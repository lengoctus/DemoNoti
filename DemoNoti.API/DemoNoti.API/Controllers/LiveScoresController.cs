using DemoNoti.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DemoNoti.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveScoresController : ControllerBase
    {
        private readonly liveonsportContext _context;

        public LiveScoresController(liveonsportContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create()
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

            using (var client = new HttpClient())
            {
                var model = new Notification
                {
                    Message = "Sent msg"
                };

                var todoItemJson = new StringContent(
                   JsonSerializer.Serialize(model),
                   Encoding.UTF8,
                   "application/json");

                var response = client.PostAsync<Notification>(https://localhost:7162/LiveScores/PublishCreateLiveScore, todoItemJson);
                response.Wait();
            }

            return Ok(data);
        }
    }

    public class Notification
    {
        public string? Message { get; set; }
    }
}
