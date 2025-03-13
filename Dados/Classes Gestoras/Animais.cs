using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosNegocio;

namespace Dados
{
    /// <summary>
    /// Classe que gere uma lista de objetos do tipo Animal.
    /// </summary>
    public class Animais
    {
        #region Atributos

        /// <summary>
        /// Identificador único da lista de animais.
        /// </summary>
        int idAnimais;

        /// <summary>
        /// Lista de animais.
        /// </summary>
        List<Animal> animais;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Animais.
        /// Inicializa a lista de animais e define o identificador padrão.
        /// </summary>
        public Animais()
        {
            idAnimais = 0;
            animais = new List<Animal>();
        }

        /// <summary>
        /// Construtor com parâmetros da classe Animais.
        /// Inicializa a lista de animais e atribui um identificador.
        /// </summary>
        /// <param name="idAnimais">Identificador único da lista de animais.</param>
        public Animais(int idAnimais)
        {
            this.idAnimais = idAnimais;
            animais = new List<Animal>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da lista de animais.
        /// </summary>
        public int IdAnimais
        {
            get { return idAnimais; }
            set { idAnimais = value; }
        }

        #endregion

        #region Outros Métodos para Animal

        /// <summary>
        /// Adiciona um animal à lista.
        /// </summary>
        /// <param name="animal">Animal a ser adicionado.</param>
        /// <returns>Retorna true se o animal foi adicionado com sucesso; caso contrário, retorna false.</returns>
        public bool AdicionarAnimal(Animal animal)
        {
            if (animais == null)
            {
                animais = new List<Animal>();
            }

            if (!animais.Contains(animal))
            {
                animais.Add(animal);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna o animal com base no ID.
        /// </summary>
        /// <param name="id">ID do animal.</param>
        /// <returns>Retorna o animal procurado ou null caso não encontre.</returns>
        public Animal EncontrarAnimal(int id)
        {
            return animais.Find(a => a.AnimalId == id);
        }

        /// <summary>
        /// Remove um animal da lista com base no ID.
        /// </summary>
        /// <param name="id">ID do animal a ser removido.</param>
        /// <returns>Retorna true se o animal foi removido com sucesso; caso contrário, retorna false.</returns>
        public bool RemoverAnimal(int id)
        {
            Animal animal = EncontrarAnimal(id);
            if (animal != null)
            {
                animais.Remove(animal);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Ordena os animais através do seu nome.
        /// </summary>
        /// <returns>Retorna true se a ordenação foi bem-sucedida, caso contrário, retorna false.</returns>
        public bool OrdenarPorAnimalNome()
        {
            if (animais == null || animais.Count == 0)
            {
                return false;
            }

            animais.Sort();
            return true;
        }

        /// <summary>
        /// Verifica se já existe um animal com o mesmo nome e espécie.
        /// </summary>
        /// <param name="animal">O animal a ser verificado.</param>
        /// <returns>Retorna true se já existir um animal com o mesmo nome e espécie, caso contrário, retorna false.</returns>
        public bool AnimalExistente(Animal animal)
        {
            if (animais.Any(a => a.Nome == animal.Nome && a.Especie == animal.Especie))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Outros Métodos para AnimalSimples

        /// <summary>
        /// Adiciona um animal simples à lista de animais.
        /// </summary>
        /// <param name="aS">O animal simples a ser adicionado.</param>
        /// <returns>Retorna true se o animal foi adicionado com sucesso, caso contrário, retorna false.</returns>
        public bool AdicionarAnimalSimples(AnimalSimples aS)
        {
            Animal animal = new Animal(aS.AnimalId, aS.Nome, aS.Especie, aS.JaulaId);
            bool resultado = AdicionarAnimal(animal);
            return resultado;
        }

        /// <summary>
        /// Verifica se já existe um animal simples na lista.
        /// </summary>
        /// <param name="aS">O animal simples a ser verificado.</param>
        /// <returns>Retorna true se o animal simples já existir, caso contrário, retorna false.</returns>
        public bool AnimalSimplesExistente(AnimalSimples aS)
        {
            Animal animal = new Animal(aS.AnimalId, aS.Nome, aS.Especie, aS.JaulaId);
            bool resultado = AnimalExistente(animal);
            return resultado;
        }

        #endregion

        #endregion
    }
}


