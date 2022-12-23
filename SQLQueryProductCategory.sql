SELECT p.NameProduct, c.CategoryName
FROM   dbo.Products AS p 
       LEFT OUTER JOIN dbo.ProductCategory AS pc ON p.Id = pc.IdProduct 
       LEFT OUTER JOIN dbo.Category AS c ON pc.IdCategory = c.Id
