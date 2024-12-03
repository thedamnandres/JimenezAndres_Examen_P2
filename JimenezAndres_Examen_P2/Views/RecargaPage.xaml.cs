using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JimenezAndres_Examen_P2.Models;
using JimenezAndres_Examen_P2.Repositories;

namespace JimenezAndres_Examen_P2.Views;

public partial class RecargaPage : ContentPage
{
    RecargasFileRepository _recargaRepo;
    private Recargas recargas = new Recargas();
    
    public RecargaPage()
    {
        InitializeComponent();
        _recargaRepo = new RecargasFileRepository();
        recargas = _recargaRepo.GetRecarga("1");
        BindingContext = recargas;

    }
   
    public async void btn_save_Clicked(object sender, EventArgs e)
    {
        Recargas recargas = new Recargas
        {
            Number = ajimenez_editor1.Text,
            Name = ajimenez_editor2.Text
        };
        bool saveRecarga = _recargaRepo.CreateRecarga(recargas);
        if (saveRecarga)
        {
            await DisplayAlert("Success", "Recarga guardada correctamente", "OK");
            Navigation.PushAsync(new RecargaPage());
        }
        else
        {
            await DisplayAlert("Error", "Error al guardar la recarga", "OK");
            
        }
    }
}