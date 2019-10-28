using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Zork_Builder;
using Newtonsoft.Json;
using Zork_Common;

namespace Zork_Builder
{
    public partial class Zork_Form : Form
    {
        private WorldViewModel ViewModel;

        public bool IsWorldLoaded { get; }

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        public Zork_Form()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private WorldViewModel mViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

       private void OpenWorldCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
       {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog1.FileName));
                ViewModel.Filename = openFileDialog1.FileName;
            }
       }
        private void SaveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }


        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

  
       //     RoomView roomView = new RoomView();
       //     Controls.Add(roomView);
     

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = Properties.Settings.Default.DotNetExecutable,
                    Arguments = $"{Properties.Settings.Default.ZorkGameAssembly} {Properties.Settings.Default.ZorkGameArguments}",
                    WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.ZorkGameAssembly),
                    UseShellExecute = false
                };

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Playing.");
            }
        }

        private void closeWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


