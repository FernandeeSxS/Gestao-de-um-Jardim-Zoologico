using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe que representa uma consulta veterinária de um animal.
    /// </summary>
    public class Consulta : IComparable
    {
        #region Atributos

        /// <summary>
        /// Identificador único da consulta.
        /// </summary>
        int consultaId;

        /// <summary>
        /// Identificador do animal que realizou a consulta.
        /// </summary>
        int animalId;

        /// <summary>
        /// Identificador do veterinário responsável pela consulta.
        /// </summary>
        int veterinarioId;

        /// <summary>
        /// Data da consulta.
        /// </summary>
        DateTime dataConsulta;

        /// <summary>
        /// Descrição dos sintomas relatados ou observados.
        /// </summary>
        string sintomas;

        /// <summary>
        /// Diagnóstico feito pelo veterinário.
        /// </summary>
        string diagnostico;

        /// <summary>
        /// Tratamento prescrito durante a consulta.
        /// </summary>
        string tratamento;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Consulta.
        /// </summary>
        public Consulta()
        {
            consultaId = 0;
            animalId = 0;
            veterinarioId = 0;
            dataConsulta = DateTime.Now;
            sintomas = "";
            diagnostico = "";
            tratamento = "";
        }

        /// <summary>
        /// Construtor com parâmetros para a classe Consulta.
        /// </summary>
        /// <param name="consultaId">ID da consulta.</param>
        /// <param name="animalId">ID do animal que realizou a consulta.</param>
        /// <param name="veterinarioId">ID do veterinário responsável pela consulta.</param>
        /// <param name="dataConsulta">Data da consulta.</param>
        public Consulta(int consultaId, DateTime dataConsulta, int animalId, int veterinarioId)
        {
            this.consultaId = consultaId;
            this.animalId = animalId;
            this.veterinarioId = veterinarioId;
            this.dataConsulta = dataConsulta;
        }

        /// <summary>
        /// Construtor com parâmetros para a classe Consulta.
        /// </summary>
        /// <param name="consultaId">ID da consulta.</param>
        /// <param name="animalId">ID do animal que realizou a consulta.</param>
        /// <param name="veterinarioId">ID do veterinário responsável pela consulta.</param>
        /// <param name="dataConsulta">Data da consulta.</param>
        /// <param name="sintomas">Descrição dos sintomas.</param>
        /// <param name="diagnostico">Diagnóstico feito pelo veterinário.</param>
        /// <param name="tratamento">Tratamento prescrito.</param>
        public Consulta(int consultaId, int animalId, int veterinarioId, DateTime dataConsulta, string sintomas, string diagnostico, string tratamento)
        {
            this.consultaId = consultaId;
            this.animalId = animalId;
            this.veterinarioId = veterinarioId;
            this.dataConsulta = dataConsulta;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.tratamento = tratamento;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da consulta.
        /// </summary>
        public int ConsultaId
        {
            get { return consultaId; }
            set { consultaId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do animal que realizou a consulta.
        /// </summary>
        public int AnimalId
        {
            get { return animalId; }
            set { animalId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador do veterinário responsável pela consulta.
        /// </summary>
        public int VeterinarioId
        {
            get { return veterinarioId; }
            set { veterinarioId = value; }
        }

        /// <summary>
        /// Obtém ou define a data da consulta.
        /// </summary>
        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

        /// <summary>
        /// Obtém ou define a descrição dos sintomas relatados ou observados.
        /// </summary>
        public string Sintomas
        {
            get { return sintomas; }
            set { sintomas = value; }
        }

        /// <summary>
        /// Obtém ou define o diagnóstico feito pelo veterinário.
        /// </summary>
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        /// <summary>
        /// Obtém ou define o tratamento prescrito durante a consulta.
        /// </summary>
        public string Tratamento
        {
            get { return tratamento; }
            set { tratamento = value; }
        }

        #endregion

        #region Outros Métodos

        /// <summary>
        /// Método de comparação para ordenar as consultas por data.
        /// </summary>
        /// <param name="o">Outro objeto do tipo Consulta</param>
        /// <returns>Resultado da comparação</returns>
        public int CompareTo(Object o)
        {
            if (!(o is Consulta))
                throw new ArgumentException();

            Consulta c = o as Consulta;
            return c.dataConsulta.CompareTo(this.dataConsulta);
        }

        #endregion

        #endregion

    }
}
