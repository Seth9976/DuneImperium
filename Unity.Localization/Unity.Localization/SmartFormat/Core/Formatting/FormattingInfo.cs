using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	// Token: 0x02000087 RID: 135
	public class FormattingInfo : Object
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x00021D58 File Offset: 0x0001FF58
		// Note: this type is marked as 'beforefieldinit'.
		static FormattingInfo()
		{
			Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Formatting", "FormattingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr);
			FormattingInfo.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<Parent>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__Selector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<Selector>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__FormatDetails_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<FormatDetails>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<CurrentValue>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__Placeholder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<Placeholder>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<Format>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__Children_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<Children>k__BackingField");
			FormattingInfo.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, "<Result>k__BackingField");
			FormattingInfo.NativeMethodInfoPtr_Init_Public_Void_FormatDetails_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664483);
			FormattingInfo.NativeMethodInfoPtr_Init_Public_Void_FormattingInfo_FormatDetails_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664484);
			FormattingInfo.NativeMethodInfoPtr_Init_Public_Void_FormattingInfo_FormatDetails_Placeholder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664485);
			FormattingInfo.NativeMethodInfoPtr_ReleaseToPool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664486);
			FormattingInfo.NativeMethodInfoPtr_get_Parent_Public_get_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664487);
			FormattingInfo.NativeMethodInfoPtr_set_Parent_Private_set_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664488);
			FormattingInfo.NativeMethodInfoPtr_get_Selector_Public_get_Selector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664489);
			FormattingInfo.NativeMethodInfoPtr_set_Selector_Public_set_Void_Selector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664490);
			FormattingInfo.NativeMethodInfoPtr_get_FormatDetails_Public_Virtual_Final_New_get_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664491);
			FormattingInfo.NativeMethodInfoPtr_set_FormatDetails_Private_set_Void_FormatDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664492);
			FormattingInfo.NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664493);
			FormattingInfo.NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664494);
			FormattingInfo.NativeMethodInfoPtr_get_Placeholder_Public_Virtual_Final_New_get_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664495);
			FormattingInfo.NativeMethodInfoPtr_set_Placeholder_Private_set_Void_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664496);
			FormattingInfo.NativeMethodInfoPtr_get_Alignment_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664497);
			FormattingInfo.NativeMethodInfoPtr_get_FormatterOptions_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664498);
			FormattingInfo.NativeMethodInfoPtr_get_Format_Public_Virtual_Final_New_get_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664499);
			FormattingInfo.NativeMethodInfoPtr_set_Format_Private_set_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664500);
			FormattingInfo.NativeMethodInfoPtr_get_Children_Public_get_List_1_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664501);
			FormattingInfo.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664502);
			FormattingInfo.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664503);
			FormattingInfo.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664504);
			FormattingInfo.NativeMethodInfoPtr_FormattingException_Public_Virtual_Final_New_FormattingException_String_FormatItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664505);
			FormattingInfo.NativeMethodInfoPtr_get_SelectorText_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664506);
			FormattingInfo.NativeMethodInfoPtr_get_SelectorIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664507);
			FormattingInfo.NativeMethodInfoPtr_get_SelectorOperator_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664508);
			FormattingInfo.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664509);
			FormattingInfo.NativeMethodInfoPtr_set_Result_Public_Virtual_Final_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664510);
			FormattingInfo.NativeMethodInfoPtr_CreateChild_Private_FormattingInfo_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664511);
			FormattingInfo.NativeMethodInfoPtr_CreateChild_Public_FormattingInfo_Placeholder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664512);
			FormattingInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr, 100664513);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00022094 File Offset: 0x00020294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1074265, RefRangeEnd = 1074267, XrefRangeStart = 1074261, XrefRangeEnd = 1074265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(FormatDetails formatDetails, Format format, Object currentValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_Init_Public_Void_FormatDetails_Format_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000220FC File Offset: 0x000202FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074271, RefRangeEnd = 1074272, XrefRangeStart = 1074267, XrefRangeEnd = 1074271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(FormattingInfo parent, FormatDetails formatDetails, Format format, Object currentValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_Init_Public_Void_FormattingInfo_FormatDetails_Format_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00022178 File Offset: 0x00020378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074278, RefRangeEnd = 1074279, XrefRangeStart = 1074272, XrefRangeEnd = 1074278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, Object currentValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_Init_Public_Void_FormattingInfo_FormatDetails_Placeholder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000221F4 File Offset: 0x000203F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074304, RefRangeEnd = 1074305, XrefRangeStart = 1074279, XrefRangeEnd = 1074304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseToPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_ReleaseToPool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00022228 File Offset: 0x00020428
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00022268 File Offset: 0x00020468
		public unsafe FormattingInfo Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Parent_Public_get_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_Parent_Private_set_Void_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x000222AC File Offset: 0x000204AC
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x000222EC File Offset: 0x000204EC
		public unsafe Selector Selector
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Selector_Public_get_Selector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_Selector_Public_set_Void_Selector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00022330 File Offset: 0x00020530
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00022370 File Offset: 0x00020570
		public unsafe virtual FormatDetails FormatDetails
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_FormatDetails_Public_Virtual_Final_New_get_FormatDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatDetails>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_FormatDetails_Private_set_Void_FormatDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x000223B4 File Offset: 0x000205B4
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x000223F4 File Offset: 0x000205F4
		public unsafe virtual Object CurrentValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00022438 File Offset: 0x00020638
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00022478 File Offset: 0x00020678
		public unsafe virtual Placeholder Placeholder
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Placeholder_Public_Virtual_Final_New_get_Placeholder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_Placeholder_Private_set_Void_Placeholder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x000224BC File Offset: 0x000206BC
		public unsafe virtual int Alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Alignment_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000224F8 File Offset: 0x000206F8
		public unsafe virtual string FormatterOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_FormatterOptions_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00022530 File Offset: 0x00020730
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00022570 File Offset: 0x00020770
		public unsafe virtual Format Format
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Format_Public_Virtual_Final_New_get_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_Format_Private_set_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000225B4 File Offset: 0x000207B4
		public unsafe List<FormattingInfo> Children
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Children_Public_get_List_1_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FormattingInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000225F4 File Offset: 0x000207F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1074310, RefRangeEnd = 1074313, XrefRangeStart = 1074305, XrefRangeEnd = 1074310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00022638 File Offset: 0x00020838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074313, XrefRangeEnd = 1074316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string text, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00022698 File Offset: 0x00020898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074316, XrefRangeEnd = 1074327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Format format, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_Format_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000226EC File Offset: 0x000208EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074327, XrefRangeEnd = 1074331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FormattingException FormattingException(string issue, FormatItem problemItem = null, int startIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(issue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(problemItem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_FormattingException_Public_Virtual_Final_New_FormattingException_String_FormatItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingException>(intPtr3) : null;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0002275C File Offset: 0x0002095C
		public unsafe virtual string SelectorText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074331, XrefRangeEnd = 1074333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_SelectorText_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00022794 File Offset: 0x00020994
		public unsafe virtual int SelectorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_SelectorIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000227D0 File Offset: 0x000209D0
		public unsafe virtual string SelectorOperator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074333, XrefRangeEnd = 1074335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_SelectorOperator_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00022808 File Offset: 0x00020A08
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00022848 File Offset: 0x00020A48
		public unsafe virtual Object Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_set_Result_Public_Virtual_Final_New_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0002288C File Offset: 0x00020A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074335, XrefRangeEnd = 1074344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattingInfo CreateChild(Format format, Object currentValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_CreateChild_Private_FormattingInfo_Format_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000228F0 File Offset: 0x00020AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1074353, RefRangeEnd = 1074355, XrefRangeStart = 1074344, XrefRangeEnd = 1074353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattingInfo CreateChild(Placeholder placeholder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr_CreateChild_Public_FormattingInfo_Placeholder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00022940 File Offset: 0x00020B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074363, RefRangeEnd = 1074364, XrefRangeStart = 1074355, XrefRangeEnd = 1074363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattingInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattingInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000484C File Offset: 0x00002A4C
		public FormattingInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0002297C File Offset: 0x00020B7C
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00004855 File Offset: 0x00002A55
		public unsafe FormattingInfo _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormattingInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000229AC File Offset: 0x00020BAC
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00004874 File Offset: 0x00002A74
		public unsafe Selector _Selector_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Selector_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Selector_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000229DC File Offset: 0x00020BDC
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00004893 File Offset: 0x00002A93
		public unsafe FormatDetails _FormatDetails_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__FormatDetails_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatDetails>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__FormatDetails_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00022A0C File Offset: 0x00020C0C
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000048B2 File Offset: 0x00002AB2
		public unsafe Object _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__CurrentValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00022A3C File Offset: 0x00020C3C
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000048D1 File Offset: 0x00002AD1
		public unsafe Placeholder _Placeholder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Placeholder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Placeholder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Placeholder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00022A6C File Offset: 0x00020C6C
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000048F0 File Offset: 0x00002AF0
		public unsafe Format _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Format_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00022A9C File Offset: 0x00020C9C
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0000490F File Offset: 0x00002B0F
		public unsafe List<FormattingInfo> _Children_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Children_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FormattingInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Children_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00022ACC File Offset: 0x00020CCC
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0000492E File Offset: 0x00002B2E
		public unsafe Object _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingInfo.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr__Selector_k__BackingField;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr__FormatDetails_k__BackingField;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr__Placeholder_k__BackingField;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr__Children_k__BackingField;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_FormatDetails_Format_Object_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_FormattingInfo_FormatDetails_Format_Object_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_FormattingInfo_FormatDetails_Placeholder_Object_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseToPool_Public_Void_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_FormattingInfo_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_FormattingInfo_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_get_Selector_Public_get_Selector_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_set_Selector_Public_set_Void_Selector_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatDetails_Public_Virtual_Final_New_get_FormatDetails_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatDetails_Private_set_Void_FormatDetails_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Object_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_Placeholder_Public_Virtual_Final_New_get_Placeholder_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_set_Placeholder_Private_set_Void_Placeholder_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatterOptions_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Virtual_Final_New_get_Format_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Private_set_Void_Format_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_List_1_FormattingInfo_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_Format_Object_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_FormattingException_Public_Virtual_Final_New_FormattingException_String_FormatItem_Int32_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorText_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectorOperator_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Public_Virtual_Final_New_set_Void_Object_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_CreateChild_Private_FormattingInfo_Format_Object_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_CreateChild_Public_FormattingInfo_Placeholder_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
