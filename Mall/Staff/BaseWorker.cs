namespace Mall.Staff
{
    using System;
    using Mall.SpaceHolder;
    using Mall.Basic;

    public class BaseWorker : Employee, IPerson, IEmployee, IPromote
    {
        //*************************************************************************** fields/Properties 
        private Uniform workUniform;
        private Floors operationFloor;

        public Uniform WorkUniform
        {
            get { return workUniform; }
            set { workUniform = value; }
        }

        public Floors OperationFloor
        {
            get { return operationFloor; }
            set { operationFloor = value; }
        }
        
        //*************************************************************************** Constructors
        public BaseWorker()
            : base()
        {
            this.WorkUniform = Uniform.No_uniform;
            this.OperationFloor = Floors.NotAsigned;
        }
        
        public BaseWorker(string name, byte age, Sex gender, decimal money, decimal salary, int workhours, int skill, Uniform uniform, Floors floor)
            : base(name, age, gender, money, salary, workhours,skill)
        {
            this.WorkUniform = uniform;
            this.OperationFloor = floor;
        }

        //*************************************************************************** Methods
        public override string ToString()
        {
            string employeeInfo = base.ToString();
            string baseWorkerInfo = employeeInfo + string.Format(@"
    Uniform: {0}
    Operation at: {1}",
                      this.WorkUniform, this.OperationFloor);
            return baseWorkerInfo;
        }
    }
}