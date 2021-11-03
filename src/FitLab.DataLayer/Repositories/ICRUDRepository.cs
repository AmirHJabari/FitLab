using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Repositories
{
    public interface ICRUDRepository<TData, TFields> where TData : class where TFields : class
    {
        string GetFields(TFields whichFields);


        List<TData> GetAll(TFields whichFields = null);
        Task<List<TData>> GetAllAsync(TFields whichFields = null);


        List<TData> Search(string filter, TFields whichFields = null);
        Task<List<TData>> SearchAsync(string filter, TFields whichFields = null);


        TData GetByID(int ID);
        bool Insert(TData obj);
        bool Update(TData obj);
        bool Delete(TData obj);
        bool Delete(int ID);
    }
}
