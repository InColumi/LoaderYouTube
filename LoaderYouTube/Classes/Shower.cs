using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoaderYouTube.Classes
{
    static class Shower
    {
        public static async void Form(Form form, int delay = 40, double opasityEnd = 0.97)
        {
            double opasity = opasityEnd;
            for (double i = 0.1; form.Opacity < opasity; i += 0.01)
            {
                form.Opacity += i;
                await Task.Delay(delay);
            }
            form.Opacity = opasity;
        }
    }
}
