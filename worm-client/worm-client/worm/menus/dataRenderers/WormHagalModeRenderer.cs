using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000090 RID: 144
	public class WormHagalModeRenderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x00029E48 File Offset: 0x00028048
		// Note: this type is marked as 'beforefieldinit'.
		static WormHagalModeRenderer()
		{
			Il2CppClassPointerStore<WormHagalModeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormHagalModeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalModeRenderer>.NativeClassPtr);
			WormHagalModeRenderer.NativeFieldInfoPtr_hagalIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHagalModeRenderer>.NativeClassPtr, "hagalIcon");
			WormHagalModeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalModeRenderer>.NativeClassPtr, 100664111);
			WormHagalModeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalModeRenderer>.NativeClassPtr, 100664112);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00029EB4 File Offset: 0x000280B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695449, XrefRangeEnd = 695460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormHagalModeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00029EF0 File Offset: 0x000280F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695460, XrefRangeEnd = 695463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHagalModeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHagalModeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalModeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00004CBF File Offset: 0x00002EBF
		public WormHagalModeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00029F2C File Offset: 0x0002812C
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00004CC8 File Offset: 0x00002EC8
		public unsafe GameObject hagalIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalModeRenderer.NativeFieldInfoPtr_hagalIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHagalModeRenderer.NativeFieldInfoPtr_hagalIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_hagalIcon;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
