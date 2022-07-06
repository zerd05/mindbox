CREATE DATABASE mindbox;
use mindbox;

CREATE TABLE Product
(
  Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(20) NOT NULL,
    Price INT NOT NULL
);

CREATE TABLE Category
(
  Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(20) NOT NULL
);

CREATE TABLE Category_Product
(
  Id INT PRIMARY KEY AUTO_INCREMENT,
    Product_id INT NOT NULL,
    Category_id INT NOT NULL,
    FOREIGN KEY (Product_id) REFERENCES Product (Id),
    FOREIGN KEY (Category_id) REFERENCES Category (Id)
    
);


INSERT INTO Product (name, price) VALUES("iphone 6", 1500);
INSERT INTO Product (name, price) VALUES("iphone 7", 3000);
INSERT INTO Product (name, price) VALUES("iphone 8", 1900);
INSERT INTO Product (name, price) VALUES("iphone 9", 10000);
INSERT INTO Product (name, price) VALUES("iphone 10", 15000);
INSERT INTO Product (name, price) VALUES("Обувь резииновая", 100);
INSERT INTO Product (name, price) VALUES("Бушлат", 15000);
INSERT INTO Product (name, price) VALUES("Костюм", 1200);
INSERT INTO Product (name, price) VALUES("Монитор", 15000);
INSERT INTO Product (name, price) VALUES("Процессор", 30000);
INSERT INTO Product (name, price) VALUES("BMW X5M", 2500000);



INSERT INTO Category (name) VALUES("Телефоны");
INSERT INTO Category (name) VALUES("Мобильные устройства");
INSERT INTO Category (name) VALUES("Одежда");
INSERT INTO Category (name) VALUES("Обувь");



INSERT INTO Category_Product (Product_id, Category_id) VALUES(1, 1);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(1, 2);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(2, 1);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(2, 2);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(3, 1);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(3, 2);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(4, 1);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(4, 2);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(5, 1);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(5, 2);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(6, 1);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(7, 4);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(8, 3);
INSERT INTO Category_Product (Product_id, Category_id) VALUES(9, 3);

select Product.Name as 'Наименование', Category.Name as 'Категория' from Product 
left join Category_Product on Product.Id = Category_Product.Product_id
left join Category on Category_Product.Category_id = Category.Id;