namespace ContainerApplication;

public class ContainerShip
{
    private List<Container> Containers = new List<Container>();
    public double maxSpeed;
    public int  maxNumContainers;
    public double maxWeightConainertTonn;
    public int numberOfCont = 0;
    public double summWeight=0;

    public ContainerShip(double maxSpeed, int maxNumContainers, double maxWeightConainertTonn)
    {
        this.maxSpeed = maxSpeed;
        this.maxNumContainers = maxNumContainers;
        this.maxWeightConainertTonn = maxWeightConainertTonn;
        
    }

    public bool addOnBoard ;
    public bool addContainerOnBoard(Container cont)
    {
        addOnBoard = false;
        if (cont.massCargoKg + summWeight + cont.massContainerKg <= maxWeightConainertTonn*1000 && maxNumContainers>=numberOfCont+1)
        {
            numberOfCont += 1;
            summWeight += cont.massCargoKg + cont.massContainerKg;
            Containers.Add(cont);
            addOnBoard = true;
        }

        return addOnBoard;

    }

    public void addContainers(List<Container> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (!addContainerOnBoard(list[i]))
            {
                break;
            }
        }
    }

    public void removeContainerFromShip(String serialNum)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].serialNumber == serialNum)
            {
                numberOfCont -= 1;
                summWeight -= Containers[i].massCargoKg - Containers[i].massContainerKg;
                Containers.RemoveAt(i);
                break;
            }
        }
    }

    public void replaceContainer(String number,Container container)
    {
        Container cont;
        
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].serialNumber == number)
            {
                if (container.massContainerKg + container.massCargoKg + summWeight - Containers[i].massContainerKg -
                    Containers[i].massCargoKg <= maxWeightConainertTonn * 1000)
                {
                    removeContainerFromShip(number);
                    Containers.Insert(i, container);
                }
                else
                {
                    Console.WriteLine("Error: The weight of added container is too big.");
                }
                
            }
            
        }
        
    }
    public override string ToString()
    {
        return "Our Ship can move with the maximum speed " + maxSpeed + " and maximum numbers of containers " +
               maxNumContainers
               + "it can transport maximum " + maxWeightConainertTonn + " tons ," + "now it has " + numberOfCont +
               " containers " + "and all their weight is  " + summWeight + " kg";

    }
}