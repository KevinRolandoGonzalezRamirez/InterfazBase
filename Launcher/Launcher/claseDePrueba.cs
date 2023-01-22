using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class claseDePrueba : Form
    {
        public claseDePrueba()
        {
            InitializeComponent();
        }

        

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();

            archivo.crearArchivo(@"C:\Binarios\", "prueba");//la arroba es una excepción de "\"
            
        }
    }
}
