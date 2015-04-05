namespace Mall.Staff
{
    using System;
    using Mall.Basic;

    public class Person:IPerson
    {
        //*************************************************************************** fields/Properties  
        private string name;
        private byte age;
        private Sex gender;
        public BankBalnce personalBalance;

        public string Name
        {
            get
            {
                return this.name;              
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Employee name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value; //0-255 must throw defaut exception for byte
            }
        }

        public Sex Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value == Sex.NotAsigned||
                    value == Sex.Male ||
                    value == Sex.Femele)
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Not corect gender entry!");
                }
            }
        }

        //*************************************************************************** Constructors
        public Person()
        {
            this.Name = "no-name";
            this.Age = 0;
            this.Gender = Sex.NotAsigned;
            this.personalBalance = new BankBalnce();
        }

        public Person(string name, byte age, Sex genderInput, decimal money)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = genderInput;
            this.personalBalance = new BankBalnce(money);
        }

        //*************************************************************************** Methods
        public override string ToString()
        {
            string personalInfo = String.Format(@"
    Name: {0}
    Age: {1}
    Gender: {2}
    Balance: {3}",
                 this.Name, this.Age, this.Gender, this.personalBalance.ShowBalance());
            return personalInfo;
        }
    }
}
