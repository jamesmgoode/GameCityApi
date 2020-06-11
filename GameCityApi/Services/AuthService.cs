using GameCityApi.Models;
using GameCityApi.Services.Interfaces;
using Google.Apis.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameCityApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly static IList<User> _users = new List<User>();

        public AuthService()
        {
            Refresh();
        }

        public async Task<User> Authenticate(Google.Apis.Auth.GoogleJsonWebSignature.Payload payload)
        {
            await Task.Delay(1);

            return this.FindUserOrAdd(payload);
        }

        Task<User> IAuthService.Authenticate(GoogleJsonWebSignature.Payload payload)
        {
            throw new NotImplementedException();
        }

        private User FindUserOrAdd(Google.Apis.Auth.GoogleJsonWebSignature.Payload payload)
        {
            var u = _users.Where(x => x.Email == payload.Email).FirstOrDefault();

            if (u == null)
            {
                u = new User()
                {
                    Id = Guid.NewGuid(),
                    Name = payload.Name,
                    Email = payload.Email,
                    OAuthSubject = payload.Subject,
                    OAuthIssuer = payload.Issuer
                };
                _users.Add(u);
            }

            PrintUsers();

            return u;
        }

        private void PrintUsers()
        {
            string s = String.Empty;

            foreach (var u in _users) s += "\n[" + u.Email + "]";
        }

        private void Refresh()
        {
            if (_users.Count == 0)
            {
                _users.Add(new User() { Id = Guid.NewGuid(), Name = "Test Person1", Email = "testperson1@gmail.com" });
                _users.Add(new User() { Id = Guid.NewGuid(), Name = "Test Person2", Email = "testperson2@gmail.com" });
                _users.Add(new User() { Id = Guid.NewGuid(), Name = "Test Person3", Email = "testperson3@gmail.com" });

                PrintUsers();
            }
        }
    }
}
