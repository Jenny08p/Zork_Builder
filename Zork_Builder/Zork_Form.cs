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
        private WorldViewModel mViewModel;

        public bool IsWorldLoaded { get; }

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        public Zork_Form()
        {
            InitializeComponent();
            mViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog1.FileName));
                mViewModel.Filename = openFileDialog1.FileName;
                roomsBindingSource.DataSource = mViewModel.Rooms;
            }
        }
        private void SaveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mViewModel.SaveGame();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mViewModel.Filename = saveFileDialog.FileName;
                mViewModel.SaveGame();
            }
        }

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

        private void CloseWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


