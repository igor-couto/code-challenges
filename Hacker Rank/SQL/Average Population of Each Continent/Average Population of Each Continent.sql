SELECT COUNTRY.CONTINENT, FLOOR(AVG(CITY.Population))
FROM CITY
    INNER JOIN COUNTRY ON CITY.COUNTRYCODE = COUNTRY.CODE
GROUP BY COUNTRY.CONTINENT;