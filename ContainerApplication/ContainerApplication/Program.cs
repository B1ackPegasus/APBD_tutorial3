using ContainerApplication;

Container liquid1= new LiquidContainer(150.0,500.0,30,1000.0,false);
Container liquid2= new LiquidContainer(100.0,300.0,40,1000.0,true);
Container liquid3= new LiquidContainer(150.0,970.0,100,1000.0,false);
Container gasContainer1 = new GasContainer(200.0,20.0,200.5,1000.0,60.0);
Container gasContainer2 = new GasContainer(200.0,1410.0,200.5,2000.0,60.0);
Container refrigerator_1 = new RefrigeratedContainer(300.2,100.0,250.0,500.0,Products.Banana,20.3);
Container refrigerator_2 = new RefrigeratedContainer(300.2,200.0,250.0,500.0,Products.Cheese,20.1);

ContainerShip ship_first = new ContainerShip(10.0,7,1);
ContainerShip ship_second = new ContainerShip(15.0,5,4);
//add weight to the containers
liquid1.loadContainer(400.0);
liquid2.loadContainer(6.0);
liquid2.loadContainer(100.0);
liquid3.loadContainer(30.0);
gasContainer1.loadContainer(30.0);
gasContainer2.loadContainer(90.0);
refrigerator_1.loadContainer(400.0);
refrigerator_2.loadContainer(300.0);

Console.WriteLine(liquid1);
Console.WriteLine(refrigerator_2);

ship_first.addContainerOnBoard(gasContainer1);
ship_first.addContainerOnBoard(gasContainer2);

List<Container> containers = new List<Container>();
containers.Add(liquid1);
containers.Add(liquid2);
containers.Add(liquid3);
ship_second.addContainers(containers);

Console.WriteLine(ship_first);
Console.WriteLine(ship_second);

ship_first.removeContainerFromShip(gasContainer1.serialNumber);
refrigerator_1.emptyingCargo();
ship_second.replaceContainer(liquid2.serialNumber,refrigerator_2);
Console.WriteLine(ship_second);
Console.WriteLine();



