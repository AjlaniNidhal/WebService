using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Challenge
{
    public partial class ChallengeFrm : Form
    {
        public ChallengeFrm()
        {
            InitializeComponent();
        }
        private void Fibonacci()
        {

            ChallengeServiceReference.ChallengeServiceSoapClient client = new ChallengeServiceReference.ChallengeServiceSoapClient();
            Thread.Sleep(5000);
            MessageBox.Show(client.Fibonacci(10).ToString());
        }

        private void btn_Fibonancci_Click(object sender, EventArgs e)
        {
            using (BusyFrm loader = new BusyFrm(this.Fibonacci))
            {
                loader.ShowDialog(this);
            }
        }
    }
}
