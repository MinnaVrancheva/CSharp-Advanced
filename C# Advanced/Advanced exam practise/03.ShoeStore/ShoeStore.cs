using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore
{
    public class ShoeStore
    {
        private List<Shoe> shoes;

        public ShoeStore(string name, int storageCapacity)
        {
            shoes = new List<Shoe>();
            Name = name;
            StorageCapacity = storageCapacity;
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get { return shoes; } }
        public int Count => shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (shoes.Count == StorageCapacity)
            {
                return $"No more space in the storage room.";
            }

            shoes.Add(shoe);

            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public List<Shoe> GetShoesByType(string type)
        {
            return shoes.Where(sho => sho.Type == type.ToLower()).ToList();
        }

        public int RemoveShoes(string material)
        {
            int count = shoes.Count;
            shoes.RemoveAll(sho => sho.Material == material);
            int differ = count - shoes.Count;
            return differ; 
        }

        public Shoe GetShoeBySize(double size)
        {
            return shoes.FirstOrDefault(sho => sho.Size == size);
        }

        public string StockList(double size, string type)
        { 
            var shoes = GetShoesByType(type).Where(sho => sho.Size == size);
            
            if (!shoes.Any())
            {
                return $"No matches found!";
            }
            else
            {
                return
                    $"Stock list for size {size} - {type} shoes:{Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, shoes)}";
            }
        }
    }
}
