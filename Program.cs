class Program
{
    static void Main()
    {
        var stringVectors = new List<string>();
        string? stringVector;
        var vectors = new List<Vector>();

        do
        {
            Console.Write("Please enter a vector (Magnitude Direction): ");
            stringVector = Console.ReadLine();
            if (stringVector != "")
            {
                stringVectors.Add(stringVector);
            }

        } while (stringVector != "");

        foreach (string vec in stringVectors)
        {
            string[] splitVector = vec.Split(" ");

            if (2 == splitVector.Length)
            {
                double magnitude = Convert.ToDouble(splitVector[0]);
                double direction = Convert.ToDouble(splitVector[1]);

                vectors.Add(new Vector(magnitude, direction));
            }
        }

        VectorAdder vectorAdder = new VectorAdder(vectors);
        Vector resultant = vectorAdder.Add();
        resultant.Display();
    }
}