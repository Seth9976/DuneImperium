using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200022F RID: 559
	public class SerializedClearActiveAgentArea : SerializedAction
	{
		// Token: 0x06001890 RID: 6288 RVA: 0x000B8810 File Offset: 0x000B6A10
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedClearActiveAgentArea()
		{
			Il2CppClassPointerStore<SerializedClearActiveAgentArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedClearActiveAgentArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedClearActiveAgentArea>.NativeClassPtr);
			SerializedClearActiveAgentArea.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedClearActiveAgentArea>.NativeClassPtr, 100667539);
			SerializedClearActiveAgentArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedClearActiveAgentArea>.NativeClassPtr, 100667540);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000B8868 File Offset: 0x000B6A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132404, XrefRangeEnd = 132408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedClearActiveAgentArea.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x000B88C4 File Offset: 0x000B6AC4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedClearActiveAgentArea()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedClearActiveAgentArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedClearActiveAgentArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0000A9D6 File Offset: 0x00008BD6
		public SerializedClearActiveAgentArea(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
