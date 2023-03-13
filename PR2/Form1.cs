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

            dataGridView1.Columns[0].HeaderText = "���";
            dataGridView1.Columns[1].HeaderText = "�����";
            dataGridView1.Columns[2].HeaderText = "�������";
            dataGridView1.Columns[3].HeaderText = "����� ��������";
            dataGridView1.Columns[4].HeaderText = "������";
            dataGridView1.Columns[5].HeaderText = "������";


        }

        //����� �� �������
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "�����")
            {
                string inputtext = textBox1.Text.ToLower();//������� �������� �.� �������� � textbox �����
                var poisk = listBD.StudentList.Where(s => s.StringName.ToString().ToLower().Contains(inputtext) || s.CityName.ToString().ToLower().Contains(inputtext) || s.TitlePredmet.ToString().ToLower().Contains(inputtext) || s.TitleGroup.ToString().ToLower().Contains(inputtext) || s.TitleEducForm.ToString().ToLower().Contains(inputtext) || s.Ocenca.ToString().ToLower().Contains(inputtext))
                    .Select(s => s);
                dataGridView1.DataSource = poisk.ToList();//����� � ������� 
            }


        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { textBox1.Text = "�����"; }
        }
        //���������� �� �������
        private void label1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "��������")
            {
                var sort = listBD.StudentList.OrderByDescending(s => s.Ocenca)//���������� �� ��������
                    .Select(s => s);
                dataGridView1.DataSource = sort.ToList();//����� � �������
            }
            else if (comboBox1.Text == "�����������")
            {
                var sort = listBD.StudentList.OrderBy(s => s.Ocenca)//���������� �� �����������
                    .Select(s => s);
                dataGridView1.DataSource = sort.ToList();//����� � �������

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

        //���������� �� ����� ��������
        private void label2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                var philtr = listBD.StudentList.Where(s => s.TitleEducForm.ToString().Contains("�����"))//���������� �� ����� �����  
                    .Select(s => s);
                dataGridView1.DataSource = philtr.ToList();//����� � �������
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                var philtr = listBD.StudentList.Where(s => s.TitleEducForm.ToString().Contains("�������"))//���������� �� ������� �����  
                    .Select(s => s);
                dataGridView1.DataSource = philtr.ToList();//����� � �������

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
           // var add = listBD.StudentList
        }
    }
}