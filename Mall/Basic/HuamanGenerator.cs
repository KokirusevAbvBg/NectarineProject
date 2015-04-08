namespace Mall.Basic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Mall.Staff;
    using Mall.Common;
    using Mall.Interfaces;

    public class HuamanGenerator
    {
        private static Random rand = new Random();

        public static Person PersonGenerator()
        {
            int genderRand = rand.Next(0, 2);
            int nameIndex = rand.Next(0, 100);
            Sex gender = Sex.NotAsigned;
            string name = "not-set";

            if (genderRand == 0)
            {
                gender = Sex.Male;
                name = Enum.GetName(typeof(MaleNames), nameIndex);
            }
            else
            {
                gender = Sex.Femele;
                name = Enum.GetName(typeof(MaleNames), nameIndex);
            }

            byte age = (byte)rand.Next(18, 56);
            decimal money = (decimal)rand.Next(100, 1000000);

            var randomPerson = new Person(name, age, gender, money);
            return randomPerson;
        }

        public static Employee EmployeeGenerator()
        {
            var person = PersonGenerator();
            int skill = rand.Next(10, 50);

            var randomEmployee = new Employee(person.Name, person.Age, person.Gender, person.personalBalance.ShowBalance(), 360, 4, skill);
            return randomEmployee;
        }

        public static BaseWorker BaseWorkerGenerator()
        {
            var employee = EmployeeGenerator();
            var randomBaseWorker = new BaseWorker(  employee.Name, 
                                                    employee.Age, 
                                                    employee.Gender, 
                                                    employee.personalBalance.ShowBalance(), 
                                                    employee.Salary, employee.Workhours, 
                                                    employee.Skill, 
                                                    Uniform.No_uniform, 
                                                    Floors.NotAsigned);
            return randomBaseWorker;

        }

        public static Cleaner CreateCleaner()
        {
            var randomBaseworker = BaseWorkerGenerator();
            var randomCleaner = new Cleaner(randomBaseworker.Name,
                                            randomBaseworker.Age,
                                            randomBaseworker.Gender,
                                            randomBaseworker.personalBalance.ShowBalance(),
                                            randomBaseworker.Salary,
                                            randomBaseworker.Workhours,
                                            randomBaseworker.Skill,
                                            Uniform.Cleaner_uniform,
                                            randomBaseworker.OperationFloor);
            return randomCleaner;
        }

        public static Security CreateSecurity()
        {
            var randomBaseworker = BaseWorkerGenerator();
            var randomSecurity = new Security(randomBaseworker.Name,
                                            randomBaseworker.Age,
                                            randomBaseworker.Gender,
                                            randomBaseworker.personalBalance.ShowBalance(),
                                            400,
                                            randomBaseworker.Workhours,
                                            randomBaseworker.Skill,
                                            Uniform.Security_uniform,
                                            randomBaseworker.OperationFloor);
            return randomSecurity;
        }

        public static Seller CreateSeller()
        {
            var randomBaseworker = BaseWorkerGenerator();
            var randomSeller = new Seller(randomBaseworker.Name,
                                            randomBaseworker.Age,
                                            randomBaseworker.Gender,
                                            randomBaseworker.personalBalance.ShowBalance(),
                                            600,
                                            6,
                                            randomBaseworker.Skill,
                                            Uniform.Seller_uniform,
                                            randomBaseworker.OperationFloor);
            return randomSeller;
        }

        public static Promoter CreatePromoter()
        {
            var randomBaseworker = BaseWorkerGenerator();
            var randomPromoter = new Promoter(randomBaseworker.Name,
                                            randomBaseworker.Age,
                                            randomBaseworker.Gender,
                                            randomBaseworker.personalBalance.ShowBalance(),
                                            500,
                                            4,
                                            randomBaseworker.Skill,
                                            Uniform.Promoter_uniform,
                                            randomBaseworker.OperationFloor);
            return randomPromoter;
        }

        public static ManagmentWorkers ManagerGenerator(ManagementType type)
        {
            var employee = EmployeeGenerator();
            var randomManager = new ManagmentWorkers(employee.Name,
                                                    employee.Age,
                                                    employee.Gender,
                                                    employee.personalBalance.ShowBalance(),
                                                    1200, 
                                                    8,
                                                    100,
                                                    Uniform.Formal_Suit,
                                                    type);
            return randomManager;
        }
    }
}
