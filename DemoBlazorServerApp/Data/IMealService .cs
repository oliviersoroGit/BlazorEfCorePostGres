using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorServerApp.Data
{
    public interface IMealService
    {
        Task<List<Meal>> GetMealsAsync();
        Task<Meal> GetMealByIdAsync(int id);
        Task<Meal> InsertMealAsync(Meal meal);
        Task<Meal> UpdateMealAsync(int id, Meal m);
        Task<Meal> DeleteMealAsync(int id);
    }
}
