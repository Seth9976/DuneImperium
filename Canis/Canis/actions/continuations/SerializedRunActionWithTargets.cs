using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions.continuations
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public class SerializedRunActionWithTargets : SerializedAction
	{
		// Token: 0x06001710 RID: 5904 RVA: 0x00075E0C File Offset: 0x0007400C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRunActionWithTargets()
		{
			Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "SerializedRunActionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr);
			SerializedRunActionWithTargets.NativeFieldInfoPtr_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr, "Stack");
			SerializedRunActionWithTargets.NativeFieldInfoPtr_ContinuationActs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr, "ContinuationActs");
			SerializedRunActionWithTargets.NativeFieldInfoPtr_CurrentTargetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr, "CurrentTargetIndex");
			SerializedRunActionWithTargets.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr, 100668539);
			SerializedRunActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr, 100668540);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00075EA0 File Offset: 0x000740A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594420, XrefRangeEnd = 594428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRunActionWithTargets.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00075EFC File Offset: 0x000740FC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRunActionWithTargets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRunActionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRunActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0000B061 File Offset: 0x00009261
		public SerializedRunActionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00075F38 File Offset: 0x00074138
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x0000B06A File Offset: 0x0000926A
		public unsafe SerializedExecuteStack Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunActionWithTargets.NativeFieldInfoPtr_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedExecuteStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunActionWithTargets.NativeFieldInfoPtr_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00075F68 File Offset: 0x00074168
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000B089 File Offset: 0x00009289
		public unsafe SerializedActionAcrossTargets ContinuationActs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunActionWithTargets.NativeFieldInfoPtr_ContinuationActs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedActionAcrossTargets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunActionWithTargets.NativeFieldInfoPtr_ContinuationActs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00075F98 File Offset: 0x00074198
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000B0A8 File Offset: 0x000092A8
		public unsafe int CurrentTargetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunActionWithTargets.NativeFieldInfoPtr_CurrentTargetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRunActionWithTargets.NativeFieldInfoPtr_CurrentTargetIndex)) = value;
			}
		}

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeFieldInfoPtr_Stack;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeFieldInfoPtr_ContinuationActs;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTargetIndex;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
