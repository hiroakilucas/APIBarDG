using APIBarDG.Model.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBarDG.Util.Enum;
namespace APIBarDG.Bussiness.Comanda
{
    public class DescontoBussiness 
    {
        EnumItens EnumItens = new EnumItens();

        private NotaFiscal DescontoAplicado(NotaFiscal notaFiscal)
        {
            if (notaFiscal.Item.Count() == 0 )
            {
                return null;
            }

            
            EnumItens

            return notaFiscal;
        }
    }
}
