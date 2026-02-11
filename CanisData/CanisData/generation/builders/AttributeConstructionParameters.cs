using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData.generation.builders
{
	// Token: 0x0200002A RID: 42
	public class AttributeConstructionParameters : Object
	{
		// Token: 0x06000199 RID: 409 RVA: 0x000098C0 File Offset: 0x00007AC0
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeConstructionParameters()
		{
			Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.builders", "AttributeConstructionParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr);
			AttributeConstructionParameters.NativeFieldInfoPtr__AttributeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, "<AttributeName>k__BackingField");
			AttributeConstructionParameters.NativeFieldInfoPtr__AttributeValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, "<AttributeValue>k__BackingField");
			AttributeConstructionParameters.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, 100663510);
			AttributeConstructionParameters.NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, 100663511);
			AttributeConstructionParameters.NativeMethodInfoPtr_get_AttributeValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, 100663512);
			AttributeConstructionParameters.NativeMethodInfoPtr_set_AttributeValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, 100663513);
			AttributeConstructionParameters.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr, 100663514);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000997C File Offset: 0x00007B7C
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000099B4 File Offset: 0x00007BB4
		public unsafe string AttributeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeConstructionParameters.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeConstructionParameters.NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000099F8 File Offset: 0x00007BF8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00009A30 File Offset: 0x00007C30
		public unsafe string AttributeValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeConstructionParameters.NativeMethodInfoPtr_get_AttributeValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeConstructionParameters.NativeMethodInfoPtr_set_AttributeValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009A74 File Offset: 0x00007C74
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeConstructionParameters(string attributeName, string attributeValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeConstructionParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeConstructionParameters.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002C6D File Offset: 0x00000E6D
		public AttributeConstructionParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00009AD4 File Offset: 0x00007CD4
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002C76 File Offset: 0x00000E76
		public unsafe string _AttributeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeConstructionParameters.NativeFieldInfoPtr__AttributeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeConstructionParameters.NativeFieldInfoPtr__AttributeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00009AFC File Offset: 0x00007CFC
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002C95 File Offset: 0x00000E95
		public unsafe string _AttributeValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeConstructionParameters.NativeFieldInfoPtr__AttributeValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeConstructionParameters.NativeFieldInfoPtr__AttributeValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr__AttributeName_k__BackingField;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__AttributeValue_k__BackingField;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeName_Public_get_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeValue_Public_get_String_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeValue_Public_set_Void_String_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
