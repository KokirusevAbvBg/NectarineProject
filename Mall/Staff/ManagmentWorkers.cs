namespace Mall.Staff
{
    class ManagmentWorkers : Employee, IPerson, IEmployee, IPromote
    {
        //*************************************************************************** fields/Properties
        private Uniform workUniform;
        private ManagementType position;
        
        public Uniform WorkUniform
        {
            get { return workUniform; }
            set { workUniform = value; }
        }

        public ManagementType Position
        {
            get { return position; }
            set { position = value; }
        }

        //*************************************************************************** Constructors
        public ManagmentWorkers()
            : base()
        {
            this.WorkUniform = Uniform.Semiformal_Suit;
            this.Position = ManagementType.No_Position;
        }

        public ManagmentWorkers(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform, ManagementType position)
            : base(name, age, gender, money, salary, workhours,skill)
        {
            this.WorkUniform = uniform;
            this.Position = position;
        }
        
        //*************************************************************************** Methods

        public override void SmallPromotion()
        {
            this.Salary += 500;
            this.Skill += 30;
        }

        public override void BigPromotion()
        {
            this.Salary += 1500;
            this.Skill += 120;
        }

        public override void Discipline()
        {
            this.personalBalance.Pay(400);
            this.Skill += 10;
        }
        
        public override string ToString()
        {
            string employeeInfo = base.ToString();
            string managmentWorkerInfo = employeeInfo + string.Format(@"
    Uniform: {0}
    Position: {1}",
                      this.WorkUniform, this.Position);
            return managmentWorkerInfo;
        }
    }
}
