using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrataProblemas
{
    /// <summary>
    /// Classe personalizada para tratamento de exceções específicas no sistema.
    /// Esta classe herda da classe ApplicationException e é utilizada para lançar exceções quando há problemas específicos no processo, como mensagens personalizadas de erro.
    /// </summary>
    public class NaoPodeAlterarException : ApplicationException
    {
        /// <summary>
        /// Construtor padrão da classe NaoPodeAlterarException que inicializa a exceção com a mensagem padrão "311".
        /// </summary>
        public NaoPodeAlterarException() : base("311") { }

        /// <summary>
        /// Construtor que permite passar uma mensagem personalizada para a exceção.
        /// Lança uma exceção genérica com a mensagem fornecida e uma string adicional.
        /// </summary>
        /// <param name="msg">A mensagem personalizada que será adicionada à exceção.</param>
        /// <exception cref="Exception">Lança uma exceção com a mensagem personalizada concatenada com a string "311".</exception>
        public NaoPodeAlterarException(string msg)
        {
            throw new Exception(msg + "311");
        }

        /// <summary>
        /// Construtor que permite passar uma exceção existente e adicionar uma mensagem personalizada a ela.
        /// Lança uma nova NaoPodeAlterarException com a mensagem da exceção fornecida concatenada com a string "311".
        /// </summary>
        /// <param name="e">A exceção original que será encapsulada e modificada.</param>
        /// <exception cref="NaoPodeAlterarException">Lança uma exceção personalizada com a mensagem modificada.</exception>
        public NaoPodeAlterarException(Exception e)
        {
            throw new NaoPodeAlterarException(e.Message + "311");
        }
    }
}
