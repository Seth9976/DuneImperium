using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200000F RID: 15
	public class AddNamedRangeResponse : Object
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000DF14 File Offset: 0x0000C114
		// Note: this type is marked as 'beforefieldinit'.
		static AddNamedRangeResponse()
		{
			Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddNamedRangeResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr);
			AddNamedRangeResponse.NativeFieldInfoPtr__NamedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, "<NamedRange>k__BackingField");
			AddNamedRangeResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, "<ETag>k__BackingField");
			AddNamedRangeResponse.NativeMethodInfoPtr_get_NamedRange_Public_Virtual_New_get_NamedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, 100663613);
			AddNamedRangeResponse.NativeMethodInfoPtr_set_NamedRange_Public_Virtual_New_set_Void_NamedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, 100663614);
			AddNamedRangeResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, 100663615);
			AddNamedRangeResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, 100663616);
			AddNamedRangeResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr, 100663617);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000E01C File Offset: 0x0000C21C
		public unsafe virtual NamedRange NamedRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeResponse.NativeMethodInfoPtr_get_NamedRange_Public_Virtual_New_get_NamedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamedRange>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeResponse.NativeMethodInfoPtr_set_NamedRange_Public_Virtual_New_set_Void_NamedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000E06C File Offset: 0x0000C26C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddNamedRangeResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000E100 File Offset: 0x0000C300
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddNamedRangeResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddNamedRangeResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddNamedRangeResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000025AE File Offset: 0x000007AE
		public AddNamedRangeResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000E13C File Offset: 0x0000C33C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000025B7 File Offset: 0x000007B7
		public unsafe NamedRange _NamedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeResponse.NativeFieldInfoPtr__NamedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamedRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeResponse.NativeFieldInfoPtr__NamedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000E16C File Offset: 0x0000C36C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000025D6 File Offset: 0x000007D6
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddNamedRangeResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr__NamedRange_k__BackingField;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_NamedRange_Public_Virtual_New_get_NamedRange_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_set_NamedRange_Public_Virtual_New_set_Void_NamedRange_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
