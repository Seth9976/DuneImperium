using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000231 RID: 561
	public class SerializedClearAgentAttributes : SerializedAction
	{
		// Token: 0x0600189A RID: 6298 RVA: 0x000B8AD0 File Offset: 0x000B6CD0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedClearAgentAttributes()
		{
			Il2CppClassPointerStore<SerializedClearAgentAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedClearAgentAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedClearAgentAttributes>.NativeClassPtr);
			SerializedClearAgentAttributes.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedClearAgentAttributes>.NativeClassPtr, 100667561);
			SerializedClearAgentAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedClearAgentAttributes>.NativeClassPtr, 100667562);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000B8B28 File Offset: 0x000B6D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132508, XrefRangeEnd = 132512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedClearAgentAttributes.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000B8B84 File Offset: 0x000B6D84
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedClearAgentAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedClearAgentAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedClearAgentAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public SerializedClearAgentAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
