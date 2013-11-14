using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security.Cryptography;



namespace Clinica_Frba
{
    class Validar
    {
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static bool noVacio(String txt)
        {
            if (!string.IsNullOrEmpty(txt))
                return true;
            else return false;
        }

        public static string getHashSha256(string text)
        {
            SHA256CryptoServiceProvider shaM = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(text);
            byte[] hashedBytes = shaM.ComputeHash(inputBytes);
            StringBuilder pass_hasheado = new StringBuilder();
            for (int i = 0; i < hashedBytes.Length; i++)
            pass_hasheado.Append(hashedBytes[i].ToString("x2").ToLower());
            return pass_hasheado.ToString();

            
        }

        public static int anteriorDosDias(DateTime fecha)
        {
            TimeSpan dosDias = TimeSpan.FromDays(2);
            DateTime dia = DateTime.Today.Subtract(dosDias);
            int numero = dia.CompareTo(fecha);
            return numero;
        }

        public static void textoNumeros(String texto) 
        {
            foreach (char letra in texto)
            {
                if (!char.IsDigit(letra))
                {
                    throw new Exception("El texto contiende caracteres invalidos");
                }
            }
        }

        public static void nroAfiliadoExiste(int nroAfiliado) 
        {
            SqlCommand miCommand = new SqlCommand("Free_Running.usuarioExisteActivo", Conexion.Conectar());
            miCommand.CommandType=CommandType.StoredProcedure;
            miCommand.Parameters.Add("@nroAfiliado",SqlDbType.Int);
            miCommand.Parameters["@nroAfiliado"].Direction=ParameterDirection.Input;
            miCommand.Parameters["@nroAfiliado"].Value= nroAfiliado;

            miCommand.Parameters.Add("@salida",SqlDbType.Int);
            miCommand.Parameters["@salida"].Direction= ParameterDirection.Output;

            miCommand.ExecuteNonQuery();

            switch(Convert.ToInt32(miCommand.Parameters["@salida"].Value))
            {
                case 0:
                    throw new Exception("El afiliado no existe");
                case -1:
                    throw new Exception("El afiliado no está activo");
            }            
        }

    }
}

