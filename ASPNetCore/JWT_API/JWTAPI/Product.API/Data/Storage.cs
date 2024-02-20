namespace Product.API.Data
{
    public class Storage
    {
        private static readonly List<Models.Product> Data = new List<Models.Product>();

        public static List<Models.Product> GetAll() { return Data; }

        public static bool Create(Models.Product model)
        {
            if (Data.Any(c => c.Id == model.Id || c.Name == model.Name)) { return false; }

            Data.Add(new Models.Product
            {
                Id = model.Id,
                Name = model.Name
            });
            return true;
        }

        public static bool Delete(int id) 
        { 
            if (Data.All(c => c.Id != id)) {  return false; }

            Data.Remove(Storage.Data.First(c => c.Id == id));
            return true;
        }

        public static bool Update(Models.Product model)
        {
            if (Data.All(c => c.Id !=  model.Id)) { return false; }

            Data.First(c => c.Id == model.Id).Name = model.Name;
            return true;
        }
    }
}
