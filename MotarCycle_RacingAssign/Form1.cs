using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotarCycle_RacingAssign
{
    

    public partial class motarscycle1 : Form
    {
        // intilization of vars that are having fixed values 

        int bikeNo = 0, plyrNo = 0;
        int param = 100, gurleen = 100, samreen = 100;
        Bike instnce = new Bike();
        BudgetSetting budget = new BudgetSetting();
        public motarscycle1()
        {
            InitializeComponent();
        }

        // var bikeno is being changed according to the selected one 
        private void Motarcycle1_CheckedChanged(object sender, EventArgs e)
        {
            if (Motarcycle1.Checked==true) {
                bikeNo = 1;
            }
        }

        // var bikeno is being changed according to the selected one 
        private void MotarCycle2_CheckedChanged(object sender, EventArgs e)
        {
            if (MotarCycle2.Checked == true)
            {
                bikeNo = 2;
            }
        }

        // var bikeno is being changed according to the selected one 
        private void motarcycle3_CheckedChanged(object sender, EventArgs e)
        {
            if (motarcycle3.Checked == true)
            {
                bikeNo = 3;
            }
        }

        // var players is being changed according to the selected one 
        private void Param_selected_CheckedChanged(object sender, EventArgs e)
        {
            if (Param_selected.Checked==true) {
                plyrNo = 1;
            }
        }

        // var players is being changed according to the selected one 

        private void gurleen_selected_CheckedChanged(object sender, EventArgs e)
        {
            if (gurleen_selected.Checked == true)
            {
                plyrNo = 2;
            }
        }

        // it start timer when clicked on button

        private void ready_btn_Click(object sender, EventArgs e)
        {
            //here we need to get the help of the timer to move the bikes on the ground 
            timer1.Start(); timer2.Start(); timer3.Start(); timer4.Start(); 


        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        // printing message about balances

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            motarcycle_pic1.Left+= instnce.race();
            
            motar_cycle_pic2.Left += instnce.race();
            
            motar_cycle_pic3.Left += instnce.race();
            
            motarcycle_pic4.Left += instnce.race();

            if (motarcycle_pic1.Left>instnce.endPoint()) {
                timer2.Stop();
                MessageBox.Show("BIke 1 won the race ");
                if (Param_message.Text.ToString().Contains("amount")) {
                    param=budget.budget(Param_message.Text, 1, param);
                }

                if (gurleen_message.Text.ToString().Contains("amount"))
                {
                    gurleen = budget.budget(gurleen_message.Text, 1, gurleen);
                }

                if (samreen_message.Text.ToString().Contains("amount"))
                {
                    samreen = budget.budget(samreen_message.Text, 1, samreen);
                }

                motarcycle_pic1.Left = instnce.strtPoint();
                motar_cycle_pic2.Left = instnce.strtPoint();
                motar_cycle_pic3.Left = instnce.strtPoint();
                motarcycle_pic4.Left = instnce.strtPoint();
                Param_message.Text = "Param has " + param;
                gurleen_message.Text = "Gurleen has " + gurleen;
                samreen_message.Text = "Samreen has " + samreen;

                Motarcycle1.Checked = false;
                MotarCycle2.Checked = false;
                motarcycle3.Checked = false;
                motarcycle4.Checked = false;
                Enter_bet_amount.Text = "";

                Param_selected.Checked = false;
                gurleen_selected.Checked = false;
                samreen_selected.Checked = false;
            
            }
            if (motar_cycle_pic2.Left > instnce.endPoint())
            {
                timer2.Stop();
                MessageBox.Show("BIke 2 won the race ");
                if (Param_message.Text.ToString().Contains("amount"))
                {
                    param = budget.budget(Param_message.Text, 2, param);
                }

                if (gurleen_message.Text.ToString().Contains("amount"))
                {
                    gurleen = budget.budget(gurleen_message.Text, 2, gurleen);
                }

                if (samreen_message.Text.ToString().Contains("amount"))
                {
                    samreen = budget.budget(samreen_message.Text, 2, samreen);
                }

                motarcycle_pic1.Left = instnce.strtPoint();
                motar_cycle_pic2.Left = instnce.strtPoint();
                motar_cycle_pic3.Left = instnce.strtPoint();
                motarcycle_pic4.Left = instnce.strtPoint();
                Param_message.Text = "Param has " + param;
                gurleen_message.Text = "Gurleen has " + gurleen;
                samreen_message.Text = "Samreen has " + samreen;

                Motarcycle1.Checked = false;
                MotarCycle2.Checked = false;
                motarcycle3.Checked = false;
                motarcycle4.Checked = false;
                Enter_bet_amount.Text = "";

                Param_selected.Checked = false;
                gurleen_selected.Checked = false;
                samreen_selected.Checked = false;


            }
            if (motar_cycle_pic3.Left > instnce.endPoint())
            {
                timer2.Stop();
                MessageBox.Show("BIke 3 won the race ");

                if (Param_message.Text.ToString().Contains("amount"))
                {
                    param = budget.budget(Param_message.Text, 3, param);
                }

                if (gurleen_message.Text.ToString().Contains("amount"))
                {
                    gurleen = budget.budget(gurleen_message.Text, 3, gurleen);
                }

                if (samreen_message.Text.ToString().Contains("amount"))
                {
                    samreen = budget.budget(samreen_message.Text, 3, samreen);
                }

                motarcycle_pic1.Left = instnce.strtPoint();
                motar_cycle_pic2.Left = instnce.strtPoint();
                motar_cycle_pic3.Left = instnce.strtPoint();
                motarcycle_pic4.Left = instnce.strtPoint();
                Param_message.Text = "Param has " + param;
                gurleen_message.Text = "Gurleen has " + gurleen;
                samreen_message.Text = "Samreen has " + samreen;

                Motarcycle1.Checked = false;
                MotarCycle2.Checked = false;
                motarcycle3.Checked = false;
                motarcycle4.Checked = false;
                Enter_bet_amount.Text = "";

                Param_selected.Checked = false;
                gurleen_selected.Checked = false;
                samreen_selected.Checked = false;

            }
            if (motarcycle_pic4.Left > instnce.endPoint())
            {
                timer2.Stop();
                MessageBox.Show("BIke 4 won the race ");

                if (Param_message.Text.ToString().Contains("amount"))
                {
                    param = budget.budget(Param_message.Text, 4, param);
                }

                if (gurleen_message.Text.ToString().Contains("amount"))
                {
                    gurleen = budget.budget(gurleen_message.Text, 4, gurleen);
                }

                if (samreen_message.Text.ToString().Contains("amount"))
                {
                    samreen = budget.budget(samreen_message.Text, 4, samreen);
                }

                motarcycle_pic1.Left = instnce.strtPoint();
                motar_cycle_pic2.Left = instnce.strtPoint();
                motar_cycle_pic3.Left = instnce.strtPoint();
                motarcycle_pic4.Left = instnce.strtPoint();
                Param_message.Text = "Param has " + param;
                gurleen_message.Text = "Gurleen has " + gurleen;
                samreen_message.Text = "Samreen has " + samreen;

                Motarcycle1.Checked = false;
                MotarCycle2.Checked = false;
                motarcycle3.Checked = false;
                motarcycle4.Checked = false;
                Enter_bet_amount.Text = "";

                Param_selected.Checked = false;
                gurleen_selected.Checked = false;
                samreen_selected.Checked = false;

            }
        }

        private void samreen_selected_CheckedChanged(object sender, EventArgs e)
        {
            if (samreen_selected.Checked == true)
            {
                plyrNo = 3;
            }
        }

        // checking that whci player and dog has been selected

        private void lock_btn_Click(object sender, EventArgs e)
        {
            switch (plyrNo) {
                case 1:
                    if (bikeNo > 0 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) > 0 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) <= 50 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) <= param)
                    {
                        Param_message.Text = "Param Select " + bikeNo + " and amount " + Enter_bet_amount.Text.ToString();
                    }
                    else {
                        MessageBox.Show("You need to chekc the bike or bet amout for the bet "); 
                    }
                    bikeNo = 0;
                    plyrNo = 0;
                    ready_btn.Enabled = true;
                    break;

                case 2:
                    if (bikeNo > 0 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) > 0 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) <= 50 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) <= gurleen)
                    {
                        gurleen_message.Text = "Gurleen Select " + bikeNo + " and amount " + Enter_bet_amount.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You need to chekc the bike or bet amout for the bet ");
                    }
                    bikeNo = 0;
                    plyrNo = 0;
                    ready_btn.Enabled = true;
                    break;
                case 3:
                    if (bikeNo > 0 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) > 0 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) <= 50 && Convert.ToInt32(Enter_bet_amount.Text.ToString()) <= samreen)
                    {
                        samreen_message.Text = "Samreen Select " + bikeNo + " and amount " + Enter_bet_amount.Text.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You need to chekc the bike or bet amout for the bet ");
                    }
                    bikeNo = 0;
                    plyrNo = 0;
                    ready_btn.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Here you need to select the Player for starting the game ");
                    break;
            }
        }

        private void motarcycle4_CheckedChanged(object sender, EventArgs e)
        {
            if (motarcycle4.Checked == true)
            {
                bikeNo = 4;
            }
        }
    }
}
