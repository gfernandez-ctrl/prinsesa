using Heirloom;
namespace prinsesa;

public class balon
{
    Random random = new Random();
    private Image _imatge;
    private Vector posicio;

    public balon(int x, int y)
    {
        _imatge = new Image("fotos/balon-removebg-preview.png");
        posicio = new Vector(random.Next(800), random.Next(600));
    }

  

    public void Pinta(GraphicsContext gfx)
    {
        gfx.DrawImage(_imatge, posicio);
        
    }
    public void Mou(Rectangle finestra)
    {
        var novaPosicio = new Rectangle(posicio,_imatge.Size);
    }
}
