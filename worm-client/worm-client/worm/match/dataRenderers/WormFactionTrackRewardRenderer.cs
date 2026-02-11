using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000126 RID: 294
	public class WormFactionTrackRewardRenderer : Observer
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x00040CD4 File Offset: 0x0003EED4
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionTrackRewardRenderer()
		{
			Il2CppClassPointerStore<WormFactionTrackRewardRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFactionTrackRewardRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrackRewardRenderer>.NativeClassPtr);
			WormFactionTrackRewardRenderer.NativeFieldInfoPtr_vpReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackRewardRenderer>.NativeClassPtr, "vpReward");
			WormFactionTrackRewardRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackRewardRenderer>.NativeClassPtr, 100665132);
			WormFactionTrackRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackRewardRenderer>.NativeClassPtr, 100665133);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00040D40 File Offset: 0x0003EF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705650, XrefRangeEnd = 705675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrackRewardRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00040D7C File Offset: 0x0003EF7C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrackRewardRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrackRewardRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00009210 File Offset: 0x00007410
		public WormFactionTrackRewardRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00009219 File Offset: 0x00007419
		public unsafe GameObject vpReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackRewardRenderer.NativeFieldInfoPtr_vpReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackRewardRenderer.NativeFieldInfoPtr_vpReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_vpReward;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
