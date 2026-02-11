using System;
using Canis.gameLogs;
using coreactionlog.actionlog;
using dwd.core.input.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;

namespace worm.match.components
{
	// Token: 0x020001CB RID: 459
	public class WormActionLog : AttributeActionLog
	{
		// Token: 0x0600142C RID: 5164 RVA: 0x000555AC File Offset: 0x000537AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormActionLog()
		{
			Il2CppClassPointerStore<WormActionLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormActionLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr);
			WormActionLog.NativeFieldInfoPtr_agentTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "agentTemplate");
			WormActionLog.NativeFieldInfoPtr_agentSubTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "agentSubTemplate");
			WormActionLog.NativeFieldInfoPtr_revealTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "revealTemplate");
			WormActionLog.NativeFieldInfoPtr_revealSubTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "revealSubTemplate");
			WormActionLog.NativeFieldInfoPtr_intrigueTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "intrigueTemplate");
			WormActionLog.NativeFieldInfoPtr_techTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "techTemplate");
			WormActionLog.NativeFieldInfoPtr_intrigueSubTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "intrigueSubTemplate");
			WormActionLog.NativeFieldInfoPtr_conflictTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "conflictTemplate");
			WormActionLog.NativeFieldInfoPtr_conflictSubTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "conflictSubTemplate");
			WormActionLog.NativeFieldInfoPtr_spaceTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "spaceTemplate");
			WormActionLog.NativeFieldInfoPtr_spaceSubTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "spaceSubTemplate");
			WormActionLog.NativeFieldInfoPtr_techSubTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "techSubTemplate");
			WormActionLog.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "inputContext");
			WormActionLog.NativeFieldInfoPtr_discardToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "discardToggles");
			WormActionLog.NativeFieldInfoPtr_showFilterLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, "showFilterLogs");
			WormActionLog.NativeMethodInfoPtr_get_logEntityName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666069);
			WormActionLog.NativeMethodInfoPtr_Event_ToggleExpanded_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666070);
			WormActionLog.NativeMethodInfoPtr_Event_ToggleFilter_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666071);
			WormActionLog.NativeMethodInfoPtr_getLogEntryPrefab_Protected_Virtual_GameObject_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666072);
			WormActionLog.NativeMethodInfoPtr_GetTemplate_Private_GameObject_LogTemplates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666073);
			WormActionLog.NativeMethodInfoPtr_AcquireFilter_Private_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666074);
			WormActionLog.NativeMethodInfoPtr_GetLogString_Protected_Virtual_String_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666075);
			WormActionLog.NativeMethodInfoPtr_ProcessLogText_Public_Static_String_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666076);
			WormActionLog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr, 100666077);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x000557BC File Offset: 0x000539BC
		public unsafe override string logEntityName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713784, XrefRangeEnd = 713789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLog.NativeMethodInfoPtr_get_logEntityName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00055800 File Offset: 0x00053A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713789, XrefRangeEnd = 713801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Event_ToggleExpanded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLog.NativeMethodInfoPtr_Event_ToggleExpanded_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0005583C File Offset: 0x00053A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713801, XrefRangeEnd = 713811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleFilter(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLog.NativeMethodInfoPtr_Event_ToggleFilter_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0005587C File Offset: 0x00053A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713811, XrefRangeEnd = 713837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameObject getLogEntryPrefab(SerializedGameLog log, SerializedGameLog parent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLog.NativeMethodInfoPtr_getLogEntryPrefab_Protected_Virtual_GameObject_SerializedGameLog_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000558EC File Offset: 0x00053AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 713837, RefRangeEnd = 713838, XrefRangeStart = 713837, XrefRangeEnd = 713837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetTemplate(LogTemplates type, bool isBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLog.NativeMethodInfoPtr_GetTemplate_Private_GameObject_LogTemplates_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00055948 File Offset: 0x00053B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713838, XrefRangeEnd = 713844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AcquireFilter(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLog.NativeMethodInfoPtr_AcquireFilter_Private_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00055998 File Offset: 0x00053B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713844, XrefRangeEnd = 713845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetLogString(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActionLog.NativeMethodInfoPtr_GetLogString_Protected_Virtual_String_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000559EC File Offset: 0x00053BEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 713868, RefRangeEnd = 713870, XrefRangeStart = 713845, XrefRangeEnd = 713868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ProcessLogText(SerializedGameLog log)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLog.NativeMethodInfoPtr_ProcessLogText_Public_Static_String_SerializedGameLog_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00055A28 File Offset: 0x00053C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713870, XrefRangeEnd = 713879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActionLog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActionLog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActionLog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0000C5C7 File Offset: 0x0000A7C7
		public WormActionLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00055A64 File Offset: 0x00053C64
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		public unsafe GameObject agentTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_agentTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_agentTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00055A94 File Offset: 0x00053C94
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0000C5EF File Offset: 0x0000A7EF
		public unsafe GameObject agentSubTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_agentSubTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_agentSubTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00055AC4 File Offset: 0x00053CC4
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0000C60E File Offset: 0x0000A80E
		public unsafe GameObject revealTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_revealTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_revealTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x00055AF4 File Offset: 0x00053CF4
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0000C62D File Offset: 0x0000A82D
		public unsafe GameObject revealSubTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_revealSubTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_revealSubTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00055B24 File Offset: 0x00053D24
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0000C64C File Offset: 0x0000A84C
		public unsafe GameObject intrigueTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_intrigueTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_intrigueTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x00055B54 File Offset: 0x00053D54
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x0000C66B File Offset: 0x0000A86B
		public unsafe GameObject techTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_techTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_techTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x00055B84 File Offset: 0x00053D84
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x0000C68A File Offset: 0x0000A88A
		public unsafe GameObject intrigueSubTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_intrigueSubTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_intrigueSubTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00055BB4 File Offset: 0x00053DB4
		// (set) Token: 0x06001446 RID: 5190 RVA: 0x0000C6A9 File Offset: 0x0000A8A9
		public unsafe GameObject conflictTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_conflictTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_conflictTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00055BE4 File Offset: 0x00053DE4
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public unsafe GameObject conflictSubTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_conflictSubTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_conflictSubTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00055C14 File Offset: 0x00053E14
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x0000C6E7 File Offset: 0x0000A8E7
		public unsafe GameObject spaceTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_spaceTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_spaceTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x00055C44 File Offset: 0x00053E44
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x0000C706 File Offset: 0x0000A906
		public unsafe GameObject spaceSubTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_spaceSubTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_spaceSubTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00055C74 File Offset: 0x00053E74
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x0000C725 File Offset: 0x0000A925
		public unsafe GameObject techSubTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_techSubTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_techSubTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00055CA4 File Offset: 0x00053EA4
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x0000C744 File Offset: 0x0000A944
		public unsafe CreateInputContext inputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_inputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00055CD4 File Offset: 0x00053ED4
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0000C763 File Offset: 0x0000A963
		public unsafe Il2CppReferenceArray<Toggle> discardToggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_discardToggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_discardToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00055D04 File Offset: 0x00053F04
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x0000C782 File Offset: 0x0000A982
		public unsafe Il2CppStringArray showFilterLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_showFilterLogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormActionLog.NativeFieldInfoPtr_showFilterLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_agentTemplate;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr_agentSubTemplate;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr_revealTemplate;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeFieldInfoPtr_revealSubTemplate;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr_intrigueTemplate;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_techTemplate;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr_intrigueSubTemplate;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_conflictTemplate;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr_conflictSubTemplate;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_spaceTemplate;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr_spaceSubTemplate;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr_techSubTemplate;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeFieldInfoPtr_inputContext;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeFieldInfoPtr_discardToggles;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr_showFilterLogs;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_get_logEntityName_Protected_Virtual_get_String_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleExpanded_Public_Virtual_Void_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleFilter_Public_Void_Boolean_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_getLogEntryPrefab_Protected_Virtual_GameObject_SerializedGameLog_SerializedGameLog_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_GetTemplate_Private_GameObject_LogTemplates_Boolean_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_AcquireFilter_Private_Boolean_SerializedGameLog_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_GetLogString_Protected_Virtual_String_SerializedGameLog_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLogText_Public_Static_String_SerializedGameLog_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
