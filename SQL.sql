select Products.ProductName, Categories.CategoryName
from ProductCategory
left outer join Products on Products.Id = ProductCategory.ProductId
left outer join Categories on Categories.Id = ProductCategory.CategoryId