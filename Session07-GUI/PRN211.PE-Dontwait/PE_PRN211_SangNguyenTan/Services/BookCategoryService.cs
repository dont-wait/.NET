using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        //CUNG CẤP DATA CHO FORM, THỰC RA CUNG CẤP DATA CHO CÁI DROPDOW, BẤM XỔ, COMBO BOX
        //LẺ RA PHẢI LẤY TẤT CẢ CATEGORY TỪ DATABASE - NHƯNG TẠM THỜI HARD-CODE, ĐỂ MAI TÍNH
        private BookCategoryRepository _repo = new();
        //new ngay đây luôn không sợ phần db do mỗi hàm bên trong repo đã tự new cái dbcontext rồi
        

        //DbContext new 1 lần rồi CRUD dễ bị loạn ram
        public List<BookCategory> GetAllCategories()
        {
            //gọi repo lấy tất cả Categories
            return _repo.GetBookCategories().ToList();
                        
        }
    }
    

    
}
