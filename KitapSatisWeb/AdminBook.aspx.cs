using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapSatisWeb
{
    public partial class AdminBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _bookService.GetAll().Data;
            GridView1.DataBind();
        }

        IBookService _bookService = new BookManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var bookId = Convert.ToInt32(e.CommandArgument);
            var booksToUpdate = _bookService.GetById(bookId).Data;

            tbx_UpdateId.Text = Convert.ToString(booksToUpdate.Id);
            tbx_UpdateCategoryId.Text = Convert.ToString(booksToUpdate.BookCategoryId);
            tbx_UpdateName.Text = booksToUpdate.Name;
            tbx_UpdateUnitPrice.Text = Convert.ToString(booksToUpdate.UnitPrice);
            tbx_UpdateUnitsInStock.Text = Convert.ToString(booksToUpdate.UnitsInStock);
            tbx_UpdateWriterName.Text = Convert.ToString(booksToUpdate.WriterName);

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var BookCategoryId = Convert.ToInt32(e.CommandArgument);
            var bookToDelete = _bookService.GetById(BookCategoryId).Data;

            Delete(bookToDelete);

            GetAll();
        }

        public void Delete(Book books)
        {
            _bookService.Delete(books);
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
            Book books = new Book();
            books.Id = Convert.ToInt32(tbx_UpdateId.Text);
            books.BookCategoryId = Convert.ToInt32(tbx_UpdateCategoryId.Text);
            books.Name = tbx_UpdateName.Text;
            books.UnitPrice = Convert.ToInt16(tbx_UpdateUnitPrice.Text);
            books.UnitsInStock = Convert.ToInt16(tbx_UpdateUnitsInStock.Text);

            _bookService.Update(books);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Book books = new Book();
            books.BookCategoryId = Convert.ToInt32(tbx_AddCategoryId.Text);
            books.Name = tbx_AddName.Text;
            books.UnitPrice = Convert.ToInt16(tbx_AddUnitPrice.Text);
            books.UnitsInStock = Convert.ToInt16(tbx_AddUnitsInStock.Text);

            _bookService.Add(books);
            GetAll();
        }
    }
}
