using JimenezAndres_Examen_P2.Interfaces;
using JimenezAndres_Examen_P2.Models;
using Newtonsoft.Json;

namespace JimenezAndres_Examen_P2.Repositories;

public class RecargasFileRepository : iRecargas
{
    public string _filePath = Path.Combine(FileSystem.AppDataDirectory, "AndresJimenez.txt");
    
    public bool CreateRecarga(Recargas recarga)
    {
        try
        {
            string json_data = JsonConvert.SerializeObject(recarga);
            File.WriteAllText(_filePath, json_data);
            return true;
        }
        catch (Exception e)
        {
            throw;
        }
    }
    
    public bool UpdateRecarga(Recargas recarga)
    {
        throw new NotImplementedException();
    }
    
    public Recargas GetRecarga(string numero)
    {
        Recargas recarga = new Recargas();
        try
        {
            if (File.Exists(_filePath))
            {
                string json_data = File.ReadAllText(_filePath);
                recarga = JsonConvert.DeserializeObject<Recargas>(json_data);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return recarga;
    }
    
    public bool DeleteRecarga(string numero)
    {
        throw new NotImplementedException();
    }
    
}