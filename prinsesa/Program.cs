using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Threading.Tasks.Dataflow;
using Heirloom;
using Heirloom.Desktop;
using MovimentImatge;
using prinsesa;

namespace Princesa;

class Program
{
    const int balonInicials = 4;
    private static Window finestra;
    private static vini vini;
    private static List<balon> balon = new();
    
    static void Main()
    {
        Application.Run(() =>
        {
            finestra = new Window("La finestra");
            finestra.BeginFullscreen();
            vini = new vini(10,10);
            bool _esOr = true;
            for (int i = 0; i < balonInicials; i++)
            {
                balon.Add(new balon(_esOr));
                _esOr = false;
            }
            
            
            
            var loop = GameLoop.Create(finestra.Graphics, OnUpdate);
            loop.Start();
        });
    }

    [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
    private static void OnUpdate(GraphicsContext gfx, float dt)
    {
        var rectangleFinestra = new Rectangle(
            0, 0, finestra.Width, finestra.Height
        );
        var fons = new Image("fotos/santiago.jpeg");
        foreach (var balon in balon)
        {
            if (vini.HaCapturatUnaPilota(balon))
            {
                if (balon_or._esOr)
                {
                    Console.WriteLine("Has trobat la pilota d'or.");
                }
                else
                {
                    Console.WriteLine("No l'has trobat.");
                }
            }
        }
        
        gfx.DrawImage(fons, rectangleFinestra);
        vini.Mou(rectangleFinestra);
        vini.Pinta(gfx);
        foreach (var balon in balon)
        {
            balon.Pinta(gfx);
        }
    }
}
