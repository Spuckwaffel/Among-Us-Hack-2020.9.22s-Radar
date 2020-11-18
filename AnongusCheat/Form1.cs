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
using System.Security.Principal;
using Memory;
using System.Diagnostics;

namespace AnongusCheat
{
    public partial class Form1 : Form
    {
        public int loaddone = 0;
        public float forval = 0.3f;
        public Mem m = new Mem();
        public int map = 1;
        public Form1()
        {
            InitializeComponent();
        }
        bool ProcOpen = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //x -15.24755573
            //y -12.07517338
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-12.07517338"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-15.24755573"); //X
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-5.575904846"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-20.66352844"); //X
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-5.331996918"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-13.17671585"); //X
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-0.9380099773"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-15.39218712"); //X
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-4.389159203"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-9.004479408"); //X
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-0.4331727028"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-0.8126907349"); //X
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "1.103766561"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "9.473914146"); //X
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-3.676559925"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "6.860258102"); //X
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-4.855072498"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "16.70541191"); //X

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-12.97463322"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "9.252508163"); //X
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-16.00076866"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "4.151418686"); //X
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-13.33019447"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-3.724923134"); //X<
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-8.705735207"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "-8.084013939"); //X
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "-8.727617264"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "2.893512249"); //X
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //x 
            //y 
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", "3.566178799"); // Y
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", "13.35726261"); //X
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess("Among Us");
            if(!ProcOpen)
            {
                
                Thread.Sleep(1000);
                    return;
            }



            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(ProcOpen)
                ProcOpenLabel.Text = "Game found!";
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Xcoord.Text = "X:" + m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c");
           Ycoord.Text = "Y:" + m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", xcoordstextbox.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You can only use numbers and . ! \nFor example: 15.3002");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals("w"))
            {
                float ycoord = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30");
                ycoord = ycoord + forval;
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", ycoord + "");
            }
            if (textBox3.Text.Equals("a"))
            {
                float xcoord = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c");
                xcoord = xcoord - forval;
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", xcoord + "");
            }
            if (textBox3.Text.Equals("s"))
            {
                float ycoord = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30");
                ycoord = ycoord - forval;
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", ycoord + "");
            }
            if (textBox3.Text.Equals("d"))
            {
                float xcoord = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c");
                xcoord = xcoord + forval;
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", xcoord + "");
            }
            textBox3.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter a x coordinate and press go to tp");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter a y coordinate and press go to tp");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is the free box. just press in there w, a, s or d to move a specific value (enter the value at the for box)");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Say for how much your character should move each time you press a key in the free box");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on any button on the map to teleport to that point");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            forval = float.Parse(fortextbox.Text);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,30", "int", emergencymeetingstextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers! \nFor example: 15");
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,05c,04,4C", "int", "1");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,05c,04,4C", "int", "0");
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,05c,04,34", "int", emergencycooldowntextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers! \nFor example: 15");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5C,4,10", "byte","0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5C,4,10", "byte", "1");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5C,4,10", "byte", "2");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,05c,04,38", "int", impostorstextbox.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You can only use numbers! \nFor example: 15");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,05c,04,44", "int", discussiontimetextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers! \nFor example: 15");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,05c,04,48", "int", votingtimetextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers! \nFor example: 15");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,14", "float", playerspeedtextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers and . ! \nFor example: 15.593");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,18", "float", playervisiontextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers and . ! \nFor example: 15.593");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,1C", "float", impostorvisiontextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers and . ! \nFor example: 15.593");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,20", "float", killcooldowntextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers and . ! \nFor example: 15.593");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "0");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "1");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,05c,04,40", "int", "2");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,24", "int", commontaskstextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5C,4,28", "int", longtaskstextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,4,2C", "int", shorttaskstextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void ycoordstextbox_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", ycoordstextbox.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You can only use numbers and . ! \nFor example: 15.3002");
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (passwordbox.Text.Equals("56562"))
            {
                timer2.Enabled = true;
                timer3.Enabled = true;
                panel3.Visible = true;
                panel2.Visible = true;
                nothingfoundlabel.Text = "Seems like there is something lol";
                tabPage1.BackColor = Color.Black;
                tabPage2.BackColor = Color.Black;
                tabPage3.BackColor = Color.Black;
                tabPage1.ForeColor = Color.Lime;
                tabPage2.ForeColor = Color.Lime;
                tabPage3.ForeColor = Color.Lime;
                this.BackColor = Color.Black;
                this.ForeColor = Color.Lime;
                this.MaximizeBox = true;
                this.Width = 1510;
                this.Height = 784;

                theskeld.Visible = true;
                Mirahq.Visible = false;
                polus.Visible = false;
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TextBox textBoxI1 = new TextBox();
            TextBox textBoxI2 = new TextBox();
            TextBox textBoxI3 = new TextBox();
            TextBox textBoxI4 = new TextBox();
            TextBox textBoxI5 = new TextBox();
            TextBox textBoxI6 = new TextBox();
            TextBox textBoxI7 = new TextBox();
            TextBox textBoxI8 = new TextBox();
            TextBox textBoxI9 = new TextBox();
            TextBox textBoxI10 = new TextBox();

            //You
            youimpostor.Text = m.ReadInt("GameAssembly.dll+1468910,5c,0,34,28") + "";
            youxcoord.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c") + "";
            youycoord.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30") + "";
            youspeed.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,0,5c,24") + "";
            youkillcooldown.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,0,44") + "";
            youemergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,0,48") + "";

            //Player1
            player1name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,20,4c,2c,c", "", 32, true);
            player1imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,20,34,28") + "";
            player1emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,20,48") + "";
            player1x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,20,5c,2c,8,5c,2C") + "";
            player1y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,20,5c,2c,8,5c,30") + "";


            //Player2
            player2name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,24,4c,2c,c", "", 32, true);
            player2imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,24,34,28") + "";
            player2emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,24,48") + "";
            player2x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,24,5c,2c,8,5c,2C") + "";
            player2y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,24,5c,2c,8,5c,30") + "";


            //Player3
            player3name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,28,4c,2c,c", "", 32, true);
            player3imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,28,34,28") + "";
            player3emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,28,48") + "";
            player3x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,28,5c,2c,8,5c,2C") + "";
            player3y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,28,5c,2c,8,5c,30") + "";


            //Player4
            player4name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,2C,4c,2c,c", "", 32, true);
            player4imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,2C,34,28") + "";
            player4emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,2C,48") + "";
            player4x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,2C,5c,2c,8,5c,2C") + "";
            player4y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,2C,5c,2c,8,5c,30") + "";


            //Player5
            player5name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,30,4c,2c,c", "", 32, true);
            player5imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,30,34,28") + "";
            player5emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,30,48") + "";
            player5x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,30,5c,2c,8,5c,2C") + "";
            player5y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,30,5c,2c,8,5c,30") + "";


            //Player6
            player6name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,1C,4c,2c,c", "", 32, true);
            player6imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,1C,34,28") + "";
            player6emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,1C,48") + "";
            player6x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,1C,5c,2c,8,5c,2C") + "";
            player6y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,1C,5c,2c,8,5c,30") + "";


            //Player7
            player7name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,34,4c,2c,c", "", 32, true);
            player7imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,34,34,28") + "";
            player7emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,34,48") + "";
            player7x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,34,5c,2c,8,5c,2C") + "";
            player7y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,34,5c,2c,8,5c,30") + "";


            //Player8
            player8name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,14,4c,2c,c", "", 32, true);
            player8imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,14,34,28") + "";
            player8emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,14,48") + "";
            player8x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,14,5c,2c,8,5c,2C") + "";
            player8y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,14,5c,2c,8,5c,30") + "";

            //Player9
            player9name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,18,4c,2c,c", "", 32, true);
            player9imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,18,34,28") + "";
            player9emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,18,48") + "";
            player9x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,18,5c,2c,8,5c,2C") + "";
            player9y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,18,5c,2c,8,5c,30") + "";

            //Player10
            player10name.Text = m.ReadString("GameAssembly.dll+01468910,5c,8,8,10,4c,2c,c", "", 32, true);
            player10imp.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,10,34,28") + "";
            player10emergencies.Text = m.ReadInt("GameAssembly.dll+01468910,5c,8,8,10,48") + "";
            player10x.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,10,5c,2c,8,5c,2C") + "";
            player10y.Text = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,10,5c,2c,8,5c,30") + "";



            if (player1imp.Text.Equals("1"))
            {
                player1imp.ForeColor = Color.YellowGreen;
                playerinfo1.Text = "Impostor";
                playerinfo1.ForeColor = Color.YellowGreen;
            }
            if (player2imp.Text.Equals("1"))
            {
                player2imp.ForeColor = Color.YellowGreen;
                playerinfo2.Text = "Impostor";
                playerinfo2.ForeColor = Color.YellowGreen;
            }
            if (player3imp.Text.Equals("1"))
            {
                player3imp.ForeColor = Color.YellowGreen;
                playerinfo3.Text = "Impostor";
                playerinfo3.ForeColor = Color.YellowGreen;
            }
            if (player4imp.Text.Equals("1"))
            {
                player4imp.ForeColor = Color.YellowGreen;
                playerinfo4.Text = "Impostor";
                playerinfo4.ForeColor = Color.YellowGreen;
            }
            if (player5imp.Text.Equals("1"))
            {
                player5imp.ForeColor = Color.YellowGreen;
                playerinfo5.Text = "Impostor";
                playerinfo5.ForeColor = Color.YellowGreen;
            }
            if (player6imp.Text.Equals("1"))
            {
                player6imp.ForeColor = Color.YellowGreen;
                playerinfo6.Text = "Impostor";
                playerinfo6.ForeColor = Color.YellowGreen;
            }
            if (player7imp.Text.Equals("1"))
            {
                player7imp.ForeColor = Color.YellowGreen;
                playerinfo7.Text = "Impostor";
                playerinfo7.ForeColor = Color.YellowGreen;
            }
            if (player8imp.Text.Equals("1"))
            {
                player8imp.ForeColor = Color.YellowGreen;
                playerinfo8.Text = "Impostor";
                playerinfo8.ForeColor = Color.YellowGreen;
            }
            if (player9imp.Text.Equals("1"))
            {
                player9imp.ForeColor = Color.YellowGreen;
                playerinfo9.Text = "Impostor";
                playerinfo9.ForeColor = Color.YellowGreen;
            }
            if (player10imp.Text.Equals("1"))
            {
                player10imp.ForeColor = Color.YellowGreen;
                playerinfo10.Text = "Impostor";
                playerinfo10.ForeColor = Color.YellowGreen;
            }


            if (player1imp.Text.Equals("0"))
            {
                player1imp.ForeColor = Color.Lime;
                playerinfo1.Text = "Crewmate";
                playerinfo1.ForeColor = Color.Lime;
            }
            if (player2imp.Text.Equals("0"))
            {
                player2imp.ForeColor = Color.Lime;
                playerinfo2.Text = "Crewmate";
                playerinfo2.ForeColor = Color.Lime;
            }
            if (player3imp.Text.Equals("0"))
            {
                player3imp.ForeColor = Color.Lime;
                playerinfo3.Text = "Crewmate";
                playerinfo3.ForeColor = Color.Lime;
            }
            if (player4imp.Text.Equals("0"))
            {
                player4imp.ForeColor = Color.Lime;
                playerinfo4.Text = "Crewmate";
                playerinfo4.ForeColor = Color.Lime;
            }
            if (player5imp.Text.Equals("0"))
            {
                player5imp.ForeColor = Color.Lime;
                playerinfo5.Text = "Crewmate";
                playerinfo5.ForeColor = Color.Lime;
            }
            if (player6imp.Text.Equals("0"))
            {
                player6imp.ForeColor = Color.Lime;
                playerinfo6.Text = "Crewmate";
                playerinfo6.ForeColor = Color.Lime;
            }
            if (player7imp.Text.Equals("0"))
            {
                player7imp.ForeColor = Color.Lime;
                playerinfo7.Text = "Crewmate";
                playerinfo7.ForeColor = Color.Lime;
            }
            if (player8imp.Text.Equals("0"))
            {
                player8imp.ForeColor = Color.Lime;
                playerinfo8.Text = "Crewmate";
                playerinfo8.ForeColor = Color.Lime;
            }
            if (player9imp.Text.Equals("0"))
            {
                player9imp.ForeColor = Color.Lime;
                playerinfo9.Text = "Crewmate";
                playerinfo9.ForeColor = Color.Lime;
            }
            if (player10imp.Text.Equals("0"))
            {
                player10imp.ForeColor = Color.Lime;
                playerinfo10.Text = "Crewmate";
                playerinfo10.ForeColor = Color.Lime;
            }

            if (player1imp.Text.Equals("256"))
            {
                player1imp.ForeColor = Color.Red;
                yellowpicbox.Visible = false;
                playerinfo1.Text = "Dead";
                playerinfo1.ForeColor = Color.Red;
            }
            if (player2imp.Text.Equals("256"))
            {
                player2imp.ForeColor = Color.Red;
                pinkpicbox.Visible = false;
                playerinfo2.Text = "Dead";
                playerinfo2.ForeColor = Color.Red;
            }
            if (player3imp.Text.Equals("256"))
            {
                player3imp.ForeColor = Color.Red;
                greenpicbox.Visible = false;
                playerinfo3.Text = "Dead";
                playerinfo3.ForeColor = Color.Red;
            }
            if (player4imp.Text.Equals("256"))
            {
                player4imp.ForeColor = Color.Red;
                bluepicbox.Visible = false;
                playerinfo4.Text = "Dead";
                playerinfo4.ForeColor = Color.Red;
            }
            if (player5imp.Text.Equals("256"))
            {
                player5imp.ForeColor = Color.Red;
                lightbluepicbox.Visible = false;
                playerinfo5.Text = "Dead";
                playerinfo5.ForeColor = Color.Red;
            }
            if (player6imp.Text.Equals("256"))
            {
                player6imp.ForeColor = Color.Red;
                whitepicbox.Visible = false;
                playerinfo6.Text = "Dead";
                playerinfo6.ForeColor = Color.Red;
            }
            if (player7imp.Text.Equals("256"))
            {
                player7imp.ForeColor = Color.Red;
                orangepicbox.Visible = false;
                playerinfo7.Text = "Dead";
                playerinfo7.ForeColor = Color.Red;
            }
            if (player8imp.Text.Equals("256"))
            {
                player8imp.ForeColor = Color.Red;
                redpicbox.Visible = false;
                playerinfo8.Text = "Dead";
                playerinfo8.ForeColor = Color.Red;
            }
            if (player9imp.Text.Equals("256"))
            {
                player9imp.ForeColor = Color.Red;
                purplepicbox.Visible = false;
                playerinfo9.Text = "Dead";
                playerinfo9.ForeColor = Color.Red;
            }
            if (player10imp.Text.Equals("256"))
            {
                player10imp.ForeColor = Color.Red;
                rosepicbox.Visible = false;
                playerinfo10.Text = "Dead";
                playerinfo10.ForeColor = Color.Red;
            }


            if (player1imp.Text.Equals("257"))
            {
                player1imp.ForeColor = Color.Red;
                yellowpicbox.Visible = false;
                playerinfo1.Text = "Dead";
                playerinfo1.ForeColor = Color.Red;
            }
            if (player2imp.Text.Equals("257"))
            {
                player2imp.ForeColor = Color.Red;
                pinkpicbox.Visible = false;
                playerinfo2.Text = "Dead";
                playerinfo2.ForeColor = Color.Red;
            }
            if (player3imp.Text.Equals("257"))
            {
                player3imp.ForeColor = Color.Red;
                greenpicbox.Visible = false;
                playerinfo3.Text = "Dead";
                playerinfo3.ForeColor = Color.Red;
            }
            if (player4imp.Text.Equals("257"))
            {
                player4imp.ForeColor = Color.Red;
                bluepicbox.Visible = false;
                playerinfo4.Text = "Dead";
                playerinfo4.ForeColor = Color.Red;
            }
            if (player5imp.Text.Equals("257"))
            {
                player5imp.ForeColor = Color.Red;
                lightbluepicbox.Visible = false;
                playerinfo5.Text = "Dead";
                playerinfo5.ForeColor = Color.Red;
            }
            if (player6imp.Text.Equals("257"))
            {
                player6imp.ForeColor = Color.Red;
                whitepicbox.Visible = false;
                playerinfo6.Text = "Dead";
                playerinfo6.ForeColor = Color.Red;
            }
            if (player7imp.Text.Equals("257"))
            {
                player7imp.ForeColor = Color.Red;
                orangepicbox.Visible = false;
                playerinfo7.Text = "Dead";
                playerinfo7.ForeColor = Color.Red;
            }
            if (player8imp.Text.Equals("257"))
            {
                player8imp.ForeColor = Color.Red;
                redpicbox.Visible = false;
                playerinfo8.Text = "Dead";
                playerinfo8.ForeColor = Color.Red;
            }
            if (player9imp.Text.Equals("257"))
            {
                player9imp.ForeColor = Color.Red;
                purplepicbox.Visible = false;
                playerinfo9.Text = "Dead";
                playerinfo9.ForeColor = Color.Red;
            }
            if (player10imp.Text.Equals("257"))
            {
                player10imp.ForeColor = Color.Red;
                rosepicbox.Visible = false;
                playerinfo10.Text = "Dead";
                playerinfo10.ForeColor = Color.Red;
            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "1");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5C,0,34,28", "int", "0");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", youxcoordtextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", youycoordtextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        //lolll

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,24", "float", youspeedtextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,44", "float", youkillcooldowntextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("GameAssembly.dll+01468910,5c,0,48", "int", youemergenciestextbox.Text);
            }
            catch
            {
                MessageBox.Show("You can only use numbers!");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            m.FreezeValue("GameAssembly.dll+01468910,5c,0,44", "float", "0");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                this.ShowInTaskbar = false;
            }
            if (checkBox1.Checked == false)
            {
                this.ShowInTaskbar = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCPNN9XllVelxDIX93wxDd_Q");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player10y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player10x.Text);
        }

        private void teleport1_Click(object sender, EventArgs e)
        {
            float eny1 = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,20,5c,2c,8,5c,30");
            float enx1 = m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,20,5c,2c,8,5c,2C");
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", eny1 + "");
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", enx1 + "");


        }

        private void teleport2_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player2y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player2x.Text);
        }

        private void teleport3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player3y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player3x.Text);
        }

        private void teleport4_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player4y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player4x.Text);
        }

        private void teleport5_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player5y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player5x.Text);
        }

        private void teleport6_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player6y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player6x.Text);
        }

        private void teleport7_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player7y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player7x.Text);
        }

        private void teleport8_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player8y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player8x.Text);
        }

        private void teleport9_Click(object sender, EventArgs e)
        {
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,30", "float", player9y.Text);
            m.WriteMemory("GameAssembly.dll+01468910,5c,0,5c,2c,8,5c,2c", "float", player9x.Text);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            imp1.Visible = false;
            imp2.Visible = false;
            imp3.Visible = false;
            imp4.Visible = false;
            imp5.Visible = false;
            imp6.Visible = false;
            imp7.Visible = false;
            imp8.Visible = false;
            imp9.Visible = false;
            imp10.Visible = false;
            purplepicbox.Visible = false;
            pinkpicbox.Visible = false;
            yellowpicbox.Visible = false;
            greenpicbox.Visible = false;
            bluepicbox.Visible = false;
            lightbluepicbox.Visible = false;
            whitepicbox.Visible = false;
            orangepicbox.Visible = false;
            redpicbox.Visible = false;
            purplepicbox.Visible = false;
            rosepicbox.Visible = false;
            int playerx1 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,20,5c,2c,8,5c,2C");
            int playery1 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,20,5c,2c,8,5c,30");
            int playerx2 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,24,5c,2c,8,5c,2C");
            int playery2 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,24,5c,2c,8,5c,30");
            int playerx3 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,28,5c,2c,8,5c,2C");
            int playery3 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,28,5c,2c,8,5c,30");
            int playerx4 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,2C,5c,2c,8,5c,2C");
            int playery4 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,2C,5c,2c,8,5c,30");
            int playerx5 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,30,5c,2c,8,5c,2C");
            int playery5 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,30,5c,2c,8,5c,30");
            int playerx6 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,1C,5c,2c,8,5c,2C");
            int playery6 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,1C,5c,2c,8,5c,30");
            int playerx7 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,34,5c,2c,8,5c,2C");
            int playery7 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,34,5c,2c,8,5c,30");
            int playerx8 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,14,5c,2c,8,5c,2C");
            int playery8 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,14,5c,2c,8,5c,30");
            int playerx9 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,18,5c,2c,8,5c,2C");
            int playery9 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,18,5c,2c,8,5c,30");
            int playerx10 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,10,5c,2c,8,5c,2C");
            int playery10 = (int)m.ReadFloat("GameAssembly.dll+01468910,5c,8,8,10,5c,2c,8,5c,30");



            if (map == 1)
            {
                //radar

                playerx1 = playerx1 * 9;
                playery1 = playery1 * 9;
                int actualyway1 = 0;
                //calculate
                if (playery1 < 0)
                {
                    actualyway1 = playery1 - (playery1) - (playery1);
                }
                if (playery1 > 0)
                {
                    actualyway1 = playery1 - (playery1) - (playery1);
                }
                playerx1 = playerx1 + 215;
                actualyway1 = actualyway1 + 143;
                yellowpicbox.Location = new Point(playerx1, actualyway1);
                if (player1imp.Text.Equals("1"))
                {
                    imp1.Location = new Point(yellowpicbox.Location.X + 6, yellowpicbox.Location.Y + 6);
                    imp1.Visible = true;
                }
                if (!player1name.Text.Equals(""))
                {
                    yellowpicbox.Visible = true;
                }

                playerx2 = playerx2 * 9;
                playery2 = playery2 * 9;
                int actualyway2 = 0;
                //calculate
                if (playery2 < 0)
                {
                    actualyway2 = playery2 - (playery2) - (playery2);
                }
                if (playery2 > 0)
                {
                    actualyway2 = playery2 - (playery2) - (playery2);
                }
                playerx2 = playerx2 + 215;
                actualyway2 = actualyway2 + 143;
                pinkpicbox.Location = new Point(playerx2, actualyway2);
                if (player2imp.Text.Equals("1"))
                {
                    imp2.Location = new Point(pinkpicbox.Location.X + 6, pinkpicbox.Location.Y + 6);
                    imp2.Visible = true;
                }
                if (!player2name.Text.Equals(""))
                {
                    pinkpicbox.Visible = true;
                }

                playerx3 = playerx3 * 9;
                playery3 = playery3 * 9;
                int actualyway3 = 0;
                //calculate
                if (playery3 < 0)
                {
                    actualyway3 = playery3 - (playery3) - (playery3);
                }
                if (playery3 > 0)
                {
                    actualyway3 = playery3 - (playery3) - (playery3);
                }
                playerx3 = playerx3 + 215;
                actualyway3 = actualyway3 + 143;
                greenpicbox.Location = new Point(playerx3, actualyway3);
                if (player3imp.Text.Equals("1"))
                {
                    imp3.Location = new Point(greenpicbox.Location.X + 6, greenpicbox.Location.Y + 6);
                    imp3.Visible = true;
                }
                if (!player3name.Text.Equals(""))
                {
                    greenpicbox.Visible = true;
                }

                playerx4 = playerx4 * 9;
                playery4 = playery4 * 9;
                int actualyway4 = 0;
                //calculate
                if (playery4 < 0)
                {
                    actualyway4 = playery4 - (playery4) - (playery4);
                }
                if (playery4 > 0)
                {
                    actualyway4 = playery4 - (playery4) - (playery4);
                }
                playerx4 = playerx4 + 215;
                actualyway4 = actualyway4 + 143;
                bluepicbox.Location = new Point(playerx4, actualyway4);
                if (player4imp.Text.Equals("1"))
                {
                    imp4.Location = new Point(bluepicbox.Location.X + 6, bluepicbox.Location.Y + 6);
                    imp4.Visible = true;
                }
                if (!player4name.Text.Equals(""))
                {
                    bluepicbox.Visible = true;
                }

                playerx5 = playerx5 * 9;
                playery5 = playery5 * 9;
                int actualyway5 = 0;
                //calculate
                if (playery5 < 0)
                {
                    actualyway5 = playery5 - (playery5) - (playery5);
                }
                if (playery5 > 0)
                {
                    actualyway5 = playery5 - (playery5) - (playery5);
                }
                playerx5 = playerx5 + 215;
                actualyway5 = actualyway5 + 143;
                lightbluepicbox.Location = new Point(playerx5, actualyway5);
                if (player5imp.Text.Equals("1"))
                {
                    imp5.Location = new Point(lightbluepicbox.Location.X + 6, lightbluepicbox.Location.Y + 6);
                    imp5.Visible = true;
                }
                if (!player5name.Text.Equals(""))
                {
                    lightbluepicbox.Visible = true;
                }

                playerx6 = playerx6 * 9;
                playery6 = playery6 * 9;
                int actualyway6 = 0;
                //calculate
                if (playery6 < 0)
                {
                    actualyway6 = playery6 - (playery6) - (playery6);
                }
                if (playery6 > 0)
                {
                    actualyway6 = playery6 - (playery6) - (playery6);
                }
                playerx6 = playerx6 + 215;
                actualyway6 = actualyway6 + 143;
                whitepicbox.Location = new Point(playerx6, actualyway6);
                if (player6imp.Text.Equals("1"))
                {
                    imp6.Location = new Point(whitepicbox.Location.X + 6, whitepicbox.Location.Y + 6);
                    imp6.Visible = true;
                }
                if (!player6name.Text.Equals(""))
                {
                    whitepicbox.Visible = true;
                }

                playerx7 = playerx7 * 9;
                playery7 = playery7 * 9;
                int actualyway7 = 0;
                //calculate
                if (playery7 < 0)
                {
                    actualyway7 = playery7 - (playery7) - (playery7);
                }
                if (playery7 > 0)
                {
                    actualyway7 = playery7 - (playery7) - (playery7);
                }
                playerx7 = playerx7 + 215;
                actualyway7 = actualyway7 + 143;
                orangepicbox.Location = new Point(playerx7, actualyway7);
                if (player7imp.Text.Equals("1"))
                {
                    imp7.Location = new Point(orangepicbox.Location.X + 6, orangepicbox.Location.Y + 6);
                    imp7.Visible = true;
                }
                if (!player7name.Text.Equals(""))
                {
                    orangepicbox.Visible = true;
                }

                playerx8 = playerx8 * 9;
                playery8 = playery8 * 9;
                int actualyway8 = 0;
                //calculate
                if (playery8 < 0)
                {
                    actualyway8 = playery8 - (playery8) - (playery8);
                }
                if (playery8 > 0)
                {
                    actualyway8 = playery8 - (playery8) - (playery8);
                }
                playerx8 = playerx8 + 215;
                actualyway8 = actualyway8 + 143;
                redpicbox.Location = new Point(playerx8, actualyway8);
                if (player8imp.Text.Equals("1"))
                {
                    imp8.Location = new Point(redpicbox.Location.X + 6, redpicbox.Location.Y + 6);
                    imp8.Visible = true;
                }
                if (!player8name.Text.Equals(""))
                {
                    redpicbox.Visible = true;
                }


                playerx9 = playerx9 * 9;
                playery9 = playery9 * 9;
                int actualyway9 = 0;
                //calculate
                if (playery9 < 0)
                {
                    actualyway9 = playery9 - (playery9) - (playery9);
                }
                if (playery9 > 0)
                {
                    actualyway9 = playery9 - (playery9) - (playery9);
                }
                playerx9 = playerx9 + 215;
                actualyway9 = actualyway9 + 143;
                purplepicbox.Location = new Point(playerx9, actualyway9);
                if (player9imp.Text.Equals("1"))
                {
                    imp9.Location = new Point(purplepicbox.Location.X + 6, purplepicbox.Location.Y + 6);
                    imp9.Visible = true;
                }
                if (!player9name.Text.Equals(""))
                {
                    purplepicbox.Visible = true;
                }



                playerx10 = playerx10 * 9;
                playery10 = playery10 * 9;
                int actualyway10 = 0;
                //calculate
                if (playery10 < 0)
                {
                    actualyway10 = playery10 - (playery10) - (playery10);
                }
                if (playery10 > 0)
                {
                    actualyway10 = playery10 - (playery10) - (playery10);
                }
                playerx10 = playerx10 + 215;
                actualyway10 = actualyway10 + 143;
                rosepicbox.Location = new Point(playerx10, actualyway10);
                if (player10imp.Text.Equals("1"))
                {
                    imp10.Location = new Point(rosepicbox.Location.X + 6, rosepicbox.Location.Y + 6);
                    imp10.Visible = true;
                }
                if (!player10name.Text.Equals(""))
                {
                    rosepicbox.Visible = true;
                }
            }
            if(map == 2)
            {
                //radar

                playerx1 = playerx1 * 9;
                playery1 = playery1 * 9;
                int actualyway1 = 0;
                //calculate
                if (playery1 < 0)
                {
                    actualyway1 = playery1 - (playery1) - (playery1);
                }
                if (playery1 > 0)
                {
                    actualyway1 = playery1 - (playery1) - (playery1);
                }
                playerx1 = playerx1 + 100;
                actualyway1 = actualyway1 + 258;
                yellowpicbox.Location = new Point(playerx1, actualyway1);
                if (player1imp.Text.Equals("1"))
                {
                    imp1.Location = new Point(yellowpicbox.Location.X + 6, yellowpicbox.Location.Y + 6);
                    imp1.Visible = true;
                }
                if (!player1name.Text.Equals(""))
                {
                    yellowpicbox.Visible = true;
                }

                playerx2 = playerx2 * 9;
                playery2 = playery2 * 9;
                int actualyway2 = 0;
                //calculate
                if (playery2 < 0)
                {
                    actualyway2 = playery2 - (playery2) - (playery2);
                }
                if (playery2 > 0)
                {
                    actualyway2 = playery2 - (playery2) - (playery2);
                }
                playerx2 = playerx2 + 100;
                actualyway2 = actualyway2 + 258;
                pinkpicbox.Location = new Point(playerx2, actualyway2);
                if (player2imp.Text.Equals("1"))
                {
                    imp2.Location = new Point(pinkpicbox.Location.X + 6, pinkpicbox.Location.Y + 6);
                    imp2.Visible = true;
                }
                if (!player2name.Text.Equals(""))
                {
                    pinkpicbox.Visible = true;
                }

                playerx3 = playerx3 * 9;
                playery3 = playery3 * 9;
                int actualyway3 = 0;
                //calculate
                if (playery3 < 0)
                {
                    actualyway3 = playery3 - (playery3) - (playery3);
                }
                if (playery3 > 0)
                {
                    actualyway3 = playery3 - (playery3) - (playery3);
                }
                playerx3 = playerx3 + 100;
                actualyway3 = actualyway3 + 258;
                greenpicbox.Location = new Point(playerx3, actualyway3);
                if (player3imp.Text.Equals("1"))
                {
                    imp3.Location = new Point(greenpicbox.Location.X + 6, greenpicbox.Location.Y + 6);
                    imp3.Visible = true;
                }
                if (!player3name.Text.Equals(""))
                {
                    greenpicbox.Visible = true;
                }

                playerx4 = playerx4 * 9;
                playery4 = playery4 * 9;
                int actualyway4 = 0;
                //calculate
                if (playery4 < 0)
                {
                    actualyway4 = playery4 - (playery4) - (playery4);
                }
                if (playery4 > 0)
                {
                    actualyway4 = playery4 - (playery4) - (playery4);
                }
                playerx4 = playerx4 + 100;
                actualyway4 = actualyway4 + 258;
                bluepicbox.Location = new Point(playerx4, actualyway4);
                if (player4imp.Text.Equals("1"))
                {
                    imp4.Location = new Point(bluepicbox.Location.X + 6, bluepicbox.Location.Y + 6);
                    imp4.Visible = true;
                }
                if (!player4name.Text.Equals(""))
                {
                    bluepicbox.Visible = true;
                }

                playerx5 = playerx5 * 9;
                playery5 = playery5 * 9;
                int actualyway5 = 0;
                //calculate
                if (playery5 < 0)
                {
                    actualyway5 = playery5 - (playery5) - (playery5);
                }
                if (playery5 > 0)
                {
                    actualyway5 = playery5 - (playery5) - (playery5);
                }
                playerx5 = playerx5 + 100;
                actualyway5 = actualyway5 + 258;
                lightbluepicbox.Location = new Point(playerx5, actualyway5);
                if (player5imp.Text.Equals("1"))
                {
                    imp5.Location = new Point(lightbluepicbox.Location.X + 6, lightbluepicbox.Location.Y + 6);
                    imp5.Visible = true;
                }
                if (!player5name.Text.Equals(""))
                {
                    lightbluepicbox.Visible = true;
                }

                playerx6 = playerx6 * 9;
                playery6 = playery6 * 9;
                int actualyway6 = 0;
                //calculate
                if (playery6 < 0)
                {
                    actualyway6 = playery6 - (playery6) - (playery6);
                }
                if (playery6 > 0)
                {
                    actualyway6 = playery6 - (playery6) - (playery6);
                }
                playerx6 = playerx6 + 100;
                actualyway6 = actualyway6 + 258;
                whitepicbox.Location = new Point(playerx6, actualyway6);
                if (player6imp.Text.Equals("1"))
                {
                    imp6.Location = new Point(whitepicbox.Location.X + 6, whitepicbox.Location.Y + 6);
                    imp6.Visible = true;
                }
                if (!player6name.Text.Equals(""))
                {
                    whitepicbox.Visible = true;
                }

                playerx7 = playerx7 * 9;
                playery7 = playery7 * 9;
                int actualyway7 = 0;
                //calculate
                if (playery7 < 0)
                {
                    actualyway7 = playery7 - (playery7) - (playery7);
                }
                if (playery7 > 0)
                {
                    actualyway7 = playery7 - (playery7) - (playery7);
                }
                playerx7 = playerx7 + 100;
                actualyway7 = actualyway7 + 258;
                orangepicbox.Location = new Point(playerx7, actualyway7);
                if (player7imp.Text.Equals("1"))
                {
                    imp7.Location = new Point(orangepicbox.Location.X + 6, orangepicbox.Location.Y + 6);
                    imp7.Visible = true;
                }
                if (!player7name.Text.Equals(""))
                {
                    orangepicbox.Visible = true;
                }

                playerx8 = playerx8 * 9;
                playery8 = playery8 * 9;
                int actualyway8 = 0;
                //calculate
                if (playery8 < 0)
                {
                    actualyway8 = playery8 - (playery8) - (playery8);
                }
                if (playery8 > 0)
                {
                    actualyway8 = playery8 - (playery8) - (playery8);
                }
                playerx8 = playerx8 + 100;
                actualyway8 = actualyway8 + 258;
                redpicbox.Location = new Point(playerx8, actualyway8);
                if (player8imp.Text.Equals("1"))
                {
                    imp8.Location = new Point(redpicbox.Location.X + 6, redpicbox.Location.Y + 6);
                    imp8.Visible = true;
                }
                if (!player8name.Text.Equals(""))
                {
                    redpicbox.Visible = true;
                }


                playerx9 = playerx9 * 9;
                playery9 = playery9 * 9;
                int actualyway9 = 0;
                //calculate
                if (playery9 < 0)
                {
                    actualyway9 = playery9 - (playery9) - (playery9);
                }
                if (playery9 > 0)
                {
                    actualyway9 = playery9 - (playery9) - (playery9);
                }
                playerx9 = playerx9 + 100;
                actualyway9 = actualyway9 + 258;
                purplepicbox.Location = new Point(playerx9, actualyway9);
                if (player9imp.Text.Equals("1"))
                {
                    imp9.Location = new Point(purplepicbox.Location.X + 6, purplepicbox.Location.Y + 6);
                    imp9.Visible = true;
                }
                if (!player9name.Text.Equals(""))
                {
                    purplepicbox.Visible = true;
                }



                playerx10 = playerx10 * 9;
                playery10 = playery10 * 9;
                int actualyway10 = 0;
                //calculate
                if (playery10 < 0)
                {
                    actualyway10 = playery10 - (playery10) - (playery10);
                }
                if (playery10 > 0)
                {
                    actualyway10 = playery10 - (playery10) - (playery10);
                }
                playerx10 = playerx10 + 100;
                actualyway10 = actualyway10 + 258;
                rosepicbox.Location = new Point(playerx10, actualyway10);
                if (player10imp.Text.Equals("1"))
                {
                    imp10.Location = new Point(rosepicbox.Location.X + 6, rosepicbox.Location.Y + 6);
                    imp10.Visible = true;
                }
                if (!player10name.Text.Equals(""))
                {
                    rosepicbox.Visible = true;
                }

            }
            if (map == 3)
            {
                //radar

                playerx1 = playerx1 * 9;
                playery1 = playery1 * 9;
                int actualyway1 = 0;
                //calculate
                if (playery1 < 0)
                {
                    actualyway1 = playery1 - (playery1) - (playery1);
                }
                if (playery1 > 0)
                {
                    actualyway1 = playery1 - (playery1) - (playery1);
                }
                playerx1 = playerx1 + 55;
                actualyway1 = actualyway1 + 50;
                yellowpicbox.Location = new Point(playerx1, actualyway1);
                if (player1imp.Text.Equals("1"))
                {
                    imp1.Location = new Point(yellowpicbox.Location.X + 6, yellowpicbox.Location.Y + 6);
                    imp1.Visible = true;
                }
                if (!player1name.Text.Equals(""))
                {
                    yellowpicbox.Visible = true;
                }

                playerx2 = playerx2 * 9;
                playery2 = playery2 * 9;
                int actualyway2 = 0;
                //calculate
                if (playery2 < 0)
                {
                    actualyway2 = playery2 - (playery2) - (playery2);
                }
                if (playery2 > 0)
                {
                    actualyway2 = playery2 - (playery2) - (playery2);
                }
                playerx2 = playerx2 + 55;
                actualyway2 = actualyway2 + 50;
                pinkpicbox.Location = new Point(playerx2, actualyway2);
                if (player2imp.Text.Equals("1"))
                {
                    imp2.Location = new Point(pinkpicbox.Location.X + 6, pinkpicbox.Location.Y + 6);
                    imp2.Visible = true;
                }
                if (!player2name.Text.Equals(""))
                {
                    pinkpicbox.Visible = true;
                }

                playerx3 = playerx3 * 9;
                playery3 = playery3 * 9;
                int actualyway3 = 0;
                //calculate
                if (playery3 < 0)
                {
                    actualyway3 = playery3 - (playery3) - (playery3);
                }
                if (playery3 > 0)
                {
                    actualyway3 = playery3 - (playery3) - (playery3);
                }
                playerx3 = playerx3 + 55;
                actualyway3 = actualyway3 + 50;
                greenpicbox.Location = new Point(playerx3, actualyway3);
                if (player3imp.Text.Equals("1"))
                {
                    imp3.Location = new Point(greenpicbox.Location.X + 6, greenpicbox.Location.Y + 6);
                    imp3.Visible = true;
                }
                if (!player3name.Text.Equals(""))
                {
                    greenpicbox.Visible = true;
                }

                playerx4 = playerx4 * 9;
                playery4 = playery4 * 9;
                int actualyway4 = 0;
                //calculate
                if (playery4 < 0)
                {
                    actualyway4 = playery4 - (playery4) - (playery4);
                }
                if (playery4 > 0)
                {
                    actualyway4 = playery4 - (playery4) - (playery4);
                }
                playerx4 = playerx4 + 55;
                actualyway4 = actualyway4 + 50;
                bluepicbox.Location = new Point(playerx4, actualyway4);
                if (player4imp.Text.Equals("1"))
                {
                    imp4.Location = new Point(bluepicbox.Location.X + 6, bluepicbox.Location.Y + 6);
                    imp4.Visible = true;
                }
                if (!player4name.Text.Equals(""))
                {
                    bluepicbox.Visible = true;
                }

                playerx5 = playerx5 * 9;
                playery5 = playery5 * 9;
                int actualyway5 = 0;
                //calculate
                if (playery5 < 0)
                {
                    actualyway5 = playery5 - (playery5) - (playery5);
                }
                if (playery5 > 0)
                {
                    actualyway5 = playery5 - (playery5) - (playery5);
                }
                playerx5 = playerx5 + 55;
                actualyway5 = actualyway5 + 50;
                lightbluepicbox.Location = new Point(playerx5, actualyway5);
                if (player5imp.Text.Equals("1"))
                {
                    imp5.Location = new Point(lightbluepicbox.Location.X + 6, lightbluepicbox.Location.Y + 6);
                    imp5.Visible = true;
                }
                if (!player5name.Text.Equals(""))
                {
                    lightbluepicbox.Visible = true;
                }

                playerx6 = playerx6 * 9;
                playery6 = playery6 * 9;
                int actualyway6 = 0;
                //calculate
                if (playery6 < 0)
                {
                    actualyway6 = playery6 - (playery6) - (playery6);
                }
                if (playery6 > 0)
                {
                    actualyway6 = playery6 - (playery6) - (playery6);
                }
                playerx6 = playerx6 + 55;
                actualyway6 = actualyway6 + 50;
                whitepicbox.Location = new Point(playerx6, actualyway6);
                if (player6imp.Text.Equals("1"))
                {
                    imp6.Location = new Point(whitepicbox.Location.X + 6, whitepicbox.Location.Y + 6);
                    imp6.Visible = true;
                }
                if (!player6name.Text.Equals(""))
                {
                    whitepicbox.Visible = true;
                }

                playerx7 = playerx7 * 9;
                playery7 = playery7 * 9;
                int actualyway7 = 0;
                //calculate
                if (playery7 < 0)
                {
                    actualyway7 = playery7 - (playery7) - (playery7);
                }
                if (playery7 > 0)
                {
                    actualyway7 = playery7 - (playery7) - (playery7);
                }
                playerx7 = playerx7 + 55;
                actualyway7 = actualyway7 + 50;
                orangepicbox.Location = new Point(playerx7, actualyway7);
                if (player7imp.Text.Equals("1"))
                {
                    imp7.Location = new Point(orangepicbox.Location.X + 6, orangepicbox.Location.Y + 6);
                    imp7.Visible = true;
                }
                if (!player7name.Text.Equals(""))
                {
                    orangepicbox.Visible = true;
                }

                playerx8 = playerx8 * 9;
                playery8 = playery8 * 9;
                int actualyway8 = 0;
                //calculate
                if (playery8 < 0)
                {
                    actualyway8 = playery8 - (playery8) - (playery8);
                }
                if (playery8 > 0)
                {
                    actualyway8 = playery8 - (playery8) - (playery8);
                }
                playerx8 = playerx8 + 55;
                actualyway8 = actualyway8 + 50;
                redpicbox.Location = new Point(playerx8, actualyway8);
                if (player8imp.Text.Equals("1"))
                {
                    imp8.Location = new Point(redpicbox.Location.X + 6, redpicbox.Location.Y + 6);
                    imp8.Visible = true;
                }
                if (!player8name.Text.Equals(""))
                {
                    redpicbox.Visible = true;
                }


                playerx9 = playerx9 * 9;
                playery9 = playery9 * 9;
                int actualyway9 = 0;
                //calculate
                if (playery9 < 0)
                {
                    actualyway9 = playery9 - (playery9) - (playery9);
                }
                if (playery9 > 0)
                {
                    actualyway9 = playery9 - (playery9) - (playery9);
                }
                playerx9 = playerx9 + 55;
                actualyway9 = actualyway9 + 50;
                purplepicbox.Location = new Point(playerx9, actualyway9);
                if (player9imp.Text.Equals("1"))
                {
                    imp9.Location = new Point(purplepicbox.Location.X + 6, purplepicbox.Location.Y + 6);
                    imp9.Visible = true;
                }
                if (!player9name.Text.Equals(""))
                {
                    purplepicbox.Visible = true;
                }



                playerx10 = playerx10 * 9;
                playery10 = playery10 * 9;
                int actualyway10 = 0;
                //calculate
                if (playery10 < 0)
                {
                    actualyway10 = playery10 - (playery10) - (playery10);
                }
                if (playery10 > 0)
                {
                    actualyway10 = playery10 - (playery10) - (playery10);
                }
                playerx10 = playerx10 + 55;
                actualyway10 = actualyway10 + 50;
                rosepicbox.Location = new Point(playerx10, actualyway10);
                if (player10imp.Text.Equals("1"))
                {
                    imp10.Location = new Point(rosepicbox.Location.X + 6, rosepicbox.Location.Y + 6);
                    imp10.Visible = true;
                }
                if (!player10name.Text.Equals(""))
                {
                    rosepicbox.Visible = true;
                }
            }
        }

        private void map1_Click(object sender, EventArgs e)
        {
            map = 1;
            theskeld.Visible = true;
            Mirahq.Visible = false;
            polus.Visible = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            map = 2;
            theskeld.Visible = false;
            Mirahq.Visible = true;
            polus.Visible = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            map = 3;
            theskeld.Visible = false;
            Mirahq.Visible = false;
            polus.Visible = true;
        }

        private void Mirahq_Click(object sender, EventArgs e)
        {

        }
    }
}
