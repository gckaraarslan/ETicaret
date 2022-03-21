using ETicaret;
using Microsoft.EntityFrameworkCore;
public class AccountRepository :IAccountRepository
{     
    
    
      

    private readonly ETicaretContext _context;
    public AccountRepository(ETicaretContext context)
    {
        _context=context;
    }
    public AccountRepository()
    {
                                                                           
    }

    public async Task<List<Account>> GetAllAccounts()
    {
        return  await _context.Set<Account>().ToListAsync();
    }

    public async Task<Account> CreateAccount(Account account)
    {
        await _context.Accounts.AddAsync(account);       
       await  _context.SaveChangesAsync();
        return account;
    }

    public async Task<Account> GetAccountByEmail(string email)
    {
        return   _context.Set<Account>().SingleOrDefault(a=>a.EMAIL==email); //burda awaiti kaldırınca düzeliyor, neden ?
    }

    public async Task<Account> UpdateAccountByEmail(Account account)
    {
        
        _context.Update(account);
         await _context.SaveChangesAsync();
        return account; 
    }

    public async Task<Account> UpdateAccountPassword(Account account, string oldpassword, string newpassword)
    {
         _context.Accounts.Update(account);
          await _context.SaveChangesAsync();
          return account;  
    }

    public async Task<Account> ChangeVisibilityOfAccount(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Account> BlockAccount()
    {
        throw new NotImplementedException();
    }

    public async Task<Account> Role()   //
    {
        throw new NotImplementedException();
    }

   /* public async Task<AccountDTO> CreateAccount(AccountDTO account)     
    {
        try
        {
            Account persistAccount = new Account();

              _context.Set<Account>().AddAsync(persistAccount);   
              _context.SaveChangesAsync();                                 
            return new AccountDTO(persistAccount);
        }
        catch (Exception e)
        {
            return new AccountDTO(null);    
        }
    }*/

    public async Task<Account> FindAccountByEmailAndPasswordAsync(LoginDTO loginDTO)
    {
         Account accountFinded = (from x in _context.Accounts
                           where x.EMAIL == loginDTO.Email && x.PASSWORD == loginDTO.Password
                           select x).FirstOrDefault();
        return accountFinded;
    }
     public  Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
         Account accountFinded = (from x in _context.Accounts
                           where x.EMAIL == loginDTO.Email && x.PASSWORD == loginDTO.Password
                           select x).FirstOrDefault();
        return accountFinded;
    }

    public  Account findAccountById(int id)
    {
         Account accountByID = (from x in _context.Accounts
                           where x.ID == id
                           select x).FirstOrDefault();
        return accountByID;
    }
    public async Task<Account> findAccountByIdAsync(int id)
    {
         Account accountByID = (from x in _context.Accounts
                           where x.ID == id
                           select x).FirstOrDefault();
        return accountByID;
    }

   
    public Task<Account> BlockAccountById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<AccountDTO> CreateNewAccount(AccountDTO account)
    {
        throw new NotImplementedException();
    }
}

   
