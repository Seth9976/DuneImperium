using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x02000224 RID: 548
	public class ExecuteStackContainer : Object
	{
		// Token: 0x060016C7 RID: 5831 RVA: 0x00074C00 File Offset: 0x00072E00
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteStackContainer()
		{
			Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "ExecuteStackContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr);
			ExecuteStackContainer.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, "head");
			ExecuteStackContainer.NativeFieldInfoPtr_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, "tail");
			ExecuteStackContainer.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, "Empty");
			ExecuteStackContainer.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_ValueTuple_2_Action_IEnumerator_1_Action_ExecuteStackContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, 100668461);
			ExecuteStackContainer.NativeMethodInfoPtr__ctor_Public_Void_ExecuteStackContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, 100668462);
			ExecuteStackContainer.NativeMethodInfoPtr_StackActions_Public_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, 100668463);
			ExecuteStackContainer.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, 100668464);
			ExecuteStackContainer.NativeMethodInfoPtr_Head_Public_Nullable_1_ValueTuple_2_Action_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, 100668465);
			ExecuteStackContainer.NativeMethodInfoPtr_Tail_Public_ExecuteStackContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, 100668466);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00074CE4 File Offset: 0x00072EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593846, XrefRangeEnd = 593849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStackContainer(Nullable<ValueTuple<Action, IEnumerator<Action>>> head, ExecuteStackContainer tail)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(head));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_ValueTuple_2_Action_IEnumerator_1_Action_ExecuteStackContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00074D48 File Offset: 0x00072F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593849, XrefRangeEnd = 593853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStackContainer(ExecuteStackContainer original)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer.NativeMethodInfoPtr__ctor_Public_Void_ExecuteStackContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00074D94 File Offset: 0x00072F94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 593859, RefRangeEnd = 593863, XrefRangeStart = 593853, XrefRangeEnd = 593859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> StackActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer.NativeMethodInfoPtr_StackActions_Public_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00074DD4 File Offset: 0x00072FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593863, XrefRangeEnd = 593864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00074E10 File Offset: 0x00073010
		[CallerCount(0)]
		public unsafe Nullable<ValueTuple<Action, IEnumerator<Action>>> Head()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer.NativeMethodInfoPtr_Head_Public_Nullable_1_ValueTuple_2_Action_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<ValueTuple<Action, IEnumerator<Action>>>(intPtr);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00074E48 File Offset: 0x00073048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593864, XrefRangeEnd = 593868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStackContainer Tail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer.NativeMethodInfoPtr_Tail_Public_ExecuteStackContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr3) : null;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0000AE71 File Offset: 0x00009071
		public ExecuteStackContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00074E88 File Offset: 0x00073088
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000AE7A File Offset: 0x0000907A
		public Nullable<ValueTuple<Action, IEnumerator<Action>>> head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer.NativeFieldInfoPtr_head);
				return new Nullable<ValueTuple<Action, IEnumerator<Action>>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ValueTuple<Action, IEnumerator<Action>>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer.NativeFieldInfoPtr_head), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ValueTuple<Action, IEnumerator<Action>>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00074EB8 File Offset: 0x000730B8
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0000AEA8 File Offset: 0x000090A8
		public unsafe ExecuteStackContainer tail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer.NativeFieldInfoPtr_tail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer.NativeFieldInfoPtr_tail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00074EE8 File Offset: 0x000730E8
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0000AEC7 File Offset: 0x000090C7
		public unsafe static ExecuteStackContainer Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteStackContainer.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteStackContainer.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr_tail;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_ValueTuple_2_Action_IEnumerator_1_Action_ExecuteStackContainer_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExecuteStackContainer_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_StackActions_Public_IEnumerable_1_Action_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_Head_Public_Nullable_1_ValueTuple_2_Action_IEnumerator_1_Action_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_Tail_Public_ExecuteStackContainer_0;

		// Token: 0x02000466 RID: 1126
		[ObfuscatedName("Canis.actions.continuations.ExecuteStackContainer+<StackActions>d__5")]
		public sealed class _StackActions_d__5 : Object
		{
			// Token: 0x0600324A RID: 12874 RVA: 0x000CEE38 File Offset: 0x000CD038
			// Note: this type is marked as 'beforefieldinit'.
			static _StackActions_d__5()
			{
				Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteStackContainer>.NativeClassPtr, "<StackActions>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr);
				ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, "<>1__state");
				ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, "<>2__current");
				ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, "<>4__this");
				ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr__localTail_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, "<localTail>5__2");
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668468);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668469);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668470);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668471);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668472);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668473);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668474);
				ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr, 100668475);
			}

			// Token: 0x0600324B RID: 12875 RVA: 0x000CEF68 File Offset: 0x000CD168
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StackActions_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteStackContainer._StackActions_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600324C RID: 12876 RVA: 0x000CEFB0 File Offset: 0x000CD1B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600324D RID: 12877 RVA: 0x000CEFE4 File Offset: 0x000CD1E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593837, XrefRangeEnd = 593839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D53 RID: 3411
			// (get) Token: 0x0600324E RID: 12878 RVA: 0x000CF020 File Offset: 0x000CD220
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600324F RID: 12879 RVA: 0x000CF060 File Offset: 0x000CD260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593839, XrefRangeEnd = 593844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D54 RID: 3412
			// (get) Token: 0x06003250 RID: 12880 RVA: 0x000CF094 File Offset: 0x000CD294
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003251 RID: 12881 RVA: 0x000CF0D4 File Offset: 0x000CD2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593844, XrefRangeEnd = 593846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003252 RID: 12882 RVA: 0x000CF114 File Offset: 0x000CD314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStackContainer._StackActions_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003253 RID: 12883 RVA: 0x000181CE File Offset: 0x000163CE
			public _StackActions_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D4E RID: 3406
			// (get) Token: 0x06003254 RID: 12884 RVA: 0x000CF154 File Offset: 0x000CD354
			// (set) Token: 0x06003255 RID: 12885 RVA: 0x000181D7 File Offset: 0x000163D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D4F RID: 3407
			// (get) Token: 0x06003256 RID: 12886 RVA: 0x000CF17C File Offset: 0x000CD37C
			// (set) Token: 0x06003257 RID: 12887 RVA: 0x000181F2 File Offset: 0x000163F2
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D50 RID: 3408
			// (get) Token: 0x06003258 RID: 12888 RVA: 0x000CF1AC File Offset: 0x000CD3AC
			// (set) Token: 0x06003259 RID: 12889 RVA: 0x00018211 File Offset: 0x00016411
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D51 RID: 3409
			// (get) Token: 0x0600325A RID: 12890 RVA: 0x000CF1D4 File Offset: 0x000CD3D4
			// (set) Token: 0x0600325B RID: 12891 RVA: 0x0001822C File Offset: 0x0001642C
			public unsafe ExecuteStackContainer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D52 RID: 3410
			// (get) Token: 0x0600325C RID: 12892 RVA: 0x000CF204 File Offset: 0x000CD404
			// (set) Token: 0x0600325D RID: 12893 RVA: 0x0001824B File Offset: 0x0001644B
			public unsafe ExecuteStackContainer _localTail_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr__localTail_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStackContainer._StackActions_d__5.NativeFieldInfoPtr__localTail_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F72 RID: 8050
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F73 RID: 8051
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F74 RID: 8052
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F75 RID: 8053
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F76 RID: 8054
			private static readonly IntPtr NativeFieldInfoPtr__localTail_5__2;

			// Token: 0x04001F77 RID: 8055
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F78 RID: 8056
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F79 RID: 8057
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F7A RID: 8058
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001F7B RID: 8059
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F7C RID: 8060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F7D RID: 8061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001F7E RID: 8062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
