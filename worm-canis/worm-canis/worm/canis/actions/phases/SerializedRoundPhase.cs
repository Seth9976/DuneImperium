using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D7 RID: 727
	public class SerializedRoundPhase : SerializedStateMachineAction
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x000CDB4C File Offset: 0x000CBD4C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRoundPhase()
		{
			Il2CppClassPointerStore<SerializedRoundPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedRoundPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRoundPhase>.NativeClassPtr);
			SerializedRoundPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRoundPhase>.NativeClassPtr, 100670110);
			SerializedRoundPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRoundPhase>.NativeClassPtr, 100670111);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x000CDBA4 File Offset: 0x000CBDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166671, XrefRangeEnd = 166683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRoundPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000CDC00 File Offset: 0x000CBE00
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRoundPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRoundPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRoundPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0000C907 File Offset: 0x0000AB07
		public SerializedRoundPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
