using System;
using JwtBasics.Models;

namespace JwtBasics.Repository.IRepository
{
    public interface ITeamRepository
    {
        ICollection<Team> getTeamMembers();
        User Authenticate(string username, string password);
    }
}

