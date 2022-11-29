using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel
{
    internal class AdminCs:UserCs
    {
        private string _pasword;
        private char boyut=char.ToUpper('A');
        private char MinEded;

        public string ad 
        { 
            get
            {
                return username;
            }
            set
            {
                if (value.Length>6)
                {
                    username = value;
                }
                else
                {
                    Console.WriteLine("Yeniden User Name Yazin");
                }
            } 
        }


        public string sifre
        {
            get
            {
                return _pasword;
            }
            set
            {
                if(boyut > 1 && MinEded > 1)
                {
                    _pasword = value;
                }
            }
        }




        public ad(string userName, string isSuperadmin, string secTion, string Pasword)
        {
            Pasword = _pasword;
        }
}
}
