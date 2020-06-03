using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorServerApp.Data
{
    public class MealService : IMealService
    {
        DemoBlazorServerAppContext _context;

        public MealService(DemoBlazorServerAppContext context)
        {
            _context = context;
        }

        public async Task<List<Meal>> GetMealsAsync()
        {
            return await _context.Meals.OrderBy(x => x.CreatedDate).ToListAsync();
        }

        public async Task<Meal> GetMealByIdAsync(int id)
        {
            return await _context.Meals.FindAsync(id);
        }

        public async Task<Meal> InsertMealAsync(Meal meal)
        {
            meal.CreatedDate = DateTime.Now;
            _context.Meals.Add(meal);
            await _context.SaveChangesAsync();

            return meal;
        }

        public async Task<Meal> UpdateMealAsync(int id, Meal m)
        {
            var meal = await _context.Meals.FindAsync(id);

            if (meal == null)
                return null;

            meal.Name = m.Name;
            meal.Description = m.Description;
            meal.Price = m.Price;

            _context.Meals.Update(meal);
            await _context.SaveChangesAsync();

            return meal;
        }

        public async Task<Meal> DeleteMealAsync(int id)
        {
            var meal = await _context.Meals.FindAsync(id);

            if (meal == null)
                return null;

            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();

            return meal;
        }

    }
}
