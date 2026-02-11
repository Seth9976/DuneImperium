using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001BF RID: 447
	public class SceneManagerAPI : Object
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x000902A4 File Offset: 0x0008E4A4
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPI()
		{
			Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr);
			SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "s_DefaultAPI");
			SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
			SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667702);
			SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667703);
			SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667704);
			SceneManagerAPI.NativeMethodInfoPtr_GetNumScenesInBuildSettings_FamOrAssem_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667705);
			SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667706);
			SceneManagerAPI.NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667707);
			SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667708);
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00090388 File Offset: 0x0008E588
		public unsafe static SceneManagerAPI ActiveAPI
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 680158, RefRangeEnd = 680163, XrefRangeStart = 680148, XrefRangeEnd = 680158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr3) : null;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x000903BC File Offset: 0x0008E5BC
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x0000C558 File Offset: 0x0000A758
		public unsafe static SceneManagerAPI overrideAPI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680163, XrefRangeEnd = 680167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr3) : null;
			}
			set
			{
				SceneManagerAPI._overrideAPI_k__BackingField = value;
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000903F0 File Offset: 0x0008E5F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManagerAPI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x0009042C File Offset: 0x0008E62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetNumScenesInBuildSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_GetNumScenesInBuildSettings_FamOrAssem_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00090474 File Offset: 0x0008E674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680167, XrefRangeEnd = 680169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000904FC File Offset: 0x0008E6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680169, XrefRangeEnd = 680178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00090590 File Offset: 0x0008E790
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mustLoadAsync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0000C52B File Offset: 0x0000A72B
		public SceneManagerAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x000905E8 File Offset: 0x0008E7E8
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x0000C534 File Offset: 0x0000A734
		public unsafe static SceneManagerAPI s_DefaultAPI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00090610 File Offset: 0x0008E810
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x0000C546 File Offset: 0x0000A746
		public unsafe static SceneManagerAPI _overrideAPI_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x0000C560 File Offset: 0x0000A760
		public virtual Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPIInternal.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAPI;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_GetNumScenesInBuildSettings_FamOrAssem_Virtual_New_Int32_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0;
	}
}
