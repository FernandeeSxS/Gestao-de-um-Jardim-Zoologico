using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;

namespace Dados
{
    /// <summary>
    /// Classe que representa um evento no zoológico.
    /// </summary>
    public class Evento
    {
        #region Atributos

        /// <summary>
        /// Identificador único do evento.
        /// </summary>
        int eventoId;

        /// <summary>
        /// Tipo do evento.
        /// </summary>
        TipoEvento tipo;

        /// <summary>
        /// Nome do evento.
        /// </summary>
        string nome;

        /// <summary>
        /// ID da lista de funcionários responsáveis pelo evento.
        /// </summary>
        int idFuncionarios;

        /// <summary>
        /// Local onde o evento ocorrerá.
        /// </summary>
        string local;

        /// <summary>
        /// Data e hora do evento.
        /// </summary>
        DateTime dataEvento;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Evento.
        /// </summary>
        public Evento()
        {
            eventoId = 0;
            tipo = TipoEvento.Espetaculo;
            nome = "";
            idFuncionarios = 0;
            local = "";
            dataEvento = DateTime.Now;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Evento.
        /// </summary>
        /// <param name="eventoId">Identificador único do evento.</param>
        /// <param name="tipo">Tipo do evento.</param>
        /// <param name="idFuncionarios">ID do funcionário responsável pelo evento.</param>
        /// <param name="dataEvento">Data e hora do evento.</param>
        public Evento(int eventoId, TipoEvento tipo, int idFuncionarios, DateTime dataEvento)
        {
            this.eventoId = eventoId;
            this.tipo = tipo;
            this.idFuncionarios = idFuncionarios;
            this.dataEvento = dataEvento;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Evento.
        /// </summary>
        /// <param name="eventoId">Identificador único do evento.</param>
        /// <param name="tipo">Tipo do evento.</param>
        /// <param name="nome">Nome do evento.</param>
        /// <param name="idFuncionarios">ID do funcionário responsável pelo evento.</param>
        /// <param name="local">Local do evento.</param>
        /// <param name="dataEvento">Data e hora do evento.</param>
        public Evento(int eventoId, TipoEvento tipo, string nome, int idFuncionarios, string local, DateTime dataEvento)
        {
            this.eventoId = eventoId;
            this.tipo = tipo;
            this.nome = nome;
            this.idFuncionarios = idFuncionarios;
            this.local = local;
            this.dataEvento = dataEvento;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do evento.
        /// </summary>
        public int IdEvento
        {
            get { return eventoId; }
            set { eventoId = value; }
        }

        /// <summary>
        /// Obtém ou define o tipo do evento.
        /// </summary>
        public TipoEvento Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do evento.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o ID do funcionário responsável pelo evento.
        /// </summary>
        public int IdFuncionarios
        {
            get { return idFuncionarios; }
            set { idFuncionarios = value; }
        }

        /// <summary>
        /// Obtém ou define o local do evento.
        /// </summary>
        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        /// <summary>
        /// Obtém ou define a data do evento.
        /// </summary>
        public DateTime DataEvento
        {
            get { return dataEvento; }
            set { dataEvento = value; }
        }

        #endregion

        #endregion
    }

}
