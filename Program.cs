﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Oraycn.DesktopMixedAudioRecordDemo
{
    /*
    * 本demo采用的是 语音视频采集组件MCapture 和 语音视频录制组件MFile 的免费版本。若想获取MCapture、MFile其它版本，请联系 www.oraycn.com 。
    * 
    */
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            Application.Run(new Form1());
        }
    }
}
