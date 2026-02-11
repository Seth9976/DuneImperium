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

namespace dbgclient.menus.commands
{
	// Token: 0x0200009C RID: 156
	public class FetchMatchHistory : FailableCommand
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x00030ECC File Offset: 0x0002F0CC
		// Note: this type is marked as 'beforefieldinit'.
		static FetchMatchHistory()
		{
			Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.commands", "FetchMatchHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr);
			FetchMatchHistory.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, "<Result>k__BackingField");
			FetchMatchHistory.NativeFieldInfoPtr__baseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, "_baseUrl");
			FetchMatchHistory.NativeFieldInfoPtr__accountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, "_accountId");
			FetchMatchHistory.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, "_client");
			FetchMatchHistory.NativeMethodInfoPtr_get_Result_Public_get_MatchHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, 100664229);
			FetchMatchHistory.NativeMethodInfoPtr_set_Result_Private_set_Void_MatchHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, 100664230);
			FetchMatchHistory.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, 100664231);
			FetchMatchHistory.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, 100664232);
			FetchMatchHistory.NativeMethodInfoPtr__execute_b__8_0_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, 100664233);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00030FB0 File Offset: 0x0002F1B0
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		public unsafe MatchHistory Result
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory.NativeMethodInfoPtr_get_Result_Public_get_MatchHistory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchHistory>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory.NativeMethodInfoPtr_set_Result_Private_set_Void_MatchHistory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00031034 File Offset: 0x0002F234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 502760, RefRangeEnd = 502762, XrefRangeStart = 502756, XrefRangeEnd = 502760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FetchMatchHistory(string url, AccountID accountId, string client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000310A4 File Offset: 0x0002F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502762, XrefRangeEnd = 502767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FetchMatchHistory.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000310F0 File Offset: 0x0002F2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502767, XrefRangeEnd = 502797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__8_0(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory.NativeMethodInfoPtr__execute_b__8_0_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00004BC9 File Offset: 0x00002DC9
		public FetchMatchHistory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00031134 File Offset: 0x0002F334
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00004BD2 File Offset: 0x00002DD2
		public unsafe MatchHistory _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchHistory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00031164 File Offset: 0x0002F364
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00004BF1 File Offset: 0x00002DF1
		public unsafe string _baseUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__baseUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__baseUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0003118C File Offset: 0x0002F38C
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00004C10 File Offset: 0x00002E10
		public unsafe AccountID _accountId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__accountId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__accountId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000311BC File Offset: 0x0002F3BC
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00004C2F File Offset: 0x00002E2F
		public unsafe string _client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory.NativeFieldInfoPtr__client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr__baseUrl;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr__accountId;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr__client;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_MatchHistory_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_MatchHistory_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_String_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_0_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x0200030A RID: 778
		[ObfuscatedName("dbgclient.menus.commands.FetchMatchHistory+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x060024CC RID: 9420 RVA: 0x000967A4 File Offset: 0x000949A4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FetchMatchHistory>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr);
				FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, "<>1__state");
				FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, "<>2__current");
				FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, "<>4__this");
				FetchMatchHistory._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, 100664234);
				FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, 100664235);
				FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, 100664236);
				FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, 100664237);
				FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, 100664238);
				FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr, 100664239);
			}

			// Token: 0x060024CD RID: 9421 RVA: 0x00096884 File Offset: 0x00094A84
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchMatchHistory._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024CE RID: 9422 RVA: 0x000968CC File Offset: 0x00094ACC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024CF RID: 9423 RVA: 0x00096900 File Offset: 0x00094B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502706, XrefRangeEnd = 502751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0009693C File Offset: 0x00094B3C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024D1 RID: 9425 RVA: 0x0009697C File Offset: 0x00094B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502751, XrefRangeEnd = 502756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000969B0 File Offset: 0x00094BB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchMatchHistory._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024D3 RID: 9427 RVA: 0x0001326C File Offset: 0x0001146C
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000969F0 File Offset: 0x00094BF0
			// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00013275 File Offset: 0x00011475
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00096A18 File Offset: 0x00094C18
			// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00013290 File Offset: 0x00011490
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00096A48 File Offset: 0x00094C48
			// (set) Token: 0x060024D9 RID: 9433 RVA: 0x000132AF File Offset: 0x000114AF
			public unsafe FetchMatchHistory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchMatchHistory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchMatchHistory._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400171D RID: 5917
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400171E RID: 5918
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400171F RID: 5919
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001720 RID: 5920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001721 RID: 5921
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001722 RID: 5922
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001723 RID: 5923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001724 RID: 5924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001725 RID: 5925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
