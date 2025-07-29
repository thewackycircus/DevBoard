using DevBoard.Domain.Boards.Entities;

namespace DevBoard.Application.Boards.Interfaces
{
    public interface IBoardService
    {
        Task<BoardEnt> CreateBoardAsync(string name);
    }
}
