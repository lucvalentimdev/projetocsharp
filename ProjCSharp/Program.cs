namespace SalSystem;

internal static class Program
{
/* <summary> 
 === INFORMA��ES GERAIS ===========================================================================================================================================  
    Desenvolvedor: Lucas S. Valentim;
    Projeto Iniciado em: 17 de Mar�o de 2024;
    Tipo de projeto: Open-Source;
    Prop�sito do sistema desenvolvido: Aplica��o para portif�lio pessoal;
-------------------------------------------------------------------------------------------------------------------------------------------------------------------
 === Cr�ditos as imagens ==========================================================================================================================================
            Background : 
                <a href="https://br.freepik.com/vetores-gratis/resumo-de-um-fundo-poligonal-geometrico-moderno_1245638.htm#fromView=search&page=1&position=12&uuid=04272628-7a5e-4afa-aeba-35a2c9dc5990"> Imagem de Creative_hat no Freepik</a>
            Icon carrinho de compras: 
                <a href="https://br.freepik.com/icone/carrinho_4290854#fromView=search&page=1&position=5&uuid=2fb9c0a5-f9ab-44f6-a278-0981378a9f96"> �cone de Freepik</a>

---------------------------------------------------------------------------------------------------------------------------------------------------------------------    
========================================================================================================================================================</summary> */
    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new F_Menu());
    }
}