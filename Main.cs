using AuxiliarySensors.ConfigParser;
using AuxiliarySensors.Models;

namespace AuxiliarySensors
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void b_configLocation_Click(object sender, EventArgs e)
        {
            if(configBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tb_configLocation.Text = configBrowserDialog.SelectedPath;
            }

        }

        private void tb_configLocation_TextChanged(object sender, EventArgs e)
        {
            var setupFiles = ConfigUtil.GetFiles(tb_configLocation.Text);

            foreach(var file in setupFiles)
            {
                lb_ConfigFiles.Items.Add(file);
            }
        }

        private void lb_ConfigFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var configFile = lb_ConfigFiles.SelectedItem as MonitorSetupFile;
            rtb_ConfigFile.Text = configFile.Contents;
        }
    }
}