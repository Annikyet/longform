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
  public class ArticlesController : ControllerBase
  {
    private readonly ArticlesService _articlesService;
    private readonly Auth0Provider _auth0Provider;

    public ArticlesController(ArticlesService articlesService, Auth0Provider auth0Provider)
    {
      _articlesService = articlesService;
      _auth0Provider = auth0Provider;
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Article>> Create([FromBody] Article article)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        article.AuthorId = userInfo.id;
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Article> GetById(int id)
    {
      try
      {
        Article article = _articlesService.GetById(id);
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