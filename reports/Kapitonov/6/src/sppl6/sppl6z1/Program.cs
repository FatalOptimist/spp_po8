using sppl6z1;

Director director1 = new Director(new BuildMeetBurger(), new BuildColdDrink(), new BuildIndoorPackage());
Order order1 = director1.MakeOrder();

Console.WriteLine(order1);