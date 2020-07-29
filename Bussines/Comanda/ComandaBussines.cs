using APIBarDG.Data.Comanda;
using APIBarDG.Data.Service;
using APIBarDG.Model;
using APIBarDG.Model.NotaFiscal;
using APIBarDG.Service.ComandaService;
using APIBarDG.Util.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIBarDG.Bussines.Comanda
{
    public class ComandaBussines : IControlaComanda
    {
        
        private readonly IComandaDAO _comandaDAO;
        private readonly IItemDAO _itemDAO;
        public ComandaBussines(IComandaDAO comandaDAO, IItemDAO itemDAO)
        {
            _comandaDAO = comandaDAO;
            _itemDAO = itemDAO;

        }

        public Model.Comanda.Comanda RegistraItemComanda(int idComanda, string nomeItem)
        {
            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();
            List<Item> itens = new List<Item>();
            Item item = new Item();
            comanda = _comandaDAO.getComanda(idComanda);

            item = _itemDAO.getItem(nomeItem);
            itens.Add(item);

            comanda = _comandaDAO.cadastraComanda(idComanda, itens);

            //if (!VerificaTresSucos(comandas))
            //{
            //    //3 sucos existentes jogar exception
            //    return null;
            //}

            ////sql registra item
            //comandas = _comandaDAO.cadastraItemComanda(idComanda, item.ID);

            //comandas = PromocaoAgua(comandas);

            return comanda;
        }

        private Model.Comanda.Comanda PromocaoAgua(Model.Comanda.Comanda comanda)
        {
            double promocaoAgua = 0;
            //verifica quantas promocoes de Agua existe 
            promocaoAgua = VerificaPromocaoAgua(comanda);

            //verifica quantas promocoes ja foi pedido 
            promocaoAgua = promocaoAgua - comanda.PromocaoAguaPedidos;

            comanda.PromocaoAguaRestantes = promocaoAgua;

            return comanda;
        }

        private double VerificaPromocaoAgua(Model.Comanda.Comanda comandas)
        {
            int qtdConhaque = 0;
            int qtdCerveja = 0;
            double possivelQtdPromocaoConhaque = 0;
            double possivelQtdPromocaoCerveja = 0;

            foreach (var item in comandas.Itens)
            {
                if (item.Nome.ToString().ToUpper() == EnumItens.Conhaque.ToString().ToUpper())               
                {
                    qtdConhaque++;
                }
                else
                if (item.Nome.ToString().ToUpper() == EnumItens.Cerveja.ToString().ToUpper())                    
                {
                    qtdCerveja++;
                }
            }

            if (!(qtdConhaque > 3 && qtdCerveja > 2 ))
            {
                return 0;
            }

            possivelQtdPromocaoConhaque = qtdConhaque / 3;
            possivelQtdPromocaoCerveja = qtdCerveja/ 2;

            if (possivelQtdPromocaoConhaque > possivelQtdPromocaoCerveja)
            {
                return possivelQtdPromocaoCerveja;
            }
            else
            {
                return possivelQtdPromocaoConhaque;
            }
        }

        private bool VerificaTresSucos(Model.Comanda.Comanda comanda)
        {
            int qtdSucos = 0;


            foreach (var item in comanda.Itens)
            {
                if (item.Nome.ToString().ToUpper() == EnumItens.Suco.ToString())
                {
                    qtdSucos++;
                }
            }

            if (qtdSucos > 3)
            {
                return false;
            }

            return true;
        }

        public NotaFiscal FechamentoComanda(int idComanda)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            ComandaDAO comandaDAO = new ComandaDAO();

            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();

            //setar peços pegando da base e setar na comanda           
            //1.Cerveja: R$ 5,00
            //2.Conhaque: R$ 20,00
            //3.Suco: R$ 50,00
            //4.Água: R$ 70,00
            //sql verifica item da comanda na base e busca os itens
            //comanda = comandaDAO.getComanda(idComanda);

            DescontoBussines descontoBussines = new DescontoBussines();
            NotaFiscalBussines notaFiscalBusiness = new NotaFiscalBussines();

            comanda = descontoBussines.DescontoAplicado(comanda);
            notaFiscal = notaFiscalBusiness.GerarNotaFiscal(comanda);

            return notaFiscal;
        }

        public Model.Comanda.Comanda LimpaComanda(int idComanda)
        {
            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();

            //sql verifica se a comanda existe;
            //
            //sql delete itens da comanda;
            //comanda = comandaDAO.limpaComanda(idComanda);

            return comanda;
        }
    }
}
