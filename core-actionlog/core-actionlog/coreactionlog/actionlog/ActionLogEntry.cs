using System;
using Canis.gameLogs;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace coreactionlog.actionlog
{
	// Token: 0x02000006 RID: 6
	public class ActionLogEntry : MonoBehaviour
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002C2C File Offset: 0x00000E2C
		// Note: this type is marked as 'beforefieldinit'.
		static ActionLogEntry()
		{
			Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-actionlog.dll", "coreactionlog.actionlog", "ActionLogEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr);
			ActionLogEntry.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, "body");
			ActionLogEntry.NativeFieldInfoPtr_tintBacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, "tintBacker");
			ActionLogEntry.NativeFieldInfoPtr_sublogRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, "sublogRoot");
			ActionLogEntry.NativeFieldInfoPtr__Log_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, "<Log>k__BackingField");
			ActionLogEntry.NativeMethodInfoPtr_get_SublogRoot_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663303);
			ActionLogEntry.NativeMethodInfoPtr_get_Log_Public_get_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663304);
			ActionLogEntry.NativeMethodInfoPtr_set_Log_Private_set_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663305);
			ActionLogEntry.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663306);
			ActionLogEntry.NativeMethodInfoPtr_ProcessLogText_Protected_Virtual_New_String_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663307);
			ActionLogEntry.NativeMethodInfoPtr_HandleUndo_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663308);
			ActionLogEntry.NativeMethodInfoPtr_GetTotalHeight_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663309);
			ActionLogEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr, 100663310);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002D4C File Offset: 0x00000F4C
		public unsafe RectTransform SublogRoot
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntry.NativeMethodInfoPtr_get_SublogRoot_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002D8C File Offset: 0x00000F8C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002DCC File Offset: 0x00000FCC
		public unsafe SerializedGameLog Log
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntry.NativeMethodInfoPtr_get_Log_Public_get_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntry.NativeMethodInfoPtr_set_Log_Private_set_Void_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002E10 File Offset: 0x00001010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259534, RefRangeEnd = 1259535, XrefRangeStart = 1259510, XrefRangeEnd = 1259534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(SerializedGameLog gameLog, int logIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLog);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionLogEntry.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_SerializedGameLog_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002E6C File Offset: 0x0000106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ProcessLogText(LocalizableTextVariables logText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionLogEntry.NativeMethodInfoPtr_ProcessLogText_Protected_Virtual_New_String_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002EC0 File Offset: 0x000010C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259535, XrefRangeEnd = 1259538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionLogEntry.NativeMethodInfoPtr_HandleUndo_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002EFC File Offset: 0x000010FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259538, XrefRangeEnd = 1259564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetTotalHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionLogEntry.NativeMethodInfoPtr_GetTotalHeight_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002F44 File Offset: 0x00001144
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionLogEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionLogEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionLogEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020E7 File Offset: 0x000002E7
		public ActionLogEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002F80 File Offset: 0x00001180
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe TMP_Text body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr_body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002FB0 File Offset: 0x000011B0
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe Image tintBacker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr_tintBacker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr_tintBacker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002FE0 File Offset: 0x000011E0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x0000212E File Offset: 0x0000032E
		public unsafe RectTransform sublogRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr_sublogRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr_sublogRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003010 File Offset: 0x00001210
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000214D File Offset: 0x0000034D
		public unsafe SerializedGameLog _Log_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr__Log_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionLogEntry.NativeFieldInfoPtr__Log_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_body;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_tintBacker;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_sublogRoot;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr__Log_k__BackingField;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_SublogRoot_Public_get_RectTransform_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_Log_Public_get_SerializedGameLog_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_Log_Private_set_Void_SerializedGameLog_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_SerializedGameLog_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLogText_Protected_Virtual_New_String_LocalizableTextVariables_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_HandleUndo_Protected_Virtual_New_Void_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalHeight_Public_Virtual_New_Single_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
