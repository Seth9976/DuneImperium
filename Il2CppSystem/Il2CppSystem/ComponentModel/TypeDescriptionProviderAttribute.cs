using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200012F RID: 303
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00063144 File Offset: 0x00061344
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDescriptionProviderAttribute()
		{
			Il2CppClassPointerStore<TypeDescriptionProviderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeDescriptionProviderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptionProviderAttribute>.NativeClassPtr);
			TypeDescriptionProviderAttribute.NativeFieldInfoPtr__TypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptionProviderAttribute>.NativeClassPtr, "<TypeName>k__BackingField");
			TypeDescriptionProviderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProviderAttribute>.NativeClassPtr, 100665989);
			TypeDescriptionProviderAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProviderAttribute>.NativeClassPtr, 100665990);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000631B0 File Offset: 0x000613B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460563, XrefRangeEnd = 460571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeDescriptionProviderAttribute(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptionProviderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProviderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000631FC File Offset: 0x000613FC
		public unsafe string TypeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProviderAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000879B File Offset: 0x0000699B
		public TypeDescriptionProviderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00063234 File Offset: 0x00061434
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x000087A4 File Offset: 0x000069A4
		public unsafe string _TypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptionProviderAttribute.NativeFieldInfoPtr__TypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptionProviderAttribute.NativeFieldInfoPtr__TypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr__TypeName_k__BackingField;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;
	}
}
