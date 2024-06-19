namespace Srs6.DB
{
    class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Teacher> teachers { get; set; }
    }
}
