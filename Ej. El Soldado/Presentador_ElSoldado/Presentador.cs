using Modelo_ElSoldado;

namespace Presentador_ElSoldado
{
    public class Presentador
    {
        //Atributos
        private readonly Soldado soldado;
        private readonly IView iview;
        
        public Presentador(IView iview)
        {
            this.soldado = new Soldado();
            this.iview = iview;
        }
        public void Disparar()
        {
            string disparo = soldado.dispararArma();
            iview.Show_text(disparo);
        }
        public void verArma()
        {
            string arma = soldado.verArmaActual();
            iview.Show_text(arma);
        }
        public void dejarArma()
        {
            iview.Show_text(soldado.dejarArma());
        }
        public void recojerArma(int opcionSeleccionada)
        {
            iview.Show_text(soldado.recogerArma(opcionSeleccionada));
        }
    }
}