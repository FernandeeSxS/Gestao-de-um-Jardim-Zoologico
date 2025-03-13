using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrataProblemas;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe responsável pelo cumprimento de regras de negócio associadas a zoologico.
    /// </summary>
    public class RegrasZoologico
    {
        /// <summary>
        /// Instância da classe Zoologico a ser utilizada nas regras.
        /// </summary>
        Zoologico zoologico;

        /// <summary>
        /// Construtor da classe RegrasZoologico. Inicializa a instância de Zoologico.
        /// </summary>
        public RegrasZoologico()
        {
            zoologico = new Zoologico();
        }

        /// <summary>
        /// Atualiza o nome de um zoológico, aplicando as regras de negócio.
        /// </summary>
        /// <param name="zS">O objeto ZoologicoSimples cujo nome será atualizado.</param>
        /// <param name="novoNome">O novo nome a ser atribuído ao zoológico.</param>
        /// <returns>Retorna true se o nome foi atualizado com sucesso, caso contrário, retorna false.</returns>
        /// <exception cref="ArgumentNullException">Lançada quando o objeto ZoologicoSimples fornecido é nulo.</exception>
        /// <exception cref="NaoPodeAlterarException">Lançada quando o novo nome ultrapassa o limite de caracteres permitido (10 caracteres).</exception>
        /// <exception cref="Exception">Lançada para qualquer erro inesperado durante a operação.</exception>
        public bool AtualizarNomeZoologico(ZoologicoSimples zS, string novoNome)
        {
            if(zS == null)
            {
                throw new ArgumentNullException(nameof(zS));
            }
            if(novoNome.Length > 10)
            {
                throw new NaoPodeAlterarException();
            }

            try
            {
                bool a = zoologico.AtualizarNomeZooSimples(zS, novoNome);
                return a;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
