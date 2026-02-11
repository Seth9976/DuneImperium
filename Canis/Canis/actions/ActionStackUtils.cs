using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001E9 RID: 489
	public static class ActionStackUtils : Object
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x0000A112 File Offset: 0x00008312
		// Note: this type is marked as 'beforefieldinit'.
		static ActionStackUtils()
		{
			Il2CppClassPointerStore<ActionStackUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ActionStackUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionStackUtils>.NativeClassPtr);
			ActionStackUtils.NativeMethodInfoPtr_StackMoveNext_Public_Static_ValueTuple_2_Boolean_Action_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionStackUtils>.NativeClassPtr, 100667872);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0006CD04 File Offset: 0x0006AF04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 589805, RefRangeEnd = 589808, XrefRangeStart = 589787, XrefRangeEnd = 589805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<bool, Action> StackMoveNext(this Stack<ValueTuple<Action, IEnumerator<Action>>> actionStack)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionStack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionStackUtils.NativeMethodInfoPtr_StackMoveNext_Public_Static_ValueTuple_2_Boolean_Action_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, Action>(intPtr);
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0000A14B File Offset: 0x0000834B
		public ActionStackUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_StackMoveNext_Public_Static_ValueTuple_2_Boolean_Action_Stack_1_ValueTuple_2_Action_IEnumerator_1_Action_0;
	}
}
