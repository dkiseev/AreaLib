CREATE TABLE products (id_product int PRIMARY KEY, name_product nvarchar(255) NOT NULL);
CREATE TABLE categories (id_category int PRIMARY KEY, name_category nvarchar(255) NOT NULL);
CREATE TABLE products_categories (id_product int , id_category int, PRIMARY KEY (id_product, id_category));

select p.name_product, c.name_category from products p
left join products_categories pc on p.id_product = pc.id_product
left join categories c on pc.id_category = c.id_category;