using System;

namespace Unity.Properties
{
	// Token: 0x0200004B RID: 75
	public abstract class ConcreteTypeVisitor
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00002F81 File Offset: 0x00001181
		public void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
			this.VisitContainer<TContainer>(ref container);
		}
	}
}
