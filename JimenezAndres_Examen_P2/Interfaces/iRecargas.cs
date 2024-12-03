using JimenezAndres_Examen_P2.Models;

namespace JimenezAndres_Examen_P2.Interfaces;

public interface iRecargas
{
    Recargas GetRecarga(string numero);
    bool CreateRecarga(Recargas recarga);
    bool UpdateRecarga(Recargas recarga);
    bool DeleteRecarga(string numero);
}