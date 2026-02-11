using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x02000045 RID: 69
	public class BasicFlavorText : DescriptionLookup
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00025F34 File Offset: 0x00024134
		// Note: this type is marked as 'beforefieldinit'.
		static BasicFlavorText()
		{
			Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.core.data.composition", "BasicFlavorText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr);
			BasicFlavorText.NativeFieldInfoPtr_descriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, "descriptionText");
			BasicFlavorText.NativeFieldInfoPtr_overrideDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, "overrideDescription");
			BasicFlavorText.NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, 100663715);
			BasicFlavorText.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, 100663716);
			BasicFlavorText.NativeMethodInfoPtr_description_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, 100663717);
			BasicFlavorText.NativeMethodInfoPtr_descriptionKey_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, 100663718);
			BasicFlavorText.NativeMethodInfoPtr_SetDescription_Public_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, 100663719);
			BasicFlavorText.NativeMethodInfoPtr_SetDescriptionWithoutLocalization_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr, 100663720);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00026004 File Offset: 0x00024204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498918, XrefRangeEnd = 498921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicFlavorText(LocalizableText desc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicFlavorText.NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00026050 File Offset: 0x00024250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 498928, RefRangeEnd = 498929, XrefRangeStart = 498921, XrefRangeEnd = 498928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicFlavorText(string descriptionWithoutLocalization)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicFlavorText>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(descriptionWithoutLocalization);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicFlavorText.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002609C File Offset: 0x0002429C
		[CallerCount(0)]
		public unsafe override string description()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicFlavorText.NativeMethodInfoPtr_description_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000260E0 File Offset: 0x000242E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374430, RefRangeEnd = 374432, XrefRangeStart = 374430, XrefRangeEnd = 374432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string descriptionKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicFlavorText.NativeMethodInfoPtr_descriptionKey_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00026124 File Offset: 0x00024324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498929, XrefRangeEnd = 498932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDescription(LocalizableText description)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicFlavorText.NativeMethodInfoPtr_SetDescription_Public_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00026168 File Offset: 0x00024368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498932, XrefRangeEnd = 498939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDescriptionWithoutLocalization(string newDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicFlavorText.NativeMethodInfoPtr_SetDescriptionWithoutLocalization_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000329B File Offset: 0x0000149B
		public BasicFlavorText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000261AC File Offset: 0x000243AC
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000032A4 File Offset: 0x000014A4
		public unsafe LocalizableText descriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicFlavorText.NativeFieldInfoPtr_descriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicFlavorText.NativeFieldInfoPtr_descriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000261DC File Offset: 0x000243DC
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000032C3 File Offset: 0x000014C3
		public unsafe string overrideDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicFlavorText.NativeFieldInfoPtr_overrideDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicFlavorText.NativeFieldInfoPtr_overrideDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_descriptionText;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_overrideDescription;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_description_Protected_Virtual_String_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_descriptionKey_Protected_Virtual_String_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_SetDescription_Public_Void_LocalizableText_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_SetDescriptionWithoutLocalization_Public_Void_String_0;
	}
}
