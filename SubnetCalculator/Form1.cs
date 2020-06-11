using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnetCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillComboBox();
            cidrComboB.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subMaska = "";
            int subnet = 0;
            double vysledok = 0;
            string maska = cidrComboB.GetItemText(cidrComboB.SelectedItem);
            double maskaNum = Double.Parse(maska);
            int numIp = Convert.ToInt32(ipNum1.Value);
           
            subnet = 32 - (int)maskaNum;

                if (subnet >= 0 && subnet <= 8)
                {
                    for (int i = 0; i < subnet; i++)
                    {
                        vysledok += Math.Pow(2, i);
                    }
                    double vysSubnet = 255 - vysledok;
                    subMaska = "255.255.255." + Convert.ToString(vysSubnet);
                    labelMaska.Text = subMaska;
                    labelSubnet.Text = (Math.Pow(2, maskaNum - 8)).ToString();
                    labelHost.Text = ((Math.Pow(2, 32 - maskaNum)) - 2).ToString();
                    ipCheck(numIp);
                    ipBinary();
                    subnetBinary(subMaska);

            }
                else if (subnet > 8 && subnet <= 16)
                {
                    int octetDva = 16 - subnet;

                    octetDva = 8 - octetDva;

                    for (int i = 0; i < octetDva; i++)
                    {
                        vysledok += Math.Pow(2, i);
                    }
                    double vysSubnet = 255 - vysledok;
                    subMaska = "255.255." + Convert.ToString(vysSubnet) + ".0";
                    labelMaska.Text = subMaska;
                    labelSubnet.Text = (Math.Pow(2, maskaNum - 8)).ToString();
                    labelHost.Text = ((Math.Pow(2, 32 - maskaNum)) - 2).ToString();
                    ipCheck(numIp);
                    ipBinary();
                    subnetBinary(subMaska);
            }
                else if (subnet > 16 && subnet <= 24)
                {
                    int octetTri = 24 - subnet;

                    octetTri = 8 - octetTri;

                    for (int i = 0; i < octetTri; i++)
                    {
                        vysledok += Math.Pow(2, i);
                    }
                    double vysSubnet = 255 - vysledok;
                    subMaska = "255." + Convert.ToString(vysSubnet) + ".0.0";
                    labelMaska.Text = subMaska;
                    labelSubnet.Text = (Math.Pow(2, maskaNum - 8)).ToString();
                    labelHost.Text = ((Math.Pow(2, 32 - maskaNum)) - 2).ToString();
                    ipCheck(numIp);
                    ipBinary();
                    subnetBinary(subMaska);
                }
                else if (subnet > 24 && subnet <= 32)
                {
                    int octetStyri = 32 - subnet;

                    octetStyri = 8 - octetStyri;

                    for (int i = 0; i < octetStyri; i++)
                    {
                        vysledok += Math.Pow(2, i);
                    }
                    double vysSubnet = 255 - vysledok;
                    subMaska = Convert.ToString(vysSubnet) + ".0.0.0";
                    labelMaska.Text = subMaska;
                    labelSubnet.Text = (Math.Pow(2, maskaNum - 8)).ToString();
                    labelHost.Text = ((Math.Pow(2, 32 - maskaNum)) - 2).ToString();
                    ipCheck(numIp);
                    ipBinary();
                    subnetBinary(subMaska);
            }
            
        }

        private void ipCheck(int ipNum)
        {
         
            if (ipNum >= 1 && ipNum <= 126)
            {
                labelTrieda.Text = "A";
            }
            else if (ipNum >= 128 && ipNum <= 191)
            {
                labelTrieda.Text = "B";
            }
            else if (ipNum >= 192 && ipNum <= 223)
            {
                labelTrieda.Text = "C";
              
            }
            else if (ipNum >= 224 && ipNum <= 239)
            {
                labelTrieda.Text = "D";
            }
            else
            {
                labelTrieda.Text = "E";
            }
        }

        
        private void ipBinary()
        {

            int ip1 = Convert.ToInt32(ipNum1.Value);
            string binary1 = Convert.ToString(ip1, 2).PadLeft(8, '0');

            int ip2 = Convert.ToInt32(ipNum2.Value);
            string binary2 = Convert.ToString(ip2, 2).PadLeft(8, '0');

            int ip3 = Convert.ToInt32(ipNum3.Value);
            string binary3 = Convert.ToString(ip3, 2).PadLeft(8, '0');

            int ip4 = Convert.ToInt32(ipNum4.Value);
            string binary4 = Convert.ToString(ip4, 2).PadLeft(8, '0');

            labelIpBi.Text = String.Format("{0}.{1}.{2}.{3}", binary1, binary2, binary3, binary4);

        }

        private void subnetBinary(string subMaska)
        {
            string[] subArray = subMaska.Split('.');

            int[] subInt = Array.ConvertAll(subArray, s => int.Parse(s));

            string binary1 = Convert.ToString(subInt[0], 2).PadLeft(8, '0');
            string binary2 = Convert.ToString(subInt[1], 2).PadLeft(8, '0');
            string binary3 = Convert.ToString(subInt[2], 2).PadLeft(8, '0');
            string binary4 = Convert.ToString(subInt[3], 2).PadLeft(8, '0');

            labelMaBi.Text = String.Format("{0}.{1}.{2}.{3}", binary1, binary2, binary3, binary4);
        }
        

        private void fillComboBox()
        {
            for (int i = 8; i <= 30; i++)
            {
                cidrComboB.Items.Add(i.ToString());
            }
        }
    }
}
