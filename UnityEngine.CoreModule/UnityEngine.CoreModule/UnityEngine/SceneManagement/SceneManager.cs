using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Events;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001C0 RID: 448
	public class SceneManager : Object
	{
		// Token: 0x06002080 RID: 8320 RVA: 0x00090638 File Offset: 0x0008E838
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_s_AllowLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "s_AllowLoadScene");
			SceneManager.NativeFieldInfoPtr_sceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneLoaded");
			SceneManager.NativeFieldInfoPtr_sceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneUnloaded");
			SceneManager.NativeFieldInfoPtr_activeSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "activeSceneChanged");
			SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667710);
			SceneManager.NativeMethodInfoPtr_get_sceneCountInBuildSettings_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667711);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667712);
			SceneManager.NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667713);
			SceneManager.NativeMethodInfoPtr_GetSceneByName_Public_Static_Scene_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667714);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667715);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667716);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667717);
			SceneManager.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667718);
			SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667719);
			SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667720);
			SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667721);
			SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667722);
			SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667723);
			SceneManager.NativeMethodInfoPtr_add_activeSceneChanged_Public_Static_add_Void_UnityAction_2_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667724);
			SceneManager.NativeMethodInfoPtr_remove_activeSceneChanged_Public_Static_rem_Void_UnityAction_2_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667725);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667726);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667727);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667728);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667729);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667730);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667731);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667732);
			SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667733);
			SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667734);
			SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667735);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667737);
			SceneManager.NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667738);
			SceneManager.NativeMethodInfoPtr_GetSceneByName_Injected_Private_Static_Void_String_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667739);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667740);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_AsyncOperation_byref_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667741);
			SceneManager.get_loadedSceneCountDelegateField = IL2CPP.ResolveICall<SceneManager.get_loadedSceneCountDelegate>("UnityEngine.SceneManagement.SceneManager::get_loadedSceneCount");
			SceneManager.CanSetAsActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CanSetAsActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CanSetAsActiveScene_Injected");
			SceneManager.GetSceneByPath_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByPath_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected");
			SceneManager.CreateScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CreateScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CreateScene_Injected");
			SceneManager.UnloadSceneInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected");
			SceneManager.MergeScenes_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MergeScenes_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected");
			SceneManager.MoveGameObjectToScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MoveGameObjectToScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectToScene_Injected");
			SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectsToSceneByInstanceId_Injected");
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0009099C File Offset: 0x0008EB9C
		public unsafe static int sceneCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 680180, RefRangeEnd = 680185, XrefRangeStart = 680178, XrefRangeEnd = 680180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x000909CC File Offset: 0x0008EBCC
		public unsafe static int sceneCountInBuildSettings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 680190, RefRangeEnd = 680192, XrefRangeStart = 680185, XrefRangeEnd = 680190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_sceneCountInBuildSettings_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x000909FC File Offset: 0x0008EBFC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 680197, RefRangeEnd = 680205, XrefRangeStart = 680192, XrefRangeEnd = 680197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetActiveScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00090A2C File Offset: 0x0008EC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680205, XrefRangeEnd = 680210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetActiveScene(Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00090A6C File Offset: 0x0008EC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680210, XrefRangeEnd = 680215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetSceneByName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneByName_Public_Static_Scene_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00090AB0 File Offset: 0x0008ECB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 680220, RefRangeEnd = 680226, XrefRangeStart = 680215, XrefRangeEnd = 680220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetSceneAt(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00090AF0 File Offset: 0x0008ECF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680226, XrefRangeEnd = 680231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00090B40 File Offset: 0x0008ED40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 680240, RefRangeEnd = 680243, XrefRangeStart = 680231, XrefRangeEnd = 680240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00090BB0 File Offset: 0x0008EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680243, XrefRangeEnd = 680252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00090C30 File Offset: 0x0008EE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680252, XrefRangeEnd = 680257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref async;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00090C70 File Offset: 0x0008EE70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 680270, RefRangeEnd = 680276, XrefRangeStart = 680257, XrefRangeEnd = 680270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 680289, RefRangeEnd = 680295, XrefRangeStart = 680276, XrefRangeEnd = 680289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00090CE0 File Offset: 0x0008EEE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 680308, RefRangeEnd = 680311, XrefRangeStart = 680295, XrefRangeEnd = 680308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00090D18 File Offset: 0x0008EF18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680324, RefRangeEnd = 680325, XrefRangeStart = 680311, XrefRangeEnd = 680324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00090D50 File Offset: 0x0008EF50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 680338, RefRangeEnd = 680340, XrefRangeStart = 680325, XrefRangeEnd = 680338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_activeSceneChanged_Public_Static_add_Void_UnityAction_2_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00090D88 File Offset: 0x0008EF88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 680353, RefRangeEnd = 680355, XrefRangeStart = 680340, XrefRangeEnd = 680353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_activeSceneChanged_Public_Static_rem_Void_UnityAction_2_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00090DC0 File Offset: 0x0008EFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680359, RefRangeEnd = 680360, XrefRangeStart = 680355, XrefRangeEnd = 680359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(string sceneName, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00090E04 File Offset: 0x0008F004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 680364, RefRangeEnd = 680366, XrefRangeStart = 680360, XrefRangeEnd = 680364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00090E3C File Offset: 0x0008F03C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 680377, RefRangeEnd = 680379, XrefRangeStart = 680366, XrefRangeEnd = 680377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00090E8C File Offset: 0x0008F08C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680386, RefRangeEnd = 680387, XrefRangeStart = 680379, XrefRangeEnd = 680386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00090EE0 File Offset: 0x0008F0E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 680391, RefRangeEnd = 680394, XrefRangeStart = 680387, XrefRangeEnd = 680391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00090F34 File Offset: 0x0008F134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680394, XrefRangeEnd = 680405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00090F78 File Offset: 0x0008F178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680413, RefRangeEnd = 680414, XrefRangeStart = 680405, XrefRangeEnd = 680413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_UnloadSceneOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00090FC8 File Offset: 0x0008F1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680414, XrefRangeEnd = 680420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00091008 File Offset: 0x0008F208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680420, XrefRangeEnd = 680426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneUnloaded(Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0009103C File Offset: 0x0008F23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680426, XrefRangeEnd = 680432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref previousActiveScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newActiveScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0009107C File Offset: 0x0008F27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680432, XrefRangeEnd = 680434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetActiveScene_Injected(out Scene ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000910B0 File Offset: 0x0008F2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680434, XrefRangeEnd = 680436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetActiveScene_Injected(ref Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000910F0 File Offset: 0x0008F2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680436, XrefRangeEnd = 680438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSceneByName_Injected(string name, out Scene ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneByName_Injected_Private_Static_Void_String_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00091134 File Offset: 0x0008F334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680438, XrefRangeEnd = 680440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSceneAt_Injected(int index, out Scene ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00091174 File Offset: 0x0008F374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680440, XrefRangeEnd = 680442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_AsyncOperation_byref_Scene_UnloadSceneOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0000C568 File Offset: 0x0000A768
		public SceneManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000911C4 File Offset: 0x0008F3C4
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x0000C571 File Offset: 0x0000A771
		public unsafe static bool s_AllowLoadScene
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000911E0 File Offset: 0x0008F3E0
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0000C57F File Offset: 0x0000A77F
		public unsafe static UnityEngine.Events.UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, LoadSceneMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00091208 File Offset: 0x0008F408
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0000C591 File Offset: 0x0000A791
		public unsafe static UnityEngine.Events.UnityAction<Scene> sceneUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00091230 File Offset: 0x0008F430
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0000C5A3 File Offset: 0x0000A7A3
		public unsafe static UnityEngine.Events.UnityAction<Scene, Scene> activeSceneChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0000C5B5 File Offset: 0x0000A7B5
		public static int loadedSceneCount
		{
			get
			{
				return SceneManager.get_loadedSceneCountDelegateField();
			}
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0000C5C1 File Offset: 0x0000A7C1
		public static bool CanSetAsActiveScene(Scene scene)
		{
			return SceneManager.CanSetAsActiveScene_Injected(ref scene);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00091258 File Offset: 0x0008F458
		public static Scene GetSceneByPath(string scenePath)
		{
			Scene scene;
			SceneManager.GetSceneByPath_Injected(scenePath, out scene);
			return scene;
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00091270 File Offset: 0x0008F470
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00091290 File Offset: 0x0008F490
		public static Scene CreateScene(string sceneName, CreateSceneParameters parameters)
		{
			Scene scene;
			SceneManager.CreateScene_Injected(sceneName, ref parameters, out scene);
			return scene;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0000C5CA File Offset: 0x0000A7CA
		public static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_Injected(ref scene, options);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		public static void MergeScenes(Scene sourceScene, Scene destinationScene)
		{
			SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0000C5DF File Offset: 0x0000A7DF
		public static void MoveGameObjectToScene(GameObject go, Scene scene)
		{
			SceneManager.MoveGameObjectToScene_Injected(go, ref scene);
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0000C5E9 File Offset: 0x0000A7E9
		public static void MoveGameObjectsToSceneByInstanceId(IntPtr instanceIds, int instanceCount, Scene scene)
		{
			SceneManager.MoveGameObjectsToSceneByInstanceId_Injected(instanceIds, instanceCount, ref scene);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000912A8 File Offset: 0x0008F4A8
		public static void MoveGameObjectsToScene(Unity.Collections.NativeArray<int> instanceIDs, Scene scene)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = instanceIDs.Length == 0;
			if (!flag2)
			{
				SceneManager.MoveGameObjectsToSceneByInstanceId((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, scene);
			}
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		public static Il2CppStructArray<Scene> GetAllScenes()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00091300 File Offset: 0x0008F500
		public static Scene CreateScene(string sceneName)
		{
			CreateSceneParameters createSceneParameters = new CreateSceneParameters(LocalPhysicsMode.None);
			return SceneManager.CreateScene(sceneName, createSceneParameters);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00091324 File Offset: 0x0008F524
		public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00091344 File Offset: 0x0008F544
		public static void LoadScene(int sceneBuildIndex)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(LoadSceneMode.Single);
			SceneManager.LoadScene(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00091364 File Offset: 0x0008F564
		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, true);
			return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0009138C File Offset: 0x0008F58C
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000913B0 File Offset: 0x0008F5B0
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x000913D4 File Offset: 0x0008F5D4
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, false);
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000913F0 File Offset: 0x0008F5F0
		public static AsyncOperation LoadSceneAsync(string sceneName)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneName, loadSceneParameters);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00091414 File Offset: 0x0008F614
		public static bool UnloadScene(Scene scene)
		{
			return SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00091430 File Offset: 0x0008F630
		public static bool UnloadScene(int sceneBuildIndex)
		{
			bool flag;
			SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out flag);
			return flag;
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00091454 File Offset: 0x0008F654
		public static bool UnloadScene(string sceneName)
		{
			bool flag;
			SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out flag);
			return flag;
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00091474 File Offset: 0x0008F674
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00091498 File Offset: 0x0008F698
		public static AsyncOperation UnloadSceneAsync(Scene scene)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x000914B4 File Offset: 0x0008F6B4
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out flag);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000914D8 File Offset: 0x0008F6D8
		public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out flag);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0000C601 File Offset: 0x0000A801
		public static bool CanSetAsActiveScene_Injected(ref Scene scene)
		{
			return SceneManager.CanSetAsActiveScene_InjectedDelegateField(ref scene);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0000C60E File Offset: 0x0000A80E
		public static void GetSceneByPath_Injected(string scenePath, out Scene ret)
		{
			SceneManager.GetSceneByPath_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath), out ret);
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0000C621 File Offset: 0x0000A821
		public static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret)
		{
			SceneManager.CreateScene_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(sceneName), ref parameters, out ret);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0000C635 File Offset: 0x0000A835
		public static bool UnloadSceneInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_InjectedDelegateField(ref scene, options);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x0000C643 File Offset: 0x0000A843
		public static void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene)
		{
			SceneManager.MergeScenes_InjectedDelegateField(ref sourceScene, ref destinationScene);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0000C651 File Offset: 0x0000A851
		public static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene)
		{
			SceneManager.MoveGameObjectToScene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), ref scene);
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0000C664 File Offset: 0x0000A864
		public static void MoveGameObjectsToSceneByInstanceId_Injected(IntPtr instanceIds, int instanceCount, ref Scene scene)
		{
			SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegateField(instanceIds, instanceCount, ref scene);
		}

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_s_AllowLoadScene;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_sceneLoaded;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_sceneUnloaded;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_activeSceneChanged;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCountInBuildSettings_Public_Static_get_Int32_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneByName_Public_Static_Scene_String_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_add_activeSceneChanged_Public_Static_add_Void_UnityAction_2_Scene_Scene_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_remove_activeSceneChanged_Public_Static_rem_Void_UnityAction_2_Scene_Scene_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_LoadSceneMode_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_UnloadSceneOptions_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneByName_Injected_Private_Static_Void_String_byref_Scene_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_AsyncOperation_byref_Scene_UnloadSceneOptions_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly SceneManager.get_loadedSceneCountDelegate get_loadedSceneCountDelegateField;

		// Token: 0x04001C16 RID: 7190
		private static readonly SceneManager.CanSetAsActiveScene_InjectedDelegate CanSetAsActiveScene_InjectedDelegateField;

		// Token: 0x04001C17 RID: 7191
		private static readonly SceneManager.GetSceneByPath_InjectedDelegate GetSceneByPath_InjectedDelegateField;

		// Token: 0x04001C18 RID: 7192
		private static readonly SceneManager.CreateScene_InjectedDelegate CreateScene_InjectedDelegateField;

		// Token: 0x04001C19 RID: 7193
		private static readonly SceneManager.UnloadSceneInternal_InjectedDelegate UnloadSceneInternal_InjectedDelegateField;

		// Token: 0x04001C1A RID: 7194
		private static readonly SceneManager.MergeScenes_InjectedDelegate MergeScenes_InjectedDelegateField;

		// Token: 0x04001C1B RID: 7195
		private static readonly SceneManager.MoveGameObjectToScene_InjectedDelegate MoveGameObjectToScene_InjectedDelegateField;

		// Token: 0x04001C1C RID: 7196
		private static readonly SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegate MoveGameObjectsToSceneByInstanceId_InjectedDelegateField;

		// Token: 0x02000889 RID: 2185
		// (Invoke) Token: 0x06003A11 RID: 14865
		private delegate int get_loadedSceneCountDelegate();

		// Token: 0x0200088A RID: 2186
		// (Invoke) Token: 0x06003A13 RID: 14867
		private delegate bool CanSetAsActiveScene_InjectedDelegate(IntPtr scene);

		// Token: 0x0200088B RID: 2187
		// (Invoke) Token: 0x06003A15 RID: 14869
		private delegate void GetSceneByPath_InjectedDelegate(IntPtr scenePath, [Out] IntPtr ret);

		// Token: 0x0200088C RID: 2188
		// (Invoke) Token: 0x06003A17 RID: 14871
		private delegate void CreateScene_InjectedDelegate(IntPtr sceneName, IntPtr parameters, [Out] IntPtr ret);

		// Token: 0x0200088D RID: 2189
		// (Invoke) Token: 0x06003A19 RID: 14873
		private delegate bool UnloadSceneInternal_InjectedDelegate(IntPtr scene, UnloadSceneOptions options);

		// Token: 0x0200088E RID: 2190
		// (Invoke) Token: 0x06003A1B RID: 14875
		private delegate void MergeScenes_InjectedDelegate(IntPtr sourceScene, IntPtr destinationScene);

		// Token: 0x0200088F RID: 2191
		// (Invoke) Token: 0x06003A1D RID: 14877
		private delegate void MoveGameObjectToScene_InjectedDelegate(IntPtr go, IntPtr scene);

		// Token: 0x02000890 RID: 2192
		// (Invoke) Token: 0x06003A1F RID: 14879
		private delegate void MoveGameObjectsToSceneByInstanceId_InjectedDelegate(IntPtr instanceIds, int instanceCount, IntPtr scene);
	}
}
