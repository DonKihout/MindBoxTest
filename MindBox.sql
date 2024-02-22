SELECT "Products"."ProductName", "Categories"."CategoryName"
	FROM "Relations"
	LEFT JOIN "Products" on "Relations"."ProductID" = "Products"."ProductID"
	LEFT JOIN "Categories" on "Relations"."CategoryID" = "Categories"."CategoryID" 