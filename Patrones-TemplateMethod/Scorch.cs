using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_TemplateMethod
{
    class Scorch : Personaje
    {

        protected override int AtaqueEspecial()
        {
            return 20;
        }

        protected override string CategoriaArma()
        {
            return "SMG";
        }

        protected override string Perk()
        {
            return "Recarga Rápida";
        }

        protected override bool PuedeAtacar()
        {
            if (vida >30)
            {

                return true;
            }
            else
            {
                Console.WriteLine("Debe recuperar mas vida antes de poder atacar");
                return false;
            }
        }

        protected override void RealizarAtaque()
        {
            Console.WriteLine("Atacando!");
             AtaqueEspecial();
        }

        protected override string Rol()
        {
            return "duelista";
        }
    }
}
