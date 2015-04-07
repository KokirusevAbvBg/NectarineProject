namespace Mall.Interfaces
{
    using Mall.Staff;

    interface IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public Sex Gender { get; set; }
    }
}
