using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Your_Arithmetic
{
    public partial class formmain : Form
    {
        public double onenumber { get; set; }
        public double twonumber { get; set; }
        public double answer { get; set; }
        public int score { get; set; }
        public int questions { get; set; }
        public int level { get; set; }

        private difficulty_level difficulty;

        public formmain()
        {
            InitializeComponent();
            initialize();
            
        }


        private void initialize()
        {
            lblfun.Text = "Have fun!";
            lblquestion.Text = "1 + 2";
            lblanswer.Text = "Your answer:";
            txtbanswer.Text = "0";
            lblscore.Text = @"score: 0/0";

            btnsend.Text = "Send";
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();

            difficulty = new difficulty_level(level, score);
            level_easy();
        }

        private void createquestion()
        {
            
        }

        private void level_easy()
        {
            Random rand = new Random();
            
            onenumber = rand.Next(difficulty.min, difficulty.max);
            twonumber = rand.Next(difficulty.min, difficulty.max);
            
            answer = onenumber + twonumber;

            lblquestion.Text = string.Format("{0} + {1}", onenumber, twonumber);
        }

        private void level_medium()
        {
            Random rand = new Random();
            onenumber = rand.NextDouble();
            twonumber = rand.NextDouble();
        }

        private void level_difficult()
        {
            Random rand = new Random();
            onenumber = rand.NextDouble();
            twonumber = rand.NextDouble();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            difficulty = new difficulty_level(level, score);
            double sent;
            double.TryParse(txtbanswer.Text, out sent);
            if (sent == answer)
            {
                score += 1;
                txtbanswer.Text = "0";
            }

            level_easy();
            questions += 1;
            lblscore.Text = string.Format("score: {0}/{1}", score, questions);
        }

        private void txtbanswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnsend_Click(null, null);
            }
        }

        private void txtbanswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtbanswer.Text.Equals("0"))
            {
                txtbanswer.Text = "";
            }
        }

        private void formmain_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
