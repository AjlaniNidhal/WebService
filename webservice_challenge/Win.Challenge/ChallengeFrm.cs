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
        private async void Fibonacci()
        {

            ChallengeServiceReference.ChallengeServiceSoapClient client = new ChallengeServiceReference.ChallengeServiceSoapClient();
            Thread.Sleep(2000);
            int result = await client.FibonacciAsync(10);
            MessageBox.Show(result.ToString());
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
