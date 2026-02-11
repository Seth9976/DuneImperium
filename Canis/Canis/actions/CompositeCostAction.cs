using System;
using System.Runtime.InteropServices;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x02000174 RID: 372
	public class CompositeCostAction : CostAction
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x0005D160 File Offset: 0x0005B360
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeCostAction()
		{
			Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "CompositeCostAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr);
			CompositeCostAction.NativeFieldInfoPtr__children_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, "<children>k__BackingField");
			CompositeCostAction.NativeMethodInfoPtr_get_children_Public_get_List_1_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, 100666718);
			CompositeCostAction.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, 100666719);
			CompositeCostAction.NativeMethodInfoPtr_Then_Public_Virtual_CostAction_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, 100666720);
			CompositeCostAction.NativeMethodInfoPtr_Then_Public_Virtual_CostAction_Il2CppReferenceArray_1_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, 100666721);
			CompositeCostAction.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, 100666722);
			CompositeCostAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, 100666723);
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0005D21C File Offset: 0x0005B41C
		public unsafe List<CostAction> children
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction.NativeMethodInfoPtr_get_children_Public_get_List_1_CostAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CostAction>>(intPtr3) : null;
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0005D25C File Offset: 0x0005B45C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 582450, RefRangeEnd = 582454, XrefRangeStart = 582444, XrefRangeEnd = 582450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeCostAction(Match m, [Optional] Il2CppReferenceArray<CostAction> children)
		{
			if (children == null)
			{
				children = new Il2CppReferenceArray<CostAction>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(children);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_CostAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0005D2C8 File Offset: 0x0005B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582454, XrefRangeEnd = 582457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Then(CostAction next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeCostAction.NativeMethodInfoPtr_Then_Public_Virtual_CostAction_CostAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0005D324 File Offset: 0x0005B524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582457, XrefRangeEnd = 582460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Then([Optional] Il2CppReferenceArray<CostAction> next)
		{
			if (next == null)
			{
				next = new Il2CppReferenceArray<CostAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeCostAction.NativeMethodInfoPtr_Then_Public_Virtual_CostAction_Il2CppReferenceArray_1_CostAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0005D38C File Offset: 0x0005B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582460, XrefRangeEnd = 582475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeCostAction.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0005D3E4 File Offset: 0x0005B5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582475, XrefRangeEnd = 582481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeCostAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00008563 File Offset: 0x00006763
		public CompositeCostAction(Match m, params CostAction[] children)
			: this(m, new Il2CppReferenceArray<CostAction>(children))
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00008572 File Offset: 0x00006772
		public override CostAction Then(params CostAction[] next)
		{
			return this.Then(new Il2CppReferenceArray<CostAction>(next));
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00008580 File Offset: 0x00006780
		public CompositeCostAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0005D430 File Offset: 0x0005B630
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00008589 File Offset: 0x00006789
		public unsafe List<CostAction> _children_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction.NativeFieldInfoPtr__children_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CostAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction.NativeFieldInfoPtr__children_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr__children_k__BackingField;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_get_children_Public_get_List_1_CostAction_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_CostAction_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Virtual_CostAction_CostAction_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Virtual_CostAction_Il2CppReferenceArray_1_CostAction_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x020003B2 RID: 946
		[ObfuscatedName("Canis.actions.CompositeCostAction+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06002788 RID: 10120 RVA: 0x000ACC48 File Offset: 0x000AAE48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CompositeCostAction.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeCostAction.__c__DisplayClass6_0>.NativeClassPtr);
				CompositeCostAction.__c__DisplayClass6_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction.__c__DisplayClass6_0>.NativeClassPtr, "context");
				CompositeCostAction.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction.__c__DisplayClass6_0>.NativeClassPtr, 100666724);
				CompositeCostAction.__c__DisplayClass6_0.NativeMethodInfoPtr__CanBePaid_b__0_Internal_Boolean_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction.__c__DisplayClass6_0>.NativeClassPtr, 100666725);
			}

			// Token: 0x06002789 RID: 10121 RVA: 0x000ACCB0 File Offset: 0x000AAEB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeCostAction.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600278A RID: 10122 RVA: 0x000ACCEC File Offset: 0x000AAEEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582412, XrefRangeEnd = 582413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanBePaid_b__0(CostAction _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction.__c__DisplayClass6_0.NativeMethodInfoPtr__CanBePaid_b__0_Internal_Boolean_CostAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600278B RID: 10123 RVA: 0x00012E9E File Offset: 0x0001109E
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x0600278C RID: 10124 RVA: 0x000ACD3C File Offset: 0x000AAF3C
			// (set) Token: 0x0600278D RID: 10125 RVA: 0x00012EA7 File Offset: 0x000110A7
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction.__c__DisplayClass6_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction.__c__DisplayClass6_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__0_Internal_Boolean_CostAction_0;
		}

		// Token: 0x020003B3 RID: 947
		[ObfuscatedName("Canis.actions.CompositeCostAction+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x0600278E RID: 10126 RVA: 0x000ACD6C File Offset: 0x000AAF6C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeCostAction>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr);
				CompositeCostAction._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, "<>1__state");
				CompositeCostAction._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, "<>2__current");
				CompositeCostAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
				CompositeCostAction._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, "<>4__this");
				CompositeCostAction._execute_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, "<>7__wrap1");
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666726);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666727);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666728);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666729);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666730);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666731);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666732);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666733);
				CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr, 100666734);
			}

			// Token: 0x0600278F RID: 10127 RVA: 0x000ACEB0 File Offset: 0x000AB0B0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeCostAction._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002790 RID: 10128 RVA: 0x000ACEF8 File Offset: 0x000AB0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582413, XrefRangeEnd = 582418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002791 RID: 10129 RVA: 0x000ACF2C File Offset: 0x000AB12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582418, XrefRangeEnd = 582434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002792 RID: 10130 RVA: 0x000ACF68 File Offset: 0x000AB168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582434, XrefRangeEnd = 582437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x06002793 RID: 10131 RVA: 0x000ACF9C File Offset: 0x000AB19C
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002794 RID: 10132 RVA: 0x000ACFDC File Offset: 0x000AB1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582437, XrefRangeEnd = 582442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x06002795 RID: 10133 RVA: 0x000AD010 File Offset: 0x000AB210
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002796 RID: 10134 RVA: 0x000AD050 File Offset: 0x000AB250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582442, XrefRangeEnd = 582444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002797 RID: 10135 RVA: 0x000AD090 File Offset: 0x000AB290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeCostAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002798 RID: 10136 RVA: 0x00012EC6 File Offset: 0x000110C6
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x06002799 RID: 10137 RVA: 0x000AD0D0 File Offset: 0x000AB2D0
			// (set) Token: 0x0600279A RID: 10138 RVA: 0x00012ECF File Offset: 0x000110CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x0600279B RID: 10139 RVA: 0x000AD0F8 File Offset: 0x000AB2F8
			// (set) Token: 0x0600279C RID: 10140 RVA: 0x00012EEA File Offset: 0x000110EA
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x0600279D RID: 10141 RVA: 0x000AD128 File Offset: 0x000AB328
			// (set) Token: 0x0600279E RID: 10142 RVA: 0x00012F09 File Offset: 0x00011109
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x0600279F RID: 10143 RVA: 0x000AD150 File Offset: 0x000AB350
			// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00012F24 File Offset: 0x00011124
			public unsafe CompositeCostAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeCostAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x060027A1 RID: 10145 RVA: 0x000AD180 File Offset: 0x000AB380
			// (set) Token: 0x060027A2 RID: 10146 RVA: 0x00012F43 File Offset: 0x00011143
			public List<CostAction>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___7__wrap1);
					return new List<CostAction>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<CostAction>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeCostAction._execute_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<CostAction>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018B8 RID: 6328
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040018B9 RID: 6329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040018BA RID: 6330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018BB RID: 6331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018BC RID: 6332
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040018BD RID: 6333
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
