﻿using System;
using System.Runtime.InteropServices;

namespace Antivirus.Scans
{
    class RecycleBin
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct SHFILEOPSTRUCT
        {
            public IntPtr hWnd;
            public UInt32 wFunc;
            public IntPtr pFrom;
            public IntPtr pTo;
            public UInt16 fFlags;
            public Int32 fAnyOperationsAborted;
            public IntPtr hNameMappings;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszProgressTitle;
        }
        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int SHFileOperation(ref SHFILEOPSTRUCT lpFileOp);
        [STAThread]
        public int Recycle(string strPath)
        {
            SHFILEOPSTRUCT FileOp = new SHFILEOPSTRUCT
            {
                hWnd = IntPtr.Zero,
                // удаляем файл / папку
                wFunc = (uint)0x0003,
                pFrom = Marshal.StringToHGlobalUni(strPath),
                pTo = IntPtr.Zero,
                // без подтверждения пользователя
                fFlags = (ushort)(0x0004 | 0x0040 | 0x0010),
                lpszProgressTitle = "",
                fAnyOperationsAborted = 0,
                hNameMappings = IntPtr.Zero
            };

            return SHFileOperation(ref FileOp);
        }
    }
}