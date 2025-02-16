using System.Diagnostics;

namespace pcMonitor
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            versionLabel.Text = "Version " + Application.ProductVersion;

            projectLinkLabel.Links.Remove(projectLinkLabel.Links[0]);
            projectLinkLabel.Links.Add(0, projectLinkLabel.Text.Length, "https://github.com/billydavis/divoom.net");
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (e.Link?.LinkData != null)
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = e.Link.LinkData.ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
            }
            catch
            {
            }
        }
    }
}
