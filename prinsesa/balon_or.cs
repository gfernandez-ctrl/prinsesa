using Heirloom;
namespace prinsesa;

public class balon_or
{
    public balon_or(int x, int y)
    {
        Random random = new Random();
       
    }

    private Image _imatge;
          private Vector posicio;
          public static bool _esOr { get; }
    
    
    
          public balon_or(bool _esOr)
          {
              Random random = new Random();
              _imatge = new Image("fotos/balon-or-removebg-preview.png");
              posicio = new Vector(random.Next( 1920 - _imatge.Width), random.Next(1080 - _imatge.Height));
              bool esOr = false;
              _esOr = esOr;
              throw new NotImplementedException();
          } 
}
