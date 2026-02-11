using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.menus.components
{
	// Token: 0x020000A4 RID: 164
	public class WormSetEvents : MonoBehaviour
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x0002C31C File Offset: 0x0002A51C
		// Note: this type is marked as 'beforefieldinit'.
		static WormSetEvents()
		{
			Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "WormSetEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr);
			WormSetEvents.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr, "set");
			WormSetEvents.NativeFieldInfoPtr_setEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr, "setEvents");
			WormSetEvents.NativeMethodInfoPtr_Event_FireEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr, 100664196);
			WormSetEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr, 100664197);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002C39C File Offset: 0x0002A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696298, XrefRangeEnd = 696302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_FireEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSetEvents.NativeMethodInfoPtr_Event_FireEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696302, XrefRangeEnd = 696310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSetEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSetEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSetEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00005341 File Offset: 0x00003541
		public WormSetEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0002C40C File Offset: 0x0002A60C
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000534A File Offset: 0x0000354A
		public unsafe Set set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSetEvents.NativeFieldInfoPtr_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSetEvents.NativeFieldInfoPtr_set)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0002C434 File Offset: 0x0002A634
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00005365 File Offset: 0x00003565
		public unsafe UnityEventForSet setEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSetEvents.NativeFieldInfoPtr_setEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventForSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSetEvents.NativeFieldInfoPtr_setEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_setEvents;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_Event_FireEvent_Public_Void_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
