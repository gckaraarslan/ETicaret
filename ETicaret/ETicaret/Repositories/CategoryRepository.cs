using ETicaret;
public class CategoryRepository : ICategoryRepository
{
    private readonly ETicaretContext _context;

    public CategoryRepository(ETicaretContext context)
    {
        _context = context;
    }

    public async Task<Category> AddCategory(Category category)
    {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task DeleteCategory(Category category)
    {
        _context.Categories.Remove(category);
         await _context.SaveChangesAsync();
        
    }
                                                                                            //await, async eklencek mi ??? eklenmesi lazım
                                                                                            
    public async Task<List<Category>> GetAllCategory()
    {
       return  _context.Categories.ToList();
    }

    public async Task<List<Category>> GetAllCategoryByName(string categoryName)
    {
        return  _context.Categories.Where(c => c.Name == categoryName).ToList();
    }

    public async Task<Category> GetByCategoryId(int categoryId)
    {
        return  _context.Categories.FirstOrDefault(c=>c.Id == categoryId);
    }

    public async Task<Category> UpdateCategory(Category category)
    {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
        return category;

    }
}