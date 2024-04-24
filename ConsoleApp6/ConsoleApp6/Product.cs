using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    [Serializable]
    public class Product : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id", Id,typeof(Product));
            info.AddValue("name", Name, typeof(Product));
            info.AddValue("description", Description, typeof(Product));
        }
    }
}
