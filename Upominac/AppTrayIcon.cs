using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Upominac.Properties;
using System.Windows.Forms;



namespace Upominac
{
    public class AppTrayIcon : ApplicationContext
    {
        private NotifyIcon TrayIcon;
        public static bool TrayExited {  get; private set; } = false;
        


        public AppTrayIcon()
        {
            //Initialize Tray Icon
            TrayIcon = new NotifyIcon()
            {   
                Icon = Resources.AppIcon.birthdayCake_icon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items = { new ToolStripMenuItem("Exit", null, Exit) }
                },
                Visible = AppOptions.StartTray//true

            };
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;
        }
        
        public void TrayIcon_DoubleClick(object? sender, EventArgs e)
        {
            TrayIcon.Visible = false;
            Application.ExitThread();
            
        }

        public void Exit(object? sender, EventArgs e)
        {
            TrayIcon.Visible = false;
            TrayExited = true;
            Application.Exit();
        }
    }   
}

