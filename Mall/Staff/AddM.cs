
namespace Mall.Staff
{
    using Mall.Common;
    using Mall.Goods;

    public class AddM : ManagmentWorkers
    {

        public AddM(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform)
            : base(name, age, gender, money, salary, workhours, skill, uniform, ManagementType.Advertising)
        {

        }

        public void MakeDiscount(string name, decimal percent, SpaceHolder shop)
        {
            var maches = shop.FindAll(empl => ((empl.WorkUniform == uniform) && (empl.Name == name) && (empl.Age == age)));

            foreach (var item in maches)
            {
                this.Staff.Remove(item);
                Console.WriteLine("Employee {0} who is {1} age old is fired!", name, age);
            }
        }
    }
}
