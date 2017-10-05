using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.ExtensionMethods
{

    public static class ExtensionMethods
    {
        public static string GetBaseUrl(this HttpRequestBase request)
        {
            if (request.Url == (Uri)null)
                return string.Empty;
            else
                return request.Url.Scheme + "://" + request.Url.Authority + VirtualPathUtility.ToAbsolute("~/");
        }

        public static string FormataTextoPrimLetraMaiusc(this string texto)
        {

            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            return cultureinfo.TextInfo.ToTitleCase(texto);

        }

        public static bool validarCPF(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;
        }


    }//class


}
