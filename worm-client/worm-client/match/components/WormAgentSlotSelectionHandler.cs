using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm_client.match.components
{
	// Token: 0x02000030 RID: 48
	public class WormAgentSlotSelectionHandler : MonoBehaviour
	{
		// Token: 0x06000212 RID: 530 RVA: 0x0001F724 File Offset: 0x0001D924
		// Note: this type is marked as 'beforefieldinit'.
		static WormAgentSlotSelectionHandler()
		{
			Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm_client.match.components", "WormAgentSlotSelectionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr);
			WormAgentSlotSelectionHandler.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr, "slot");
			WormAgentSlotSelectionHandler.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr, "selectable");
			WormAgentSlotSelectionHandler.NativeMethodInfoPtr_Event_OnSlotChildrenChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr, 100663665);
			WormAgentSlotSelectionHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr, 100663666);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001F7A4 File Offset: 0x0001D9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689881, XrefRangeEnd = 689884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnSlotChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSlotSelectionHandler.NativeMethodInfoPtr_Event_OnSlotChildrenChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgentSlotSelectionHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentSlotSelectionHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentSlotSelectionHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002F5B File Offset: 0x0000115B
		public WormAgentSlotSelectionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0001F814 File Offset: 0x0001DA14
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002F64 File Offset: 0x00001164
		public unsafe Transform slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSlotSelectionHandler.NativeFieldInfoPtr_slot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSlotSelectionHandler.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001F844 File Offset: 0x0001DA44
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002F83 File Offset: 0x00001183
		public unsafe GameObject selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSlotSelectionHandler.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAgentSlotSelectionHandler.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_slot;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnSlotChildrenChanged_Public_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
