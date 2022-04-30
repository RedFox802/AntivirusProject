using AntivirusLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIAntivirus.MessageProcessing;
using UIAntivirus.ServiceInteraction;
using UIAntivirus.Shadule;

namespace UIAntivirus
{

    public partial class Form1 : Form
    {

        #region General

        private Thread monitoringThread;
        public Form1()
        {
            InitializeComponent();

            //Запуск антивируса если он еще не запущен
            MyServiceProvider.StartAntivirus();
        }

        private void MonitoringAnswers()
        {
            while (true)
            {
                String message = MonitoringSocket.GetAnswer();
                txtMonitoringResults.Text += message + "\r\n";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ограничение запуска одно приложение для одного юзера
            string sid = WindowsIdentity.GetCurrent().User.Value;  
            bool mutexWasCreated;
            Mutex m = new Mutex(true, sid, out mutexWasCreated);

            if (!mutexWasCreated)
            {
                MessageBox.Show("Не пытайтесь подключиться еще раз с одного пользователя!");
                this.Close();
            }
            else
            {
                ChooseScanSocket.StartSocket();
                DisksScanSocket.StartSocket();
                ShaduleSocket.StartSocket();
                MonitoringSocket.StartSocket();
                Thread th = new Thread(MonitoringAnswers);
                th.Start();
                monitoringThread = th;
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            ChooseScanSocket.CloseSocket();
            DisksScanSocket.CloseSocket();
            this.Close();
        }

        private void BtnChange(Button btn, Color color, bool enabl)
        {
            btn.Enabled = enabl;
            btn.BackColor = color;
        }

        private void rbPath_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Text = "";
        }

        #endregion

        #region SelectiveScan

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = "c:\\";
                    ofd.Filter = MessagesData.filterExe;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        txtPath.Text = ofd.FileName;
                    }
                }
            }

            if (rbPath.Checked)
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        txtPath.Text = fbd.SelectedPath;
                    }
                }
            }
        }


        private async Task StartCheckAsunc()
        {
            if (txtPath.Text == "") MessageBox.Show("Сначала выберите путь!");
            else
            {
                #region Взаимодействие с другими элементами
                txtResults.Items.Clear();
                BtnChange(btnPause, Color.MediumOrchid, true);
                BtnChange(btnStopScan, Color.MediumOrchid, true);
                BtnChange(btnStartScan, Color.Gainsboro, false);
                BtnChange(btnDeleteAll , Color.Gainsboro, false);
                BtnChange(btnDeleteVirus, Color.Gainsboro, false);
                BtnChange(btnQuarantine, Color.Gainsboro, false);
                #endregion

                String command = rbFile.Checked ? MessagesData.scanFile : MessagesData.scanPath;
                String path = txtPath.Text.Replace(@"\", @"\\\");

                String myAnswer = await Task.Run(() => CommandsHandler.GetCommand(command, path));
                if (myAnswer == MessagesData.resultNone) MessageBox.Show(MessagesData.resultNone);
                else if (myAnswer == MessagesData.resultStop) { }
                else txtResults.Items.AddRange(myAnswer.Split('#'));

                #region Взаимодействие с другими элементами
                if (txtResults.Items.Count>0)
                {
                    BtnChange(btnDeleteVirus, Color.MediumOrchid, true);
                    BtnChange(btnDeleteAll, Color.MediumOrchid, true);
                    BtnChange(btnQuarantine, Color.MediumOrchid, true);
                }
                else
                {
                    BtnChange(btnDeleteVirus, Color.Gainsboro, false);
                    BtnChange(btnDeleteAll, Color.Gainsboro, false);
                    BtnChange(btnQuarantine, Color.Gainsboro, false);
                }

                BtnChange(btnPause, Color.Gainsboro, false);
                BtnChange(btnRestart, Color.Gainsboro, false);
                BtnChange(btnStopScan, Color.Gainsboro, false);
                BtnChange(btnStartScan, Color.MediumOrchid, true);
                #endregion
            }
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            StartCheckAsunc();
        }

        private void btnQuarantine_Click(object sender, EventArgs e)
        {
            DeleteOrCarantine(MessagesData.carantine, btnDeleteVirus, btnQuarantine,btnDeleteAll);
            txtResults.Items.Clear();
        }

        private async Task PauseAsunc(Button btn1, Button btn2, Button btn3,String command)
        {
            await Task.Run(() => CommandsHandler.GetCommand(command));

            BtnChange(btn1, Color.MediumOrchid, true);
            BtnChange(btn2, Color.Gainsboro, false);
            BtnChange(btn3, Color.Gainsboro, false);
            MessageBox.Show("Сканирование приостановлено!");
        }

        private async Task RestartAsunc(Button btn1, Button btn2, Button btn3, String command)
        {
            await Task.Run(() => CommandsHandler.GetCommand(command));

            BtnChange(btn1, Color.Gainsboro, false);
            BtnChange(btn2, Color.MediumOrchid, true);
            BtnChange(btn3, Color.MediumOrchid, true);
            MessageBox.Show("Сканирование возобновлено!");
        }

        private async Task StopAsunc(Button btn1, Button btn2, Button btn3, String command)
        {
            await Task.Run(() => CommandsHandler.GetCommand(command));

            BtnChange(btn1, Color.Gainsboro, false);
            BtnChange(btn2, Color.Gainsboro, false);
            BtnChange(btn3, Color.Gainsboro, false);
            MessageBox.Show("Сканирование окончательно остановлено!");
        }

        private async Task DeleteVirus(Button btn, Button btn2, ListBox lb)
        {
            object selectedPath = lb.SelectedItem;
            String path = selectedPath.ToString();
            MessageBox.Show(CommandsHandler.GetCommand(MessagesData.delete,path));
            lb.Items.Remove(selectedPath);

            if (lb.Items.Count > 0)
            {
                BtnChange(btn, Color.MediumOrchid, true);
                BtnChange(btn2, Color.MediumOrchid, true);
            }
            else
            {
                BtnChange(btn, Color.Gainsboro, false);
                BtnChange(btn2, Color.Gainsboro, false);
            }
        }

        private async Task DeleteViruses(Button btn,Button btn2, ListBox lb)
        {
            MessageBox.Show(CommandsHandler.GetCommand(MessagesData.deleteAll));
            BtnChange(btn, Color.Gainsboro, false);
            BtnChange(btn2, Color.Gainsboro, false);
            lb.Items.Clear();  
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseAsunc(btnRestart, btnPause, btnStopScan,MessagesData.scanPause);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartAsunc(btnRestart, btnPause, btnStopScan, MessagesData.scanContinue);
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            StopAsunc(btnRestart, btnPause, btnStopScan, MessagesData.scanStop);
        }

        private void btnDeleteVirus_Click(object sender, EventArgs e)
        {
            DeleteVirus(btnDeleteVirus,btnDeleteAll, txtResults);
        }


        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteViruses(btnDeleteVirus,btnDeleteAll, txtResults);
        }

        #endregion

        #region DiscsScan


        private async Task FullCheckAsunc()
        {
            #region Взаимодействие с другими элементами
            txtFullResults.Items.Clear();
            BtnChange(btnFullPause, Color.MediumOrchid, true);
            BtnChange(btnFullStop, Color.MediumOrchid, true);
            BtnChange(btnStartFullScan, Color.Gainsboro, false);
            BtnChange(btnFullDelete , Color.Gainsboro, false);
            BtnChange(btnFullDeleteAll , Color.Gainsboro, false);
            BtnChange(btnFullCarantine , Color.Gainsboro, false);
            #endregion

            String command = MessagesData.scanFull;
            if (rbFullComp.Checked) command += "#" + MessagesData.fullComp;
            else if (rbOwnDIscs.Checked) command += "#" + MessagesData.fullOwn;
            else if (rbRemDisks.Checked) command += "#" + MessagesData.fullRem;


            String myAnswer = await Task.Run(() => CommandsHandler.GetCommand(command));
            if (myAnswer == MessagesData.resultNoDiscs) MessageBox.Show(MessagesData.resultNoDiscs);
            else if (myAnswer == MessagesData.resultNone) MessageBox.Show(MessagesData.resultNone);
            else if (myAnswer == MessagesData.resultStop) { }
            else txtFullResults.Items.AddRange(myAnswer.Split('#'));

            #region Кнопки
            if (txtFullResults.Items.Count>0)
            {
                BtnChange(btnFullDelete, Color.MediumOrchid, true);
                BtnChange(btnFullDeleteAll, Color.MediumOrchid, true);
                BtnChange(btnFullCarantine, Color.MediumOrchid, true);
            }
            else
            {
                BtnChange(btnFullDelete, Color.Gainsboro, false);
                BtnChange(btnFullDeleteAll, Color.Gainsboro, false);
                BtnChange(btnFullCarantine, Color.Gainsboro, false);
            }

            BtnChange(btnFullPause, Color.Gainsboro, false);
            BtnChange(btnFullRestart, Color.Gainsboro, false);
            BtnChange(btnFullStop, Color.Gainsboro, false);
            BtnChange(btnStartFullScan, Color.MediumOrchid, true);
            #endregion
        }

        private void btnFullCarantine_Click(object sender, EventArgs e)
        {
            DeleteOrCarantine(MessagesData.carantine, btnFullDelete, btnFullCarantine, btnFullDeleteAll);
            txtFullResults.Items.Clear();
        }

        private void btnStartFullScan_Click(object sender, EventArgs e)
        {
            FullCheckAsunc();
        }

        private void btnFullPause_Click(object sender, EventArgs e)
        {
            PauseAsunc(btnFullRestart, btnFullPause, btnFullStop, MessagesData.scanFullPause);
        }

        private void btnFullRestart_Click(object sender, EventArgs e)
        {
            RestartAsunc(btnFullRestart, btnFullPause, btnFullStop, MessagesData.scanFullContinue);
        }

        private void btnFullDelete_Click(object sender, EventArgs e)
        {
            DeleteVirus(btnFullDelete,btnFullDeleteAll,txtFullResults);
        }

        private void btnFullStop_Click(object sender, EventArgs e)
        {
            StopAsunc(btnFullRestart, btnFullPause, btnFullStop, MessagesData.scanFullStop);
        }


        private void btnFullDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteViruses(btnFullDelete, btnFullDeleteAll, txtFullResults);
        }

        #endregion

        #region  Shadule

        private void btnOpenForShadule_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtShadulePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnShadule_Click(object sender, EventArgs e)
        {
            Shadule();
        }
        private async Task Shadule()
        {
            if (txtShadulePath.Text == "" || txtHour.Text == "" || txtMinute.Text == "") MessageBox.Show("Заполните все данные");
            else
            {
                txtShadule.Items.Clear();

                String path = txtShadulePath.Text.Replace(@"\", @"\\\");
                String command = path + "#" + txtHour.Text + "#" + txtMinute.Text;


                String myAnswer = await Task.Run(() => ShaduleHandler.SentCommand(command));

                txtShadule.Items.AddRange(myAnswer.Split('#'));

                #region Кнопки
                if (txtShadule.Items.Count > 0)
                {
                    BtnChange(btnShaduleDalete, Color.MediumOrchid, true);
                    BtnChange(btnShaduleCarantine, Color.MediumOrchid, true);
                }
                else
                {
                    BtnChange(btnShaduleDalete, Color.Gainsboro, false);
                    BtnChange(btnShaduleCarantine, Color.Gainsboro, false);
                }
                #endregion
            }
        }

        private void btnShaduleCarantine_Click(object sender, EventArgs e)
        {
            DeleteOrCarantine(MessagesData.carantine, btnShaduleDalete, btnShaduleCarantine, btnShaduleDalete);
            txtShadule.Items.Clear();
        }

        private void btnShaduleDalete_Click(object sender, EventArgs e)
        {
            DeleteOrCarantine(MessagesData.delete, btnShaduleDalete, btnShaduleCarantine, btnShaduleDalete);
            txtShadule.Items.Clear();
        }

        #endregion

        #region Monitoring
        private void btnFindPathMonitoring_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPathForMonitoring.Text = fbd.SelectedPath;
                }
            }
        }

        private void DeleteOrCarantine(String operation, Button btn, Button btn2,Button btn3)
        {
            CommandsHandler.GetCommand(operation);
            MessageBox.Show("Выполнено!");
            BtnChange(btn, Color.Gainsboro, false);
            BtnChange(btn2, Color.Gainsboro, false);
            BtnChange(btn3, Color.Gainsboro, false);
        }

        private async Task AddMonitoring()
        {
            String path = txtPathForMonitoring.Text;

            if (txtMonitoringDirectoris.Items.Contains(path)) MessageBox.Show("Эта папка уже добавлена к мониторингу!");
            else
            {
                MonitoringSocket.SentMessage(MessagesData.monitoringAdd + "#" + path);
                txtMonitoringDirectoris.Items.Add(path);
            }
        }

        private void btnAddMonitoring_Click(object sender, EventArgs e)
        {
            if (txtPathForMonitoring.Text != "")
            {
                AddMonitoring();
            }
            else MessageBox.Show("Выберите папку!");
        }

        private async Task DeleteMonitoring()
        {
            int Index = txtMonitoringDirectoris.SelectedIndex;
            String path = txtMonitoringDirectoris.Items[Index].ToString();

            MonitoringSocket.SentMessage(MessagesData.monitoringDelete + "#" + path);
            MessageBox.Show(MessagesData.monitoringDelete + "#" + path);
            txtMonitoringDirectoris.Items.RemoveAt(Index);
        }

        private void btnDeleteMonitoring_Click(object sender, EventArgs e)
        {
            DeleteMonitoring();
        }

        private void btnVirCarMonitoring_Click(object sender, EventArgs e)
        {
            DeleteOrCarantine(MessagesData.carantine, btnVirDeleteMonitoring, btnVirCarMonitoring, btnVirDeleteMonitoring);
            txtMonitoringResults.Text = "";
        }

        private void btnVirDeleteMonitoring_Click(object sender, EventArgs e)
        {
            DeleteOrCarantine(MessagesData.delete, btnVirDeleteMonitoring, btnVirCarMonitoring, btnVirDeleteMonitoring);
            txtMonitoringResults.Text = "";
        }


        private void txtMonitoringResults_TextChanged(object sender, EventArgs e)
        {
            if (txtMonitoringResults.Text != "")
            {
                BtnChange(btnVirDeleteMonitoring, Color.PowderBlue, true);
                BtnChange(btnVirCarMonitoring, Color.PowderBlue, true);
            }
            else
            {
                BtnChange(btnVirDeleteMonitoring, Color.Gainsboro, false);
                BtnChange(btnVirCarMonitoring, Color.Gainsboro, false);
            }
        }
        #endregion

        #region Carantine

        private void ChangeCarantineBtn()
        {
            if (txtCarantineFiles.Items.Count == 0)
            {
                BtnChange(btnCarantineDeleteFile, Color.Gainsboro, false);
                BtnChange(btnCarantineDeleteAll, Color.Gainsboro, false);
                BtnChange(btnCarantineReturnFile, Color.Gainsboro, false);
                BtnChange(btnCarantineReturnAll, Color.Gainsboro, false);
            }
            else
            {
                BtnChange(btnCarantineDeleteFile, Color.MediumOrchid, true);
                BtnChange(btnCarantineDeleteAll, Color.MediumOrchid, true);
                BtnChange(btnCarantineReturnFile, Color.MediumOrchid, true);
                BtnChange(btnCarantineReturnAll, Color.MediumOrchid, true);
            }
        }

        List<String> CarantineList = new List<String>();
        private void btnCarantineShow_Click(object sender, EventArgs e)
        {
            String CarantineFiles = CommandsHandler.GetCommand(MessagesData.carantineShow);

            if (CarantineFiles != "None")
            {
                String[] array = CarantineFiles.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                CarantineList.AddRange(array);

                foreach (var item in CarantineList)
                {
                    var Info = new FileInfo(item);
                    txtCarantineFiles.Items.Add($"Файл: {Info.Name} Расположение до карантина: {Info.DirectoryName}");
                }
            }
            else MessageBox.Show("В данный момент карантин пуст");

            ChangeCarantineBtn();
        }

        private void DeleteOrReturn(String operation)
        {
            int IndexForReturn = txtCarantineFiles.SelectedIndex;
            String CommandResult = CommandsHandler.GetCommand(operation, CarantineList[IndexForReturn]);

            MessageBox.Show(CommandResult);
            txtCarantineFiles.Items.RemoveAt(IndexForReturn);
            CarantineList.RemoveAt(IndexForReturn);
            ChangeCarantineBtn();
        }


        private void DeleteOrReturnAll(String operation)
        {
            String CommandResult = CommandsHandler.GetCommand(operation);
            MessageBox.Show(CommandResult);

            txtCarantineFiles.Items.Clear();
            CarantineList.Clear();
            ChangeCarantineBtn();
        }

        private void btnCarantineReturnFile_Click(object sender, EventArgs e)
        {
            DeleteOrReturn(MessagesData.carantineRecoverOne);
        }

        private void btnCarantineReturnAll_Click(object sender, EventArgs e)
        {
            DeleteOrReturnAll(MessagesData.carantineRecoverAll);
        }

        private void btnCarantineDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteOrReturn(MessagesData.carantineDeleteOne);
        }

        private void btnCarantineDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteOrReturnAll(MessagesData.carantineDeleteAll);
        }




        #endregion


    }
}
