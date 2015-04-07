namespace Mall.Intefaces
{
    using Mall.Basic;

    interface IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public Sex Gender { get; set; }
    }
}
