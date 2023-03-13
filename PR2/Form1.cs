using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form1 : Form
    {
        private ListBD listBD = new ListBD();
        public Form1()
        {


            InitializeComponent();
            listBD.Initialize();
            dataGridView1.DataSource = listBD.StudentList.ToList();

            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Город";
            dataGridView1.Columns[2].HeaderText = "Предмет";
            dataGridView1.Columns[3].HeaderText = "Форма обучения";
            dataGridView1.Columns[4].HeaderText = "Группа";
            dataGridView1.Columns[5].HeaderText = "Оценка";


        }

        //Поиск по таблице
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Поиск")
            {
                string inputtext = textBox1.Text.ToLower();//входное значение т.е вводимый в textbox текст
                var poisk = listBD.StudentList.Where(s => s.StringName.ToString().ToLower().Contains(inputtext) || s.CityName.ToString().ToLower().Contains(inputtext) || s.TitlePredmet.ToString().ToLower().Contains(inputtext) || s.TitleGroup.ToString().ToLower().Contains(inputtext) || s.TitleEducForm.ToString().ToLower().Contains(inputtext) || s.Ocenca.ToString().ToLower().Contains(inputtext))
                    .Select(s => s);
                dataGridView1.DataSource = poisk.ToList();//вывод в таблицу 
            }


        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { textBox1.Text = "Поиск"; }
        }
        //Сортировка по оценкам
        private void label1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Убывание")
            {
                var sort = listBD.StudentList.OrderByDescending(s => s.Ocenca)//сортировка по убыванию
                    .Select(s => s);
                dataGridView1.DataSource = sort.ToList();//вывод в таблицу
            }
            else if (comboBox1.Text == "Возрастание")
            {
                var sort = listBD.StudentList.OrderBy(s => s.Ocenca)//сортировка по возрастанию
                    .Select(s => s);
                dataGridView1.DataSource = sort.ToList();//вывод в таблицу

            }

        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        //фильтрация по форме обучения
        private void label2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                var philtr = listBD.StudentList.Where(s => s.TitleEducForm.ToString().Contains("Очная"))//фильтарция по очной форме  
                    .Select(s => s);
                dataGridView1.DataSource = philtr.ToList();//вывод в таблицу
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                var philtr = listBD.StudentList.Where(s => s.TitleEducForm.ToString().Contains("Заочная"))//фильтарция по заочной форме  
                    .Select(s => s);
                dataGridView1.DataSource = philtr.ToList();//вывод в таблицу

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
           // var add = listBD.StudentList
        }
    }
}