using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.stackmodifiers
{
	// Token: 0x02000045 RID: 69
	public class StackModifier : Object
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0002AFFC File Offset: 0x000291FC
		// Note: this type is marked as 'beforefieldinit'.
		static StackModifier()
		{
			Il2CppClassPointerStore<StackModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.stackmodifiers", "StackModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackModifier>.NativeClassPtr);
			StackModifier.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, "Source");
			StackModifier.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, "Description");
			StackModifier.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, "Modifiers");
			StackModifier.NativeMethodInfoPtr_GetModifierForAttribute_Public_StackModifierItem_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, 100664234);
			StackModifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, 100664235);
			StackModifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, 100664236);
			StackModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackModifier>.NativeClassPtr, 100664237);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0002B0B8 File Offset: 0x000292B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553458, XrefRangeEnd = 553471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackModifierItem GetModifierForAttribute(IAttributeDefinition attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackModifier.NativeMethodInfoPtr_GetModifierForAttribute_Public_StackModifierItem_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackModifierItem>(intPtr3) : null;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0002B108 File Offset: 0x00029308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553471, XrefRangeEnd = 553478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackModifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0002B160 File Offset: 0x00029360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackModifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0002B1A8 File Offset: 0x000293A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackModifier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00003D8C File Offset: 0x00001F8C
		public StackModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0002B1E4 File Offset: 0x000293E4
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003D95 File Offset: 0x00001F95
		public unsafe EntityID Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifier.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifier.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0002B214 File Offset: 0x00029414
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public unsafe LocalizableTextVariables Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifier.NativeFieldInfoPtr_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifier.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0002B244 File Offset: 0x00029444
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00003DD3 File Offset: 0x00001FD3
		public unsafe List<StackModifierItem> Modifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifier.NativeFieldInfoPtr_Modifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StackModifierItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifier.NativeFieldInfoPtr_Modifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_Modifiers;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierForAttribute_Public_StackModifierItem_IAttributeDefinition_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
