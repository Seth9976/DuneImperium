using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.stackmodifiers
{
	// Token: 0x02000046 RID: 70
	public class StackModifierItem : Object
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x0002B274 File Offset: 0x00029474
		// Note: this type is marked as 'beforefieldinit'.
		static StackModifierItem()
		{
			Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.stackmodifiers", "StackModifierItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr);
			StackModifierItem.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr, "Amount");
			StackModifierItem.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr, "Attribute");
			StackModifierItem.NativeFieldInfoPtr_Persist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr, "Persist");
			StackModifierItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr, 100664238);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0002B2F4 File Offset: 0x000294F4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackModifierItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackModifierItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackModifierItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003DF2 File Offset: 0x00001FF2
		public StackModifierItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0002B330 File Offset: 0x00029530
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003DFB File Offset: 0x00001FFB
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifierItem.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifierItem.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0002B358 File Offset: 0x00029558
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003E16 File Offset: 0x00002016
		public unsafe int Attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifierItem.NativeFieldInfoPtr_Attribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifierItem.NativeFieldInfoPtr_Attribute)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0002B380 File Offset: 0x00029580
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003E31 File Offset: 0x00002031
		public unsafe bool Persist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifierItem.NativeFieldInfoPtr_Persist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackModifierItem.NativeFieldInfoPtr_Persist)) = value;
			}
		}

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_Persist;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
