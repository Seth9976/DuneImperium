using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000113 RID: 275
	public class WormDisabledRenderer : VersionedDataComponentObserver<WormDisabledData>
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		// Note: this type is marked as 'beforefieldinit'.
		static WormDisabledRenderer()
		{
			Il2CppClassPointerStore<WormDisabledRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormDisabledRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDisabledRenderer>.NativeClassPtr);
			WormDisabledRenderer.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDisabledRenderer>.NativeClassPtr, "selectable");
			WormDisabledRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledRenderer>.NativeClassPtr, 100665044);
			WormDisabledRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledRenderer>.NativeClassPtr, 100665045);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0003EC14 File Offset: 0x0003CE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704862, XrefRangeEnd = 704867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDisabledRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003EC50 File Offset: 0x0003CE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704867, XrefRangeEnd = 704870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDisabledRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDisabledRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisabledRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00008B8E File Offset: 0x00006D8E
		public WormDisabledRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0003EC8C File Offset: 0x0003CE8C
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00008B97 File Offset: 0x00006D97
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledRenderer.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledRenderer.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
