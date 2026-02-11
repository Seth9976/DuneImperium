using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	// Token: 0x02000084 RID: 132
	public class FormatCache : Object
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x00020D68 File Offset: 0x0001EF68
		// Note: this type is marked as 'beforefieldinit'.
		static FormatCache()
		{
			Il2CppClassPointerStore<FormatCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Formatting", "FormatCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatCache>.NativeClassPtr);
			FormatCache.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, "<Format>k__BackingField");
			FormatCache.NativeFieldInfoPtr__CachedObjects_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, "<CachedObjects>k__BackingField");
			FormatCache.NativeFieldInfoPtr_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, "Table");
			FormatCache.NativeFieldInfoPtr__LocalVariables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, "<LocalVariables>k__BackingField");
			FormatCache.NativeFieldInfoPtr__VariableTriggers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, "<VariableTriggers>k__BackingField");
			FormatCache.NativeMethodInfoPtr_get_Format_Public_get_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664451);
			FormatCache.NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664452);
			FormatCache.NativeMethodInfoPtr_get_CachedObjects_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664453);
			FormatCache.NativeMethodInfoPtr_get_LocalVariables_Public_get_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664454);
			FormatCache.NativeMethodInfoPtr_set_LocalVariables_Public_set_Void_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664455);
			FormatCache.NativeMethodInfoPtr_get_VariableTriggers_Public_get_List_1_IVariableValueChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664456);
			FormatCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatCache>.NativeClassPtr, 100664457);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00020E88 File Offset: 0x0001F088
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		public unsafe Format Format
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr_get_Format_Public_get_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00020F0C File Offset: 0x0001F10C
		public unsafe Dictionary<string, Object> CachedObjects
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr_get_CachedObjects_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00020F4C File Offset: 0x0001F14C
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00020F8C File Offset: 0x0001F18C
		public unsafe IVariableGroup LocalVariables
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr_get_LocalVariables_Public_get_IVariableGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr_set_LocalVariables_Public_set_Void_IVariableGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		public unsafe List<IVariableValueChanged> VariableTriggers
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr_get_VariableTriggers_Public_get_List_1_IVariableValueChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IVariableValueChanged>>(intPtr3) : null;
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00021010 File Offset: 0x0001F210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074208, RefRangeEnd = 1074209, XrefRangeStart = 1074193, XrefRangeEnd = 1074208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00004645 File Offset: 0x00002845
		public FormatCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0002104C File Offset: 0x0001F24C
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0000464E File Offset: 0x0000284E
		public unsafe Format _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__Format_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0002107C File Offset: 0x0001F27C
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0000466D File Offset: 0x0000286D
		public unsafe Dictionary<string, Object> _CachedObjects_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__CachedObjects_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__CachedObjects_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000210AC File Offset: 0x0001F2AC
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0000468C File Offset: 0x0000288C
		public unsafe LocalizationTable Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr_Table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr_Table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000210DC File Offset: 0x0001F2DC
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x000046AB File Offset: 0x000028AB
		public unsafe IVariableGroup _LocalVariables_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__LocalVariables_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__LocalVariables_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0002110C File Offset: 0x0001F30C
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x000046CA File Offset: 0x000028CA
		public unsafe List<IVariableValueChanged> _VariableTriggers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__VariableTriggers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IVariableValueChanged>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatCache.NativeFieldInfoPtr__VariableTriggers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr__CachedObjects_k__BackingField;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_Table;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr__LocalVariables_k__BackingField;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr__VariableTriggers_k__BackingField;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_Format_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_get_CachedObjects_Public_get_Dictionary_2_String_Object_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalVariables_Public_get_IVariableGroup_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalVariables_Public_set_Void_IVariableGroup_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_get_VariableTriggers_Public_get_List_1_IVariableValueChanged_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
