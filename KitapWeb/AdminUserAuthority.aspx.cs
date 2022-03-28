using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb
{
    public partial class AdminUserAuthority : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _userAuthorityService.GetAll().Data;
            GridView1.DataBind();
        }

        IUserAuthorityService _userAuthorityService = new UserAuthorityManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var UserAuthorityId = Convert.ToInt32(e.CommandArgument);
            var UserAuthorityToUpdate = _userAuthorityService.GetById(UserAuthorityId).Data;

            tbx_UpdateId.Text = Convert.ToString(UserAuthorityToUpdate.Id);
            tbx_UpdateUserId.Text = Convert.ToString(UserAuthorityToUpdate.UserId);
            tbx_UpdateAuthorityId.Text = Convert.ToString(UserAuthorityToUpdate.AuthorityId);

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var UserAuthorityId = Convert.ToInt32(e.CommandArgument);
            var UserAuthorityToDelete = _userAuthorityService.GetById(UserAuthorityId).Data;

            Delete(UserAuthorityToDelete);

            GetAll();
        }

        public void Delete(UserAuthority userAuthority)
        {
            _userAuthorityService.Delete(userAuthority);
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            UserAuthority userAuthority = new UserAuthority();
            userAuthority.Id = Convert.ToInt32(tbx_UpdateId.Text);
            userAuthority.UserId = Convert.ToInt32(tbx_UpdateUserId.Text);
            userAuthority.AuthorityId = Convert.ToInt32(tbx_UpdateAuthorityId.Text);

            _userAuthorityService.Update(userAuthority);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            UserAuthority userAuthority = new UserAuthority();

            userAuthority.UserId = Convert.ToInt32(tbx_AddUserId.Text);
            userAuthority.AuthorityId = Convert.ToInt32(tbx_AddAuthorityId.Text);

            _userAuthorityService.Add(userAuthority);
            GetAll();
        }

    }
}