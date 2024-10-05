CREATE TABLE Categories (
  categoryId int,
  name varchar(15)
);

CREATE TABLE Products (
  productId int,
  name varchar(15)
);

CREATE TABLE ProductsCategories (
  productId int,
  categoryId int
);

-- insert
INSERT INTO Categories(categoryId,name) VALUES (1, 'Food products');
INSERT INTO Categories(categoryId,name) VALUES (2, 'Clothes');
INSERT INTO Categories(categoryId,name) VALUES (3, 'Shoes');

INSERT INTO Products(productId,name) VALUES (1, 'Cake');
INSERT INTO Products(productId,name) VALUES (2, 'Milk');
INSERT INTO Products(productId,name) VALUES (3, 'Boots');
INSERT INTO Products(productId,name) VALUES (4, 'Coat');
INSERT INTO Products(productId,name) VALUES (5, 'Auto');

INSERT INTO ProductsCategories(productId,categoryId) VALUES (1, 1);
INSERT INTO ProductsCategories(productId,categoryId) VALUES (2, 1);
INSERT INTO ProductsCategories(productId,categoryId) VALUES (3, 2);
INSERT INTO ProductsCategories(productId,categoryId) VALUES (3, 3);
INSERT INTO ProductsCategories(productId,categoryId) VALUES (4, 2);

-- fetch 
SELECT 
  p.name,
  c.name
  
FROM Products AS p
LEFT JOIN ProductsCategories as pc ON pc.productId = p.productId
LEFT JOIN Categories as c ON c.categoryId = pc.categoryId;
GO