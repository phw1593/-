using OAManage.Command;
using OAManage.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OAManage.ViewModels
{
    public class AccountViewModel : INotifyPropertyChanged
    {

        //数据模型对象，ui无法直接访问
        private AccountModel _accountModel;

        public event PropertyChangedEventHandler? PropertyChanged;

        //账户属性，供前端绑定
        public string Account
        {
            get { return this._accountModel.Account; }
            set
            {
                _accountModel.Account = value;
                OnPropertyChanged();
            }
        }

        //密码属性，供前端绑定
        public string Pwd
        {
            get { return this._accountModel.Pwd; }
            set
            {
                _accountModel.Pwd = value;
                OnPropertyChanged();

            }
        }
        public ICommand ClickCommand { get; }
        public AccountViewModel()
        {
            this._accountModel = new AccountModel();
            this.ClickCommand = new DoCommand(Login);

        }


        private void Login()
        {
            if (this.Account == "abc" && this.Pwd == "123")
            {
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("登录失败");
                this.Account = "";
                this.Pwd = "";
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

    }
}
