using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Todo : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                this.id = value;
                RaisePropertyChanged("Id");
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                this.title = value;
                RaisePropertyChanged("Title");
            }
        }
        private string deadline;
        public string Deadline
        {
            get { return deadline; }
            set
            {
                this.deadline = value;
                RaisePropertyChanged("Deadline");
            }
        }

        public Todo(int id, string title, string deadline)
        {
            this.id = id;
            this.title = title;
            this.deadline = deadline;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
