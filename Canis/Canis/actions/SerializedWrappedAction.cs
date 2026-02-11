using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001F7 RID: 503
	public class SerializedWrappedAction : SerializedStateMachineAction
	{
		// Token: 0x06001553 RID: 5459 RVA: 0x0006F8A4 File Offset: 0x0006DAA4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedWrappedAction()
		{
			Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedWrappedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr);
			SerializedWrappedAction.NativeFieldInfoPtr_WrappedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr, "WrappedActions");
			SerializedWrappedAction.NativeFieldInfoPtr_ActionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr, "ActionIndex");
			SerializedWrappedAction.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_Final_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr, 100668104);
			SerializedWrappedAction.NativeMethodInfoPtr_GenWrappedAction_Protected_Abstract_Virtual_New_WrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr, 100668105);
			SerializedWrappedAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr, 100668106);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0006F938 File Offset: 0x0006DB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590996, XrefRangeEnd = 591015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedWrappedAction.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_Final_StateMachineAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0006F988 File Offset: 0x0006DB88
		[CallerCount(0)]
		public unsafe virtual WrappedAction GenWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedWrappedAction.NativeMethodInfoPtr_GenWrappedAction_Protected_Abstract_Virtual_New_WrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0006F9E4 File Offset: 0x0006DBE4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedWrappedAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedWrappedAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedWrappedAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0000A4AA File Offset: 0x000086AA
		public SerializedWrappedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0006FA20 File Offset: 0x0006DC20
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x0000A4B3 File Offset: 0x000086B3
		public unsafe Il2CppReferenceArray<SerializedAction> WrappedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedWrappedAction.NativeFieldInfoPtr_WrappedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedWrappedAction.NativeFieldInfoPtr_WrappedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0006FA50 File Offset: 0x0006DC50
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000A4D2 File Offset: 0x000086D2
		public unsafe int ActionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedWrappedAction.NativeFieldInfoPtr_ActionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedWrappedAction.NativeFieldInfoPtr_ActionIndex)) = value;
			}
		}

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_WrappedActions;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_ActionIndex;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_Final_StateMachineAction_Match_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_GenWrappedAction_Protected_Abstract_Virtual_New_WrappedAction_Match_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
