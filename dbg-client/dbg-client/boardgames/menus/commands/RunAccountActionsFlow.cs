using System;
using boardgames.menus.prompts;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000218 RID: 536
	public class RunAccountActionsFlow : Command
	{
		// Token: 0x0600188F RID: 6287 RVA: 0x0006D3C0 File Offset: 0x0006B5C0
		// Note: this type is marked as 'beforefieldinit'.
		static RunAccountActionsFlow()
		{
			Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunAccountActionsFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr);
			RunAccountActionsFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr, 100666955);
			RunAccountActionsFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr, 100666956);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0006D418 File Offset: 0x0006B618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527418, XrefRangeEnd = 527422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunAccountActionsFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0006D464 File Offset: 0x0006B664
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunAccountActionsFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000D9B1 File Offset: 0x0000BBB1
		public RunAccountActionsFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003EF RID: 1007
		[ObfuscatedName("boardgames.menus.commands.RunAccountActionsFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002F08 RID: 12040 RVA: 0x000B4E34 File Offset: 0x000B3034
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr);
				RunAccountActionsFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr, "<>9");
				RunAccountActionsFlow.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr, "<>9__0_1");
				RunAccountActionsFlow.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr, "<>9__0_0");
				RunAccountActionsFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr, 100666958);
				RunAccountActionsFlow.__c.NativeMethodInfoPtr__execute_b__0_1_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr, 100666959);
				RunAccountActionsFlow.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr, 100666960);
			}

			// Token: 0x06002F09 RID: 12041 RVA: 0x000B4ED8 File Offset: 0x000B30D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAccountActionsFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F0A RID: 12042 RVA: 0x000B4F14 File Offset: 0x000B3114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527236, XrefRangeEnd = 527243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0_1(ErrorInfo error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow.__c.NativeMethodInfoPtr__execute_b__0_1_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F0B RID: 12043 RVA: 0x000B4F5C File Offset: 0x000B315C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527243, XrefRangeEnd = 527250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0_0(ErrorInfo error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F0C RID: 12044 RVA: 0x000184E7 File Offset: 0x000166E7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D74 RID: 3444
			// (get) Token: 0x06002F0D RID: 12045 RVA: 0x000B4FA4 File Offset: 0x000B31A4
			// (set) Token: 0x06002F0E RID: 12046 RVA: 0x000184F0 File Offset: 0x000166F0
			public unsafe static RunAccountActionsFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunAccountActionsFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunAccountActionsFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunAccountActionsFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000B4FCC File Offset: 0x000B31CC
			// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00018502 File Offset: 0x00016702
			public unsafe static Action<ErrorInfo> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunAccountActionsFlow.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunAccountActionsFlow.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D76 RID: 3446
			// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000B4FF4 File Offset: 0x000B31F4
			// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00018514 File Offset: 0x00016714
			public unsafe static Action<ErrorInfo> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunAccountActionsFlow.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunAccountActionsFlow.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D1A RID: 7450
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D1B RID: 7451
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04001D1C RID: 7452
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001D1D RID: 7453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D1E RID: 7454
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_1_Internal_Void_ErrorInfo_0;

			// Token: 0x04001D1F RID: 7455
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_0_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x020003F0 RID: 1008
		[ObfuscatedName("boardgames.menus.commands.RunAccountActionsFlow+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002F13 RID: 12051 RVA: 0x000B501C File Offset: 0x000B321C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunAccountActionsFlow>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr);
				RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, "<>1__state");
				RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, "<>2__current");
				RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__accountActionsPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, "<accountActionsPrompt>5__2");
				RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__loginPromptFlow_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, "<loginPromptFlow>5__3");
				RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__deleteFlow_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, "<deleteFlow>5__4");
				RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, 100666961);
				RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, 100666962);
				RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, 100666963);
				RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, 100666964);
				RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, 100666965);
				RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr, 100666966);
			}

			// Token: 0x06002F14 RID: 12052 RVA: 0x000B5124 File Offset: 0x000B3324
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAccountActionsFlow._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F15 RID: 12053 RVA: 0x000B516C File Offset: 0x000B336C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F16 RID: 12054 RVA: 0x000B51A0 File Offset: 0x000B33A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527250, XrefRangeEnd = 527413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D7C RID: 3452
			// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000B51DC File Offset: 0x000B33DC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F18 RID: 12056 RVA: 0x000B521C File Offset: 0x000B341C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527413, XrefRangeEnd = 527418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000B5250 File Offset: 0x000B3450
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAccountActionsFlow._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x00018526 File Offset: 0x00016726
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000B5290 File Offset: 0x000B3490
			// (set) Token: 0x06002F1C RID: 12060 RVA: 0x0001852F File Offset: 0x0001672F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000B52B8 File Offset: 0x000B34B8
			// (set) Token: 0x06002F1E RID: 12062 RVA: 0x0001854A File Offset: 0x0001674A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000B52E8 File Offset: 0x000B34E8
			// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00018569 File Offset: 0x00016769
			public unsafe AccountActionsPrompt _accountActionsPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__accountActionsPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountActionsPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__accountActionsPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000B5318 File Offset: 0x000B3518
			// (set) Token: 0x06002F22 RID: 12066 RVA: 0x00018588 File Offset: 0x00016788
			public unsafe RunLoginPromptFlow _loginPromptFlow_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__loginPromptFlow_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLoginPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__loginPromptFlow_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000B5348 File Offset: 0x000B3548
			// (set) Token: 0x06002F24 RID: 12068 RVA: 0x000185A7 File Offset: 0x000167A7
			public unsafe RunDeleteAccountFlow _deleteFlow_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__deleteFlow_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDeleteAccountFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAccountActionsFlow._execute_d__0.NativeFieldInfoPtr__deleteFlow_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D20 RID: 7456
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D21 RID: 7457
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D22 RID: 7458
			private static readonly IntPtr NativeFieldInfoPtr__accountActionsPrompt_5__2;

			// Token: 0x04001D23 RID: 7459
			private static readonly IntPtr NativeFieldInfoPtr__loginPromptFlow_5__3;

			// Token: 0x04001D24 RID: 7460
			private static readonly IntPtr NativeFieldInfoPtr__deleteFlow_5__4;

			// Token: 0x04001D25 RID: 7461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D26 RID: 7462
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D27 RID: 7463
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D28 RID: 7464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D29 RID: 7465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D2A RID: 7466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
