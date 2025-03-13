using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    public enum TipoEvento
    {
        AlimentacaoAnimal,
        Espetaculo,
        LimpezaJaula
    }

    /// <summary>
    /// Classe que representa uma versão simplificada de um evento no zoológico.
    /// Contém os atributos EventoId, Data, TipoEvento e IdFuncionarios.
    /// </summary>
    public class EventoSimples
    {
        #region Atributos

        /// <summary>
        /// ID único do evento.
        /// </summary>
        int eventoId;

        /// <summary>
        /// Data do evento.
        /// </summary>
        DateTime data;

        /// <summary>
        /// ID da lista de funcionários que realizou o evento.
        /// </summary>
        int idFuncionarios;

        /// <summary>
        /// Tipo de evento (Alimentação de animal, Espetáculo, Limpeza de jaula).
        /// </summary>
        TipoEvento tipoEvento;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe EventoSimples.
        /// </summary>
        public EventoSimples()
        {
            eventoId = 0;
            data = DateTime.Now;
            idFuncionarios = 0;
            tipoEvento = TipoEvento.AlimentacaoAnimal; // Valor padrão
        }

        /// <summary>
        /// Construtor com parâmetros da classe EventoSimples.
        /// </summary>
        /// <param name="eventoId">ID único do evento.</param>
        /// <param name="data">Data do evento.</param>
        /// <param name="idFuncionarios">ID da lista de funcionários que realizaram o evento.</param>
        /// <param name="tipoEvento">Tipo de evento.</param>
        public EventoSimples(int eventoId, DateTime data, int idFuncionarios, TipoEvento tipoEvento)
        {
            this.eventoId = eventoId;
            this.data = data;
            this.idFuncionarios = idFuncionarios;
            this.tipoEvento = tipoEvento;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o ID único do evento.
        /// </summary>
        public int EventoId
        {
            get { return eventoId; }
            set { eventoId = value; }
        }

        /// <summary>
        /// Obtém ou define a data do evento.
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Obtém ou define o ID da lista de funcionários que realizaram o evento.
        /// </summary>
        public int IdFuncionarios
        {
            get { return idFuncionarios; }
            set { idFuncionarios = value; }
        }

        /// <summary>
        /// Obtém ou define o tipo do evento.
        /// </summary>
        public TipoEvento TipoEvento
        {
            get { return tipoEvento; }
            set { tipoEvento = value; }
        }

        #endregion
    }
}
