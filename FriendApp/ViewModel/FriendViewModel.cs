using FriendApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FriendApp.ViewModel
{
   public class FriendViewModel
    {
        #region Atributo

        #endregion
        #region Constructor
        public FriendViewModel() {

        }
        #endregion
        #region Propiedades
        public Command SaveCommand { set; get; }
        public Command DeleteCommand { set; get; }
        public Boolean IsEnable { set; get; }
        public Friend FriendModel { set; get; }
        #endregion

    }
}
