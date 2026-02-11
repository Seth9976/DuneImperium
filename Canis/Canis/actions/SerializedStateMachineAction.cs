using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001ED RID: 493
	public class SerializedStateMachineAction : SerializedAction
	{
		// Token: 0x060014CC RID: 5324 RVA: 0x0006D1D4 File Offset: 0x0006B3D4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedStateMachineAction()
		{
			Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedStateMachineAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr);
			SerializedStateMachineAction.NativeFieldInfoPtr_InitialState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr, "InitialState");
			SerializedStateMachineAction.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr, "CurrentState");
			SerializedStateMachineAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr, 100667904);
			SerializedStateMachineAction.NativeMethodInfoPtr_GenStateMachineAction_Protected_Abstract_Virtual_New_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr, 100667905);
			SerializedStateMachineAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr, 100667906);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0006D268 File Offset: 0x0006B468
		[CallerCount(0)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedStateMachineAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0006D2B8 File Offset: 0x0006B4B8
		[CallerCount(0)]
		public unsafe virtual StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedStateMachineAction.NativeMethodInfoPtr_GenStateMachineAction_Protected_Abstract_Virtual_New_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0006D314 File Offset: 0x0006B514
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedStateMachineAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedStateMachineAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedStateMachineAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0000A1CC File Offset: 0x000083CC
		public SerializedStateMachineAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0006D350 File Offset: 0x0006B550
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000A1D5 File Offset: 0x000083D5
		public unsafe int InitialState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineAction.NativeFieldInfoPtr_InitialState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineAction.NativeFieldInfoPtr_InitialState)) = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0006D378 File Offset: 0x0006B578
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0000A1F0 File Offset: 0x000083F0
		public unsafe int CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineAction.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineAction.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeFieldInfoPtr_InitialState;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Abstract_Virtual_New_StateMachineAction_Match_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
