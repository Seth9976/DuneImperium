using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B3 RID: 691
	public class SerializedUndoStartAgentTurnPhase : SerializedAction
	{
		// Token: 0x06001C9C RID: 7324 RVA: 0x000C8178 File Offset: 0x000C6378
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedUndoStartAgentTurnPhase()
		{
			Il2CppClassPointerStore<SerializedUndoStartAgentTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedUndoStartAgentTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedUndoStartAgentTurnPhase>.NativeClassPtr);
			SerializedUndoStartAgentTurnPhase.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUndoStartAgentTurnPhase>.NativeClassPtr, 100669293);
			SerializedUndoStartAgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUndoStartAgentTurnPhase>.NativeClassPtr, 100669294);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000C81D0 File Offset: 0x000C63D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152573, XrefRangeEnd = 152577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedUndoStartAgentTurnPhase.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000C822C File Offset: 0x000C642C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedUndoStartAgentTurnPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedUndoStartAgentTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedUndoStartAgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0000C21B File Offset: 0x0000A41B
		public SerializedUndoStartAgentTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
