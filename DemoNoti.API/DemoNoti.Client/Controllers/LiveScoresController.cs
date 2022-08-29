using DemoNoti.Client.Entities;
using DemoNoti.Client.HubClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace DemoNoti.Client.Controllers
{
    public class LiveScoresController : Controller
    {
        private readonly liveonsportContext _context;
        private readonly IHubContext<BroadCastHub, IHubClient> _hub;

        public LiveScoresController(liveonsportContext context, IHubContext<BroadCastHub, IHubClient> hub)
        {
            _context = context;
            _hub = hub;
        }

        public IActionResult Index()
        {
            return View(_context.Livescores.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> PublishCreateLiveScore(Notification model)
        {
            await _hub.Clients.All.BroadcastMessage();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetLiveScores()
        {
            return Ok(_context.Livescores.ToList());
        }
    }

    public class Notification
    {
        public string? Message { get; set; }
    }
}
