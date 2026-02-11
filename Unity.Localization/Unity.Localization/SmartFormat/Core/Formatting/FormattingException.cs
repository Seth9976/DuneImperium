using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	// Token: 0x02000086 RID: 134
	public class FormattingException : Exception
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x0002199C File Offset: 0x0001FB9C
		// Note: this type is marked as 'beforefieldinit'.
		static FormattingException()
		{
			Il2CppClassPointerStore<FormattingException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Formatting", "FormattingException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingException>.NativeClassPtr);
			FormattingException.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, "<Format>k__BackingField");
			FormattingException.NativeFieldInfoPtr__ErrorItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, "<ErrorItem>k__BackingField");
			FormattingException.NativeFieldInfoPtr__Issue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, "<Issue>k__BackingField");
			FormattingException.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, "<Index>k__BackingField");
			FormattingException.NativeMethodInfoPtr__ctor_Public_Void_FormatItem_Exception_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664476);
			FormattingException.NativeMethodInfoPtr__ctor_Public_Void_FormatItem_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664477);
			FormattingException.NativeMethodInfoPtr_get_Format_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664478);
			FormattingException.NativeMethodInfoPtr_get_ErrorItem_Public_get_FormatItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664479);
			FormattingException.NativeMethodInfoPtr_get_Issue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664480);
			FormattingException.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664481);
			FormattingException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingException>.NativeClassPtr, 100664482);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00021AA8 File Offset: 0x0001FCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074225, XrefRangeEnd = 1074232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattingException(FormatItem errorItem, Exception formatException, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattingException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingException.NativeMethodInfoPtr__ctor_Public_Void_FormatItem_Exception_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00021B14 File Offset: 0x0001FD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074239, RefRangeEnd = 1074240, XrefRangeStart = 1074232, XrefRangeEnd = 1074239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattingException(FormatItem errorItem, string issue, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattingException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(issue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingException.NativeMethodInfoPtr__ctor_Public_Void_FormatItem_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00021B80 File Offset: 0x0001FD80
		public unsafe string Format
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingException.NativeMethodInfoPtr_get_Format_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00021BB8 File Offset: 0x0001FDB8
		public unsafe FormatItem ErrorItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingException.NativeMethodInfoPtr_get_ErrorItem_Public_get_FormatItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatItem>(intPtr3) : null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00021BF8 File Offset: 0x0001FDF8
		public unsafe string Issue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingException.NativeMethodInfoPtr_get_Issue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00021C30 File Offset: 0x0001FE30
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingException.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00021C6C File Offset: 0x0001FE6C
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074240, XrefRangeEnd = 1074261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FormattingException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000047CB File Offset: 0x000029CB
		public FormattingException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00021CB0 File Offset: 0x0001FEB0
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x000047D4 File Offset: 0x000029D4
		public unsafe string _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__Format_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00021CD8 File Offset: 0x0001FED8
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000047F3 File Offset: 0x000029F3
		public unsafe FormatItem _ErrorItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__ErrorItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__ErrorItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00021D08 File Offset: 0x0001FF08
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00004812 File Offset: 0x00002A12
		public unsafe string _Issue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__Issue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__Issue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00021D30 File Offset: 0x0001FF30
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00004831 File Offset: 0x00002A31
		public unsafe int _Index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__Index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingException.NativeFieldInfoPtr__Index_k__BackingField)) = value;
			}
		}

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr__ErrorItem_k__BackingField;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr__Issue_k__BackingField;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FormatItem_Exception_Int32_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FormatItem_String_Int32_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_String_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorItem_Public_get_FormatItem_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_get_Issue_Public_get_String_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
