using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrataProblemas
{
    /// <summary>
    /// Classe personalizada para tratamento de exceções específicas no sistema.
    /// Esta classe herda da classe ApplicationException e é utilizada para lançar exceções quando há problemas específicos no processo.
    /// </summary>
    public class FicheirosException : ApplicationException
    {
            /// <summary>
            /// Construtor padrão da classe FicheirosException que inicializa a exceção com a mensagem padrão "401".
            /// </summary>
            public FicheirosException() : base("401") { }

            /// <summary>
            /// Construtor que permite passar uma mensagem personalizada para a exceção.
            /// Lança uma exceção genérica com a mensagem fornecida e uma string adicional.
            /// </summary>
            /// <param name="msg">A mensagem personalizada que será adicionada à exceção.</param>
            /// <exception cref="Exception">Lança uma exceção com a mensagem personalizada concatenada com a string "401".</exception>
            public FicheirosException(string msg)
            {
                throw new Exception(msg + "401");
            }

            /// <summary>
            /// Construtor que permite passar uma exceção existente e adicionar uma mensagem personalizada a ela.
            /// Lança uma nova FicheirosException com a mensagem da exceção fornecida concatenada com a string " 401".
            /// </summary>
            /// <param name="e">A exceção original que será encapsulada e modificada.</param>
            /// <exception cref="FicheirosException">Lança uma exceção personalizada com a mensagem modificada.</exception>
            public FicheirosException(Exception e)
            {
                throw new FicheirosException(e.Message + "401");
            }
    }
}
