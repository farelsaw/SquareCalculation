SELECT P.Name AS 'Имя продукта', C.name AS 'Имя категории' 
FROM Products AS P
LEFT JOIN Categories AS C ON P.CategoryId = C.Id;