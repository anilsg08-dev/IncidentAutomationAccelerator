
using System;

namespace IncidentAutomationAPI.Models
{
    /// <summary>
    /// Represents an incident in the ERP/eCommerce landscape.
    /// Includes metadata for resolution tracking and continuous improvement.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Unique identifier for the incident.
        /// </summary>
        public int IncidentID { get; set; }

        /// <summary>
        /// Category of the incident (ERP, eCommerce, Database, Network).
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Severity level (High, Medium, Low).
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Timestamp when the incident was logged.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
