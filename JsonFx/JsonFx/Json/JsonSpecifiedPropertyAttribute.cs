using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Json
{
	// Token: 0x0200002A RID: 42
	public class JsonSpecifiedPropertyAttribute : Attribute
	{
		// Token: 0x06000217 RID: 535 RVA: 0x0000B1D8 File Offset: 0x000093D8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSpecifiedPropertyAttribute()
		{
			Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json", "JsonSpecifiedPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr);
			JsonSpecifiedPropertyAttribute.NativeFieldInfoPtr_specifiedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr, "specifiedProperty");
			JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr, 100663600);
			JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr, 100663601);
			JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr_get_SpecifiedProperty_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr, 100663602);
			JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr_set_SpecifiedProperty_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr, 100663603);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000B26C File Offset: 0x0000946C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSpecifiedPropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000B2A8 File Offset: 0x000094A8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSpecifiedPropertyAttribute(string propertyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSpecifiedPropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000B2F4 File Offset: 0x000094F4
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000B32C File Offset: 0x0000952C
		public unsafe string SpecifiedProperty
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr_get_SpecifiedProperty_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSpecifiedPropertyAttribute.NativeMethodInfoPtr_set_SpecifiedProperty_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002D8F File Offset: 0x00000F8F
		public JsonSpecifiedPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000B370 File Offset: 0x00009570
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002D98 File Offset: 0x00000F98
		public unsafe string specifiedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSpecifiedPropertyAttribute.NativeFieldInfoPtr_specifiedProperty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSpecifiedPropertyAttribute.NativeFieldInfoPtr_specifiedProperty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_specifiedProperty;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecifiedProperty_Public_get_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecifiedProperty_Public_set_Void_String_0;
	}
}
