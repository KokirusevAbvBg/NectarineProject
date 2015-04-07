namespace Mall.Interfaces
{
    using Mall.Staff;
    using Mall.Common;

    interface IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public Sex Gender { get; set; }
    }
}
