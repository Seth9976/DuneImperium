using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002C8 RID: 712
	public class EventDebuggerDefaultActionTrace : EventDebuggerTrace
	{
		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x0001529C File Offset: 0x0001349C
		public PropagationPhase phase
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x000D9F18 File Offset: 0x000D8118
		public string targetName
		{
			get
			{
				return base.eventBase.target.GetType().FullName;
			}
		}
	}
}
