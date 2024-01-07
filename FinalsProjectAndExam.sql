CREATE DATABASE finalsprojectandexam;

USE finalsprojectandexam;

-- USED IN LOGIN & MAINTENANCE FORM
CREATE TABLE tbl_users (
	user_Id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR (255) NOT NULL,
    password VARCHAR (255) NOT NULL
);

-- USED IN MAINTENANCE FORM
CREATE TABLE tbl_itemCategory (
	category_Id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR (255)
);
ALTER TABLE tbl_itemCategory AUTO_INCREMENT = 10001;

CREATE TABLE tbl_suppliers (
	supplier_Id INT PRIMARY KEY AUTO_INCREMENT,
    supplier_name VARCHAR (255) NOT NULL,
    address VARCHAR (255) NOT NULL,
    contactNo VARCHAR (11) NOT NULL
);
ALTER TABLE tbl_suppliers AUTO_INCREMENT = 20001;

CREATE TABLE tbl_items (
	item_Id INT PRIMARY KEY AUTO_INCREMENT,
    item_name VARCHAR (255) NOT NULL,
    category_Id INT NOT NULL,
    FOREIGN KEY (category_Id) REFERENCES tbl_itemCategory (category_Id),
    base_price DOUBLE
);
ALTER TABLE tbl_items AUTO_INCREMENT = 30001;

-- USED IN DELIVERY FORM
-- tbl_inventory is also USED IN INVENTORY MONITORING FORM & POINT OF SALES FORM
CREATE TABLE tbl_delivery (
    delivery_Id INT,
    delivery_date DATE,
    item_Id INT,
    quantity INT,
    PRIMARY KEY (delivery_Id, item_Id),
    FOREIGN KEY (item_Id) REFERENCES tbl_items (item_Id)
);

CREATE TABLE tbl_inventory (
	inventory_Id INT PRIMARY KEY AUTO_INCREMENT,
	item_Id INT NOT NULL,
    FOREIGN KEY (item_Id) REFERENCES tbl_delivery (item_Id),
    quantity INT
);
ALTER TABLE tbl_inventory AUTO_INCREMENT = 50001;

-- USED IN POINT OF SALES FORM
CREATE TABLE tbl_sales (
	receipt_Id INT,
    receipt_date DATE,
    item_Id INT,
    PRIMARY KEY (receipt_Id, item_Id),
    FOREIGN KEY (item_Id) REFERENCES tbl_inventory (item_Id),
	quantity INT,
    total_amount DOUBLE
);

INSERT INTO tbl_users 
VALUES 	(1, "admin", "admin"),
		(2, "vince", "12345"),
        (3, "alejandre", "54321"),
        (4, "darrel", "32145"),
        (5, "harry", "potter"),
        (6, "hermione", "granger"),
        (7, "ron", "weasley"),
        (8, "severus", "snape"),
        (9, "albus", "dumbledore"),
        (10, "sirius", "black");
        
INSERT INTO tbl_itemcategory (category_name)
VALUES  ("Smartphones"),
		("Laptops"),
        ("Smartwatches"),
        ("Headphones"),
        ("Gaming Consoles"),
        ("Tablets"),
        ("Cameras"),
        ("Monitors"),
        ("Earphones"),
        ("Mouse");

INSERT INTO tbl_suppliers (supplier_name, address, contactNo)
VALUES 	("Tech Haven", "123 Tech Street, Cityville", "11234567890"),
		("Gadget Galaxy", "456 Gadget Lane, Tech City", "12345678901"),
		("ElectroLink", "789 Electronics Boulevard, Gadgetsburg", "13456789012"),
		("Digital Nexus", "987 Tech Avenue, Innovate City", "14567890123"),
		("SmartWare Solutions", "654 Gadget Street, Techtopia", "15678901234"),
		("Connectech", "321 Innovation Road, Gadgetville", "16789012345"),
		("FutureTech Supplies", "876 Digital Lane, Innovate City", "17890123456"),
		("TechTrend Electronics", "234 Gadget Avenue, Future City", "18901234567"),
		("Gizmo Haven", "543 Tech Street, Innovate City", "19012345678"),
		("InnoGadgets Inc.", "876 Electronics Lane, Futurville", "10123456789"),
		("Swift Gadgets", "987 Tech Avenue, Techtopia", "11234567890"),
		("TechGenius Supplies", "654 Innovate Road, Gadgetsburg", "12345678901"),
		("Digital Innovations", "321 Gadget Street, Innovate City", "13456789012"),
		("SmartTech Solutions", "876 Tech Lane, Future City", "14567890123"),
		("ElectroGadget World", "987 Innovate Avenue, Techtopia", "15678901234"),
		("InnoSupplies Inc.", "234 Electronics Boulevard, Future City", "16789012345"),
		("TechConnect Solutions", "543 Gadget Road, Innovate City", "17890123456"),
		("GizmoTech", "876 Tech Avenue, Future City", "18901234567"),
		("InnoElectronics", "234 Electronics Lane, Techtopia", "19012345678"),
		("SmartSolutions", "876 Gadget Street, Innovate City", "10123456789"),
        ("Vince Fontanilla", "Barangay Mamatid, City of Cabuyao, Province of Laguna", "09452038317"),
		("Darrel Barnedo" , "Barangay Mamatid, City of Cabuyao, Province of Laguna", "09361435849"),
		("Christian Alejandre", "Barangay Mamatid, City of Cabuyao, Province of Laguna", "09765677676");

INSERT INTO tbl_items (item_name, category_Id, base_price) 
VALUES	("Samsung Galaxy S21", 10001, 45999.99),
		("Dell XPS 13", 10002, 82999.99),
		("Apple Watch Series 7", 10003, 19999.99),
		("Sony WH-1000XM4 Headphones", 10004, 17499.99),
		("PlayStation 5", 10005, 24999.99),
		("Apple iPad Air", 10006, 29999.99),
		("Canon EOS R5", 10007, 174999.99),
		("LG 27GL83A-B 27-inch Monitor", 10008, 24999.99),
		("AirPods Pro", 10009, 12499.99),
		("Logitech G Pro X Superlight Mouse", 10010, 7499.99),
		("iPhone 13 Pro", 10001, 95999.99),
		("HP Spectre x360", 10002, 119999.99),
		("Garmin Venu 2", 10003, 27999.99),
		("Bose QuietComfort 35 II", 10004, 23499.99),
		("Xbox Series X", 10005, 24999.99),
		("Samsung Galaxy Tab S7", 10006, 32499.99),
		("Nikon Z6", 10007, 99999.99),
		("ASUS ROG Swift PG279Q 27-inch Monitor", 10008, 34999.99),
		("Jabra Elite 85t Earbuds", 10009, 11499.99),
		("Razer DeathAdder Elite Mouse", 10010, 3499.99);

INSERT INTO tbl_delivery (delivery_Id, delivery_date, item_Id, quantity) 
VALUES 	(40001, '2023-01-01', 30005, 150),
		(40001, '2023-01-01', 30008, 80),
		(40002, '2023-02-15', 30013, 200),
		(40002, '2023-02-15', 30007, 50),
		(40003, '2023-02-17', 30015, 150),
		(40003, '2023-02-17', 30011, 100),
		(40004, '2023-02-20', 30002, 10),
		(40004, '2023-02-20', 30004, 120),
		(40005, '2023-03-01', 30017, 25),
		(40005, '2023-03-01', 30014, 60),
		(40006, '2023-03-07', 30010, 40),
		(40006, '2023-03-07', 30003, 90),
		(40007, '2023-03-25', 30005, 150),
		(40007, '2023-03-25', 30008, 80),
		(40008, '2023-04-08', 30013, 200),
		(40008, '2023-04-08', 30007, 50),
		(40009, '2023-04-15', 30015, 150),
		(40009, '2023-04-15', 30001, 100),
		(40010, '2023-04-17', 30002, 10),
		(40010, '2023-04-17', 30004, 120),
		(40011, '2023-04-19', 30017, 25),
		(40011, '2023-04-19', 30014, 60),
		(40012, '2023-05-10', 30003, 90),
		(40013, '2023-05-10', 30015, 120),
        (40014, '2023-05-15', 30019, 90),
		(40015, '2023-05-15', 30008, 120),
        (40016, '2023-06-01', 30013, 90),
		(40017, '2023-06-13', 30014, 120),
        (40018, '2023-06-15', 30006, 90),
		(40019, '2023-06-23', 30020, 120);
        
INSERT INTO tbl_inventory (item_id, quantity)
VALUES 	(30005, 145),
		(30008, 77),
		(30013, 192),
		(30007, 48),
		(30015, 145),
		(30011, 96),
		(30002, 9),
		(30004, 114),
		(30014, 57),
		(30017, 23),
		(30003, 90),
		(30010, 39),
		(30001, 95),
		(30019, 86),
		(30006, 87),
		(30020, 118);
        
INSERT INTO tbl_sales
VALUES 	(60001, '2023-07-05', 30005, 5, 124999.95),
		(60001, '2023-07-05', 30008, 3, 74999.97),
		(60001, '2023-07-05', 30013, 8, 223999.92),
		(60001, '2023-07-05', 30007, 2, 349999.98),
		(60002, '2023-08-09', 30015, 5, 124999.95),
		(60002, '2023-08-09', 30011, 4, 383999.96),
		(60002, '2023-08-09', 30002, 1, 82999.99),
		(60002, '2023-08-09', 30004, 6, 104999.94),
		(60003, '2023-09-13', 30014, 3, 70499.97),
		(60003, '2023-09-13', 30017, 2, 199999.98),
		(60003, '2023-09-13', 30003, 4, 79999.96),
		(60003, '2023-09-13', 30010, 1, 7499.99),
		(60004, '2023-10-17', 30001, 5, 229999.95),
		(60004, '2023-10-17', 30019, 4, 45999.96),
		(60004, '2023-10-17', 30006, 3, 89999.97),
		(60004, '2023-10-17', 30020, 2, 6999.98),
		(60005, '2023-11-21', 30005, 2, 49999.98),
		(60005, '2023-11-21', 30008, 3, 74999.97),
		(60006, '2023-12-25', 30014, 3, 70499.97),
		(60006, '2023-12-25', 30017, 2, 199999.98),
		(60006, '2023-12-25', 30003, 4, 79999.96),
		(60006, '2023-12-25', 30010, 1, 7499.99),
		(60007, '2023-12-26', 30001, 5, 229999.95),
		(60007, '2023-12-26', 30019, 4, 45999.96),
		(60007, '2023-12-26', 30006, 3, 89999.97),
		(60007, '2023-12-26', 30020, 2, 6999.98),
		(60008, '2023-12-27', 30005, 2, 49999.98),
		(60008, '2023-12-27', 30008, 3, 74999.97),
		(60008, '2023-12-27', 30013, 6, 167999.94),
		(60008, '2023-12-27', 30007, 2, 349999.98),
		(60009, '2023-12-28', 30015, 5, 124999.95),
		(60009, '2023-12-28', 30011, 4, 383999.96),
		(60009, '2023-12-28', 30002, 1, 82999.99),
		(60009, '2023-12-28', 30004, 6, 104999.94),
		(60010, '2023-12-29', 30014, 3, 70499.97),
		(60010, '2023-12-29', 30017, 2, 199999.98),
		(60010, '2023-12-29', 30003, 4, 79999.96),
		(60010, '2023-12-29', 30010, 1, 7499.99);

SELECT * FROM tbl_users;
SELECT * FROM tbl_itemcategory;
SELECT * FROM tbl_suppliers;
SELECT * FROM tbl_items;
SELECT * FROM tbl_delivery;
SELECT * FROM tbl_inventory;
SELECT * FROM tbl_sales;