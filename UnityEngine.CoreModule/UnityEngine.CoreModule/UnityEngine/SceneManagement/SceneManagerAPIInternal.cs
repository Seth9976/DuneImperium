using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001BE RID: 446
	public static class SceneManagerAPIInternal : Object
	{
		// Token: 0x06002069 RID: 8297 RVA: 0x0009006C File Offset: 0x0008E26C
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPIInternal()
		{
			Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr);
			SceneManagerAPIInternal.NativeMethodInfoPtr_GetNumScenesInBuildSettings_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100667698);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100667699);
			SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100667700);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100667701);
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected");
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000900FC File Offset: 0x0008E2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680140, XrefRangeEnd = 680142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumScenesInBuildSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_GetNumScenesInBuildSettings_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0009012C File Offset: 0x0008E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680142, XrefRangeEnd = 680144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0009019C File Offset: 0x0008E39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680144, XrefRangeEnd = 680146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0009021C File Offset: 0x0008E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680146, XrefRangeEnd = 680148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0000C514 File Offset: 0x0000A714
		public SceneManagerAPIInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0009028C File Offset: 0x0008E48C
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			Scene scene;
			SceneManagerAPIInternal.GetSceneByBuildIndex_Injected(buildIndex, out scene);
			return scene;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0000C51D File Offset: 0x0000A71D
		public static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
		{
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField(buildIndex, out ret);
		}

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_GetNumScenesInBuildSettings_Public_Static_Int32_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate GetSceneByBuildIndex_InjectedDelegateField;

		// Token: 0x02000888 RID: 2184
		// (Invoke) Token: 0x06003A0F RID: 14863
		private delegate void GetSceneByBuildIndex_InjectedDelegate(int buildIndex, [Out] IntPtr ret);
	}
}
