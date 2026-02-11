using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000005 RID: 5
	public class AddBandingRequest : Object
	{
		// Token: 0x06000056 RID: 86 RVA: 0x0000C510 File Offset: 0x0000A710
		// Note: this type is marked as 'beforefieldinit'.
		static AddBandingRequest()
		{
			Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddBandingRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr);
			AddBandingRequest.NativeFieldInfoPtr__BandedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, "<BandedRange>k__BackingField");
			AddBandingRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddBandingRequest.NativeMethodInfoPtr_get_BandedRange_Public_Virtual_New_get_BandedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, 100663561);
			AddBandingRequest.NativeMethodInfoPtr_set_BandedRange_Public_Virtual_New_set_Void_BandedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, 100663562);
			AddBandingRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, 100663563);
			AddBandingRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, 100663564);
			AddBandingRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr, 100663565);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000C618 File Offset: 0x0000A818
		public unsafe virtual BandedRange BandedRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddBandingRequest.NativeMethodInfoPtr_get_BandedRange_Public_Virtual_New_get_BandedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BandedRange>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddBandingRequest.NativeMethodInfoPtr_set_BandedRange_Public_Virtual_New_set_Void_BandedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000C668 File Offset: 0x0000A868
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddBandingRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddBandingRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000C6FC File Offset: 0x0000A8FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddBandingRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddBandingRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddBandingRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022BA File Offset: 0x000004BA
		public AddBandingRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000C738 File Offset: 0x0000A938
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000022C3 File Offset: 0x000004C3
		public unsafe BandedRange _BandedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddBandingRequest.NativeFieldInfoPtr__BandedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BandedRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddBandingRequest.NativeFieldInfoPtr__BandedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000C768 File Offset: 0x0000A968
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000022E2 File Offset: 0x000004E2
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddBandingRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddBandingRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr__BandedRange_k__BackingField;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_BandedRange_Public_Virtual_New_get_BandedRange_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_set_BandedRange_Public_Virtual_New_set_Void_BandedRange_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
