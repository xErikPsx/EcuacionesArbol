using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_ecuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nodo charExp;
        Arbol ar = new Arbol ();
        private void button1_Click(object sender, EventArgs e)
        {
            string ecuacion = txtEc.Text;

            char[] array = ecuacion.ToCharArray(); //pasa la exprecion a char dentro de un vectror;
            
            foreach (char charr in array) //pasa el vector a una lista
            {
                charExp = new Nodo(Convert.ToString(charr));
                ar.agregarLista(charExp);
            }

            //txtEc.Text = ar.reporte();            
            ar.crearArbol();
            
            txtPost.Text = ar.PostOrden();
            txtPre.Text = ar.PreOrden();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEc.Text = "1+2*3";
        }

        private void btnEvaluarPost_Click(object sender, EventArgs e)
        {
            string lPost = txtPost.Text;

            char[] array = lPost.ToCharArray();

            foreach (char charr in array)
            {
                charExp = new Nodo(Convert.ToString(charr));
                ar.agregarLista(charExp);
            }

            txtResPost.Text = ar.notacionPost();
            lblPruebas.Text = ar.reporte();
        }

        private void btnEvaluarPre_Click(object sender, EventArgs e)
        {
            string lPre = txtPre.Text;

            char[] array = lPre.ToCharArray();

            foreach (char charr in array)
            {
                charExp = new Nodo(Convert.ToString(charr));
                ar.agregarLista(charExp);
            }

            txtResPre.Text = ar.notacionPre();
        }
    }
}
