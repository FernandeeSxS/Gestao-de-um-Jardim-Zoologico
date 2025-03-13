using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using TrataProblemas;
using System.IO;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a jaulas.
    /// </summary>
    public class RegrasJaulas
    {
        /// <summary>
        /// Instância da classe Jaulas a ser utilizada nas regras.
        /// </summary>
        Jaulas jaulas;

        /// <summary>
        /// Inicializa uma nova instância da classe RegrasJaulas com o ID especificado.
        /// </summary>
        /// <param name="id">ID utilizado para inicializar a instância de Jaulas.</param>
        public RegrasJaulas(int id)
        {
            jaulas = new Jaulas(id);
        }

        #region MétodosPrincipais

        /// <summary>
        /// Adiciona uma nova jaula à lista de jaulas, após validar suas propriedades.
        /// </summary>
        /// <param name="jaula">O objeto da classe Jaula a ser adicionado.</param>
        /// <returns>Retorna true se a jaula for adicionada com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando um argumento fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AdicionarJaulaSimples(JaulaSimples jaula)
        {
            if (!ValidarCapacidadeJaula(jaula.Capacidade))
            {
                throw new ArgumentException(nameof(jaula.Capacidade));
            }

            try
            {
                bool a = jaulas.AdicionarJaulaSimples(jaula);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remove uma jaula da lista de jaulas pelo seu ID.
        /// </summary>
        /// <param name="jaulaId">O ID da jaula a ser removida.</param>
        /// <returns>Retorna true se a jaula for removida com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool RemoverJaula(int jaulaId)
        {
            if (jaulaId == 0)
            {
                throw new ArgumentException(nameof(jaulaId));
            }

            try
            {
                bool a = jaulas.RemoverJaula(jaulaId);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Guarda a lista de jaulas num ficheiro.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro onde as jaulas serão guardadas. Deve ser "Jaulas" para que a exportação seja realizado.</param>
        /// <returns>Retorna true se as jaulas foram guardadas com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é válido ou ocorre um erro durante a exportação.</exception>
        public bool GuardarJaulasFicheiro(string fileName)
        {
            if (fileName != "Jaulas")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = jaulas.SaveJaulas(fileName);
                return a;
            }
            catch (IOException ex)
            {
                throw new FicheirosException(ex.Message);
            }
            catch (Exception e)
            {
                throw new FicheirosException(e.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de jaulas de um ficheiro.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro de onde as jaulas serão carregadas. Deve ser "Jaulas" para que o carregamento seja realizado.</param>
        /// <returns>Retorna true se as jaulas foram carregadas com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é válido ou ocorre um erro durante o carregamento.</exception>
        public bool CarregarJaulasFicheiro(string fileName)
        {
            if (fileName != "Jaulas")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = jaulas.LoadJaulas(fileName);
                return a;
            }
            catch (IOException ex)
            {
                throw new FicheirosException(ex.Message);
            }
            catch (Exception e)
            {
                throw new FicheirosException(e.Message);
            }
        }

        #endregion

        #region MétodosAuxiliares

        /// <summary>
        /// Valida se a capacidade da jaula é maior que zero.
        /// </summary>
        /// <param name="capacidade">A capacidade da jaula.</param>
        /// <returns>Retorna true se a capacidade for válida, caso contrário, retorna false.</returns>
        private bool ValidarCapacidadeJaula(int capacidade)
        {
            return capacidade > 0;
        }

        #endregion
    }


}
