using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class AssetBundleRequestOptions : Object
	{
		// Token: 0x06000243 RID: 579 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRequestOptions()
		{
			Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "AssetBundleRequestOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr);
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_Hash");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_Crc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_Crc");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_Timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_Timeout");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_ChunkedTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_ChunkedTransfer");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_RedirectLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_RedirectLimit");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_RetryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_RetryCount");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_BundleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_BundleName");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_AssetLoadMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_AssetLoadMode");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_BundleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_BundleSize");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_UseCrcForCachedBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_UseCrcForCachedBundles");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_UseUWRForLocalBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_UseUWRForLocalBundles");
			AssetBundleRequestOptions.NativeFieldInfoPtr_m_ClearOtherCachedVersionsWhenLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, "m_ClearOtherCachedVersionsWhenLoaded");
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_Hash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663676);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_Hash_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663677);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_Crc_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663678);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_Crc_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663679);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_Timeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663680);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_Timeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663681);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_ChunkedTransfer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663682);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_ChunkedTransfer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663683);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_RedirectLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663684);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_RedirectLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663685);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_RetryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663686);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_RetryCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663687);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_BundleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663688);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_BundleName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663689);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_AssetLoadMode_Public_get_AssetLoadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663690);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_AssetLoadMode_Public_set_Void_AssetLoadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663691);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_BundleSize_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663692);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_BundleSize_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663693);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_UseCrcForCachedBundle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663694);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_UseCrcForCachedBundle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663695);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_UseUnityWebRequestForLocalBundles_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663696);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_UseUnityWebRequestForLocalBundles_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663697);
			AssetBundleRequestOptions.NativeMethodInfoPtr_get_ClearOtherCachedVersionsWhenLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663698);
			AssetBundleRequestOptions.NativeMethodInfoPtr_set_ClearOtherCachedVersionsWhenLoaded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663699);
			AssetBundleRequestOptions.NativeMethodInfoPtr_ComputeSize_Public_Virtual_New_Int64_IResourceLocation_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663700);
			AssetBundleRequestOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr, 100663701);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0000DE18 File Offset: 0x0000C018
		public unsafe string Hash
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_Hash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_Hash_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000DE5C File Offset: 0x0000C05C
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000DE98 File Offset: 0x0000C098
		public unsafe uint Crc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_Crc_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_Crc_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000DF14 File Offset: 0x0000C114
		public unsafe int Timeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_Timeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_Timeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000DF54 File Offset: 0x0000C154
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0000DF90 File Offset: 0x0000C190
		public unsafe bool ChunkedTransfer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_ChunkedTransfer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_ChunkedTransfer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000E00C File Offset: 0x0000C20C
		public unsafe int RedirectLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_RedirectLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_RedirectLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000E04C File Offset: 0x0000C24C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000E088 File Offset: 0x0000C288
		public unsafe int RetryCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_RetryCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_RetryCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000E100 File Offset: 0x0000C300
		public unsafe string BundleName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_BundleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_BundleName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000E144 File Offset: 0x0000C344
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000E180 File Offset: 0x0000C380
		public unsafe AssetLoadMode AssetLoadMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_AssetLoadMode_Public_get_AssetLoadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_AssetLoadMode_Public_set_Void_AssetLoadMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		public unsafe long BundleSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_BundleSize_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_BundleSize_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000E23C File Offset: 0x0000C43C
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0000E278 File Offset: 0x0000C478
		public unsafe bool UseCrcForCachedBundle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_UseCrcForCachedBundle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_UseCrcForCachedBundle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0000E2F4 File Offset: 0x0000C4F4
		public unsafe bool UseUnityWebRequestForLocalBundles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_UseUnityWebRequestForLocalBundles_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_UseUnityWebRequestForLocalBundles_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000E334 File Offset: 0x0000C534
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000E370 File Offset: 0x0000C570
		public unsafe bool ClearOtherCachedVersionsWhenLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_get_ClearOtherCachedVersionsWhenLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr_set_ClearOtherCachedVersionsWhenLoaded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139262, XrefRangeEnd = 1139274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleRequestOptions.NativeMethodInfoPtr_ComputeSize_Public_Virtual_New_Int64_IResourceLocation_ResourceManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000E41C File Offset: 0x0000C61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139274, XrefRangeEnd = 1139279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequestOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleRequestOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequestOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002EB5 File Offset: 0x000010B5
		public AssetBundleRequestOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000E458 File Offset: 0x0000C658
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002EBE File Offset: 0x000010BE
		public unsafe string m_Hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_Hash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_Hash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000E480 File Offset: 0x0000C680
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00002EDD File Offset: 0x000010DD
		public unsafe uint m_Crc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_Crc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_Crc)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002EF8 File Offset: 0x000010F8
		public unsafe int m_Timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_Timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_Timeout)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00002F13 File Offset: 0x00001113
		public unsafe bool m_ChunkedTransfer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_ChunkedTransfer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_ChunkedTransfer)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00002F2E File Offset: 0x0000112E
		public unsafe int m_RedirectLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_RedirectLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_RedirectLimit)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000E520 File Offset: 0x0000C720
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002F49 File Offset: 0x00001149
		public unsafe int m_RetryCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_RetryCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_RetryCount)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000E548 File Offset: 0x0000C748
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002F64 File Offset: 0x00001164
		public unsafe string m_BundleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_BundleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_BundleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000E570 File Offset: 0x0000C770
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002F83 File Offset: 0x00001183
		public unsafe AssetLoadMode m_AssetLoadMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_AssetLoadMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_AssetLoadMode)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000E598 File Offset: 0x0000C798
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002F9E File Offset: 0x0000119E
		public unsafe long m_BundleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_BundleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_BundleSize)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002FB9 File Offset: 0x000011B9
		public unsafe bool m_UseCrcForCachedBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_UseCrcForCachedBundles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_UseCrcForCachedBundles)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002FD4 File Offset: 0x000011D4
		public unsafe bool m_UseUWRForLocalBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_UseUWRForLocalBundles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_UseUWRForLocalBundles)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000E610 File Offset: 0x0000C810
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002FEF File Offset: 0x000011EF
		public unsafe bool m_ClearOtherCachedVersionsWhenLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_ClearOtherCachedVersionsWhenLoaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleRequestOptions.NativeFieldInfoPtr_m_ClearOtherCachedVersionsWhenLoaded)) = value;
			}
		}

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_m_Hash;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_m_Crc;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_m_Timeout;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkedTransfer;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_RedirectLimit;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_RetryCount;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_BundleName;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetLoadMode;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_m_BundleSize;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_m_UseCrcForCachedBundles;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_m_UseUWRForLocalBundles;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearOtherCachedVersionsWhenLoaded;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_get_Hash_Public_get_String_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_set_Hash_Public_set_Void_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_get_Crc_Public_get_UInt32_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_set_Crc_Public_set_Void_UInt32_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_Timeout_Public_get_Int32_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_set_Timeout_Public_set_Void_Int32_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkedTransfer_Public_get_Boolean_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkedTransfer_Public_set_Void_Boolean_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectLimit_Public_get_Int32_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_set_RedirectLimit_Public_set_Void_Int32_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_RetryCount_Public_get_Int32_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_set_RetryCount_Public_set_Void_Int32_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_BundleName_Public_get_String_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_set_BundleName_Public_set_Void_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetLoadMode_Public_get_AssetLoadMode_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetLoadMode_Public_set_Void_AssetLoadMode_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_BundleSize_Public_get_Int64_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_set_BundleSize_Public_set_Void_Int64_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCrcForCachedBundle_Public_get_Boolean_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_UseCrcForCachedBundle_Public_set_Void_Boolean_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_UseUnityWebRequestForLocalBundles_Public_get_Boolean_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_set_UseUnityWebRequestForLocalBundles_Public_set_Void_Boolean_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_ClearOtherCachedVersionsWhenLoaded_Public_get_Boolean_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_set_ClearOtherCachedVersionsWhenLoaded_Public_set_Void_Boolean_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSize_Public_Virtual_New_Int64_IResourceLocation_ResourceManager_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
