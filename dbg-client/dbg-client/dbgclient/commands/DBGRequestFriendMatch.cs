using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.game;
using UnityEngine.Networking;

namespace dbgclient.commands
{
	// Token: 0x020000DB RID: 219
	public class DBGRequestFriendMatch : Command
	{
		// Token: 0x06000947 RID: 2375 RVA: 0x0003ACD4 File Offset: 0x00038ED4
		// Note: this type is marked as 'beforefieldinit'.
		static DBGRequestFriendMatch()
		{
			Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.commands", "DBGRequestFriendMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr);
			DBGRequestFriendMatch.NativeFieldInfoPtr_againstAccounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "againstAccounts");
			DBGRequestFriendMatch.NativeFieldInfoPtr_accountNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "accountNames");
			DBGRequestFriendMatch.NativeFieldInfoPtr_aiCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "aiCount");
			DBGRequestFriendMatch.NativeFieldInfoPtr_aiLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "aiLevel");
			DBGRequestFriendMatch.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "client");
			DBGRequestFriendMatch.NativeFieldInfoPtr_gameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "gameOptions");
			DBGRequestFriendMatch.NativeFieldInfoPtr__GameSession_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "<GameSession>k__BackingField");
			DBGRequestFriendMatch.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "error");
			DBGRequestFriendMatch.NativeMethodInfoPtr_get_GameSession_Public_get_DWDGameSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664641);
			DBGRequestFriendMatch.NativeMethodInfoPtr_set_GameSession_Private_set_Void_DWDGameSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664642);
			DBGRequestFriendMatch.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664643);
			DBGRequestFriendMatch.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_List_1_String_Int32_Int32_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664644);
			DBGRequestFriendMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664645);
			DBGRequestFriendMatch.NativeMethodInfoPtr__execute_b__13_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664646);
			DBGRequestFriendMatch.NativeMethodInfoPtr__execute_b__13_2_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, 100664647);
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0003AE30 File Offset: 0x00039030
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0003AE70 File Offset: 0x00039070
		public unsafe DWDGameSession GameSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.NativeMethodInfoPtr_get_GameSession_Public_get_DWDGameSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.NativeMethodInfoPtr_set_GameSession_Private_set_Void_DWDGameSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0003AEB4 File Offset: 0x000390B4
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0003AEEC File Offset: 0x000390EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505644, XrefRangeEnd = 505654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGRequestFriendMatch(Il2CppReferenceArray<AccountID> againstAccounts, List<string> accountNames, int aiCount, int aiLevel, string client, Dictionary<string, string> gameOptions = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(againstAccounts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_List_1_String_Int32_Int32_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0003AF8C File Offset: 0x0003918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505654, XrefRangeEnd = 505659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGRequestFriendMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0003AFD8 File Offset: 0x000391D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505659, XrefRangeEnd = 505685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__13_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.NativeMethodInfoPtr__execute_b__13_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003B01C File Offset: 0x0003921C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505685, XrefRangeEnd = 505700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__13_2(ErrorInfo status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(status));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.NativeMethodInfoPtr__execute_b__13_2_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000065FF File Offset: 0x000047FF
		public DBGRequestFriendMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0003B064 File Offset: 0x00039264
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00006608 File Offset: 0x00004808
		public unsafe Il2CppReferenceArray<AccountID> againstAccounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_againstAccounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_againstAccounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0003B094 File Offset: 0x00039294
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00006627 File Offset: 0x00004827
		public unsafe List<string> accountNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_accountNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_accountNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0003B0C4 File Offset: 0x000392C4
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00006646 File Offset: 0x00004846
		public unsafe int aiCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_aiCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_aiCount)) = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0003B0EC File Offset: 0x000392EC
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00006661 File Offset: 0x00004861
		public unsafe int aiLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_aiLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_aiLevel)) = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0003B114 File Offset: 0x00039314
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0000667C File Offset: 0x0000487C
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0003B13C File Offset: 0x0003933C
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x0000669B File Offset: 0x0000489B
		public unsafe Dictionary<string, string> gameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_gameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_gameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0003B16C File Offset: 0x0003936C
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x000066BA File Offset: 0x000048BA
		public unsafe DWDGameSession _GameSession_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr__GameSession_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr__GameSession_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0003B19C File Offset: 0x0003939C
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x000066D9 File Offset: 0x000048D9
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_againstAccounts;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_accountNames;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_aiCount;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_aiLevel;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_gameOptions;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr__GameSession_k__BackingField;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_get_GameSession_Public_get_DWDGameSession_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_set_GameSession_Private_set_Void_DWDGameSession_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AccountID_List_1_String_Int32_Int32_String_Dictionary_2_String_String_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__13_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__13_2_Private_Void_ErrorInfo_0;

		// Token: 0x0200032B RID: 811
		[ObfuscatedName("dbgclient.commands.DBGRequestFriendMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002641 RID: 9793 RVA: 0x0009AF24 File Offset: 0x00099124
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr);
				DBGRequestFriendMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr, "<>9");
				DBGRequestFriendMatch.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr, "<>9__13_0");
				DBGRequestFriendMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr, 100664649);
				DBGRequestFriendMatch.__c.NativeMethodInfoPtr__execute_b__13_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr, 100664650);
			}

			// Token: 0x06002642 RID: 9794 RVA: 0x0009AFA0 File Offset: 0x000991A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGRequestFriendMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002643 RID: 9795 RVA: 0x0009AFDC File Offset: 0x000991DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505526, XrefRangeEnd = 505534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__13_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch.__c.NativeMethodInfoPtr__execute_b__13_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002644 RID: 9796 RVA: 0x00013D4F File Offset: 0x00011F4F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x06002645 RID: 9797 RVA: 0x0009B020 File Offset: 0x00099220
			// (set) Token: 0x06002646 RID: 9798 RVA: 0x00013D58 File Offset: 0x00011F58
			public unsafe static DBGRequestFriendMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGRequestFriendMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGRequestFriendMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGRequestFriendMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x06002647 RID: 9799 RVA: 0x0009B048 File Offset: 0x00099248
			// (set) Token: 0x06002648 RID: 9800 RVA: 0x00013D6A File Offset: 0x00011F6A
			public unsafe static Action<UnityWebRequest> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGRequestFriendMatch.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGRequestFriendMatch.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__13_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x0200032C RID: 812
		[ObfuscatedName("dbgclient.commands.DBGRequestFriendMatch+<execute>d__13")]
		public sealed class _execute_d__13 : Object
		{
			// Token: 0x06002649 RID: 9801 RVA: 0x0009B070 File Offset: 0x00099270
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__13()
			{
				Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGRequestFriendMatch>.NativeClassPtr, "<execute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr);
				DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, "<>1__state");
				DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, "<>2__current");
				DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, "<>4__this");
				DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, 100664651);
				DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, 100664652);
				DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, 100664653);
				DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, 100664654);
				DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, 100664655);
				DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr, 100664656);
			}

			// Token: 0x0600264A RID: 9802 RVA: 0x0009B150 File Offset: 0x00099350
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGRequestFriendMatch._execute_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600264B RID: 9803 RVA: 0x0009B198 File Offset: 0x00099398
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600264C RID: 9804 RVA: 0x0009B1CC File Offset: 0x000993CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505534, XrefRangeEnd = 505639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x0600264D RID: 9805 RVA: 0x0009B208 File Offset: 0x00099408
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600264E RID: 9806 RVA: 0x0009B248 File Offset: 0x00099448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505639, XrefRangeEnd = 505644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x0600264F RID: 9807 RVA: 0x0009B27C File Offset: 0x0009947C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGRequestFriendMatch._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002650 RID: 9808 RVA: 0x00013D7C File Offset: 0x00011F7C
			public _execute_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x06002651 RID: 9809 RVA: 0x0009B2BC File Offset: 0x000994BC
			// (set) Token: 0x06002652 RID: 9810 RVA: 0x00013D85 File Offset: 0x00011F85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x06002653 RID: 9811 RVA: 0x0009B2E4 File Offset: 0x000994E4
			// (set) Token: 0x06002654 RID: 9812 RVA: 0x00013DA0 File Offset: 0x00011FA0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x06002655 RID: 9813 RVA: 0x0009B314 File Offset: 0x00099514
			// (set) Token: 0x06002656 RID: 9814 RVA: 0x00013DBF File Offset: 0x00011FBF
			public unsafe DBGRequestFriendMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGRequestFriendMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGRequestFriendMatch._execute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001803 RID: 6147
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001804 RID: 6148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001805 RID: 6149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001806 RID: 6150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001807 RID: 6151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
