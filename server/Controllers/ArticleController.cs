using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Utils;
using longform.Models;
using longform.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace longform.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ArticleController : ControllerBase
  {
    private readonly ArticleService _articleService;
    private readonly Auth0Provider _auth0Provider;

    public ArticleController(ArticleService articleService, Auth0Provider auth0Provider)
    {
      _articleService = articleService;
      _auth0Provider = auth0Provider;
    }

    [HttpGet("{id}")]
    public ActionResult<Article> GetById(int id)
    {
      try
      {
        Article article = _articleService.GetById(id);
        return Ok(article);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}

    //     [HttpGet]
    //     [Authorize]
    //     public async Task<ActionResult<Account>> Get()
    //     {
    //         try
    //         {
    //             Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
    //             return Ok(_accountService.GetOrCreateProfile(userInfo));
    //         }
    //         catch (Exception e)
    //         {
    //             return BadRequest(e.Message);
    //         }
    //     }
    // }