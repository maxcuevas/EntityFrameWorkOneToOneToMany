using EntityFrameWorkOneToOneToManyExample.Models;
using System.Linq;

namespace EntityFrameWorkOneToOneToManyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new Model1();

            var shirt1 = new shirt();
            shirt1.name = "teal";

            var shirt2 = new shirt();
            shirt2.name = "salmon";

            var outfit1 = new outfit();
            outfit1.name = "thursday";

            var outfitToShirt1 = new outfit_to_shirt();
            outfitToShirt1.shirt = shirt1;
            outfitToShirt1.outfit = outfit1;

            var outfitToShirt2 = new outfit_to_shirt();
            outfitToShirt2.shirt = shirt2;
            outfitToShirt2.outfit = outfit1;


            dbContext.outfit_to_shirt.Add(outfitToShirt1);
            dbContext.outfit_to_shirt.Add(outfitToShirt2);
            dbContext.SaveChanges();



            var shirt3 = new shirt();
            shirt3.name = "orange";

            var shirt4 = new shirt();
            shirt4.name = "blue";

            var outfit2 = new outfit();
            outfit2.name = "tuesday";

            var outfitToShirt3 = new outfit_to_shirt();
            outfitToShirt3.shirt = shirt3;
            outfitToShirt3.outfit = outfit2;

            var outfitToShirt4 = new outfit_to_shirt();
            outfitToShirt4.shirt = shirt4;
            outfitToShirt4.outfit = outfit2;

            dbContext.outfit_to_shirt.Add(outfitToShirt3);
            dbContext.outfit_to_shirt.Add(outfitToShirt4);
            dbContext.SaveChanges();


        }
    }
}
