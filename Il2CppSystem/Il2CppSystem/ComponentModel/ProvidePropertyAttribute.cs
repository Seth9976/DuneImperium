using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000123 RID: 291
	public sealed class ProvidePropertyAttribute : Attribute
	{
		// Token: 0x060011FC RID: 4604 RVA: 0x00061274 File Offset: 0x0005F474
		// Note: this type is marked as 'beforefieldinit'.
		static ProvidePropertyAttribute()
		{
			Il2CppClassPointerStore<ProvidePropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ProvidePropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProvidePropertyAttribute>.NativeClassPtr);
			ProvidePropertyAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProvidePropertyAttribute>.NativeClassPtr, "<PropertyName>k__BackingField");
			ProvidePropertyAttribute.NativeFieldInfoPtr__ReceiverTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProvidePropertyAttribute>.NativeClassPtr, "<ReceiverTypeName>k__BackingField");
			ProvidePropertyAttribute.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvidePropertyAttribute>.NativeClassPtr, 100665926);
			ProvidePropertyAttribute.NativeMethodInfoPtr_get_ReceiverTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProvidePropertyAttribute>.NativeClassPtr, 100665927);
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x000612F4 File Offset: 0x0005F4F4
		public unsafe string PropertyName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvidePropertyAttribute.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0006132C File Offset: 0x0005F52C
		public unsafe string ReceiverTypeName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProvidePropertyAttribute.NativeMethodInfoPtr_get_ReceiverTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00008516 File Offset: 0x00006716
		public ProvidePropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00061364 File Offset: 0x0005F564
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0000851F File Offset: 0x0000671F
		public unsafe string _PropertyName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvidePropertyAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvidePropertyAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0006138C File Offset: 0x0005F58C
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0000853E File Offset: 0x0000673E
		public unsafe string _ReceiverTypeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvidePropertyAttribute.NativeFieldInfoPtr__ReceiverTypeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProvidePropertyAttribute.NativeFieldInfoPtr__ReceiverTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeFieldInfoPtr__PropertyName_k__BackingField;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeFieldInfoPtr__ReceiverTypeName_k__BackingField;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiverTypeName_Public_get_String_0;
	}
}
