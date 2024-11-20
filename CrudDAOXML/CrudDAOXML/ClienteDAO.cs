using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CrudDAOXML
{
    internal class ClienteDAO
    {
        private List<Cliente> clientes;
        
        public ClienteDAO()
        {
           clientes=new List<Cliente>();
        }


        public void adicionarCliente(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }

        public void removerCliente(Cliente cliente)
        {
            this.clientes.Remove(cliente);
        }

        public List<Cliente> getClientes() { 
            return this.clientes;
        }

        public void Salvar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List <Cliente>));
            FileStream fs = new FileStream("C:\\Users\\Pichau\\source\\repos\\CrudDAOXML\\CrudDAOXML\\Arquivo.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs,this. clientes);
            fs.Close();
        }

        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Cliente>));
            FileStream fs = new FileStream("C:\\Users\\Pichau\\source\\repos\\CrudDAOXML\\CrudDAOXML\\Arquivo.xml", FileMode.OpenOrCreate);

            try
            {
                this.clientes = ser.Deserialize(fs) as List<Cliente>;
            }
            catch (InvalidOperationException)
            {
                ser.Serialize(fs, clientes);
            }
            finally
            {
                fs.Close();
            }

         
        }

        
    }
}
