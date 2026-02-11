using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000044 RID: 68
	public class SceneProvider : Object
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00011ED4 File Offset: 0x000100D4
		// Note: this type is marked as 'beforefieldinit'.
		static SceneProvider()
		{
			Il2CppClassPointerStore<SceneProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "SceneProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr);
			SceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, 100663852);
			SceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, 100663853);
			SceneProvider.NativeMethodInfoPtr_ReleaseScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, 100663854);
			SceneProvider.NativeMethodInfoPtr_UnityEngine_ResourceManagement_ResourceProviders_ISceneProvider2_ReleaseScene_Private_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, 100663855);
			SceneProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, 100663856);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00011F68 File Offset: 0x00010168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141162, XrefRangeEnd = 1141164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneMode_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00011FEC File Offset: 0x000101EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1141207, RefRangeEnd = 1141208, XrefRangeStart = 1141164, XrefRangeEnd = 1141207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.NativeMethodInfoPtr_ProvideScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneParameters_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00012070 File Offset: 0x00010270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141208, XrefRangeEnd = 1141211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.NativeMethodInfoPtr_ReleaseScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000120D0 File Offset: 0x000102D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141211, XrefRangeEnd = 1141231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> UnityEngine_ResourceManagement_ResourceProviders_ISceneProvider2_ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unloadOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.NativeMethodInfoPtr_UnityEngine_ResourceManagement_ResourceProviders_ISceneProvider2_ReleaseScene_Private_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00012140 File Offset: 0x00010340
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003586 File Offset: 0x00001786
		public SceneProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_ProvideScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_ProvideScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_IResourceLocation_LoadSceneParameters_Boolean_Int32_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseScene_Public_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_ResourceProviders_ISceneProvider2_ReleaseScene_Private_Virtual_Final_New_AsyncOperationHandle_1_SceneInstance_ResourceManager_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000089 RID: 137
		public class SceneOp : AsyncOperationBase<SceneInstance>
		{
			// Token: 0x06000696 RID: 1686 RVA: 0x0001F03C File Offset: 0x0001D23C
			// Note: this type is marked as 'beforefieldinit'.
			static SceneOp()
			{
				Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, "SceneOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr);
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_ActivateOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_ActivateOnLoad");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_Inst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_Inst");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_Location");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_LoadSceneParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_LoadSceneParameters");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_Priority");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_DepOp");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_ResourceManager");
				SceneProvider.SceneOp.NativeFieldInfoPtr_m_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, "m_provider");
				SceneProvider.SceneOp.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_ISceneProvider2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663857);
				SceneProvider.SceneOp.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663858);
				SceneProvider.SceneOp.NativeMethodInfoPtr_Init_Public_Void_IResourceLocation_LoadSceneMode_Boolean_Int32_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663859);
				SceneProvider.SceneOp.NativeMethodInfoPtr_Init_Public_Void_IResourceLocation_LoadSceneParameters_Boolean_Int32_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663860);
				SceneProvider.SceneOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663861);
				SceneProvider.SceneOp.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663862);
				SceneProvider.SceneOp.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663863);
				SceneProvider.SceneOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663864);
				SceneProvider.SceneOp.NativeMethodInfoPtr_InternalLoadScene_Internal_SceneInstance_IResourceLocation_Boolean_LoadSceneParameters_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663865);
				SceneProvider.SceneOp.NativeMethodInfoPtr_InternalLoad_Private_AsyncOperation_String_Boolean_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663866);
				SceneProvider.SceneOp.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663867);
				SceneProvider.SceneOp.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663868);
				SceneProvider.SceneOp.NativeMethodInfoPtr_UnityEngine_ResourceManagement_IUpdateReceiver_Update_Private_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr, 100663869);
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x0001F20C File Offset: 0x0001D40C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140897, XrefRangeEnd = 1140902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SceneOp(ResourceManager rm, ISceneProvider2 provider)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneProvider.SceneOp>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.SceneOp.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_ISceneProvider2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000698 RID: 1688 RVA: 0x0001F26C File Offset: 0x0001D46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140902, XrefRangeEnd = 1140909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DownloadStatus GetDownloadStatus(HashSet<Object> visited)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000699 RID: 1689 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140909, XrefRangeEnd = 1140919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneMode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.SceneOp.NativeMethodInfoPtr_Init_Public_Void_IResourceLocation_LoadSceneMode_Boolean_Int32_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x0001F348 File Offset: 0x0001D548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140919, XrefRangeEnd = 1140928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.SceneOp.NativeMethodInfoPtr_Init_Public_Void_IResourceLocation_LoadSceneParameters_Boolean_Int32_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x0001F3CC File Offset: 0x0001D5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140928, XrefRangeEnd = 1140961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x0001F414 File Offset: 0x0001D614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140961, XrefRangeEnd = 1140970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GetDependencies(List<AsyncOperationHandle> deps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001F464 File Offset: 0x0001D664
			public unsafe override string DebugName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140970, XrefRangeEnd = 1140984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600069E RID: 1694 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140984, XrefRangeEnd = 1141053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600069F RID: 1695 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141053, XrefRangeEnd = 1141069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingFromBundle;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.SceneOp.NativeMethodInfoPtr_InternalLoadScene_Internal_SceneInstance_IResourceLocation_Boolean_LoadSceneParameters_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SceneInstance(intPtr);
			}

			// Token: 0x060006A0 RID: 1696 RVA: 0x0001F564 File Offset: 0x0001D764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141069, XrefRangeEnd = 1141073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingFromBundle;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.SceneOp.NativeMethodInfoPtr_InternalLoad_Private_AsyncOperation_String_Boolean_LoadSceneParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141073, XrefRangeEnd = 1141092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Destroy()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001F60C File Offset: 0x0001D80C
			public unsafe override float Progress
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141092, XrefRangeEnd = 1141097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.SceneOp.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x0001F654 File Offset: 0x0001D854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141097, XrefRangeEnd = 1141105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void UnityEngine_ResourceManagement_IUpdateReceiver_Update(float unscaledDeltaTime)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref unscaledDeltaTime;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.SceneOp.NativeMethodInfoPtr_UnityEngine_ResourceManagement_IUpdateReceiver_Update_Private_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00004851 File Offset: 0x00002A51
			public SceneOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0001F694 File Offset: 0x0001D894
			// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0000485A File Offset: 0x00002A5A
			public unsafe bool m_ActivateOnLoad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_ActivateOnLoad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_ActivateOnLoad)) = value;
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0001F6BC File Offset: 0x0001D8BC
			// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00004875 File Offset: 0x00002A75
			public SceneInstance m_Inst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_Inst);
					return new SceneInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_Inst), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001F6 RID: 502
			// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001F6EC File Offset: 0x0001D8EC
			// (set) Token: 0x060006AA RID: 1706 RVA: 0x000048A3 File Offset: 0x00002AA3
			public unsafe IResourceLocation m_Location
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_Location);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001F7 RID: 503
			// (get) Token: 0x060006AB RID: 1707 RVA: 0x0001F71C File Offset: 0x0001D91C
			// (set) Token: 0x060006AC RID: 1708 RVA: 0x000048C2 File Offset: 0x00002AC2
			public unsafe LoadSceneParameters m_LoadSceneParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_LoadSceneParameters);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_LoadSceneParameters)) = value;
				}
			}

			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001F744 File Offset: 0x0001D944
			// (set) Token: 0x060006AE RID: 1710 RVA: 0x000048DD File Offset: 0x00002ADD
			public unsafe int m_Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_Priority)) = value;
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x060006AF RID: 1711 RVA: 0x0001F76C File Offset: 0x0001D96C
			// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000048F8 File Offset: 0x00002AF8
			public AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_DepOp);
					return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001F79C File Offset: 0x0001D99C
			// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00004926 File Offset: 0x00002B26
			public unsafe ResourceManager m_ResourceManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_ResourceManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001F7CC File Offset: 0x0001D9CC
			// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00004945 File Offset: 0x00002B45
			public unsafe ISceneProvider2 m_provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISceneProvider2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.SceneOp.NativeFieldInfoPtr_m_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004AE RID: 1198
			private static readonly IntPtr NativeFieldInfoPtr_m_ActivateOnLoad;

			// Token: 0x040004AF RID: 1199
			private static readonly IntPtr NativeFieldInfoPtr_m_Inst;

			// Token: 0x040004B0 RID: 1200
			private static readonly IntPtr NativeFieldInfoPtr_m_Location;

			// Token: 0x040004B1 RID: 1201
			private static readonly IntPtr NativeFieldInfoPtr_m_LoadSceneParameters;

			// Token: 0x040004B2 RID: 1202
			private static readonly IntPtr NativeFieldInfoPtr_m_Priority;

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

			// Token: 0x040004B5 RID: 1205
			private static readonly IntPtr NativeFieldInfoPtr_m_provider;

			// Token: 0x040004B6 RID: 1206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_ISceneProvider2_0;

			// Token: 0x040004B7 RID: 1207
			private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0;

			// Token: 0x040004B8 RID: 1208
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_IResourceLocation_LoadSceneMode_Boolean_Int32_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

			// Token: 0x040004B9 RID: 1209
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_IResourceLocation_LoadSceneParameters_Boolean_Int32_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

			// Token: 0x040004BA RID: 1210
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040004BB RID: 1211
			private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

			// Token: 0x040004BC RID: 1212
			private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

			// Token: 0x040004BD RID: 1213
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040004BE RID: 1214
			private static readonly IntPtr NativeMethodInfoPtr_InternalLoadScene_Internal_SceneInstance_IResourceLocation_Boolean_LoadSceneParameters_Boolean_Int32_0;

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeMethodInfoPtr_InternalLoad_Private_AsyncOperation_String_Boolean_LoadSceneParameters_0;

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_IUpdateReceiver_Update_Private_Virtual_Final_New_Void_Single_0;
		}

		// Token: 0x0200008A RID: 138
		public class UnloadSceneOp : AsyncOperationBase<SceneInstance>
		{
			// Token: 0x060006B5 RID: 1717 RVA: 0x0001F7FC File Offset: 0x0001D9FC
			// Note: this type is marked as 'beforefieldinit'.
			static UnloadSceneOp()
			{
				Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneProvider>.NativeClassPtr, "UnloadSceneOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr);
				SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, "m_Instance");
				SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_sceneLoadHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, "m_sceneLoadHandle");
				SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_UnloadOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, "m_UnloadOptions");
				SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, 100663870);
				SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, 100663871);
				SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, 100663872);
				SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_UnloadSceneCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, 100663873);
				SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, 100663874);
				SceneProvider.UnloadSceneOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr, 100663875);
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x0001F8DC File Offset: 0x0001DADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141105, XrefRangeEnd = 1141113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sceneLoadHandle));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x0001F934 File Offset: 0x0001DB34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141113, XrefRangeEnd = 1141130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x0001F970 File Offset: 0x0001DB70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141130, XrefRangeEnd = 1141141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1141155, RefRangeEnd = 1141156, XrefRangeStart = 1141141, XrefRangeEnd = 1141155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnloadSceneCompleted(AsyncOperation obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_UnloadSceneCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001F9FC File Offset: 0x0001DBFC
			public unsafe override float Progress
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141156, XrefRangeEnd = 1141159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneProvider.UnloadSceneOp.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x0001FA44 File Offset: 0x0001DC44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141159, XrefRangeEnd = 1141162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnloadSceneOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneProvider.UnloadSceneOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneProvider.UnloadSceneOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x00004964 File Offset: 0x00002B64
			public UnloadSceneOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001FA80 File Offset: 0x0001DC80
			// (set) Token: 0x060006BE RID: 1726 RVA: 0x0000496D File Offset: 0x00002B6D
			public SceneInstance m_Instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_Instance);
					return new SceneInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_Instance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001FAB0 File Offset: 0x0001DCB0
			// (set) Token: 0x060006C0 RID: 1728 RVA: 0x0000499B File Offset: 0x00002B9B
			public AsyncOperationHandle<SceneInstance> m_sceneLoadHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_sceneLoadHandle);
					return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_sceneLoadHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001FAE0 File Offset: 0x0001DCE0
			// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000049C9 File Offset: 0x00002BC9
			public unsafe UnloadSceneOptions m_UnloadOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_UnloadOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneProvider.UnloadSceneOp.NativeFieldInfoPtr_m_UnloadOptions)) = value;
				}
			}

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

			// Token: 0x040004C4 RID: 1220
			private static readonly IntPtr NativeFieldInfoPtr_m_sceneLoadHandle;

			// Token: 0x040004C5 RID: 1221
			private static readonly IntPtr NativeFieldInfoPtr_m_UnloadOptions;

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_SceneInstance_UnloadSceneOptions_0;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneCompleted_Private_Void_AsyncOperation_0;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

			// Token: 0x040004CB RID: 1227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
