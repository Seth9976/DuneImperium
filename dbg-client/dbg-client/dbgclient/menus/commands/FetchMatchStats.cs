using System;
using Canis.utils.ids;
using dbgclient.data;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.menus.commands
{
	// Token: 0x0200009D RID: 157
	public class FetchMatchStats : FailableCommand
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x000311E4 File Offset: 0x0002F3E4
		// Note: this type is marked as 'beforefieldinit'.
		static FetchMatchStats()
		{
			Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.commands", "FetchMatchStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr);
			FetchMatchStats.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, "<Result>k__BackingField");
			FetchMatchStats.NativeFieldInfoPtr__baseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, "_baseUrl");
			FetchMatchStats.NativeFieldInfoPtr__accountIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, "_accountIds");
			FetchMatchStats.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, "_client");
			FetchMatchStats.NativeMethodInfoPtr_get_Result_Public_get_MatchStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, 100664240);
			FetchMatchStats.NativeMethodInfoPtr_set_Result_Private_set_Void_MatchStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, 100664241);
			FetchMatchStats.NativeMethodInfoPtr__ctor_Public_Void_String_IReadOnlyCollection_1_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, 100664242);
			FetchMatchStats.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, 100664243);
			FetchMatchStats.NativeMethodInfoPtr__execute_b__8_0_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, 100664244);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000312C8 File Offset: 0x0002F4C8
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00031308 File Offset: 0x0002F508
		public unsafe MatchStats Result
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats.NativeMethodInfoPtr_get_Result_Public_get_MatchStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchStats>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats.NativeMethodInfoPtr_set_Result_Private_set_Void_MatchStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0003134C File Offset: 0x0002F54C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502760, RefRangeEnd = 502762, XrefRangeStart = 502760, XrefRangeEnd = 502762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FetchMatchStats(string url, IReadOnlyCollection<AccountID> accountIds, string client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountIds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats.NativeMethodInfoPtr__ctor_Public_Void_String_IReadOnlyCollection_1_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000313BC File Offset: 0x0002F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502849, XrefRangeEnd = 502854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FetchMatchStats.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00031408 File Offset: 0x0002F608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502854, XrefRangeEnd = 502884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__8_0(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats.NativeMethodInfoPtr__execute_b__8_0_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00004C4E File Offset: 0x00002E4E
		public FetchMatchStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0003144C File Offset: 0x0002F64C
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00004C57 File Offset: 0x00002E57
		public unsafe MatchStats _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStats>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0003147C File Offset: 0x0002F67C
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00004C76 File Offset: 0x00002E76
		public unsafe string _baseUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__baseUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__baseUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000314A4 File Offset: 0x0002F6A4
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00004C95 File Offset: 0x00002E95
		public unsafe IReadOnlyCollection<AccountID> _accountIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__accountIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__accountIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000314D4 File Offset: 0x0002F6D4
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00004CB4 File Offset: 0x00002EB4
		public unsafe string _client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats.NativeFieldInfoPtr__client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr__baseUrl;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr__accountIds;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr__client;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_MatchStats_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_MatchStats_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IReadOnlyCollection_1_AccountID_String_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_0_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x0200030B RID: 779
		[ObfuscatedName("dbgclient.menus.commands.FetchMatchStats+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x060024DA RID: 9434 RVA: 0x00096A78 File Offset: 0x00094C78
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FetchMatchStats>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr);
				FetchMatchStats._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, "<>1__state");
				FetchMatchStats._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, "<>2__current");
				FetchMatchStats._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, "<>4__this");
				FetchMatchStats._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, 100664245);
				FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, 100664246);
				FetchMatchStats._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, 100664247);
				FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, 100664248);
				FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, 100664249);
				FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr, 100664250);
			}

			// Token: 0x060024DB RID: 9435 RVA: 0x00096B58 File Offset: 0x00094D58
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchMatchStats._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024DC RID: 9436 RVA: 0x00096BA0 File Offset: 0x00094DA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024DD RID: 9437 RVA: 0x00096BD4 File Offset: 0x00094DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502797, XrefRangeEnd = 502844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x060024DE RID: 9438 RVA: 0x00096C10 File Offset: 0x00094E10
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024DF RID: 9439 RVA: 0x00096C50 File Offset: 0x00094E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502844, XrefRangeEnd = 502849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x060024E0 RID: 9440 RVA: 0x00096C84 File Offset: 0x00094E84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchStats._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024E1 RID: 9441 RVA: 0x000132CE File Offset: 0x000114CE
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x060024E2 RID: 9442 RVA: 0x00096CC4 File Offset: 0x00094EC4
			// (set) Token: 0x060024E3 RID: 9443 RVA: 0x000132D7 File Offset: 0x000114D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x060024E4 RID: 9444 RVA: 0x00096CEC File Offset: 0x00094EEC
			// (set) Token: 0x060024E5 RID: 9445 RVA: 0x000132F2 File Offset: 0x000114F2
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00096D1C File Offset: 0x00094F1C
			// (set) Token: 0x060024E7 RID: 9447 RVA: 0x00013311 File Offset: 0x00011511
			public unsafe FetchMatchStats __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchMatchStats>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchStats._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001726 RID: 5926
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
