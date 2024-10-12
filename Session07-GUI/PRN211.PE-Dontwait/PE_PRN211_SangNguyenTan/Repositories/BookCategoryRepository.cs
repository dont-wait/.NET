using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepository
    {
        //lại vẫn phải mượn tay của dbcontext để giúp xuống database
        private BookManagementDbContext _context;

        //lấy tất cả BookCategory - hiện có 5 dòng để đổ vào dropdow/combobox bên form Detail
        public List<BookCategory> GetBookCategories() {
            _context = new();
            return _context.BookCategories.ToList();
        }

    }
}
