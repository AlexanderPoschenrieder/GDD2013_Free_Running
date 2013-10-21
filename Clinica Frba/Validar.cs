using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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









    }
}

