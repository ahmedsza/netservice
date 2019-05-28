using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Helper
{
public async Task<string> GetMessage()
{
using (var client = new HttpClient())
    {
        try
        {
            client.BaseAddress = new Uri("http://springjava3.df1f849f01ef4c4a90e4.westeurope.aksapp.io");
            var response = await client.GetAsync($"/greeting");
            response.EnsureSuccessStatusCode();

            var stringResult = await response.Content.ReadAsStringAsync();
            var greeting = JsonConvert.DeserializeObject<Greeting>(stringResult);
            return greeting.content;
        }
        catch
        {
            return "An error occurred";
        }
        
    }
}

}

public class Greeting
{
    public int id { get; set; }
    public string content { get; set; }
}