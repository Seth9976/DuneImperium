using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001EC RID: 492
	public class SlapjackSimultaneousAction : Action
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x0006D08C File Offset: 0x0006B28C
		// Note: this type is marked as 'beforefieldinit'.
		static SlapjackSimultaneousAction()
		{
			Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SlapjackSimultaneousAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr);
			SlapjackSimultaneousAction.NativeFieldInfoPtr__perPlayerActionStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr, "_perPlayerActionStacks");
			SlapjackSimultaneousAction.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ValueTuple_2_PlayerEntity_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr, 100667887);
			SlapjackSimultaneousAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr, 100667888);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0006D0F8 File Offset: 0x0006B2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589998, XrefRangeEnd = 590022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlapjackSimultaneousAction(IEnumerable<ValueTuple<PlayerEntity, Action>> actions, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ValueTuple_2_PlayerEntity_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0006D158 File Offset: 0x0006B358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590022, XrefRangeEnd = 590028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlapjackSimultaneousAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0000A1A4 File Offset: 0x000083A4
		public SlapjackSimultaneousAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0006D1A4 File Offset: 0x0006B3A4
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x0000A1AD File Offset: 0x000083AD
		public unsafe List<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>> _perPlayerActionStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction.NativeFieldInfoPtr__perPlayerActionStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction.NativeFieldInfoPtr__perPlayerActionStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeFieldInfoPtr__perPlayerActionStacks;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ValueTuple_2_PlayerEntity_Action_Match_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000428 RID: 1064
		[ObfuscatedName("Canis.actions.SlapjackSimultaneousAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002ED4 RID: 11988 RVA: 0x000C4208 File Offset: 0x000C2408
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr);
				SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr, "<>9");
				SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr, "<>9__1_0");
				SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr, "<>9__2_0");
				SlapjackSimultaneousAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr, 100667890);
				SlapjackSimultaneousAction.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_ValueTuple_2_PlayerEntity_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr, 100667891);
				SlapjackSimultaneousAction.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_ValueTuple_2_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr, 100667892);
			}

			// Token: 0x06002ED5 RID: 11989 RVA: 0x000C42AC File Offset: 0x000C24AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ED6 RID: 11990 RVA: 0x000C42E8 File Offset: 0x000C24E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589833, XrefRangeEnd = 589852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>> __ctor_b__1_0(ValueTuple<PlayerEntity, Action> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_ValueTuple_2_PlayerEntity_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>(intPtr);
				}
			}

			// Token: 0x06002ED7 RID: 11991 RVA: 0x000C4338 File Offset: 0x000C2538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589852, XrefRangeEnd = 589855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int> _execute_b__2_0(ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>> stack, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(stack));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_ValueTuple_2_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int>(intPtr);
			}

			// Token: 0x06002ED8 RID: 11992 RVA: 0x00016623 File Offset: 0x00014823
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x000C4394 File Offset: 0x000C2594
			// (set) Token: 0x06002EDA RID: 11994 RVA: 0x0001662C File Offset: 0x0001482C
			public unsafe static SlapjackSimultaneousAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlapjackSimultaneousAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x06002EDB RID: 11995 RVA: 0x000C43BC File Offset: 0x000C25BC
			// (set) Token: 0x06002EDC RID: 11996 RVA: 0x0001663E File Offset: 0x0001483E
			public unsafe static Func<ValueTuple<PlayerEntity, Action>, ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<PlayerEntity, Action>, ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000C43E4 File Offset: 0x000C25E4
			// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00016650 File Offset: 0x00014850
			public unsafe static Func<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int, ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int, ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SlapjackSimultaneousAction.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D5C RID: 7516
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D5D RID: 7517
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001D5E RID: 7518
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001D5F RID: 7519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D60 RID: 7520
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_0_Internal_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_ValueTuple_2_PlayerEntity_Action_0;

			// Token: 0x04001D61 RID: 7521
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_ValueTuple_2_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_0;
		}

		// Token: 0x02000429 RID: 1065
		[ObfuscatedName("Canis.actions.SlapjackSimultaneousAction+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06002EDF RID: 11999 RVA: 0x000C440C File Offset: 0x000C260C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<SlapjackSimultaneousAction.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c__DisplayClass2_0>.NativeClassPtr);
				SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeFieldInfoPtr_slappedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c__DisplayClass2_0>.NativeClassPtr, "slappedIndex");
				SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c__DisplayClass2_0>.NativeClassPtr, 100667893);
				SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_ValueTuple_2_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c__DisplayClass2_0>.NativeClassPtr, 100667894);
			}

			// Token: 0x06002EE0 RID: 12000 RVA: 0x000C4474 File Offset: 0x000C2674
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlapjackSimultaneousAction.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EE1 RID: 12001 RVA: 0x000C44B0 File Offset: 0x000C26B0
			[CallerCount(0)]
			public unsafe bool _execute_b__1(ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_ValueTuple_2_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002EE2 RID: 12002 RVA: 0x00016662 File Offset: 0x00014862
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x000C4504 File Offset: 0x000C2704
			// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x0001666B File Offset: 0x0001486B
			public unsafe int slappedIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeFieldInfoPtr_slappedIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction.__c__DisplayClass2_0.NativeFieldInfoPtr_slappedIndex)) = value;
				}
			}

			// Token: 0x04001D62 RID: 7522
			private static readonly IntPtr NativeFieldInfoPtr_slappedIndex;

			// Token: 0x04001D63 RID: 7523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D64 RID: 7524
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_ValueTuple_2_ValueTuple_2_PlayerEntity_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_Int32_0;
		}

		// Token: 0x0200042A RID: 1066
		[ObfuscatedName("Canis.actions.SlapjackSimultaneousAction+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002EE5 RID: 12005 RVA: 0x000C452C File Offset: 0x000C272C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlapjackSimultaneousAction>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr);
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<>1__state");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<>2__current");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<>4__this");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__playerSlapped_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<playerSlapped>5__2");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__yielded_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<yielded>5__3");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<i>5__4");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__actionStack_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<actionStack>5__5");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__goToNextPlayer_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<goToNextPlayer>5__6");
				SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, "<>7__wrap6");
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667895);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667896);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667897);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667898);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667899);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667900);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667901);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667902);
				SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr, 100667903);
			}

			// Token: 0x06002EE6 RID: 12006 RVA: 0x000C46D4 File Offset: 0x000C28D4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlapjackSimultaneousAction._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EE7 RID: 12007 RVA: 0x000C471C File Offset: 0x000C291C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589855, XrefRangeEnd = 589860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EE8 RID: 12008 RVA: 0x000C4750 File Offset: 0x000C2950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589860, XrefRangeEnd = 589988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002EE9 RID: 12009 RVA: 0x000C478C File Offset: 0x000C298C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589988, XrefRangeEnd = 589991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C4A RID: 3146
			// (get) Token: 0x06002EEA RID: 12010 RVA: 0x000C47C0 File Offset: 0x000C29C0
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002EEB RID: 12011 RVA: 0x000C4800 File Offset: 0x000C2A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589991, XrefRangeEnd = 589996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C4B RID: 3147
			// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000C4834 File Offset: 0x000C2A34
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EED RID: 12013 RVA: 0x000C4874 File Offset: 0x000C2A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 589996, XrefRangeEnd = 589998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002EEE RID: 12014 RVA: 0x000C48B4 File Offset: 0x000C2AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlapjackSimultaneousAction._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002EEF RID: 12015 RVA: 0x00016686 File Offset: 0x00014886
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C40 RID: 3136
			// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x000C48F4 File Offset: 0x000C2AF4
			// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x0001668F File Offset: 0x0001488F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C41 RID: 3137
			// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x000C491C File Offset: 0x000C2B1C
			// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x000166AA File Offset: 0x000148AA
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000C494C File Offset: 0x000C2B4C
			// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x000166C9 File Offset: 0x000148C9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000C4974 File Offset: 0x000C2B74
			// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x000166E4 File Offset: 0x000148E4
			public unsafe SlapjackSimultaneousAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlapjackSimultaneousAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x000C49A4 File Offset: 0x000C2BA4
			// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00016703 File Offset: 0x00014903
			public Nullable<int> _playerSlapped_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__playerSlapped_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__playerSlapped_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x06002EFA RID: 12026 RVA: 0x000C49D4 File Offset: 0x000C2BD4
			// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00016731 File Offset: 0x00014931
			public unsafe bool _yielded_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__yielded_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__yielded_5__3)) = value;
				}
			}

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000C49FC File Offset: 0x000C2BFC
			// (set) Token: 0x06002EFD RID: 12029 RVA: 0x0001674C File Offset: 0x0001494C
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x17000C47 RID: 3143
			// (get) Token: 0x06002EFE RID: 12030 RVA: 0x000C4A24 File Offset: 0x000C2C24
			// (set) Token: 0x06002EFF RID: 12031 RVA: 0x00016767 File Offset: 0x00014967
			public unsafe Stack<ValueTuple<Action, IEnumerator<Action>>> _actionStack_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__actionStack_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<Action, IEnumerator<Action>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__actionStack_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C48 RID: 3144
			// (get) Token: 0x06002F00 RID: 12032 RVA: 0x000C4A54 File Offset: 0x000C2C54
			// (set) Token: 0x06002F01 RID: 12033 RVA: 0x00016786 File Offset: 0x00014986
			public unsafe bool _goToNextPlayer_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__goToNextPlayer_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr__goToNextPlayer_5__6)) = value;
				}
			}

			// Token: 0x17000C49 RID: 3145
			// (get) Token: 0x06002F02 RID: 12034 RVA: 0x000C4A7C File Offset: 0x000C2C7C
			// (set) Token: 0x06002F03 RID: 12035 RVA: 0x000167A1 File Offset: 0x000149A1
			public unsafe IEnumerator<ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int>> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<ValueTuple<PlayerEntity, Stack<ValueTuple<Action, IEnumerator<Action>>>>, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlapjackSimultaneousAction._execute_d__2.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D65 RID: 7525
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D66 RID: 7526
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D67 RID: 7527
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001D68 RID: 7528
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D69 RID: 7529
			private static readonly IntPtr NativeFieldInfoPtr__playerSlapped_5__2;

			// Token: 0x04001D6A RID: 7530
			private static readonly IntPtr NativeFieldInfoPtr__yielded_5__3;

			// Token: 0x04001D6B RID: 7531
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04001D6C RID: 7532
			private static readonly IntPtr NativeFieldInfoPtr__actionStack_5__5;

			// Token: 0x04001D6D RID: 7533
			private static readonly IntPtr NativeFieldInfoPtr__goToNextPlayer_5__6;

			// Token: 0x04001D6E RID: 7534
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x04001D6F RID: 7535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D70 RID: 7536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D71 RID: 7537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D72 RID: 7538
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001D73 RID: 7539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001D74 RID: 7540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D75 RID: 7541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D76 RID: 7542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001D77 RID: 7543
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
