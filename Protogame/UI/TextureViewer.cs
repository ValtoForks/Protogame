using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Protogame
{
    public class TextureViewer : IContainer
    {
        public IContainer[] Children { get { return new IContainer[0]; } }
        public IContainer Parent { get; set; }
        public int Order { get; set; }
        public bool Focused { get; set; }
        public TextureAsset Texture { get; set; }

        public TextureViewer()
        {
            this.Texture = null;
        }

        public void Update(ISkin skin, Rectangle layout, GameTime gameTime, ref bool stealFocus)
        {
        }

        public void Draw(IRenderContext context, ISkin skin, Rectangle layout)
        {
            skin.DrawTextureViewer(context, layout, this);
        }
    }
}

