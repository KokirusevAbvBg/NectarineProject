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
        private Random rand = new Random();

        public BaseWorker BaseWorkerGenerator()
        {
            int genderRand = rand.Next(0, 2);
            int nameIndex = rand.Next(0, 100);
            Sex gender = Sex.NotAsigned;
            string name = "not-set";
            
            if (genderRand==0)
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

            int skill = rand.Next(10, 50);


            var randomBaseWorker = new BaseWorker(name, age, gender, money, 360, 4, skill,Uniform.No_uniform,Floors.NotAsigned);
            return randomBaseWorker;
        }
    }
}
