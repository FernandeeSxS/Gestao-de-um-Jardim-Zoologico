using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe que gere uma lista de objetos do tipo Funcionario.
    /// </summary>
    public class Funcionarios
    {
        #region Atributos

        /// <summary>
        /// Identificador único da lista de funcionários.
        /// </summary>
        int idFuncionarios;

        /// <summary>
        /// Lista que armazena os funcionários registados.
        /// </summary>
        List<Funcionario> func;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Funcionarios.
        /// Inicializa a lista de funcionários e define o identificador padrão.
        /// </summary>
        public Funcionarios()
        {
            idFuncionarios = 0;
            func = new List<Funcionario>();
        }

        /// <summary>
        /// Construtor com capacidade personalizada e identificador da classe Funcionarios.
        /// Inicializa a lista com uma capacidade especificada e atribui um identificador único.
        /// </summary>
        /// <param name="idFuncionarios">Identificador único da lista de funcionários.</param>
        public Funcionarios(int idFuncionarios)
        {
            this.idFuncionarios = idFuncionarios;
            func = new List<Funcionario>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da lista de funcionários.
        /// </summary>
        public int IdFuncionarios
        {
            get { return idFuncionarios; }
            set { idFuncionarios = value; }
        }

        #endregion

        #region Outros Métodos Complexos

        /// <summary>
        /// Regista um novo funcionário na lista de funcionários.
        /// </summary>
        /// <param name="funcionario">Funcionário a ser registado.</param>
        /// <returns>Retorna true se o funcionário foi registado com sucesso; caso contrário, retorna false.</returns>
        public bool RegistarFuncionario(Funcionario funcionario)
        {
            func.Add(funcionario);
            return true;
        }

        /// <summary>
        /// Remove um funcionário da lista de funcionários com base no ID.
        /// </summary>
        /// <param name="funcionarioId">O ID do funcionário a ser removido.</param>
        /// <returns>Retorna true se o funcionário foi removido com sucesso; caso contrário, retorna false.</returns>
        public bool RemoverFuncionario(int funcionarioId)
        {
            Funcionario funcionario = func.Find(f => f.FuncionarioId == funcionarioId);
            if (funcionario != null)
            {
                func.Remove(funcionario);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Preserva a lista de funcionários num ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro onde os dados serão guardados.</param>
        /// <returns>Retorna true se os dados foram guardados com sucesso, caso contrário, retorna false.</returns>
        public bool SaveFuncionarios(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de funcionários de um ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro onde os dados dos funcionários estão armazenados.</param>
        /// <returns>Retorna true se os dados foram carregados com sucesso, caso contrário, retorna false.</returns>
        public bool LoadFuncionarios(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException();
                }

                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                Funcionarios funcionariosDeserializados = (Funcionarios)bin.Deserialize(stream);
                stream.Close();

                this.idFuncionarios = funcionariosDeserializados.idFuncionarios;
                this.func = funcionariosDeserializados.func;

                return true;
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion

        #region Outros Métodos Simples

        /// <summary>
        /// Adiciona um funcionário simples à lista de funcionários.
        /// </summary>
        /// <param name="fS">Funcionário simples a ser adicionado.</param>
        /// <returns>Retorna verdadeiro se o funcionário foi adicionado com sucesso, caso contrário, retorna falso.</returns>
        public bool AdicionarFuncionarioSimples(FuncionarioSimples fS)
        {
            Funcionario funcionario = new Funcionario(fS.FuncionarioId, fS.Idade);
            bool resultado = RegistarFuncionario(funcionario);
            return resultado;
        }

        #endregion

        #endregion
    }
}


