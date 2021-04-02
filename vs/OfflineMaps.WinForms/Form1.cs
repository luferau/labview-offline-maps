using System;
using System.Windows.Forms;
using OfflineMaps.Core;

namespace OfflineMaps.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            offlineMapControl.SetMapTitlesFolder(@"..\..\..\..\maps\map\");
        }

        private void point1Button_Click(object sender, EventArgs e)
        {
            var point1 = new PointData(false, "London", 51.5, 0.05, 157, 65.5, 25.1);

            offlineMapControl.AddPoint(point1);
        }

        private void point2button_Click(object sender, EventArgs e)
        {
            var point2 = new PointData(false, "Minsk", 53.9, 27.6, 320, 65.5, 24.8);

            offlineMapControl.AddPoint(point2);
        }
    }
}
