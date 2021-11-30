using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_TemplateMethod
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }

        protected int vida = 100;
        protected bool estamuerto = false;

        public void Atacar()
        {
            if (PuedeAtacar())
            {
                RealizarAtaque();
            }

        }
        public void RecibirDanio(int danio)
        {
            vida -= danio;
            if (vida <= 0)
            {
                Console.WriteLine("derrotado");
                estamuerto = true;
                vida = 0;
            }
            else
            {
                estamuerto = false;
                Console.WriteLine("Aún me queda " + vida + " de vida");
            }

        }
        public void GenerarAgente()
        {
            string agente;
            agente = $"{Nombre}: \nPerk: {Perk()} \nCategoría de Arma: {CategoriaArma()} \nRol: {Rol()}";
            Console.WriteLine(agente);
           
        }

        protected abstract bool PuedeAtacar();
        protected abstract void RealizarAtaque();
        protected abstract string Rol();
        protected abstract int AtaqueEspecial();
        protected abstract string Perk();
        protected abstract string CategoriaArma();



    }
}
