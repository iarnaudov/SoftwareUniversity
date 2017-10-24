SELECT 
	CountryName, CountryCode, 
	IIF(Currencies.CurrencyCode = 'EUR', 'Euro', 'Not Euro') AS Currency
FROM Countries 
LEFT JOIN Currencies ON Currencies.CurrencyCode = Countries.CurrencyCode
ORDER BY CountryName

---*---*---*---*---*---*---*---*---*---*---*---

SELECT CountryName, CountryCode,
CASE CurrencyCode
WHEN 'EUR' THEN 'Euro'
ELSE 'Not Euro'
END AS Currency
FROM Countries
ORDER BY CountryName