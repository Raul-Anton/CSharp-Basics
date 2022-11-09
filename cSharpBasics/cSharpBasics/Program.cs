using cSharpBasics;

BlackTea blackTea = new BlackTea();

GreenTea greenTea = new GreenTea();

blackTea.Bitterness();
greenTea.Bitterness();



Console.WriteLine();

BlackTea.Quantity = 9;

blackTea.CheckStock();
blackTea.CheckStock(10);



Console.WriteLine();

GreenTea.Quantity = 11;

greenTea.CheckStock();
greenTea.CheckStock(10);



Console.WriteLine();

WhiteTea whiteTea = new WhiteTea();

whiteTea.Bitterness();

WhiteTea.Quantity = 2;
whiteTea.CheckStock();



// IEnumerable
Console.WriteLine();

ItemArray itemArray = new ItemArray();

itemArray.Add(blackTea);
itemArray.Add(greenTea);
itemArray.Add(whiteTea);

foreach (var item in itemArray)
    Console.WriteLine(item);


//IClonable
Console.WriteLine();

WhiteTea? firstTea = whiteTea.Clone() as WhiteTea;

Console.WriteLine(firstTea);



