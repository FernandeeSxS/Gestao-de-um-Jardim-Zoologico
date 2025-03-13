using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrataProblemas;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a bilhetes.
    /// </summary>
    public class RegrasBilhetes
    {
        /// <summary>
        /// Instância da classe Bilhetes a ser usada nas regras.
        /// </summary>
        Bilhetes bilhetes;

        /// <summary>
        /// Inicializa uma nova instância da classe RegrasBilhetes com um identificador.
        /// </summary>
        /// <param name="id">O identificador utilizado para inicializar a instância de Bilhetes.</param>
        public RegrasBilhetes(int id)
        {
            bilhetes = new Bilhetes(id);
        }

        #region MétodosPrincipais

        /// <summary>
        /// Adiciona um novo bilhete à lista de bilhetes, após validar suas propriedades.
        /// </summary>
        /// <param name="bilhete">O objeto da classe BilheteSimples a ser adicionado.</param>
        /// <returns>Retorna true se o bilhete for adicionado com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="InvalidOperationException">Lançada quando a operação de adição não pode ser realizada.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AdicionarBilheteSimples(BilheteSimples bilhete)
        {
            if (bilhetes.BilheteSimplesExistente(bilhete))
            {
                throw new InvalidOperationException(nameof(bilhete.Codigo));
            }

            try
            {
                bool a = bilhetes.AdicionarBilheteSimples(bilhete);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remove um bilhete da lista de bilhetes pelo seu ID.
        /// </summary>
        /// <param name="codigo">O ID do bilhete a ser removido.</param>
        /// <returns>Retorna true se o bilhete for removido com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID fornecido é inválido.</exception>
        /// <exception cref="InvalidOperationException">Lançada quando a operação de remoção não pode ser realizada.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool RemoverBilhete(string codigo)
        {
            if (codigo == "A0" || codigo == "C0" || codigo == "J0" || codigo == "I0")
            {
                throw new ArgumentException(nameof(codigo));
            }

            try
            {
                bool a = bilhetes.RemoverBilhete(codigo);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Altera o preço de todos os bilhetes de uma determinada data.
        /// </summary>
        /// <param name="data">A data dos bilhetes cujos preços serão alterados.</param>
        /// <param name="novoPreco">O novo preço a ser atribuído.</param>
        /// <returns>Retorna verdadeiro se o preço foi alterado com sucesso para pelo menos um bilhete, caso contrário, retorna falso.</returns>
        /// <exception cref="NaoPodeAlterarException">Lançada quando o novo preço é igual ou superior a 30.00, ou ocorre um erro durante a operação.</exception>
        public bool AlterarPrecoBilhetesPorData(DateTime data, double novoPreco)
        {
            if (novoPreco >= 30.00)
            {
                throw new NaoPodeAlterarException();
            }

            try
            {
                bool a = bilhetes.AlterarPrecoBilhetesPorData(data, novoPreco);
                return a;
            }
            catch (Exception e)
            {
                throw new NaoPodeAlterarException(e.Message);
            }
        }

        #endregion

        #region MétodosAuxiliares

        #endregion
    }
}
