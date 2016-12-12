using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDeGroupingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDeGroupingList.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public List<TUser> Users { get; } = new List<TUser>
        {
            new TUser
            {
                ID = 0, Name = "あ", Kana = "ア", Address = "大分市",
                Birthday = DateTime.Parse("1974/01/01")
            },
            new TUser
            {
                ID = 0, Name = "い", Kana = "イ", Address = "別府市",
                Birthday = DateTime.Parse("1974/02/02")
            },
            new TUser
            {
                ID = 0, Name = "う", Kana = "ウ", Address = "中津市",
                Birthday = DateTime.Parse("1975/01/01")
            },
            new TUser
            {
                ID = 0, Name = "え", Kana = "エ", Address = "別府市",
                Birthday = DateTime.Parse("1976/01/01")
            },
            new TUser
            {
                ID = 0, Name = "お", Kana = "オ", Address = "日田市",
                Birthday = DateTime.Parse("1975/03/03")
            },
            new TUser
            {
                ID = 0, Name = "か", Kana = "カ", Address = "大分市",
                Birthday = DateTime.Parse("1973/05/05")
            },
            new TUser
            {
                ID = 0, Name = "き", Kana = "キ", Address = "大分市",
                Birthday = DateTime.Parse("1977/06/06")
            },
        };


        private bool _dataType;
        public bool DisplayType
        {
            get { return _dataType; }
            set { SetProperty(ref _dataType, value); }
        }


        public List<IGrouping<string, TUser>> GroupingUsersByAddress
        {
            get { return Users.GroupBy(user => user.Address).ToList(); }
        }

        public List<IGrouping<int, TUser>> GroupingUsersByAge
        {
            get { return Users.GroupBy(user => user.Age).ToList(); }
        }


        public MainPageViewModel()
        {
            DisplayType = false;
        }

    }
}
