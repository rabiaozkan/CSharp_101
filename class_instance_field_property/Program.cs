namespace class_instance_field_property;
class Program
{
    static void Main(string[] args)
    {

           // Syntax
        // Class ClassName
        //{
        //    [Access Modifiers]    [Data Type] PropertyName:
        //    [Access Modifiers]    [Return Type] MethodsName ([List of parameters])
        //    {
        //        // Operations
        //    }

        //Access Modifiers
        // * Public
        // * Private
        // * Internal
        // * Protected




        Employee employeeOne = new Employee();
        employeeOne.Name = "Rabia";
        employeeOne.LastName = "Ozkan";
        employeeOne.No = 123456;
        employeeOne.Department = "IT";

        employeeOne.GetEmployeeInfo();
        
        Console.WriteLine("************");

        Employee employeeTwo = new Employee();
        employeeTwo.Name = "XXX";
        employeeTwo.LastName = "YYY";
        employeeTwo.No = 112233;
        employeeTwo.Department = "HR";

        employeeTwo.GetEmployeeInfo();
       
    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}",Name);
            Console.WriteLine("Last Name of the employee: {0}",LastName);
            Console.WriteLine("Id of the employee: {0}",No);
            Console.WriteLine("Department of the employee: {0}",Department);
        }
    }
}