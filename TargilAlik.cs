using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIlya
{
    class Program
    {
        static void Main(string[] args)
        {
            // key-unique value
            //Dictionary<string, string> _dic = new Dictionary<string, string>();

            Ilya _alikObj = new Ilya() { Name = "Alik" };

            Ilya _result = null;

            List<Ilya> _listIlya = new List<Ilya>();
            _listIlya.Add(_alikObj);

            foreach (Ilya item in _listIlya)
            {
                if (item.Name == "Alik")
                {
                    _result = item;
                    break;
                }
            }

            // key - obj.Name
            Dictionary<string, Ilya> _dicIlya = new Dictionary<string, Ilya>();

            _dicIlya.Add("Alik", _alikObj);

            if (_dicIlya.ContainsKey("Alik"))
            {
                _result = _dicIlya["Alik"];
            }

            Dictionary<string, Ilya> _tools = _listIlya.ToDictionary(i => i.Name, i => i);


              //object _obj = new object();
              //_obj.ToString();

            int _int = 5;
            Console.WriteLine("_int = {0}", _int);
            //Console.WriteLine("_int = {0}", _int.ToString());

            Ilya _ilya = new Ilya();
            _ilya.Name = "Name Ilya";

            Alik _alik = new Alik();
            _alik.Name = "Name Alik";

            //Console.WriteLine("_ilya = {0}", _ilya.ToString());

            Console.WriteLine("_ilya = {0}", _ilya);
            Console.WriteLine("_alik = {0}", _alik);

            //string _str1 = GetSting<int>(_int);
            //string _str1 = GetSting<Alik>(_alik);
            //string _str2 = GetSting<Ilya>(_ilya);
            //Console.WriteLine("_alik = {0}, _ilya = {1}", _str1, _str2);
            // output _alik = [ Name = Name Alik ], _ilya = [ Name = Name Ilya ]

            //GetSpecialString(_ilya);

            Console.ReadKey();
        }


        static string GetSting<Tobject>(Tobject obj) where Tobject : class, IName
        {
            return string.Format("[ Name = {0} ]", obj.Name);
        }

        static string GetSpecialString(int obj)
        {
            return obj.ToString();
        }
    }


    public interface IName
    {
        string Name { get; set; }
    }

    public class Ilya : IName
    {
        public string Name { get; set; }
        public int Child { get; set; }

        /// <summary>
        /// overrided for debug or log
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{{ Name:{0}, Child:{1} }}", Name, Child);
        }
    }

    public class Alik : IName
    {
        public string Name { get; set; }

        /// <summary>
        /// overrided for debug or log
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{{ Name:{0} }}", Name);
        }
    }
}
