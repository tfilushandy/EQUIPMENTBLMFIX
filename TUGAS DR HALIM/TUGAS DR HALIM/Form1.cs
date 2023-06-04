using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGAS_DR_HALIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string classname = "Knight";
        static int VIT = 2;
        static int STR = 0;
        static int DEX = 2;
        static int AGI = 0;
        static int INT = 1;
        static int WIS = 2;
        static int CASH = 1000;
        static int LEVEL = 2;
        static int SP = 1;
        static double POS = 200.69;
        static string MAP = "12345234523456345623456456745673456734567345674567";

        string result = $"{classname} {VIT.ToString()} {STR.ToString()} {DEX.ToString()} {AGI.ToString()}" +
            $" {INT.ToString()} {WIS.ToString()} {CASH.ToString()} {LEVEL.ToString()} {SP.ToString()} {POS.ToString()} {MAP}";

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  Class Name 	: Knight
                VIT		: 2
                STR		: 0
                DEX		: 2
                AGI		: 0
                INT		: 1
                WIS		: 2
                CASH		: 1000
                LEVEL		: 2
                SP		: 1
                POS		: 200,69
                MAP		: 12345234523456345623456456745673456734567345674567

                result
                Knight 2 0 2 0 1 2 1000 2 1 200,69 123
            */
        }
        class Knight
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            resulttxtbox.Text = result;
        }
    }
}
