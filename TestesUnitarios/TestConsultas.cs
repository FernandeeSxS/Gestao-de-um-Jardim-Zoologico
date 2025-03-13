using ObjetosNegocio;
using RegrasNegocio;
using TrataProblemas;

namespace TestesUnitarios
{
    /// <summary>
    /// Classe de testes unitários para a funcionalidade de gestão de consultas no sistema.
    /// </summary>
    [TestClass]
    public class TestConsultas
    {
        #region AdicionarConsulta

        /// <summary>
        /// Testa a adição de uma consulta simples com data válida com sucesso.
        /// </summary>
        [TestMethod]
        public void AdicionarConsultaSimplesValidaDataSucesso()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);

            ConsultaSimples consultaSimples = new ConsultaSimples(1, new DateTime(2024, 11, 15), 1, 1);

            bool resultado = consultas.AdicionarConsultaSimples(consultaSimples);

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Testa a adição de uma consulta simples com data inválida, verificando se é lançada uma exceção <see cref="ArgumentException"/>.
        /// </summary>
        [TestMethod]
        public void AdicionarConsultaSimplesDataInvalidaLancaArgumentException()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);

            ConsultaSimples consultaSimples = new ConsultaSimples(1, DateTime.Now.AddDays(1), 1, 1);

            Exception ex = Assert.ThrowsException<ArgumentException>(() => consultas.AdicionarConsultaSimples(consultaSimples));
        }

        #endregion


        #region RemoverConsulta

        /// <summary>
        /// Testa a remoção de uma consulta com ID inválido, verificando se é lançada uma exceção <see cref="ArgumentException"/>.
        /// </summary>
        [TestMethod]
        public void RemoverConsultaIDInvalido()
        {

            RegrasConsultas consultas = new RegrasConsultas(1);

            Exception ex = Assert.ThrowsException<ArgumentException>(() => consultas.RemoverConsulta(0)); // ID inválido

        }

        /// <summary>
        /// Testa a remoção de uma consulta com sucesso, verificando se o resultado é verdadeiro.
        /// </summary>
        [TestMethod]
        public void RemoverConsultaSucesso()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);
            ConsultaSimples consultaSimples = new ConsultaSimples(5, new DateTime(2024, 10, 5), 2, 3);
            consultas.AdicionarConsultaSimples(consultaSimples);

            bool resultado = consultas.RemoverConsulta(consultaSimples.ConsultaId);

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Testa a tentativa de remoção de uma consulta que não existe, verificando se o resultado é falso.
        /// </summary>
        [TestMethod]
        public void RemoverConsultaConsultaNaoExistente()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);

            bool resultado = consultas.RemoverConsulta(9999); // Consulta não existente

            Assert.IsFalse(resultado);
        }

        #endregion


        #region Ficheiros

        /// <summary>
        /// Testa o caso em que o nome do ficheiro para guardar as consultas está incorreto, verificando se é lançada uma exceção <see cref="FicheirosException"/>.
        /// </summary>
        [TestMethod]
        public void GuardarConsultasFicheiroNomeIncorreto()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);

            FicheirosException ex = Assert.ThrowsException<FicheirosException>(() => consultas.GuardarConsultasFicheiro("Jaulas"));
        }

        /// <summary>
        /// Testa a gravação das consultas em um ficheiro com sucesso.
        /// </summary>
        [TestMethod]
        public void GuardarConsultasFicheiroSucesso()
        {
            // Arrange
            RegrasConsultas consultas = new RegrasConsultas(1);

            ConsultaSimples consultaSimples = new ConsultaSimples(1, new DateTime(2024, 11, 15), 1, 1);

            consultas.AdicionarConsultaSimples(consultaSimples);

            bool resultado = consultas.GuardarConsultasFicheiro("Consultas");

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Testa a leitura das consultas de um ficheiro com sucesso.
        /// </summary>
        [TestMethod]
        public void CarregarConsultasFicheiroSucesso()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);

            ConsultaSimples consultaSimples = new ConsultaSimples(1, new DateTime(2024, 11, 15), 1, 1);

            consultas.AdicionarConsultaSimples(consultaSimples);

            consultas.GuardarConsultasFicheiro("Consultas");

            bool resultado = consultas.CarregarConsultasFicheiro("Consultas");

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Testa a tentativa de carregar consultas de um ficheiro com nome incorreto, verificando se é lançada uma exceção <see cref="FicheirosException"/>.
        /// </summary>
        [TestMethod]
        public void CarregarConsultasFicheiroNomeIncorreto()
        {
            RegrasConsultas consultas = new RegrasConsultas(1);

            ConsultaSimples consultaSimples = new ConsultaSimples(1, new DateTime(2024, 11, 15), 1, 1);

            consultas.AdicionarConsultaSimples(consultaSimples);

            consultas.GuardarConsultasFicheiro("Consultas");

            Exception ex = Assert.ThrowsException<FicheirosException>(() => consultas.CarregarConsultasFicheiro("Jaulas"));
        }

        #endregion
    }

}