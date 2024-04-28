namespace SalSystem.Services;

public class ImagemConverter
{
    public static string ImageToBase64(Image image)                                 //----- Converte uma imagem para string de Base64 -----//
    {
        using MemoryStream ms = new();
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);    // <-- Salva a imagem no MemoryStream em formato JPEG //
        byte[] imageData = ms.ToArray();                            // <-- Converte os bytes da imagem para base64 //
        return Convert.ToBase64String(imageData);
    }

    public static byte[] Base64ToImage(string base64String)                         //----- Converte uma string base64 de volta para uma imagem (array de bytes)-----//
    {
        return Convert.FromBase64String(base64String);
    }
   
    public static void SaveImageFromBase64(string base64Image, string outputPath)   //----- Salva uma imagem (representada como base64) em um arquivo no disco -----//
    {
        byte[] imageData = Convert.FromBase64String(base64Image);
        File.WriteAllBytes(outputPath, imageData);
    }
}

