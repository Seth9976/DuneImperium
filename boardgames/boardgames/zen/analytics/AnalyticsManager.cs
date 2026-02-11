using System;
using analytics;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace zen.analytics
{
	// Token: 0x0200008C RID: 140
	public class AnalyticsManager : MonoBehaviour
	{
		// Token: 0x060006E4 RID: 1764 RVA: 0x00026878 File Offset: 0x00024A78
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsManager()
		{
			Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics", "AnalyticsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr);
			AnalyticsManager.NativeFieldInfoPtr_MAX_OFFLINE_MESSAGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "MAX_OFFLINE_MESSAGES");
			AnalyticsManager.NativeFieldInfoPtr_readyToLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "readyToLog");
			AnalyticsManager.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "logging");
			AnalyticsManager.NativeFieldInfoPtr_analyticsToBundleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "analyticsToBundleCount");
			AnalyticsManager.NativeFieldInfoPtr_pendingAnalyticsMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "pendingAnalyticsMessages");
			AnalyticsManager.NativeFieldInfoPtr_activeWebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "activeWebRequest");
			AnalyticsManager.NativeFieldInfoPtr_previouslyOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "previouslyOnline");
			AnalyticsManager.NativeFieldInfoPtr__sessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "_sessionID");
			AnalyticsManager.NativeMethodInfoPtr_LogMemoryWarningMessage_Private_Static_Void_MemoryCleanupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664411);
			AnalyticsManager.NativeMethodInfoPtr_LogAnalyticsMessage_Public_Static_Void_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664412);
			AnalyticsManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664413);
			AnalyticsManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664414);
			AnalyticsManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664415);
			AnalyticsManager.NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Virtual_Final_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664416);
			AnalyticsManager.NativeMethodInfoPtr_OnApplicationFocus_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664417);
			AnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664418);
			AnalyticsManager.NativeMethodInfoPtr_buildUnityWebRequest_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664419);
			AnalyticsManager.NativeMethodInfoPtr_appendOfflineMessagesToPending_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664420);
			AnalyticsManager.NativeMethodInfoPtr_saveMessagesToFile_Private_Void_List_1_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664421);
			AnalyticsManager.NativeMethodInfoPtr_handleMsg_Private_UnityWebRequest_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664422);
			AnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664423);
			AnalyticsManager.NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664424);
			AnalyticsManager.NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664425);
			AnalyticsManager.NativeMethodInfoPtr_makeSessionID_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664426);
			AnalyticsManager.NativeMethodInfoPtr_get_SessionID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664427);
			AnalyticsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, 100664428);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00026AB0 File Offset: 0x00024CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989478, XrefRangeEnd = 989494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogMemoryWarningMessage(MemoryWatchdog.MemoryCleanupEvent evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_LogMemoryWarningMessage_Private_Static_Void_MemoryCleanupEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00026AE4 File Offset: 0x00024CE4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 989501, RefRangeEnd = 989513, XrefRangeStart = 989494, XrefRangeEnd = 989501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAnalyticsMessage(IAnalyticsMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_LogAnalyticsMessage_Public_Static_Void_IAnalyticsMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00026B1C File Offset: 0x00024D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989513, XrefRangeEnd = 989535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00026B50 File Offset: 0x00024D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989535, XrefRangeEnd = 989547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00026B84 File Offset: 0x00024D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989547, XrefRangeEnd = 989562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00026BB8 File Offset: 0x00024DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989562, XrefRangeEnd = 989598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command HandleBlockingApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Virtual_Final_New_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989598, XrefRangeEnd = 989602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_OnApplicationFocus_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00026C44 File Offset: 0x00024E44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 989606, RefRangeEnd = 989611, XrefRangeStart = 989602, XrefRangeEnd = 989606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void logAnalyticsMessage(IAnalyticsMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00026C88 File Offset: 0x00024E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989611, XrefRangeEnd = 989616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator buildUnityWebRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_buildUnityWebRequest_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00026CC8 File Offset: 0x00024EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989654, RefRangeEnd = 989655, XrefRangeStart = 989616, XrefRangeEnd = 989654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void appendOfflineMessagesToPending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_appendOfflineMessagesToPending_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00026CFC File Offset: 0x00024EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 989691, RefRangeEnd = 989693, XrefRangeStart = 989655, XrefRangeEnd = 989691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void saveMessagesToFile(List<IAnalyticsMessage> unsentMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unsentMessages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_saveMessagesToFile_Private_Void_List_1_IAnalyticsMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00026D40 File Offset: 0x00024F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989709, RefRangeEnd = 989710, XrefRangeStart = 989693, XrefRangeEnd = 989709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityWebRequest handleMsg(IAnalyticsMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_handleMsg_Private_UnityWebRequest_IAnalyticsMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00026D90 File Offset: 0x00024F90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 989717, RefRangeEnd = 989723, XrefRangeStart = 989710, XrefRangeEnd = 989717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00026DCC File Offset: 0x00024FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989723, XrefRangeEnd = 989730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string URL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00026E04 File Offset: 0x00025004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989730, XrefRangeEnd = 989737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string game()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00026E3C File Offset: 0x0002503C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989737, XrefRangeEnd = 989740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string makeSessionID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_makeSessionID_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00026E74 File Offset: 0x00025074
		public unsafe string SessionID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989740, XrefRangeEnd = 989743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr_get_SessionID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00026EAC File Offset: 0x000250AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989743, XrefRangeEnd = 989744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00005161 File Offset: 0x00003361
		public AnalyticsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00026EE8 File Offset: 0x000250E8
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0000516A File Offset: 0x0000336A
		public unsafe static int MAX_OFFLINE_MESSAGES
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AnalyticsManager.NativeFieldInfoPtr_MAX_OFFLINE_MESSAGES, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnalyticsManager.NativeFieldInfoPtr_MAX_OFFLINE_MESSAGES, (void*)(&value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00026F04 File Offset: 0x00025104
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x00005178 File Offset: 0x00003378
		public unsafe bool readyToLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_readyToLog);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_readyToLog)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00026F2C File Offset: 0x0002512C
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00005193 File Offset: 0x00003393
		public unsafe bool logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_logging)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00026F54 File Offset: 0x00025154
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x000051AE File Offset: 0x000033AE
		public unsafe int analyticsToBundleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_analyticsToBundleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_analyticsToBundleCount)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00026F7C File Offset: 0x0002517C
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x000051C9 File Offset: 0x000033C9
		public unsafe ConcurrentQueue<IAnalyticsMessage> pendingAnalyticsMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_pendingAnalyticsMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<IAnalyticsMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_pendingAnalyticsMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00026FAC File Offset: 0x000251AC
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000051E8 File Offset: 0x000033E8
		public unsafe Coroutine activeWebRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_activeWebRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_activeWebRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00026FDC File Offset: 0x000251DC
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00005207 File Offset: 0x00003407
		public unsafe bool previouslyOnline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_previouslyOnline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr_previouslyOnline)) = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00027004 File Offset: 0x00025204
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00005222 File Offset: 0x00003422
		public unsafe string _sessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr__sessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager.NativeFieldInfoPtr__sessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_MAX_OFFLINE_MESSAGES;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_readyToLog;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_logging;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_analyticsToBundleCount;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_pendingAnalyticsMessages;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_activeWebRequest;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_previouslyOnline;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr__sessionID;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_LogMemoryWarningMessage_Private_Static_Void_MemoryCleanupEvent_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_LogAnalyticsMessage_Public_Static_Void_IAnalyticsMessage_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Virtual_Final_New_Command_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_IEnumerator_Boolean_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsMessage_Public_Virtual_Final_New_Void_IAnalyticsMessage_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_buildUnityWebRequest_Private_IEnumerator_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_appendOfflineMessagesToPending_Private_Void_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_saveMessagesToFile_Private_Void_List_1_IAnalyticsMessage_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_handleMsg_Private_UnityWebRequest_IAnalyticsMessage_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_URL_Public_Virtual_Final_New_String_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_game_Public_Virtual_Final_New_String_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_makeSessionID_Private_String_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionID_Public_get_String_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200020F RID: 527
		[ObfuscatedName("zen.analytics.AnalyticsManager+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x0600182D RID: 6189 RVA: 0x0000D3B2 File Offset: 0x0000B5B2
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<AnalyticsManager.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsManager.__O>.NativeClassPtr);
				AnalyticsManager.__O.NativeFieldInfoPtr__0___LogMemoryWarningMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager.__O>.NativeClassPtr, "<0>__LogMemoryWarningMessage");
			}

			// Token: 0x0600182E RID: 6190 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x0600182F RID: 6191 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
			// (set) Token: 0x06001830 RID: 6192 RVA: 0x0000D3EF File Offset: 0x0000B5EF
			public unsafe static Action<MemoryWatchdog.MemoryCleanupEvent> _0___LogMemoryWarningMessage
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnalyticsManager.__O.NativeFieldInfoPtr__0___LogMemoryWarningMessage, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MemoryWatchdog.MemoryCleanupEvent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnalyticsManager.__O.NativeFieldInfoPtr__0___LogMemoryWarningMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EA8 RID: 3752
			private static readonly IntPtr NativeFieldInfoPtr__0___LogMemoryWarningMessage;
		}

		// Token: 0x02000210 RID: 528
		[ObfuscatedName("zen.analytics.AnalyticsManager+<OnApplicationFocus>d__13")]
		public sealed class _OnApplicationFocus_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x06001831 RID: 6193 RVA: 0x0005C1D8 File Offset: 0x0005A3D8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnApplicationFocus_d__13()
			{
				Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "<OnApplicationFocus>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr);
				AnalyticsManager._OnApplicationFocus_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, "<>1__state");
				AnalyticsManager._OnApplicationFocus_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, "<>2__current");
				AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, 100664430);
				AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, 100664431);
				AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, 100664432);
				AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, 100664433);
				AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, 100664434);
				AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr, 100664435);
			}

			// Token: 0x06001832 RID: 6194 RVA: 0x0005C2A4 File Offset: 0x0005A4A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnApplicationFocus_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsManager._OnApplicationFocus_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001833 RID: 6195 RVA: 0x0005C2EC File Offset: 0x0005A4EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001834 RID: 6196 RVA: 0x0005C320 File Offset: 0x0005A520
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06001835 RID: 6197 RVA: 0x0005C35C File Offset: 0x0005A55C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001836 RID: 6198 RVA: 0x0005C39C File Offset: 0x0005A59C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989381, XrefRangeEnd = 989386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06001837 RID: 6199 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._OnApplicationFocus_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001838 RID: 6200 RVA: 0x0000D401 File Offset: 0x0000B601
			public _OnApplicationFocus_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06001839 RID: 6201 RVA: 0x0005C410 File Offset: 0x0005A610
			// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000D40A File Offset: 0x0000B60A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._OnApplicationFocus_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._OnApplicationFocus_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x0600183B RID: 6203 RVA: 0x0005C438 File Offset: 0x0005A638
			// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000D425 File Offset: 0x0000B625
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._OnApplicationFocus_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._OnApplicationFocus_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EA9 RID: 3753
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EAA RID: 3754
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EAB RID: 3755
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EAC RID: 3756
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EAD RID: 3757
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EAE RID: 3758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EAF RID: 3759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EB0 RID: 3760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000211 RID: 529
		[ObfuscatedName("zen.analytics.AnalyticsManager+<buildUnityWebRequest>d__15")]
		public sealed class _buildUnityWebRequest_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x0600183D RID: 6205 RVA: 0x0005C468 File Offset: 0x0005A668
			// Note: this type is marked as 'beforefieldinit'.
			static _buildUnityWebRequest_d__15()
			{
				Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsManager>.NativeClassPtr, "<buildUnityWebRequest>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr);
				AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, "<>1__state");
				AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, "<>2__current");
				AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, "<>4__this");
				AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__unsentMessages_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, "<unsentMessages>5__2");
				AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__msg_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, "<msg>5__3");
				AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__www_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, "<www>5__4");
				AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, 100664436);
				AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, 100664437);
				AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, 100664438);
				AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, 100664439);
				AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, 100664440);
				AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr, 100664441);
			}

			// Token: 0x0600183E RID: 6206 RVA: 0x0005C584 File Offset: 0x0005A784
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _buildUnityWebRequest_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsManager._buildUnityWebRequest_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600183F RID: 6207 RVA: 0x0005C5CC File Offset: 0x0005A7CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001840 RID: 6208 RVA: 0x0005C600 File Offset: 0x0005A800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989386, XrefRangeEnd = 989473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06001841 RID: 6209 RVA: 0x0005C63C File Offset: 0x0005A83C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001842 RID: 6210 RVA: 0x0005C67C File Offset: 0x0005A87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989473, XrefRangeEnd = 989478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06001843 RID: 6211 RVA: 0x0005C6B0 File Offset: 0x0005A8B0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsManager._buildUnityWebRequest_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001844 RID: 6212 RVA: 0x0000D444 File Offset: 0x0000B644
			public _buildUnityWebRequest_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06001845 RID: 6213 RVA: 0x0005C6F0 File Offset: 0x0005A8F0
			// (set) Token: 0x06001846 RID: 6214 RVA: 0x0000D44D File Offset: 0x0000B64D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x06001847 RID: 6215 RVA: 0x0005C718 File Offset: 0x0005A918
			// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000D468 File Offset: 0x0000B668
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x06001849 RID: 6217 RVA: 0x0005C748 File Offset: 0x0005A948
			// (set) Token: 0x0600184A RID: 6218 RVA: 0x0000D487 File Offset: 0x0000B687
			public unsafe AnalyticsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x0600184B RID: 6219 RVA: 0x0005C778 File Offset: 0x0005A978
			// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000D4A6 File Offset: 0x0000B6A6
			public unsafe List<IAnalyticsMessage> _unsentMessages_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__unsentMessages_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAnalyticsMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__unsentMessages_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x0600184D RID: 6221 RVA: 0x0005C7A8 File Offset: 0x0005A9A8
			// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000D4C5 File Offset: 0x0000B6C5
			public unsafe IAnalyticsMessage _msg_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__msg_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAnalyticsMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__msg_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x0600184F RID: 6223 RVA: 0x0005C7D8 File Offset: 0x0005A9D8
			// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
			public unsafe UnityWebRequest _www_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__www_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsManager._buildUnityWebRequest_d__15.NativeFieldInfoPtr__www_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EB1 RID: 3761
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EB2 RID: 3762
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EB3 RID: 3763
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000EB4 RID: 3764
			private static readonly IntPtr NativeFieldInfoPtr__unsentMessages_5__2;

			// Token: 0x04000EB5 RID: 3765
			private static readonly IntPtr NativeFieldInfoPtr__msg_5__3;

			// Token: 0x04000EB6 RID: 3766
			private static readonly IntPtr NativeFieldInfoPtr__www_5__4;

			// Token: 0x04000EB7 RID: 3767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EB8 RID: 3768
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EB9 RID: 3769
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EBA RID: 3770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EBB RID: 3771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EBC RID: 3772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
