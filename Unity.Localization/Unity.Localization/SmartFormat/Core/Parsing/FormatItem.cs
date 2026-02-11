using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x02000079 RID: 121
	public class FormatItem : Object
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x0001E81C File Offset: 0x0001CA1C
		// Note: this type is marked as 'beforefieldinit'.
		static FormatItem()
		{
			Il2CppClassPointerStore<FormatItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "FormatItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatItem>.NativeClassPtr);
			FormatItem.NativeFieldInfoPtr_baseString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "baseString");
			FormatItem.NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "endIndex");
			FormatItem.NativeFieldInfoPtr_SmartSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "SmartSettings");
			FormatItem.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "startIndex");
			FormatItem.NativeFieldInfoPtr_m_RawText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "m_RawText");
			FormatItem.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "<Parent>k__BackingField");
			FormatItem.NativeMethodInfoPtr_get_Parent_Public_get_FormatItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664350);
			FormatItem.NativeMethodInfoPtr_set_Parent_Private_set_Void_FormatItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664351);
			FormatItem.NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664352);
			FormatItem.NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664353);
			FormatItem.NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664354);
			FormatItem.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664355);
			FormatItem.NativeMethodInfoPtr_get_RawText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664356);
			FormatItem.NativeMethodInfoPtr_ToEnumerable_Public_IEnumerable_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664357);
			FormatItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664358);
			FormatItem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, 100664359);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001E98C File Offset: 0x0001CB8C
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		public unsafe FormatItem Parent
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_get_Parent_Public_get_FormatItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FormatItem>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_set_Parent_Private_set_Void_FormatItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001EA10 File Offset: 0x0001CC10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1073515, RefRangeEnd = 1073518, XrefRangeStart = 1073512, XrefRangeEnd = 1073515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(SmartSettings smartSettings, FormatItem parent, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0001EA74 File Offset: 0x0001CC74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1073521, RefRangeEnd = 1073523, XrefRangeStart = 1073518, XrefRangeEnd = 1073521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1073526, RefRangeEnd = 1073531, XrefRangeStart = 1073523, XrefRangeEnd = 1073526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smartSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001EB68 File Offset: 0x0001CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073531, XrefRangeEnd = 1073535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FormatItem.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001EBA4 File Offset: 0x0001CDA4
		public unsafe string RawText
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1073537, RefRangeEnd = 1073539, XrefRangeStart = 1073535, XrefRangeEnd = 1073537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_get_RawText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001EBDC File Offset: 0x0001CDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073543, RefRangeEnd = 1073544, XrefRangeStart = 1073539, XrefRangeEnd = 1073543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<char> ToEnumerable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr_ToEnumerable_Public_IEnumerable_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<char>>(intPtr3) : null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001EC1C File Offset: 0x0001CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073544, XrefRangeEnd = 1073554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FormatItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001EC60 File Offset: 0x0001CE60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00004231 File Offset: 0x00002431
		public FormatItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000423A File Offset: 0x0000243A
		public unsafe string baseString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_baseString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_baseString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00004259 File Offset: 0x00002459
		public unsafe int endIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_endIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_endIndex)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001ECEC File Offset: 0x0001CEEC
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00004274 File Offset: 0x00002474
		public unsafe SmartSettings SmartSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_SmartSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_SmartSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001ED1C File Offset: 0x0001CF1C
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00004293 File Offset: 0x00002493
		public unsafe int startIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_startIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_startIndex)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001ED44 File Offset: 0x0001CF44
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x000042AE File Offset: 0x000024AE
		public unsafe string m_RawText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_m_RawText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr_m_RawText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001ED6C File Offset: 0x0001CF6C
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000042CD File Offset: 0x000024CD
		public unsafe FormatItem _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FormatItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_baseString;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_endIndex;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_SmartSettings;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_m_RawText;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_FormatItem_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_FormatItem_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_Int32_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_Int32_Int32_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_SmartSettings_FormatItem_String_Int32_Int32_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_get_RawText_Public_get_String_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_ToEnumerable_Public_IEnumerable_1_Char_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200014E RID: 334
		public sealed class PartialCharEnumerator : ValueType
		{
			// Token: 0x06000ECB RID: 3787 RVA: 0x0003FD60 File Offset: 0x0003DF60
			// Note: this type is marked as 'beforefieldinit'.
			static PartialCharEnumerator()
			{
				Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatItem>.NativeClassPtr, "PartialCharEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr);
				FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_BaseString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, "m_BaseString");
				FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, "m_From");
				FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, "m_To");
				FormatItem.PartialCharEnumerator.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, 100664360);
				FormatItem.PartialCharEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, 100664361);
				FormatItem.PartialCharEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, 100664362);
			}

			// Token: 0x06000ECC RID: 3788 RVA: 0x0003FE04 File Offset: 0x0003E004
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 745917, RefRangeEnd = 745928, XrefRangeStart = 745917, XrefRangeEnd = 745928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PartialCharEnumerator(string s, int from, int to)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000ECD RID: 3789 RVA: 0x0003FE70 File Offset: 0x0003E070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073507, XrefRangeEnd = 1073512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<char> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<char>>(intPtr3) : null;
			}

			// Token: 0x06000ECE RID: 3790 RVA: 0x0003FEB4 File Offset: 0x0003E0B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000ECF RID: 3791 RVA: 0x00008346 File Offset: 0x00006546
			public PartialCharEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000ED0 RID: 3792 RVA: 0x0000834F File Offset: 0x0000654F
			public PartialCharEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0003FEF8 File Offset: 0x0003E0F8
			// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00008361 File Offset: 0x00006561
			public unsafe string m_BaseString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_BaseString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_BaseString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0003FF20 File Offset: 0x0003E120
			// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00008380 File Offset: 0x00006580
			public unsafe int m_From
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_From);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_From)) = value;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0003FF48 File Offset: 0x0003E148
			// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0000839B File Offset: 0x0000659B
			public unsafe int m_To
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_To);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator.NativeFieldInfoPtr_m_To)) = value;
				}
			}

			// Token: 0x04000A2B RID: 2603
			private static readonly IntPtr NativeFieldInfoPtr_m_BaseString;

			// Token: 0x04000A2C RID: 2604
			private static readonly IntPtr NativeFieldInfoPtr_m_From;

			// Token: 0x04000A2D RID: 2605
			private static readonly IntPtr NativeFieldInfoPtr_m_To;

			// Token: 0x04000A2E RID: 2606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;

			// Token: 0x04000A2F RID: 2607
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Char_0;

			// Token: 0x04000A30 RID: 2608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0200018F RID: 399
			[ObfuscatedName("UnityEngine.Localization.SmartFormat.Core.Parsing.FormatItem+PartialCharEnumerator+<GetEnumerator>d__4")]
			public sealed class _GetEnumerator_d__4 : Object
			{
				// Token: 0x06001027 RID: 4135 RVA: 0x000442C4 File Offset: 0x000424C4
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__4()
				{
					Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, "<GetEnumerator>d__4");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr);
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, "<>1__state");
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, "<>2__current");
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, "<>4__this");
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, "<i>5__2");
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, 100664363);
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, 100664364);
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, 100664365);
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Char__get_Current_Private_Virtual_Final_New_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, 100664366);
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, 100664367);
					FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr, 100664368);
				}

				// Token: 0x06001028 RID: 4136 RVA: 0x000443B8 File Offset: 0x000425B8
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__4(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator._GetEnumerator_d__4>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001029 RID: 4137 RVA: 0x00044400 File Offset: 0x00042600
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600102A RID: 4138 RVA: 0x00044434 File Offset: 0x00042634
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073497, XrefRangeEnd = 1073499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000458 RID: 1112
				// (get) Token: 0x0600102B RID: 4139 RVA: 0x00044470 File Offset: 0x00042670
				public unsafe char System.Collections.Generic.IEnumerator<System.Char>.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Char__get_Current_Private_Virtual_Final_New_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600102C RID: 4140 RVA: 0x000444AC File Offset: 0x000426AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073499, XrefRangeEnd = 1073504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000459 RID: 1113
				// (get) Token: 0x0600102D RID: 4141 RVA: 0x000444E0 File Offset: 0x000426E0
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073504, XrefRangeEnd = 1073507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600102E RID: 4142 RVA: 0x00008D0F File Offset: 0x00006F0F
				public _GetEnumerator_d__4(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000454 RID: 1108
				// (get) Token: 0x0600102F RID: 4143 RVA: 0x00044520 File Offset: 0x00042720
				// (set) Token: 0x06001030 RID: 4144 RVA: 0x00008D18 File Offset: 0x00006F18
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000455 RID: 1109
				// (get) Token: 0x06001031 RID: 4145 RVA: 0x00044548 File Offset: 0x00042748
				// (set) Token: 0x06001032 RID: 4146 RVA: 0x00008D33 File Offset: 0x00006F33
				public unsafe char __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___2__current);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___2__current)) = value;
					}
				}

				// Token: 0x17000456 RID: 1110
				// (get) Token: 0x06001033 RID: 4147 RVA: 0x00044570 File Offset: 0x00042770
				// (set) Token: 0x06001034 RID: 4148 RVA: 0x00008D4E File Offset: 0x00006F4E
				public FormatItem.PartialCharEnumerator __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___4__this);
						return new FormatItem.PartialCharEnumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FormatItem.PartialCharEnumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000457 RID: 1111
				// (get) Token: 0x06001035 RID: 4149 RVA: 0x000445A0 File Offset: 0x000427A0
				// (set) Token: 0x06001036 RID: 4150 RVA: 0x00008D7C File Offset: 0x00006F7C
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatItem.PartialCharEnumerator._GetEnumerator_d__4.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04000B09 RID: 2825
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04000B0A RID: 2826
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04000B0B RID: 2827
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04000B0C RID: 2828
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04000B0D RID: 2829
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04000B0E RID: 2830
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000B0F RID: 2831
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04000B10 RID: 2832
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Char__get_Current_Private_Virtual_Final_New_get_Char_0;

				// Token: 0x04000B11 RID: 2833
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000B12 RID: 2834
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
