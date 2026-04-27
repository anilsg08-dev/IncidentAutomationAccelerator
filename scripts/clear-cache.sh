#!/bin/bash
# -------------------------------------------------------------------
# Script: clear-cache.sh
# Purpose: Clear application cache for automated incident resolution
# Author: Incident Automation Accelerator
# -------------------------------------------------------------------

# Define cache directory
CACHE_DIR="/var/app/cache"

# Define log file
LOG_FILE="/var/log/incident-automation/clear-cache.log"

# Function to log messages
log_message() {
    local message="$1"
    local timestamp=$(date +"%Y-%m-%d %H:%M:%S")
    echo "$timestamp : $message" | tee -a "$LOG_FILE"
}

log_message "Starting cache clear operation..."

# Check if cache directory exists
if [ -d "$CACHE_DIR" ]; then
    rm -rf "${CACHE_DIR:?}"/*
    if [ $? -eq 0 ]; then
        log_message "Cache cleared successfully from $CACHE_DIR."
    else
        log_message "ERROR: Failed to clear cache from $CACHE_DIR."
        exit 1
    fi
else
    log_message "WARNING: Cache directory $CACHE_DIR does not exist."
    exit 1
fi

log_message "Cache clear operation completed."
exit 0

