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
    /// Classe que gere uma lista de objetos do tipo Jaula.
    /// </summary>
    public class Jaulas
    {
        #region Atributos

        /// <summary>
        /// Identificador único da lista de jaulas.
        /// </summary>
        int idJaulas;

        /// <summary>
        /// Lista de jaulas.
        /// </summary>
        List<Jaula> jaulas;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Jaulas.
        /// Inicializa a lista de jaulas e define o identificador padrão.
        /// </summary>
        public Jaulas()
        {
            idJaulas = 0;
            jaulas = new List<Jaula>();
        }

        /// <summary>
        /// Construtor com parâmetros da classe Jaulas.
        /// Inicializa a lista de jaulas e atribui um identificador.
        /// </summary>
        /// <param name="idJaulas">Identificador único da lista de jaulas.</param>
        public Jaulas(int idJaulas)
        {
            this.idJaulas = idJaulas;
            jaulas = new List<Jaula>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da lista de jaulas.
        /// </summary>
        public int IdJaulas
        {
            get { return idJaulas; }
            set { idJaulas = value; }
        }

        #endregion

        #region Outros Métodos Complexos

        /// <summary>
        /// Adiciona uma jaula à lista de jaulas.
        /// </summary>
        /// <param name="jaula">Jaula a ser adicionada.</param>
        /// <returns>Retorna verdadeiro se a jaula foi adicionada com sucesso; caso contrário, retorna falso.</returns>
        public bool AdicionarJaula(Jaula jaula)
        {
            if (!jaulas.Contains(jaula))
            {
                jaulas.Add(jaula);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a jaula com base no ID.
        /// </summary>
        /// <param name="jaulaId">Identificador da jaula.</param>
        /// <returns>Retorna a jaula procurada ou null caso não encontre.</returns>
        public Jaula EncontrarJaula(int jaulaId)
        {
            return jaulas.Find(j => j.JaulaId == jaulaId);
        }

        /// <summary>
        /// Remove uma jaula da lista com base no ID.
        /// </summary>
        /// <param name="jaulaId">Identificador da jaula a ser removida.</param>
        /// <returns>Retorna verdadeiro se a jaula foi removida com sucesso; caso contrário, retorna falso.</returns>
        public bool RemoverJaula(int jaulaId)
        {
            Jaula jaula = EncontrarJaula(jaulaId);
            if (jaula != null)
            {
                jaulas.Remove(jaula);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Preservar a lista de jaulas num ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro onde os dados serão guardados.</param>
        /// <returns>Retorna true se os dados foram guardados com sucesso, caso contrário, retorna false.</returns>
        public bool SaveJaulas(string fileName)
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
        /// Carrega a lista de jaulas de um ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro onde os dados das jaulas estão armazenados.</param>
        /// <returns>Retorna true se os dados foram carregados com sucesso, caso contrário, retorna false.</returns>
        public bool LoadJaulas(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException();
                }

                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                Jaulas jaulasDeserializadas = (Jaulas)bin.Deserialize(stream);
                stream.Close();

                this.idJaulas = jaulasDeserializadas.idJaulas;
                this.jaulas = jaulasDeserializadas.jaulas;

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
        /// Adiciona uma jaula simples à lista de jaulas.
        /// </summary>
        /// <param name="jS">Jaula simples a ser adicionada.</param>
        /// <returns>Retorna verdadeiro se a jaula foi adicionada com sucesso, caso contrário, retorna falso.</returns>
        public bool AdicionarJaulaSimples(JaulaSimples jS)
        {
            Jaula jaula = new Jaula(jS.JaulaId, jS.Capacidade);
            bool resultado = AdicionarJaula(jaula);
            return resultado;
        }

        #endregion

        #endregion
    }
}