using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /// <summary>
    /// Classe que gere uma lista de objetos do tipo Bilhete.
    /// </summary>
    public class Bilhetes
    {
        #region Atributos

        /// <summary>
        /// Identificador único da lista de bilhetes.
        /// </summary>
        int idBilhetes;

        /// <summary>
        /// Lista de bilhetes.
        /// </summary>
        List<Bilhete> bilhetes;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Bilhetes.
        /// Inicializa a lista de bilhetes e define o identificador padrão.
        /// </summary>
        public Bilhetes()
        {
            idBilhetes = 0;
            bilhetes = new List<Bilhete>();
        }

        /// <summary>
        /// Construtor com parâmetros da classe Bilhetes.
        /// Inicializa a lista de bilhetes e atribui um identificador.
        /// </summary>
        /// <param name="idBilhetes">Identificador único da lista de bilhetes.</param>
        public Bilhetes(int idBilhetes)
        {
            this.idBilhetes = idBilhetes;
            bilhetes = new List<Bilhete>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da lista de bilhetes.
        /// </summary>
        public int IdBilhetes
        {
            get { return idBilhetes; }
            set { idBilhetes = value; }
        }

        #endregion

        #region Outros Métodos Complexos

        /// <summary>
        /// Adiciona um bilhete à lista de bilhetes.
        /// </summary>
        /// <param name="bilhete">Bilhete a ser adicionado.</param>
        /// <returns>Retorna verdadeiro se o bilhete foi adicionado com sucesso; caso contrário, retorna falso.</returns>
        public bool AdicionarBilhete(Bilhete bilhete)
        {
            if (!bilhetes.Contains(bilhete))
            {
                bilhetes.Add(bilhete);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna o bilhete com base no código.
        /// </summary>
        /// <param name="codigo">Código do bilhete.</param>
        /// <returns>Retorna o bilhete procurado ou null caso não encontre.</returns>
        public Bilhete EncontrarBilhete(string codigo)
        {
            return bilhetes.Find(b => b.Codigo == codigo);
        }

        /// <summary>
        /// Remove um bilhete da lista com base no código.
        /// </summary>
        /// <param name="codigo">Código do bilhete a ser removido.</param>
        /// <returns>Retorna verdadeiro se o bilhete foi removido com sucesso; caso contrário, retorna falso.</returns>
        public bool RemoverBilhete(string codigo)
        {
            Bilhete bilhete = EncontrarBilhete(codigo);
            if (bilhete != null)
            {
                bilhetes.Remove(bilhete);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica se já existe um bilhete com o mesmo código.
        /// </summary>
        /// <param name="bilhete">O bilhete a ser verificado.</param>
        /// <returns>Retorna true se já existir um bilhete com o mesmo código, caso contrário, retorna false.</returns>
        public bool BilheteExistente(Bilhete bilhete)
        {
            if (bilhetes.Any(b => b.Codigo == bilhete.Codigo))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Altera o preço de todos os bilhetes de uma determinada data.
        /// </summary>
        /// <param name="data">A data dos bilhetes cujos preços serão alterados.</param>
        /// <param name="novoPreco">O novo preço a ser atribuído.</param>
        /// <returns>Retorna verdadeiro se o preço foi alterado com sucesso para pelo menos um bilhete, caso contrário, retorna falso.</returns>
        public bool AlterarPrecoBilhetesPorData(DateTime data, double novoPreco)
        {
            if (novoPreco <= 0)
            {
                return false;
            }

            foreach (Bilhete bilhete in bilhetes)
            {
                if (bilhete.Data.Day == data.Day)
                {
                    bilhete.Preco = novoPreco;
                }
            }

            return true;
        }

        #endregion

        #region Outros Métodos Simples

        /// <summary>
        /// Adiciona um bilhete simples à lista de bilhetes.
        /// </summary>
        /// <param name="bS">O bilhete simples a ser adicionado.</param>
        /// <returns>Retorna verdadeiro se o bilhete foi adicionado com sucesso, caso contrário, retorna falso.</returns>
        public bool AdicionarBilheteSimples(BilheteSimples bS)
        {
            Bilhete bilhete = new Bilhete(bS.Codigo, bS.Data);
            bool resultado = AdicionarBilhete(bilhete);
            return resultado;
        }

        /// <summary>
        /// Verifica se já existe um bilhete simples na lista.
        /// </summary>
        /// <param name="bS">O bilhete simples a ser verificado.</param>
        /// <returns>Retorna verdadeiro se o bilhete simples já existir, caso contrário, retorna falso.</returns>
        public bool BilheteSimplesExistente(BilheteSimples bS)
        {
            Bilhete bilhete = new Bilhete(bS.Codigo, bS.Data);
            bool resultado = BilheteExistente(bilhete);
            return resultado;
        }

        #endregion

        #endregion
    }

}
