using Heirloom;
using prinsesa;

namespace MovimentImatge;

public class vini
{
    private Image _imatge;
    private Vector posicio;
    private int velocitat;

    public vini(int x, int y)
    {
        _imatge = new Image("fotos/vini-removebg-preview.png");
        velocitat = 18;
        posicio = new Vector(x, y);
    }

    public void Pinta(GraphicsContext gfx)
    {
        gfx.DrawImage(_imatge, posicio);
        
    }


    public void Mou(Rectangle finestra)
    {
        var novaPosicio = new Rectangle(posicio,_imatge.Size);
        if(Input.CheckKey(Key.A, ButtonState.Down))
        {
            novaPosicio.X -= velocitat;
        }
        
        if(Input.CheckKey(Key.D, ButtonState.Down))
        {
            novaPosicio.X += velocitat;
        }
        if(Input.CheckKey(Key.W, ButtonState.Down))
        {
            novaPosicio.Y -= velocitat;
        }
        if(Input.CheckKey(Key.S, ButtonState.Down))
        {
            novaPosicio.Y += velocitat;
        }

        if (finestra.Contains(novaPosicio))
        {
            posicio.X = novaPosicio.X;
            posicio.Y = novaPosicio.Y;
        }
            
    }

    public bool HaCapturatUnaPilota(balon balon)
    {
        var rectangleVini = new Rectangle(posicio,_imatge.Size);
        var rectangleBalon = new Rectangle(posicio,_imatge.Size);
        
        return rectangleVini.Overlaps(rectangleBalon);
        
    }
}