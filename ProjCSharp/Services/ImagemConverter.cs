
namespace SalSystem.Services;

public class ImagemConverter
{
    public static string ImageToBase64(Image _image)                   //***----- Converte uma imagem para string de Base64 -----***//
    {
        using MemoryStream _ms = new();
            _image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);          // <-- Salva a imagem no MemoryStream em formato JPEG //
            byte[] _imageData = _ms.ToArray();                                  // <-- Converte os bytes da imagem para base64 //
        return Convert.ToBase64String(_imageData);
    }

    public static Image Base64ToImage(string _base64String)           //***----- Converte uma string base64 de volta para uma imagem (array de bytes)-----***//
    {
        try
        {
            byte[] imageData = Convert.FromBase64String(_base64String);         // <-- Converte a string Base64 de volta para um array de bytes //
            using MemoryStream _ms = new(imageData);                            // <-- Cria um MemoryStream a partir dos dados do array de bytes //
                Image _image = Image.FromStream(_ms);                           // <-- Tenta criar e retornar a imagem a partir do MemoryStream //
            return _image;
          
        }
        catch (FormatException ex)
        {
            throw new ArgumentException("A string Base64 fornecida não é válida.", nameof(_base64String), ex);
        }
    }
   
    public static void SaveImageFromBase64(string base64Image, string outputPath)   //***----- Salva uma imagem (representada como base64) em um arquivo no disco -----***//
    {
        byte[] imageData = Convert.FromBase64String(base64Image);
        File.WriteAllBytes(outputPath, imageData);
    }
}

