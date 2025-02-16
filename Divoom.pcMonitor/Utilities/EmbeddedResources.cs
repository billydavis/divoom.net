using System.Reflection;

namespace pcMonitor.Utilities;

public class EmbeddedResources
{

    public static Image GetImage(string name)
    {
        name = "pcMonitor.Resources." + name;

        var names =
            Assembly.GetExecutingAssembly().GetManifestResourceNames();

        foreach (var n in names)
        {
            if (n.Replace('\\', '.') != name) continue;
            using var stream = Assembly.GetExecutingAssembly().
                GetManifestResourceStream(n);

            if (stream == null) continue;

            // "You must keep the stream open for the lifetime of the Image."
            var image = Image.FromStream(stream);

            // so we just create a copy of the image 
            var bitmap = new Bitmap(image);

            // and dispose it right here
            image.Dispose();

            return bitmap;
        }

        return new Bitmap(1, 1);
    }

    public static Icon GetIcon(string name)
    {
        name = "pcMonitor.Resources." + name;

        string[] names =
            Assembly.GetExecutingAssembly().GetManifestResourceNames();
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i].Replace('\\', '.') == name)
            {
                using (Stream stream = Assembly.GetExecutingAssembly().
                           GetManifestResourceStream(names[i]))
                {
                    return new Icon(stream);
                }
            }
        }

        return null;
    }

}