using ETicaret;

    public interface IAccountRepository

{
    Task<List<Account>> GetAllAccounts();
    Task<Account> CreateAccount(Account account);
    Task<Account> GetAccountByEmail(string email);
    Task<Account> UpdateAccountByEmail(Account account);
    Task<Account> UpdateAccountPassword(Account account,string oldpassword, string newpassword); 
    Task<Account> ChangeVisibilityOfAccount(int id);
    Task<Account> BlockAccountById(int id);
    Task<Account> Role();
    Task<AccountDTO> CreateNewAccount(AccountDTO account);   
    Task<Account> FindAccountByEmailAndPasswordAsync(LoginDTO loginDTO);       
    Account FindAccountByEmailAndPassword(LoginDTO loginDTO); 
    
    Task<Account> findAccountByIdAsync(int id);
    Account findAccountById(int id);
}

