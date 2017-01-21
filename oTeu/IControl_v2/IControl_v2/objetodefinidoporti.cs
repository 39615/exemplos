using System;

namespace IControl_v2
{
    public class objetodefinidoporti
    {
        private Action ok;

        public objetodefinidoporti(Action ok)
        {
            this.ok = ok;
        }

        public void sair()
        {
            ok();
        }

        public void showBox()
        {

        }
    }
}