<Query Kind="Program">
  <Connection>
    <ID>bd4951fc-bee7-4f10-a5ea-d2bbd0d28c69</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	var date = new DateTime(2014,10,24);
	date.Dump();
	ReservationsByTime(date).Dump();
}

// Define other methods and classes here
//change dynamic to DTO.classname
public List<dynamic> ReservationsByTime(DateTime date)
{
	var results = from data in Reservations
					where data.ReservationDate.Year == date.Year
						&& data.ReservationDate.Month == date.Month
						&& data.ReservationDate.Day == date.Day
						&& data.ReservationStatus == 'B'
					select new //DTO.classname
					{
						Name = data.CustomerName,
						Date = data.ReservationDate,
						Status = data.ReservationStatus,
						Event = data.SpecialEvents.Description,
						NumberInParty = data.NumberInParty,
						Contact = data.ContactPhone
					};
					//group example
					var finalResults = from item in results
										orderby item.NumberInParty
										group item by item.Date.TimeOfDay into itemGroup
										select new //
									{
										SeatingTime = itemGroup.Key,
										Reservations = itemGroup.ToList()
									};
		return finalResults.ToList<dynamic>();//remove <dynamic> once in controller with DTO classnames
}