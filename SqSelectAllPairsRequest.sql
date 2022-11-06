SELECT Products.name, Categories.name
FROM Products
LEFT JOIN ProductsCategories ON Products.id = ProductsCategories.products_id
INNER JOIN Categories on Categories.id = ProductsCategories.category_id
ORDER BY Products.name