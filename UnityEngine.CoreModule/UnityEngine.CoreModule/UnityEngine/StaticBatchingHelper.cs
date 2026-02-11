using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x020002F4 RID: 756
	public struct StaticBatchingHelper
	{
		// Token: 0x06002D80 RID: 11648 RVA: 0x000120E6 File Offset: 0x000102E6
		public static void CombineMeshes(Il2CppReferenceArray<GameObject> gos, GameObject staticBatchRoot)
		{
			StaticBatchingHelper.CombineMeshesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(gos), IL2CPP.Il2CppObjectBaseToPtr(staticBatchRoot));
		}

		// Token: 0x0400291A RID: 10522
		private static readonly StaticBatchingHelper.CombineMeshesDelegate CombineMeshesDelegateField = IL2CPP.ResolveICall<StaticBatchingHelper.CombineMeshesDelegate>("UnityEngine.StaticBatchingHelper::CombineMeshes");

		// Token: 0x02000B52 RID: 2898
		// (Invoke) Token: 0x06003F99 RID: 16281
		private delegate void CombineMeshesDelegate(IntPtr gos, IntPtr staticBatchRoot);
	}
}
