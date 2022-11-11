using cSharpBasics;
BlackTea blackTea = new BlackTea();
GreenTea greenTea = new GreenTea();


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

WhiteTea.Quantity = 2;
whiteTea.CheckStock();



// IEnumerable
Console.WriteLine();

TeaArray teaArray = new TeaArray();

teaArray.Add(blackTea);
teaArray.Add(greenTea);
teaArray.Add(whiteTea);

foreach (var item in teaArray)
    Console.WriteLine(item);


//IClonable
Console.WriteLine();

WhiteTea? firstTea = whiteTea.Clone() as WhiteTea;

Console.WriteLine(firstTea);



