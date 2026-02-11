using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000114 RID: 276
	public class WormDisabledSubscriber : VersionedSubscriber<WormDisabledData>
	{
		// Token: 0x06000CBD RID: 3261 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		// Note: this type is marked as 'beforefieldinit'.
		static WormDisabledSubscriber()
		{
			Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormDisabledSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr);
			WormDisabledSubscriber.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr, "display");
			WormDisabledSubscriber.NativeFieldInfoPtr_showOnDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr, "showOnDisabled");
			WormDisabledSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr, 100665046);
			WormDisabledSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr, 100665047);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003ED3C File Offset: 0x0003CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704870, XrefRangeEnd = 704873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDisabledSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0003ED78 File Offset: 0x0003CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704873, XrefRangeEnd = 704876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDisabledSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDisabledSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDisabledSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00008BB6 File Offset: 0x00006DB6
		public WormDisabledSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x00008BBF File Offset: 0x00006DBF
		public unsafe GameObject display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledSubscriber.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledSubscriber.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00008BDE File Offset: 0x00006DDE
		public unsafe bool showOnDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledSubscriber.NativeFieldInfoPtr_showOnDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDisabledSubscriber.NativeFieldInfoPtr_showOnDisabled)) = value;
			}
		}

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_showOnDisabled;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
