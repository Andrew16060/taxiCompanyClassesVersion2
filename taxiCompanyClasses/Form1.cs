using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxiCompanyClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            taxiList.Add(new taxi("Dunedin Taxi", 4543333, 3, 2.55));
            taxiList.Add(new taxi("United Taxi", 4662222, 2.90, 3));
            taxiList.Add(new taxi("Southern Taxi", 5005000, 2.50, 2.60));
        }

        List<taxi> taxiList = new List<taxi>();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < taxiList.Count; i++)
            {
                lboxOutput.Items.Add(taxiList[i].CalculateCost(Convert.ToDouble(txtDistance.Text)));
            }
        }
    }
}
