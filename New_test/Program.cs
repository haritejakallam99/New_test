


//float numberFloat = 123.45678f;

//{
//    Console.WriteLine(numberFloat);

//}


////ARRAYS

//string[] veg = new string[4] { "tomto", "carrote", "beans", "cabbage" };
//foreach (var vegitable in veg)
//{
//    Console.WriteLine(vegitable);
//}

//double[] dub = new double[4] { 23323.4567890, 2334123.54656456546, 232412.0475844, 244123.324354645645 };
//foreach (var dubable in dub)
//{
//    Console.WriteLine(dubable);
//}

//dictionary

Dictionary<int, string> valuepairs = new Dictionary<int, string>();

valuepairs.Add(0, "tomato");
valuepairs.Add(1, "carrot");
valuepairs.Add(2, "beans");

foreach (var item in valuepairs)
{
    Console.WriteLine($"number:{item.Key},veggies:{item.Value}");
}

//Dictionary<string, float> values = new Dictionary<string, float>();
//values.Add("teja", 12.3f);
//values.Add("sai", 14.2f);
//values.Add("lalitha", 26.12f);

//foreach (var key in values)
//{
//    Console.WriteLine($"name:{key.Key},number:{key.Value}");
//}

//LISTS

List<int> sampleList= new List<int>();
sampleList.Add(1);
sampleList.Add(1);
sampleList.Add(3);
sampleList.Add(2);

foreach(var item in sampleList)
{
    Console.WriteLine(item);

}

//public class Employee
//{
//    public int EmpId { get; set; }   
//    public string FirstName { get; set; }   
//    public string LastName { get; set; } 
//    public  DateTime Doj { get; set; }
//    public double Salary { get; set; }

//}
////List<Employee> employee1 = new List<Employee>();

//    employee1.Add(new Employee { EmpId = 1, FirstName = "hari", LastName = "teja", Doj = DateTime.Now, Salary = 2000.22 });
//    employee1.Add(new Employee { EmpId = 2, FirstName = "sai", LastName = "krishna", Doj = DateTime.Now, Salary = 3000.22 });
//    employee1.Add(new Employee { EmpId = 3, FirstName = "haritha", LastName = "kasa", Doj = DateTime.Now, Salary = 8000.22 });
//foreach(var item in employee1)  
//    { 
//    Console.WriteLine(item); 
//}






