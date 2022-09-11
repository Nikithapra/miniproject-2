//program  to print product list with condition 1

using checkpoint_2_list;
using System.Reflection.PortableExecutable;

bool ad = true;

//Creating a List1
List<ProductList> prod1 = new List<ProductList>();

//Creating a List2
List<ProductList2> prod2 = new List<ProductList2>();
try 
{ 
while (ad)
{

    Console.WriteLine("enter the product category");
    string Category = Console.ReadLine();

    Console.WriteLine("enter the product name");
    string Prodname = Console.ReadLine();

    Console.WriteLine("enter the product price");
    int Price = int.Parse(Console.ReadLine());



    Console.WriteLine("enter the product quantity");
    int Quantity = int.Parse(Console.ReadLine());


    //creating object for class1 ProductList
    ProductList p1 = new ProductList(Category, Prodname, Price);
    //Adding to list name Prod1
    prod1.Add(p1);




    //creating object for class2 ProductList2
    ProductList2 p2 = new ProductList2(Quantity);
    //Adding to list name Prod1
    prod2.Add(p2);


    //checking for exit
    Console.WriteLine("do you want to continue Y/exit");
    string next = Console.ReadLine();

    if (next.ToLower().Trim() == "exit")
    {
        break;

    }


}


//price list sorted from low to high


//sum  of price for list
int sum = prod1.Sum(Pd => Pd.Price);

//prod1.Sort();

//printing products list unsorted
Console.WriteLine("Product details UNSORTED list:");
Console.WriteLine("----------------------------");

Console.WriteLine("category".PadRight(10) +
              "name".PadRight(10) +
                  "price".PadRight(10)
                  );


Console.WriteLine("----------------------------");

Console.WriteLine("");

//printing 

foreach (var p in prod1)
{
    Console.WriteLine(p.Category.PadRight(10) +
                      p.Prodname.PadRight(10) +
                      p.Price.ToString().PadRight(10));

}


//adding additiona parameters quantity
//Console.WriteLine("Product details-additional item -Quantity");

Console.WriteLine("Quantity".PadRight(10));

foreach (var p in prod2)
{
    Console.WriteLine(p.Quantity.ToString().PadRight(60));
}

Console.WriteLine("");
Console.WriteLine("sum of prices:" + sum);
Console.WriteLine("");

Console.WriteLine("Product details SORTED list:");
Console.WriteLine("----------------------------");

// printing products list sorted

List<ProductList> Pricedescending = prod1.OrderBy(pd => pd.Price).ToList();

Console.WriteLine("category".PadRight(10) +
              "name".PadRight(10) +
                  "price".PadRight(10)
                  );

Console.WriteLine("----------------------------");


foreach (var p2 in Pricedescending)
{
    Console.WriteLine(p2.Category.PadRight(10) +
                      p2.Prodname.PadRight(10) +
                      p2.Price.ToString().PadRight(10));
}

Console.WriteLine("");

List<ProductList2> quantitydescending = prod2.OrderBy(pd => pd.Quantity).ToList();
Console.WriteLine("Quantity".PadRight(10));

foreach (var p3 in quantitydescending)
{
    Console.WriteLine(p3.Quantity.ToString().PadRight(60));
}
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();



//class1
class ProductList
{
    //creating default constructor
    public ProductList(string category, string prodname, int price)
    {
        Category = category;
        Prodname = prodname;
        Price = price;
    }

    public String Category { get; set; }
    public String Prodname { get; set; }
    public int Price { get; set; }


}