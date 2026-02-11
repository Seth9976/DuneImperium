using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000010 RID: 16
	public class AddProtectedRangeRequest : Object
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x0000E194 File Offset: 0x0000C394
		// Note: this type is marked as 'beforefieldinit'.
		static AddProtectedRangeRequest()
		{
			Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "AddProtectedRangeRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr);
			AddProtectedRangeRequest.NativeFieldInfoPtr__ProtectedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, "<ProtectedRange>k__BackingField");
			AddProtectedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, "<ETag>k__BackingField");
			AddProtectedRangeRequest.NativeMethodInfoPtr_get_ProtectedRange_Public_Virtual_New_get_ProtectedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, 100663618);
			AddProtectedRangeRequest.NativeMethodInfoPtr_set_ProtectedRange_Public_Virtual_New_set_Void_ProtectedRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, 100663619);
			AddProtectedRangeRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, 100663620);
			AddProtectedRangeRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, 100663621);
			AddProtectedRangeRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr, 100663622);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000E250 File Offset: 0x0000C450
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000E29C File Offset: 0x0000C49C
		public unsafe virtual ProtectedRange ProtectedRange
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeRequest.NativeMethodInfoPtr_get_ProtectedRange_Public_Virtual_New_get_ProtectedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeRequest.NativeMethodInfoPtr_set_ProtectedRange_Public_Virtual_New_set_Void_ProtectedRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000E2EC File Offset: 0x0000C4EC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000E330 File Offset: 0x0000C530
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddProtectedRangeRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000E380 File Offset: 0x0000C580
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddProtectedRangeRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddProtectedRangeRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddProtectedRangeRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000025F5 File Offset: 0x000007F5
		public AddProtectedRangeRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000025FE File Offset: 0x000007FE
		public unsafe ProtectedRange _ProtectedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeRequest.NativeFieldInfoPtr__ProtectedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProtectedRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeRequest.NativeFieldInfoPtr__ProtectedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000261D File Offset: 0x0000081D
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddProtectedRangeRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr__ProtectedRange_k__BackingField;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtectedRange_Public_Virtual_New_get_ProtectedRange_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtectedRange_Public_Virtual_New_set_Void_ProtectedRange_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
