namespace ContainerApplication;

public class LiquidContainer:Container,IHazardNotifier

{
    private bool isHazard;
    public LiquidContainer(double heightCm, double massContainerKg, double depthCm, double maxPayload, bool isHazard) : base(heightCm, massContainerKg, depthCm, maxPayload)
    {
        this.isHazard = isHazard;
        typeOfContainer = "L";
        this.serialNumber = funTypeOfContainer();
       
       
    }

    public override void loadContainer(double kg)
    {
        if (isHazard && kg+massCargoKg>0.5*maxPayload)
        {
            Console.WriteLine("It is dangerous.Only half of maximum Payload can be filled. ");
        }
        else if(isHazard)
        {
            massCargoKg += kg;
        }
        else if (!isHazard && kg+massCargoKg>0.9*maxPayload)
        {
            Console.WriteLine("It is dangerous.Only 0.9 of maximum Payload can be filled. ");
        }
        else
        {
            massCargoKg += kg;
        }
    }

    public void text_notification()
    {
        Console.WriteLine("This container contains dangerous liquids! "+serialNumber);
    }
    
    
    public override string ToString()
    {
        string info = "";
        if (isHazard)
        {
            info += "It is Hazard liquid";
        }
        else
        {
            info += "It is not Hazard liquid";
        }
        return "Container of the type  :" + typeOfContainer + " with the serial number " + serialNumber +
               ". The height of the container: " + heightCm + " with the mass " +
               +massCargoKg + " and depth " + depthCm + ". The maxPayload of this container is " + maxPayload +
               " and now the container contains " + massCargoKg  + info;
    }
}