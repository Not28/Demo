using DelegateCSharp;
//c1
//Mathems ma = new();
//ma.Add(10, 5);
////c2
//Mathems.Div(10, 6);
////c3
//new Mathems().Multi(10, 5);

//delegate
Abc dele = new Mathems().Multi;
dele += new Mathems();
dele(10, 5);
