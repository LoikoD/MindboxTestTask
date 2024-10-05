/*
	Пояснение:
	
	Если считать, что в базе данных существуют три таблицы:
		1. product: содержит информация о всех продуктах, включая их id и имя (name)
		2. category: содержит информация о всех категориях, включая их id и имя (name)
		3. product_category - таблица-связь, которая устанавливает связь многие ко многим между продуктами и категориями.
		   Эта таблица содержит внешние ключи product_id и category_id, указывающие на соответствующие id в таблицах product и category.
	то решением будет запрос #1.
    
	Если структура в БД не нормализованная, и таблицы-связи нет, а, например, в таблице product есть поля category_id_1, category_id_2, category_id_3 и т.д.,
	в таком случае в качестве решения можно использовать запрос #2.
*/

-- Запрос #1
SELECT p.name AS ProductName, c.name AS CategoryName
FROM product p
LEFT JOIN product_category pc ON p.id = pc.product_id
LEFT JOIN category c ON pc.category_id = c.id;


-- Запрос #2

SELECT p.name AS ProductName, c.name AS CategoryName
FROM product p
LEFT JOIN category c ON p.category_id_1 = c.id

UNION

SELECT p.name AS ProductName, c.name AS CategoryName
FROM product p
LEFT JOIN category c ON p.category_id_2 = c.id

UNION

SELECT p.name AS ProductName, c.name AS CategoryName
FROM product p
LEFT JOIN category c ON p.category_id_3 = c.id

UNION

...

UNION

SELECT p.name AS ProductName, c.name AS CategoryName
FROM product p
LEFT JOIN category c ON p.category_id_X = c.id;