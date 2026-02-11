using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002C3 RID: 707
	public class DebuggerEventDispatchingStrategy
	{
		// Token: 0x060033C0 RID: 13248 RVA: 0x000D9C48 File Offset: 0x000D7E48
		public bool CanDispatchEvent(EventBase evt)
		{
			return false;
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00014F70 File Offset: 0x00013170
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00014F73 File Offset: 0x00013173
		public void PostDispatch(EventBase evt, IPanel panel)
		{
		}
	}
}
