import React from "react";
import Dashboard from "./components/Dashboard";

function App() {
  return (
    <div style={{ backgroundColor: "#f8f9fa", minHeight: "100vh" }}>
      <header style={{ backgroundColor: "#34495e", padding: "15px" }}>
        <h1 style={{ color: "white", margin: 0 }}>Incident Automation Accelerator</h1>
      </header>
      <main style={{ padding: "20px" }}>
        <Dashboard />
      </main>
      <footer style={{ backgroundColor: "#ecf0f1", padding: "10px", textAlign: "center" }}>
        <small>© 2026 Incident Automation Accelerator | Designed by Anil Gachinakatti</small>
      </footer>
    </div>
  );
}

export default App;

