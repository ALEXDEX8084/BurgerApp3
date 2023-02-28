using MvvmBurgerApp.ViewModels;

namespace MvvmBurgerApp.View;

public partial class OrderListPage : ContentPage
{
	public OrderListPage()
	{
		InitializeComponent();
		BindingContext = new BurgerListViewModel() { Navigation = this.Navigation };
	

    }

    private void Itogi_Clicked(object sender, EventArgs e)
    {
        List<BurgerViewModel> Burgers = new List<BurgerViewModel>();
        foreach (var b in booksList.ItemsSource) Burgers.Add((BurgerViewModel)b);

        int totalPrice = 0;
        foreach (var b in Burgers) totalPrice += b.Total;
        ItogCounttext.Text = totalPrice.ToString();
    }
}