using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x02000006 RID: 6
	public static class NavMeshBuilder
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000221B File Offset: 0x0000041B
		public static void Cancel(NavMeshData data)
		{
			NavMeshBuilder.CancelDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x0400002E RID: 46
		private static readonly NavMeshBuilder.CancelDelegate CancelDelegateField = IL2CPP.ResolveICall<NavMeshBuilder.CancelDelegate>("UnityEngine.AI.NavMeshBuilder::Cancel");

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000106 RID: 262
		private delegate void CancelDelegate(IntPtr data);
	}
}
