using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000011 RID: 17
	public class AddProtectedRangeResponse : Object
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0000E414 File Offset: 0x0000C614
		// Note: this type is marked as 'beforefieldinit'.
		static AddProtectedRangeResponse()
		{
			Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddProtectedRangeResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr);
			AddProtectedRangeResponse.NativeFieldInfoPtr__ProtectedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, "<ProtectedRange>k__BackingField");
			AddProtectedRangeResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, "<ETag>k__BackingField");
			AddProtectedRangeResponse.NativeMethodInfoPtr_get_ProtectedRange_Public_Virtual_New_get_ProtectedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, 100663623);
			AddProtectedRangeResponse.NativeMethodInfoPtr_set_ProtectedRange_Public_Virtual_New_set_Void_ProtectedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, 100663624);
			AddProtectedRangeResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, 100663625);
			AddProtectedRangeResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, 100663626);
			AddProtectedRangeResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr, 100663627);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000E51C File Offset: 0x0000C71C
		public unsafe virtual ProtectedRange ProtectedRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeResponse.NativeMethodInfoPtr_get_ProtectedRange_Public_Virtual_New_get_ProtectedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProtectedRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeResponse.NativeMethodInfoPtr_set_ProtectedRange_Public_Virtual_New_set_Void_ProtectedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000E56C File Offset: 0x0000C76C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000E600 File Offset: 0x0000C800
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddProtectedRangeResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddProtectedRangeResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddProtectedRangeResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000263C File Offset: 0x0000083C
		public AddProtectedRangeResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000E63C File Offset: 0x0000C83C
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002645 File Offset: 0x00000845
		public unsafe ProtectedRange _ProtectedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeResponse.NativeFieldInfoPtr__ProtectedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProtectedRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeResponse.NativeFieldInfoPtr__ProtectedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000E66C File Offset: 0x0000C86C
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002664 File Offset: 0x00000864
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr__ProtectedRange_k__BackingField;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtectedRange_Public_Virtual_New_get_ProtectedRange_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtectedRange_Public_Virtual_New_set_Void_ProtectedRange_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
