using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaTEC22609.Models
{
    public class TipoDeAssociacao
    {

        // Thiago Andrey Zils
        // thiago.zils@catolicasc.org.br

        public int Id { get; set; }
        public string Nome { get; set; }
         public int Periodo { get; set; }
         public int Mensalidade { get; set; }
    }
}