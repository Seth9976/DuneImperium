using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x02000226 RID: 550
	public class SerializedExecuteStack : Object
	{
		// Token: 0x060016E8 RID: 5864 RVA: 0x000754C0 File Offset: 0x000736C0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedExecuteStack()
		{
			Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "SerializedExecuteStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr);
			SerializedExecuteStack.NativeFieldInfoPtr_StackActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr, "StackActions");
			SerializedExecuteStack.NativeMethodInfoPtr_Deserialize_Public_ExecuteStack_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr, 100668496);
			SerializedExecuteStack.NativeMethodInfoPtr_TuplesToExecuteStackContainer_Public_ExecuteStackContainer_List_1_ValueTuple_2_Action_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr, 100668497);
			SerializedExecuteStack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr, 100668498);
			SerializedExecuteStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr, 100668499);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00075554 File Offset: 0x00073754
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 594182, RefRangeEnd = 594186, XrefRangeStart = 594158, XrefRangeEnd = 594182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStack Deserialize(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedExecuteStack.NativeMethodInfoPtr_Deserialize_Public_ExecuteStack_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
			}
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000755A4 File Offset: 0x000737A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 594209, RefRangeEnd = 594211, XrefRangeStart = 594186, XrefRangeEnd = 594209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStackContainer TuplesToExecuteStackContainer(List<ValueTuple<Action, IEnumerator<Action>>> tuples)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tuples);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedExecuteStack.NativeMethodInfoPtr_TuplesToExecuteStackContainer_Public_ExecuteStackContainer_List_1_ValueTuple_2_Action_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr3) : null;
			}
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x000755F4 File Offset: 0x000737F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594211, XrefRangeEnd = 594222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedExecuteStack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00075638 File Offset: 0x00073838
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedExecuteStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedExecuteStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0000AF20 File Offset: 0x00009120
		public SerializedExecuteStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00075674 File Offset: 0x00073874
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0000AF29 File Offset: 0x00009129
		public unsafe Il2CppReferenceArray<SerializedAction> StackActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedExecuteStack.NativeFieldInfoPtr_StackActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedExecuteStack.NativeFieldInfoPtr_StackActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_StackActions;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_ExecuteStack_Match_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_TuplesToExecuteStackContainer_Public_ExecuteStackContainer_List_1_ValueTuple_2_Action_IEnumerator_1_Action_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200046A RID: 1130
		[ObfuscatedName("Canis.actions.continuations.SerializedExecuteStack+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06003272 RID: 12914 RVA: 0x000CF60C File Offset: 0x000CD80C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SerializedExecuteStack.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedExecuteStack>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedExecuteStack.__c__DisplayClass1_0>.NativeClassPtr);
				SerializedExecuteStack.__c__DisplayClass1_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedExecuteStack.__c__DisplayClass1_0>.NativeClassPtr, "match");
				SerializedExecuteStack.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedExecuteStack.__c__DisplayClass1_0>.NativeClassPtr, 100668500);
				SerializedExecuteStack.__c__DisplayClass1_0.NativeMethodInfoPtr__Deserialize_b__0_Internal_ValueTuple_2_Action_IEnumerator_1_Action_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedExecuteStack.__c__DisplayClass1_0>.NativeClassPtr, 100668501);
			}

			// Token: 0x06003273 RID: 12915 RVA: 0x000CF674 File Offset: 0x000CD874
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedExecuteStack.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedExecuteStack.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003274 RID: 12916 RVA: 0x000CF6B0 File Offset: 0x000CD8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594153, XrefRangeEnd = 594158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Action, IEnumerator<Action>> _Deserialize_b__0(SerializedAction sa)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedExecuteStack.__c__DisplayClass1_0.NativeMethodInfoPtr__Deserialize_b__0_Internal_ValueTuple_2_Action_IEnumerator_1_Action_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<Action, IEnumerator<Action>>(intPtr);
				}
			}

			// Token: 0x06003275 RID: 12917 RVA: 0x000182D6 File Offset: 0x000164D6
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D5A RID: 3418
			// (get) Token: 0x06003276 RID: 12918 RVA: 0x000CF6F8 File Offset: 0x000CD8F8
			// (set) Token: 0x06003277 RID: 12919 RVA: 0x000182DF File Offset: 0x000164DF
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedExecuteStack.__c__DisplayClass1_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedExecuteStack.__c__DisplayClass1_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F8A RID: 8074
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F8B RID: 8075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F8C RID: 8076
			private static readonly IntPtr NativeMethodInfoPtr__Deserialize_b__0_Internal_ValueTuple_2_Action_IEnumerator_1_Action_SerializedAction_0;
		}
	}
}
