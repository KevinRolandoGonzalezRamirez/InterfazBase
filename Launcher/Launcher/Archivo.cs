using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public class Archivo
    {

        public void crearCarpeta()
        {
            string folderPath = @"C:\Binarios";

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine(folderPath);

                }
            }catch (Exception e)
            {

                MessageBox.Show("No se pudo crear la carpeta binarios");
            }

        }

        public void crearArchivo(string ruta, string nombreDeArchivo)
        {
            

            string fileName = ruta + nombreDeArchivo + ".bin";//aca guardó así como también establezco el nombre del fichero .bin

            crearCarpeta();//función que crea la carpeta
            //MessageBox.Show(fileName);

            try
            {
                BinaryWriter bwStream = new BinaryWriter(new FileStream(fileName, FileMode.Create));// acción para crear el archivo en binario

                Encoding ascii = Encoding.ASCII;// creó que lo cifra en ascii
                BinaryWriter bwEncoder = new BinaryWriter(new FileStream(fileName, FileMode.Create), ascii);// escribe en binario
            }
            catch (Exception e){

                MessageBox.Show("No se pudo crear el archivo");
            }

            

        }

        //public void 
    }
}
