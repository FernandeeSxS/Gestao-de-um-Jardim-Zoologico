using ObjetosNegocio;
using RegrasNegocio;
using TrataProblemas;

namespace TestesUnitarios
{
    namespace TestesUnitarios
    {
        /// <summary>
        /// Classe de testes unitários para a funcionalidade de gestão de bilhetes no sistema.
        /// </summary>
        [TestClass]
        public class TestBilhetes
        {
            #region AdicionarBilhete

            /// <summary>
            /// Testa a adição de um bilhete simples com sucesso.
            /// </summary>
            [TestMethod]
            public void AdicionarBilheteSimplesSucesso()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                BilheteSimples bilheteSimples = new BilheteSimples("A1", new DateTime(2024, 11, 15));

                bool resultado = bilhetes.AdicionarBilheteSimples(bilheteSimples);

                Assert.IsTrue(resultado);
            }

            /// <summary>
            /// Testa a tentativa de adicionar um bilhete simples com um ID já existente, verificando se é lançada uma exceção do tipo <see cref="InvalidOperationException"/>.
            /// </summary>
            [TestMethod]
            public void AdicionarBilheteSimplesIDExistente()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                BilheteSimples bilheteSimples1 = new BilheteSimples("A1", new DateTime(2024, 11, 15));
                bilhetes.AdicionarBilheteSimples(bilheteSimples1);

                BilheteSimples bilheteSimples2 = new BilheteSimples("A1", new DateTime(2024, 11, 15));

                Exception ex = Assert.ThrowsException<InvalidOperationException>(() => bilhetes.AdicionarBilheteSimples(bilheteSimples2));
            }

            #endregion


            #region RemoverBilhete

            /// <summary>
            /// Testa a remoção de um bilhete com código inválido, verificando se é lançada uma exceção do tipo <see cref="ArgumentException"/>.
            /// </summary>
            [TestMethod]
            public void RemoverBilheteCodigoInvalido()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                Exception ex = Assert.ThrowsException<ArgumentException>(() => bilhetes.RemoverBilhete("A0"));
            }

            /// <summary>
            /// Testa a remoção bem-sucedida de um bilhete através do seu código.
            /// </summary>
            [TestMethod]
            public void RemoverBilheteSucesso()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                BilheteSimples bilheteSimples = new BilheteSimples("A1", new DateTime(2024, 11, 15));
                bilhetes.AdicionarBilheteSimples(bilheteSimples);

                bool resultado = bilhetes.RemoverBilhete(bilheteSimples.Codigo);

                Assert.IsTrue(resultado);
            }

            /// <summary>
            /// Testa a tentativa de remoção de um bilhete com um código que não existe, verificando se a operação retorna false.
            /// </summary>
            [TestMethod]
            public void RemoverBilheteCodigoNaoExistente()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                bool resultado = bilhetes.RemoverBilhete("Z1");

                Assert.IsFalse(resultado);
            }

            #endregion


            #region AlterarPrecoBilhetes

            /// <summary>
            /// Testa a alteração de preço de bilhetes para uma data específica com sucesso.
            /// </summary>
            [TestMethod]
            public void AlterarPrecoBilhetesPorDataSucesso()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                BilheteSimples bilheteSimples1 = new BilheteSimples("A1", new DateTime(2024, 11, 15));
                BilheteSimples bilheteSimples2 = new BilheteSimples("A2", new DateTime(2024, 11, 15));

                bilhetes.AdicionarBilheteSimples(bilheteSimples1);
                bilhetes.AdicionarBilheteSimples(bilheteSimples2);

                bool resultado = bilhetes.AlterarPrecoBilhetesPorData(new DateTime(2024, 11, 15), 20.00);

                Assert.IsTrue(resultado);
            }

            /// <summary>
            /// Testa a tentativa de alterar o preço de bilhetes para uma data específica com um valor de preço excessivo, verificando se é lançada uma exceção do tipo <see cref="NaoPodeAlterarException"/>.
            /// </summary>
            [TestMethod]
            public void AlterarPrecoBilhetesPorDataPrecoAlto()
            {
                RegrasBilhetes bilhetes = new RegrasBilhetes(1);

                BilheteSimples bilheteSimples1 = new BilheteSimples("A1", new DateTime(2024, 11, 15));
                bilhetes.AdicionarBilheteSimples(bilheteSimples1);

                NaoPodeAlterarException ex = Assert.ThrowsException<NaoPodeAlterarException>(() => bilhetes.AlterarPrecoBilhetesPorData(DateTime.Now, 30.01));
            }

            #endregion
        }
    }


}