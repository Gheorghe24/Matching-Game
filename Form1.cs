using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoculetProiect
{
    public partial class Form1 : Form
    {
        Label firstclicked = null;
        Label secondclicked = null;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "$","$","!","!","l","l","o","o",
            "U","U","Q","Q","H","H","E","E"
        };
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconlabel.Text = icons[randomNumber];
                    iconlabel.ForeColor = iconlabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Brown)
                    return;
                if (firstclicked == null)
                {
                    firstclicked = clickedLabel;
                    clickedLabel.ForeColor = Color.Brown;
                    return;
                }
                secondclicked = clickedLabel;
                clickedLabel.ForeColor = Color.Brown; 
                winner();
                if (firstclicked.Text == secondclicked.Text)
                {
                    firstclicked = null;
                    secondclicked = null;
                    return;
                }
                timer1.Start();
            }
        }
        private void winner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    if (iconlabel.ForeColor == iconlabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Felicitari, ai castigat !");
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;
            firstclicked = null;
            secondclicked = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
