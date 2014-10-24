<Query Kind="Statements">
  <Connection>
    <ID>bd4951fc-bee7-4f10-a5ea-d2bbd0d28c69</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

var results = from data in Items
				orderby data.MenuCategory.Description,
						data.Description
				select new
				{
					CatDescription = data.MenuCategory.Description,
					ItemDescription = data.Description,
					Quantity= data.BillItems.Sum(x => x.Quantity),
					Price = data.BillItems.Sum(x => x.SalePrice * x.Quantity),
					Cost = data.BillItems.Sum(x => x.UnitCost * x.Quantity)
				};
results.Count().Dump();
results.Dump();