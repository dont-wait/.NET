using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;
        //xài đâu new đấy

        //tạm thời hok có select tất cả User như bên Category
        //Category select hết để đổ vào combo, dropdown
        //BookRepo select hết để đổ vào grid

        //Ở đây ta select đúng email, pass, cái role thoả email và pass, hoặc là hok thấy
        public UserAccount? GetAccount(string email, string password)
        {
            _context = new();
            //_context.UserAccounts.Where(đưa vào hàm Lambda nhận vào 1 acc trả về True False) -> list user thoả đk nào đó
            //                     .Select(đưa vào lambda trả về) list acc
            //                      .FirstOrDefault(Lambda) trả về 1 dòng
            //                      hoặc null - hok tìm thấy theo tiêu chí lambda
            //return _context.UserAccounts.FirstOrDefault(delegate (UserAccount x)
            //{
            //    if (x.Email == email && x.Password == password);
            //    return false;
            //});
            //return _context.UserAccounts.FirstOrDefault(delegate (UserAccount x)
            //{
            //    return x.Email == email && x.Password == password;
            //});
            return _context.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

    }
}
