using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Components
{
    public class MainButton: Button
    {

            public MainButton()
            {
                this.BackColor = ColorTranslator.FromHtml(Resources.LayoutStandards.PrimaryColor);
                this.ForeColor = Color.White;
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderSize = 0;
                this.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(Resources.LayoutStandards.SecondaryColor);
            }

            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
            }
        }

   }
