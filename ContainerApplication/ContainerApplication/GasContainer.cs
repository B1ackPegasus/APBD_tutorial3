using System.Diagnostics;

namespace ContainerApplication;
public class GasContainer:Container,IHazardNotifier
{
    public  double presure;
    
    public GasContainer(double heightCm, double massContainerKg, double depthCm, double maxPayload,double presure) : base(heightCm, massContainerKg, depthCm, maxPayload)
    {
        this.presure = presure;
        typeOfContainer = "G";
        this.serialNumber = funTypeOfContainer();
    }

    public override void emptyingCargo()
    {
        massCargoKg *= 0.05;
    }

    public void text_notification()
    {
        Console.WriteLine("A hazardous event occured in gas container " + serialNumber);
    }
    public override string ToString()
    {
        return "Container of the type  :" + typeOfContainer + " with the serial number " + serialNumber +
               ". The height of the container: " + heightCm + " with the mass " +
               +massCargoKg + " and depth " + depthCm + ". The maxPayload of this container is " + maxPayload +
               " and now the container contains " + massCargoKg + "Presuare: "+presure;
    }
}

