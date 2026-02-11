using System;
using boardgames.ranked.menus;
using boardgames.ranked.networking.responses;
using dwd.core;
using dwd.core.commands;
using dwd.core.session.commands;
using dwd.core.ui.match.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.ranked.commands
{
	// Token: 0x02000037 RID: 55
	public class RunQueueForRankedFlow : Command
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00008BEC File Offset: 0x00006DEC
		// Note: this type is marked as 'beforefieldinit'.
		static RunQueueForRankedFlow()
		{
			Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "RunQueueForRankedFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr);
			RunQueueForRankedFlow.NativeFieldInfoPtr_gameStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr, "gameStarted");
			RunQueueForRankedFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr, 100663478);
			RunQueueForRankedFlow.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr, 100663479);
			RunQueueForRankedFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr, 100663480);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008C6C File Offset: 0x00006E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226095, XrefRangeEnd = 1226100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunQueueForRankedFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497605, RefRangeEnd = 497606, XrefRangeStart = 497605, XrefRangeEnd = 497606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLobbyGameStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow.NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00008CEC File Offset: 0x00006EEC
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunQueueForRankedFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000030DE File Offset: 0x000012DE
		public RunQueueForRankedFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00008D28 File Offset: 0x00006F28
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000030E7 File Offset: 0x000012E7
		public unsafe bool gameStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow.NativeFieldInfoPtr_gameStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow.NativeFieldInfoPtr_gameStarted)) = value;
			}
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_gameStarted;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_HandleLobbyGameStarted_Private_Void_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("boardgames.ranked.commands.RunQueueForRankedFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600026C RID: 620 RVA: 0x0000A41C File Offset: 0x0000861C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr);
				RunQueueForRankedFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr, "<>9");
				RunQueueForRankedFlow.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr, "<>9__1_0");
				RunQueueForRankedFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr, 100663482);
				RunQueueForRankedFlow.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_IEnumerator_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr, 100663483);
			}

			// Token: 0x0600026D RID: 621 RVA: 0x0000A498 File Offset: 0x00008698
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunQueueForRankedFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600026E RID: 622 RVA: 0x0000A4D4 File Offset: 0x000086D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226005, XrefRangeEnd = 1226009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _execute_b__1_0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_IEnumerator_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00003550 File Offset: 0x00001750
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000270 RID: 624 RVA: 0x0000A52C File Offset: 0x0000872C
			// (set) Token: 0x06000271 RID: 625 RVA: 0x00003559 File Offset: 0x00001759
			public unsafe static RunQueueForRankedFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunQueueForRankedFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunQueueForRankedFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunQueueForRankedFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000272 RID: 626 RVA: 0x0000A554 File Offset: 0x00008754
			// (set) Token: 0x06000273 RID: 627 RVA: 0x0000356B File Offset: 0x0000176B
			public unsafe static Func<ErrorInfo, IEnumerator> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunQueueForRankedFlow.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunQueueForRankedFlow.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_0_Internal_IEnumerator_ErrorInfo_0;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("boardgames.ranked.commands.RunQueueForRankedFlow+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06000274 RID: 628 RVA: 0x0000A57C File Offset: 0x0000877C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunQueueForRankedFlow>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr);
				RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, "<>1__state");
				RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, "<>2__current");
				RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, "<>4__this");
				RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__eventsProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, "<eventsProvider>5__2");
				RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__queue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, "<queue>5__3");
				RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__queuePrompt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, "<queuePrompt>5__4");
				RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, 100663484);
				RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, 100663485);
				RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, 100663486);
				RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, 100663487);
				RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, 100663488);
				RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr, 100663489);
			}

			// Token: 0x06000275 RID: 629 RVA: 0x0000A698 File Offset: 0x00008898
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunQueueForRankedFlow._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0000A6E0 File Offset: 0x000088E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000277 RID: 631 RVA: 0x0000A714 File Offset: 0x00008914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226009, XrefRangeEnd = 1226090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000278 RID: 632 RVA: 0x0000A750 File Offset: 0x00008950
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000279 RID: 633 RVA: 0x0000A790 File Offset: 0x00008990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226090, XrefRangeEnd = 1226095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600027A RID: 634 RVA: 0x0000A7C4 File Offset: 0x000089C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunQueueForRankedFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0000357D File Offset: 0x0000177D
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600027C RID: 636 RVA: 0x0000A804 File Offset: 0x00008A04
			// (set) Token: 0x0600027D RID: 637 RVA: 0x00003586 File Offset: 0x00001786
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x0600027E RID: 638 RVA: 0x0000A82C File Offset: 0x00008A2C
			// (set) Token: 0x0600027F RID: 639 RVA: 0x000035A1 File Offset: 0x000017A1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000280 RID: 640 RVA: 0x0000A85C File Offset: 0x00008A5C
			// (set) Token: 0x06000281 RID: 641 RVA: 0x000035C0 File Offset: 0x000017C0
			public unsafe RunQueueForRankedFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunQueueForRankedFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000282 RID: 642 RVA: 0x0000A88C File Offset: 0x00008A8C
			// (set) Token: 0x06000283 RID: 643 RVA: 0x000035DF File Offset: 0x000017DF
			public unsafe RankedPlayProvider _eventsProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__eventsProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedPlayProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__eventsProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000284 RID: 644 RVA: 0x0000A8BC File Offset: 0x00008ABC
			// (set) Token: 0x06000285 RID: 645 RVA: 0x000035FE File Offset: 0x000017FE
			public unsafe WriteToSessionAndAwaitResponse<RankedQueueJoined> _queue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__queue_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<RankedQueueJoined>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__queue_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000286 RID: 646 RVA: 0x0000A8EC File Offset: 0x00008AEC
			// (set) Token: 0x06000287 RID: 647 RVA: 0x0000361D File Offset: 0x0000181D
			public unsafe FlavoredDismissablePrompt _queuePrompt_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__queuePrompt_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredDismissablePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunQueueForRankedFlow._execute_d__1.NativeFieldInfoPtr__queuePrompt_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000159 RID: 345
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400015A RID: 346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400015B RID: 347
			private static readonly IntPtr NativeFieldInfoPtr__eventsProvider_5__2;

			// Token: 0x0400015C RID: 348
			private static readonly IntPtr NativeFieldInfoPtr__queue_5__3;

			// Token: 0x0400015D RID: 349
			private static readonly IntPtr NativeFieldInfoPtr__queuePrompt_5__4;

			// Token: 0x0400015E RID: 350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400015F RID: 351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000160 RID: 352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000161 RID: 353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000163 RID: 355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
