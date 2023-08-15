using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.ViewModels
{
	public class ViewModel
	{
		public ObservableCollection<StatusDataModel> statusThumbsCollection; 

		public ViewModel()
		{
			statusThumbsCollection = new ObservableCollection<StatusDataModel>()
			{

                new StatusDataModel
                {
                    IsMeAddStatus=true
                },

                new StatusDataModel
				{
					ContactName="Mike",
					ContactPhoto= new Uri("/assets/1.png", UriKind.RelativeOrAbsolute),
					StatusImage= new Uri("/assets/5.jpg", UriKind.RelativeOrAbsolute),
					IsMeAddStatus=false
				},

                 new StatusDataModel
                {
                    ContactName="Steve",
                    ContactPhoto= new Uri("/assets/2.jpg", UriKind.RelativeOrAbsolute),
                    StatusImage= new Uri("/assets/8.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus=false
                },

                 new StatusDataModel
                {
                    ContactName="Will",
                    ContactPhoto= new Uri("/assets/3.png", UriKind.RelativeOrAbsolute),
                    StatusImage= new Uri("/assets/5.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus=false
                },

            };
		}
	}
}
