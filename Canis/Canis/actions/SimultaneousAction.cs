using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001E8 RID: 488
	public class SimultaneousAction : Action
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x0006CBBC File Offset: 0x0006ADBC
		// Note: this type is marked as 'beforefieldinit'.
		static SimultaneousAction()
		{
			Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SimultaneousAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr);
			SimultaneousAction.NativeFieldInfoPtr__perPlayerActionStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr, "_perPlayerActionStacks");
			SimultaneousAction.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr, 100667859);
			SimultaneousAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr, 100667860);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0006CC28 File Offset: 0x0006AE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589757, XrefRangeEnd = 589781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimultaneousAction(IEnumerable<Action> actions, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0006CC88 File Offset: 0x0006AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589781, XrefRangeEnd = 589787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimultaneousAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0000A0EA File Offset: 0x000082EA
		public SimultaneousAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0006CCD4 File Offset: 0x0006AED4
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000A0F3 File Offset: 0x000082F3
		public unsafe List<Stack<ValueTuple<Action, IEnumerator<Action>>>> _perPlayerActionStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction.NativeFieldInfoPtr__perPlayerActionStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Stack<ValueTuple<Action, IEnumerator<Action>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction.NativeFieldInfoPtr__perPlayerActionStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeFieldInfoPtr__perPlayerActionStacks;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Action_Match_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000425 RID: 1061
		[ObfuscatedName("Canis.actions.SimultaneousAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002EA0 RID: 11936 RVA: 0x000C3848 File Offset: 0x000C1A48
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr);
				SimultaneousAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr, "<>9");
				SimultaneousAction.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr, "<>9__1_0");
				SimultaneousAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr, 100667862);
				SimultaneousAction.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr, 100667863);
			}

			// Token: 0x06002EA1 RID: 11937 RVA: 0x000C38C4 File Offset: 0x000C1AC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EA2 RID: 11938 RVA: 0x000C3900 File Offset: 0x000C1B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589684, XrefRangeEnd = 589700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stack<ValueTuple<Action, IEnumerator<Action>>> __ctor_b__1_0(Action act)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<Action, IEnumerator<Action>>>>(intPtr3) : null;
				}
			}

			// Token: 0x06002EA3 RID: 11939 RVA: 0x0001648C File Offset: 0x0001468C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x000C3950 File Offset: 0x000C1B50
			// (set) Token: 0x06002EA5 RID: 11941 RVA: 0x00016495 File Offset: 0x00014695
			public unsafe static SimultaneousAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimultaneousAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimultaneousAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimultaneousAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x000C3978 File Offset: 0x000C1B78
			// (set) Token: 0x06002EA7 RID: 11943 RVA: 0x000164A7 File Offset: 0x000146A7
			public unsafe static Func<Action, Stack<ValueTuple<Action, IEnumerator<Action>>>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SimultaneousAction.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action, Stack<ValueTuple<Action, IEnumerator<Action>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SimultaneousAction.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D3C RID: 7484
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D3D RID: 7485
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001D3E RID: 7486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D3F RID: 7487
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_0_Internal_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Action_0;
		}

		// Token: 0x02000426 RID: 1062
		[ObfuscatedName("Canis.actions.SimultaneousAction+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002EA8 RID: 11944 RVA: 0x000C39A0 File Offset: 0x000C1BA0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimultaneousAction>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr);
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<>1__state");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<>2__current");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<>4__this");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr__yielded_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<yielded>5__2");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<i>5__3");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr__actionStack_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<actionStack>5__4");
				SimultaneousAction._execute_d__2.NativeFieldInfoPtr__goToNextPlayer_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, "<goToNextPlayer>5__5");
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667864);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667865);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667866);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667867);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667868);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667869);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667870);
				SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr, 100667871);
			}

			// Token: 0x06002EA9 RID: 11945 RVA: 0x000C3B0C File Offset: 0x000C1D0C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimultaneousAction._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EAA RID: 11946 RVA: 0x000C3B54 File Offset: 0x000C1D54
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EAB RID: 11947 RVA: 0x000C3B88 File Offset: 0x000C1D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589700, XrefRangeEnd = 589750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C34 RID: 3124
			// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000C3BC4 File Offset: 0x000C1DC4
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002EAD RID: 11949 RVA: 0x000C3C04 File Offset: 0x000C1E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589750, XrefRangeEnd = 589755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C35 RID: 3125
			// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000C3C38 File Offset: 0x000C1E38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EAF RID: 11951 RVA: 0x000C3C78 File Offset: 0x000C1E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589755, XrefRangeEnd = 589757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002EB0 RID: 11952 RVA: 0x000C3CB8 File Offset: 0x000C1EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002EB1 RID: 11953 RVA: 0x000164B9 File Offset: 0x000146B9
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000C3CF8 File Offset: 0x000C1EF8
			// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x000164C2 File Offset: 0x000146C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x000C3D20 File Offset: 0x000C1F20
			// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x000164DD File Offset: 0x000146DD
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x000C3D50 File Offset: 0x000C1F50
			// (set) Token: 0x06002EB7 RID: 11959 RVA: 0x000164FC File Offset: 0x000146FC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C2F RID: 3119
			// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x000C3D78 File Offset: 0x000C1F78
			// (set) Token: 0x06002EB9 RID: 11961 RVA: 0x00016517 File Offset: 0x00014717
			public unsafe SimultaneousAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimultaneousAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C30 RID: 3120
			// (get) Token: 0x06002EBA RID: 11962 RVA: 0x000C3DA8 File Offset: 0x000C1FA8
			// (set) Token: 0x06002EBB RID: 11963 RVA: 0x00016536 File Offset: 0x00014736
			public unsafe bool _yielded_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__yielded_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__yielded_5__2)) = value;
				}
			}

			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x06002EBC RID: 11964 RVA: 0x000C3DD0 File Offset: 0x000C1FD0
			// (set) Token: 0x06002EBD RID: 11965 RVA: 0x00016551 File Offset: 0x00014751
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x06002EBE RID: 11966 RVA: 0x000C3DF8 File Offset: 0x000C1FF8
			// (set) Token: 0x06002EBF RID: 11967 RVA: 0x0001656C File Offset: 0x0001476C
			public unsafe Stack<ValueTuple<Action, IEnumerator<Action>>> _actionStack_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__actionStack_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<Action, IEnumerator<Action>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__actionStack_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C33 RID: 3123
			// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000C3E28 File Offset: 0x000C2028
			// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x0001658B File Offset: 0x0001478B
			public unsafe bool _goToNextPlayer_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__goToNextPlayer_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimultaneousAction._execute_d__2.NativeFieldInfoPtr__goToNextPlayer_5__5)) = value;
				}
			}

			// Token: 0x04001D40 RID: 7488
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D41 RID: 7489
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D42 RID: 7490
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001D43 RID: 7491
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D44 RID: 7492
			private static readonly IntPtr NativeFieldInfoPtr__yielded_5__2;

			// Token: 0x04001D45 RID: 7493
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04001D46 RID: 7494
			private static readonly IntPtr NativeFieldInfoPtr__actionStack_5__4;

			// Token: 0x04001D47 RID: 7495
			private static readonly IntPtr NativeFieldInfoPtr__goToNextPlayer_5__5;

			// Token: 0x04001D48 RID: 7496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D49 RID: 7497
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D4A RID: 7498
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D4B RID: 7499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001D4C RID: 7500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D4D RID: 7501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D4E RID: 7502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001D4F RID: 7503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
