/*
------------------------------------------------------------
 Script: rerun-etl.sql
 Purpose: Re-run failed ETL job for automated incident resolution
 Author: Incident Automation Accelerator
------------------------------------------------------------
*/

-- Log start of ETL rerun
PRINT 'Starting ETL job rerun at ' + CONVERT(VARCHAR, GETDATE(), 120);

BEGIN TRY
    -- Example: call stored procedure to re-run ETL job
    EXEC usp_RunETLJob @JobID = 101;

    -- Log success
    PRINT 'ETL job rerun completed successfully at ' + CONVERT(VARCHAR, GETDATE(), 120);
END TRY
BEGIN CATCH
    -- Log error details
    PRINT 'ERROR: ETL job rerun failed at ' + CONVERT(VARCHAR, GETDATE(), 120);
    PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS VARCHAR);
    PRINT 'Error Message: ' + ERROR_MESSAGE();
END CATCH;

