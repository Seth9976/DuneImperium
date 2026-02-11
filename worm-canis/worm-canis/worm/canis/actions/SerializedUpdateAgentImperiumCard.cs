using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002AA RID: 682
	public class SerializedUpdateAgentImperiumCard : SerializedAction
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x000C6714 File Offset: 0x000C4914
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedUpdateAgentImperiumCard()
		{
			Il2CppClassPointerStore<SerializedUpdateAgentImperiumCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedUpdateAgentImperiumCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedUpdateAgentImperiumCard>.NativeClassPtr);
			SerializedUpdateAgentImperiumCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUpdateAgentImperiumCard>.NativeClassPtr, 100669063);
			SerializedUpdateAgentImperiumCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUpdateAgentImperiumCard>.NativeClassPtr, 100669064);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000C676C File Offset: 0x000C496C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149889, XrefRangeEnd = 149893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedUpdateAgentImperiumCard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000C67C8 File Offset: 0x000C49C8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedUpdateAgentImperiumCard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedUpdateAgentImperiumCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedUpdateAgentImperiumCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0000BF58 File Offset: 0x0000A158
		public SerializedUpdateAgentImperiumCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
