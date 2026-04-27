<#
.SYNOPSIS
    Restart ERP Sync Service for automated incident resolution.
.DESCRIPTION
    This script stops and starts the ERP Sync Windows service.
    It includes logging and error handling for professional use.
#>

# Define service name
$serviceName = "ERP_Sync_Service"

# Define log file path
$logFile = "C:\IncidentAutomation\logs\restart-erp.log"

# Function to log messages
function Write-Log {
    param([string]$message)
    $timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
    $entry = "$timestamp : $message"
    Add-Content -Path $logFile -Value $entry
    Write-Output $entry
}

Write-Log "Attempting to restart service: $serviceName"

try {
    # Stop service
    Stop-Service -Name $serviceName -Force -ErrorAction Stop
    Write-Log "Service $serviceName stopped successfully."

    # Start service
    Start-Service -Name $serviceName -ErrorAction Stop
    Write-Log "Service $serviceName started successfully."

    Write-Log "ERP Sync Service restart completed."
}
catch {
    Write-Log "ERROR: Failed to restart $serviceName. Details: $_"
}

