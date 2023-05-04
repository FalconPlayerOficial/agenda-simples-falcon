using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_simples_falcon
{
    internal class Contato
    {
        private string primeironome;
        private string sobrenome;
        private string telefone;

        public string PrimeiroNome
        {
            get { return primeironome; }
            set { primeironome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }

        }
        public string Telefone
        {

            get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }

                else
                {
                    telefone = "00-00000-0000";
                }
            
            }   
    
        
        }
   
        public Contato() 
        {
            PrimeiroNome = "falcon";
            Sobrenome = "player";
            Telefone = "11-99324-9870";
        }
        
        public Contato(string primeironome,string sobrenome,string telefone)
        {
            PrimeiroNome = primeironome;
            Sobrenome = sobrenome;
            Sobrenome = telefone;
        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += String.Format("{0}-{1}-{2}",
                Telefone.Substring(0,1),
                Telefone.Substring(2,6)
                ;
        }

    }

            
}
