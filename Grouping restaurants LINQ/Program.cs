List<Restaurant> restaurants = new List<Restaurant>() {
    new Restaurant() {  Name = "De Gouden Draak", City = "Rotterdam", OpeningYear = 1998 },
    new Restaurant() {  Name = "De Vergulde lepel", City = "Rotterdam", OpeningYear = 2001 },
    new Restaurant() {  Name = "Het Zalmpje", City = "Gouda", OpeningYear = 1998 },
    new Restaurant() {  Name = "Wokcity", City = "Utrecht", OpeningYear = 2002 },
    new Restaurant() {  Name = "Pizzaria Italia", City = "Utrecht", OpeningYear = 2001 },
    new Restaurant() {  Name = "Restaurant Garam Masala", City = "Rotterdam", OpeningYear = 2006 },
    new Restaurant() {  Name = "Friethuis Zuid", City = "Rotterdam", OpeningYear = 2012 },
    new Restaurant() {  Name = "Pizzaria Della Nonna", City = "Gouda", OpeningYear = 2001 },
    new Restaurant() {  Name = "Punjabi Foods", City = "Utrecht", OpeningYear = 2009 },
};

List<(int, int)> list = new List<(int, int)>();
foreach (Restaurant rest in restaurants)
{
    int current_year = rest.OpeningYear;
    int amount = 0;
    foreach (Restaurant r2 in restaurants)
    {
        if (current_year == r2.OpeningYear)
        {
            amount++;
        }
    }
    list.Add((current_year, amount));
}

foreach ((int year, int amount) in list.OrderByDescending(x => x.Item2).Distinct())
{
    Console.WriteLine($"{year}: {amount}");
}