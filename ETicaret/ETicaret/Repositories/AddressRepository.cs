using ETicaret;
public class AddressRepository : IAddressRepository
{


    private readonly ETicaretContext _eTicaretContext;

    public AddressRepository()
    {
        _eTicaretContext = new ETicaretContext();
    }

    async Task<Country> IAddressRepository.FindCountryByName(string countryName)
    {
        return  _eTicaretContext.Set<Country>().FirstOrDefault(c => c.Name == countryName);

    }
    async Task<City> IAddressRepository.FindCityByName(string CityName)
    {
        return  _eTicaretContext.Set<City>().FirstOrDefault(c => c.Name == CityName);

    }

    async Task<State> IAddressRepository.FindStateByName(string StateName)
    {
        return  _eTicaretContext.Set<State>().FirstOrDefault(c => c.Name == StateName);

    }

    async Task<District> IAddressRepository.FindDistrictByName(string DistirctName)
    {
        return  _eTicaretContext.Set<District>().FirstOrDefault(c => c.Name == DistirctName);

    }



    public async Task<Address> RegisterAddress(Address address)
    {   
        try{
        _eTicaretContext.Address.AddAsync(address);
        _eTicaretContext.SaveChangesAsync();
        return address;
         }
        catch(Exception e)
        {
            return null;
        }
    }


    public async Task<List<Address>> GetAllAddress()
    {

        return  _eTicaretContext.Set<Address>().ToList();
    }
    public async Task<Address> GetAddress(int id)
    {

        var getAddress =  _eTicaretContext.Set<Address>().SingleOrDefault(p => p.Id == id);

        if (getAddress != null)
        {

            return getAddress;

        }
        else
        {
            return null;
        }
    }
    public async Task<Country> GetCountry(string name)
    {

        var countrycontroller =  _eTicaretContext.Set<Country>().FirstOrDefault(p => p.Name == name);
        if (countrycontroller != null)
        {
            return countrycontroller;
        }
        return null;
    }


    public async Task<List<Country>> GetAllCountry()
    {

        return  _eTicaretContext.Set<Country>().ToList();
    }


    string name;
    public async Task<List<State>> GetAllStatesByCountryId(int id)
    {

        var getState =  _eTicaretContext.Set<State>().Where(p => p.CountryId == id).ToList();
        if (getState != null)
        {

            return getState;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<City>> GetAllCitiesByStateId(int id)
    {
        var getCity =  _eTicaretContext.Set<City>().Where(p => p.StateId == id).ToList();
        if (getCity != null)
        {

            return getCity;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<City>> GetAllCitiesByContryId(int id)
    {
        var getCity =  _eTicaretContext.Set<City>().Where(p => p.CountryId == id).ToList();
        if (getCity != null)
        {

            return getCity;

        }
        else
        {
            return null;
        }
    }

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        var getDistricts =  _eTicaretContext.Set<District>().Where(p => p.CityId == id).ToList();
        if (getDistricts != null)
        {

            return getDistricts;

        }
        else
        {
            return null;
        }
    }
    public async Task<Address> DeleteAddress(int id)
    {


        var findedAddress =  _eTicaretContext.Address.FirstOrDefault(x => x.Id == id);
        _eTicaretContext.Address.Remove(findedAddress);
        _eTicaretContext.SaveChangesAsync();

        return null;


    }


    async Task<Address> IAddressRepository.UpdateAddress(int id)
    {
        var findedAdress= await _eTicaretContext.Address.FindAsync(id);
        _eTicaretContext.Address.Update(findedAdress);
        _eTicaretContext.SaveChanges();
        return findedAdress;
    }

    async Task<Country> IAddressRepository.CreateCountry(Country country)
    {
        try{
        await _eTicaretContext.Set<Country>().AddAsync(country);
        await _eTicaretContext.SaveChangesAsync();
        return country;
        }
        catch(Exception e)
        {
            return null;
        }
    }
    async Task<City> IAddressRepository.CreateCity(City city)
    {
        try{
        await _eTicaretContext.Set<City>().AddAsync(city);
        await _eTicaretContext.SaveChangesAsync();
        return city;
        }
        catch(Exception e)
        {
            return null;
        }
    }

    async Task<State> IAddressRepository.CreateState(State state)
    {
        try{
        await _eTicaretContext.Set<State>().AddAsync(state);
        await _eTicaretContext.SaveChangesAsync();
        return state;
        }
        catch(Exception e)
        {
            return null;
        }
    }

    async Task<District> IAddressRepository.CreateDistrict(District district)
    {
        try{
        await _eTicaretContext.Set<District>().AddAsync(district);
        await _eTicaretContext.SaveChangesAsync();
        return district;
        }
        catch(Exception e)
        {
            return null;
        }
    }

    async Task<Country> IAddressRepository.DeleteCountry(Country country)
    {
         var findedCountry= await _eTicaretContext.Set<Country>().FindAsync(country.Id);
        _eTicaretContext.Set<Country>().Remove(country);
        _eTicaretContext.SaveChangesAsync();
        return country;
    }

    async Task<City> IAddressRepository.DeleteCity(City city)
    {
        var findedCity= await _eTicaretContext.Set<City>().FindAsync(city.Id);
        _eTicaretContext.Set<City>().Remove(city);
        _eTicaretContext.SaveChangesAsync();
        return city;
    }

    async Task<State> IAddressRepository.DeleteState(State state)
    {
        var findedState= await _eTicaretContext.Set<State>().FindAsync(state.Id);
        _eTicaretContext.Set<State>().Remove(state);
        _eTicaretContext.SaveChangesAsync();
        return state;
    }

    async Task<District> IAddressRepository.DeleteDistrict(District district)
    {
        var findedDisctrict= await _eTicaretContext.Set<District>().FindAsync(district.Id);
        _eTicaretContext.Set<District>().Remove(district);
        _eTicaretContext.SaveChangesAsync();
        return findedDisctrict;
    }


}
