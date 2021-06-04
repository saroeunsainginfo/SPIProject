using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SPI_Class
{
    
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            car obj = new car(); // Create Obj to use class

            //obj.model = textBox1.Text; //Call Field model from class
            //obj.color = textBox2.Text;
            //obj.year = Convert.ToInt32(textBox3.Text);

            //MessageBox.Show("Car Model: "+ obj.model + "Color: "+ obj.color + "Produced Year: " + Convert.ToString(obj.year));
            obj.show(textBox1.Text,textBox2.Text, Convert.ToInt32(textBox3.Text));

        }
    }
    class car
    {
        public string model; //Assing Value While Declaration
        public string color;
        public int year;

        public void show(string a, string b, int c)
        {
            model = a;
            color = b;
            year = c;
             MessageBox.Show("Car Model: "+ model + " Color: " +color+" Produced year: " +Convert.ToString(year));
        }



    }



}
