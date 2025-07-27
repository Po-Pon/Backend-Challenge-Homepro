using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using api.Models.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BooksController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("books")]
        public async Task<IActionResult> GetBooks()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://api.itbook.store/1.0/search/mysql");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "Error fetching data.");
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<BookApiResponse>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (apiResponse?.Books == null)
            {
                return Ok(new List<BookDto>());
            }

            var sortedBooks = apiResponse.Books.OrderBy(b => b.Title).ToList();
            return Ok(sortedBooks);
        }
    }
}