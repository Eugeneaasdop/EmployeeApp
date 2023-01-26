namespace PhoneApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        this.BindingContext = new EmployeeViewModel
        {
            FIO = "Смирнов А.А.",
            Stuff = "Программист",
            Salary = 100200,
            Exp = 9,
            Factor = 2.25
        };
    }
}

