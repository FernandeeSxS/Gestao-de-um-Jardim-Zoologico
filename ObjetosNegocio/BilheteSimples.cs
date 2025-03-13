using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa uma versão simplificada de um bilhete no zoológico.
    /// Contém apenas os atributos código e preço.
    /// </summary>
    public class BilheteSimples
    {
        #region Atributos

        /// <summary>
        /// Código único do bilhete.
        /// </summary>
        string codigo;

        /// <summary>
        /// Data de validade do bilhete.
        /// </summary>
        DateTime data;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe BilheteSimples.
        /// </summary>
        public BilheteSimples()
        {
            codigo = "";
            data = DateTime.Now;
        }

        /// <summary>
        /// Construtor com parâmetros da classe BilheteSimples.
        /// </summary>
        /// <param name="codigo">Código único do bilhete.</param>
        /// <param name="data">Data de validade do bilhete.</param>
        public BilheteSimples(string codigo, DateTime data)
        {
            this.codigo = codigo;
            this.data = data;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o código único do bilhete.
        /// </summary>
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Obtém ou define a data de validade do bilhete.
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        #endregion
    }

}
