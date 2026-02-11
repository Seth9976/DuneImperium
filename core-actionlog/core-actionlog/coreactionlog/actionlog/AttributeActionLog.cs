using System;
using Canis.gameLogs;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace coreactionlog.actionlog
{
	// Token: 0x02000008 RID: 8
	public class AttributeActionLog : MonoBehaviour
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000031E8 File Offset: 0x000013E8
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeActionLog()
		{
			Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-actionlog.dll", "coreactionlog.actionlog", "AttributeActionLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr);
			AttributeActionLog.NativeFieldInfoPtr_entryTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "entryTemplate");
			AttributeActionLog.NativeFieldInfoPtr_subentryTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "subentryTemplate");
			AttributeActionLog.NativeFieldInfoPtr_logContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "logContainer");
			AttributeActionLog.NativeFieldInfoPtr_scrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "scrollbar");
			AttributeActionLog.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "anim");
			AttributeActionLog.NativeFieldInfoPtr_minimize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "minimize");
			AttributeActionLog.NativeFieldInfoPtr_showLogButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "showLogButton");
			AttributeActionLog.NativeFieldInfoPtr_showLogToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "showLogToggle");
			AttributeActionLog.NativeFieldInfoPtr_autoScrollCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "autoScrollCoroutine");
			AttributeActionLog.NativeFieldInfoPtr_expanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "expanded");
			AttributeActionLog.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<Initialized>k__BackingField");
			AttributeActionLog.NativeFieldInfoPtr_logsToPopulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "logsToPopulate");
			AttributeActionLog.NativeFieldInfoPtr_instantiatedLogEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "instantiatedLogEntries");
			AttributeActionLog.NativeFieldInfoPtr_gameLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "gameLogs");
			AttributeActionLog.NativeFieldInfoPtr_displayLogFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "displayLogFilter");
			AttributeActionLog.NativeFieldInfoPtr_subLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "subLogs");
			AttributeActionLog.NativeFieldInfoPtr_historyLogsToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "historyLogsToLoad");
			AttributeActionLog.NativeFieldInfoPtr_maxInstantiatedLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "maxInstantiatedLogs");
			AttributeActionLog.NativeFieldInfoPtr_logsAvailableIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "logsAvailableIndicator");
			AttributeActionLog.NativeFieldInfoPtr_initializeOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "initializeOnStart");
			AttributeActionLog.NativeFieldInfoPtr_onLogOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "onLogOpened");
			AttributeActionLog.NativeFieldInfoPtr_onLogClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "onLogClosed");
			AttributeActionLog.NativeFieldInfoPtr_lastAddedLogIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "lastAddedLogIndex");
			AttributeActionLog.NativeFieldInfoPtr_shouldScrollToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "shouldScrollToBottom");
			AttributeActionLog.NativeFieldInfoPtr_FORCE_SCROLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "FORCE_SCROLL_THRESHOLD");
			AttributeActionLog.NativeFieldInfoPtr_END_OF_LOG_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "END_OF_LOG_THRESHOLD");
			AttributeActionLog.NativeFieldInfoPtr_disableScrollLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "disableScrollLoad");
			AttributeActionLog.NativeFieldInfoPtr_playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "playmat");
			AttributeActionLog.NativeMethodInfoPtr_get_logEntityName_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663314);
			AttributeActionLog.NativeMethodInfoPtr_get_Expanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663315);
			AttributeActionLog.NativeMethodInfoPtr_set_Expanded_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663316);
			AttributeActionLog.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663317);
			AttributeActionLog.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663318);
			AttributeActionLog.NativeMethodInfoPtr_get_HasFilter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663319);
			AttributeActionLog.NativeMethodInfoPtr_get_DisableAutoScroll_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663320);
			AttributeActionLog.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663321);
			AttributeActionLog.NativeMethodInfoPtr_Initialize_Public_Void_List_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663322);
			AttributeActionLog.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663323);
			AttributeActionLog.NativeMethodInfoPtr_ContainsLog_Public_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663324);
			AttributeActionLog.NativeMethodInfoPtr_getEarliestUnloadedLogIndex_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663325);
			AttributeActionLog.NativeMethodInfoPtr_getLatestUnloadedLogIndex_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663326);
			AttributeActionLog.NativeMethodInfoPtr_HandleDragOrScroll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663327);
			AttributeActionLog.NativeMethodInfoPtr_AddLog_Public_Virtual_New_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663328);
			AttributeActionLog.NativeMethodInfoPtr_AddLogs_Public_Void_List_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663329);
			AttributeActionLog.NativeMethodInfoPtr_SetFilter_Public_Void_Func_2_SerializedGameLog_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663330);
			AttributeActionLog.NativeMethodInfoPtr_instantiateLogs_Protected_Virtual_New_Void_Int32_Int32_LoadMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663331);
			AttributeActionLog.NativeMethodInfoPtr_instantiateEntry_Private_GameObject_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663332);
			AttributeActionLog.NativeMethodInfoPtr_instantiateSubLog_Private_Void_SerializedGameLog_Int32_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663333);
			AttributeActionLog.NativeMethodInfoPtr_ReplaceExistingLog_Private_Static_Boolean_SerializedGameLog_List_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663334);
			AttributeActionLog.NativeMethodInfoPtr_getLogEntryPrefab_Protected_Virtual_New_GameObject_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663335);
			AttributeActionLog.NativeMethodInfoPtr_Event_ScrollToBottom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663336);
			AttributeActionLog.NativeMethodInfoPtr_StartScrollToBottom_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663337);
			AttributeActionLog.NativeMethodInfoPtr_scrollToBottomInOneFrame_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663338);
			AttributeActionLog.NativeMethodInfoPtr_loadLogsBackwardAfterOneFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663339);
			AttributeActionLog.NativeMethodInfoPtr_loadLogsForwardAfterOneFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663340);
			AttributeActionLog.NativeMethodInfoPtr_GetDisplayLogs_Private_IReadOnlyList_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663341);
			AttributeActionLog.NativeMethodInfoPtr_FindDisplayLogIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663342);
			AttributeActionLog.NativeMethodInfoPtr_GetSubLogs_Protected_IReadOnlyList_1_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663343);
			AttributeActionLog.NativeMethodInfoPtr_GetDisplaySubLogs_Private_IReadOnlyList_1_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663344);
			AttributeActionLog.NativeMethodInfoPtr_Event_ToggleExpanded_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663345);
			AttributeActionLog.NativeMethodInfoPtr_populateLogs_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663346);
			AttributeActionLog.NativeMethodInfoPtr_cleanLogs_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663347);
			AttributeActionLog.NativeMethodInfoPtr_GetLogStrings_Public_Virtual_Final_New_SortedDictionary_2_Int32_IReadOnlyList_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663348);
			AttributeActionLog.NativeMethodInfoPtr_GetLogString_Protected_Virtual_New_String_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663349);
			AttributeActionLog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663350);
			AttributeActionLog.NativeMethodInfoPtr__Start_b__41_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, 100663351);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003740 File Offset: 0x00001940
		public unsafe virtual string logEntityName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259648, XrefRangeEnd = 1259650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_get_logEntityName_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003784 File Offset: 0x00001984
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000037C0 File Offset: 0x000019C0
		public unsafe bool Expanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_get_Expanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259650, XrefRangeEnd = 1259657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_set_Expanded_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003800 File Offset: 0x00001A00
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000383C File Offset: 0x00001A3C
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000387C File Offset: 0x00001A7C
		public unsafe bool HasFilter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259657, RefRangeEnd = 1259658, XrefRangeStart = 1259657, XrefRangeEnd = 1259657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_get_HasFilter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000038B8 File Offset: 0x00001AB8
		public unsafe virtual bool DisableAutoScroll
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_get_DisableAutoScroll_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003900 File Offset: 0x00001B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259658, XrefRangeEnd = 1259663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003940 File Offset: 0x00001B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259663, XrefRangeEnd = 1259664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<SerializedGameLog> logs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_Initialize_Public_Void_List_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003984 File Offset: 0x00001B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259664, XrefRangeEnd = 1259671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000039B8 File Offset: 0x00001BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259671, XrefRangeEnd = 1259675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_ContainsLog_Public_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003A08 File Offset: 0x00001C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259680, RefRangeEnd = 1259681, XrefRangeStart = 1259675, XrefRangeEnd = 1259680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getEarliestUnloadedLogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_getEarliestUnloadedLogIndex_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003A44 File Offset: 0x00001C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259681, XrefRangeEnd = 1259686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getLatestUnloadedLogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_getLatestUnloadedLogIndex_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003A80 File Offset: 0x00001C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259697, RefRangeEnd = 1259698, XrefRangeStart = 1259686, XrefRangeEnd = 1259697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDragOrScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_HandleDragOrScroll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003AB4 File Offset: 0x00001CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259698, XrefRangeEnd = 1259735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_AddLog_Public_Virtual_New_Void_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003B04 File Offset: 0x00001D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259774, RefRangeEnd = 1259775, XrefRangeStart = 1259735, XrefRangeEnd = 1259774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLogs(List<SerializedGameLog> logs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_AddLogs_Public_Void_List_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003B48 File Offset: 0x00001D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259778, RefRangeEnd = 1259779, XrefRangeStart = 1259775, XrefRangeEnd = 1259778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFilter(Func<SerializedGameLog, bool> filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_SetFilter_Public_Void_Func_2_SerializedGameLog_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003B8C File Offset: 0x00001D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259779, XrefRangeEnd = 1259830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void instantiateLogs(int startIndex, int logsToAdd = 0, AttributeActionLog.LoadMode loadMode = AttributeActionLog.LoadMode.Populate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logsToAdd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_instantiateLogs_Protected_Virtual_New_Void_Int32_Int32_LoadMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003BF4 File Offset: 0x00001DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259873, RefRangeEnd = 1259874, XrefRangeStart = 1259830, XrefRangeEnd = 1259873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject instantiateEntry(SerializedGameLog logEntry, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logEntry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_instantiateEntry_Private_GameObject_SerializedGameLog_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003C54 File Offset: 0x00001E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259887, RefRangeEnd = 1259888, XrefRangeStart = 1259874, XrefRangeEnd = 1259887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void instantiateSubLog(SerializedGameLog sub, int index, SerializedGameLog parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_instantiateSubLog_Private_Void_SerializedGameLog_Int32_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003CB8 File Offset: 0x00001EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259905, RefRangeEnd = 1259906, XrefRangeStart = 1259888, XrefRangeEnd = 1259905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReplaceExistingLog(SerializedGameLog log, List<SerializedGameLog> list)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_ReplaceExistingLog_Private_Static_Boolean_SerializedGameLog_List_1_SerializedGameLog_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D0C File Offset: 0x00001F0C
		[CallerCount(0)]
		public unsafe virtual GameObject getLogEntryPrefab(SerializedGameLog log, SerializedGameLog parent = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_getLogEntryPrefab_Protected_Virtual_New_GameObject_SerializedGameLog_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003D7C File Offset: 0x00001F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259906, XrefRangeEnd = 1259909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ScrollToBottom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_Event_ScrollToBottom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259912, RefRangeEnd = 1259913, XrefRangeStart = 1259909, XrefRangeEnd = 1259912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartScrollToBottom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_StartScrollToBottom_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003DE4 File Offset: 0x00001FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259913, XrefRangeEnd = 1259918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator scrollToBottomInOneFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_scrollToBottomInOneFrame_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003E30 File Offset: 0x00002030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259918, XrefRangeEnd = 1259923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadLogsBackwardAfterOneFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_loadLogsBackwardAfterOneFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003E70 File Offset: 0x00002070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259923, XrefRangeEnd = 1259928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator loadLogsForwardAfterOneFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_loadLogsForwardAfterOneFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003EB0 File Offset: 0x000020B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259928, XrefRangeEnd = 1259930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<SerializedGameLog> GetDisplayLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_GetDisplayLogs_Private_IReadOnlyList_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedGameLog>>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003EF0 File Offset: 0x000020F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259953, RefRangeEnd = 1259954, XrefRangeStart = 1259930, XrefRangeEnd = 1259953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindDisplayLogIndex(int logId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_FindDisplayLogIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003F3C File Offset: 0x0000213C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259954, XrefRangeEnd = 1259957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<SerializedGameLog> GetSubLogs(int parentId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parentId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_GetSubLogs_Protected_IReadOnlyList_1_SerializedGameLog_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedGameLog>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003F88 File Offset: 0x00002188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259957, XrefRangeEnd = 1259962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<SerializedGameLog> GetDisplaySubLogs(int parentId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parentId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_GetDisplaySubLogs_Private_IReadOnlyList_1_SerializedGameLog_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SerializedGameLog>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003FD4 File Offset: 0x000021D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259977, RefRangeEnd = 1259978, XrefRangeStart = 1259962, XrefRangeEnd = 1259977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ToggleExpanded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_Event_ToggleExpanded_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004010 File Offset: 0x00002210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259990, RefRangeEnd = 1259992, XrefRangeStart = 1259978, XrefRangeEnd = 1259990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void populateLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_populateLogs_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004044 File Offset: 0x00002244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260017, RefRangeEnd = 1260019, XrefRangeStart = 1259992, XrefRangeEnd = 1260017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cleanLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_cleanLogs_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260019, XrefRangeEnd = 1260059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortedDictionary<int, IReadOnlyList<string>> GetLogStrings(int numLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numLogs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr_GetLogStrings_Public_Virtual_Final_New_SortedDictionary_2_Int32_IReadOnlyList_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedDictionary<int, IReadOnlyList<string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000040C4 File Offset: 0x000022C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260059, XrefRangeEnd = 1260060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLogString(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeActionLog.NativeMethodInfoPtr_GetLogString_Protected_Virtual_New_String_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004118 File Offset: 0x00002318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260094, RefRangeEnd = 1260095, XrefRangeStart = 1260060, XrefRangeEnd = 1260094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeActionLog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004154 File Offset: 0x00002354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260095, XrefRangeEnd = 1260097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__41_0(EntityComponent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.NativeMethodInfoPtr__Start_b__41_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000021B3 File Offset: 0x000003B3
		public AttributeActionLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000041A4 File Offset: 0x000023A4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000021BC File Offset: 0x000003BC
		public unsafe GameObject entryTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_entryTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_entryTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000041D4 File Offset: 0x000023D4
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000021DB File Offset: 0x000003DB
		public unsafe GameObject subentryTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_subentryTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_subentryTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000021FA File Offset: 0x000003FA
		public unsafe RectTransform logContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_logContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_logContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004234 File Offset: 0x00002434
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002219 File Offset: 0x00000419
		public unsafe Scrollbar scrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_scrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_scrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004264 File Offset: 0x00002464
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002238 File Offset: 0x00000438
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004294 File Offset: 0x00002494
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002257 File Offset: 0x00000457
		public unsafe int minimize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_minimize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_minimize)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000042BC File Offset: 0x000024BC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002272 File Offset: 0x00000472
		public unsafe GameObject showLogButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_showLogButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_showLogButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000042EC File Offset: 0x000024EC
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002291 File Offset: 0x00000491
		public unsafe Toggle showLogToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_showLogToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_showLogToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000431C File Offset: 0x0000251C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000022B0 File Offset: 0x000004B0
		public unsafe Coroutine autoScrollCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_autoScrollCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_autoScrollCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000434C File Offset: 0x0000254C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000022CF File Offset: 0x000004CF
		public unsafe bool expanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_expanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_expanded)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004374 File Offset: 0x00002574
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000022EA File Offset: 0x000004EA
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000439C File Offset: 0x0000259C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002305 File Offset: 0x00000505
		public unsafe int logsToPopulate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_logsToPopulate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_logsToPopulate)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000043C4 File Offset: 0x000025C4
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002320 File Offset: 0x00000520
		public unsafe SortedDictionary<int, ActionLogEntry> instantiatedLogEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_instantiatedLogEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<int, ActionLogEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_instantiatedLogEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000043F4 File Offset: 0x000025F4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000233F File Offset: 0x0000053F
		public unsafe List<SerializedGameLog> gameLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_gameLogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedGameLog>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_gameLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00004424 File Offset: 0x00002624
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000235E File Offset: 0x0000055E
		public unsafe Func<SerializedGameLog, bool> displayLogFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_displayLogFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedGameLog, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_displayLogFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004454 File Offset: 0x00002654
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000237D File Offset: 0x0000057D
		public unsafe Dictionary<int, List<SerializedGameLog>> subLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_subLogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<SerializedGameLog>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_subLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004484 File Offset: 0x00002684
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000239C File Offset: 0x0000059C
		public unsafe int historyLogsToLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_historyLogsToLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_historyLogsToLoad)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000044AC File Offset: 0x000026AC
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe int maxInstantiatedLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_maxInstantiatedLogs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_maxInstantiatedLogs)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000044D4 File Offset: 0x000026D4
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000023D2 File Offset: 0x000005D2
		public unsafe GameObject logsAvailableIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_logsAvailableIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_logsAvailableIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004504 File Offset: 0x00002704
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000023F1 File Offset: 0x000005F1
		public unsafe bool initializeOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_initializeOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_initializeOnStart)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000452C File Offset: 0x0000272C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000240C File Offset: 0x0000060C
		public unsafe UnityEvent onLogOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_onLogOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_onLogOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000455C File Offset: 0x0000275C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000242B File Offset: 0x0000062B
		public unsafe UnityEvent onLogClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_onLogClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_onLogClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000458C File Offset: 0x0000278C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000244A File Offset: 0x0000064A
		public unsafe int lastAddedLogIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_lastAddedLogIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_lastAddedLogIndex)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000045B4 File Offset: 0x000027B4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002465 File Offset: 0x00000665
		public unsafe bool shouldScrollToBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_shouldScrollToBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_shouldScrollToBottom)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000045DC File Offset: 0x000027DC
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002480 File Offset: 0x00000680
		public unsafe static float FORCE_SCROLL_THRESHOLD
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(AttributeActionLog.NativeFieldInfoPtr_FORCE_SCROLL_THRESHOLD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeActionLog.NativeFieldInfoPtr_FORCE_SCROLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000045F8 File Offset: 0x000027F8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000248E File Offset: 0x0000068E
		public unsafe static float END_OF_LOG_THRESHOLD
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(AttributeActionLog.NativeFieldInfoPtr_END_OF_LOG_THRESHOLD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeActionLog.NativeFieldInfoPtr_END_OF_LOG_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004614 File Offset: 0x00002814
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe bool disableScrollLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_disableScrollLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_disableScrollLoad)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000463C File Offset: 0x0000283C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000024B7 File Offset: 0x000006B7
		public unsafe EntityComponent playmat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_playmat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.NativeFieldInfoPtr_playmat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_entryTemplate;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_subentryTemplate;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_logContainer;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_scrollbar;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_minimize;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_showLogButton;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_showLogToggle;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_autoScrollCoroutine;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_expanded;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_logsToPopulate;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_instantiatedLogEntries;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_gameLogs;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_displayLogFilter;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_subLogs;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_historyLogsToLoad;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_maxInstantiatedLogs;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_logsAvailableIndicator;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_initializeOnStart;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_onLogOpened;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_onLogClosed;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_lastAddedLogIndex;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_shouldScrollToBottom;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_FORCE_SCROLL_THRESHOLD;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_END_OF_LOG_THRESHOLD;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_disableScrollLoad;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_playmat;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_logEntityName_Protected_Virtual_New_get_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_Expanded_Public_get_Boolean_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_set_Expanded_Protected_set_Void_Boolean_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_HasFilter_Public_get_Boolean_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableAutoScroll_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_SerializedGameLog_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_ContainsLog_Public_Boolean_SerializedGameLog_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_getEarliestUnloadedLogIndex_Protected_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_getLatestUnloadedLogIndex_Protected_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_HandleDragOrScroll_Public_Void_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_AddLog_Public_Virtual_New_Void_SerializedGameLog_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_AddLogs_Public_Void_List_1_SerializedGameLog_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_SetFilter_Public_Void_Func_2_SerializedGameLog_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_instantiateLogs_Protected_Virtual_New_Void_Int32_Int32_LoadMode_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_instantiateEntry_Private_GameObject_SerializedGameLog_Int32_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_instantiateSubLog_Private_Void_SerializedGameLog_Int32_SerializedGameLog_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceExistingLog_Private_Static_Boolean_SerializedGameLog_List_1_SerializedGameLog_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_getLogEntryPrefab_Protected_Virtual_New_GameObject_SerializedGameLog_SerializedGameLog_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Event_ScrollToBottom_Public_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_StartScrollToBottom_Protected_Void_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_scrollToBottomInOneFrame_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_loadLogsBackwardAfterOneFrame_Private_IEnumerator_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_loadLogsForwardAfterOneFrame_Private_IEnumerator_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayLogs_Private_IReadOnlyList_1_SerializedGameLog_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_FindDisplayLogIndex_Private_Int32_Int32_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GetSubLogs_Protected_IReadOnlyList_1_SerializedGameLog_Int32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplaySubLogs_Private_IReadOnlyList_1_SerializedGameLog_Int32_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleExpanded_Public_Virtual_New_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_populateLogs_Protected_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_cleanLogs_Protected_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetLogStrings_Public_Virtual_Final_New_SortedDictionary_2_Int32_IReadOnlyList_1_String_Int32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetLogString_Protected_Virtual_New_String_SerializedGameLog_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__41_0_Private_Boolean_EntityComponent_0;

		// Token: 0x0200000C RID: 12
		public enum LoadMode
		{
			// Token: 0x04000067 RID: 103
			Populate,
			// Token: 0x04000068 RID: 104
			Backward,
			// Token: 0x04000069 RID: 105
			Forward
		}

		// Token: 0x0200000D RID: 13
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060000A7 RID: 167 RVA: 0x00004990 File Offset: 0x00002B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr);
				AttributeActionLog.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr, "<>9");
				AttributeActionLog.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr, "<>9__51_0");
				AttributeActionLog.__c.NativeFieldInfoPtr___9__51_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr, "<>9__51_1");
				AttributeActionLog.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr, 100663353);
				AttributeActionLog.__c.NativeMethodInfoPtr__instantiateLogs_b__51_0_Internal_Int32_KeyValuePair_2_Int32_ActionLogEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr, 100663354);
				AttributeActionLog.__c.NativeMethodInfoPtr__instantiateLogs_b__51_1_Internal_Int32_KeyValuePair_2_Int32_ActionLogEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr, 100663355);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00004A34 File Offset: 0x00002C34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00004A70 File Offset: 0x00002C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259583, XrefRangeEnd = 1259584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _instantiateLogs_b__51_0(KeyValuePair<int, ActionLogEntry> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c.NativeMethodInfoPtr__instantiateLogs_b__51_0_Internal_Int32_KeyValuePair_2_Int32_ActionLogEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00004AC4 File Offset: 0x00002CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259584, XrefRangeEnd = 1259585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _instantiateLogs_b__51_1(KeyValuePair<int, ActionLogEntry> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c.NativeMethodInfoPtr__instantiateLogs_b__51_1_Internal_Int32_KeyValuePair_2_Int32_ActionLogEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000AB RID: 171 RVA: 0x000025CD File Offset: 0x000007CD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000AC RID: 172 RVA: 0x00004B18 File Offset: 0x00002D18
			// (set) Token: 0x060000AD RID: 173 RVA: 0x000025D6 File Offset: 0x000007D6
			public unsafe static AttributeActionLog.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeActionLog.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeActionLog.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeActionLog.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00004B40 File Offset: 0x00002D40
			// (set) Token: 0x060000AF RID: 175 RVA: 0x000025E8 File Offset: 0x000007E8
			public unsafe static Func<KeyValuePair<int, ActionLogEntry>, int> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeActionLog.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ActionLogEntry>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeActionLog.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004B68 File Offset: 0x00002D68
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x000025FA File Offset: 0x000007FA
			public unsafe static Func<KeyValuePair<int, ActionLogEntry>, int> __9__51_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeActionLog.__c.NativeFieldInfoPtr___9__51_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ActionLogEntry>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeActionLog.__c.NativeFieldInfoPtr___9__51_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006A RID: 106
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeFieldInfoPtr___9__51_1;

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeMethodInfoPtr__instantiateLogs_b__51_0_Internal_Int32_KeyValuePair_2_Int32_ActionLogEntry_0;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeMethodInfoPtr__instantiateLogs_b__51_1_Internal_Int32_KeyValuePair_2_Int32_ActionLogEntry_0;
		}

		// Token: 0x0200000E RID: 14
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060000B2 RID: 178 RVA: 0x00004B90 File Offset: 0x00002D90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass48_0>.NativeClassPtr);
				AttributeActionLog.__c__DisplayClass48_0.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass48_0>.NativeClassPtr, "log");
				AttributeActionLog.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass48_0>.NativeClassPtr, 100663356);
				AttributeActionLog.__c__DisplayClass48_0.NativeMethodInfoPtr__AddLog_b__0_Internal_Boolean_ActionLogEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass48_0>.NativeClassPtr, 100663357);
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00004BF8 File Offset: 0x00002DF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x00004C34 File Offset: 0x00002E34
			[CallerCount(0)]
			public unsafe bool _AddLog_b__0(ActionLogEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass48_0.NativeMethodInfoPtr__AddLog_b__0_Internal_Boolean_ActionLogEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x0000260C File Offset: 0x0000080C
			public __c__DisplayClass48_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004C84 File Offset: 0x00002E84
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002615 File Offset: 0x00000815
			public unsafe SerializedGameLog log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass48_0.NativeFieldInfoPtr_log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass48_0.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeMethodInfoPtr__AddLog_b__0_Internal_Boolean_ActionLogEntry_0;
		}

		// Token: 0x0200000F RID: 15
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060000B8 RID: 184 RVA: 0x00004CB4 File Offset: 0x00002EB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass52_0>.NativeClassPtr);
				AttributeActionLog.__c__DisplayClass52_0.NativeFieldInfoPtr_sub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass52_0>.NativeClassPtr, "sub");
				AttributeActionLog.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass52_0>.NativeClassPtr, 100663358);
				AttributeActionLog.__c__DisplayClass52_0.NativeMethodInfoPtr__instantiateEntry_b__0_Internal_Boolean_ActionLogEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass52_0>.NativeClassPtr, 100663359);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00004D1C File Offset: 0x00002F1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00004D58 File Offset: 0x00002F58
			[CallerCount(0)]
			public unsafe bool _instantiateEntry_b__0(ActionLogEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass52_0.NativeMethodInfoPtr__instantiateEntry_b__0_Internal_Boolean_ActionLogEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00002634 File Offset: 0x00000834
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00004DA8 File Offset: 0x00002FA8
			// (set) Token: 0x060000BD RID: 189 RVA: 0x0000263D File Offset: 0x0000083D
			public unsafe SerializedGameLog sub
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass52_0.NativeFieldInfoPtr_sub);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass52_0.NativeFieldInfoPtr_sub), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeFieldInfoPtr_sub;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeMethodInfoPtr__instantiateEntry_b__0_Internal_Boolean_ActionLogEntry_0;
		}

		// Token: 0x02000010 RID: 16
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060000BE RID: 190 RVA: 0x00004DD8 File Offset: 0x00002FD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass54_0>.NativeClassPtr);
				AttributeActionLog.__c__DisplayClass54_0.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass54_0>.NativeClassPtr, "log");
				AttributeActionLog.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass54_0>.NativeClassPtr, 100663360);
				AttributeActionLog.__c__DisplayClass54_0.NativeMethodInfoPtr__ReplaceExistingLog_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass54_0>.NativeClassPtr, 100663361);
			}

			// Token: 0x060000BF RID: 191 RVA: 0x00004E40 File Offset: 0x00003040
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00004E7C File Offset: 0x0000307C
			[CallerCount(0)]
			public unsafe bool _ReplaceExistingLog_b__0(SerializedGameLog l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass54_0.NativeMethodInfoPtr__ReplaceExistingLog_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x0000265C File Offset: 0x0000085C
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004ECC File Offset: 0x000030CC
			// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002665 File Offset: 0x00000865
			public unsafe SerializedGameLog log
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass54_0.NativeFieldInfoPtr_log);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass54_0.NativeFieldInfoPtr_log), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeFieldInfoPtr_log;

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeMethodInfoPtr__ReplaceExistingLog_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x02000011 RID: 17
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060000C4 RID: 196 RVA: 0x00004EFC File Offset: 0x000030FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass62_0>.NativeClassPtr);
				AttributeActionLog.__c__DisplayClass62_0.NativeFieldInfoPtr_logId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass62_0>.NativeClassPtr, "logId");
				AttributeActionLog.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass62_0>.NativeClassPtr, 100663362);
				AttributeActionLog.__c__DisplayClass62_0.NativeMethodInfoPtr__FindDisplayLogIndex_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass62_0>.NativeClassPtr, 100663363);
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x00004F64 File Offset: 0x00003164
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00004FA0 File Offset: 0x000031A0
			[CallerCount(0)]
			public unsafe bool _FindDisplayLogIndex_b__0(SerializedGameLog l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog.__c__DisplayClass62_0.NativeMethodInfoPtr__FindDisplayLogIndex_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x00002684 File Offset: 0x00000884
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004FF0 File Offset: 0x000031F0
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000268D File Offset: 0x0000088D
			public unsafe int logId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass62_0.NativeFieldInfoPtr_logId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog.__c__DisplayClass62_0.NativeFieldInfoPtr_logId)) = value;
				}
			}

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeFieldInfoPtr_logId;

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeMethodInfoPtr__FindDisplayLogIndex_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x02000012 RID: 18
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<Start>d__41")]
		public sealed class _Start_d__41 : global::Il2CppSystem.Object
		{
			// Token: 0x060000CA RID: 202 RVA: 0x00005018 File Offset: 0x00003218
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__41()
			{
				Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<Start>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr);
				AttributeActionLog._Start_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, "<>1__state");
				AttributeActionLog._Start_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, "<>2__current");
				AttributeActionLog._Start_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, "<>4__this");
				AttributeActionLog._Start_d__41.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, "<entitiesProvider>5__2");
				AttributeActionLog._Start_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, 100663364);
				AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, 100663365);
				AttributeActionLog._Start_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, 100663366);
				AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, 100663367);
				AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, 100663368);
				AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr, 100663369);
			}

			// Token: 0x060000CB RID: 203 RVA: 0x0000510C File Offset: 0x0000330C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog._Start_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._Start_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000CC RID: 204 RVA: 0x00005154 File Offset: 0x00003354
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x00005188 File Offset: 0x00003388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259585, XrefRangeEnd = 1259598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._Start_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000CE RID: 206 RVA: 0x000051C4 File Offset: 0x000033C4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00005204 File Offset: 0x00003404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259598, XrefRangeEnd = 1259603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005238 File Offset: 0x00003438
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._Start_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x000026A8 File Offset: 0x000008A8
			public _Start_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005278 File Offset: 0x00003478
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x000026B1 File Offset: 0x000008B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x000052A0 File Offset: 0x000034A0
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x000026CC File Offset: 0x000008CC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x000052D0 File Offset: 0x000034D0
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x000026EB File Offset: 0x000008EB
			public unsafe AttributeActionLog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeActionLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005300 File Offset: 0x00003500
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000270A File Offset: 0x0000090A
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._Start_d__41.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400007E RID: 126
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000082 RID: 130
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000083 RID: 131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000084 RID: 132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000085 RID: 133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000013 RID: 19
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<loadLogsBackwardAfterOneFrame>d__59")]
		public sealed class _loadLogsBackwardAfterOneFrame_d__59 : global::Il2CppSystem.Object
		{
			// Token: 0x060000DA RID: 218 RVA: 0x00005330 File Offset: 0x00003530
			// Note: this type is marked as 'beforefieldinit'.
			static _loadLogsBackwardAfterOneFrame_d__59()
			{
				Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<loadLogsBackwardAfterOneFrame>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr);
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, "<>1__state");
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, "<>2__current");
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, "<>4__this");
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr__previousScrollbarValue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, "<previousScrollbarValue>5__2");
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, 100663370);
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, 100663371);
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, 100663372);
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, 100663373);
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, 100663374);
				AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr, 100663375);
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00005424 File Offset: 0x00003624
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadLogsBackwardAfterOneFrame_d__59(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000DC RID: 220 RVA: 0x0000546C File Offset: 0x0000366C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DD RID: 221 RVA: 0x000054A0 File Offset: 0x000036A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259603, XrefRangeEnd = 1259606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000DE RID: 222 RVA: 0x000054DC File Offset: 0x000036DC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000DF RID: 223 RVA: 0x0000551C File Offset: 0x0000371C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259606, XrefRangeEnd = 1259611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005550 File Offset: 0x00003750
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00002729 File Offset: 0x00000929
			public _loadLogsBackwardAfterOneFrame_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005590 File Offset: 0x00003790
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002732 File Offset: 0x00000932
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x000055B8 File Offset: 0x000037B8
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000274D File Offset: 0x0000094D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x000055E8 File Offset: 0x000037E8
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000276C File Offset: 0x0000096C
			public unsafe AttributeActionLog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeActionLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005618 File Offset: 0x00003818
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000278B File Offset: 0x0000098B
			public unsafe float _previousScrollbarValue_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr__previousScrollbarValue_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsBackwardAfterOneFrame_d__59.NativeFieldInfoPtr__previousScrollbarValue_5__2)) = value;
				}
			}

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeFieldInfoPtr__previousScrollbarValue_5__2;

			// Token: 0x0400008A RID: 138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400008B RID: 139
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000014 RID: 20
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<loadLogsForwardAfterOneFrame>d__60")]
		public sealed class _loadLogsForwardAfterOneFrame_d__60 : global::Il2CppSystem.Object
		{
			// Token: 0x060000EA RID: 234 RVA: 0x00005640 File Offset: 0x00003840
			// Note: this type is marked as 'beforefieldinit'.
			static _loadLogsForwardAfterOneFrame_d__60()
			{
				Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<loadLogsForwardAfterOneFrame>d__60");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr);
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, "<>1__state");
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, "<>2__current");
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, "<>4__this");
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr__previousScrollbarValue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, "<previousScrollbarValue>5__2");
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, 100663376);
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, 100663377);
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, 100663378);
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, 100663379);
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, 100663380);
				AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr, 100663381);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00005734 File Offset: 0x00003934
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _loadLogsForwardAfterOneFrame_d__60(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog._loadLogsForwardAfterOneFrame_d__60>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000EC RID: 236 RVA: 0x0000577C File Offset: 0x0000397C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000ED RID: 237 RVA: 0x000057B0 File Offset: 0x000039B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259611, XrefRangeEnd = 1259614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000EE RID: 238 RVA: 0x000057EC File Offset: 0x000039EC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000EF RID: 239 RVA: 0x0000582C File Offset: 0x00003A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259614, XrefRangeEnd = 1259619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005860 File Offset: 0x00003A60
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x000027A6 File Offset: 0x000009A6
			public _loadLogsForwardAfterOneFrame_d__60(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x000058A0 File Offset: 0x00003AA0
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x000027AF File Offset: 0x000009AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x000058C8 File Offset: 0x00003AC8
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x000027CA File Offset: 0x000009CA
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x000058F8 File Offset: 0x00003AF8
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x000027E9 File Offset: 0x000009E9
			public unsafe AttributeActionLog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeActionLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005928 File Offset: 0x00003B28
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002808 File Offset: 0x00000A08
			public unsafe float _previousScrollbarValue_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr__previousScrollbarValue_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._loadLogsForwardAfterOneFrame_d__60.NativeFieldInfoPtr__previousScrollbarValue_5__2)) = value;
				}
			}

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000093 RID: 147
			private static readonly IntPtr NativeFieldInfoPtr__previousScrollbarValue_5__2;

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000015 RID: 21
		[ObfuscatedName("coreactionlog.actionlog.AttributeActionLog+<scrollToBottomInOneFrame>d__58")]
		public sealed class _scrollToBottomInOneFrame_d__58 : global::Il2CppSystem.Object
		{
			// Token: 0x060000FA RID: 250 RVA: 0x00005950 File Offset: 0x00003B50
			// Note: this type is marked as 'beforefieldinit'.
			static _scrollToBottomInOneFrame_d__58()
			{
				Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeActionLog>.NativeClassPtr, "<scrollToBottomInOneFrame>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr);
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, "<>1__state");
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, "<>2__current");
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, "<>4__this");
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, 100663382);
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, 100663383);
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, 100663384);
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, 100663385);
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, 100663386);
				AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr, 100663387);
			}

			// Token: 0x060000FB RID: 251 RVA: 0x00005A30 File Offset: 0x00003C30
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _scrollToBottomInOneFrame_d__58(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeActionLog._scrollToBottomInOneFrame_d__58>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00005A78 File Offset: 0x00003C78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00005AAC File Offset: 0x00003CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259619, XrefRangeEnd = 1259643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060000FE RID: 254 RVA: 0x00005AE8 File Offset: 0x00003CE8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00005B28 File Offset: 0x00003D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259643, XrefRangeEnd = 1259648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000100 RID: 256 RVA: 0x00005B5C File Offset: 0x00003D5C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00002823 File Offset: 0x00000A23
			public _scrollToBottomInOneFrame_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000102 RID: 258 RVA: 0x00005B9C File Offset: 0x00003D9C
			// (set) Token: 0x06000103 RID: 259 RVA: 0x0000282C File Offset: 0x00000A2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000104 RID: 260 RVA: 0x00005BC4 File Offset: 0x00003DC4
			// (set) Token: 0x06000105 RID: 261 RVA: 0x00002847 File Offset: 0x00000A47
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000106 RID: 262 RVA: 0x00005BF4 File Offset: 0x00003DF4
			// (set) Token: 0x06000107 RID: 263 RVA: 0x00002866 File Offset: 0x00000A66
			public unsafe AttributeActionLog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeActionLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeActionLog._scrollToBottomInOneFrame_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
