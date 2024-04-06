public class CepService
{
    private readonly HttpClient _httpClient;

    public CepService()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://viacep.com.br/");
    }

    public async Task<string> GetCityByCepAsync(string cep)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"ws/{cep}/json/");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            // Desserializar o JSON para extrair o nome da cidade (localidade)
            dynamic addressData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
            string cityName = addressData.localidade;

            if (!string.IsNullOrEmpty(cityName))
            {
                return $"Município: {cityName}";
            }
            else
            {
                return "Município não encontrado para o CEP fornecido.";
            }
        }
        catch (HttpRequestException ex)
        {
            return $"Erro na requisição HTTP: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Erro ao processar resposta: {ex.Message}";
        }
    }
}

//=================================================================================================================================================//
