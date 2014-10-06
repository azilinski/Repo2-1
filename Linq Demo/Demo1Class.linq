<Query Kind="Program">
  <Connection>
    <ID>575e854e-13a2-499d-992c-bbc50c1feab0</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	var results = from cat in MenuCategories
	orderby cat.Description
	select new CategoryMenuItems()
	{
		Description= cat.Description,
		MenuItems = from item in cat.Items
			where item.Active
			select new MenuItem()
			{
				Description = item.Description,
				Price = item.CurrentPrice,
				Calories = item.Calories,
				Comment = item.Comment
			}
	};
	results.Dump();
}

// Define other methods and classes here
	public class MenuItem
	{
		public string Description{get;set;}
		public decimal Price{get;set;}
		public int? Calories{get;set;}
		public string Comment{get;set;}
	}
	
	public class CategoryMenuItems
	{
		public string Description{get;set;}
		public IEnumerable MenuItems{get;set;}
		
	}