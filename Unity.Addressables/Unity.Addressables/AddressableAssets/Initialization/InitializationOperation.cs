using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.AddressableAssets.Utility;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	// Token: 0x02000028 RID: 40
	public class InitializationOperation : AsyncOperationBase<IResourceLocator>
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00012224 File Offset: 0x00010424
		// Note: this type is marked as 'beforefieldinit'.
		static InitializationOperation()
		{
			Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Initialization", "InitializationOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr);
			InitializationOperation.NativeFieldInfoPtr_m_rtdOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_rtdOp");
			InitializationOperation.NativeFieldInfoPtr_m_loadCatalogOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_loadCatalogOp");
			InitializationOperation.NativeFieldInfoPtr_m_ProviderSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_ProviderSuffix");
			InitializationOperation.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_Addressables");
			InitializationOperation.NativeFieldInfoPtr_m_Diagnostics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_Diagnostics");
			InitializationOperation.NativeFieldInfoPtr_m_InitGroupOps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_InitGroupOps");
			InitializationOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663909);
			InitializationOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663910);
			InitializationOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663911);
			InitializationOperation.NativeMethodInfoPtr_CreateInitializationOperation_Internal_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663912);
			InitializationOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663913);
			InitializationOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663914);
			InitializationOperation.NativeMethodInfoPtr_LoadProvider_Private_Static_Void_AddressablesImpl_ObjectInitializationData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663915);
			InitializationOperation.NativeMethodInfoPtr_OnCatalogDataLoaded_Private_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_AsyncOperationHandle_1_ContentCatalogData_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663916);
			InitializationOperation.NativeMethodInfoPtr_LoadContentCatalog_Public_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_IResourceLocation_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663917);
			InitializationOperation.NativeMethodInfoPtr_LoadContentCatalog_Public_AsyncOperationHandle_1_IResourceLocator_IResourceLocation_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663918);
			InitializationOperation.NativeMethodInfoPtr_LoadContentCatalogInternal_Internal_AsyncOperationHandle_1_IResourceLocator_IList_1_IResourceLocation_Int32_ResourceLocationMap_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663919);
			InitializationOperation.NativeMethodInfoPtr_LoadOpComplete_Private_Void_AsyncOperationHandle_1_IResourceLocator_IList_1_IResourceLocation_ResourceLocationMap_Int32_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100663920);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000123BC File Offset: 0x000105BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164763, XrefRangeEnd = 1164788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializationOperation(AddressablesImpl aa)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00012408 File Offset: 0x00010608
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164788, XrefRangeEnd = 1164792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00012450 File Offset: 0x00010650
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164792, XrefRangeEnd = 1164794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00012494 File Offset: 0x00010694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164892, RefRangeEnd = 1164893, XrefRangeStart = 1164794, XrefRangeEnd = 1164892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerSettingsLocation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_CreateInitializationOperation_Internal_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000124F4 File Offset: 0x000106F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164893, XrefRangeEnd = 1164923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001253C File Offset: 0x0001073C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164923, XrefRangeEnd = 1165077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00012578 File Offset: 0x00010778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165108, RefRangeEnd = 1165109, XrefRangeStart = 1165077, XrefRangeEnd = 1165108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addressables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(providerData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadProvider_Private_Static_Void_AddressablesImpl_ObjectInitializationData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000125D8 File Offset: 0x000107D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1165168, RefRangeEnd = 1165169, XrefRangeStart = 1165109, XrefRangeEnd = 1165168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addressables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteHashLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_OnCatalogDataLoaded_Private_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_AsyncOperationHandle_1_ContentCatalogData_String_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00012650 File Offset: 0x00010850
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1165232, RefRangeEnd = 1165235, XrefRangeStart = 1165169, XrefRangeEnd = 1165232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addressables);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteHashLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadContentCatalog_Public_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_IResourceLocation_String_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000126C4 File Offset: 0x000108C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165235, XrefRangeEnd = 1165236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteHashLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadContentCatalog_Public_AsyncOperationHandle_1_IResourceLocator_IResourceLocation_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00012730 File Offset: 0x00010930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1165262, RefRangeEnd = 1165264, XrefRangeStart = 1165236, XrefRangeEnd = 1165262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locMap);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteHashLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadContentCatalogInternal_Internal_AsyncOperationHandle_1_IResourceLocator_IList_1_IResourceLocation_Int32_ResourceLocationMap_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<IResourceLocator>(intPtr);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000127AC File Offset: 0x000109AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1165310, RefRangeEnd = 1165312, XrefRangeStart = 1165264, XrefRangeEnd = 1165310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(catalogs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locMap);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteHashLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadOpComplete_Private_Void_AsyncOperationHandle_1_IResourceLocator_IList_1_IResourceLocation_ResourceLocationMap_Int32_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000306F File Offset: 0x0000126F
		public InitializationOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00012838 File Offset: 0x00010A38
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00003078 File Offset: 0x00001278
		public AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_rtdOp);
				return new AsyncOperationHandle<ResourceManagerRuntimeData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<ResourceManagerRuntimeData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_rtdOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<ResourceManagerRuntimeData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00012868 File Offset: 0x00010A68
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000030A6 File Offset: 0x000012A6
		public AsyncOperationHandle<IResourceLocator> m_loadCatalogOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_loadCatalogOp);
				return new AsyncOperationHandle<IResourceLocator>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IResourceLocator>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_loadCatalogOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IResourceLocator>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00012898 File Offset: 0x00010A98
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000030D4 File Offset: 0x000012D4
		public unsafe string m_ProviderSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_ProviderSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_ProviderSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000128C0 File Offset: 0x00010AC0
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000030F3 File Offset: 0x000012F3
		public unsafe AddressablesImpl m_Addressables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_Addressables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000128F0 File Offset: 0x00010AF0
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00003112 File Offset: 0x00001312
		public unsafe ResourceManagerDiagnostics m_Diagnostics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_Diagnostics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManagerDiagnostics>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_Diagnostics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00012920 File Offset: 0x00010B20
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00003131 File Offset: 0x00001331
		public unsafe InitalizationObjectsOperation m_InitGroupOps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_InitGroupOps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitalizationObjectsOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_InitGroupOps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_m_rtdOp;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_m_loadCatalogOp;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_m_ProviderSuffix;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_m_Diagnostics;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_InitGroupOps;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_CreateInitializationOperation_Internal_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_String_String_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_LoadProvider_Private_Static_Void_AddressablesImpl_ObjectInitializationData_String_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_OnCatalogDataLoaded_Private_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_AsyncOperationHandle_1_ContentCatalogData_String_IResourceLocation_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalog_Public_Static_AsyncOperationHandle_1_IResourceLocator_AddressablesImpl_IResourceLocation_String_IResourceLocation_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalog_Public_AsyncOperationHandle_1_IResourceLocator_IResourceLocation_String_IResourceLocation_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentCatalogInternal_Internal_AsyncOperationHandle_1_IResourceLocator_IList_1_IResourceLocation_Int32_ResourceLocationMap_IResourceLocation_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_LoadOpComplete_Private_Void_AsyncOperationHandle_1_IResourceLocator_IList_1_IResourceLocation_ResourceLocationMap_Int32_IResourceLocation_0;

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("UnityEngine.AddressableAssets.Initialization.InitializationOperation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600057B RID: 1403 RVA: 0x00019644 File Offset: 0x00017844
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr);
				InitializationOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, "<>9");
				InitializationOperation.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, "<>9__13_0");
				InitializationOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, 100663922);
				InitializationOperation.__c.NativeMethodInfoPtr__Execute_b__13_0_Internal_Boolean_IResourceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, 100663923);
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x000196C0 File Offset: 0x000178C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x000196FC File Offset: 0x000178FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164752, XrefRangeEnd = 1164761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Execute_b__13_0(IResourceProvider rp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c.NativeMethodInfoPtr__Execute_b__13_0_Internal_Boolean_IResourceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00004536 File Offset: 0x00002736
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x0001974C File Offset: 0x0001794C
			// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000453F File Offset: 0x0000273F
			public unsafe static InitializationOperation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializationOperation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000581 RID: 1409 RVA: 0x00019774 File Offset: 0x00017974
			// (set) Token: 0x06000582 RID: 1410 RVA: 0x00004551 File Offset: 0x00002751
			public unsafe static Func<IResourceProvider, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationOperation.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IResourceProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationOperation.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003CF RID: 975
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040003D0 RID: 976
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040003D1 RID: 977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003D2 RID: 978
			private static readonly IntPtr NativeMethodInfoPtr__Execute_b__13_0_Internal_Boolean_IResourceProvider_0;
		}

		// Token: 0x02000083 RID: 131
		[ObfuscatedName("UnityEngine.AddressableAssets.Initialization.InitializationOperation+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x06000583 RID: 1411 RVA: 0x0001979C File Offset: 0x0001799C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr);
				InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr, "addressables");
				InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_providerSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr, "providerSuffix");
				InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_remoteHashLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr, "remoteHashLocation");
				InitializationOperation.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr, 100663924);
				InitializationOperation.__c__DisplayClass16_0.NativeMethodInfoPtr__LoadContentCatalog_b__0_Internal_AsyncOperationHandle_1_IResourceLocator_AsyncOperationHandle_1_ContentCatalogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr, 100663925);
			}

			// Token: 0x06000584 RID: 1412 RVA: 0x0001982C File Offset: 0x00017A2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x00019868 File Offset: 0x00017A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164761, XrefRangeEnd = 1164762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AsyncOperationHandle<IResourceLocator> _LoadContentCatalog_b__0(AsyncOperationHandle<ContentCatalogData> res)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(res));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c__DisplayClass16_0.NativeMethodInfoPtr__LoadContentCatalog_b__0_Internal_AsyncOperationHandle_1_IResourceLocator_AsyncOperationHandle_1_ContentCatalogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AsyncOperationHandle<IResourceLocator>(intPtr);
				}
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x00004563 File Offset: 0x00002763
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000587 RID: 1415 RVA: 0x000198B8 File Offset: 0x00017AB8
			// (set) Token: 0x06000588 RID: 1416 RVA: 0x0000456C File Offset: 0x0000276C
			public unsafe AddressablesImpl addressables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_addressables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000589 RID: 1417 RVA: 0x000198E8 File Offset: 0x00017AE8
			// (set) Token: 0x0600058A RID: 1418 RVA: 0x0000458B File Offset: 0x0000278B
			public unsafe string providerSuffix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_providerSuffix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_providerSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x0600058B RID: 1419 RVA: 0x00019910 File Offset: 0x00017B10
			// (set) Token: 0x0600058C RID: 1420 RVA: 0x000045AA File Offset: 0x000027AA
			public unsafe IResourceLocation remoteHashLocation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_remoteHashLocation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass16_0.NativeFieldInfoPtr_remoteHashLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003D3 RID: 979
			private static readonly IntPtr NativeFieldInfoPtr_addressables;

			// Token: 0x040003D4 RID: 980
			private static readonly IntPtr NativeFieldInfoPtr_providerSuffix;

			// Token: 0x040003D5 RID: 981
			private static readonly IntPtr NativeFieldInfoPtr_remoteHashLocation;

			// Token: 0x040003D6 RID: 982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003D7 RID: 983
			private static readonly IntPtr NativeMethodInfoPtr__LoadContentCatalog_b__0_Internal_AsyncOperationHandle_1_IResourceLocator_AsyncOperationHandle_1_ContentCatalogData_0;
		}

		// Token: 0x02000084 RID: 132
		[ObfuscatedName("UnityEngine.AddressableAssets.Initialization.InitializationOperation+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600058D RID: 1421 RVA: 0x00019940 File Offset: 0x00017B40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr);
				InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_catalogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, "catalogs");
				InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_locMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, "locMap");
				InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, "index");
				InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_remoteHashLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, "remoteHashLocation");
				InitializationOperation.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, 100663926);
				InitializationOperation.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadContentCatalogInternal_b__0_Internal_Void_AsyncOperationHandle_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr, 100663927);
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x000199F8 File Offset: 0x00017BF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x00019A34 File Offset: 0x00017C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164762, XrefRangeEnd = 1164763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadContentCatalogInternal_b__0(AsyncOperationHandle<IResourceLocator> op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadContentCatalogInternal_b__0_Internal_Void_AsyncOperationHandle_1_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x000045C9 File Offset: 0x000027C9
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000591 RID: 1425 RVA: 0x00019A7C File Offset: 0x00017C7C
			// (set) Token: 0x06000592 RID: 1426 RVA: 0x000045D2 File Offset: 0x000027D2
			public unsafe InitializationOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializationOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x00019AAC File Offset: 0x00017CAC
			// (set) Token: 0x06000594 RID: 1428 RVA: 0x000045F1 File Offset: 0x000027F1
			public unsafe IList<IResourceLocation> catalogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_catalogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_catalogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000595 RID: 1429 RVA: 0x00019ADC File Offset: 0x00017CDC
			// (set) Token: 0x06000596 RID: 1430 RVA: 0x00004610 File Offset: 0x00002810
			public unsafe ResourceLocationMap locMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_locMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceLocationMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_locMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x06000597 RID: 1431 RVA: 0x00019B0C File Offset: 0x00017D0C
			// (set) Token: 0x06000598 RID: 1432 RVA: 0x0000462F File Offset: 0x0000282F
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x00019B34 File Offset: 0x00017D34
			// (set) Token: 0x0600059A RID: 1434 RVA: 0x0000464A File Offset: 0x0000284A
			public unsafe IResourceLocation remoteHashLocation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_remoteHashLocation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.__c__DisplayClass18_0.NativeFieldInfoPtr_remoteHashLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003D8 RID: 984
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003D9 RID: 985
			private static readonly IntPtr NativeFieldInfoPtr_catalogs;

			// Token: 0x040003DA RID: 986
			private static readonly IntPtr NativeFieldInfoPtr_locMap;

			// Token: 0x040003DB RID: 987
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040003DC RID: 988
			private static readonly IntPtr NativeFieldInfoPtr_remoteHashLocation;

			// Token: 0x040003DD RID: 989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003DE RID: 990
			private static readonly IntPtr NativeMethodInfoPtr__LoadContentCatalogInternal_b__0_Internal_Void_AsyncOperationHandle_1_IResourceLocator_0;
		}
	}
}
