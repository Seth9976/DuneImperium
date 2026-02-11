using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.AssetBundlePatching
{
	// Token: 0x0200000A RID: 10
	public static class AssetBundleUtility
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00002165 File Offset: 0x00000365
		public static void PatchAssetBundles(Il2CppReferenceArray<AssetBundle> bundles, Il2CppStringArray filenames)
		{
			AssetBundleUtility.PatchAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(bundles), IL2CPP.Il2CppObjectBaseToPtr(filenames));
		}

		// Token: 0x0400004E RID: 78
		private static readonly AssetBundleUtility.PatchAssetBundlesDelegate PatchAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundleUtility.PatchAssetBundlesDelegate>("UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility::PatchAssetBundles");

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000A2 RID: 162
		private delegate void PatchAssetBundlesDelegate(IntPtr bundles, IntPtr filenames);
	}
}
