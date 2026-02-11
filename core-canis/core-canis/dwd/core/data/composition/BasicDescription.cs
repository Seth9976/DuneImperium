using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001DA RID: 474
	public class BasicDescription : DescriptionLookup
	{
		// Token: 0x06001A1E RID: 6686 RVA: 0x0007BDB8 File Offset: 0x00079FB8
		// Note: this type is marked as 'beforefieldinit'.
		static BasicDescription()
		{
			Il2CppClassPointerStore<BasicDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "BasicDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr);
			BasicDescription.NativeFieldInfoPtr_descriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, "descriptionText");
			BasicDescription.NativeFieldInfoPtr_overrideDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, "overrideDescription");
			BasicDescription.NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667436);
			BasicDescription.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667437);
			BasicDescription.NativeMethodInfoPtr_description_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667438);
			BasicDescription.NativeMethodInfoPtr_descriptionKey_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667439);
			BasicDescription.NativeMethodInfoPtr_GetFullDescription_Public_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667440);
			BasicDescription.NativeMethodInfoPtr_SetDescription_Public_Void_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667441);
			BasicDescription.NativeMethodInfoPtr_SetDescriptionWithoutLocalization_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr, 100667442);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0007BE9C File Offset: 0x0007A09C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 882345, RefRangeEnd = 882366, XrefRangeStart = 882341, XrefRangeEnd = 882345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicDescription(LocalizableText desc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescription.NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0007BEE8 File Offset: 0x0007A0E8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 882374, RefRangeEnd = 882406, XrefRangeStart = 882366, XrefRangeEnd = 882374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicDescription(string descriptionWithoutLocalization)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicDescription>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(descriptionWithoutLocalization);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescription.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0007BF34 File Offset: 0x0007A134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882406, XrefRangeEnd = 882407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string description()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicDescription.NativeMethodInfoPtr_description_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0007BF78 File Offset: 0x0007A178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374430, RefRangeEnd = 374432, XrefRangeStart = 374430, XrefRangeEnd = 374432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string descriptionKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicDescription.NativeMethodInfoPtr_descriptionKey_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0007BFBC File Offset: 0x0007A1BC
		[CallerCount(0)]
		public unsafe LocalizableText GetFullDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescription.NativeMethodInfoPtr_GetFullDescription_Public_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0007BFFC File Offset: 0x0007A1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882407, XrefRangeEnd = 882409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDescription(LocalizableText description)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescription.NativeMethodInfoPtr_SetDescription_Public_Void_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0007C040 File Offset: 0x0007A240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 882415, RefRangeEnd = 882419, XrefRangeStart = 882409, XrefRangeEnd = 882415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDescriptionWithoutLocalization(string newDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicDescription.NativeMethodInfoPtr_SetDescriptionWithoutLocalization_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0000B5BB File Offset: 0x000097BB
		public BasicDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0007C084 File Offset: 0x0007A284
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public unsafe LocalizableText descriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicDescription.NativeFieldInfoPtr_descriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicDescription.NativeFieldInfoPtr_descriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0007C0B4 File Offset: 0x0007A2B4
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0000B5E3 File Offset: 0x000097E3
		public unsafe string overrideDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicDescription.NativeFieldInfoPtr_overrideDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicDescription.NativeFieldInfoPtr_overrideDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr_descriptionText;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr_overrideDescription;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizableText_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_description_Protected_Virtual_String_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_descriptionKey_Protected_Virtual_String_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_GetFullDescription_Public_LocalizableText_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_SetDescription_Public_Void_LocalizableText_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_SetDescriptionWithoutLocalization_Public_Void_String_0;
	}
}
