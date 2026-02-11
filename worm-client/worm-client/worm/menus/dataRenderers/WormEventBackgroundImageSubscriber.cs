using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000083 RID: 131
	public class WormEventBackgroundImageSubscriber : Subscriber<WormEventData>
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x00028464 File Offset: 0x00026664
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventBackgroundImageSubscriber()
		{
			Il2CppClassPointerStore<WormEventBackgroundImageSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventBackgroundImageSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventBackgroundImageSubscriber>.NativeClassPtr);
			WormEventBackgroundImageSubscriber.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventBackgroundImageSubscriber>.NativeClassPtr, "image");
			WormEventBackgroundImageSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventBackgroundImageSubscriber>.NativeClassPtr, 100664028);
			WormEventBackgroundImageSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventBackgroundImageSubscriber>.NativeClassPtr, 100664029);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000284D0 File Offset: 0x000266D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694672, XrefRangeEnd = 694676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventBackgroundImageSubscriber.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002850C File Offset: 0x0002670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694676, XrefRangeEnd = 694679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventBackgroundImageSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventBackgroundImageSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventBackgroundImageSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000047C5 File Offset: 0x000029C5
		public WormEventBackgroundImageSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00028548 File Offset: 0x00026748
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000047CE File Offset: 0x000029CE
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventBackgroundImageSubscriber.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventBackgroundImageSubscriber.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
