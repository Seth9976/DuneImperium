using System;
using boardgames.account;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.ranked.commands
{
	// Token: 0x0200003A RID: 58
	public class RunRankedPlayFlow : FailableCommand
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00008FAC File Offset: 0x000071AC
		// Note: this type is marked as 'beforefieldinit'.
		static RunRankedPlayFlow()
		{
			Il2CppClassPointerStore<RunRankedPlayFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "RunRankedPlayFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedPlayFlow>.NativeClassPtr);
			RunRankedPlayFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow>.NativeClassPtr, 100663510);
			RunRankedPlayFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow>.NativeClassPtr, 100663511);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00009004 File Offset: 0x00007204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226327, XrefRangeEnd = 1226332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunRankedPlayFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00009050 File Offset: 0x00007250
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunRankedPlayFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedPlayFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00003133 File Offset: 0x00001333
		public RunRankedPlayFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("boardgames.ranked.commands.RunRankedPlayFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x060002B4 RID: 692 RVA: 0x0000B120 File Offset: 0x00009320
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRankedPlayFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr);
				RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, "<>4__this");
				RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr__check_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, "<check>5__2");
				RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr__initializeRanked_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, "<initializeRanked>5__3");
				RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, 100663512);
				RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, 100663513);
				RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, 100663514);
				RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, 100663515);
				RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, 100663516);
				RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr, 100663517);
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000B228 File Offset: 0x00009428
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedPlayFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0000B270 File Offset: 0x00009470
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0000B2A4 File Offset: 0x000094A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226287, XrefRangeEnd = 1226322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000B2E0 File Offset: 0x000094E0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000B320 File Offset: 0x00009520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226322, XrefRangeEnd = 1226327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060002BA RID: 698 RVA: 0x0000B354 File Offset: 0x00009554
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedPlayFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002BB RID: 699 RVA: 0x000037A9 File Offset: 0x000019A9
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x060002BC RID: 700 RVA: 0x0000B394 File Offset: 0x00009594
			// (set) Token: 0x060002BD RID: 701 RVA: 0x000037B2 File Offset: 0x000019B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x060002BE RID: 702 RVA: 0x0000B3BC File Offset: 0x000095BC
			// (set) Token: 0x060002BF RID: 703 RVA: 0x000037CD File Offset: 0x000019CD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000B3EC File Offset: 0x000095EC
			// (set) Token: 0x060002C1 RID: 705 RVA: 0x000037EC File Offset: 0x000019EC
			public unsafe RunRankedPlayFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRankedPlayFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000B41C File Offset: 0x0000961C
			// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000380B File Offset: 0x00001A0B
			public unsafe ICheckPrivilegesCommand _check_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr__check_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr__check_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000B44C File Offset: 0x0000964C
			// (set) Token: 0x060002C5 RID: 709 RVA: 0x0000382A File Offset: 0x00001A2A
			public unsafe InitializeRankedCommand _initializeRanked_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr__initializeRanked_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializeRankedCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedPlayFlow._execute_d__0.NativeFieldInfoPtr__initializeRanked_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400017E RID: 382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeFieldInfoPtr__check_5__2;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeFieldInfoPtr__initializeRanked_5__3;

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
