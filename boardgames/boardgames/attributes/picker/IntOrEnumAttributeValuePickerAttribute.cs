using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace boardgames.attributes.picker
{
	// Token: 0x0200017A RID: 378
	public class IntOrEnumAttributeValuePickerAttribute : PropertyAttribute
	{
		// Token: 0x060012E5 RID: 4837 RVA: 0x0004B490 File Offset: 0x00049690
		// Note: this type is marked as 'beforefieldinit'.
		static IntOrEnumAttributeValuePickerAttribute()
		{
			Il2CppClassPointerStore<IntOrEnumAttributeValuePickerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.picker", "IntOrEnumAttributeValuePickerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntOrEnumAttributeValuePickerAttribute>.NativeClassPtr);
			IntOrEnumAttributeValuePickerAttribute.NativeFieldInfoPtr__KeyField_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntOrEnumAttributeValuePickerAttribute>.NativeClassPtr, "<KeyField>k__BackingField");
			IntOrEnumAttributeValuePickerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOrEnumAttributeValuePickerAttribute>.NativeClassPtr, 100666079);
			IntOrEnumAttributeValuePickerAttribute.NativeMethodInfoPtr_get_KeyField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOrEnumAttributeValuePickerAttribute>.NativeClassPtr, 100666080);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0004B4FC File Offset: 0x000496FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntOrEnumAttributeValuePickerAttribute(string keyField = "attribute")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntOrEnumAttributeValuePickerAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntOrEnumAttributeValuePickerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0004B548 File Offset: 0x00049748
		public unsafe string KeyField
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntOrEnumAttributeValuePickerAttribute.NativeMethodInfoPtr_get_KeyField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0000AD02 File Offset: 0x00008F02
		public IntOrEnumAttributeValuePickerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0004B580 File Offset: 0x00049780
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x0000AD0B File Offset: 0x00008F0B
		public unsafe string _KeyField_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntOrEnumAttributeValuePickerAttribute.NativeFieldInfoPtr__KeyField_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntOrEnumAttributeValuePickerAttribute.NativeFieldInfoPtr__KeyField_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeFieldInfoPtr__KeyField_k__BackingField;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyField_Public_get_String_0;
	}
}
