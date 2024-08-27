-- Дропаем таблицы если существуют
DROP TABLE IF EXISTS products_categories;
DROP TABLE IF EXISTS products;
DROP TABLE IF EXISTS categories;

-- Создаем таблицы
CREATE TABLE products (
    product_id SERIAL PRIMARY KEY,
    product_name VARCHAR(100)
);

CREATE TABLE categories (
    category_id SERIAL PRIMARY KEY,
    category_name VARCHAR(100)
);

CREATE TABLE products_categories (
    product_id INT,
    category_id INT,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

-- Заполняем таблицы
INSERT INTO products (product_id, product_name) VALUES
(1, 'Call of duty'),
(2, 'Assassins Creed'),
(3, 'Sonic'),
(4, 'The Last of Us'),
(5, 'Cyberpunk'),
(6, 'Need for Speed');

INSERT INTO categories (category_id, category_name) VALUES
(1, 'Strategy'),
(2, 'Story'),
(3, 'Shooter'),
(4, '3rd person'),
(5, 'Adventure'),
(6, 'Platfomer');

INSERT INTO products_categories (product_id, category_id) VALUES
(1, 3),
(1, 5),
(2, 2),
(2, 4),
(3, 6),
(3, 5),
(4, 4),
(4, 2),
(5, 3),
(5, 2);

-- Пишем запрос
SELECT 
    product_name, 
    category_name
FROM 
    products as p
LEFT JOIN 
    products_categories pc ON p.product_id = pc.product_id
LEFT JOIN 
    categories c ON pc.category_id = c.category_id;