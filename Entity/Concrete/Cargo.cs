using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Cargo:IEntity
    {
       
            public Int16 LojistikBirimKodu { get; set; }
            public string? LojistikBirimAd { get; set; }
            public int SipariNo { get; set; }
            public string? nSipariNo { get; set; }
            public int likiliSipari { get; set; }
            public int YonlendirmeTipNo { get; set; }
            public string? YonlendirmeTipi { get; set; }
           // public string MyProperty { get; set; }
            public string? LojistikOpTipi { get; set; }
            public string? SiparisTipi { get; set; }
            public string? ReferansNo1 { get; set; }
            public string? MuteriTeslimNo { get; set; }
            public string? SipariDurumu { get; set; }



        }
    }

