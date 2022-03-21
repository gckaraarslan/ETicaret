using ETicaret;
public class BrandRepository : IBrandRepository{

    private readonly ETicaretContext _context;

    public BrandRepository(ETicaretContext context)
    {
        _context = context;
        
    }
    public async Task<Brand> AddBrandAsync(Brand brand)
    {
        await _context.Brands.AddAsync(brand);
        await _context.SaveChangesAsync();
        return brand;
    }
    public async Task<Brand> UpdateBrandAsync(Brand brand)
    {
        _context.Brands.Update(brand);
        await _context.SaveChangesAsync();
        return brand;

    }
    public async Task DeleteBrandAsync(Brand brand)
    {
         _context.Brands.Remove(brand);
         await _context.SaveChangesAsync();
    }
    public async Task<List<Brand>> GetAllBrandAsync()
    {
        return   _context.Brands.ToList();
    }
    public async Task<Brand> GetByBrandIdAsync(int brandId)
    {
        return  _context.Brands.FirstOrDefault(p=> p.Id == brandId);
    }
    public async Task<List<Brand>> GetAllBrandByNameAsync(string brandName)
    {
        return  _context.Brands.Where(p=> p.Name == brandName).ToList();

    }

}