using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios
{
    /// <summary>
    /// Classe de testes unitários para a funcionalidade de gestão de animais no sistema.
    /// </summary>
    [TestClass]
    public class TestAnimais
    {
        #region AdicionarAnimal

        /// <summary>
        /// Testa a validação do nome ao adicionar um novo animal e verifica se a operação é bem-sucedida.
        /// </summary>
        [TestMethod]
        public void AdicionarAnimalSimplesValidaNomeESucesso()
        {
            RegrasAnimais animais = new RegrasAnimais(1);

            AnimalSimples animal = new AnimalSimples(1, "Mufasa", "Leão", 3);

            bool resultado = animais.AdicionarAnimalSimples(animal);

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Testa a tentativa de adicionar um animal com nome repetido, verificando se uma exceção do tipo <see cref="InvalidOperationException"/> é lançada.
        /// </summary>
        [TestMethod]
        public void AdicionarAnimalSimplesNomeRepetidoLancaArgumentException()
        {
            RegrasAnimais animais = new RegrasAnimais(1);

            AnimalSimples animal1 = new AnimalSimples(1, "Mufasa", "Leão", 3);
            AnimalSimples animal2 = new AnimalSimples(1, "Mufasa", "Leão", 3);

            animais.AdicionarAnimalSimples(animal1);

            Exception ex = Assert.ThrowsException<InvalidOperationException>(() => animais.AdicionarAnimalSimples(animal2));
        }

        #endregion


        #region RemoverAnimal

        /// <summary>
        /// Testa a remoção de um animal com um ID inválido, verificando se uma exceção do tipo <see cref="ArgumentException"/> é lançada.
        /// </summary>
        [TestMethod]
        public void RemoverAnimalIDInvalidoLancaArgumentException()
        {
            RegrasAnimais animais = new RegrasAnimais(1);

            Exception ex = Assert.ThrowsException<ArgumentException>(() => animais.RemoverAnimal(0));
        }

        /// <summary>
        /// Testa a remoção bem-sucedida de um animal através do seu ID.
        /// </summary>
        [TestMethod]
        public void RemoverAnimalSucesso()
        {
            RegrasAnimais animais = new RegrasAnimais(1);
            AnimalSimples animal1 = new AnimalSimples(1, "Mufasa", "Leão", 3);

            animais.AdicionarAnimalSimples(animal1);

            bool resultado = animais.RemoverAnimal(animal1.AnimalId);

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Testa a tentativa de remoção de um animal que não existe, verificando se a operação retorna false.
        /// </summary>
        [TestMethod]
        public void RemoverAnimalNaoExistenteRetornaFalse()
        {
            RegrasAnimais animais = new RegrasAnimais(1);

            bool resultado = animais.RemoverAnimal(9999);

            Assert.IsFalse(resultado);
        }

        #endregion
    }

}