using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_with_MVP_pattern.Models;
using CRUD_with_MVP_pattern.Views;
using CRUD_with_MVP_pattern._Repositories;
using System.Windows.Forms;

namespace CRUD_with_MVP_pattern.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
        }
        private void ShowPetsView(object sender,EventArgs e)
        {
            IPetView view = PetView.GetInstance((MainView)mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
        }
    }
}
