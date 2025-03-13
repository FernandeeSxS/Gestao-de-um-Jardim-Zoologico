using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /// <summary>
    /// Classe que representa o Zoológico.
    /// </summary>
    public class Zoologico
    {
        #region Atributos

        /// <summary>
        /// Nome do zoológico.
        /// </summary>
        string nome;

        /// <summary>
        /// Localização do zoológico.
        /// </summary>
        string localizacao;

        /// <summary>
        /// Instância que gere as jaulas do zoológico.
        /// </summary>
        Jaulas jaulas;

        /// <summary>
        /// Instância que gere os veterinários do zoológico.
        /// </summary>
        Veterinarios veterinarios;

        /// <summary>
        /// Instância que gere os funcionários do zoológico.
        /// </summary>
        Funcionarios funcionarios;

        /// <summary>
        /// Instância que gere os bilhetes do zoológico.
        /// </summary>
        Bilhetes bilhetes;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Zoologico.
        /// </summary>
        public Zoologico()
        {
            nome = "";
            localizacao = "";
            jaulas = new Jaulas();
            veterinarios = new Veterinarios();
            funcionarios = new Funcionarios();
            bilhetes = new Bilhetes();
        }

        /// <summary>
        /// Construtor com parâmetros da classe Zoologico.
        /// </summary>
        /// <param name="nome">Nome do zoológico.</param>
        /// <param name="localizacao">Localização do zoológico.</param>
        /// <param name="jaulas">Instância para gerenciar jaulas.</param>
        /// <param name="veterinarios">Instância para gerenciar veterinários.</param>
        /// <param name="funcionarios">Instância para gerenciar funcionários.</param>
        /// <param name="bilhetes">Instância para gerenciar bilhetes.</param>
        public Zoologico(string nome, string localizacao, Jaulas jaulas, Veterinarios veterinarios, Funcionarios funcionarios, Bilhetes bilhetes)
        {
            this.nome = nome;
            this.localizacao = localizacao;
            this.jaulas = jaulas;
            this.veterinarios = veterinarios;
            this.funcionarios = funcionarios;
            this.bilhetes = bilhetes;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Zoologico.
        /// </summary>
        /// <param name="idJaulas">Identificador da lista de jaulas do zoológico.</param>
        /// <param name="idVeterinarios">Identificador da lista de veterinarios do zoológico.</param>
        /// <param name="idFuncionarios">Identificador da lista de funcionarios do zoológico.</param>
        /// <param name="idBilhetes">Identificador da lista de bilhetes do zoológico.</param>
        public Zoologico(int idJaulas, int  idVeterinarios, int idFuncionarios, int idBilhetes)
        {
            this.jaulas = new Jaulas(idJaulas);
            this.veterinarios = new Veterinarios(idVeterinarios);
            this.funcionarios = new Funcionarios(idFuncionarios);
            this.bilhetes = new Bilhetes(idBilhetes);
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do zoológico.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define a localização do zoológico.
        /// </summary>
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        #endregion

        #region Outros Métodos

        /// <summary>
        /// Atualiza o nome de um zoológico simples, se o novo nome for válido.
        /// </summary>
        /// <param name="zS">O zoológico simples a ser atualizado.</param>
        /// <param name="novoNome">O novo nome para o zoológico.</param>
        /// <returns>True se o nome foi atualizado com sucesso; caso contrário, false.</returns>
        public bool AtualizarNomeZooSimples(ZoologicoSimples zS, string novoNome)
        {
            Zoologico z = ZoologicoSimplesEmZoologico(zS);

            if (novoNome == "")
            {
                return false;
            }

            z.Nome = novoNome;
            return true;
        }

        /// <summary>
        /// Converte um zoológico simples num zoológico.
        /// </summary>
        /// <param name="zS">O zoológico simples a ser convertido.</param>
        /// <returns>Uma instância de Zoologico baseada nos dados do ZoologicoSimples.</returns>
        public Zoologico ZoologicoSimplesEmZoologico(ZoologicoSimples zS)
        {
            if (zS.IdJaulas == 0 || zS.IdVeterinarios == 0 || zS.IdFuncionarios == 0 || zS.IdBilhetes == 0)
            {
                throw new InvalidOperationException();
            }

            return new Zoologico( zS.IdJaulas, zS.IdVeterinarios, zS.IdFuncionarios, zS.IdBilhetes);
        }

        #endregion

        #endregion
    }

}
