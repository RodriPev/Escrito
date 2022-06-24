using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp6
{
    

    public partial class Form1 : Form
    {
        int años;
        int ci;
        string nom;
        string fecha;
        int horas;
        ArrayList listaAma = new ArrayList();
        ArrayList listaProf = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            años = Convert.ToInt32(textBox5.Text);
            ci = Convert.ToInt32(textBox1.Text);
            nom = textBox2.Text;
            fecha = textBox3.Text;



            Deportista AA = new Deportista(ci, nom, fecha, horas);
            listaAma.Add(AA);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listaAma.GetType());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    class Deportista
    {
        protected int ci { get; set; }
        protected string nom { get; set; }
        protected string fecha { get; set; }
        protected int horas { get; set; }

        public Deportista(int Ci, string Nom, string Fecha, int Horas)
        {
            ci = Ci;
            nom = Nom;
            fecha = Fecha;
            horas = Horas;
        }
    }
    class Amateur : Deportista
    {
        private int años { get; set; }
        public Amateur(int Años) : base (1, "","",1)
        {
            
            años = Años;

        }
    }
   
    
    
}
