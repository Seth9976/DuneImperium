using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine;
using UnityEngine.UI;

namespace canis.console.src
{
	// Token: 0x02000006 RID: 6
	public class FilterableLogDisplay : LogProcessor
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002F7C File Offset: 0x0000117C
		// Note: this type is marked as 'beforefieldinit'.
		static FilterableLogDisplay()
		{
			Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "canis.console.src", "FilterableLogDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr);
			FilterableLogDisplay.NativeFieldInfoPtr_maxDisplayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "maxDisplayCount");
			FilterableLogDisplay.NativeFieldInfoPtr_displayPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "displayPrototype");
			FilterableLogDisplay.NativeFieldInfoPtr_infoToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "infoToggle");
			FilterableLogDisplay.NativeFieldInfoPtr_warningToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "warningToggle");
			FilterableLogDisplay.NativeFieldInfoPtr_errorToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "errorToggle");
			FilterableLogDisplay.NativeFieldInfoPtr_logs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "logs");
			FilterableLogDisplay.NativeFieldInfoPtr_fullTypeCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "fullTypeCounts");
			FilterableLogDisplay.NativeFieldInfoPtr_storedTypeCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "storedTypeCounts");
			FilterableLogDisplay.NativeFieldInfoPtr_typeToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "typeToggles");
			FilterableLogDisplay.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "displays");
			FilterableLogDisplay.NativeFieldInfoPtr_logStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "logStringBuilder");
			FilterableLogDisplay.NativeFieldInfoPtr_MaxLogEntryLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "MaxLogEntryLength");
			FilterableLogDisplay.NativeFieldInfoPtr_displayParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "displayParent");
			FilterableLogDisplay.NativeFieldInfoPtr_needsRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, "needsRebuild");
			FilterableLogDisplay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, 100663303);
			FilterableLogDisplay.NativeMethodInfoPtr_ProcessLog_Public_Virtual_Void_String_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, 100663304);
			FilterableLogDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, 100663305);
			FilterableLogDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, 100663306);
			FilterableLogDisplay.NativeMethodInfoPtr_Method_Private_Void_Toggle_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, 100663307);
			FilterableLogDisplay.NativeMethodInfoPtr__Start_b__14_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000313C File Offset: 0x0000133C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255295, XrefRangeEnd = 1255304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterableLogDisplay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003170 File Offset: 0x00001370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255304, XrefRangeEnd = 1255355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessLog(string logString, string stackTrace, ref LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterableLogDisplay.NativeMethodInfoPtr_ProcessLog_Public_Virtual_Void_String_String_byref_LogType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031E0 File Offset: 0x000013E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255355, XrefRangeEnd = 1255420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterableLogDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003214 File Offset: 0x00001414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255420, XrefRangeEnd = 1255473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterableLogDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterableLogDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterableLogDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003250 File Offset: 0x00001450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1255491, RefRangeEnd = 1255494, XrefRangeStart = 1255473, XrefRangeEnd = 1255491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Toggle_LogType_0(Toggle toggle, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterableLogDisplay.NativeMethodInfoPtr_Method_Private_Void_Toggle_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000032A0 File Offset: 0x000014A0
		[CallerCount(0)]
		public unsafe void _Start_b__14_1(bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterableLogDisplay.NativeMethodInfoPtr__Start_b__14_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020E7 File Offset: 0x000002E7
		public FilterableLogDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000032E0 File Offset: 0x000014E0
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe int maxDisplayCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_maxDisplayCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_maxDisplayCount)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003308 File Offset: 0x00001508
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000210B File Offset: 0x0000030B
		public unsafe Text displayPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_displayPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_displayPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003338 File Offset: 0x00001538
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000212A File Offset: 0x0000032A
		public unsafe Toggle infoToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_infoToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_infoToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003368 File Offset: 0x00001568
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002149 File Offset: 0x00000349
		public unsafe Toggle warningToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_warningToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_warningToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003398 File Offset: 0x00001598
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002168 File Offset: 0x00000368
		public unsafe Toggle errorToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_errorToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_errorToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000033C8 File Offset: 0x000015C8
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002187 File Offset: 0x00000387
		public unsafe LinkedList<ValueTuple<LogType, string>> logs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_logs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ValueTuple<LogType, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_logs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000033F8 File Offset: 0x000015F8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000021A6 File Offset: 0x000003A6
		public unsafe Dictionary<LogType, int> fullTypeCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_fullTypeCounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LogType, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_fullTypeCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003428 File Offset: 0x00001628
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021C5 File Offset: 0x000003C5
		public unsafe Dictionary<LogType, int> storedTypeCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_storedTypeCounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LogType, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_storedTypeCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003458 File Offset: 0x00001658
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021E4 File Offset: 0x000003E4
		public unsafe Dictionary<LogType, ValueTuple<Toggle, Text>> typeToggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_typeToggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LogType, ValueTuple<Toggle, Text>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_typeToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003488 File Offset: 0x00001688
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002203 File Offset: 0x00000403
		public unsafe List<Text> displays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_displays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_displays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000034B8 File Offset: 0x000016B8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002222 File Offset: 0x00000422
		public unsafe StringBuilder logStringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_logStringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_logStringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000034E8 File Offset: 0x000016E8
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002241 File Offset: 0x00000441
		public unsafe static int MaxLogEntryLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FilterableLogDisplay.NativeFieldInfoPtr_MaxLogEntryLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterableLogDisplay.NativeFieldInfoPtr_MaxLogEntryLength, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003504 File Offset: 0x00001704
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000224F File Offset: 0x0000044F
		public unsafe Transform displayParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_displayParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_displayParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003534 File Offset: 0x00001734
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000226E File Offset: 0x0000046E
		public unsafe bool needsRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_needsRebuild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterableLogDisplay.NativeFieldInfoPtr_needsRebuild)) = value;
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_maxDisplayCount;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_displayPrototype;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_infoToggle;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_warningToggle;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_errorToggle;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_logs;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeCounts;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_storedTypeCounts;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_typeToggles;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_logStringBuilder;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_MaxLogEntryLength;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_displayParent;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_needsRebuild;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLog_Public_Virtual_Void_String_String_byref_LogType_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Toggle_LogType_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__14_1_Private_Void_Boolean_0;
	}
}
