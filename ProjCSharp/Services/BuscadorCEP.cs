public class CepService : IDisposable
{
    private readonly HttpClient _httpClient;

    public CepService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://viacep.com.br/")
        };
    }

    public async Task<(string City, string State)> GetCityAndStateByCepAsync(string cep)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"ws/{cep}/json/");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            // Desserializar o JSON para extrair o nome da cidade (localidade) e estado (UF) //
            dynamic addressData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
            string cityName = addressData.localidade;
            string state = addressData.uf;

            if (!string.IsNullOrEmpty(cityName))
            {
                return (cityName, state);
            }
            else
            {
                return ("Município não encontrado para o CEP fornecido.", "");
            }
        }
        catch (HttpRequestException e)
        {
            return ($"Erro na requisição HTTP: {e.Message}", "");
        }
        catch (Exception e)
        {
            return ($"Erro ao processar resposta: {e.Message}", "");
        }
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}


//=================================================================================================================================================//
