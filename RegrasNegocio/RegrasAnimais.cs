using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using ObjetosNegocio;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a animais.
    /// </summary>
    public class RegrasAnimais
    {
        /// <summary>
        /// Instância da classe Animais a ser usada nas regras.
        /// </summary>
        Animais animais;

        /// <summary>
        /// Inicializa uma nova instância da classe RegrasAnimais com um identificador.
        /// </summary>
        /// <param name="id">O identificador utilizado para inicializar a instância de Animais.</param>
        public RegrasAnimais(int id)
        {
            animais = new Animais(id);
        }

        #region MétodosPrincipais

        /// <summary>
        /// Adiciona um novo animal à lista de animais, após validar as suas propriedades.
        /// </summary>
        /// <param name="animal">O objeto da classe AnimalSimples a ser adicionado.</param>
        /// <returns>Retorna true se o animal for adicionado com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando um argumento fornecido é inválido.</exception>
        /// <exception cref="InvalidOperationException">Lançada quando a operação de adição não pode ser realizada.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AdicionarAnimalSimples(AnimalSimples animal)
        {
            if(animais.AnimalSimplesExistente(animal))
            {
                throw new InvalidOperationException(nameof(animal.Nome) + nameof(animal.Especie));
            }

            try
            {    
                bool a = animais.AdicionarAnimalSimples(animal);
                return a;
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(nameof(animal) + ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Remove um animal da lista de animais pelo seu ID.
        /// </summary>
        /// <param name="animalId">O ID do animal a ser removido.</param>
        /// <returns>Retorna true se o animal for removido com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentException">Lançada quando o ID fornecido é inválido.</exception>
        /// <exception cref="InvalidOperationException">Lançada quando a operação de remoção não pode ser realizada.</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool RemoverAnimal(int animalId)
        {
            
            if (animalId == 0)
            {
                throw new ArgumentException(nameof(animalId));
            }

            try
            {
                bool a = animais.RemoverAnimal(animalId);
                return a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        #endregion
    }
}