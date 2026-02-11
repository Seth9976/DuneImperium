using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001C5 RID: 453
	public static class SceneUtility : Object
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x000915C8 File Offset: 0x0008F7C8
		// Note: this type is marked as 'beforefieldinit'.
		static SceneUtility()
		{
			Il2CppClassPointerStore<SceneUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr);
			SceneUtility.NativeMethodInfoPtr_GetScenePathByBuildIndex_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneUtility>.NativeClassPtr, 100667743);
			SceneUtility.GetBuildIndexByScenePathDelegateField = IL2CPP.ResolveICall<SceneUtility.GetBuildIndexByScenePathDelegate>("UnityEngine.SceneManagement.SceneUtility::GetBuildIndexByScenePath");
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0009161C File Offset: 0x0008F81C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 680454, RefRangeEnd = 680456, XrefRangeStart = 680452, XrefRangeEnd = 680454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetScenePathByBuildIndex(int buildIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buildIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneUtility.NativeMethodInfoPtr_GetScenePathByBuildIndex_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0000C699 File Offset: 0x0000A899
		public SceneUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0000C6A2 File Offset: 0x0000A8A2
		public static int GetBuildIndexByScenePath(string scenePath)
		{
			return SceneUtility.GetBuildIndexByScenePathDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath));
		}

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_GetScenePathByBuildIndex_Public_Static_String_Int32_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly SceneUtility.GetBuildIndexByScenePathDelegate GetBuildIndexByScenePathDelegateField;

		// Token: 0x02000891 RID: 2193
		// (Invoke) Token: 0x06003A21 RID: 14881
		private delegate int GetBuildIndexByScenePathDelegate(IntPtr scenePath);
	}
}
