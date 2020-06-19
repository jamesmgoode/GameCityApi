using GameCityApi.Models.NineIsles;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameCityApi.Data
{
    public class NineIslesService : INineIslesService
    {
        private readonly string _apiKey;
        private readonly string _spreadsheetId;

        public NineIslesService(IConfiguration configuration)
        {
            _apiKey = configuration.GetValue<string>("NineIslesData:ApiKey");
            _spreadsheetId = configuration.GetValue<string>("NineIslesData:SpreadsheetId");
        }

        public async Task<IEnumerable<Research>> GetAllResearchAsync()
        {
            var service = new SheetsService(new BaseClientService.Initializer
            {
                ApiKey = _apiKey
            });

            // Define request parameters.
            var spreadsheetId = _spreadsheetId;
            var range = "AllResearch!A2:D";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            var response = await request.ExecuteAsync();
            var values = response.Values;

            var researches = new List<Research>();
            try
            {
                foreach (var research in values)
                {
                    researches.Add(new Research
                    {
                        Name = research[0].ToString(),
                        Description = research[1].ToString(),
                        ResearchType = Enum.Parse<ResearchType>(research[2].ToString()),
                        Level = int.Parse(research[3].ToString())
                    });
                }

                return researches;
            }
            catch
            {
                return new List<Research> { new Research { Name = "Error", Description = "Error getting research data", Level = -1 } };
            }
        }
    }
}
