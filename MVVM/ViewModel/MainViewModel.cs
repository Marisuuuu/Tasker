using Tasker.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.MVVM.ViewModel
{
    public class MainViewModel
    {
        
        public ObservableCollection<Category> Categories {  get; set; }
        public ObservableCollection<MyTask> Task { get; set; }


        public MainViewModel() 
        {
            FillData();
        }

        private void FillData()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Id = 1,
                    CategoryName = "Six Seven!!",
                    Color = "#cf14df"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Amogus",
                    Color = "#cf14df"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Nine Eleven!",
                    Color = "#cf14df"
                },
            };

            Task = new ObservableCollection<MyTask> 
            {
                new MyTask
                {
                    TaskName = "Do the thing!",
                    Completed = false,
                    CategoryID = 1,
                },
                new MyTask
                {
                    TaskName = "You are too old!",
                    Completed = false,
                    CategoryID = 1,
                },
                new MyTask
                {
                    TaskName = "For this!",
                    Completed = false,
                    CategoryID = 1,
                },
            };
        }

    }
}
