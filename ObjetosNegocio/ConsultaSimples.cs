using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa uma versão simplificada de uma consulta no zoológico.
    /// Contém apenas os atributos ID, data, identificadores do animal e do veterinário que participaram na consulta.
    /// </summary>
    public class ConsultaSimples
    {
        #region Atributos

        /// <summary>
        /// Identificador único da consulta.
        /// </summary>
        int consultaId;

        /// <summary>
        /// Data da consulta.
        /// </summary>
        DateTime dataConsulta;

        /// <summary>
        /// Identificador único do animal que participou da consulta.
        /// </summary>
        int animalId;

        /// <summary>
        /// Identificador único do veterinário que realizou a consulta.
        /// </summary>
        int veterinarioId;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe ConsultaSimples.
        /// </summary>
        public ConsultaSimples()
        {
            consultaId = 0;
            dataConsulta = DateTime.Now;
            animalId = 0;
            veterinarioId = 0;
        }

        /// <summary>
        /// Construtor com parâmetros para a classe ConsultaSimples.
        /// </summary>
        /// <param name="consultaId">ID da consulta.</param>
        /// <param name="dataConsulta">Data da consulta.</param>
        /// <param name="animalId">Identificador único do animal que participou da consulta.</param>
        /// <param name="veterinarioId">Identificador único do veterinário que realizou a consulta.</param>
        public ConsultaSimples(int consultaId, DateTime dataConsulta, int animalId, int veterinarioId)
        {
            this.consultaId = consultaId;
            this.dataConsulta = dataConsulta;
            this.animalId = animalId;
            this.veterinarioId = veterinarioId;
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
        /// Obtém ou define a data da consulta.
        /// </summary>
        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador único do animal que participou na consulta.
        /// </summary>
        public int AnimalId 
        { 
            get { return animalId; } 
            set { animalId = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador único do veterinário que realizou a consulta.
        /// </summary>
        public int VeterinarioId
        {
            get { return veterinarioId; }
            set { veterinarioId = value; }
        }

        #endregion
    }

}
