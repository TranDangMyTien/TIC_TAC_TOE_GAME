namespace TIC_TAC_TOE_GAME
{
    public partial class Form1 : Form
    {
        char who = 'O';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.LavenderBlush;
            //bt.BackColor = Color.White;
            if (who =='O')
            {
                bt.Text = "O";
                if (b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "" ||
                     b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "" ||
                     b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "" ||
                     b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "" ||
                     b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "" ||
                     b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "" ||
                     b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "" ||
                     b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != "")
                {
                    MessageBox.Show($"The winer is {who.ToString()} !!!");
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                    MessageBox.Show("Draw !!!"); //Full 
                who = 'X';

            }
            else if (who == 'X')
            {
                bt.Text = "X";
                if (b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "" ||
                     b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "" ||
                     b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "" ||
                     b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "" ||
                     b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "" ||
                     b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "" ||
                     b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "" ||
                     b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != "")
                {
                    MessageBox.Show($"The winer is {who.ToString()} !!!");
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                    MessageBox.Show("Draw !!!"); //Full 
                who = 'O';

            }
            movement++;

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'O';
            movement = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.LavenderBlush;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.LavenderBlush;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.LavenderBlush;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.LavenderBlush;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.LavenderBlush;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.LavenderBlush;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.LavenderBlush;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.LavenderBlush;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.LavenderBlush;
            tableLayoutPanel1.Enabled = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is Tic Tac Toe and the autor of this game is IT code");
        }
    }
}