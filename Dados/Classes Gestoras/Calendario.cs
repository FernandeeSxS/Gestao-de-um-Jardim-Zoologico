using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /// <summary>
    /// Classe que gere uma lista de objetos do tipo Evento.
    /// </summary>
    public static class Calendario
    {
        #region Atributos

        /// <summary>
        /// Lista que armazena os eventos registados (estática).
        /// </summary>
        static List<Evento> eventos = new List<Evento>();

        #endregion

        #region Métodos para Evento

        /// <summary>
        /// Regista um novo evento no calendário.
        /// </summary>
        /// <param name="evento">Evento a ser registado.</param>
        /// <returns>Retorna true se o evento foi registado com sucesso; caso contrário, retorna false.</returns>
        public static bool AdicionarEvento(Evento evento)
        {
            if (!eventos.Contains(evento))
            {
                eventos.Add(evento);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Encontra um evento no calendário com base no ID.
        /// </summary>
        /// <param name="idEvento">ID do evento a ser encontrado.</param>
        /// <returns>Retorna o evento encontrado ou null caso não exista.</returns>
        public static Evento EncontrarEvento(int idEvento)
        {
            return eventos.Find(e => e.IdEvento == idEvento);
        }

        /// <summary>
        /// Remove um evento do calendário com base no ID.
        /// </summary>
        /// <param name="idEvento">ID do evento a ser removido.</param>
        /// <returns>Retorna true se o evento foi removido com sucesso; caso contrário, retorna false.</returns>
        public static bool RemoverEvento(int idEvento)
        {
            Evento evento = EncontrarEvento(idEvento);
            if (evento != null)
            {
                eventos.Remove(evento);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna todos os eventos de um determinado dia.
        /// </summary>
        /// <param name="data">Data dos eventos.</param>
        /// <returns>Lista de eventos que ocorrem na data especificada.</returns>
        public static List<Evento> ObterEventosPorDia(DateTime data)
        {
            return eventos.Where(e => e.DataEvento.Date == data.Date).ToList();
        }

        #endregion

        #region Métodos para EventoSimples

        /// <summary>
        /// Adiciona um evento simples ao calendário.
        /// </summary>
        /// <param name="eS">Evento simples a ser adicionado.</param>
        /// <returns>Retorna verdadeiro se o evento simples foi adicionado com sucesso, caso contrário, retorna falso.</returns>
        public static bool AdicionarEventoSimples(EventoSimples eS)
        {
            Evento evento = new Evento(eS.EventoId, eS.TipoEvento, eS.IdFuncionarios, eS.Data);
            bool resultado = Calendario.AdicionarEvento(evento);

            return resultado;
        }

        /// <summary>
        /// Retorna todos os eventos simples de um determinado dia.
        /// </summary>
        /// <param name="data">Data dos eventos simples.</param>
        /// <returns>Lista de eventos simples que ocorrem na data especificada.</returns>
        public static List<EventoSimples> ObterEventosPorDiaSimples(DateTime data)
        {
            List<Evento> eventos = Calendario.ObterEventosPorDia(data);

            List<EventoSimples> eventosSimples = eventos.Select(e => new EventoSimples(e.IdEvento, e.DataEvento, e.IdFuncionarios, e.Tipo)).ToList();
            return eventosSimples;
        }

        #endregion
    }
}

