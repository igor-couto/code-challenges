SELECT Name + QUOTENAME(SUBSTRING(Occupation, 1, 1), '()') FROM OCCUPATIONS ORDER BY Name;

SELECT 'There are a total of ' + CAST (COUNT(Occupation) AS VARCHAR) + ' ' + LOWER(Occupation) + 's.' FROM OCCUPATIONS GROUP BY Occupation ORDER BY COUNT(Occupation) , Occupation ASC; 