using Dapper;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class UserServise
{
    private readonly DataContext _dataContext;
    public UserServise()=> _dataContext = new DataContext();

    public string AddUser(User user)
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = $"insert into users(name, email) values('{user.Name}', '{user.Email}')";
            var response = connection.Execute(sql);
            if (response == 1)
            {
                return "User added!";
            }
            return "Error";
        }
    }
    public string UpdateUser(User user)
    {
        using(var connection = _dataContext.CreateConnection())
        {
            var sql = $"update users set name = '{user.Name}', email = '{user.Email}' where id = {user.Id}'";
            var response = connection.Execute(sql);
            if (response == 1)
            {
                return "User added!";
            }
            return "Error";
        }
    }
    public string DeleteUser(int id)
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = $"delete users where id = {id}";
            var response = connection.Execute(sql);
            if (response == 1)
            {
                return "User deleted!";
            }
            return "Error";
        }
    }
    public List<User> GetUsers()
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = "select * from users";
            var response = connection.Query<User>(sql);
            return response.ToList();
        }
    }
    public User GetUserById(int id)
    {
        using (var connection = _dataContext.CreateConnection())
        {
            var sql = $"select * from users where id = {id}";
            var response = connection.QueryFirstOrDefault(sql);
            return response;
        }
    }

    public User GetUser(int id)
    {
        throw new NotImplementedException();
    }

}
