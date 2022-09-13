using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace AppCustoViagem.Model
{
    public class Pedagio
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Localizacao { get; set; }
        public double Valor { get; set; }

        public string Valido { get; set; }
    }
}
