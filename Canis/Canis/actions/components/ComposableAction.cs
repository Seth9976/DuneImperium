using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace Canis.actions.components
{
	// Token: 0x0200022F RID: 559
	public class ComposableAction : StateMachineAction
	{
		// Token: 0x06001749 RID: 5961 RVA: 0x00076C18 File Offset: 0x00074E18
		// Note: this type is marked as 'beforefieldinit'.
		static ComposableAction()
		{
			Il2CppClassPointerStore<ComposableAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.components", "ComposableAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr);
			ComposableAction.NativeFieldInfoPtr_DoOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "DoOrder");
			ComposableAction.NativeFieldInfoPtr_states = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "states");
			ComposableAction.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "components");
			ComposableAction.NativeMethodInfoPtr_MakeStatesFromKeyGroup_Private_Static_IEnumerable_1_ValueTuple_2_Int32_ActionComponent_IGrouping_2_Int32_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668586);
			ComposableAction.NativeMethodInfoPtr_MakeStates_Protected_Static_Dictionary_2_Int32_ActionComponent_Il2CppReferenceArray_1_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668587);
			ComposableAction.NativeMethodInfoPtr_GetInitialState_Protected_Static_Int32_Il2CppReferenceArray_1_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668588);
			ComposableAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_Il2CppReferenceArray_1_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668589);
			ComposableAction.NativeMethodInfoPtr_DetermineNextState_Protected_Virtual_Nullable_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668590);
			ComposableAction.NativeMethodInfoPtr_BehaviorFor_Protected_Virtual_StateBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668591);
			ComposableAction.NativeMethodInfoPtr_Do_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, 100668592);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00076D10 File Offset: 0x00074F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594983, XrefRangeEnd = 594989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ValueTuple<int, ActionComponent>> MakeStatesFromKeyGroup(IGrouping<int, ValueTuple<int, ActionComponent>> group)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.NativeMethodInfoPtr_MakeStatesFromKeyGroup_Private_Static_IEnumerable_1_ValueTuple_2_Int32_ActionComponent_IGrouping_2_Int32_ValueTuple_2_Int32_ActionComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<int, ActionComponent>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00076D54 File Offset: 0x00074F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 595090, RefRangeEnd = 595091, XrefRangeStart = 594989, XrefRangeEnd = 595090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, ActionComponent> MakeStates(Il2CppReferenceArray<ActionComponent> components)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.NativeMethodInfoPtr_MakeStates_Protected_Static_Dictionary_2_Int32_ActionComponent_Il2CppReferenceArray_1_ActionComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ActionComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00076D98 File Offset: 0x00074F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 595132, RefRangeEnd = 595133, XrefRangeStart = 595091, XrefRangeEnd = 595132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInitialState(Il2CppReferenceArray<ActionComponent> components)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.NativeMethodInfoPtr_GetInitialState_Protected_Static_Int32_Il2CppReferenceArray_1_ActionComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00076DDC File Offset: 0x00074FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595133, XrefRangeEnd = 595163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComposableAction(Match m, [Optional] Il2CppReferenceArray<ActionComponent> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<ActionComponent>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_Il2CppReferenceArray_1_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00076E48 File Offset: 0x00075048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595163, XrefRangeEnd = 595176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<int> DetermineNextState(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComposableAction.NativeMethodInfoPtr_DetermineNextState_Protected_Virtual_Nullable_1_Int32_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00076E9C File Offset: 0x0007509C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595176, XrefRangeEnd = 595190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior BehaviorFor(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComposableAction.NativeMethodInfoPtr_BehaviorFor_Protected_Virtual_StateBehavior_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00076EF4 File Offset: 0x000750F4
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> Do()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComposableAction.NativeMethodInfoPtr_Do_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0000B22B File Offset: 0x0000942B
		public ComposableAction(Match m, params ActionComponent[] components)
			: this(m, new Il2CppReferenceArray<ActionComponent>(components))
		{
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0000B23A File Offset: 0x0000943A
		public ComposableAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x00076F40 File Offset: 0x00075140
		// (set) Token: 0x06001754 RID: 5972 RVA: 0x0000B243 File Offset: 0x00009443
		public unsafe static int DoOrder
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ComposableAction.NativeFieldInfoPtr_DoOrder, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComposableAction.NativeFieldInfoPtr_DoOrder, (void*)(&value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x00076F5C File Offset: 0x0007515C
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0000B251 File Offset: 0x00009451
		public unsafe List<int> states
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.NativeFieldInfoPtr_states);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.NativeFieldInfoPtr_states), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x00076F8C File Offset: 0x0007518C
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x0000B270 File Offset: 0x00009470
		public unsafe Dictionary<int, ActionComponent> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ActionComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_DoOrder;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeFieldInfoPtr_states;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_MakeStatesFromKeyGroup_Private_Static_IEnumerable_1_ValueTuple_2_Int32_ActionComponent_IGrouping_2_Int32_ValueTuple_2_Int32_ActionComponent_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_MakeStates_Protected_Static_Dictionary_2_Int32_ActionComponent_Il2CppReferenceArray_1_ActionComponent_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_GetInitialState_Protected_Static_Int32_Il2CppReferenceArray_1_ActionComponent_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_Il2CppReferenceArray_1_ActionComponent_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextState_Protected_Virtual_Nullable_1_Int32_Action_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_BehaviorFor_Protected_Virtual_StateBehavior_Int32_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_Do_Protected_Abstract_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x02000475 RID: 1141
		[ObfuscatedName("Canis.actions.components.ComposableAction+<>O")]
		public static class __O : Object
		{
			// Token: 0x06003317 RID: 13079 RVA: 0x0001887C File Offset: 0x00016A7C
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ComposableAction.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposableAction.__O>.NativeClassPtr);
				ComposableAction.__O.NativeFieldInfoPtr__0___MakeStatesFromKeyGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__O>.NativeClassPtr, "<0>__MakeStatesFromKeyGroup");
			}

			// Token: 0x06003318 RID: 13080 RVA: 0x000188B0 File Offset: 0x00016AB0
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x06003319 RID: 13081 RVA: 0x000D1418 File Offset: 0x000CF618
			// (set) Token: 0x0600331A RID: 13082 RVA: 0x000188B9 File Offset: 0x00016AB9
			public unsafe static Func<IGrouping<int, ValueTuple<int, ActionComponent>>, IEnumerable<ValueTuple<int, ActionComponent>>> _0___MakeStatesFromKeyGroup
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__O.NativeFieldInfoPtr__0___MakeStatesFromKeyGroup, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, ValueTuple<int, ActionComponent>>, IEnumerable<ValueTuple<int, ActionComponent>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__O.NativeFieldInfoPtr__0___MakeStatesFromKeyGroup, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FEA RID: 8170
			private static readonly IntPtr NativeFieldInfoPtr__0___MakeStatesFromKeyGroup;
		}

		// Token: 0x02000476 RID: 1142
		[ObfuscatedName("Canis.actions.components.ComposableAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600331B RID: 13083 RVA: 0x000D1440 File Offset: 0x000CF640
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr);
				ComposableAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9");
				ComposableAction.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__4_0");
				ComposableAction.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__4_1");
				ComposableAction.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__4_2");
				ComposableAction.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__4_3");
				ComposableAction.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__4_4");
				ComposableAction.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__5_0");
				ComposableAction.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__5_1");
				ComposableAction.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, "<>9__6_0");
				ComposableAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668594);
				ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_0_Internal_ValueTuple_2_Int32_ActionComponent_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668595);
				ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_1_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668596);
				ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_2_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668597);
				ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_3_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668598);
				ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_4_Internal_ActionComponent_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668599);
				ComposableAction.__c.NativeMethodInfoPtr__GetInitialState_b__5_0_Internal_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668600);
				ComposableAction.__c.NativeMethodInfoPtr__GetInitialState_b__5_1_Internal_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668601);
				ComposableAction.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Int32_KeyValuePair_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr, 100668602);
			}

			// Token: 0x0600331C RID: 13084 RVA: 0x000D15D4 File Offset: 0x000CF7D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComposableAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600331D RID: 13085 RVA: 0x000D1610 File Offset: 0x000CF810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594927, XrefRangeEnd = 594930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, ActionComponent> _MakeStates_b__4_0(ActionComponent component)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_0_Internal_ValueTuple_2_Int32_ActionComponent_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<int, ActionComponent>(intPtr);
				}
			}

			// Token: 0x0600331E RID: 13086 RVA: 0x000D1658 File Offset: 0x000CF858
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 507920, RefRangeEnd = 507929, XrefRangeStart = 507920, XrefRangeEnd = 507929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeStates_b__4_1(ValueTuple<int, ActionComponent> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_1_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600331F RID: 13087 RVA: 0x000D16AC File Offset: 0x000CF8AC
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 507920, RefRangeEnd = 507929, XrefRangeStart = 507920, XrefRangeEnd = 507929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeStates_b__4_2(ValueTuple<int, ActionComponent> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_2_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003320 RID: 13088 RVA: 0x000D1700 File Offset: 0x000CF900
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 507920, RefRangeEnd = 507929, XrefRangeStart = 507920, XrefRangeEnd = 507929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeStates_b__4_3(ValueTuple<int, ActionComponent> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_3_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003321 RID: 13089 RVA: 0x000D1754 File Offset: 0x000CF954
			[CallerCount(0)]
			public unsafe ActionComponent _MakeStates_b__4_4(ValueTuple<int, ActionComponent> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__MakeStates_b__4_4_Internal_ActionComponent_ValueTuple_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionComponent>(intPtr3) : null;
				}
			}

			// Token: 0x06003322 RID: 13090 RVA: 0x000D17AC File Offset: 0x000CF9AC
			[CallerCount(0)]
			public unsafe int _GetInitialState_b__5_0(ActionComponent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__GetInitialState_b__5_0_Internal_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003323 RID: 13091 RVA: 0x000D17FC File Offset: 0x000CF9FC
			[CallerCount(0)]
			public unsafe int _GetInitialState_b__5_1(ActionComponent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr__GetInitialState_b__5_1_Internal_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003324 RID: 13092 RVA: 0x000D184C File Offset: 0x000CFA4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594930, XrefRangeEnd = 594931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __ctor_b__6_0(KeyValuePair<int, ActionComponent> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Int32_KeyValuePair_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003325 RID: 13093 RVA: 0x000188CB File Offset: 0x00016ACB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06003326 RID: 13094 RVA: 0x000D18A0 File Offset: 0x000CFAA0
			// (set) Token: 0x06003327 RID: 13095 RVA: 0x000188D4 File Offset: 0x00016AD4
			public unsafe static ComposableAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComposableAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x06003328 RID: 13096 RVA: 0x000D18C8 File Offset: 0x000CFAC8
			// (set) Token: 0x06003329 RID: 13097 RVA: 0x000188E6 File Offset: 0x00016AE6
			public unsafe static Func<ActionComponent, ValueTuple<int, ActionComponent>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionComponent, ValueTuple<int, ActionComponent>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x0600332A RID: 13098 RVA: 0x000D18F0 File Offset: 0x000CFAF0
			// (set) Token: 0x0600332B RID: 13099 RVA: 0x000188F8 File Offset: 0x00016AF8
			public unsafe static Func<ValueTuple<int, ActionComponent>, int> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, ActionComponent>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x0600332C RID: 13100 RVA: 0x000D1918 File Offset: 0x000CFB18
			// (set) Token: 0x0600332D RID: 13101 RVA: 0x0001890A File Offset: 0x00016B0A
			public unsafe static Func<ValueTuple<int, ActionComponent>, int> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, ActionComponent>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x0600332E RID: 13102 RVA: 0x000D1940 File Offset: 0x000CFB40
			// (set) Token: 0x0600332F RID: 13103 RVA: 0x0001891C File Offset: 0x00016B1C
			public unsafe static Func<ValueTuple<int, ActionComponent>, int> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, ActionComponent>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x06003330 RID: 13104 RVA: 0x000D1968 File Offset: 0x000CFB68
			// (set) Token: 0x06003331 RID: 13105 RVA: 0x0001892E File Offset: 0x00016B2E
			public unsafe static Func<ValueTuple<int, ActionComponent>, ActionComponent> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, ActionComponent>, ActionComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x06003332 RID: 13106 RVA: 0x000D1990 File Offset: 0x000CFB90
			// (set) Token: 0x06003333 RID: 13107 RVA: 0x00018940 File Offset: 0x00016B40
			public unsafe static Func<ActionComponent, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionComponent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x06003334 RID: 13108 RVA: 0x000D19B8 File Offset: 0x000CFBB8
			// (set) Token: 0x06003335 RID: 13109 RVA: 0x00018952 File Offset: 0x00016B52
			public unsafe static Func<ActionComponent, int> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionComponent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06003336 RID: 13110 RVA: 0x000D19E0 File Offset: 0x000CFBE0
			// (set) Token: 0x06003337 RID: 13111 RVA: 0x00018964 File Offset: 0x00016B64
			public unsafe static Func<KeyValuePair<int, ActionComponent>, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComposableAction.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ActionComponent>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComposableAction.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FEB RID: 8171
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FEC RID: 8172
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001FED RID: 8173
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04001FEE RID: 8174
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04001FEF RID: 8175
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x04001FF0 RID: 8176
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x04001FF1 RID: 8177
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001FF2 RID: 8178
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04001FF3 RID: 8179
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001FF4 RID: 8180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FF5 RID: 8181
			private static readonly IntPtr NativeMethodInfoPtr__MakeStates_b__4_0_Internal_ValueTuple_2_Int32_ActionComponent_ActionComponent_0;

			// Token: 0x04001FF6 RID: 8182
			private static readonly IntPtr NativeMethodInfoPtr__MakeStates_b__4_1_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0;

			// Token: 0x04001FF7 RID: 8183
			private static readonly IntPtr NativeMethodInfoPtr__MakeStates_b__4_2_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0;

			// Token: 0x04001FF8 RID: 8184
			private static readonly IntPtr NativeMethodInfoPtr__MakeStates_b__4_3_Internal_Int32_ValueTuple_2_Int32_ActionComponent_0;

			// Token: 0x04001FF9 RID: 8185
			private static readonly IntPtr NativeMethodInfoPtr__MakeStates_b__4_4_Internal_ActionComponent_ValueTuple_2_Int32_ActionComponent_0;

			// Token: 0x04001FFA RID: 8186
			private static readonly IntPtr NativeMethodInfoPtr__GetInitialState_b__5_0_Internal_Int32_ActionComponent_0;

			// Token: 0x04001FFB RID: 8187
			private static readonly IntPtr NativeMethodInfoPtr__GetInitialState_b__5_1_Internal_Int32_ActionComponent_0;

			// Token: 0x04001FFC RID: 8188
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Int32_KeyValuePair_2_Int32_ActionComponent_0;
		}

		// Token: 0x02000477 RID: 1143
		[ObfuscatedName("Canis.actions.components.ComposableAction+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06003338 RID: 13112 RVA: 0x000D1A08 File Offset: 0x000CFC08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr);
				ComposableAction.__c__DisplayClass8_0.NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr, "component");
				ComposableAction.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				ComposableAction.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr, 100668603);
				ComposableAction.__c__DisplayClass8_0.NativeMethodInfoPtr__BehaviorFor_b__0_Internal_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr, 100668604);
			}

			// Token: 0x06003339 RID: 13113 RVA: 0x000D1A84 File Offset: 0x000CFC84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComposableAction.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600333A RID: 13114 RVA: 0x000D1AC0 File Offset: 0x000CFCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594931, XrefRangeEnd = 594932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Action> _BehaviorFor_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction.__c__DisplayClass8_0.NativeMethodInfoPtr__BehaviorFor_b__0_Internal_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}

			// Token: 0x0600333B RID: 13115 RVA: 0x00018976 File Offset: 0x00016B76
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x0600333C RID: 13116 RVA: 0x000D1B00 File Offset: 0x000CFD00
			// (set) Token: 0x0600333D RID: 13117 RVA: 0x0001897F File Offset: 0x00016B7F
			public unsafe ActionComponent component
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.__c__DisplayClass8_0.NativeFieldInfoPtr_component);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.__c__DisplayClass8_0.NativeFieldInfoPtr_component), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x0600333E RID: 13118 RVA: 0x000D1B30 File Offset: 0x000CFD30
			// (set) Token: 0x0600333F RID: 13119 RVA: 0x0001899E File Offset: 0x00016B9E
			public unsafe ComposableAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComposableAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FFD RID: 8189
			private static readonly IntPtr NativeFieldInfoPtr_component;

			// Token: 0x04001FFE RID: 8190
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FFF RID: 8191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002000 RID: 8192
			private static readonly IntPtr NativeMethodInfoPtr__BehaviorFor_b__0_Internal_IEnumerable_1_Action_0;
		}

		// Token: 0x02000478 RID: 1144
		[ObfuscatedName("Canis.actions.components.ComposableAction+<MakeStatesFromKeyGroup>d__3")]
		public sealed class _MakeStatesFromKeyGroup_d__3 : Object
		{
			// Token: 0x06003340 RID: 13120 RVA: 0x000D1B60 File Offset: 0x000CFD60
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeStatesFromKeyGroup_d__3()
			{
				Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComposableAction>.NativeClassPtr, "<MakeStatesFromKeyGroup>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "<>1__state");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "<>2__current");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "<>l__initialThreadId");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "group");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___3__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "<>3__group");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "<i>5__2");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, "<>7__wrap2");
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668605);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668606);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668607);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668608);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668609);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668610);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668611);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_Int32_ActionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668612);
				ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr, 100668613);
			}

			// Token: 0x06003341 RID: 13121 RVA: 0x000D1CCC File Offset: 0x000CFECC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeStatesFromKeyGroup_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComposableAction._MakeStatesFromKeyGroup_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003342 RID: 13122 RVA: 0x000D1D14 File Offset: 0x000CFF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594932, XrefRangeEnd = 594937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003343 RID: 13123 RVA: 0x000D1D48 File Offset: 0x000CFF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594937, XrefRangeEnd = 594964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003344 RID: 13124 RVA: 0x000D1D84 File Offset: 0x000CFF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594964, XrefRangeEnd = 594967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x06003345 RID: 13125 RVA: 0x000D1DB8 File Offset: 0x000CFFB8
			public unsafe ValueTuple<int, ActionComponent> prop_ValueTuple_2_Int32_ActionComponent_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<int, ActionComponent>(intPtr);
				}
			}

			// Token: 0x06003346 RID: 13126 RVA: 0x000D1DF0 File Offset: 0x000CFFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594967, XrefRangeEnd = 594972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DA5 RID: 3493
			// (get) Token: 0x06003347 RID: 13127 RVA: 0x000D1E24 File Offset: 0x000D0024
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594972, XrefRangeEnd = 594975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003348 RID: 13128 RVA: 0x000D1E64 File Offset: 0x000D0064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594975, XrefRangeEnd = 594983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<int, ActionComponent>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_Int32_ActionComponent_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_Int32_ActionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<int, ActionComponent>>>(intPtr3) : null;
			}

			// Token: 0x06003349 RID: 13129 RVA: 0x000D1EA4 File Offset: 0x000D00A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600334A RID: 13130 RVA: 0x000189BD File Offset: 0x00016BBD
			public _MakeStatesFromKeyGroup_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x0600334B RID: 13131 RVA: 0x000D1EE4 File Offset: 0x000D00E4
			// (set) Token: 0x0600334C RID: 13132 RVA: 0x000189C6 File Offset: 0x00016BC6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x0600334D RID: 13133 RVA: 0x000D1F0C File Offset: 0x000D010C
			// (set) Token: 0x0600334E RID: 13134 RVA: 0x000189E1 File Offset: 0x00016BE1
			public ValueTuple<int, ActionComponent> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___2__current);
					return new ValueTuple<int, ActionComponent>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, ActionComponent>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, ActionComponent>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x0600334F RID: 13135 RVA: 0x000D1F3C File Offset: 0x000D013C
			// (set) Token: 0x06003350 RID: 13136 RVA: 0x00018A0F File Offset: 0x00016C0F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06003351 RID: 13137 RVA: 0x000D1F64 File Offset: 0x000D0164
			// (set) Token: 0x06003352 RID: 13138 RVA: 0x00018A2A File Offset: 0x00016C2A
			public unsafe IGrouping<int, ValueTuple<int, ActionComponent>> group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr_group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGrouping<int, ValueTuple<int, ActionComponent>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06003353 RID: 13139 RVA: 0x000D1F94 File Offset: 0x000D0194
			// (set) Token: 0x06003354 RID: 13140 RVA: 0x00018A49 File Offset: 0x00016C49
			public unsafe IGrouping<int, ValueTuple<int, ActionComponent>> __3__group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___3__group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGrouping<int, ValueTuple<int, ActionComponent>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___3__group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x06003355 RID: 13141 RVA: 0x000D1FC4 File Offset: 0x000D01C4
			// (set) Token: 0x06003356 RID: 13142 RVA: 0x00018A68 File Offset: 0x00016C68
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17000DA3 RID: 3491
			// (get) Token: 0x06003357 RID: 13143 RVA: 0x000D1FEC File Offset: 0x000D01EC
			// (set) Token: 0x06003358 RID: 13144 RVA: 0x00018A83 File Offset: 0x00016C83
			public unsafe IEnumerator<ValueTuple<int, ActionComponent>> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<int, ActionComponent>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComposableAction._MakeStatesFromKeyGroup_d__3.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002001 RID: 8193
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002002 RID: 8194
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002003 RID: 8195
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002004 RID: 8196
			private static readonly IntPtr NativeFieldInfoPtr_group;

			// Token: 0x04002005 RID: 8197
			private static readonly IntPtr NativeFieldInfoPtr___3__group;

			// Token: 0x04002006 RID: 8198
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04002007 RID: 8199
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002008 RID: 8200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002009 RID: 8201
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400200A RID: 8202
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400200B RID: 8203
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400200C RID: 8204
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_Int32_ActionComponent_0;

			// Token: 0x0400200D RID: 8205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400200E RID: 8206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400200F RID: 8207
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_Int32_ActionComponent_0;

			// Token: 0x04002010 RID: 8208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
