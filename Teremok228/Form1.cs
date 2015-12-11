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
    public partial class Form1 : Form
    {
        Random g_rnd = new Random();
        soul[] TPEOPLE;
        soul[] filt;

        string[] types;

        bool trigger = false; //Триггер вывода

        bool trg_0 = false; //Для проверки
        bool trg_1 = false;

        public Form1()
        {
            InitializeComponent();
            filters.Enabled = false;
            button1_cansel.Enabled = false;
            button1_add.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Киркоров-кнопка-start
        {
            textBox2.Text = "";
            while (true)
            {
                if (textBox1.TextLength == 0) break;
                
                System.Media.SoundPlayer SoundPlayer = new System.Media.SoundPlayer(Properties.Resources.CHpok);
                SoundPlayer.Load();
                SoundPlayer.Play();

                //Start

                BornPeople(Convert.ToInt32(textBox1.Text));
                MakeList(TPEOPLE);

                types = Dist_Mass(TPEOPLE); //Кто есть в списке
                MakeComboBox(types);

                trigger = false;

                button1_add.Enabled = true;
                break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (trigger) //Либо сортированный, либо начальный массив
                {
                    Stats(filt, listBox1.SelectedIndex);
                    filt[listBox1.SelectedIndex].Sound();
                }
                else
                {
                    Stats(TPEOPLE, listBox1.SelectedIndex);
                    TPEOPLE[listBox1.SelectedIndex].Sound();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Только цифры 0-9
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8) e.Handled = true;
        }

        private void BornPeople(int a){ //Генерим
            TPEOPLE = new soul[a];
            for (int i = 0; i < TPEOPLE.Length; i++ )
            {
                switch(g_rnd.Next(0,3)){
                    case 0: TPEOPLE[i] = new Bear(g_rnd.Next(200, 500), g_rnd.Next(180, 300), Convert.ToBoolean(g_rnd.Next(0, 2)), g_rnd.Next(0, 3), g_rnd.Next(0, 3), g_rnd.Next(0, 3), Convert.ToString(g_rnd.Next(1, 32) + "-" + g_rnd.Next(1, 13) + "-" + g_rnd.Next(1000, 2000))); break;
                    case 1: TPEOPLE[i] = new Dwarf(g_rnd.Next(80, 200), g_rnd.Next(80, 120), Convert.ToBoolean(g_rnd.Next(0, 2)), g_rnd.Next(0, 3), g_rnd.Next(0, 3), g_rnd.Next(0, 3), Convert.ToString(g_rnd.Next(1, 32) + "-" + g_rnd.Next(1, 13) + "-" + g_rnd.Next(1000, 2000))); break;
                    case 2: TPEOPLE[i] = new Gorilla(g_rnd.Next(60, 130), g_rnd.Next(130, 200), Convert.ToBoolean(g_rnd.Next(0, 2)), g_rnd.Next(0, 3), g_rnd.Next(0, 3), g_rnd.Next(0, 3), Convert.ToString(g_rnd.Next(1, 32) + "-" + g_rnd.Next(1, 13) + "-" + g_rnd.Next(1000, 2000))); break;
                    default: break;
                }
            }

        }
        private void MakeList(soul[] mass) //Добавляем объекты в лист бокс
        {
            listBox1.Items.Clear();
            for (int i = 0; i < mass.Length; i++ )
            {
                listBox1.Items.Add(mass[i].Name);
            }
        }
        private void Stats(soul[] mass, int a) //Выводим статы каждого
        {
            textBox2.Text = "Имя: " + mass[a].Name + "\r\n"
                + "Тип: " + mass[a].Type + "\r\n"
                + "Рост: " + mass[a].Height + "\r\n"
                + "Вес: " + mass[a].Weight + "\r\n"
                + "Дата рождения: " + mass[a].Date + "\r\n"
                + "Цвет глаз: " + mass[a].Color_Eyes + "\r\n"
                + "Цвет волос: " + mass[a].Color_Head + "\r\n"
                + "Пол: " + mass[a].Sex + "\r\n"
                + "Ориентация: " + mass[a].Orientation + "\r\n";
        }

        private void filters_Click(object sender, EventArgs e) //Фильтр-кнопка
        {
            if(comboBox1_type.SelectedIndex != -1 || comboBox2_items.SelectedIndex != -1)
            {
                Object selecteditem = comboBox2_items.SelectedItem;
                filt = Vision_Sort(TPEOPLE, selecteditem.ToString(), comboBox1_type.SelectedIndex);

                trigger = true;
                MakeList(filt);

                button1_cansel.Enabled = true;
            }
        }

        private soul[] Vision_Sort(soul[] mass, string who, int method)
        {
            soul[] n_mass = new soul[1]; //шоб не агрился

            int val = 0;
            int count = 0;

            switch (method)
            {
                case 0: //Кроме
                    for (int i = 0; i < mass.Length; i++) if (mass[i].Type != who) val++; //Определяю размер нового массива

                    n_mass = new soul[val]; //пересоздаю

                    for (int i = 0; i < mass.Length; i++)
                    {
                        if (mass[i].Type != who)
                        {
                            n_mass[count] = mass[i];
                            count++;
                        }
                    }

                    break;
                case 1: //Только
                    for (int i = 0; i < mass.Length; i++) if (mass[i].Type == who) val++; //Определяю размер нового массива

                    n_mass = new soul[val]; //пересоздаю

                    for (int i = 0; i < mass.Length; i++ )
                    {
                        if (mass[i].Type == who)
                        {
                            n_mass[count] = mass[i];
                            count++;
                        }
                    }

                    break;
                default: break;
            }

            return n_mass; //Отдаю
        }

        private string[] Dist_Mass(soul[] mass) //Удалить дубли
        {
            string[] nm = new string[mass.Length];
            for (int i = 0; i < mass.Length; i++) nm[i] = mass[i].Type;
            nm = nm.Distinct().ToArray();

            return nm;
        }

        private void MakeComboBox(string[] mass) //Заполняем варианты
        {
            comboBox2_items.Items.Clear();
            for (int i = 0; i < mass.Length; i++)
            {
                comboBox2_items.Items.Add(mass[i]);
            }
        }

        private void comboBox1_type_SelectedIndexChanged(object sender, EventArgs e) //Чисто для проверки
        {
            if (comboBox1_type.SelectedIndex != -1) trg_0 = true;
            else trg_0 = false;

            if (trg_0 && trg_1) filters.Enabled = true;
            else filters.Enabled = false;
        }

        private void comboBox2_items_SelectedIndexChanged(object sender, EventArgs e) // - " -
        {
            if (comboBox1_type.SelectedIndex != -1) trg_1 = true;
            else trg_1 = false;

            if (trg_0 && trg_1) filters.Enabled = true;
            else filters.Enabled = false;
        }

        private void button1_cansel_Click(object sender, EventArgs e) //Выводим обратно начальный массив
        {
            trigger = false;
            MakeList(TPEOPLE);

            button1_cansel.Enabled = false;
        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            NewGen np = new NewGen();
            np.ShowDialog();
            if (np.DialogResult == DialogResult.OK)
            {
                Array.Resize(ref TPEOPLE, TPEOPLE.Length + 1);
                TPEOPLE[TPEOPLE.Length - 1] = np.givemeSoul;
                MakeList(TPEOPLE);

                types = Dist_Mass(TPEOPLE); //Кто есть в списке
                MakeComboBox(types);
            }
            else
            {
                //Nothing
            }
        }
    }
}
