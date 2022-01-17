using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izvp_lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int id = 0;
        private int miss = 0;
        private List<Question> questions = new List<Question>();
        private void Form1_Load(object sender, EventArgs e)
        {

            questions.Add(new Question("2+2=?","4"));
            questions.Add(new Question("2+2*2=?", "6"));
            questions.Add(new Question("5-1", "4"));
            questions.Add(new Question("111-111=?", "0"));
            questions.Add(new Question("0*0+1=?", "1"));
            label1.Text = questions[0].QUestion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (!checkAnswer(textBox1.Text.Trim()))
            {
                label2.Text = "Невірно. Правильна відповідь: " + questions[id].Answer;
                miss++;
                if (miss > 2)
                {
                    label3.Text = "Ви програли";
                    panel1.Visible = false;
                    button1.Visible = true;
                    return;
                }
            }
            else
            {
                label2.Text = "Правильно.";
               
            }
            if (id != questions.Count - 1)
            {
                id++;
                label1.Text = questions[id].QUestion;
            }
            else
            {
                label3.Text = "Ви перемогли. Кількість помилок: "+miss;
                panel1.Visible = false;
                button1.Visible = true;
            }
            textBox1.Text = "";
        }
        

        private bool checkAnswer( string userAnswer)
        {
            if(questions[id].Answer.Equals(userAnswer))
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            panel1.Visible = true;
            button1.Visible = false;
            id = 0;
            miss = 0;
            label1.Text = questions[0].QUestion;
            label3.Text = "";
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}
