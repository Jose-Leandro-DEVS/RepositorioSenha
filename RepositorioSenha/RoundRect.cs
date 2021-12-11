using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RepositorioSenha
{
  public static class RoundRect
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

      public static extern IntPtr CreateRoundRectRgn
      (
      int nLeftRect,
      int nTopRect,
      int RightRect,
      int nBottomRect,
      int nWidthEllipse,
      int nHeightEllipse
      );

        
    }
}
