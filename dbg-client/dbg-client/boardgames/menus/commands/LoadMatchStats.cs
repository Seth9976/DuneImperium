using System;
using Canis.utils.ids;
using dbgclient.data;
using dbgclient.menus.commands;
using dwd.core.account;
using dwd.core.commands;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.commands
{
	// Token: 0x02000216 RID: 534
	public class LoadMatchStats : FailableCommand
	{
		// Token: 0x0600187F RID: 6271 RVA: 0x0006D0DC File Offset: 0x0006B2DC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadMatchStats()
		{
			Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "LoadMatchStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr);
			LoadMatchStats.NativeFieldInfoPtr_MatchStatsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, "MatchStatsData");
			LoadMatchStats.NativeFieldInfoPtr__friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, "_friends");
			LoadMatchStats.NativeFieldInfoPtr__accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, "_accountProvider");
			LoadMatchStats.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, 100666936);
			LoadMatchStats.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, 100666937);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0006D170 File Offset: 0x0006B370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 527175, RefRangeEnd = 527176, XrefRangeStart = 527174, XrefRangeEnd = 527175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadMatchStats(bool friends)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friends;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0006D1B8 File Offset: 0x0006B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527176, XrefRangeEnd = 527181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadMatchStats.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0000D927 File Offset: 0x0000BB27
		public LoadMatchStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0006D204 File Offset: 0x0006B404
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0000D930 File Offset: 0x0000BB30
		public unsafe List<MatchStatsData> MatchStatsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats.NativeFieldInfoPtr_MatchStatsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MatchStatsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats.NativeFieldInfoPtr_MatchStatsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0006D234 File Offset: 0x0006B434
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x0000D94F File Offset: 0x0000BB4F
		public unsafe bool _friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats.NativeFieldInfoPtr__friends);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats.NativeFieldInfoPtr__friends)) = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x0006D25C File Offset: 0x0006B45C
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x0000D96A File Offset: 0x0000BB6A
		public unsafe AccountProvider _accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats.NativeFieldInfoPtr__accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats.NativeFieldInfoPtr__accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeFieldInfoPtr_MatchStatsData;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeFieldInfoPtr__friends;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeFieldInfoPtr__accountProvider;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020003EC RID: 1004
		[ObfuscatedName("boardgames.menus.commands.LoadMatchStats+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002EE2 RID: 12002 RVA: 0x000B46F0 File Offset: 0x000B28F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr);
				LoadMatchStats.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr, "<>9");
				LoadMatchStats.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr, "<>9__4_0");
				LoadMatchStats.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr, 100666939);
				LoadMatchStats.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_AccountID_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr, 100666940);
			}

			// Token: 0x06002EE3 RID: 12003 RVA: 0x000B476C File Offset: 0x000B296C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadMatchStats.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EE4 RID: 12004 RVA: 0x000B47A8 File Offset: 0x000B29A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527054, XrefRangeEnd = 527058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _execute_b__4_0(RosterEntry f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats.__c.NativeMethodInfoPtr__execute_b__4_0_Internal_AccountID_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06002EE5 RID: 12005 RVA: 0x000183D7 File Offset: 0x000165D7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000B47F8 File Offset: 0x000B29F8
			// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x000183E0 File Offset: 0x000165E0
			public unsafe static LoadMatchStats.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadMatchStats.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadMatchStats.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadMatchStats.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D68 RID: 3432
			// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x000B4820 File Offset: 0x000B2A20
			// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x000183F2 File Offset: 0x000165F2
			public unsafe static Func<RosterEntry, AccountID> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadMatchStats.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadMatchStats.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D03 RID: 7427
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D04 RID: 7428
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001D05 RID: 7429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D06 RID: 7430
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__4_0_Internal_AccountID_RosterEntry_0;
		}

		// Token: 0x020003ED RID: 1005
		[ObfuscatedName("boardgames.menus.commands.LoadMatchStats+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002EEA RID: 12010 RVA: 0x000B4848 File Offset: 0x000B2A48
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadMatchStats>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr);
				LoadMatchStats._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, "<>1__state");
				LoadMatchStats._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, "<>2__current");
				LoadMatchStats._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, "<>4__this");
				LoadMatchStats._execute_d__4.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, "<request>5__2");
				LoadMatchStats._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, 100666941);
				LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, 100666942);
				LoadMatchStats._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, 100666943);
				LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, 100666944);
				LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, 100666945);
				LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr, 100666946);
			}

			// Token: 0x06002EEB RID: 12011 RVA: 0x000B493C File Offset: 0x000B2B3C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadMatchStats._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EEC RID: 12012 RVA: 0x000B4984 File Offset: 0x000B2B84
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EED RID: 12013 RVA: 0x000B49B8 File Offset: 0x000B2BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527058, XrefRangeEnd = 527169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000B49F4 File Offset: 0x000B2BF4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EEF RID: 12015 RVA: 0x000B4A34 File Offset: 0x000B2C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527169, XrefRangeEnd = 527174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x000B4A68 File Offset: 0x000B2C68
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadMatchStats._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EF1 RID: 12017 RVA: 0x00018404 File Offset: 0x00016604
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x000B4AA8 File Offset: 0x000B2CA8
			// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x0001840D File Offset: 0x0001660D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000B4AD0 File Offset: 0x000B2CD0
			// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00018428 File Offset: 0x00016628
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000B4B00 File Offset: 0x000B2D00
			// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x00018447 File Offset: 0x00016647
			public unsafe LoadMatchStats __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadMatchStats>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x000B4B30 File Offset: 0x000B2D30
			// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00018466 File Offset: 0x00016666
			public unsafe FetchMatchStats _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchMatchStats>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadMatchStats._execute_d__4.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D07 RID: 7431
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D08 RID: 7432
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D09 RID: 7433
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D0A RID: 7434
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04001D0B RID: 7435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D0C RID: 7436
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D0D RID: 7437
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D0E RID: 7438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D0F RID: 7439
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D10 RID: 7440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
