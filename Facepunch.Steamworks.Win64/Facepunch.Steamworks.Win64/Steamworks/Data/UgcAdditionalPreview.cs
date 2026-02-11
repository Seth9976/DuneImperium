using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200020D RID: 525
	public sealed class UgcAdditionalPreview : ValueType
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x0007F890 File Offset: 0x0007DA90
		// Note: this type is marked as 'beforefieldinit'.
		static UgcAdditionalPreview()
		{
			Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UgcAdditionalPreview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr);
			UgcAdditionalPreview.NativeFieldInfoPtr__UrlOrVideoID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, "<UrlOrVideoID>k__BackingField");
			UgcAdditionalPreview.NativeFieldInfoPtr__OriginalFileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, "<OriginalFileName>k__BackingField");
			UgcAdditionalPreview.NativeFieldInfoPtr__ItemPreviewType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, "<ItemPreviewType>k__BackingField");
			UgcAdditionalPreview.NativeMethodInfoPtr__ctor_Internal_Void_String_String_ItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668131);
			UgcAdditionalPreview.NativeMethodInfoPtr_get_UrlOrVideoID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668132);
			UgcAdditionalPreview.NativeMethodInfoPtr_set_UrlOrVideoID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668133);
			UgcAdditionalPreview.NativeMethodInfoPtr_get_OriginalFileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668134);
			UgcAdditionalPreview.NativeMethodInfoPtr_set_OriginalFileName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668135);
			UgcAdditionalPreview.NativeMethodInfoPtr_get_ItemPreviewType_Public_get_ItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668136);
			UgcAdditionalPreview.NativeMethodInfoPtr_set_ItemPreviewType_Private_set_Void_ItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr, 100668137);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0007F988 File Offset: 0x0007DB88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 862668, RefRangeEnd = 862671, XrefRangeStart = 862668, XrefRangeEnd = 862671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UgcAdditionalPreview(string urlOrVideoID, string originalFileName, ItemPreviewType itemPreviewType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(urlOrVideoID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemPreviewType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr__ctor_Internal_Void_String_String_ItemPreviewType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0007F9F8 File Offset: 0x0007DBF8
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0007FA34 File Offset: 0x0007DC34
		public unsafe string UrlOrVideoID
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr_get_UrlOrVideoID_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr_set_UrlOrVideoID_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0007FA7C File Offset: 0x0007DC7C
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0007FAB8 File Offset: 0x0007DCB8
		public unsafe string OriginalFileName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr_get_OriginalFileName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr_set_OriginalFileName_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0007FB00 File Offset: 0x0007DD00
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0007FB44 File Offset: 0x0007DD44
		public unsafe ItemPreviewType ItemPreviewType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr_get_ItemPreviewType_Public_get_ItemPreviewType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UgcAdditionalPreview.NativeMethodInfoPtr_set_ItemPreviewType_Private_set_Void_ItemPreviewType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00008B35 File Offset: 0x00006D35
		public UgcAdditionalPreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00008B3E File Offset: 0x00006D3E
		public UgcAdditionalPreview()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UgcAdditionalPreview>.NativeClassPtr))
		{
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0007FB88 File Offset: 0x0007DD88
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x00008B50 File Offset: 0x00006D50
		public unsafe string _UrlOrVideoID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UgcAdditionalPreview.NativeFieldInfoPtr__UrlOrVideoID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UgcAdditionalPreview.NativeFieldInfoPtr__UrlOrVideoID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0007FBB0 File Offset: 0x0007DDB0
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x00008B6F File Offset: 0x00006D6F
		public unsafe string _OriginalFileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UgcAdditionalPreview.NativeFieldInfoPtr__OriginalFileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UgcAdditionalPreview.NativeFieldInfoPtr__OriginalFileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0007FBD8 File Offset: 0x0007DDD8
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x00008B8E File Offset: 0x00006D8E
		public unsafe ItemPreviewType _ItemPreviewType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UgcAdditionalPreview.NativeFieldInfoPtr__ItemPreviewType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UgcAdditionalPreview.NativeFieldInfoPtr__ItemPreviewType_k__BackingField)) = value;
			}
		}

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeFieldInfoPtr__UrlOrVideoID_k__BackingField;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeFieldInfoPtr__OriginalFileName_k__BackingField;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeFieldInfoPtr__ItemPreviewType_k__BackingField;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_ItemPreviewType_0;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeMethodInfoPtr_get_UrlOrVideoID_Public_get_String_0;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeMethodInfoPtr_set_UrlOrVideoID_Private_set_Void_String_0;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalFileName_Public_get_String_0;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr_set_OriginalFileName_Private_set_Void_String_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemPreviewType_Public_get_ItemPreviewType_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemPreviewType_Private_set_Void_ItemPreviewType_0;
	}
}
