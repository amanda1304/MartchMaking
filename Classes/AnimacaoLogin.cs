using System;
using System.Drawing;
using System.Windows.Forms;

namespace YourNamespace
{
    public class AnimacaoLogin
    {
        private Timer _timer;
        private Panel pnl;
        private int _targetX;
        private int _speed;
        private bool _movingRight;

        public AnimacaoLogin()
        {
            _timer = new Timer();
            _timer.Interval = 20; // Quanto menor, mais suave a animação
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pnl == null) return;
            if (_movingRight)
            {
                pnl.Left += _speed;
                if (pnl.Left >= _targetX)
                {
                    pnl.Left = _targetX;
                    _timer.Stop();
                }
            }
            else
            {
                pnl.Left -= _speed;
                if (pnl.Left <= _targetX)
                {
                    pnl.Left = _targetX;
                    _timer.Stop();
                }
            }
            
        }

        public void MoverParaDireita(Panel panel, int distancia, int speed)
        {
            pnl = panel;
            _speed = speed;
            _movingRight = true;
            _targetX = panel.Left + distancia;
            _timer.Start();
        }

        public void MoverParaEsquerda(Panel panel, int distancia, int speed)
        {
            pnl = panel;
            _speed = speed;
            _movingRight = false;
            _targetX = panel.Left - distancia;
            _timer.Start();
        }
    }
}

