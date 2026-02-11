using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200030E RID: 782
	public class UnityEventQueueSystem
	{
		// Token: 0x06002DD4 RID: 11732 RVA: 0x00012432 File Offset: 0x00010632
		public static string GenerateEventIdForPayload(string eventPayloadName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x0001243F File Offset: 0x0001063F
		public static IntPtr GetGlobalEventQueue()
		{
			return UnityEventQueueSystem.GetGlobalEventQueueDelegateField();
		}

		// Token: 0x0400294E RID: 10574
		private static readonly UnityEventQueueSystem.GetGlobalEventQueueDelegate GetGlobalEventQueueDelegateField = IL2CPP.ResolveICall<UnityEventQueueSystem.GetGlobalEventQueueDelegate>("UnityEngine.UnityEventQueueSystem::GetGlobalEventQueue");

		// Token: 0x02000B6D RID: 2925
		// (Invoke) Token: 0x06003FCF RID: 16335
		private delegate IntPtr GetGlobalEventQueueDelegate();
	}
}
