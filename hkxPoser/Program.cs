using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;    // Add reference to Microsoft.VisualBasic

namespace hkxPoser
{
    class Program : WindowsFormsApplicationBase
    {
        public Form1 _form1;

        public Program() {
            ///////this.EnableVisualStyles = true;
            this.IsSingleInstance = true;
            
            // Если это приложение уже запущено, не загружаем его.
            if (System.Diagnostics.Process.GetProcessesByName(
                System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)
                ).Count() > 1) {
                return;
            }

            Settings settings = Settings.Load(Path.Combine(Application.StartupPath, @"config.xml"));
            ////settings.Dump();
            
            _form1 = new Form1(settings);
            Form2 form2 = new Form2();

            form2.TopLevel = false;
            form2.Location = new System.Drawing.Point(0, 26);
            _form1.Controls.Add(form2);
            form2.BringToFront();
            form2.viewer = _form1.viewer;

            _form1.Show();
            form2.Show();

            this.MainForm = _form1;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e) {
            e.BringToForeground = true;
            if (e.CommandLine.Count > 0 && File.Exists(e.CommandLine[0]) 
                && e.CommandLine[0].Trim().ToLower().EndsWith(".hkx"))
                _form1.viewer.LoadAnimation(e.CommandLine[0]);
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(_form1);
            new Program().Run(args);
        }
    }
}
