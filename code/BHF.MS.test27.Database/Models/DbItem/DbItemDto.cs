using System.Text.Json.Serialization;

namespace BHF.MS.test27.Database.Models.DbItem
{
    public class DbItemDto : DbItemCreateDto
    {
        [JsonRequired]
        public Guid Id { get; set; }

        public DbItemDto()
        {
        }

        public DbItemDto(Context.Entities.DbItem dbItem) : base(dbItem)
        {
            Id = dbItem.Id;
        }
    }
}

