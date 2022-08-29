using DemoNoti.Client.Entities;
using DemoNoti.Client.HubClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace DemoNoti.Client.Controllers
{
    public class LiveScoresController : Controller
    {
        private readonly liveonsportContext _context;
        private readonly IHubContext<BroadCastHub> _hub;

        public LiveScoresController(liveonsportContext context, IHubContext<BroadCastHub> hub)
        {
            _context = context;
            _hub = hub;
        }

        public IActionResult Index()
        {
            return View(_context.Livescores.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Livescore model)
        {
            try
            {
                var data = new Livescore
                {
                    UrlImage = "202208250803_image.png",
                    SportName = "Football",
                    SportTypeId = 2,
                    SportRefId = 0,
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = 1,
                    SportNameKo = "안녕하세요"
                };

                _context.Livescores.Add(data);
                _context.SaveChanges();

                await _hub.Clients.All.SendAsync("BroadcastMessage");

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PublishCreateLiveScore(Notification model)
        {
            await _hub.Clients.All.SendAsync("BroadcastMessage");
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
