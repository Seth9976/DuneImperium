using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002BB RID: 699
	public static class IBindingExtensions
	{
		// Token: 0x060033BE RID: 13246 RVA: 0x000D9C24 File Offset: 0x000D7E24
		public static bool IsBound(IBindable control)
		{
			return ((control != null) ? control.binding : null) != null;
		}
	}
}
