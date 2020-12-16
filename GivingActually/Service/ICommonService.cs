using GivingActually.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GivingActually.Service
{
    public interface ICommonService 
    {
        List<StoriesViewModel> GetStories();
    }
}