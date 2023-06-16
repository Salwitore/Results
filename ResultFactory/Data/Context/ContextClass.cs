using Data.Model;

namespace Data.Context
{
    public class StaticDB
    {
        public List<User> Database { get; set; } = new List<User>();

        public StaticDB()
        {
            Database.Add(new User()
            {
                Id = 1,
                Email = "Test1",
                Name = "Test1",
                Password = "Test1",
            });
            Database.Add(new User()
            {
                Id = 2,
                Email = "Test2",
                Name = "Test2",
                Password = "Test2",
            });
            Database.Add(new User()
            {
                Id = 3,
                Email = "Test3",
                Name = "Test3",
                Password = "Test3",
            });
        }
    }
}
