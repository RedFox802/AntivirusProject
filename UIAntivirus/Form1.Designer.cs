namespace UIAntivirus
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.ListBox();
            this.btnDeleteVirus = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbPath = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnFullDeleteAll = new System.Windows.Forms.Button();
            this.txtFullResults = new System.Windows.Forms.ListBox();
            this.btnFullDelete = new System.Windows.Forms.Button();
            this.btnFullStop = new System.Windows.Forms.Button();
            this.btnFullPause = new System.Windows.Forms.Button();
            this.btnFullRestart = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.rbRemDisks = new System.Windows.Forms.RadioButton();
            this.rbOwnDIscs = new System.Windows.Forms.RadioButton();
            this.rbFullComp = new System.Windows.Forms.RadioButton();
            this.btnStartFullScan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShadule = new System.Windows.Forms.ListBox();
            this.btnShaduleCarantine = new System.Windows.Forms.Button();
            this.btnShaduleDalete = new System.Windows.Forms.Button();
            this.btnShadule = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnOpenForShadule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShadulePath = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVirCarMonitoring = new System.Windows.Forms.Button();
            this.btnVirDeleteMonitoring = new System.Windows.Forms.Button();
            this.txtMonitoringResults = new System.Windows.Forms.TextBox();
            this.txtMonitoringDirectoris = new System.Windows.Forms.ListBox();
            this.btnDeleteMonitoring = new System.Windows.Forms.Button();
            this.btnAddMonitoring = new System.Windows.Forms.Button();
            this.btnFindPathMonitoring = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPathForMonitoring = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCarantineShow = new System.Windows.Forms.Button();
            this.btnCarantineReturnAll = new System.Windows.Forms.Button();
            this.btnCarantineReturnFile = new System.Windows.Forms.Button();
            this.btnCarantineDeleteAll = new System.Windows.Forms.Button();
            this.btnCarantineDeleteFile = new System.Windows.Forms.Button();
            this.txtCarantineFiles = new System.Windows.Forms.ListBox();
            this.btnQuarantine = new System.Windows.Forms.Button();
            this.btnFullCarantine = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAll.Enabled = false;
            this.btnDeleteAll.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnDeleteAll.Location = new System.Drawing.Point(30, 202);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(209, 64);
            this.btnDeleteAll.TabIndex = 26;
            this.btnDeleteAll.Text = "Удалить все";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResults.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.txtResults.FormattingEnabled = true;
            this.txtResults.ItemHeight = 29;
            this.txtResults.Location = new System.Drawing.Point(30, 395);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(854, 294);
            this.txtResults.TabIndex = 16;
            // 
            // btnDeleteVirus
            // 
            this.btnDeleteVirus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteVirus.Enabled = false;
            this.btnDeleteVirus.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnDeleteVirus.Location = new System.Drawing.Point(30, 272);
            this.btnDeleteVirus.Name = "btnDeleteVirus";
            this.btnDeleteVirus.Size = new System.Drawing.Size(209, 64);
            this.btnDeleteVirus.TabIndex = 11;
            this.btnDeleteVirus.Text = "Удаление";
            this.btnDeleteVirus.UseVisualStyleBackColor = false;
            this.btnDeleteVirus.Visible = false;
            this.btnDeleteVirus.Click += new System.EventHandler(this.btnDeleteVirus_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStopScan.Enabled = false;
            this.btnStopScan.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopScan.Location = new System.Drawing.Point(698, 236);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(209, 64);
            this.btnStopScan.TabIndex = 15;
            this.btnStopScan.Text = "Прекращение";
            this.btnStopScan.UseVisualStyleBackColor = false;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(473, 272);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(209, 64);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Остановка";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRestart.Enabled = false;
            this.btnRestart.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(473, 202);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(209, 64);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Возобновление";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnClose1.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnClose1.Location = new System.Drawing.Point(711, 722);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(173, 64);
            this.btnClose1.TabIndex = 12;
            this.btnClose1.Text = "Закрыть";
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnChoosePath.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnChoosePath.Location = new System.Drawing.Point(30, 121);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(424, 64);
            this.btnChoosePath.TabIndex = 4;
            this.btnChoosePath.Text = "Выбрать";
            this.btnChoosePath.UseVisualStyleBackColor = false;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFile.Location = new System.Drawing.Point(555, 35);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(289, 34);
            this.rbFile.TabIndex = 6;
            this.rbFile.Text = "Сканирование файла";
            this.rbFile.UseVisualStyleBackColor = true;
            this.rbFile.CheckedChanged += new System.EventHandler(this.rbPath_CheckedChanged);
            // 
            // rbPath
            // 
            this.rbPath.AutoSize = true;
            this.rbPath.Checked = true;
            this.rbPath.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPath.Location = new System.Drawing.Point(555, 74);
            this.rbPath.Name = "rbPath";
            this.rbPath.Size = new System.Drawing.Size(285, 34);
            this.rbPath.TabIndex = 5;
            this.rbPath.TabStop = true;
            this.rbPath.Text = "Сканирование папки";
            this.rbPath.UseVisualStyleBackColor = true;
            this.rbPath.CheckedChanged += new System.EventHandler(this.rbPath_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь к сканируемому объекту :";
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnStartScan.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.Location = new System.Drawing.Point(473, 124);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(424, 61);
            this.btnStartScan.TabIndex = 1;
            this.btnStartScan.Text = "Сканирование";
            this.btnStartScan.UseVisualStyleBackColor = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPath.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.txtPath.Location = new System.Drawing.Point(30, 55);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPath.Size = new System.Drawing.Size(424, 60);
            this.txtPath.TabIndex = 2;
            // 
            // btnFullDeleteAll
            // 
            this.btnFullDeleteAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFullDeleteAll.Enabled = false;
            this.btnFullDeleteAll.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFullDeleteAll.Location = new System.Drawing.Point(710, 195);
            this.btnFullDeleteAll.Name = "btnFullDeleteAll";
            this.btnFullDeleteAll.Size = new System.Drawing.Size(199, 60);
            this.btnFullDeleteAll.TabIndex = 25;
            this.btnFullDeleteAll.Text = "Очистить";
            this.btnFullDeleteAll.UseVisualStyleBackColor = false;
            this.btnFullDeleteAll.Click += new System.EventHandler(this.btnFullDeleteAll_Click);
            // 
            // txtFullResults
            // 
            this.txtFullResults.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFullResults.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.txtFullResults.FormattingEnabled = true;
            this.txtFullResults.ItemHeight = 29;
            this.txtFullResults.Location = new System.Drawing.Point(23, 335);
            this.txtFullResults.Name = "txtFullResults";
            this.txtFullResults.Size = new System.Drawing.Size(886, 381);
            this.txtFullResults.TabIndex = 24;
            // 
            // btnFullDelete
            // 
            this.btnFullDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFullDelete.Enabled = false;
            this.btnFullDelete.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFullDelete.Location = new System.Drawing.Point(710, 263);
            this.btnFullDelete.Name = "btnFullDelete";
            this.btnFullDelete.Size = new System.Drawing.Size(199, 58);
            this.btnFullDelete.TabIndex = 19;
            this.btnFullDelete.Text = "Удалить";
            this.btnFullDelete.UseVisualStyleBackColor = false;
            this.btnFullDelete.Visible = false;
            this.btnFullDelete.Click += new System.EventHandler(this.btnFullDelete_Click);
            // 
            // btnFullStop
            // 
            this.btnFullStop.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFullStop.Enabled = false;
            this.btnFullStop.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFullStop.Location = new System.Drawing.Point(23, 263);
            this.btnFullStop.Name = "btnFullStop";
            this.btnFullStop.Size = new System.Drawing.Size(229, 57);
            this.btnFullStop.TabIndex = 23;
            this.btnFullStop.Text = "Завершить";
            this.btnFullStop.UseVisualStyleBackColor = false;
            this.btnFullStop.Click += new System.EventHandler(this.btnFullStop_Click);
            // 
            // btnFullPause
            // 
            this.btnFullPause.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFullPause.Enabled = false;
            this.btnFullPause.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFullPause.Location = new System.Drawing.Point(23, 133);
            this.btnFullPause.Name = "btnFullPause";
            this.btnFullPause.Size = new System.Drawing.Size(229, 58);
            this.btnFullPause.TabIndex = 22;
            this.btnFullPause.Text = "Приостановить";
            this.btnFullPause.UseVisualStyleBackColor = false;
            this.btnFullPause.Click += new System.EventHandler(this.btnFullPause_Click);
            // 
            // btnFullRestart
            // 
            this.btnFullRestart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFullRestart.Enabled = false;
            this.btnFullRestart.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFullRestart.Location = new System.Drawing.Point(23, 197);
            this.btnFullRestart.Name = "btnFullRestart";
            this.btnFullRestart.Size = new System.Drawing.Size(229, 60);
            this.btnFullRestart.TabIndex = 21;
            this.btnFullRestart.Text = "Продолжить";
            this.btnFullRestart.UseVisualStyleBackColor = false;
            this.btnFullRestart.Click += new System.EventHandler(this.btnFullRestart_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnClose2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnClose2.Location = new System.Drawing.Point(710, 722);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(199, 64);
            this.btnClose2.TabIndex = 20;
            this.btnClose2.Text = "Покинуть";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // rbRemDisks
            // 
            this.rbRemDisks.AutoSize = true;
            this.rbRemDisks.Font = new System.Drawing.Font("Ink Free", 12F);
            this.rbRemDisks.Location = new System.Drawing.Point(653, 84);
            this.rbRemDisks.Name = "rbRemDisks";
            this.rbRemDisks.Size = new System.Drawing.Size(222, 34);
            this.rbRemDisks.TabIndex = 18;
            this.rbRemDisks.Text = "Внешние диски";
            this.rbRemDisks.UseVisualStyleBackColor = true;
            // 
            // rbOwnDIscs
            // 
            this.rbOwnDIscs.AutoSize = true;
            this.rbOwnDIscs.Font = new System.Drawing.Font("Ink Free", 12F);
            this.rbOwnDIscs.Location = new System.Drawing.Point(653, 37);
            this.rbOwnDIscs.Name = "rbOwnDIscs";
            this.rbOwnDIscs.Size = new System.Drawing.Size(256, 34);
            this.rbOwnDIscs.TabIndex = 17;
            this.rbOwnDIscs.Text = "Встроенные диски";
            this.rbOwnDIscs.UseVisualStyleBackColor = true;
            // 
            // rbFullComp
            // 
            this.rbFullComp.AutoSize = true;
            this.rbFullComp.Checked = true;
            this.rbFullComp.Font = new System.Drawing.Font("Ink Free", 12F);
            this.rbFullComp.Location = new System.Drawing.Point(417, 37);
            this.rbFullComp.Name = "rbFullComp";
            this.rbFullComp.Size = new System.Drawing.Size(230, 34);
            this.rbFullComp.TabIndex = 16;
            this.rbFullComp.TabStop = true;
            this.rbFullComp.Text = "Весь компьютер";
            this.rbFullComp.UseVisualStyleBackColor = true;
            // 
            // btnStartFullScan
            // 
            this.btnStartFullScan.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnStartFullScan.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnStartFullScan.Location = new System.Drawing.Point(23, 49);
            this.btnStartFullScan.Name = "btnStartFullScan";
            this.btnStartFullScan.Size = new System.Drawing.Size(351, 69);
            this.btnStartFullScan.TabIndex = 3;
            this.btnStartFullScan.Text = "Сканирование";
            this.btnStartFullScan.UseVisualStyleBackColor = false;
            this.btnStartFullScan.Click += new System.EventHandler(this.btnStartFullScan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 834);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage1.Controls.Add(this.btnQuarantine);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnDeleteAll);
            this.tabPage1.Controls.Add(this.txtResults);
            this.tabPage1.Controls.Add(this.btnDeleteVirus);
            this.tabPage1.Controls.Add(this.btnStopScan);
            this.tabPage1.Controls.Add(this.btnPause);
            this.tabPage1.Controls.Add(this.btnRestart);
            this.tabPage1.Controls.Add(this.btnClose1);
            this.tabPage1.Controls.Add(this.btnChoosePath);
            this.tabPage1.Controls.Add(this.rbFile);
            this.tabPage1.Controls.Add(this.rbPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnStartScan);
            this.tabPage1.Controls.Add(this.txtPath);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 792);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выборочное сканирование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label3.Location = new System.Drawing.Point(25, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Результаты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1577, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage2.Controls.Add(this.btnFullCarantine);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnFullDeleteAll);
            this.tabPage2.Controls.Add(this.txtFullResults);
            this.tabPage2.Controls.Add(this.btnFullDelete);
            this.tabPage2.Controls.Add(this.btnFullStop);
            this.tabPage2.Controls.Add(this.btnFullPause);
            this.tabPage2.Controls.Add(this.btnFullRestart);
            this.tabPage2.Controls.Add(this.btnClose2);
            this.tabPage2.Controls.Add(this.rbRemDisks);
            this.tabPage2.Controls.Add(this.rbOwnDIscs);
            this.tabPage2.Controls.Add(this.rbFullComp);
            this.tabPage2.Controls.Add(this.btnStartFullScan);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 792);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сканирование дисков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label4.Location = new System.Drawing.Point(403, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Результаты:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtShadule);
            this.tabPage3.Controls.Add(this.btnShaduleCarantine);
            this.tabPage3.Controls.Add(this.btnShaduleDalete);
            this.tabPage3.Controls.Add(this.btnShadule);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtMinute);
            this.tabPage3.Controls.Add(this.txtHour);
            this.tabPage3.Controls.Add(this.btnOpenForShadule);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtShadulePath);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(927, 792);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сканирование по расписанию";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.Font = new System.Drawing.Font("Ink Free", 12F);
            this.button1.Location = new System.Drawing.Point(613, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 64);
            this.button1.TabIndex = 30;
            this.button1.Text = "Покинуть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label7.Location = new System.Drawing.Point(393, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "Результаты:";
            // 
            // txtShadule
            // 
            this.txtShadule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShadule.FormattingEnabled = true;
            this.txtShadule.ItemHeight = 29;
            this.txtShadule.Location = new System.Drawing.Point(27, 278);
            this.txtShadule.Name = "txtShadule";
            this.txtShadule.Size = new System.Drawing.Size(851, 381);
            this.txtShadule.TabIndex = 27;
            // 
            // btnShaduleCarantine
            // 
            this.btnShaduleCarantine.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShaduleCarantine.Enabled = false;
            this.btnShaduleCarantine.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnShaduleCarantine.Location = new System.Drawing.Point(27, 715);
            this.btnShaduleCarantine.Name = "btnShaduleCarantine";
            this.btnShaduleCarantine.Size = new System.Drawing.Size(265, 58);
            this.btnShaduleCarantine.TabIndex = 26;
            this.btnShaduleCarantine.Text = "Карантин";
            this.btnShaduleCarantine.UseVisualStyleBackColor = false;
            this.btnShaduleCarantine.Click += new System.EventHandler(this.btnShaduleCarantine_Click);
            // 
            // btnShaduleDalete
            // 
            this.btnShaduleDalete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShaduleDalete.Enabled = false;
            this.btnShaduleDalete.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnShaduleDalete.Location = new System.Drawing.Point(298, 715);
            this.btnShaduleDalete.Name = "btnShaduleDalete";
            this.btnShaduleDalete.Size = new System.Drawing.Size(265, 58);
            this.btnShaduleDalete.TabIndex = 25;
            this.btnShaduleDalete.Text = "Уничтожение";
            this.btnShaduleDalete.UseVisualStyleBackColor = false;
            this.btnShaduleDalete.Click += new System.EventHandler(this.btnShaduleDalete_Click);
            // 
            // btnShadule
            // 
            this.btnShadule.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnShadule.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnShadule.Location = new System.Drawing.Point(544, 136);
            this.btnShadule.Name = "btnShadule";
            this.btnShadule.Size = new System.Drawing.Size(331, 68);
            this.btnShadule.TabIndex = 24;
            this.btnShadule.Text = "Задать время";
            this.btnShadule.UseVisualStyleBackColor = false;
            this.btnShadule.Click += new System.EventHandler(this.btnShadule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label5.Location = new System.Drawing.Point(661, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Время :";
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.SystemColors.Window;
            this.txtMinute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinute.Location = new System.Drawing.Point(715, 64);
            this.txtMinute.Multiline = true;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(160, 57);
            this.txtMinute.TabIndex = 22;
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.SystemColors.Window;
            this.txtHour.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHour.Location = new System.Drawing.Point(549, 64);
            this.txtHour.Multiline = true;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(160, 57);
            this.txtHour.TabIndex = 21;
            // 
            // btnOpenForShadule
            // 
            this.btnOpenForShadule.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnOpenForShadule.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnOpenForShadule.Location = new System.Drawing.Point(24, 136);
            this.btnOpenForShadule.Name = "btnOpenForShadule";
            this.btnOpenForShadule.Size = new System.Drawing.Size(412, 68);
            this.btnOpenForShadule.TabIndex = 20;
            this.btnOpenForShadule.Text = "Выбрать";
            this.btnOpenForShadule.UseVisualStyleBackColor = false;
            this.btnOpenForShadule.Click += new System.EventHandler(this.btnOpenForShadule_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label6.Location = new System.Drawing.Point(195, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Папка :";
            // 
            // txtShadulePath
            // 
            this.txtShadulePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtShadulePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShadulePath.Location = new System.Drawing.Point(24, 56);
            this.txtShadulePath.Multiline = true;
            this.txtShadulePath.Name = "txtShadulePath";
            this.txtShadulePath.ReadOnly = true;
            this.txtShadulePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShadulePath.Size = new System.Drawing.Size(412, 57);
            this.txtShadulePath.TabIndex = 18;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.btnVirCarMonitoring);
            this.tabPage4.Controls.Add(this.btnVirDeleteMonitoring);
            this.tabPage4.Controls.Add(this.txtMonitoringResults);
            this.tabPage4.Controls.Add(this.txtMonitoringDirectoris);
            this.tabPage4.Controls.Add(this.btnDeleteMonitoring);
            this.tabPage4.Controls.Add(this.btnAddMonitoring);
            this.tabPage4.Controls.Add(this.btnFindPathMonitoring);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtPathForMonitoring);
            this.tabPage4.Font = new System.Drawing.Font("Ink Free", 12F);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(927, 792);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Мониторинг";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label10.Location = new System.Drawing.Point(387, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 30);
            this.label10.TabIndex = 35;
            this.label10.Text = "Результаты :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumOrchid;
            this.button2.Font = new System.Drawing.Font("Ink Free", 12F);
            this.button2.Location = new System.Drawing.Point(646, 717);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 64);
            this.button2.TabIndex = 34;
            this.button2.Text = "Покинуть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label9.Location = new System.Drawing.Point(387, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 30);
            this.label9.TabIndex = 33;
            this.label9.Text = "Добавленные папки :";
            // 
            // btnVirCarMonitoring
            // 
            this.btnVirCarMonitoring.BackColor = System.Drawing.Color.LightGray;
            this.btnVirCarMonitoring.Enabled = false;
            this.btnVirCarMonitoring.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnVirCarMonitoring.Location = new System.Drawing.Point(292, 719);
            this.btnVirCarMonitoring.Name = "btnVirCarMonitoring";
            this.btnVirCarMonitoring.Size = new System.Drawing.Size(265, 58);
            this.btnVirCarMonitoring.TabIndex = 32;
            this.btnVirCarMonitoring.Text = "Карантин";
            this.btnVirCarMonitoring.UseVisualStyleBackColor = false;
            this.btnVirCarMonitoring.Click += new System.EventHandler(this.btnVirCarMonitoring_Click);
            // 
            // btnVirDeleteMonitoring
            // 
            this.btnVirDeleteMonitoring.BackColor = System.Drawing.Color.LightGray;
            this.btnVirDeleteMonitoring.Enabled = false;
            this.btnVirDeleteMonitoring.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnVirDeleteMonitoring.Location = new System.Drawing.Point(21, 719);
            this.btnVirDeleteMonitoring.Name = "btnVirDeleteMonitoring";
            this.btnVirDeleteMonitoring.Size = new System.Drawing.Size(265, 58);
            this.btnVirDeleteMonitoring.TabIndex = 31;
            this.btnVirDeleteMonitoring.Text = "Уничтожение";
            this.btnVirDeleteMonitoring.UseVisualStyleBackColor = false;
            this.btnVirDeleteMonitoring.Click += new System.EventHandler(this.btnVirDeleteMonitoring_Click);
            // 
            // txtMonitoringResults
            // 
            this.txtMonitoringResults.BackColor = System.Drawing.SystemColors.Window;
            this.txtMonitoringResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMonitoringResults.Location = new System.Drawing.Point(21, 377);
            this.txtMonitoringResults.Multiline = true;
            this.txtMonitoringResults.Name = "txtMonitoringResults";
            this.txtMonitoringResults.ReadOnly = true;
            this.txtMonitoringResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMonitoringResults.Size = new System.Drawing.Size(890, 336);
            this.txtMonitoringResults.TabIndex = 30;
            this.txtMonitoringResults.TextChanged += new System.EventHandler(this.txtMonitoringResults_TextChanged);
            // 
            // txtMonitoringDirectoris
            // 
            this.txtMonitoringDirectoris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMonitoringDirectoris.FormattingEnabled = true;
            this.txtMonitoringDirectoris.HorizontalScrollbar = true;
            this.txtMonitoringDirectoris.ItemHeight = 29;
            this.txtMonitoringDirectoris.Location = new System.Drawing.Point(392, 47);
            this.txtMonitoringDirectoris.Name = "txtMonitoringDirectoris";
            this.txtMonitoringDirectoris.Size = new System.Drawing.Size(519, 294);
            this.txtMonitoringDirectoris.TabIndex = 29;
            // 
            // btnDeleteMonitoring
            // 
            this.btnDeleteMonitoring.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnDeleteMonitoring.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnDeleteMonitoring.Location = new System.Drawing.Point(21, 269);
            this.btnDeleteMonitoring.Name = "btnDeleteMonitoring";
            this.btnDeleteMonitoring.Size = new System.Drawing.Size(346, 58);
            this.btnDeleteMonitoring.TabIndex = 28;
            this.btnDeleteMonitoring.Text = "Удалить";
            this.btnDeleteMonitoring.UseVisualStyleBackColor = false;
            this.btnDeleteMonitoring.Click += new System.EventHandler(this.btnDeleteMonitoring_Click);
            // 
            // btnAddMonitoring
            // 
            this.btnAddMonitoring.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAddMonitoring.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnAddMonitoring.Location = new System.Drawing.Point(21, 197);
            this.btnAddMonitoring.Name = "btnAddMonitoring";
            this.btnAddMonitoring.Size = new System.Drawing.Size(346, 58);
            this.btnAddMonitoring.TabIndex = 27;
            this.btnAddMonitoring.Text = "Добавить";
            this.btnAddMonitoring.UseVisualStyleBackColor = false;
            this.btnAddMonitoring.Click += new System.EventHandler(this.btnAddMonitoring_Click);
            // 
            // btnFindPathMonitoring
            // 
            this.btnFindPathMonitoring.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnFindPathMonitoring.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFindPathMonitoring.Location = new System.Drawing.Point(21, 123);
            this.btnFindPathMonitoring.Name = "btnFindPathMonitoring";
            this.btnFindPathMonitoring.Size = new System.Drawing.Size(346, 57);
            this.btnFindPathMonitoring.TabIndex = 26;
            this.btnFindPathMonitoring.Text = "Выбрать";
            this.btnFindPathMonitoring.UseVisualStyleBackColor = false;
            this.btnFindPathMonitoring.Click += new System.EventHandler(this.btnFindPathMonitoring_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 30);
            this.label8.TabIndex = 25;
            this.label8.Text = "Выберите папку :";
            // 
            // txtPathForMonitoring
            // 
            this.txtPathForMonitoring.BackColor = System.Drawing.SystemColors.Window;
            this.txtPathForMonitoring.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPathForMonitoring.Location = new System.Drawing.Point(21, 47);
            this.txtPathForMonitoring.Multiline = true;
            this.txtPathForMonitoring.Name = "txtPathForMonitoring";
            this.txtPathForMonitoring.ReadOnly = true;
            this.txtPathForMonitoring.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPathForMonitoring.Size = new System.Drawing.Size(346, 57);
            this.txtPathForMonitoring.TabIndex = 24;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.btnCarantineShow);
            this.tabPage5.Controls.Add(this.btnCarantineReturnAll);
            this.tabPage5.Controls.Add(this.btnCarantineReturnFile);
            this.tabPage5.Controls.Add(this.btnCarantineDeleteAll);
            this.tabPage5.Controls.Add(this.btnCarantineDeleteFile);
            this.tabPage5.Controls.Add(this.txtCarantineFiles);
            this.tabPage5.Font = new System.Drawing.Font("Ink Free", 12F);
            this.tabPage5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(927, 792);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Карантин";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumOrchid;
            this.button3.Font = new System.Drawing.Font("Ink Free", 12F);
            this.button3.Location = new System.Drawing.Point(618, 721);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 64);
            this.button3.TabIndex = 35;
            this.button3.Text = "Покинуть";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 12F);
            this.label11.Location = new System.Drawing.Point(38, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "Файлы в карантине :";
            // 
            // btnCarantineShow
            // 
            this.btnCarantineShow.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCarantineShow.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnCarantineShow.Location = new System.Drawing.Point(44, 574);
            this.btnCarantineShow.Name = "btnCarantineShow";
            this.btnCarantineShow.Size = new System.Drawing.Size(542, 71);
            this.btnCarantineShow.TabIndex = 18;
            this.btnCarantineShow.Text = "Просмотр карантина";
            this.btnCarantineShow.UseVisualStyleBackColor = false;
            this.btnCarantineShow.Click += new System.EventHandler(this.btnCarantineShow_Click);
            // 
            // btnCarantineReturnAll
            // 
            this.btnCarantineReturnAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCarantineReturnAll.Enabled = false;
            this.btnCarantineReturnAll.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnCarantineReturnAll.Location = new System.Drawing.Point(44, 721);
            this.btnCarantineReturnAll.Name = "btnCarantineReturnAll";
            this.btnCarantineReturnAll.Size = new System.Drawing.Size(265, 64);
            this.btnCarantineReturnAll.TabIndex = 17;
            this.btnCarantineReturnAll.Text = "Восстановить все";
            this.btnCarantineReturnAll.UseVisualStyleBackColor = false;
            this.btnCarantineReturnAll.Click += new System.EventHandler(this.btnCarantineReturnAll_Click);
            // 
            // btnCarantineReturnFile
            // 
            this.btnCarantineReturnFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCarantineReturnFile.Enabled = false;
            this.btnCarantineReturnFile.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnCarantineReturnFile.Location = new System.Drawing.Point(44, 650);
            this.btnCarantineReturnFile.Name = "btnCarantineReturnFile";
            this.btnCarantineReturnFile.Size = new System.Drawing.Size(265, 65);
            this.btnCarantineReturnFile.TabIndex = 16;
            this.btnCarantineReturnFile.Text = "Восстановить";
            this.btnCarantineReturnFile.UseVisualStyleBackColor = false;
            this.btnCarantineReturnFile.Click += new System.EventHandler(this.btnCarantineReturnFile_Click);
            // 
            // btnCarantineDeleteAll
            // 
            this.btnCarantineDeleteAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCarantineDeleteAll.Enabled = false;
            this.btnCarantineDeleteAll.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnCarantineDeleteAll.Location = new System.Drawing.Point(321, 721);
            this.btnCarantineDeleteAll.Name = "btnCarantineDeleteAll";
            this.btnCarantineDeleteAll.Size = new System.Drawing.Size(265, 64);
            this.btnCarantineDeleteAll.TabIndex = 15;
            this.btnCarantineDeleteAll.Text = "Удалить все";
            this.btnCarantineDeleteAll.UseVisualStyleBackColor = false;
            this.btnCarantineDeleteAll.Click += new System.EventHandler(this.btnCarantineDeleteAll_Click);
            // 
            // btnCarantineDeleteFile
            // 
            this.btnCarantineDeleteFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCarantineDeleteFile.Enabled = false;
            this.btnCarantineDeleteFile.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnCarantineDeleteFile.Location = new System.Drawing.Point(321, 650);
            this.btnCarantineDeleteFile.Name = "btnCarantineDeleteFile";
            this.btnCarantineDeleteFile.Size = new System.Drawing.Size(265, 65);
            this.btnCarantineDeleteFile.TabIndex = 14;
            this.btnCarantineDeleteFile.Text = "Удалить";
            this.btnCarantineDeleteFile.UseVisualStyleBackColor = false;
            this.btnCarantineDeleteFile.Click += new System.EventHandler(this.btnCarantineDeleteFile_Click);
            // 
            // txtCarantineFiles
            // 
            this.txtCarantineFiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCarantineFiles.FormattingEnabled = true;
            this.txtCarantineFiles.HorizontalScrollbar = true;
            this.txtCarantineFiles.ItemHeight = 29;
            this.txtCarantineFiles.Location = new System.Drawing.Point(43, 80);
            this.txtCarantineFiles.Name = "txtCarantineFiles";
            this.txtCarantineFiles.Size = new System.Drawing.Size(840, 468);
            this.txtCarantineFiles.TabIndex = 9;
            // 
            // btnQuarantine
            // 
            this.btnQuarantine.BackColor = System.Drawing.Color.Gainsboro;
            this.btnQuarantine.Enabled = false;
            this.btnQuarantine.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnQuarantine.Location = new System.Drawing.Point(245, 202);
            this.btnQuarantine.Name = "btnQuarantine";
            this.btnQuarantine.Size = new System.Drawing.Size(209, 64);
            this.btnQuarantine.TabIndex = 28;
            this.btnQuarantine.Text = "Карантин";
            this.btnQuarantine.UseVisualStyleBackColor = false;
            this.btnQuarantine.Click += new System.EventHandler(this.btnQuarantine_Click);
            // 
            // btnFullCarantine
            // 
            this.btnFullCarantine.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFullCarantine.Enabled = false;
            this.btnFullCarantine.Font = new System.Drawing.Font("Ink Free", 12F);
            this.btnFullCarantine.Location = new System.Drawing.Point(505, 197);
            this.btnFullCarantine.Name = "btnFullCarantine";
            this.btnFullCarantine.Size = new System.Drawing.Size(199, 58);
            this.btnFullCarantine.TabIndex = 29;
            this.btnFullCarantine.Text = "Карантин";
            this.btnFullCarantine.UseVisualStyleBackColor = false;
            this.btnFullCarantine.Click += new System.EventHandler(this.btnFullCarantine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(946, 844);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Антивирус";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RadioButton rbRemDisks;
        private System.Windows.Forms.RadioButton rbOwnDIscs;
        private System.Windows.Forms.RadioButton rbFullComp;
        private System.Windows.Forms.Button btnStartFullScan;
        private System.Windows.Forms.Button btnDeleteVirus;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnFullDelete;
        private System.Windows.Forms.Button btnFullStop;
        private System.Windows.Forms.Button btnFullPause;
        private System.Windows.Forms.Button btnFullRestart;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.ListBox txtResults;
        private System.Windows.Forms.ListBox txtFullResults;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnFullDeleteAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox txtShadule;
        private System.Windows.Forms.Button btnShaduleCarantine;
        private System.Windows.Forms.Button btnShaduleDalete;
        private System.Windows.Forms.Button btnShadule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Button btnOpenForShadule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShadulePath;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVirCarMonitoring;
        private System.Windows.Forms.Button btnVirDeleteMonitoring;
        public System.Windows.Forms.TextBox txtMonitoringResults;
        private System.Windows.Forms.ListBox txtMonitoringDirectoris;
        private System.Windows.Forms.Button btnDeleteMonitoring;
        private System.Windows.Forms.Button btnAddMonitoring;
        private System.Windows.Forms.Button btnFindPathMonitoring;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPathForMonitoring;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCarantineShow;
        private System.Windows.Forms.Button btnCarantineReturnAll;
        private System.Windows.Forms.Button btnCarantineReturnFile;
        private System.Windows.Forms.Button btnCarantineDeleteAll;
        private System.Windows.Forms.Button btnCarantineDeleteFile;
        private System.Windows.Forms.ListBox txtCarantineFiles;
        private System.Windows.Forms.Button btnQuarantine;
        private System.Windows.Forms.Button btnFullCarantine;
    }
}

