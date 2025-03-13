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
    /// <summary>
    /// Classe que gere uma lista de objetos do tipo Veterinários.
    /// </summary>
    [Serializable]
    public class Veterinarios
    {
        #region Atributos

        /// <summary>
        /// Identificador único da lista de veterinários.
        /// </summary>
        int idVeterinarios;

        /// <summary>
        /// Lista de veterinários.
        /// </summary>
        List<Veterinario> veterinarios;


        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Veterinarios.
        /// Inicializa a lista de veterinários e define o identificador padrão.
        /// </summary>
        public Veterinarios()
        {
            idVeterinarios = 0;
            veterinarios = new List<Veterinario>();
        }

        /// <summary>
        /// Construtor com parâmetros da classe Veterinarios.
        /// Inicializa a lista de veterinários e atribui um identificador.
        /// </summary>
        /// <param name="idVeterinarios">Identificador único da lista de veterinários.</param>
        public Veterinarios(int idVeterinarios)
        {
            this.idVeterinarios = idVeterinarios;
            veterinarios = new List<Veterinario>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da lista de veterinários.
        /// </summary>
        public int IdVeterinarios
        {
            get { return idVeterinarios; }
            set { idVeterinarios = value; }
        }

        #endregion

        #region Outros Métodos Complexos

        /// <summary>
        /// Adiciona um veterinário à lista.
        /// </summary>
        /// <param name="veterinario">Veterinário a ser adicionado.</param>
        /// <returns>Retorna true se o veterinário foi adicionado com sucesso; caso contrário, retorna false.</returns>
        public bool AdicionarVeterinario(Veterinario veterinario)
        {
            if (!veterinarios.Contains(veterinario))
            {
                veterinarios.Add(veterinario);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna o veterinário com base no ID.
        /// </summary>
        /// <param name="id">ID do veterinário.</param>
        /// <returns>Retorna o veterinário procurado ou null caso não encontre.</returns>
        public Veterinario EncontrarVeterinario(int id)
        {
            return veterinarios.Find(v => v.VeterinarioId == id);
        }

        /// <summary>
        /// Remove um veterinário da lista com base no ID.
        /// </summary>
        /// <param name="id">ID do veterinário a ser removido.</param>
        /// <returns>Retorna true se o veterinário foi removido com sucesso; caso contrário, retorna false.</returns>
        public bool RemoverVeterinario(int id)
        {
            Veterinario veterinario = EncontrarVeterinario(id);
            if (veterinario != null)
            {
                veterinarios.Remove(veterinario);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Preserva a lista de veterinários num ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro onde os dados serão salvos.</param>
        /// <returns>Retorna true se os dados foram guardados com sucesso, caso contrário, retorna false.</returns>
        public bool SaveVeterinarios(string fileName)
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
        /// Carrega a lista de veterinários a partir de um ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro binário de onde os dados dos veterinários serão carregados.</param>
        /// <returns>Retorna true se os dados foram carregados com sucesso; caso contrário, lança uma exceção.</returns>
        public bool LoadVeterinarios(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException();
                }

                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                Veterinarios veterinariosDeserializados = (Veterinarios)bin.Deserialize(stream);
                stream.Close();

                this.idVeterinarios = veterinariosDeserializados.idVeterinarios;
                this.veterinarios = veterinariosDeserializados.veterinarios;

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
        /// Adiciona um veterinário à lista a partir de um objeto VeterinarioSimples.
        /// </summary>
        /// <param name="vS">Objeto do tipo VeterinarioSimples que contém as informações do veterinário a ser adicionado.</param>
        /// <returns>Retorna true se o veterinário foi adicionado com sucesso à lista; caso contrário, retorna false.</returns>
        public bool AdicionarVeterinarioSimples(VeterinarioSimples vS)
        {
            Veterinario veterinario = new Veterinario(vS.VeterinarioId, vS.Idade);

            bool resultado = AdicionarVeterinario(veterinario);
            return resultado;
        }

        #endregion

        #endregion

    }
}
