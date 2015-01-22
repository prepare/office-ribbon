// *********************************
// Message from Original Author:
//
// 2008 Jose Menendez Poo
// Please give me credit if you use this code. It's all I ask.
// Contact me for more info: menendezpoo@gmail.com
// *********************************
//
// Original project from http://ribbon.codeplex.com/
// Continue to support and maintain by http://officeribbon.codeplex.com/


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace System.Windows.Forms
{
    /// <summary>
    /// Represents a collection of RibbonTab objects
    /// </summary>
    public sealed class RibbonTabCollection
           : System.Windows.Forms.Classes.Collections.RibbonCollectionBase<RibbonTab>
    {
        /// <summary>
        /// Creates a new RibbonTabCollection
        /// </summary>
        /// <param name="owner">|</param>
        /// <exception cref="AgrumentNullException">owner is null</exception>
        internal RibbonTabCollection(Ribbon owner)
           : base(owner)
        {
            if (owner == null) throw new ArgumentNullException("null");
        }

        internal override void SetOwner(RibbonTab item)
        {
           item.SetOwner(Owner);
        }

        internal override void ClearOwner(RibbonTab item)
        {
           item.ClearOwner();
        }

        internal override void UpdateRegions()
        {
            try
            {
                Owner.OnRegionsChanged();
            }
            catch
            {
            }
        }
    }
}
