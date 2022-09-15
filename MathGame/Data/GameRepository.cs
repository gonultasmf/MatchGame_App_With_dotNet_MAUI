using MathGame.Models;
using SQLite;

namespace MathGame.Data;

public class GameRepository
{
    string _path;
    private SQLiteConnection _connection;

    public GameRepository(string path)
    {
        _path = path;
    }

    public void Init()
    {
        _connection = new SQLiteConnection(_path);
        _connection.CreateTable<Game>();
    }

    public List<Game> GetAllGames()
    {
        Init();
        return _connection.Table<Game>().ToList();
    }

    public void Add(Game game)
    {
        _connection = new SQLiteConnection(_path);
        _connection.Insert(game);
    }

    public void Delete(int id)
    {
        _connection = new SQLiteConnection(_path);
        _connection.Delete(new Game { Id = id });
    }
}
