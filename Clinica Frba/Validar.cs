using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;//necesario para establecer la conexion
using System.Configuration;//necesario para establecer la conexion
using Clinica_Frba.Properties;



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

        public static bool existe_afiliado(string campo, long Parametro, string procedimiento)
        {
            bool result;

            SqlConnection miconexion = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("dbo." + procedimiento, miconexion);

            using (miconexion)
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@" + campo, Parametro);

                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Valor devuelto

                cmd.ExecuteNonQuery();

                int resultado = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();

                if (resultado == 1)
                {
                    result = true;
                }

                else result = false;

                return result;
            }
        }


        public static bool IsValidEmail(string strMailAddress)
        {

            return Regex.IsMatch(strMailAddress, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

        }

        public static bool integridad_de_datos(long Documento, string procedimiento)
        {

            SqlConnection miconexion = Conexion.Conectar();

            SqlCommand cmd = new SqlCommand("dbo." + procedimiento, miconexion);
            using (miconexion)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros si los hubieran

                cmd.Parameters.AddWithValue("@Documento", Documento);
                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Valor devuelto

                cmd.ExecuteNonQuery();

                int valorDeVerdad = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();

                if (valorDeVerdad == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}

