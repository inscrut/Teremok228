using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teremok228
{
    public partial class NewGen : Form
    {
        Random _rnd = new Random();
        private soul newSoul;
        public soul givemeSoul { get { return newSoul; } }

        public NewGen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1_type.SelectedIndex == -1 || comboBox2_sex.SelectedIndex == -1 || textBox3_date.TextLength == 0) { return; }
            else
            {

                switch (comboBox1_type.SelectedIndex)
                {
                    case 0:
                        newSoul = new Gorilla(_rnd.Next(60, 130), _rnd.Next(130, 200), Convert.ToBoolean(comboBox2_sex.SelectedIndex), _rnd.Next(0, 3), _rnd.Next(0, 3), _rnd.Next(0, 3), textBox3_date.Text);
                        break;
                    case 1:
                        newSoul = new Bear(_rnd.Next(200, 500), _rnd.Next(180, 300), Convert.ToBoolean(comboBox2_sex.SelectedIndex), _rnd.Next(0, 3), _rnd.Next(0, 3), _rnd.Next(0, 3), textBox3_date.Text);
                        break;
                    case 2:
                        newSoul = new Dwarf(_rnd.Next(80, 200), _rnd.Next(80, 120), Convert.ToBoolean(comboBox2_sex.SelectedIndex), _rnd.Next(0, 3), _rnd.Next(0, 3), _rnd.Next(0, 3), textBox3_date.Text);
                        break;
                    default: break;
                }


                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
