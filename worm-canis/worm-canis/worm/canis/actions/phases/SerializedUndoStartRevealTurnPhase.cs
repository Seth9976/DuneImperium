using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D4 RID: 724
	public class SerializedUndoStartRevealTurnPhase : SerializedAction
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x000CD4BC File Offset: 0x000CB6BC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedUndoStartRevealTurnPhase()
		{
			Il2CppClassPointerStore<SerializedUndoStartRevealTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedUndoStartRevealTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedUndoStartRevealTurnPhase>.NativeClassPtr);
			SerializedUndoStartRevealTurnPhase.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUndoStartRevealTurnPhase>.NativeClassPtr, 100670012);
			SerializedUndoStartRevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUndoStartRevealTurnPhase>.NativeClassPtr, 100670013);
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x000CD514 File Offset: 0x000CB714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164355, XrefRangeEnd = 164359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedUndoStartRevealTurnPhase.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000CD570 File Offset: 0x000CB770
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedUndoStartRevealTurnPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedUndoStartRevealTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedUndoStartRevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0000C8D6 File Offset: 0x0000AAD6
		public SerializedUndoStartRevealTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
