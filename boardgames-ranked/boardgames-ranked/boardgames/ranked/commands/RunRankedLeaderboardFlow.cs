using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using dwd.core.ui.prompt.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.ranked.commands
{
	// Token: 0x02000039 RID: 57
	public class RunRankedLeaderboardFlow : Command
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00008E84 File Offset: 0x00007084
		// Note: this type is marked as 'beforefieldinit'.
		static RunRankedLeaderboardFlow()
		{
			Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "RunRankedLeaderboardFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr);
			RunRankedLeaderboardFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr, 100663498);
			RunRankedLeaderboardFlow.NativeMethodInfoPtr_ShowErrorPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr, 100663499);
			RunRankedLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr, 100663500);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00008EF0 File Offset: 0x000070F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226266, XrefRangeEnd = 1226271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunRankedLeaderboardFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00008F3C File Offset: 0x0000713C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226271, XrefRangeEnd = 1226287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowErrorPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow.NativeMethodInfoPtr_ShowErrorPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00008F70 File Offset: 0x00007170
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunRankedLeaderboardFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000312A File Offset: 0x0000132A
		public RunRankedLeaderboardFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_ShowErrorPrompt_Private_Void_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("boardgames.ranked.commands.RunRankedLeaderboardFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600029A RID: 666 RVA: 0x0000AC78 File Offset: 0x00008E78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr);
				RunRankedLeaderboardFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr, "<>9");
				RunRankedLeaderboardFlow.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr, "<>9__0_0");
				RunRankedLeaderboardFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr, 100663502);
				RunRankedLeaderboardFlow.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr, 100663503);
			}

			// Token: 0x0600029B RID: 667 RVA: 0x0000ACF4 File Offset: 0x00008EF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedLeaderboardFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029C RID: 668 RVA: 0x0000AD30 File Offset: 0x00008F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226147, XrefRangeEnd = 1226155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0_0(UnityWebRequest r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600029D RID: 669 RVA: 0x000036DC File Offset: 0x000018DC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600029E RID: 670 RVA: 0x0000AD74 File Offset: 0x00008F74
			// (set) Token: 0x0600029F RID: 671 RVA: 0x000036E5 File Offset: 0x000018E5
			public unsafe static RunRankedLeaderboardFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunRankedLeaderboardFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRankedLeaderboardFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunRankedLeaderboardFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000AD9C File Offset: 0x00008F9C
			// (set) Token: 0x060002A1 RID: 673 RVA: 0x000036F7 File Offset: 0x000018F7
			public unsafe static Action<UnityWebRequest> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunRankedLeaderboardFlow.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunRankedLeaderboardFlow.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("boardgames.ranked.commands.RunRankedLeaderboardFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x060002A2 RID: 674 RVA: 0x0000ADC4 File Offset: 0x00008FC4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRankedLeaderboardFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr);
				RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, "<>4__this");
				RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, "<request>5__2");
				RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr__spinner_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, "<spinner>5__3");
				RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, 100663504);
				RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, 100663505);
				RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, 100663506);
				RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, 100663507);
				RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, 100663508);
				RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr, 100663509);
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0000AECC File Offset: 0x000090CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedLeaderboardFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000AF14 File Offset: 0x00009114
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000AF48 File Offset: 0x00009148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226155, XrefRangeEnd = 1226261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000AF84 File Offset: 0x00009184
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x0000AFC4 File Offset: 0x000091C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226261, XrefRangeEnd = 1226266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000AFF8 File Offset: 0x000091F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedLeaderboardFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00003709 File Offset: 0x00001909
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060002AA RID: 682 RVA: 0x0000B038 File Offset: 0x00009238
			// (set) Token: 0x060002AB RID: 683 RVA: 0x00003712 File Offset: 0x00001912
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060002AC RID: 684 RVA: 0x0000B060 File Offset: 0x00009260
			// (set) Token: 0x060002AD RID: 685 RVA: 0x0000372D File Offset: 0x0000192D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060002AE RID: 686 RVA: 0x0000B090 File Offset: 0x00009290
			// (set) Token: 0x060002AF RID: 687 RVA: 0x0000374C File Offset: 0x0000194C
			public unsafe RunRankedLeaderboardFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRankedLeaderboardFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000B0C0 File Offset: 0x000092C0
			// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000376B File Offset: 0x0000196B
			public unsafe DwdWebRequestCommand _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000B0F0 File Offset: 0x000092F0
			// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000378A File Offset: 0x0000198A
			public unsafe ShowSpinnerWhile<IFailable> _spinner_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr__spinner_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedLeaderboardFlow._execute_d__0.NativeFieldInfoPtr__spinner_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000173 RID: 371
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000174 RID: 372
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000175 RID: 373
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000176 RID: 374
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000177 RID: 375
			private static readonly IntPtr NativeFieldInfoPtr__spinner_5__3;

			// Token: 0x04000178 RID: 376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000179 RID: 377
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400017A RID: 378
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400017B RID: 379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400017C RID: 380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400017D RID: 381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
