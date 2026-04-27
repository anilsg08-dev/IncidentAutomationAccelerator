import React, { useEffect, useState } from "react";
import axios from "axios";

function Dashboard() {
  const [incidents, setIncidents] = useState([]);

  // Fetch incidents from backend API
  useEffect(() => {
    axios.get("http://localhost:5000/api/incident")
      .then(res => setIncidents(res.data))
      .catch(err => console.error("Error fetching incidents:", err));
  }, []);

  // Resolve incident by ID
  const resolveIncident = (id) => {
    axios.post(`http://localhost:5000/api/incident/resolve/${id}`)
      .then(res => {
        setIncidents(incidents.map(i => i.incidentID === id ? res.data : i));
      })
      .catch(err => console.error("Error resolving incident:", err));
  };

  return (
    <div style={{ padding: "20px", fontFamily: "Arial, sans-serif" }}>
      <h2 style={{ color: "#2c3e50" }}>Incident Dashboard</h2>
      <table style={{ width: "100%", borderCollapse: "collapse", marginTop: "20px" }}>
        <thead>
          <tr style={{ backgroundColor: "#ecf0f1" }}>
            <th style={{ border: "1px solid #bdc3c7", padding: "8px" }}>ID</th>
            <th style={{ border: "1px solid #bdc3c7", padding: "8px" }}>Category</th>
            <th style={{ border: "1px solid #bdc3c7", padding: "8px" }}>Severity</th>
            <th style={{ border: "1px solid #bdc3c7", padding: "8px" }}>Description</th>
            <th style={{ border: "1px solid #bdc3c7", padding: "8px" }}>Status</th>
            <th style={{ border: "1px solid #bdc3c7", padding: "8px" }}>Resolution Time (min)</th>

