namespace  ContainerApplication;

public class RefrigeratedContainer:Container
{
    public Products product;
    public double temperature;
    public RefrigeratedContainer(double heightCm, double massContainerKg, double depthCm, double maxPayload,Products product,double temp) : base(heightCm, massContainerKg, depthCm, maxPayload)
    {
        this.product = product;
        temperature = temp;
        if (((int)this.product)/10.0 > temperature)
        {
            throw new ArgumentException("Temperature inside container is lower than the temperature required by a given type of product ");
        }
        typeOfContainer = "C";
        this.serialNumber = funTypeOfContainer();
    }
    public override string ToString()
    {
        return "Container of the type  :" + typeOfContainer + " with the serial number " + serialNumber +
               ". The height of the container: " + heightCm + " with the mass " +
               +massCargoKg + " and depth " + depthCm + ". The maxPayload of this container is " + maxPayload +
               " and now the container contains " + massCargoKg + "Products inside: "+product +"saved with the temperature "+temperature ;
    }
}