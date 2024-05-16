using DesignPatternApp.Repository.Entities;

namespace DesignPatternApp.Infrastructure
{
    public sealed class LocalStorage
    {
        public List<Employee> employees = new List<Employee>();
        private static LocalStorage? instance = null;
        private LocalStorage() { }
        public static LocalStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LocalStorage();
                }
                return instance;
            }
        }
    }
}