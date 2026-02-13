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
                    Color = "#c0df"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Nine Eleven!",
                    Color = "#2214ff"
                },
            };

            Task = new ObservableCollection<MyTask> 
            {
                new MyTask
                {
                    TaskName = "Do the thing!",
                    Completed = true,
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
                    Completed = true,
                    CategoryID = 1,
                },
                new MyTask
                {
                    TaskName = "Sus!",
                    Completed = false,
                    CategoryID = 2,
                },
                new MyTask
                {
                    TaskName = "Sussy Baka!",
                    Completed = false,
                    CategoryID = 2,
                },
                new MyTask
                {
                    TaskName = "Amogus!",
                    Completed = true,
                    CategoryID = 2,
                },
                 new MyTask
                {
                    TaskName = "Osama Bin Ladin",
                    Completed = true,
                    CategoryID = 3,
                },
                 new MyTask
                {
                    TaskName = "Twin Towers",
                    Completed = true,
                    CategoryID = 3,
                },
                 new MyTask
                {
                    TaskName = "Airplane",
                    Completed = true,
                    CategoryID = 3,
                }
            };

            UpdateDate();
        }

        private void UpdateDate()
        {
            foreach(var c in Categories)
            {
                var task = from t in Task
                           where t.CategoryID == c.Id
                           select t;

                var completed = from t in task
                                where t.Completed == true
                                select t;

                var notComplete = from t in task
                                  where t.Completed == false
                                  select t;

                c.PendingTask = notComplete.Count();
                c.Percentage = (float)completed.Count()/(float)task.Count();
            }

            foreach (var t in Task)
            {
                var catColor = 
                    (from c in Categories
                     where c.Id == t.CategoryID
                     select c.Color).FirstOrDefault();
                t.TaskColor = catColor;
            }
        }
    }
}
