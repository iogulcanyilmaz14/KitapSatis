using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_BookCategories.Text = Convert.ToString(BookCategoriesCount());
            lbl_Customers.Text = Convert.ToString(CustomersCount());
            lbl_BookOrders.Text = Convert.ToString(BookOrdersCount());
            lbl_Books.Text = Convert.ToString(BooksCount());
        }

        IBookCategoryService _bookCategoryService = new BookCategoryManager();
        IBookOrderService _bookOrderService = new BookOrderManager();
        ICustomerService _customerService = new CustomerManager();
        IBookService _bookService = new BookManager();


        // Persents
        public double BooksPersent()
        {
            double result = _bookService.GetAll().Data.Count / 10.0;
            return result;
        }

        public double BookOrdersPersent()
        {
            double result = _bookOrderService.GetAll().Data.Count / 10.0;
            return result;
        }
        public double BookCategoriesPersent()
        {
            double result = _bookCategoryService.GetAll().Data.Count / 10.0;
            return result;
        }
        public double CustomersPersent()
        {
            double result = _customerService.GetAll().Data.Count / 10.0;
            return result;
        }

        // Counts

        public int BookCategoriesCount()
        {
            return _bookCategoryService.GetAll().Data.Count;
        }

        public int BooksCount()
        {
            return _bookService.GetAll().Data.Count;
        }

        public int CustomersCount()
        {
            return _customerService.GetAll().Data.Count;
        }

        public int BookOrdersCount()
        {
            return _bookOrderService.GetAll().Data.Count;
        }


        // GetAlls
        public List<Book> BooksGetAll()
        {
            return _bookService.GetAll().Data;
        }
        public List<BookCategory> BookCategoriesGetAll()
        {
            return _bookCategoryService.GetAll().Data;
        }

        //public int UsersGetAll()
        //{
        //   return _userService.GetAll().Data.Count;
        //}

        //public int CustomersGetAll()
        //{
        //   return _customerService.GetAll().Data.Count;
        //}




    }
}
