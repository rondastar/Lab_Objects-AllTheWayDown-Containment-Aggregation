using System.Runtime.InteropServices;

namespace Lab_Objects_AllTheWayDown_Containment_Aggregation
{
    // Ronda Rutherford
    // May 1, 2023
    // Lab - Objects All The Way Down
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a new instance of Eyewear Department
            EyewearDepartment department = new EyewearDepartment();

            // create frames
            Frames frames = new Frames("tortoise shell", 6, "Kate Spade");

            // create lenses
            Lenses lenses = new Lenses(null, "black");

            // create sunglasses and pass in frames and lenses
            Sunglasses sunglasses = new Sunglasses(Sunglasses.BestUse.fashion, Sunglasses.InterchangeableLenses.no, (decimal)359.99, frames, lenses);

            // add the sunglasses to the department inventory - containment
            department.AddSunglasses(sunglasses);

            //Access lens and frames type of the first sunglasses in the department inventory
            Sunglasses exampleSunglasses = department.InventorySunglasses[0]; // first sunglasses
            Lenses exampleSunglassesLenses = exampleSunglasses.Lenses;
            Frames exampleSunglassesFrames = exampleSunglasses.Frames;


            // Prints the color of the frames and lenses of the first sunglasses in the inventory
            Console.WriteLine(exampleSunglassesFrames.Color);
            Console.WriteLine(exampleSunglassesLenses.Color);
        } // Main
    } // class
} // namespace