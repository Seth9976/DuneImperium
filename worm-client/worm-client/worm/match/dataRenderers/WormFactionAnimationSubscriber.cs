using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000122 RID: 290
	public class WormFactionAnimationSubscriber : VersionedSubscriber<WormFactionData>
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x00040578 File Offset: 0x0003E778
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionAnimationSubscriber()
		{
			Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFactionAnimationSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr);
			WormFactionAnimationSubscriber.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr, "animator");
			WormFactionAnimationSubscriber.NativeFieldInfoPtr_FactionParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr, "FactionParam");
			WormFactionAnimationSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr, 100665117);
			WormFactionAnimationSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr, 100665118);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000405F8 File Offset: 0x0003E7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705498, XrefRangeEnd = 705506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionAnimationSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00040634 File Offset: 0x0003E834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705506, XrefRangeEnd = 705509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionAnimationSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionAnimationSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAnimationSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0000907B File Offset: 0x0000727B
		public WormFactionAnimationSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00040670 File Offset: 0x0003E870
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00009084 File Offset: 0x00007284
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAnimationSubscriber.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAnimationSubscriber.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x000406A0 File Offset: 0x0003E8A0
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x000090A3 File Offset: 0x000072A3
		public unsafe static int FactionParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormFactionAnimationSubscriber.NativeFieldInfoPtr_FactionParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFactionAnimationSubscriber.NativeFieldInfoPtr_FactionParam, (void*)(&value));
			}
		}

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_FactionParam;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
