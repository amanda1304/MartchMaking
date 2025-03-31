using System;
using System.Windows.Forms;
using System.Drawing;


namespace Login_Register.Classes
{
    internal class AnimacaoLogin
    {
        private Timer _timer;
        private Panel Pnl;
        private int targetX;
        private int _speed;
        private bool _moveDireito;
        private int _posicaoInicial;

        public AnimacaoLogin()
        {

            _timer = new Timer();
            _timer.Interval = 7;
            _timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e) {
            if (Pnl == null) return;
            if (!_moveDireito)
            {
                Pnl.Left -= _speed;

                if (Pnl.Left >= _posicaoInicial)// Corrigido: Agora a condição é para alcançar o destino na esquerda
                {
                    Pnl.Left = _posicaoInicial;
                    _timer.Stop();
                }


            }
            else
            {
                Pnl.Left += _speed;
                if (Pnl.Left <= _posicaoInicial)
                {
                    Pnl.Left = _posicaoInicial;
                    _timer.Stop();
                }
            }
         }
        public void ConfigurarPainel(Panel Pnl)
        {
            this.Pnl = Pnl;
            _posicaoInicial = Pnl.Left;
        }
       
        public void MoverParaDireita( Panel Pnl, int distancia, int speed)
        {
            
            _moveDireito = true;
            _speed = speed;
            targetX = _posicaoInicial - distancia;
            _timer.Start();

        }
        public void MoverParaEsquerda(  Panel Pnl, int speed)
        {
            _moveDireito = false;
            _speed = speed;
            targetX = _posicaoInicial;
            _timer.Stop();

        }
    }

}
