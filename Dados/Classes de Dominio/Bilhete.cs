using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /// <summary>
    /// Enumerado que define os tipos de bilhetes disponíveis.
    /// </summary>
    public enum TipoBilhete
    {
        Adulto,
        Crianca,
        Jovem,
        Idoso
    }

    /// <summary>
    /// Classe que representa um bilhete do zoológico.
    /// </summary>
    public class Bilhete
    {
        #region Atributos

        /// <summary>
        /// Código do bilhete.
        /// </summary>
        string codigo;

        /// <summary>
        /// Data de validade do bilhete.
        /// </summary>
        DateTime data;

        /// <summary>
        /// Preço do bilhete.
        /// </summary>
        double preco;

        /// <summary>
        /// Tipo do bilhete.
        /// </summary>
        TipoBilhete tipo;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Bilhete.
        /// </summary>
        public Bilhete()
        {
            codigo = "";
            data = DateTime.Now;
            preco = 0.0;
            tipo = TipoBilhete.Adulto;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Bilhete.
        /// </summary>
        /// <param name="codigo">Código do bilhete.</param>
        /// <param name="data">Data de validade do bilhete.</param>
        public Bilhete(string codigo, DateTime data)
        {
            this.codigo = codigo;
            this.data = data;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Bilhete.
        /// </summary>
        /// <param name="codigo">Código do bilhete.</param>
        /// <param name="data">Data de validade do bilhete.</param>
        /// <param name="preco">Preço do bilhete.</param>
        /// <param name="tipo">Tipo do bilhete.</param>
        public Bilhete(string codigo, DateTime data, double preco, TipoBilhete tipo)
        {
            this.codigo = codigo;
            this.data = data;
            this.preco = preco;
            this.tipo = tipo;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o código do bilhete.
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

        /// <summary>
        /// Obtém ou define o preço do bilhete.
        /// </summary>
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        /// <summary>
        /// Obtém ou define o tipo do bilhete.
        /// </summary>
        public TipoBilhete Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        #region Outros Métodos

        /// <summary>
        /// Verifica se o bilhete é válido.
        /// </summary>
        /// <returns>Retorna verdadeiro se o bilhete for válido, falso caso contrário.</returns>
        public bool VerificarValidade()
        {
            return data.Date == DateTime.Now.Date;
        }

        #endregion

        #endregion
    }
}
