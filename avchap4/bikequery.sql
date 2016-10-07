SELECT     Production.Product.Name, Production.Product.ProductNumber, Production.Product.Color, Production.Product.StandardCost, 
                      Production.Product.ListPrice, Production.Product.Size, Production.Product.Weight, Production.ProductPhoto.ThumbNailPhoto, 
                      Production.ProductPhoto.LargePhoto
FROM         Production.ProductProductPhoto INNER JOIN
                      Production.ProductPhoto ON Production.ProductProductPhoto.ProductPhotoID = Production.ProductPhoto.ProductPhotoID INNER JOIN
                      Production.Product ON Production.ProductProductPhoto.ProductID = Production.Product.ProductID
WHERE        Production.Product.ListPrice > 250
