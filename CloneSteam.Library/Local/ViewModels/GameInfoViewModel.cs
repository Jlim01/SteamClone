using CloneSteam.Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Controls;

namespace CloneSteam.Library.Local.ViewModels
{

    public partial class GameInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        string? settingToolTiptxt;
        [ObservableProperty]
        string? infoToolTiptxt;
        [ObservableProperty]
        string? bookmarkToolTiptxt;
        [ObservableProperty]
        private GameInfo currentGameInfo;



        public GameInfoViewModel()
        {
            SettingToolTiptxt = getSettingToolTip();
            InfoToolTiptxt = getInfoToolTip();
            BookmarkToolTiptxt = getBookmarkToolTip();
        }


        private string getSettingToolTip()
        {
            return "관리";
        }
        private string getInfoToolTip()
        {
            return "정보 자세히 보기";
        }

        private string getBookmarkToolTip()
        {
            return "즐겨찾기에 추가";
        }
        #region Command
        [RelayCommand]
        private void SettingBtn()
        {
            MessageBox.Show("SettingBtn Check");
        }

        [RelayCommand]
        private void InfoBtn()
        {
            MessageBox.Show("InfoBtnCommand Check");
        }
        [RelayCommand]
        private void BookmarkBtn()
        {
            MessageBox.Show("BookmarkBtnCommand Check");
        }
        [RelayCommand]
        void ShowPage()
        {
            MessageBox.Show("ShowPage Command Check");
        }
        [RelayCommand]
        void Cummunityhub()
        {
            MessageBox.Show("CummunityhubCommand Check");
        }
        [RelayCommand]
        void Debate()
        {
            MessageBox.Show("DebateCommand Check");
        }
        [RelayCommand]
        void Guide()
        {
            MessageBox.Show("GuideCommand Check");
        }
        [RelayCommand]
        void Support()
        {
            MessageBox.Show("SupportCommand Check");
        }
        #endregion


    }
}
