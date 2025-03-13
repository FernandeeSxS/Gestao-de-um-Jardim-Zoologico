using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrataProblemas;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a veterinarios.
    /// </summary>
    public class RegrasVeterinarios
    {
        /// <summary>
        /// Instância da classe Veterinarios que será utilizada nas regras.
        /// </summary>
        Veterinarios veterinarios;

        /// <summary>
        /// Inicializa uma nova instância da classe RegrasVeterinarios com o ID especificado.
        /// </summary>
        /// <param name="id">ID utilizado para inicializar a instância de Veterinarios.</param>
        public RegrasVeterinarios(int id)
        {
            veterinarios = new Veterinarios(id);
        }

        #region Métodos Principais

        /// <summary>
        /// Adiciona um novo veterinário à lista de veterinários, após validar as suas propriedades.
        /// </summary>
        /// <param name="veterinario">O objeto da classe Veterinario a ser adicionado.</param>
        /// <returns>Retorna true se o veterinário for adicionado com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando um argumento fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AdicionarVeterinarioSimples(VeterinarioSimples veterinario)
        {
            if (!ValidarIdadeVeterinario(veterinario.Idade))
            {
                throw new ArgumentException(nameof(veterinario.Idade));
            }

            try
            {
                bool a = veterinarios.AdicionarVeterinarioSimples(veterinario);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remove um veterinário da lista de veterinários pelo seu ID.
        /// </summary>
        /// <param name="veterinarioId">O ID do veterinário a ser removido.</param>
        /// <returns>Retorna true se o veterinário for removido com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool RemoverVeterinario(int veterinarioId)
        {
            if (veterinarioId == 0)
            {
                throw new ArgumentException(nameof(veterinarioId));
            }

            try
            {
                bool a = veterinarios.RemoverVeterinario(veterinarioId);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Guarda a lista de veterinários em um ficheiro.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro onde os veterinários serão guardados. Deve ser "Veterinarios" para que a exportação seja realizado.</param>
        /// <returns>Retorna true se os veterinários foram guardados com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é válido ou ocorre algum erro durante o processo de exportação.</exception>
        public bool GuardarVeterinariosFicheiro(string fileName)
        {
            if (fileName != "Veterinarios")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = veterinarios.SaveVeterinarios(fileName);
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
        /// Carrega a lista de veterinários de um ficheiro.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro de onde os veterinários serão carregados. Deve ser "Veterinarios" para que o carregamento seja realizado.</param>
        /// <returns>Retorna true se os veterinários foram carregados com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é válido ou ocorre algum erro durante o processo de carregamento.</exception>
        public bool CarregarVeterinariosFicheiro(string fileName)
        {
            if (fileName != "Veterinarios")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = veterinarios.LoadVeterinarios(fileName);
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
        /// Valida se a idade do veterinário é válida (acima de 21 anos).
        /// </summary>
        /// <param name="idade">A idade do veterinário.</param>
        /// <returns>Retorna true se a idade for válida, caso contrário, retorna false.</returns>
        private bool ValidarIdadeVeterinario(int idade)
        {
            return idade >= 21;
        }

        #endregion
    }
}
