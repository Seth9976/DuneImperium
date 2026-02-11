using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F7 RID: 247
	public class AttributeProviderAttribute : Attribute
	{
		// Token: 0x06000FD8 RID: 4056 RVA: 0x00057988 File Offset: 0x00055B88
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeProviderAttribute()
		{
			Il2CppClassPointerStore<AttributeProviderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AttributeProviderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeProviderAttribute>.NativeClassPtr);
			AttributeProviderAttribute.NativeFieldInfoPtr__TypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeProviderAttribute>.NativeClassPtr, "<TypeName>k__BackingField");
			AttributeProviderAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeProviderAttribute>.NativeClassPtr, "<PropertyName>k__BackingField");
			AttributeProviderAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeProviderAttribute>.NativeClassPtr, 100665576);
			AttributeProviderAttribute.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeProviderAttribute>.NativeClassPtr, 100665577);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00057A08 File Offset: 0x00055C08
		public unsafe string TypeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeProviderAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00057A40 File Offset: 0x00055C40
		public unsafe string PropertyName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeProviderAttribute.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00007B7B File Offset: 0x00005D7B
		public AttributeProviderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00057A78 File Offset: 0x00055C78
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00007B84 File Offset: 0x00005D84
		public unsafe string _TypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeProviderAttribute.NativeFieldInfoPtr__TypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeProviderAttribute.NativeFieldInfoPtr__TypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00057AA0 File Offset: 0x00055CA0
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00007BA3 File Offset: 0x00005DA3
		public unsafe string _PropertyName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeProviderAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeProviderAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr__TypeName_k__BackingField;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr__PropertyName_k__BackingField;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;
	}
}
