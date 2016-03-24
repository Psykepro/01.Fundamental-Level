namespace ReaperInvasion.UI
{
    using System.Collections.Generic;
    using System.Windows.Controls;

    using ReaperInvasion.GameObjects;

    public class Renderer
    {
        private readonly List<Reaper> reapers = new List<Reaper>();

        public Renderer(Canvas canvas, AssetLoader assetLoader)
        {
            this.Canvas = canvas;
            this.AssetLoader = assetLoader;
        }

        public AssetLoader AssetLoader { get; private set; }

        public Canvas Canvas { get; private set; }

        public void Render(int x, int y)
        {
            var reaper = this.ReaperFactory(x, y);
            var image = this.AssetLoader.GetImage(reaper.Type);

            Canvas.SetLeft(image, reaper.X);
            Canvas.SetTop(image, reaper.Y);

            this.Canvas.Children.Add(image);
        }

        /// <summary>
        /// The Flyweight Pattern.
        /// </summary>
        private Reaper ReaperFactory(int x, int y)
        {
            foreach (var reaper in this.reapers)
            {
                if (reaper.X == x && reaper.Y == y)
                {
                    return reaper;
                }
            }
            
            var newReaper = new Reaper(x, y);
            this.reapers.Add(newReaper);
            return newReaper;
        }
    }
}