using System;
using System.IO;
namespace Ej3ComprobarFichero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Ruta del archivo a verificar
            string filePath = @"C:/campions.txt";

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                label1.Text = "Himno añadido";
                Console.WriteLine("El archivo existe");
            }
            else
            {
                using (FileStream fs = File.Create(filePath))
                {
                    fs.Close();
                }

                label1.Text = "El archivo se ha creado";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Alicante tiene tres cosas\r\nque en España son muy famosas\r\nson sus playas, son sus palmeras\r\ny su equipo es el mejor.\r\n\r\nTodos juntos y en armonía\r\nle animamos día tras día\r\nno hay equipo que se le iguale\r\nes el Hércules campeón.\r\n\r\n¡Ahí va!\r\ncuando juegan al ataque\r\ntodos temen su coraje.\r\n¡Ahí va!\r\nno hay rival que le resista\r\nes el Hércules campeón.\r\n\r\n¡¡¡¡ Es el Hércules campeón !!!!\r\n¡¡¡¡ Es el Hércules campeón !!!!\r\n\r\n");
                }
                
            }
        }
    } 
}