using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrataProblemas;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a consultas.
    /// </summary>
    public class RegrasConsultas
    {
        /// <summary>
        /// Instância da classe Consultas a ser utilizadas nas regras.
        /// </summary>
        Consultas consultas;

        /// <summary>
        /// Inicializa uma nova instância da classe RegrasConsultas com um identificador específico.
        /// </summary>
        /// <param name="id">O identificador utilizado para inicializar a instância de Consultas.</param>
        public RegrasConsultas(int id)
        {
            consultas = new Consultas(id);
        }

        #region Métodos Principais

        /// <summary>
        /// Adiciona uma nova consulta à lista de consultas, após validar as suas propriedades.
        /// </summary>
        /// <param name="consultaS">O objeto da classe ConsultaSimples a ser adicionado.</param>
        /// <returns>Retorna true se a consulta for adicionada com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando um argumento fornecido é inválido.</exception>
        /// <exception cref="InvalidOperationException">Lançada quando a operação de adição não pode ser realizada.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AdicionarConsultaSimples(ConsultaSimples consultaS)
        {
            if (!ValidarDataConsulta(consultaS.DataConsulta))
            {
                throw new ArgumentException(nameof(consultaS.DataConsulta));
            }

            if (consultas.ConsultaSimplesExistente(consultaS))
            {
                throw new InvalidOperationException(nameof(consultaS.DataConsulta));
            }

            try
            {
                bool a = consultas.AdicionarConsultaSimples(consultaS);
                return a;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        /// <summary>
        /// Remove uma consulta da lista de consultas pelo seu ID.
        /// </summary>
        /// <param name="consultaId">O ID da consulta a ser removida.</param>
        /// <returns>Retorna true se a consulta for removida com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID fornecido é inválido.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool RemoverConsulta(int consultaId)
        {

            if (consultaId == 0)
            {
                throw new ArgumentException(nameof(consultaId));
            }

            try 
            { 
                bool a = consultas.RemoverConsulta(consultaId);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Guarda a lista de consultas num ficheiro especificado.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro onde as consultas serão guardadas. Deve ser "Consultas" para que a exportação seja realizada.</param>
        /// <returns>Retorna true se as consultas foram guardadas com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é "Consultas", ou ocorre um erro durante a operação de escrita.</exception>
        public bool GuardarConsultasFicheiro(string fileName)
        {

            if (fileName != "Consultas")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = consultas.SaveConsultas(fileName);
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
        /// Carrega a lista de consultas a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="fileName">Nome do ficheiro de onde as consultas serão carregadas. Deve ser "Consultas" para que a importação seja realizada.</param>
        /// <returns>Retorna true se as consultas foram carregadas com sucesso; caso contrário, retorna false.</returns>
        /// <exception cref="FicheirosException">Lançada quando o nome do ficheiro não é "Consultas", ou ocorre um erro durante a operação de leitura.</exception>
        public bool CarregarConsultasFicheiro(string fileName)
        {
            if (fileName != "Consultas")
            {
                throw new FicheirosException();
            }

            try
            {
                bool a = consultas.LoadConsultas(fileName);
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
        /// Valida se a data da consulta é válida.
        /// </summary>
        /// <param name="data">A data da consulta.</param>
        /// <returns>Retorna true se a data for válida, caso contrário, retorna false.</returns>
        private bool ValidarDataConsulta(DateTime data)
        {
            return data <= DateTime.Now;
        }

        #endregion
    }
}
