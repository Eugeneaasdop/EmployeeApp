using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace PhoneApp1
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Employee emp;
        public ICommand Calculate { get; }
        public ICommand plusSalary { get; }
        public ICommand minusSalary { get; }
        public ICommand plusExp { get; }
        public ICommand minusExp { get; }
        public ICommand plusFactor { get; }
        public ICommand minusFactor { get; }

        public EmployeeViewModel()
        {
            emp = new Employee();
            Calculate = new Command(CalculatePrize);
            plusSalary = new Command(CalculatePlusSalary);
            minusSalary = new Command(CalculateMinusSalary);
            plusExp = new Command(CalculatePlusExp);
            minusExp = new Command(CalculateMinusExp);
            plusFactor = new Command(CalculatePlusFactor);
            minusFactor = new Command(CalculateMinusFactor);
        }

        public void CalculatePrize()
        {
            if (emp != null)
                Prize = Salary*Exp*Factor;
        }
        public void CalculatePlusSalary()
        {
            if (emp != null)
                Salary += 100;
        }
        public void CalculateMinusSalary()
        {
            if (emp != null && Salary > 0)
                Salary -= 100;
        }
        public void CalculatePlusExp()
        {
            if (emp != null)
                Exp += 1;
        }
        public void CalculateMinusExp()
        {
            if (emp != null && Exp > 0)
                Exp -= 1;
        }
        public void CalculatePlusFactor()
        {
            if (emp != null)
                Factor += 0.25;
        }
        public void CalculateMinusFactor()
        {
            if (emp != null && Factor > 0)
                Factor -= 0.25;
        }

        public string FIO
        {
            get { return emp.FIO; }
            set
            {
                if (emp.FIO != value)
                {
                    emp.FIO = value;
                    OnPropertyChanged("FIO");
                }
            }
        }
        public string Stuff
        {
            get { return emp.Stuff; }
            set
            {
                if (emp.Stuff != value)
                {
                    emp.Stuff = value;
                    OnPropertyChanged("Stuff");
                }
            }
        }
        public int Salary
        {
            get { return emp.Salary; }
            set
            {
                if (emp.Salary != value)
                {
                    emp.Salary = value;
                    OnPropertyChanged("Salary");
                }
            }
        }
        public int Exp
        {
            get { return emp.Exp; }
            set
            {
                if (emp.Exp != value)
                {
                    emp.Exp = value;
                    OnPropertyChanged("Exp");
                }
            }
        }
        public double Factor
        {
            get { return emp.Factor; }
            set
            {
                if (emp.Factor != value)
                {
                    emp.Factor = value;
                    OnPropertyChanged("Factor");
                }
            }
        }
        public double Prize
        {
            get { return emp.Prize; }
            set
            {
                if (emp.Prize != value)
                {
                    emp.Prize = value;
                    OnPropertyChanged("Prize");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
