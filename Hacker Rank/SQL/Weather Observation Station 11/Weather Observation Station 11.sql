SELECT DISTINCT CITY FROM STATION WHERE LOWER(SUBSTRING(CITY, 1, 1)) NOT IN ('a', 'e', 'i', 'o', 'u' ) OR LOWER(SUBSTRING(CITY, LEN(CITY), 1)) NOT IN ('a', 'e', 'i', 'o', 'u' );