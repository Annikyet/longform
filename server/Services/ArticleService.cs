using longform.Models;
using longform.Repositories;

namespace longform.Services
{
  public class ArticleService
  {
    private readonly ArticleRepository _repo;
    public ArticleService(ArticleRepository repo)
    {
      _repo = repo;
    }
  }
    // public class AccountService
    // {
    //     private readonly AccountsRepository _repo;
    //     public AccountService(AccountsRepository repo)
    //     {
    //         _repo = repo;
    //     }

    //     internal string GetProfileEmailById(string id)
    //     {
    //         return _repo.GetById(id).Email;
    //     }
    //     internal Account GetProfileByEmail(string email)
    //     {
    //         return _repo.GetByEmail(email);
    //     }
    //     internal Account GetOrCreateProfile(Account userInfo)
    //     {
    //         Account profile = _repo.GetById(userInfo.Id);
    //         if (profile == null)
    //         {
    //             return _repo.Create(userInfo);
    //         }
    //         return profile;
    //     }

    //     internal Account Edit(Account editData, string userEmail)
    //     {
    //         Account original = GetProfileByEmail(userEmail);
    //         original.Name = editData.Name.Length > 0 ? editData.Name : original.Name;
    //         // original.ProfileImgId = editData.ProfileImgId.Length > 0 ? editData.ProfileImgId : original.ProfileImgId;
    //         return _repo.Edit(original);
    //     }
    // }
}