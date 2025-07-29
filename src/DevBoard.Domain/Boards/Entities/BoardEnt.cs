using DevBoard.Domain.User.Entities;
using DevBoard.Domain.Shared;

namespace DevBoard.Domain.Boards.Entities
{
    public class BoardEnt : BaseEnt
    {
        public BoardEnt(string name)
        {
            Name = name.ToLower();

        }
        public string Name { get; set; }

        public Guid? UserId { get; set; }
        public UserEnt? User { get; set; }

    }
}
