use csharp;

CREATE TABLE cars (
	id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL UNIQUE,
    quantity INT,
    price FLOAT,
    brand_id INT,
    status INT,
    image TEXT,
    is_deleted INT,
    FOREIGN KEY (brand_id) REFERENCES brands(id)
);


select * from brands;