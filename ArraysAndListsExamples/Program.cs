namespace ArraysAndListsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays and Lists are collections of different data types
            //Arrays have a size that cannot change at creation
            int[] numbers = new int[] { 32, 4, 50 };
            //could just start it with var instead of int[]
            //can place the size of the index in the [], but you don't have to
            //example - var numbers = new int[4] {4, 3, 2, 1};
            //arrays start at index 0, so the 5th spot on the index will be 4 on the index

            Console.WriteLine(numbers.Length); //This will print out the size of the index of your array

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers[0] = 100;//accessing the first spot in the index and changing it to 100
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Lists
            //Lists have a size that can change all you want
            List<int>listNumbers = new List<int>() { 20, 100, 22, 4}; //can say var again in ths example to start it off

            listNumbers.Add(1000); //1000 will be added after 4
            listNumbers.Remove(20);//removes 20 from the 0 spot

            foreach(var number in listNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(listNumbers.Count); //Tells you how many spots are in the list = its size

            var names = new string[] { "John", "Amy", "Smith" };


            Console.WriteLine(names[0]);

            var students = new List<string>() { };

            students.Add("Mack");
            students.Add("Cali");
            foreach(var name in students)
            {
                Console.WriteLine(name);
            }

            //var arrayStudents = students.ToArray(); will make a copy of students and convert it to an array
            //ToList will convert it to a list

        }
    }
}