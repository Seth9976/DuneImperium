using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets.ResourceProviders
{
	// Token: 0x0200001E RID: 30
	public class ContentCatalogProvider : ResourceProviderBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000F6FC File Offset: 0x0000D8FC
		// Note: this type is marked as 'beforefieldinit'.
		static ContentCatalogProvider()
		{
			Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceProviders", "ContentCatalogProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr);
			ContentCatalogProvider.NativeFieldInfoPtr_DisableCatalogUpdateOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, "DisableCatalogUpdateOnStart");
			ContentCatalogProvider.NativeFieldInfoPtr_IsLocalCatalogInBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, "IsLocalCatalogInBundle");
			ContentCatalogProvider.NativeFieldInfoPtr_m_LocationToCatalogLoadOpMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, "m_LocationToCatalogLoadOpMap");
			ContentCatalogProvider.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, 100663778);
			ContentCatalogProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, 100663779);
			ContentCatalogProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, 100663780);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163825, XrefRangeEnd = 1163833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentCatalogProvider(ResourceManager resourceManagerInstance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManagerInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163833, XrefRangeEnd = 1163864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release(IResourceLocation location, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentCatalogProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000F850 File Offset: 0x0000DA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163864, XrefRangeEnd = 1163881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle providerInterface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(providerInterface));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentCatalogProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002ACB File Offset: 0x00000CCB
		public ContentCatalogProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public unsafe bool DisableCatalogUpdateOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.NativeFieldInfoPtr_DisableCatalogUpdateOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.NativeFieldInfoPtr_DisableCatalogUpdateOnStart)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000F8CC File Offset: 0x0000DACC
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002AEF File Offset: 0x00000CEF
		public unsafe bool IsLocalCatalogInBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.NativeFieldInfoPtr_IsLocalCatalogInBundle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.NativeFieldInfoPtr_IsLocalCatalogInBundle)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002B0A File Offset: 0x00000D0A
		public unsafe Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.NativeFieldInfoPtr_m_LocationToCatalogLoadOpMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.NativeFieldInfoPtr_m_LocationToCatalogLoadOpMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_DisableCatalogUpdateOnStart;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_IsLocalCatalogInBundle;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_m_LocationToCatalogLoadOpMap;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x0200007A RID: 122
		public enum DependencyHashIndex
		{
			// Token: 0x0400038E RID: 910
			Remote,
			// Token: 0x0400038F RID: 911
			Cache,
			// Token: 0x04000390 RID: 912
			Count
		}

		// Token: 0x0200007B RID: 123
		public class InternalOp : Object
		{
			// Token: 0x06000510 RID: 1296 RVA: 0x00018274 File Offset: 0x00016474
			// Note: this type is marked as 'beforefieldinit'.
			static InternalOp()
			{
				Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContentCatalogProvider>.NativeClassPtr, "InternalOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr);
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_LocalDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_LocalDataPath");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_RemoteHashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_RemoteHashValue");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_LocalHashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_LocalHashValue");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ProviderInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_ProviderInterface");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ContentCatalogData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_ContentCatalogData");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ContentCatalogDataLoadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_ContentCatalogDataLoadOp");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_BundledCatalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_BundledCatalog");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_Retried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_Retried");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_DisableCatalogUpdateOnStart");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_IsLocalCatalogInBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "m_IsLocalCatalogInBundle");
				ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_kCatalogExt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "kCatalogExt");
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663781);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionCallback_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663782);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663783);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_CanLoadCatalogFromBundle_Internal_Boolean_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663784);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_LoadCatalog_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663785);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_CatalogLoadOpCompleteCallback_Private_Void_AsyncOperationHandle_1_ContentCatalogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663786);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_GetTransformedInternalId_Private_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663787);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_DetermineIdToLoad_Internal_String_IResourceLocation_IList_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663788);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_OnCatalogLoaded_Private_Void_ContentCatalogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663789);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663790);
				ContentCatalogProvider.InternalOp.NativeMethodInfoPtr__LoadCatalog_b__14_0_Private_Void_ContentCatalogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, 100663791);
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x00018458 File Offset: 0x00016658
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1163518, RefRangeEnd = 1163520, XrefRangeStart = 1163482, XrefRangeEnd = 1163518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(providerInterface));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableCatalogUpdateOnStart;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalCatalogInBundle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x000184BC File Offset: 0x000166BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163520, XrefRangeEnd = 1163526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool WaitForCompletionCallback()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_WaitForCompletionCallback_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x000184F8 File Offset: 0x000166F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163526, XrefRangeEnd = 1163546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x0001852C File Offset: 0x0001672C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163546, XrefRangeEnd = 1163553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(idToLoad);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_CanLoadCatalogFromBundle_Internal_Boolean_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x0001858C File Offset: 0x0001678C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1163617, RefRangeEnd = 1163618, XrefRangeStart = 1163553, XrefRangeEnd = 1163617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(idToLoad);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadCatalogFromLocalBundle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_LoadCatalog_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x000185DC File Offset: 0x000167DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163618, XrefRangeEnd = 1163626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_CatalogLoadOpCompleteCallback_Private_Void_AsyncOperationHandle_1_ContentCatalogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x00018624 File Offset: 0x00016824
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1163631, RefRangeEnd = 1163635, XrefRangeStart = 1163626, XrefRangeEnd = 1163631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetTransformedInternalId(IResourceLocation loc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_GetTransformedInternalId_Private_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x0001866C File Offset: 0x0001686C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1163707, RefRangeEnd = 1163708, XrefRangeStart = 1163635, XrefRangeEnd = 1163707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string DetermineIdToLoad(IResourceLocation location, IList<Object> dependencyObjects, bool disableCatalogUpdateOnStart = false)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dependencyObjects);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disableCatalogUpdateOnStart;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_DetermineIdToLoad_Internal_String_IResourceLocation_IList_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x000186D4 File Offset: 0x000168D4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1163821, RefRangeEnd = 1163823, XrefRangeStart = 1163708, XrefRangeEnd = 1163821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCatalogLoaded(ContentCatalogData ccd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr_OnCatalogLoaded_Private_Void_ContentCatalogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x00018718 File Offset: 0x00016918
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x00018754 File Offset: 0x00016954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163823, XrefRangeEnd = 1163825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadCatalog_b__14_0(ContentCatalogData ccd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.NativeMethodInfoPtr__LoadCatalog_b__14_0_Private_Void_ContentCatalogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x00004141 File Offset: 0x00002341
			public InternalOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x0600051D RID: 1309 RVA: 0x00018798 File Offset: 0x00016998
			// (set) Token: 0x0600051E RID: 1310 RVA: 0x0000414A File Offset: 0x0000234A
			public unsafe string m_LocalDataPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_LocalDataPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_LocalDataPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x0600051F RID: 1311 RVA: 0x000187C0 File Offset: 0x000169C0
			// (set) Token: 0x06000520 RID: 1312 RVA: 0x00004169 File Offset: 0x00002369
			public unsafe string m_RemoteHashValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_RemoteHashValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_RemoteHashValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06000521 RID: 1313 RVA: 0x000187E8 File Offset: 0x000169E8
			// (set) Token: 0x06000522 RID: 1314 RVA: 0x00004188 File Offset: 0x00002388
			public unsafe string m_LocalHashValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_LocalHashValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_LocalHashValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000523 RID: 1315 RVA: 0x00018810 File Offset: 0x00016A10
			// (set) Token: 0x06000524 RID: 1316 RVA: 0x000041A7 File Offset: 0x000023A7
			public ProvideHandle m_ProviderInterface
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ProviderInterface);
					return new ProvideHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ProviderInterface), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProvideHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000525 RID: 1317 RVA: 0x00018840 File Offset: 0x00016A40
			// (set) Token: 0x06000526 RID: 1318 RVA: 0x000041D5 File Offset: 0x000023D5
			public unsafe ContentCatalogData m_ContentCatalogData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ContentCatalogData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentCatalogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ContentCatalogData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000527 RID: 1319 RVA: 0x00018870 File Offset: 0x00016A70
			// (set) Token: 0x06000528 RID: 1320 RVA: 0x000041F4 File Offset: 0x000023F4
			public AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ContentCatalogDataLoadOp);
					return new AsyncOperationHandle<ContentCatalogData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<ContentCatalogData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_ContentCatalogDataLoadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<ContentCatalogData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000529 RID: 1321 RVA: 0x000188A0 File Offset: 0x00016AA0
			// (set) Token: 0x0600052A RID: 1322 RVA: 0x00004222 File Offset: 0x00002422
			public unsafe ContentCatalogProvider.InternalOp.BundledCatalog m_BundledCatalog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_BundledCatalog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentCatalogProvider.InternalOp.BundledCatalog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_BundledCatalog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x0600052B RID: 1323 RVA: 0x000188D0 File Offset: 0x00016AD0
			// (set) Token: 0x0600052C RID: 1324 RVA: 0x00004241 File Offset: 0x00002441
			public unsafe bool m_Retried
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_Retried);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_Retried)) = value;
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x0600052D RID: 1325 RVA: 0x000188F8 File Offset: 0x00016AF8
			// (set) Token: 0x0600052E RID: 1326 RVA: 0x0000425C File Offset: 0x0000245C
			public unsafe bool m_DisableCatalogUpdateOnStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart)) = value;
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x0600052F RID: 1327 RVA: 0x00018920 File Offset: 0x00016B20
			// (set) Token: 0x06000530 RID: 1328 RVA: 0x00004277 File Offset: 0x00002477
			public unsafe bool m_IsLocalCatalogInBundle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_IsLocalCatalogInBundle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_m_IsLocalCatalogInBundle)) = value;
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000531 RID: 1329 RVA: 0x00018948 File Offset: 0x00016B48
			// (set) Token: 0x06000532 RID: 1330 RVA: 0x00004292 File Offset: 0x00002492
			public unsafe static string kCatalogExt
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_kCatalogExt, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContentCatalogProvider.InternalOp.NativeFieldInfoPtr_kCatalogExt, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000391 RID: 913
			private static readonly IntPtr NativeFieldInfoPtr_m_LocalDataPath;

			// Token: 0x04000392 RID: 914
			private static readonly IntPtr NativeFieldInfoPtr_m_RemoteHashValue;

			// Token: 0x04000393 RID: 915
			private static readonly IntPtr NativeFieldInfoPtr_m_LocalHashValue;

			// Token: 0x04000394 RID: 916
			private static readonly IntPtr NativeFieldInfoPtr_m_ProviderInterface;

			// Token: 0x04000395 RID: 917
			private static readonly IntPtr NativeFieldInfoPtr_m_ContentCatalogData;

			// Token: 0x04000396 RID: 918
			private static readonly IntPtr NativeFieldInfoPtr_m_ContentCatalogDataLoadOp;

			// Token: 0x04000397 RID: 919
			private static readonly IntPtr NativeFieldInfoPtr_m_BundledCatalog;

			// Token: 0x04000398 RID: 920
			private static readonly IntPtr NativeFieldInfoPtr_m_Retried;

			// Token: 0x04000399 RID: 921
			private static readonly IntPtr NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart;

			// Token: 0x0400039A RID: 922
			private static readonly IntPtr NativeFieldInfoPtr_m_IsLocalCatalogInBundle;

			// Token: 0x0400039B RID: 923
			private static readonly IntPtr NativeFieldInfoPtr_kCatalogExt;

			// Token: 0x0400039C RID: 924
			private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_ProvideHandle_Boolean_Boolean_0;

			// Token: 0x0400039D RID: 925
			private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletionCallback_Private_Boolean_0;

			// Token: 0x0400039E RID: 926
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

			// Token: 0x0400039F RID: 927
			private static readonly IntPtr NativeMethodInfoPtr_CanLoadCatalogFromBundle_Internal_Boolean_String_IResourceLocation_0;

			// Token: 0x040003A0 RID: 928
			private static readonly IntPtr NativeMethodInfoPtr_LoadCatalog_Internal_Void_String_Boolean_0;

			// Token: 0x040003A1 RID: 929
			private static readonly IntPtr NativeMethodInfoPtr_CatalogLoadOpCompleteCallback_Private_Void_AsyncOperationHandle_1_ContentCatalogData_0;

			// Token: 0x040003A2 RID: 930
			private static readonly IntPtr NativeMethodInfoPtr_GetTransformedInternalId_Private_String_IResourceLocation_0;

			// Token: 0x040003A3 RID: 931
			private static readonly IntPtr NativeMethodInfoPtr_DetermineIdToLoad_Internal_String_IResourceLocation_IList_1_Object_Boolean_0;

			// Token: 0x040003A4 RID: 932
			private static readonly IntPtr NativeMethodInfoPtr_OnCatalogLoaded_Private_Void_ContentCatalogData_0;

			// Token: 0x040003A5 RID: 933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003A6 RID: 934
			private static readonly IntPtr NativeMethodInfoPtr__LoadCatalog_b__14_0_Private_Void_ContentCatalogData_0;

			// Token: 0x02000087 RID: 135
			public class BundledCatalog : Object
			{
				// Token: 0x0600059F RID: 1439 RVA: 0x00019B64 File Offset: 0x00017D64
				// Note: this type is marked as 'beforefieldinit'.
				static BundledCatalog()
				{
					Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp>.NativeClassPtr, "BundledCatalog");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_BundlePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_BundlePath");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_OpInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_OpInProgress");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_LoadBundleRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_LoadBundleRequest");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_CatalogAssetBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_CatalogAssetBundle");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_LoadTextAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_LoadTextAssetRequest");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_CatalogData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_CatalogData");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_WebRequestQueueOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_WebRequestQueueOperation");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_RequestOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_RequestOperation");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_WebRequestTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "m_WebRequestTimeout");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_OnLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, "OnLoaded");
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_add_OnLoaded_Public_add_Void_Action_1_ContentCatalogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663792);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_remove_OnLoaded_Public_rem_Void_Action_1_ContentCatalogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663793);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_get_OpInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663794);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_get_OpIsSuccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663795);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663796);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663797);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_Unload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663798);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_LoadCatalogFromBundleAsync_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663799);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_WebRequestOperationCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663800);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_LoadTextAssetRequestComplete_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663801);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_WaitForCompletion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663802);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr__LoadCatalogFromBundleAsync_b__19_1_Private_Void_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663803);
					ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr__LoadCatalogFromBundleAsync_b__19_0_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr, 100663804);
				}

				// Token: 0x060005A0 RID: 1440 RVA: 0x00019D5C File Offset: 0x00017F5C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163339, XrefRangeEnd = 1163344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void add_OnLoaded(Action<ContentCatalogData> value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_add_OnLoaded_Public_add_Void_Action_1_ContentCatalogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060005A1 RID: 1441 RVA: 0x00019DA0 File Offset: 0x00017FA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163344, XrefRangeEnd = 1163349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void remove_OnLoaded(Action<ContentCatalogData> value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_remove_OnLoaded_Public_rem_Void_Action_1_ContentCatalogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x1700019A RID: 410
				// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00019DE4 File Offset: 0x00017FE4
				public unsafe bool OpInProgress
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_get_OpInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x1700019B RID: 411
				// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00019E20 File Offset: 0x00018020
				public unsafe bool OpIsSuccess
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_get_OpIsSuccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060005A4 RID: 1444 RVA: 0x00019E5C File Offset: 0x0001805C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163349, XrefRangeEnd = 1163355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe BundledCatalog(string bundlePath, int webRequestTimeout = 0)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogProvider.InternalOp.BundledCatalog>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(bundlePath);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref webRequestTimeout;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060005A5 RID: 1445 RVA: 0x00019EB8 File Offset: 0x000180B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163355, XrefRangeEnd = 1163360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public new unsafe void Finalize()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060005A6 RID: 1446 RVA: 0x00019EF4 File Offset: 0x000180F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163360, XrefRangeEnd = 1163362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Unload()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_Unload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060005A7 RID: 1447 RVA: 0x00019F28 File Offset: 0x00018128
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1163378, RefRangeEnd = 1163379, XrefRangeStart = 1163362, XrefRangeEnd = 1163378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void LoadCatalogFromBundleAsync()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_LoadCatalogFromBundleAsync_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060005A8 RID: 1448 RVA: 0x00019F5C File Offset: 0x0001815C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163379, XrefRangeEnd = 1163409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void WebRequestOperationCompleted(AsyncOperation op)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_WebRequestOperationCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060005A9 RID: 1449 RVA: 0x00019FA0 File Offset: 0x000181A0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1163432, RefRangeEnd = 1163434, XrefRangeStart = 1163409, XrefRangeEnd = 1163432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void LoadTextAssetRequestComplete(AsyncOperation op)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_LoadTextAssetRequestComplete_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060005AA RID: 1450 RVA: 0x00019FE4 File Offset: 0x000181E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163434, XrefRangeEnd = 1163443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool WaitForCompletion()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr_WaitForCompletion_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060005AB RID: 1451 RVA: 0x0001A020 File Offset: 0x00018220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163443, XrefRangeEnd = 1163452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _LoadCatalogFromBundleAsync_b__19_1(UnityWebRequestAsyncOperation asyncOp)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncOp);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr__LoadCatalogFromBundleAsync_b__19_1_Private_Void_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060005AC RID: 1452 RVA: 0x0001A064 File Offset: 0x00018264
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163452, XrefRangeEnd = 1163482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _LoadCatalogFromBundleAsync_b__19_0(AsyncOperation loadOp)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadOp);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogProvider.InternalOp.BundledCatalog.NativeMethodInfoPtr__LoadCatalogFromBundleAsync_b__19_0_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060005AD RID: 1453 RVA: 0x000046B9 File Offset: 0x000028B9
				public BundledCatalog(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000190 RID: 400
				// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001A0A8 File Offset: 0x000182A8
				// (set) Token: 0x060005AF RID: 1455 RVA: 0x000046C2 File Offset: 0x000028C2
				public unsafe string m_BundlePath
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_BundlePath);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_BundlePath), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000191 RID: 401
				// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001A0D0 File Offset: 0x000182D0
				// (set) Token: 0x060005B1 RID: 1457 RVA: 0x000046E1 File Offset: 0x000028E1
				public unsafe bool m_OpInProgress
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_OpInProgress);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_OpInProgress)) = value;
					}
				}

				// Token: 0x17000192 RID: 402
				// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001A0F8 File Offset: 0x000182F8
				// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000046FC File Offset: 0x000028FC
				public unsafe AssetBundleCreateRequest m_LoadBundleRequest
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_LoadBundleRequest);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_LoadBundleRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000193 RID: 403
				// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001A128 File Offset: 0x00018328
				// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0000471B File Offset: 0x0000291B
				public unsafe AssetBundle m_CatalogAssetBundle
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_CatalogAssetBundle);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_CatalogAssetBundle), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000194 RID: 404
				// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0001A158 File Offset: 0x00018358
				// (set) Token: 0x060005B7 RID: 1463 RVA: 0x0000473A File Offset: 0x0000293A
				public unsafe AssetBundleRequest m_LoadTextAssetRequest
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_LoadTextAssetRequest);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_LoadTextAssetRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000195 RID: 405
				// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001A188 File Offset: 0x00018388
				// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00004759 File Offset: 0x00002959
				public unsafe ContentCatalogData m_CatalogData
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_CatalogData);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentCatalogData>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_CatalogData), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000196 RID: 406
				// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001A1B8 File Offset: 0x000183B8
				// (set) Token: 0x060005BB RID: 1467 RVA: 0x00004778 File Offset: 0x00002978
				public unsafe WebRequestQueueOperation m_WebRequestQueueOperation
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_WebRequestQueueOperation);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestQueueOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_WebRequestQueueOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000197 RID: 407
				// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001A1E8 File Offset: 0x000183E8
				// (set) Token: 0x060005BD RID: 1469 RVA: 0x00004797 File Offset: 0x00002997
				public unsafe AsyncOperation m_RequestOperation
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_RequestOperation);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_RequestOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000198 RID: 408
				// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001A218 File Offset: 0x00018418
				// (set) Token: 0x060005BF RID: 1471 RVA: 0x000047B6 File Offset: 0x000029B6
				public unsafe int m_WebRequestTimeout
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_WebRequestTimeout);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_m_WebRequestTimeout)) = value;
					}
				}

				// Token: 0x17000199 RID: 409
				// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001A240 File Offset: 0x00018440
				// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000047D1 File Offset: 0x000029D1
				public unsafe Action<ContentCatalogData> OnLoaded
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_OnLoaded);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ContentCatalogData>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogProvider.InternalOp.BundledCatalog.NativeFieldInfoPtr_OnLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040003DF RID: 991
				private static readonly IntPtr NativeFieldInfoPtr_m_BundlePath;

				// Token: 0x040003E0 RID: 992
				private static readonly IntPtr NativeFieldInfoPtr_m_OpInProgress;

				// Token: 0x040003E1 RID: 993
				private static readonly IntPtr NativeFieldInfoPtr_m_LoadBundleRequest;

				// Token: 0x040003E2 RID: 994
				private static readonly IntPtr NativeFieldInfoPtr_m_CatalogAssetBundle;

				// Token: 0x040003E3 RID: 995
				private static readonly IntPtr NativeFieldInfoPtr_m_LoadTextAssetRequest;

				// Token: 0x040003E4 RID: 996
				private static readonly IntPtr NativeFieldInfoPtr_m_CatalogData;

				// Token: 0x040003E5 RID: 997
				private static readonly IntPtr NativeFieldInfoPtr_m_WebRequestQueueOperation;

				// Token: 0x040003E6 RID: 998
				private static readonly IntPtr NativeFieldInfoPtr_m_RequestOperation;

				// Token: 0x040003E7 RID: 999
				private static readonly IntPtr NativeFieldInfoPtr_m_WebRequestTimeout;

				// Token: 0x040003E8 RID: 1000
				private static readonly IntPtr NativeFieldInfoPtr_OnLoaded;

				// Token: 0x040003E9 RID: 1001
				private static readonly IntPtr NativeMethodInfoPtr_add_OnLoaded_Public_add_Void_Action_1_ContentCatalogData_0;

				// Token: 0x040003EA RID: 1002
				private static readonly IntPtr NativeMethodInfoPtr_remove_OnLoaded_Public_rem_Void_Action_1_ContentCatalogData_0;

				// Token: 0x040003EB RID: 1003
				private static readonly IntPtr NativeMethodInfoPtr_get_OpInProgress_Public_get_Boolean_0;

				// Token: 0x040003EC RID: 1004
				private static readonly IntPtr NativeMethodInfoPtr_get_OpIsSuccess_Public_get_Boolean_0;

				// Token: 0x040003ED RID: 1005
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

				// Token: 0x040003EE RID: 1006
				private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

				// Token: 0x040003EF RID: 1007
				private static readonly IntPtr NativeMethodInfoPtr_Unload_Private_Void_0;

				// Token: 0x040003F0 RID: 1008
				private static readonly IntPtr NativeMethodInfoPtr_LoadCatalogFromBundleAsync_Public_Void_0;

				// Token: 0x040003F1 RID: 1009
				private static readonly IntPtr NativeMethodInfoPtr_WebRequestOperationCompleted_Private_Void_AsyncOperation_0;

				// Token: 0x040003F2 RID: 1010
				private static readonly IntPtr NativeMethodInfoPtr_LoadTextAssetRequestComplete_Private_Void_AsyncOperation_0;

				// Token: 0x040003F3 RID: 1011
				private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Boolean_0;

				// Token: 0x040003F4 RID: 1012
				private static readonly IntPtr NativeMethodInfoPtr__LoadCatalogFromBundleAsync_b__19_1_Private_Void_UnityWebRequestAsyncOperation_0;

				// Token: 0x040003F5 RID: 1013
				private static readonly IntPtr NativeMethodInfoPtr__LoadCatalogFromBundleAsync_b__19_0_Private_Void_AsyncOperation_0;
			}
		}
	}
}
