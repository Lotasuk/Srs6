namespace Srs6.DB
{
    class Teacher {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public int age { get; set; }
        public int? roleId {  get; set; }
        public virtual Role Role { get; set; }
       

    }
}
