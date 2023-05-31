SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductId = ProductCategory.ProductId
LEFT JOIN Categories ON ProductCategory.CategoryId = Categories.CategoryId;
