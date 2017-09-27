using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaTEC22609.Models
{
    public class Aluno
    {
        // Thiago Andrey Zils
        // thiago.zils@catolicasc.org.br


        public int Id { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Faixa Faixa { get; set; }

        public TipoDeAssociacao TipoDeAssociacao { get; set; }

    }
}