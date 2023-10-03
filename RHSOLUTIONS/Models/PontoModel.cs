using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMIVRH.Models
{
    public class PontoModel
    {
        public DateTime PrimeiraBatida { get; set; }
        public DateTime SegundaBatida { get; set; }
        public DateTime TerceiraBatida { get; set; }
        public DateTime QuartaBatida { get; set; }
        public int HorasTrabalhadas { get; set; }
        public string Cpf { get; set; }
        public DateTime Dia { get; set; }

    }
}
