using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dbgclient.matchHistory
{
	// Token: 0x0200002B RID: 43
	public class OfflineMessageManager : MonoBehaviour
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00015340 File Offset: 0x00013540
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMessageManager()
		{
			Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dbgclient.matchHistory", "OfflineMessageManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr);
			OfflineMessageManager.NativeFieldInfoPtr__offlineMessagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, "_offlineMessagePath");
			OfflineMessageManager.NativeFieldInfoPtr__sendMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, "_sendMessage");
			OfflineMessageManager.NativeFieldInfoPtr__pendingMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, "_pendingMessages");
			OfflineMessageManager.NativeFieldInfoPtr__readyToLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, "_readyToLog");
			OfflineMessageManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663570);
			OfflineMessageManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663571);
			OfflineMessageManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663572);
			OfflineMessageManager.NativeMethodInfoPtr_Enabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663573);
			OfflineMessageManager.NativeMethodInfoPtr_LogOfflineMessage_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663574);
			OfflineMessageManager.NativeMethodInfoPtr_LogOfflineMessage_Public_Void_String_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663575);
			OfflineMessageManager.NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Virtual_Final_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663576);
			OfflineMessageManager.NativeMethodInfoPtr_SendOfflineMessage_Private_IEnumerator_OfflineMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663577);
			OfflineMessageManager.NativeMethodInfoPtr_SaveMessagesToFile_Private_Void_List_1_OfflineMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663578);
			OfflineMessageManager.NativeMethodInfoPtr_AppendOfflineMessagesToPending_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663579);
			OfflineMessageManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, 100663580);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001549C File Offset: 0x0001369C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983803, XrefRangeEnd = 983816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000154D0 File Offset: 0x000136D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983816, XrefRangeEnd = 983834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00015504 File Offset: 0x00013704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983834, XrefRangeEnd = 983847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00015538 File Offset: 0x00013738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 983854, RefRangeEnd = 983856, XrefRangeStart = 983847, XrefRangeEnd = 983854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_Enabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00015574 File Offset: 0x00013774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983856, XrefRangeEnd = 983861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOfflineMessage(string url, bool useToken, string serializedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useToken;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(serializedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_LogOfflineMessage_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000155D8 File Offset: 0x000137D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983861, XrefRangeEnd = 983870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOfflineMessage(string url, bool useToken, global::Il2CppSystem.Object uploadObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useToken;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uploadObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_LogOfflineMessage_Public_Void_String_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001563C File Offset: 0x0001383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983870, XrefRangeEnd = 983901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command HandleBlockingApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Virtual_Final_New_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001567C File Offset: 0x0001387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983901, XrefRangeEnd = 983907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SendOfflineMessage(OfflineMessage offlineMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(offlineMessage));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_SendOfflineMessage_Private_IEnumerator_OfflineMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000156D4 File Offset: 0x000138D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983907, XrefRangeEnd = 983913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveMessagesToFile(List<OfflineMessage> unsentMessages)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unsentMessages);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_SaveMessagesToFile_Private_Void_List_1_OfflineMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00015718 File Offset: 0x00013918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 983945, RefRangeEnd = 983946, XrefRangeStart = 983913, XrefRangeEnd = 983945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendOfflineMessagesToPending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr_AppendOfflineMessagesToPending_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001574C File Offset: 0x0001394C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMessageManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002B49 File Offset: 0x00000D49
		public OfflineMessageManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00015788 File Offset: 0x00013988
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002B52 File Offset: 0x00000D52
		public unsafe string _offlineMessagePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__offlineMessagePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__offlineMessagePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000157B0 File Offset: 0x000139B0
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002B71 File Offset: 0x00000D71
		public unsafe IEnumerator _sendMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__sendMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__sendMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000157E0 File Offset: 0x000139E0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002B90 File Offset: 0x00000D90
		public unsafe ConcurrentQueue<OfflineMessage> _pendingMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__pendingMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<OfflineMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__pendingMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00015810 File Offset: 0x00013A10
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002BAF File Offset: 0x00000DAF
		public unsafe bool _readyToLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__readyToLog);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager.NativeFieldInfoPtr__readyToLog)) = value;
			}
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr__offlineMessagePath;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__sendMessage;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr__pendingMessages;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr__readyToLog;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Private_Boolean_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_LogOfflineMessage_Public_Void_String_Boolean_String_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_LogOfflineMessage_Public_Void_String_Boolean_Object_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_HandleBlockingApplicationQuit_Public_Virtual_Final_New_Command_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_SendOfflineMessage_Private_IEnumerator_OfflineMessage_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_SaveMessagesToFile_Private_Void_List_1_OfflineMessage_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_AppendOfflineMessagesToPending_Private_Void_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001A2 RID: 418
		[ObfuscatedName("dbgclient.matchHistory.OfflineMessageManager+<SendOfflineMessage>d__11")]
		public sealed class _SendOfflineMessage_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x0600147B RID: 5243 RVA: 0x00050358 File Offset: 0x0004E558
			// Note: this type is marked as 'beforefieldinit'.
			static _SendOfflineMessage_d__11()
			{
				Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfflineMessageManager>.NativeClassPtr, "<SendOfflineMessage>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr);
				OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, "<>1__state");
				OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, "<>2__current");
				OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr_offlineMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, "offlineMessage");
				OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, "<>4__this");
				OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, 100663581);
				OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, 100663582);
				OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, 100663583);
				OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, 100663584);
				OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, 100663585);
				OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr, 100663586);
			}

			// Token: 0x0600147C RID: 5244 RVA: 0x0005044C File Offset: 0x0004E64C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendOfflineMessage_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMessageManager._SendOfflineMessage_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147D RID: 5245 RVA: 0x00050494 File Offset: 0x0004E694
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600147E RID: 5246 RVA: 0x000504C8 File Offset: 0x0004E6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983766, XrefRangeEnd = 983798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x0600147F RID: 5247 RVA: 0x00050504 File Offset: 0x0004E704
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001480 RID: 5248 RVA: 0x00050544 File Offset: 0x0004E744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983798, XrefRangeEnd = 983803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x06001481 RID: 5249 RVA: 0x00050578 File Offset: 0x0004E778
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessageManager._SendOfflineMessage_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001482 RID: 5250 RVA: 0x0000B993 File Offset: 0x00009B93
			public _SendOfflineMessage_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x06001483 RID: 5251 RVA: 0x000505B8 File Offset: 0x0004E7B8
			// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000B99C File Offset: 0x00009B9C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x06001485 RID: 5253 RVA: 0x000505E0 File Offset: 0x0004E7E0
			// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000B9B7 File Offset: 0x00009BB7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x06001487 RID: 5255 RVA: 0x00050610 File Offset: 0x0004E810
			// (set) Token: 0x06001488 RID: 5256 RVA: 0x0000B9D6 File Offset: 0x00009BD6
			public OfflineMessage offlineMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr_offlineMessage);
					return new OfflineMessage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr_offlineMessage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x06001489 RID: 5257 RVA: 0x00050640 File Offset: 0x0004E840
			// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000BA04 File Offset: 0x00009C04
			public unsafe OfflineMessageManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineMessageManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessageManager._SendOfflineMessage_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C6D RID: 3181
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C6E RID: 3182
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C6F RID: 3183
			private static readonly IntPtr NativeFieldInfoPtr_offlineMessage;

			// Token: 0x04000C70 RID: 3184
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C71 RID: 3185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C72 RID: 3186
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C73 RID: 3187
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C74 RID: 3188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C75 RID: 3189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C76 RID: 3190
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
