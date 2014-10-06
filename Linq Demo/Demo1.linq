<Query Kind="Statements">
  <Connection>
    <ID>575e854e-13a2-499d-992c-bbc50c1feab0</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

var results = from item in Items
	where item.Active
	select new
	{
		Description = item.Description,
		Price = item.CurrentPrice,
		Calories = item.Calories,
		Comment = item.Comment
	};
	results.Dump();
	//return results.ToList();