using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.json
{
	// Token: 0x02000011 RID: 17
	public sealed class TypeHintingAttribute : Attribute
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000040D8 File Offset: 0x000022D8
		// Note: this type is marked as 'beforefieldinit'.
		static TypeHintingAttribute()
		{
			Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "TypeHintingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr);
			TypeHintingAttribute.NativeFieldInfoPtr_HintingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr, "HintingField");
			TypeHintingAttribute.NativeFieldInfoPtr_FallbackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr, "FallbackType");
			TypeHintingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr, 100663345);
			TypeHintingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004158 File Offset: 0x00002358
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeHintingAttribute(string hintingField)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hintingField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHintingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000041A4 File Offset: 0x000023A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeHintingAttribute(string hintingField, Type fallbackType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeHintingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hintingField);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallbackType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeHintingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002380 File Offset: 0x00000580
		public TypeHintingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002389 File Offset: 0x00000589
		public unsafe string HintingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHintingAttribute.NativeFieldInfoPtr_HintingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHintingAttribute.NativeFieldInfoPtr_HintingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000422C File Offset: 0x0000242C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000023A8 File Offset: 0x000005A8
		public unsafe Type FallbackType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHintingAttribute.NativeFieldInfoPtr_FallbackType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeHintingAttribute.NativeFieldInfoPtr_FallbackType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_HintingField;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_FallbackType;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;
	}
}
