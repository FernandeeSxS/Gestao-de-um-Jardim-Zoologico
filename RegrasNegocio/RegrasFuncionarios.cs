using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using TrataProblemas;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a funcionarios.
    /// </summary>
    public class RegrasFuncionarios
    {
        /// <summary>
        /// Instância da classe Funcionarios que será utilizada nas regras.
        /// </summary>
        Funcionarios funcionarios;

        /// <summary>
        /// Inicializa uma nova instância da classe RegrasFuncionarios com o ID especificado.
        /// </summary>
        /// <param name="id">ID utilizado para inicializar a instância de Funcionarios.</param>
        public RegrasFuncionarios(int id)
        {
            funcionarios = new Funcionarios(id);
        }

        #region Métodos Principais

        /// <summary>
        /// Adiciona um novo funcionário à lista de funcionários, após validar as suas propriedades.
        /// </summary>
        /// <param name="funcionario">O objeto da classe FuncionarioSimples a ser adicionado.</param>
        /// <returns>Retorna true se o funcionário for adicionado com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando um argumento fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AdicionarFuncionarioSimples(FuncionarioSimples funcionario)
        {

            if (!ValidarIdadeFuncionario(funcionario.Idade))
            {
                throw new ArgumentException(nameof(funcionario.Idade));
            }

            try
            {
                bool a = funcionarios.AdicionarFuncionarioSimples(funcionario);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remove um funcionário da lista de funcionários pelo seu ID.
        /// </summary>
        /// <param name="funcionarioId">O ID do funcionário a ser removido.</param>
        /// <returns>Retorna true se o funcionário for removido com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool RemoverFuncionario(int funcionarioId)
        {
            if (funcionarioId == 0)
            {
                    throw new ArgumentException(nameof(funcionarioId));
            }

            try
            {
                bool a = funcionarios.RemoverFuncionario(funcionarioId);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Salva a lista de funcionários em um ficheiro.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro onde os funcionários serão salvos. Deve ser "Funcionarios" para que o salvamento seja realizado.</param>
        /// <returns>Retorna true se os funcionários foram salvos com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é válido ou ocorre um erro durante o salvamento.</exception>
        public bool GuardarFuncionariosFicheiro(string fileName)
        {
            if (fileName != "Funcionarios")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = funcionarios.SaveFuncionarios(fileName);
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
        /// Carrega a lista de funcionários de um ficheiro.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro de onde os funcionários serão carregados. Deve ser "Funcionarios" para que o carregamento seja realizado.</param>
        /// <returns>Retorna true se os funcionários foram carregados com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é válido ou ocorre um erro durante o carregamento.</exception>
        public bool CarregarFuncionariosFicheiro(string fileName)
        {
            if (fileName != "Funcionarios")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = funcionarios.LoadFuncionarios(fileName);
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

        #region Métodos Auxiliares

        /// <summary>
        /// Valida se a idade do funcionário é válida (acima de 18 anos).
        /// </summary>
        /// <param name="idade">A idade do funcionário.</param>
        /// <returns>Retorna true se a idade for válida, caso contrário, retorna false.</returns>
        private bool ValidarIdadeFuncionario(int idade)
        {
            return idade >= 18;
        }

        #endregion

    }
}
