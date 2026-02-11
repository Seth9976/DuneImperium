using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	public class ResourceManagerRuntimeData : Object
	{
		// Token: 0x06000331 RID: 817 RVA: 0x00012950 File Offset: 0x00010B50
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManagerRuntimeData()
		{
			Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Initialization", "ResourceManagerRuntimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr);
			ResourceManagerRuntimeData.NativeFieldInfoPtr_kCatalogAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "kCatalogAddress");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_buildTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_buildTarget");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_SettingsHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_SettingsHash");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CatalogLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_CatalogLocations");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_ProfileEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_ProfileEvents");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_LogResourceManagerExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_LogResourceManagerExceptions");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_ExtraInitializationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_ExtraInitializationData");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_DisableCatalogUpdateOnStart");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_IsLocalCatalogInBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_IsLocalCatalogInBundle");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CertificateHandlerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_CertificateHandlerType");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_AddressablesVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_AddressablesVersion");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_maxConcurrentWebRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_maxConcurrentWebRequests");
			ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CatalogRequestsTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, "m_CatalogRequestsTimeout");
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_BuildTarget_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663928);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_BuildTarget_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663929);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_SettingsHash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663930);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_SettingsHash_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663931);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_CatalogLocations_Public_get_List_1_ResourceLocationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663932);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_ProfileEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663933);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_ProfileEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663934);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_LogResourceManagerExceptions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663935);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_LogResourceManagerExceptions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663936);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_InitializationObjects_Public_get_List_1_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663937);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_DisableCatalogUpdateOnStartup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663938);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_DisableCatalogUpdateOnStartup_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663939);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_IsLocalCatalogInBundle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663940);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_IsLocalCatalogInBundle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663941);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_CertificateHandlerType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663942);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_CertificateHandlerType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663943);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_AddressablesVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663944);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_AddressablesVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663945);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_MaxConcurrentWebRequests_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663946);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_MaxConcurrentWebRequests_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663947);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_get_CatalogRequestsTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663948);
			ResourceManagerRuntimeData.NativeMethodInfoPtr_set_CatalogRequestsTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663949);
			ResourceManagerRuntimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr, 100663950);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00012C50 File Offset: 0x00010E50
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00012C88 File Offset: 0x00010E88
		public unsafe string BuildTarget
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_BuildTarget_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_BuildTarget_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00012CCC File Offset: 0x00010ECC
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00012D04 File Offset: 0x00010F04
		public unsafe string SettingsHash
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_SettingsHash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_SettingsHash_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00012D48 File Offset: 0x00010F48
		public unsafe List<ResourceLocationData> CatalogLocations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_CatalogLocations_Public_get_List_1_ResourceLocationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ResourceLocationData>>(intPtr3) : null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00012D88 File Offset: 0x00010F88
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00012DC4 File Offset: 0x00010FC4
		public unsafe bool ProfileEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_ProfileEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_ProfileEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00012E04 File Offset: 0x00011004
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00012E40 File Offset: 0x00011040
		public unsafe bool LogResourceManagerExceptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_LogResourceManagerExceptions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_LogResourceManagerExceptions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00012E80 File Offset: 0x00011080
		public unsafe List<ObjectInitializationData> InitializationObjects
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_InitializationObjects_Public_get_List_1_ObjectInitializationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ObjectInitializationData>>(intPtr3) : null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00012EC0 File Offset: 0x000110C0
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00012EFC File Offset: 0x000110FC
		public unsafe bool DisableCatalogUpdateOnStartup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_DisableCatalogUpdateOnStartup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_DisableCatalogUpdateOnStartup_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00012F3C File Offset: 0x0001113C
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00012F78 File Offset: 0x00011178
		public unsafe bool IsLocalCatalogInBundle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_IsLocalCatalogInBundle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_IsLocalCatalogInBundle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00012FB8 File Offset: 0x000111B8
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00012FF8 File Offset: 0x000111F8
		public unsafe Type CertificateHandlerType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1165313, RefRangeEnd = 1165315, XrefRangeStart = 1165312, XrefRangeEnd = 1165313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_CertificateHandlerType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165315, XrefRangeEnd = 1165316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_CertificateHandlerType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001303C File Offset: 0x0001123C
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00013074 File Offset: 0x00011274
		public unsafe string AddressablesVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_AddressablesVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_AddressablesVersion_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000130B8 File Offset: 0x000112B8
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000130F4 File Offset: 0x000112F4
		public unsafe int MaxConcurrentWebRequests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_MaxConcurrentWebRequests_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_MaxConcurrentWebRequests_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00013134 File Offset: 0x00011334
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00013170 File Offset: 0x00011370
		public unsafe int CatalogRequestsTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_get_CatalogRequestsTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr_set_CatalogRequestsTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000131B0 File Offset: 0x000113B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165316, XrefRangeEnd = 1165331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManagerRuntimeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManagerRuntimeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerRuntimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003150 File Offset: 0x00001350
		public ResourceManagerRuntimeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000131EC File Offset: 0x000113EC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003159 File Offset: 0x00001359
		public unsafe static string kCatalogAddress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourceManagerRuntimeData.NativeFieldInfoPtr_kCatalogAddress, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManagerRuntimeData.NativeFieldInfoPtr_kCatalogAddress, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0001320C File Offset: 0x0001140C
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000316B File Offset: 0x0000136B
		public unsafe string m_buildTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_buildTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_buildTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00013234 File Offset: 0x00011434
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000318A File Offset: 0x0000138A
		public unsafe string m_SettingsHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_SettingsHash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_SettingsHash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001325C File Offset: 0x0001145C
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000031A9 File Offset: 0x000013A9
		public unsafe List<ResourceLocationData> m_CatalogLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CatalogLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResourceLocationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CatalogLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0001328C File Offset: 0x0001148C
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000031C8 File Offset: 0x000013C8
		public unsafe bool m_ProfileEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_ProfileEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_ProfileEvents)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000132B4 File Offset: 0x000114B4
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000031E3 File Offset: 0x000013E3
		public unsafe bool m_LogResourceManagerExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_LogResourceManagerExceptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_LogResourceManagerExceptions)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000132DC File Offset: 0x000114DC
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000031FE File Offset: 0x000013FE
		public unsafe List<ObjectInitializationData> m_ExtraInitializationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_ExtraInitializationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectInitializationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_ExtraInitializationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0001330C File Offset: 0x0001150C
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000321D File Offset: 0x0000141D
		public unsafe bool m_DisableCatalogUpdateOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00013334 File Offset: 0x00011534
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003238 File Offset: 0x00001438
		public unsafe bool m_IsLocalCatalogInBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_IsLocalCatalogInBundle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_IsLocalCatalogInBundle)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001335C File Offset: 0x0001155C
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003253 File Offset: 0x00001453
		public SerializedType m_CertificateHandlerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CertificateHandlerType);
				return new SerializedType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CertificateHandlerType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001338C File Offset: 0x0001158C
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003281 File Offset: 0x00001481
		public unsafe string m_AddressablesVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_AddressablesVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_AddressablesVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000133B4 File Offset: 0x000115B4
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000032A0 File Offset: 0x000014A0
		public unsafe int m_maxConcurrentWebRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_maxConcurrentWebRequests);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_maxConcurrentWebRequests)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000133DC File Offset: 0x000115DC
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000032BB File Offset: 0x000014BB
		public unsafe int m_CatalogRequestsTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CatalogRequestsTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerRuntimeData.NativeFieldInfoPtr_m_CatalogRequestsTimeout)) = value;
			}
		}

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_kCatalogAddress;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_m_buildTarget;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_m_SettingsHash;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_m_CatalogLocations;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfileEvents;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_m_LogResourceManagerExceptions;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraInitializationData;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_m_DisableCatalogUpdateOnStart;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_m_IsLocalCatalogInBundle;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_m_CertificateHandlerType;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_m_AddressablesVersion;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_m_maxConcurrentWebRequests;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_m_CatalogRequestsTimeout;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildTarget_Public_get_String_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_set_BuildTarget_Public_set_Void_String_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_SettingsHash_Public_get_String_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_set_SettingsHash_Public_set_Void_String_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogLocations_Public_get_List_1_ResourceLocationData_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_get_ProfileEvents_Public_get_Boolean_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_set_ProfileEvents_Public_set_Void_Boolean_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_get_LogResourceManagerExceptions_Public_get_Boolean_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_set_LogResourceManagerExceptions_Public_set_Void_Boolean_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializationObjects_Public_get_List_1_ObjectInitializationData_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableCatalogUpdateOnStartup_Public_get_Boolean_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableCatalogUpdateOnStartup_Public_set_Void_Boolean_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalCatalogInBundle_Public_get_Boolean_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalCatalogInBundle_Public_set_Void_Boolean_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateHandlerType_Public_get_Type_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateHandlerType_Public_set_Void_Type_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressablesVersion_Public_get_String_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_set_AddressablesVersion_Public_set_Void_String_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxConcurrentWebRequests_Public_get_Int32_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxConcurrentWebRequests_Public_set_Void_Int32_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogRequestsTimeout_Public_get_Int32_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_set_CatalogRequestsTimeout_Public_set_Void_Int32_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
