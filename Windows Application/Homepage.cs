using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application
{
    public partial class Homepage : Form
    {

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        { 
            //syntax used for current time and date to watch//
            timer1.Enabled = true;
            //This bundle of code is used to hide the groupbox from the screen until selection of menu, time of meal//
            //where groups are named by what we required like week, mean which list of meal we have to hide until clicking on button//
            grpWeeks.Enabled = false;
            grpMorningTeaMenu.Visible = false;
            grpWeek1.Visible = false;
            grpWeek2.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            //here is the coding for date and time,which represt the current time and date//
            //make easy for user to have a look on time,on this application//
            lblDate.Text = DateTime.Now.ToString("dd--MM--yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //this is for the sign out button, if you want to go back to the Start Page/Sign In Page to order something by someone else name//
            //or detail then click sign out button which will directly go back to Sign in Page//
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btnMorningTea_Click(object sender, EventArgs e)
        {
            //this code/syntax is for to hide all the informatioon uintil you click the button//
            //grpweeks is a group which is unabled until we click on Morning Tea Button//
            grpWeeks.Enabled = false;
            //this is the main syntax or can say code which helps us to choose something from menu, mean to say do action on the form//
            grpMorningTeaMenu.Enabled = true;
            //this is for when you click the Morning Tea Butoon then it pop up the menu, and shows us//
            grpMorningTeaMenu.Visible = true;
            //Bottom two are the group which can't be popped up until we click, select lunch menu//
            grpWeek1.Visible = false;
            grpWeek2.Visible = false;
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            //this is for when you click, select the lunch menu then it enable the weeks button otherwise you can't command anything//
            grpWeeks.Enabled = true;
           
        }

        private void btnLunchWeek1_Click(object sender, EventArgs e)
        {
            grpWeek1.Visible = true;
            grpWeek1.Enabled = true;
            grpWeek2.Visible = false;
            grpWeek2.Enabled = false;
        }

        private void btnLunchWeek2_Click(object sender, EventArgs e)
        {
            grpWeek2.Visible = true;
            grpWeek2.Enabled = true;
        }

        private void grpWeek2_Enter(object sender, EventArgs e)
        {

        }
    }

    }
