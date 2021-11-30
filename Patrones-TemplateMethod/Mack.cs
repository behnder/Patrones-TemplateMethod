using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_TemplateMethod
{
    class Mack : Personaje
    {

        protected override int AtaqueEspecial()
        {
            return 22;
        }

        protected override string CategoriaArma()
        {
            return "LMG";
        }

        protected override string Perk()
        {
            return "Recarga Automática";
        }

        protected override bool PuedeAtacar()
        {
            if (vida > 50)
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
            return "Defensor";
        }
    }
}
