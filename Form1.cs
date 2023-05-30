using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Med
        {
            public string name;
            public int quantity;
            public int price;
            public int term;

            public Med(string n, int q, int p, int t)
            {
                this.name = n;
                this.quantity = q;
                this.price = p;
                this.term = t;
            }
        }

        Random rnd = new Random();
        string[] names = new string[5] {"Пенталгин", "Аспирин", "Турбослим", "Нурофен", "Новиган"};



        private void button1_Click(object sender, EventArgs e)
        {
            
            MaxMin();                        
        }


        Med[] medic = new Med[5];
        public void Info()
        {
            for (int i = 0; i < names.Length; i++)
            {
                medic[i].name = names[i];

                int quantity = rnd.Next(1, 20);
                medic[i].quantity = quantity;

                int price = rnd.Next(50, 500);
                medic[i].price = price;

                int term = rnd.Next(1, 12);
                medic[i].term = term;
                
            }
            MessageBox.Show($"Всего препаратов: {names.Length}");
        }

        public void MaxMin()
        {
            int max = int.MinValue;
            string name = "";

            int min = int.MaxValue;
            string name1 = "";

            for (int i = 0; i < medic.Length; i++)
            {
                if (max < medic[i].price)
                {
                    max = medic[i].price;
                    name = medic[i].name;
                }
                if (min > medic[i].price)
                {
                    min = medic[i].price;
                    name1 = medic[i].name;
                }
            }
            MessageBox.Show($"Самый дорогой препарат: {name}\n Цена препарата {name}: {max}\nСамый дешевый препарат: {name1}\nЦена препарата {name1}: {min}");
        }

        public void TERM()
        {
            
            for (int i = 0; i < medic.Length; i++)
            {
                if (medic[i].term > 3)
                {
                    MessageBox.Show($"Срок годности {medic[i].name}: {medic[i].term}");
                }
            }
        }

        public void TotalPrice()
        {
            int total = 0;

            for (int i = 0; i < medic.Length; i++)
            {
                int sum = medic[i].price * medic[i].quantity;
                total += sum;
            }
            MessageBox.Show($"Общая цена товаров: {total}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TERM();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalPrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Info();
        }
    }
}
