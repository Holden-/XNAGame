using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XnaApp.Objetos
{
    public class ObjetoJogo
    {
        // Velocidade do objeto
        public Vector2 Velocidade { get; set; }
        // Posição do objeto
        public Vector2 Posicao { get; set; }
        // Áreas de colisão do objeto
        public List<Rectangle> AreaColisao { get; set; }
        // Imagem do objeto
        public Texture2D Imagem { get; set; }
        // Cada quadro da imagem no arquivo: RectangleSource
        public Rectangle RecSrc { get; set; }
        // Posição do quadro na tela: RectangleDestination
        public Rectangle RecDst { get; set; }
        // Número de quadros da imagem
        public int ImagemQtd { get; set; }
        // Quadro atualmente selecionado
        public int ImagemNum { get; set; }

        public ObjetoJogo()
        {
            // Instancia áreas de colisão do objeto
            AreaColisao = new List<Rectangle>();
        }
        
        public ObjetoJogo(Vector2 Position) : this()
        {
            this.Posicao = Position;
        }

        public ObjetoJogo(Vector2 Position, Vector2 Velocidade) : this()
        {
            // Posição e velocidade iniciais
            this.Posicao = Position;
            this.Velocidade = Velocidade;
        }

        public bool VerificarColisao(Rectangle rec)
        {
            // Verifica se houve colisão com outro objeto
            bool result = false;
            foreach(Rectangle r in AreaColisao)
                if (r.Intersects(rec))
                {
                    result = true;
                    break;
                }
            return result;
        }
    }
}
