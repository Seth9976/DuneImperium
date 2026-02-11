using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	// Token: 0x02000085 RID: 133
	public class FormatDetails : Object
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x0002113C File Offset: 0x0001F33C
		// Note: this type is marked as 'beforefieldinit'.
		static FormatDetails()
		{
			Il2CppClassPointerStore<FormatDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Formatting", "FormatDetails");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr);
			FormatDetails.NativeFieldInfoPtr__Formatter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<Formatter>k__BackingField");
			FormatDetails.NativeFieldInfoPtr__OriginalFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<OriginalFormat>k__BackingField");
			FormatDetails.NativeFieldInfoPtr__OriginalArgs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<OriginalArgs>k__BackingField");
			FormatDetails.NativeFieldInfoPtr__FormatCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<FormatCache>k__BackingField");
			FormatDetails.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<Provider>k__BackingField");
			FormatDetails.NativeFieldInfoPtr__Output_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<Output>k__BackingField");
			FormatDetails.NativeFieldInfoPtr__FormattingException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, "<FormattingException>k__BackingField");
			FormatDetails.NativeMethodInfoPtr_Init_Public_Void_SmartFormatter_Format_IList_1_Object_FormatCache_IFormatProvider_IOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664458);
			FormatDetails.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664459);
			FormatDetails.NativeMethodInfoPtr_get_Formatter_Public_get_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664460);
			FormatDetails.NativeMethodInfoPtr_set_Formatter_Private_set_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664461);
			FormatDetails.NativeMethodInfoPtr_get_OriginalFormat_Public_get_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664462);
			FormatDetails.NativeMethodInfoPtr_set_OriginalFormat_Private_set_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664463);
			FormatDetails.NativeMethodInfoPtr_get_OriginalArgs_Public_get_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664464);
			FormatDetails.NativeMethodInfoPtr_set_OriginalArgs_Private_set_Void_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664465);
			FormatDetails.NativeMethodInfoPtr_get_FormatCache_Public_get_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664466);
			FormatDetails.NativeMethodInfoPtr_set_FormatCache_Private_set_Void_FormatCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664467);
			FormatDetails.NativeMethodInfoPtr_get_Provider_Public_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664468);
			FormatDetails.NativeMethodInfoPtr_set_Provider_Private_set_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664469);
			FormatDetails.NativeMethodInfoPtr_get_Output_Public_get_IOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664470);
			FormatDetails.NativeMethodInfoPtr_set_Output_Private_set_Void_IOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664471);
			FormatDetails.NativeMethodInfoPtr_get_FormattingException_Public_get_FormattingException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664472);
			FormatDetails.NativeMethodInfoPtr_set_FormattingException_Public_set_Void_FormattingException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664473);
			FormatDetails.NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664474);
			FormatDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00021360 File Offset: 0x0001F560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1074215, RefRangeEnd = 1074217, XrefRangeStart = 1074209, XrefRangeEnd = 1074215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(SmartFormatter formatter, Format originalFormat, IList<Object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalFormat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalArgs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatCache);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_Init_Public_Void_SmartFormatter_Format_IList_1_Object_FormatCache_IFormatProvider_IOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00021400 File Offset: 0x0001F600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074224, RefRangeEnd = 1074225, XrefRangeStart = 1074217, XrefRangeEnd = 1074224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00021434 File Offset: 0x0001F634
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00021474 File Offset: 0x0001F674
		public unsafe SmartFormatter Formatter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_Formatter_Public_get_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_Formatter_Private_set_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x000214B8 File Offset: 0x0001F6B8
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x000214F8 File Offset: 0x0001F6F8
		public unsafe Format OriginalFormat
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_OriginalFormat_Public_get_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_OriginalFormat_Private_set_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0002153C File Offset: 0x0001F73C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0002157C File Offset: 0x0001F77C
		public unsafe IList<Object> OriginalArgs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_OriginalArgs_Public_get_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_OriginalArgs_Private_set_Void_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x000215C0 File Offset: 0x0001F7C0
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00021600 File Offset: 0x0001F800
		public unsafe FormatCache FormatCache
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_FormatCache_Public_get_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_FormatCache_Private_set_Void_FormatCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00021644 File Offset: 0x0001F844
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00021684 File Offset: 0x0001F884
		public unsafe IFormatProvider Provider
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_Provider_Public_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_Provider_Private_set_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000216C8 File Offset: 0x0001F8C8
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00021708 File Offset: 0x0001F908
		public unsafe IOutput Output
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_Output_Public_get_IOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOutput>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_Output_Private_set_Void_IOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002174C File Offset: 0x0001F94C
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0002178C File Offset: 0x0001F98C
		public unsafe FormattingException FormattingException
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_FormattingException_Public_get_FormattingException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormattingException>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_set_FormattingException_Public_set_Void_FormattingException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000217D0 File Offset: 0x0001F9D0
		public unsafe SmartSettings Settings
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 399714, RefRangeEnd = 399719, XrefRangeStart = 399714, XrefRangeEnd = 399719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00021810 File Offset: 0x0001FA10
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatDetails()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatDetails>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000046E9 File Offset: 0x000028E9
		public FormatDetails(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0002184C File Offset: 0x0001FA4C
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x000046F2 File Offset: 0x000028F2
		public unsafe SmartFormatter _Formatter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__Formatter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__Formatter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0002187C File Offset: 0x0001FA7C
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00004711 File Offset: 0x00002911
		public unsafe Format _OriginalFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__OriginalFormat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__OriginalFormat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000218AC File Offset: 0x0001FAAC
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00004730 File Offset: 0x00002930
		public unsafe IList<Object> _OriginalArgs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__OriginalArgs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__OriginalArgs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000218DC File Offset: 0x0001FADC
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000474F File Offset: 0x0000294F
		public unsafe FormatCache _FormatCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__FormatCache_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__FormatCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0002190C File Offset: 0x0001FB0C
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000476E File Offset: 0x0000296E
		public unsafe IFormatProvider _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__Provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0002193C File Offset: 0x0001FB3C
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0000478D File Offset: 0x0000298D
		public unsafe IOutput _Output_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__Output_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOutput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__Output_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0002196C File Offset: 0x0001FB6C
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x000047AC File Offset: 0x000029AC
		public unsafe FormattingException _FormattingException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__FormattingException_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormattingException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatDetails.NativeFieldInfoPtr__FormattingException_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr__Formatter_k__BackingField;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr__OriginalFormat_k__BackingField;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr__OriginalArgs_k__BackingField;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr__FormatCache_k__BackingField;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr__Output_k__BackingField;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr__FormattingException_k__BackingField;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_SmartFormatter_Format_IList_1_Object_FormatCache_IFormatProvider_IOutput_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatter_Public_get_SmartFormatter_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatter_Private_set_Void_SmartFormatter_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalFormat_Public_get_Format_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_set_OriginalFormat_Private_set_Void_Format_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalArgs_Public_get_IList_1_Object_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_set_OriginalArgs_Private_set_Void_IList_1_Object_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatCache_Public_get_FormatCache_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatCache_Private_set_Void_FormatCache_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_get_IFormatProvider_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_set_Provider_Private_set_Void_IFormatProvider_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_get_Output_Public_get_IOutput_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_set_Output_Private_set_Void_IOutput_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_get_FormattingException_Public_get_FormattingException_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_set_FormattingException_Public_set_Void_FormattingException_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
