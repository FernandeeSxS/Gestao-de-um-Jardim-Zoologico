using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a eventos.
    /// </summary>
    public class RegrasEventos
    {
        /// <summary>
        /// Adiciona um evento ao calendário, aplicando as regras de negócio.
        /// </summary>
        /// <param name="evento">Evento a ser adicionado.</param>
        /// <returns>Retorna true se o evento for adicionado com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando a data do evento é anterior à data atual.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public static bool AdicionarEventoSimples(EventoSimples evento)
        {
            if (evento.Data.Date < DateTime.Now.Date)
            {
                throw new ArgumentException(nameof(evento.Data));
            }

            try
            {
                bool a = Calendario.AdicionarEventoSimples(evento);
                return a;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remove um evento do calendário, verificando as regras de negócio.
        /// </summary>
        /// <param name="idEvento">ID do evento a ser removido.</param>
        /// <returns>Retorna true se o evento foi removido com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID do evento é inválido.</exception>
        /// <exception cref="InvalidOperationException">Lançada quando o evento com o ID especificado não é encontrado.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public static bool RemoverEvento(int idEvento)
        {
            if (idEvento > 0)
            {
                throw new ArgumentException(nameof(idEvento));
            }

            if (Calendario.EncontrarEvento(idEvento) == null)
            {
                throw new InvalidOperationException(nameof(idEvento));
            }

            try
            {
                bool a = Calendario.RemoverEvento(idEvento);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Obtém a lista de eventos de um determinado dia, aplicando as regras de negócio.
        /// </summary>
        /// <param name="data">Data dos eventos.</param>
        /// <returns>Lista de eventos para o dia especificado.</returns>
        /// <exception cref="ArgumentException">Lançada quando a data fornecida é anterior à data atual.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public static List<EventoSimples> ObterEventosPorDiaSimples(DateTime data)
        {
            if (data.Date < DateTime.Now.Date)
            {
                throw new ArgumentException(nameof(data));
            }

            try
            {
                List<EventoSimples> eventosSimples = Calendario.ObterEventosPorDiaSimples(data);
                return eventosSimples;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}