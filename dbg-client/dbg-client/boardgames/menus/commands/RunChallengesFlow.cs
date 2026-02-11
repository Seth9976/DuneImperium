using System;
using boardgames.match.behaviours;
using boardgames.menus.prompts;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x0200021C RID: 540
	public class RunChallengesFlow : Command
	{
		// Token: 0x060018B2 RID: 6322 RVA: 0x0006DB70 File Offset: 0x0006BD70
		// Note: this type is marked as 'beforefieldinit'.
		static RunChallengesFlow()
		{
			Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunChallengesFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr);
			RunChallengesFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr, 100667010);
			RunChallengesFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr, 100667011);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0006DBC8 File Offset: 0x0006BDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527718, XrefRangeEnd = 527722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunChallengesFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0006DC14 File Offset: 0x0006BE14
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunChallengesFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0000DAA9 File Offset: 0x0000BCA9
		public RunChallengesFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F6 RID: 1014
		[ObfuscatedName("boardgames.menus.commands.RunChallengesFlow+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06002F73 RID: 12147 RVA: 0x000B62A4 File Offset: 0x000B44A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<RunChallengesFlow.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunChallengesFlow.__c__DisplayClass0_0>.NativeClassPtr);
				RunChallengesFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_matchHub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChallengesFlow.__c__DisplayClass0_0>.NativeClassPtr, "matchHub");
				RunChallengesFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow.__c__DisplayClass0_0>.NativeClassPtr, 100667012);
				RunChallengesFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow.__c__DisplayClass0_0>.NativeClassPtr, 100667013);
			}

			// Token: 0x06002F74 RID: 12148 RVA: 0x000B630C File Offset: 0x000B450C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunChallengesFlow.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F75 RID: 12149 RVA: 0x000B6348 File Offset: 0x000B4548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527676, XrefRangeEnd = 527679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F76 RID: 12150 RVA: 0x0001882C File Offset: 0x00016A2C
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000B6384 File Offset: 0x000B4584
			// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00018835 File Offset: 0x00016A35
			public unsafe DBGMatchHub matchHub
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_matchHub);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow.__c__DisplayClass0_0.NativeFieldInfoPtr_matchHub), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D5C RID: 7516
			private static readonly IntPtr NativeFieldInfoPtr_matchHub;

			// Token: 0x04001D5D RID: 7517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D5E RID: 7518
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0;
		}

		// Token: 0x020003F7 RID: 1015
		[ObfuscatedName("boardgames.menus.commands.RunChallengesFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002F79 RID: 12153 RVA: 0x000B63B4 File Offset: 0x000B45B4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunChallengesFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr);
				RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, "<>8__1");
				RunChallengesFlow._execute_d__0.NativeFieldInfoPtr__challengesSelectPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, "<challengesSelectPrompt>5__2");
				RunChallengesFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, 100667014);
				RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, 100667015);
				RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, 100667016);
				RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, 100667017);
				RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, 100667018);
				RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr, 100667019);
			}

			// Token: 0x06002F7A RID: 12154 RVA: 0x000B64A8 File Offset: 0x000B46A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunChallengesFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F7B RID: 12155 RVA: 0x000B64F0 File Offset: 0x000B46F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F7C RID: 12156 RVA: 0x000B6524 File Offset: 0x000B4724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527679, XrefRangeEnd = 527713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06002F7D RID: 12157 RVA: 0x000B6560 File Offset: 0x000B4760
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F7E RID: 12158 RVA: 0x000B65A0 File Offset: 0x000B47A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527713, XrefRangeEnd = 527718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06002F7F RID: 12159 RVA: 0x000B65D4 File Offset: 0x000B47D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunChallengesFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F80 RID: 12160 RVA: 0x00018854 File Offset: 0x00016A54
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x06002F81 RID: 12161 RVA: 0x000B6614 File Offset: 0x000B4814
			// (set) Token: 0x06002F82 RID: 12162 RVA: 0x0001885D File Offset: 0x00016A5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x06002F83 RID: 12163 RVA: 0x000B663C File Offset: 0x000B483C
			// (set) Token: 0x06002F84 RID: 12164 RVA: 0x00018878 File Offset: 0x00016A78
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x06002F85 RID: 12165 RVA: 0x000B666C File Offset: 0x000B486C
			// (set) Token: 0x06002F86 RID: 12166 RVA: 0x00018897 File Offset: 0x00016A97
			public unsafe RunChallengesFlow.__c__DisplayClass0_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunChallengesFlow.__c__DisplayClass0_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x06002F87 RID: 12167 RVA: 0x000B669C File Offset: 0x000B489C
			// (set) Token: 0x06002F88 RID: 12168 RVA: 0x000188B6 File Offset: 0x00016AB6
			public unsafe ChallengesSelectPrompt _challengesSelectPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr__challengesSelectPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengesSelectPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunChallengesFlow._execute_d__0.NativeFieldInfoPtr__challengesSelectPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D5F RID: 7519
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D60 RID: 7520
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D61 RID: 7521
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001D62 RID: 7522
			private static readonly IntPtr NativeFieldInfoPtr__challengesSelectPrompt_5__2;

			// Token: 0x04001D63 RID: 7523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D64 RID: 7524
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D65 RID: 7525
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D66 RID: 7526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D67 RID: 7527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D68 RID: 7528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
