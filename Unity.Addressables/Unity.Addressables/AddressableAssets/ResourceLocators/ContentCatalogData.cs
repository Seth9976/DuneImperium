using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class ContentCatalogData : Object
	{
		// Token: 0x06000278 RID: 632 RVA: 0x0000FF90 File Offset: 0x0000E190
		// Note: this type is marked as 'beforefieldinit'.
		static ContentCatalogData()
		{
			Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceLocators", "ContentCatalogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr);
			ContentCatalogData.NativeFieldInfoPtr_kMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "kMagic");
			ContentCatalogData.NativeFieldInfoPtr_kVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "kVersion");
			ContentCatalogData.NativeFieldInfoPtr_LocalHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "LocalHash");
			ContentCatalogData.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "location");
			ContentCatalogData.NativeFieldInfoPtr_m_LocatorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_LocatorId");
			ContentCatalogData.NativeFieldInfoPtr_m_BuildResultHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_BuildResultHash");
			ContentCatalogData.NativeFieldInfoPtr_m_InstanceProviderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_InstanceProviderData");
			ContentCatalogData.NativeFieldInfoPtr_m_SceneProviderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_SceneProviderData");
			ContentCatalogData.NativeFieldInfoPtr_m_ResourceProviderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_ResourceProviderData");
			ContentCatalogData.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_Entries");
			ContentCatalogData.NativeFieldInfoPtr_m_ProviderIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_ProviderIds");
			ContentCatalogData.NativeFieldInfoPtr_m_InternalIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_InternalIds");
			ContentCatalogData.NativeFieldInfoPtr_m_KeyDataString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_KeyDataString");
			ContentCatalogData.NativeFieldInfoPtr_m_BucketDataString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_BucketDataString");
			ContentCatalogData.NativeFieldInfoPtr_m_EntryDataString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_EntryDataString");
			ContentCatalogData.NativeFieldInfoPtr_kBytesPerInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "kBytesPerInt32");
			ContentCatalogData.NativeFieldInfoPtr_k_EntryDataItemPerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "k_EntryDataItemPerEntry");
			ContentCatalogData.NativeFieldInfoPtr_m_ExtraDataString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_ExtraDataString");
			ContentCatalogData.NativeFieldInfoPtr_m_resourceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_resourceTypes");
			ContentCatalogData.NativeFieldInfoPtr_m_InternalIdPrefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "m_InternalIdPrefixes");
			ContentCatalogData.NativeMethodInfoPtr_get_BuildResultHash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663818);
			ContentCatalogData.NativeMethodInfoPtr_set_BuildResultHash_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663819);
			ContentCatalogData.NativeMethodInfoPtr_get_ProviderId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663820);
			ContentCatalogData.NativeMethodInfoPtr_set_ProviderId_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663821);
			ContentCatalogData.NativeMethodInfoPtr_get_InstanceProviderData_Public_get_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663822);
			ContentCatalogData.NativeMethodInfoPtr_set_InstanceProviderData_Public_set_Void_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663823);
			ContentCatalogData.NativeMethodInfoPtr_get_SceneProviderData_Public_get_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663824);
			ContentCatalogData.NativeMethodInfoPtr_set_SceneProviderData_Public_set_Void_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663825);
			ContentCatalogData.NativeMethodInfoPtr_get_ResourceProviderData_Public_get_List_1_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663826);
			ContentCatalogData.NativeMethodInfoPtr_set_ResourceProviderData_Public_set_Void_List_1_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663827);
			ContentCatalogData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663828);
			ContentCatalogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663829);
			ContentCatalogData.NativeMethodInfoPtr_get_ProviderIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663830);
			ContentCatalogData.NativeMethodInfoPtr_get_InternalIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663831);
			ContentCatalogData.NativeMethodInfoPtr_LoadFromFile_Internal_Static_ContentCatalogData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663832);
			ContentCatalogData.NativeMethodInfoPtr_SaveToFile_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663833);
			ContentCatalogData.NativeMethodInfoPtr_CleanData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663834);
			ContentCatalogData.NativeMethodInfoPtr_CreateCustomLocator_Internal_ResourceLocationMap_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663835);
			ContentCatalogData.NativeMethodInfoPtr_CreateLocator_Public_ResourceLocationMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663836);
			ContentCatalogData.NativeMethodInfoPtr_GetData_Internal_IList_1_ContentCatalogDataEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663837);
			ContentCatalogData.NativeMethodInfoPtr_ExpandInternalId_Internal_Static_String_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, 100663838);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000102F4 File Offset: 0x0000E4F4
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0001032C File Offset: 0x0000E52C
		public unsafe string BuildResultHash
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_BuildResultHash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_set_BuildResultHash_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00010370 File Offset: 0x0000E570
		// (set) Token: 0x0600027C RID: 636 RVA: 0x000103A8 File Offset: 0x0000E5A8
		public unsafe string ProviderId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_ProviderId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_set_ProviderId_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000103EC File Offset: 0x0000E5EC
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00010424 File Offset: 0x0000E624
		public unsafe ObjectInitializationData InstanceProviderData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_InstanceProviderData_Public_get_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ObjectInitializationData(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163933, XrefRangeEnd = 1163934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_set_InstanceProviderData_Public_set_Void_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0001046C File Offset: 0x0000E66C
		// (set) Token: 0x06000280 RID: 640 RVA: 0x000104A4 File Offset: 0x0000E6A4
		public unsafe ObjectInitializationData SceneProviderData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_SceneProviderData_Public_get_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ObjectInitializationData(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163934, XrefRangeEnd = 1163935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_set_SceneProviderData_Public_set_Void_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000104EC File Offset: 0x0000E6EC
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0001052C File Offset: 0x0000E72C
		public unsafe List<ObjectInitializationData> ResourceProviderData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_ResourceProviderData_Public_get_List_1_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ObjectInitializationData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_set_ResourceProviderData_Public_set_Void_List_1_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00010570 File Offset: 0x0000E770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163935, XrefRangeEnd = 1163944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentCatalogData(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000105BC File Offset: 0x0000E7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163944, XrefRangeEnd = 1163952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentCatalogData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000105F8 File Offset: 0x0000E7F8
		public unsafe Il2CppStringArray ProviderIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_ProviderIds_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00010638 File Offset: 0x0000E838
		public unsafe Il2CppStringArray InternalIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_get_InternalIds_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00010678 File Offset: 0x0000E878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163952, XrefRangeEnd = 1163956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContentCatalogData LoadFromFile(string path, int cacheSize = 1024)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_LoadFromFile_Internal_Static_ContentCatalogData_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentCatalogData>(intPtr3) : null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000106CC File Offset: 0x0000E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163956, XrefRangeEnd = 1163962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToFile(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_SaveToFile_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00010710 File Offset: 0x0000E910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163962, XrefRangeEnd = 1163982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_CleanData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00010744 File Offset: 0x0000E944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163982, XrefRangeEnd = 1163984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationMap CreateCustomLocator(string overrideId = "", string providerSuffix = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(overrideId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_CreateCustomLocator_Internal_ResourceLocationMap_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationMap>(intPtr3) : null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000107A8 File Offset: 0x0000E9A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1164058, RefRangeEnd = 1164063, XrefRangeStart = 1163984, XrefRangeEnd = 1164058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationMap CreateLocator(string providerSuffix = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerSuffix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_CreateLocator_Public_ResourceLocationMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceLocationMap>(intPtr3) : null;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000107F8 File Offset: 0x0000E9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164063, XrefRangeEnd = 1164187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<ContentCatalogDataEntry> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_GetData_Internal_IList_1_ContentCatalogDataEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ContentCatalogDataEntry>>(intPtr3) : null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00010838 File Offset: 0x0000EA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164192, RefRangeEnd = 1164193, XrefRangeStart = 1164187, XrefRangeEnd = 1164192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandInternalId(Il2CppStringArray internalIdPrefixes, string v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalIdPrefixes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.NativeMethodInfoPtr_ExpandInternalId_Internal_Static_String_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002BEC File Offset: 0x00000DEC
		public ContentCatalogData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00010888 File Offset: 0x0000EA88
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public unsafe static int kMagic
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ContentCatalogData.NativeFieldInfoPtr_kMagic, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentCatalogData.NativeFieldInfoPtr_kMagic, (void*)(&value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000108A4 File Offset: 0x0000EAA4
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00002C03 File Offset: 0x00000E03
		public unsafe static int kVersion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ContentCatalogData.NativeFieldInfoPtr_kVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentCatalogData.NativeFieldInfoPtr_kVersion, (void*)(&value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000108C0 File Offset: 0x0000EAC0
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00002C11 File Offset: 0x00000E11
		public unsafe string LocalHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_LocalHash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_LocalHash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000108E8 File Offset: 0x0000EAE8
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00002C30 File Offset: 0x00000E30
		public unsafe IResourceLocation location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00010918 File Offset: 0x0000EB18
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00002C4F File Offset: 0x00000E4F
		public unsafe string m_LocatorId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_LocatorId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_LocatorId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00010940 File Offset: 0x0000EB40
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00002C6E File Offset: 0x00000E6E
		public unsafe string m_BuildResultHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_BuildResultHash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_BuildResultHash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00010968 File Offset: 0x0000EB68
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00002C8D File Offset: 0x00000E8D
		public ObjectInitializationData m_InstanceProviderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_InstanceProviderData);
				return new ObjectInitializationData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_InstanceProviderData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00010998 File Offset: 0x0000EB98
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002CBB File Offset: 0x00000EBB
		public ObjectInitializationData m_SceneProviderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_SceneProviderData);
				return new ObjectInitializationData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_SceneProviderData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002CE9 File Offset: 0x00000EE9
		public unsafe List<ObjectInitializationData> m_ResourceProviderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_ResourceProviderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectInitializationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_ResourceProviderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000109F8 File Offset: 0x0000EBF8
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00002D08 File Offset: 0x00000F08
		public unsafe IList<ContentCatalogDataEntry> m_Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ContentCatalogDataEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00010A28 File Offset: 0x0000EC28
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002D27 File Offset: 0x00000F27
		public unsafe Il2CppStringArray m_ProviderIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_ProviderIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_ProviderIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00010A58 File Offset: 0x0000EC58
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002D46 File Offset: 0x00000F46
		public unsafe Il2CppStringArray m_InternalIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_InternalIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_InternalIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00010A88 File Offset: 0x0000EC88
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002D65 File Offset: 0x00000F65
		public unsafe string m_KeyDataString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_KeyDataString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_KeyDataString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002D84 File Offset: 0x00000F84
		public unsafe string m_BucketDataString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_BucketDataString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_BucketDataString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00002DA3 File Offset: 0x00000FA3
		public unsafe string m_EntryDataString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_EntryDataString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_EntryDataString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00010B00 File Offset: 0x0000ED00
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00002DC2 File Offset: 0x00000FC2
		public unsafe static int kBytesPerInt32
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ContentCatalogData.NativeFieldInfoPtr_kBytesPerInt32, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentCatalogData.NativeFieldInfoPtr_kBytesPerInt32, (void*)(&value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00010B1C File Offset: 0x0000ED1C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public unsafe static int k_EntryDataItemPerEntry
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ContentCatalogData.NativeFieldInfoPtr_k_EntryDataItemPerEntry, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentCatalogData.NativeFieldInfoPtr_k_EntryDataItemPerEntry, (void*)(&value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00010B38 File Offset: 0x0000ED38
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00002DDE File Offset: 0x00000FDE
		public unsafe string m_ExtraDataString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_ExtraDataString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_ExtraDataString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00010B60 File Offset: 0x0000ED60
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002DFD File Offset: 0x00000FFD
		public unsafe Il2CppReferenceArray<SerializedType> m_resourceTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_resourceTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_resourceTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00010B90 File Offset: 0x0000ED90
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00002E1C File Offset: 0x0000101C
		public unsafe Il2CppStringArray m_InternalIdPrefixes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_InternalIdPrefixes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.NativeFieldInfoPtr_m_InternalIdPrefixes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_kMagic;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_kVersion;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_LocalHash;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_m_LocatorId;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_m_BuildResultHash;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceProviderData;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_m_SceneProviderData;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceProviderData;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_m_Entries;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_m_ProviderIds;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalIds;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyDataString;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_m_BucketDataString;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_m_EntryDataString;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_kBytesPerInt32;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_k_EntryDataItemPerEntry;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraDataString;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_m_resourceTypes;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalIdPrefixes;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildResultHash_Public_get_String_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_set_BuildResultHash_Public_set_Void_String_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_get_String_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_set_ProviderId_Internal_set_Void_String_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceProviderData_Public_get_ObjectInitializationData_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_set_InstanceProviderData_Public_set_Void_ObjectInitializationData_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneProviderData_Public_get_ObjectInitializationData_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneProviderData_Public_set_Void_ObjectInitializationData_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceProviderData_Public_get_List_1_ObjectInitializationData_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_set_ResourceProviderData_Public_set_Void_List_1_ObjectInitializationData_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderIds_Public_get_Il2CppStringArray_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalIds_Public_get_Il2CppStringArray_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromFile_Internal_Static_ContentCatalogData_String_Int32_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_SaveToFile_Internal_Void_String_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_CleanData_Internal_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomLocator_Internal_ResourceLocationMap_String_String_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocator_Public_ResourceLocationMap_String_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Internal_IList_1_ContentCatalogDataEntry_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_ExpandInternalId_Internal_Static_String_Il2CppStringArray_String_0;

		// Token: 0x0200007C RID: 124
		public sealed class Bucket : ValueType
		{
			// Token: 0x06000533 RID: 1331 RVA: 0x00018968 File Offset: 0x00016B68
			// Note: this type is marked as 'beforefieldinit'.
			static Bucket()
			{
				Il2CppClassPointerStore<ContentCatalogData.Bucket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "Bucket");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogData.Bucket>.NativeClassPtr);
				ContentCatalogData.Bucket.NativeFieldInfoPtr_dataOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.Bucket>.NativeClassPtr, "dataOffset");
				ContentCatalogData.Bucket.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.Bucket>.NativeClassPtr, "entries");
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x000042A4 File Offset: 0x000024A4
			public Bucket(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x000042AD File Offset: 0x000024AD
			public Bucket()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogData.Bucket>.NativeClassPtr))
			{
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000536 RID: 1334 RVA: 0x000189BC File Offset: 0x00016BBC
			// (set) Token: 0x06000537 RID: 1335 RVA: 0x000042BF File Offset: 0x000024BF
			public unsafe int dataOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.Bucket.NativeFieldInfoPtr_dataOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.Bucket.NativeFieldInfoPtr_dataOffset)) = value;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06000538 RID: 1336 RVA: 0x000189E4 File Offset: 0x00016BE4
			// (set) Token: 0x06000539 RID: 1337 RVA: 0x000042DA File Offset: 0x000024DA
			public unsafe Il2CppStructArray<int> entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.Bucket.NativeFieldInfoPtr_entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.Bucket.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003A7 RID: 935
			private static readonly IntPtr NativeFieldInfoPtr_dataOffset;

			// Token: 0x040003A8 RID: 936
			private static readonly IntPtr NativeFieldInfoPtr_entries;
		}

		// Token: 0x0200007D RID: 125
		public class CompactLocation : Object
		{
			// Token: 0x0600053A RID: 1338 RVA: 0x00018A14 File Offset: 0x00016C14
			// Note: this type is marked as 'beforefieldinit'.
			static CompactLocation()
			{
				Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "CompactLocation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr);
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Locator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_Locator");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_InternalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_InternalId");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_ProviderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_ProviderId");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_Dependency");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_Data");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_HashCode");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_DependencyHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_DependencyHashCode");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_PrimaryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_PrimaryKey");
				ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, "m_Type");
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663840);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663841);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663842);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663843);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663844);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663845);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663846);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663847);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663848);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663849);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663850);
				ContentCatalogData.CompactLocation.NativeMethodInfoPtr__ctor_Public_Void_ResourceLocationMap_String_String_Object_Object_Int32_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr, 100663851);
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x0600053B RID: 1339 RVA: 0x00018BE4 File Offset: 0x00016DE4
			public unsafe virtual string InternalId
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x00018C1C File Offset: 0x00016E1C
			public unsafe virtual string ProviderId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x0600053D RID: 1341 RVA: 0x00018C54 File Offset: 0x00016E54
			public unsafe virtual IList<IResourceLocation> Dependencies
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163903, XrefRangeEnd = 1163910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr3) : null;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x00018C94 File Offset: 0x00016E94
			public unsafe virtual bool HasDependencies
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1020000, RefRangeEnd = 1020001, XrefRangeStart = 1020000, XrefRangeEnd = 1020001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x0600053F RID: 1343 RVA: 0x00018CD0 File Offset: 0x00016ED0
			public unsafe virtual int DependencyHashCode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000540 RID: 1344 RVA: 0x00018D0C File Offset: 0x00016F0C
			public unsafe virtual Object Data
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000541 RID: 1345 RVA: 0x00018D4C File Offset: 0x00016F4C
			// (set) Token: 0x06000542 RID: 1346 RVA: 0x00018D84 File Offset: 0x00016F84
			public unsafe virtual string PrimaryKey
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x00018DC8 File Offset: 0x00016FC8
			public unsafe virtual Type ResourceType
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00018E08 File Offset: 0x00017008
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentCatalogData.CompactLocation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00018E4C File Offset: 0x0001704C
			[CallerCount(0)]
			public unsafe virtual int Hash(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x00018E9C File Offset: 0x0001709C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1163928, RefRangeEnd = 1163929, XrefRangeStart = 1163910, XrefRangeEnd = 1163928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompactLocation(ResourceLocationMap locator, string internalId, string providerId, Object dependencyKey, Object data, int depHash, string primaryKey, Type type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogData.CompactLocation>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalId);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerId);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dependencyKey);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depHash;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(primaryKey);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.CompactLocation.NativeMethodInfoPtr__ctor_Public_Void_ResourceLocationMap_String_String_Object_Object_Int32_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x000042F9 File Offset: 0x000024F9
			public CompactLocation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x00018F68 File Offset: 0x00017168
			// (set) Token: 0x06000549 RID: 1353 RVA: 0x00004302 File Offset: 0x00002502
			public unsafe ResourceLocationMap m_Locator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Locator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceLocationMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Locator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x0600054A RID: 1354 RVA: 0x00018F98 File Offset: 0x00017198
			// (set) Token: 0x0600054B RID: 1355 RVA: 0x00004321 File Offset: 0x00002521
			public unsafe string m_InternalId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_InternalId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_InternalId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x0600054C RID: 1356 RVA: 0x00018FC0 File Offset: 0x000171C0
			// (set) Token: 0x0600054D RID: 1357 RVA: 0x00004340 File Offset: 0x00002540
			public unsafe string m_ProviderId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_ProviderId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_ProviderId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x0600054E RID: 1358 RVA: 0x00018FE8 File Offset: 0x000171E8
			// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000435F File Offset: 0x0000255F
			public unsafe Object m_Dependency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Dependency);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Dependency), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x06000550 RID: 1360 RVA: 0x00019018 File Offset: 0x00017218
			// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000437E File Offset: 0x0000257E
			public unsafe Object m_Data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000552 RID: 1362 RVA: 0x00019048 File Offset: 0x00017248
			// (set) Token: 0x06000553 RID: 1363 RVA: 0x0000439D File Offset: 0x0000259D
			public unsafe int m_HashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_HashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_HashCode)) = value;
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x06000554 RID: 1364 RVA: 0x00019070 File Offset: 0x00017270
			// (set) Token: 0x06000555 RID: 1365 RVA: 0x000043B8 File Offset: 0x000025B8
			public unsafe int m_DependencyHashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_DependencyHashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_DependencyHashCode)) = value;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x06000556 RID: 1366 RVA: 0x00019098 File Offset: 0x00017298
			// (set) Token: 0x06000557 RID: 1367 RVA: 0x000043D3 File Offset: 0x000025D3
			public unsafe string m_PrimaryKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_PrimaryKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_PrimaryKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000558 RID: 1368 RVA: 0x000190C0 File Offset: 0x000172C0
			// (set) Token: 0x06000559 RID: 1369 RVA: 0x000043F2 File Offset: 0x000025F2
			public unsafe Type m_Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentCatalogData.CompactLocation.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003A9 RID: 937
			private static readonly IntPtr NativeFieldInfoPtr_m_Locator;

			// Token: 0x040003AA RID: 938
			private static readonly IntPtr NativeFieldInfoPtr_m_InternalId;

			// Token: 0x040003AB RID: 939
			private static readonly IntPtr NativeFieldInfoPtr_m_ProviderId;

			// Token: 0x040003AC RID: 940
			private static readonly IntPtr NativeFieldInfoPtr_m_Dependency;

			// Token: 0x040003AD RID: 941
			private static readonly IntPtr NativeFieldInfoPtr_m_Data;

			// Token: 0x040003AE RID: 942
			private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

			// Token: 0x040003AF RID: 943
			private static readonly IntPtr NativeFieldInfoPtr_m_DependencyHashCode;

			// Token: 0x040003B0 RID: 944
			private static readonly IntPtr NativeFieldInfoPtr_m_PrimaryKey;

			// Token: 0x040003B1 RID: 945
			private static readonly IntPtr NativeFieldInfoPtr_m_Type;

			// Token: 0x040003B2 RID: 946
			private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040003B3 RID: 947
			private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040003B4 RID: 948
			private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0;

			// Token: 0x040003B5 RID: 949
			private static readonly IntPtr NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040003B6 RID: 950
			private static readonly IntPtr NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040003B7 RID: 951
			private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040003B8 RID: 952
			private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040003B9 RID: 953
			private static readonly IntPtr NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_String_0;

			// Token: 0x040003BA RID: 954
			private static readonly IntPtr NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0;

			// Token: 0x040003BB RID: 955
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040003BC RID: 956
			private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0;

			// Token: 0x040003BD RID: 957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceLocationMap_String_String_Object_Object_Int32_String_Type_0;
		}

		// Token: 0x0200007E RID: 126
		[ObfuscatedName("UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600055A RID: 1370 RVA: 0x000190F0 File Offset: 0x000172F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContentCatalogData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr);
				ContentCatalogData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr, "<>9");
				ContentCatalogData.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr, "<>9__48_0");
				ContentCatalogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr, 100663853);
				ContentCatalogData.__c.NativeMethodInfoPtr__GetData_b__48_0_Internal_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr, 100663854);
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x0001916C File Offset: 0x0001736C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentCatalogData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x000191A8 File Offset: 0x000173A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163929, XrefRangeEnd = 1163933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetData_b__48_0(IResourceLocation d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentCatalogData.__c.NativeMethodInfoPtr__GetData_b__48_0_Internal_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x00004411 File Offset: 0x00002611
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x000191F0 File Offset: 0x000173F0
			// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000441A File Offset: 0x0000261A
			public unsafe static ContentCatalogData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContentCatalogData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentCatalogData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContentCatalogData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x00019218 File Offset: 0x00017418
			// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000442C File Offset: 0x0000262C
			public unsafe static Func<IResourceLocation, string> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContentCatalogData.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IResourceLocation, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContentCatalogData.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003BE RID: 958
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040003BF RID: 959
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x040003C0 RID: 960
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003C1 RID: 961
			private static readonly IntPtr NativeMethodInfoPtr__GetData_b__48_0_Internal_String_IResourceLocation_0;
		}
	}
}
