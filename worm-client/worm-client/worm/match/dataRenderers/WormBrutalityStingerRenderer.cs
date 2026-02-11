using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x020000FE RID: 254
	public class WormBrutalityStingerRenderer : Observer
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x0003A864 File Offset: 0x00038A64
		// Note: this type is marked as 'beforefieldinit'.
		static WormBrutalityStingerRenderer()
		{
			Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormBrutalityStingerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr);
			WormBrutalityStingerRenderer.NativeFieldInfoPtr_oneTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr, "oneTroop");
			WormBrutalityStingerRenderer.NativeFieldInfoPtr_twoTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr, "twoTroops");
			WormBrutalityStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr, 100664866);
			WormBrutalityStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr, 100664867);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0003A8E4 File Offset: 0x00038AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703071, XrefRangeEnd = 703093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBrutalityStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0003A920 File Offset: 0x00038B20
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBrutalityStingerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBrutalityStingerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBrutalityStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00007F92 File Offset: 0x00006192
		public WormBrutalityStingerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0003A95C File Offset: 0x00038B5C
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00007F9B File Offset: 0x0000619B
		public unsafe GameObject oneTroop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityStingerRenderer.NativeFieldInfoPtr_oneTroop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityStingerRenderer.NativeFieldInfoPtr_oneTroop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0003A98C File Offset: 0x00038B8C
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00007FBA File Offset: 0x000061BA
		public unsafe GameObject twoTroops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityStingerRenderer.NativeFieldInfoPtr_twoTroops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBrutalityStingerRenderer.NativeFieldInfoPtr_twoTroops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_oneTroop;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_twoTroops;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
