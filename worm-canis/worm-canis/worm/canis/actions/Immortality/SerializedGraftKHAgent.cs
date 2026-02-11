using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002E7 RID: 743
	public class SerializedGraftKHAgent : SerializedAction
	{
		// Token: 0x06001EA4 RID: 7844 RVA: 0x000D05C8 File Offset: 0x000CE7C8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGraftKHAgent()
		{
			Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedGraftKHAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr);
			SerializedGraftKHAgent.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr, "PlayerID");
			SerializedGraftKHAgent.NativeFieldInfoPtr_KHAgentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr, "KHAgentID");
			SerializedGraftKHAgent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr, 100670485);
			SerializedGraftKHAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr, 100670486);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000D0648 File Offset: 0x000CE848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171579, XrefRangeEnd = 171591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGraftKHAgent.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000D06A4 File Offset: 0x000CE8A4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGraftKHAgent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGraftKHAgent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGraftKHAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0000CDC1 File Offset: 0x0000AFC1
		public SerializedGraftKHAgent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000D06E0 File Offset: 0x000CE8E0
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x0000CDCA File Offset: 0x0000AFCA
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftKHAgent.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftKHAgent.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x000D0710 File Offset: 0x000CE910
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0000CDE9 File Offset: 0x0000AFE9
		public unsafe EntityID KHAgentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftKHAgent.NativeFieldInfoPtr_KHAgentID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGraftKHAgent.NativeFieldInfoPtr_KHAgentID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeFieldInfoPtr_KHAgentID;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
