using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbgeApi.Models
{
    public class Regiao
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
    public class UF 
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public Regiao Regiao { get; set; }

    }
    public class Messoregiao 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UF UF { get; set; }
    }
    public class MicroRegiao 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Messoregiao Messoregiao { get; set; }
    }
    public class Municipios 
    {
        [Display(Name="Código do Municipio")]
        public int Id { get; set; }
        [Display(Name = "Municipio")]
        public string Nome { get; set; }
        public MicroRegiao MicroRegiao { get; set; }
    }
}
