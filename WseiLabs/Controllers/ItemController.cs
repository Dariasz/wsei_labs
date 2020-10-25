using Microsoft.AspNetCore.Mvc;
using WseiLabs.Models;

namespace WseiLabs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        [HttpPost]
        public ItemModel Post(ItemModel itemModel)
        {
            // var viewModel = new CompanyAddedViewModel
            // {
            //     NumberOfCharsInName = itemModel.Name.Length,
            //     NumberOfCharsInDescription = itemModel.Description.Length,
            //     IsHidden = !itemModel.IsVisible,
            // };
            return itemModel;
        }
    }
}