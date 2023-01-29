SELECT TOP 1 CAST (ROUND(    
    SQRT(
        POWER( MAX(LAT_N) - MIN(LAT_N), 2 )
        +
        POWER( MAX(LONG_W) - MIN(LONG_W), 2 )
    )
, 4) AS DECIMAL(18, 4))
FROM STATION;