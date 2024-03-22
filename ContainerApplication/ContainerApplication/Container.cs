namespace ContainerApplication;

public class Container
{
     public static int Container_number = 0;
     public string typeOfContainer;
     public double massCargoKg;
     public double heightCm;
     public double massContainerKg;
     public double depthCm;
     public string serialNumber="KON";
     public double maxPayload;

     public Container(double heightCm, double massContainerKg, double depthCm, double maxPayload)
     {
          massCargoKg = 0;
          this.heightCm = heightCm;
          this.massContainerKg = massContainerKg;
          this.depthCm = depthCm;
          this.maxPayload = maxPayload;
     }

     public int generateNumber()
     {
          Container_number += 1;
          return Container_number;
     }

     public string funTypeOfContainer()
     {
          string serialNumberOfCont = serialNumber + "-" + typeOfContainer + "-" + generateNumber();
          return serialNumberOfCont;
     }

     public virtual void emptyingCargo()
     {
         massCargoKg = 0;
     }

     public virtual void loadContainer(double kg)
     {
          if (kg+massCargoKg<maxPayload)
          {
               massCargoKg +=kg;
          }
          else
          {
               massCargoKg +=kg;
               throw new OverfillException("Impossible.Cargo weight is bigger than maximum capacity");
          }
          
          
     }

     public override string ToString()
     {
          return "Container of the type  :" + typeOfContainer + " with the serial number " + serialNumber +
                 ". The height of the container: " + heightCm + " with the mass " +
                 +massCargoKg + " and depth " + depthCm + ". The maxPayload of this container is " + maxPayload +
                 " and now the container contains " + massCargoKg;
     }
}