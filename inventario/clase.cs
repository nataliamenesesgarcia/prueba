using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace inventario
{
    public class Resultado
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        
        public string informacion()
        {
            return $"postId:{postId} \nid:{id} \name:{name} \nemail:{email} \nbody:{body}";
        }
        public string Email
        {

            get { return email; }
        }
        public int Id
        {
            get { return id; }
        }


    }

    public class Data
    {
        private static string _url;
        private static int _num;
        private static Resultado[] _resultados;
        private static string _boton;
        private static int _id;
        private static string _email;

        public static void Url_set (string url)
        {
           
            _url = url;

        }

        public static void NumSet(int num)
        {

            _num = num;

        }

        public static void BotonSet(string boton)
        {

            _boton = boton;

        }
        public static void ResultSet(Resultado[] resultados)
        {

            _resultados = resultados;

        }

        public static void IdSet(int id)
        {
            _id = id;
        }
        public static void EmailSet(string email)
        {
            _email = email;
        }

        public static string Url_get() { return _url; }
        public static int num_get() { return _num; }

        public static string boton_get() { return _boton; }
        public static int Id_Get() { return _id; }
        public static string Email_Get() { return _email; }

        public static Resultado[] Result_get () { return _resultados; }

        public static Resultado[] GetData(int num, Resultado[] resultado,string boton)
        {
            switch (boton)
            {
                case "PostId":
                    var resultoOrd = resultado.OrderBy(objeto => objeto.postId).ToArray();
                    return resultoOrd.Take(num).ToArray();
                case "Id":
                    var resultoOrd2 = resultado.OrderBy(objeto => objeto.postId).ToArray();
                    return resultoOrd2.Take(num).ToArray();
                case "Name":
                    var resultoOrd3 = resultado.OrderBy(objeto => objeto.name).ToArray();
                    return resultoOrd3.Take(num).ToArray();
                case "Email":
                    var resultoOrd4 = resultado.OrderBy(objeto => objeto.email).ToArray();
                    return resultoOrd4.Take(num).ToArray();
                case "Body":
                    var resultoOrd5 = resultado.OrderBy(objeto => objeto.body).ToArray();
                    return resultoOrd5.Take(num).ToArray();

                default:
                    var resultOrd = resultado.OrderBy(objeto => objeto.email).ToArray();
                    return resultOrd.Take(num).ToArray();
            }
           
        }

        public static string SearchData(int id, string email, Resultado[] resultado)
        {
            bool isTrueId = false;
            bool isTrueEmail = false;

            if (id == 0 && email == null) return "Error:no ingreso datos válidos";

            if (id > 0)
            {
                foreach (var objeto in resultado)
                {
                    if (objeto.Id == id)
                    {
                        isTrueId = true;
                        return objeto.informacion();

                    }

                }
                if (!isTrueId) return "Error:No se encontro el ID";
                isTrueId = false;
            }
            if (id <= 0 && !string.IsNullOrWhiteSpace(email) )
            {
                Regex regex = new Regex(email, RegexOptions.IgnoreCase);

                foreach (var objeto in resultado)
                {
                    if (regex.IsMatch(objeto.Email))
                    {
                        isTrueEmail = true;
                        return objeto.informacion();
                    }
                }
                if (!isTrueEmail) return "Error:no se encontro el email";


            }

            return "Error: no ingreso datos validos";
        }



    }


    
}
