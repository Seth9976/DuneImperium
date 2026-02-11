using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001F0 RID: 496
	public class SerializedStateMachineActionV2 : SerializedAction
	{
		// Token: 0x060014FB RID: 5371 RVA: 0x0006DF8C File Offset: 0x0006C18C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedStateMachineActionV2()
		{
			Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedStateMachineActionV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr);
			SerializedStateMachineActionV2.NativeFieldInfoPtr_InitialState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr, "InitialState");
			SerializedStateMachineActionV2.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr, "CurrentState");
			SerializedStateMachineActionV2.NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr, 100667965);
			SerializedStateMachineActionV2.NativeMethodInfoPtr_GenStateMachineAction_Protected_Abstract_Virtual_New_StateMachineActionV2_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr, 100667966);
			SerializedStateMachineActionV2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr, 100667967);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0006E020 File Offset: 0x0006C220
		[CallerCount(0)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedStateMachineActionV2.NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0006E070 File Offset: 0x0006C270
		[CallerCount(0)]
		public unsafe virtual StateMachineActionV2 GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedStateMachineActionV2.NativeMethodInfoPtr_GenStateMachineAction_Protected_Abstract_Virtual_New_StateMachineActionV2_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2>(intPtr3) : null;
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedStateMachineActionV2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedStateMachineActionV2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedStateMachineActionV2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0000A2A3 File Offset: 0x000084A3
		public SerializedStateMachineActionV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0006E108 File Offset: 0x0006C308
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0000A2AC File Offset: 0x000084AC
		public unsafe int InitialState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineActionV2.NativeFieldInfoPtr_InitialState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineActionV2.NativeFieldInfoPtr_InitialState)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0006E130 File Offset: 0x0006C330
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x0000A2C7 File Offset: 0x000084C7
		public unsafe int CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineActionV2.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedStateMachineActionV2.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeFieldInfoPtr_InitialState;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Final_Action_Match_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Abstract_Virtual_New_StateMachineActionV2_Match_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
