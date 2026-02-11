using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000103 RID: 259
	public class WormCarefulObservationStingerRenderer : Observer
	{
		// Token: 0x06000B97 RID: 2967 RVA: 0x0003B31C File Offset: 0x0003951C
		// Note: this type is marked as 'beforefieldinit'.
		static WormCarefulObservationStingerRenderer()
		{
			Il2CppClassPointerStore<WormCarefulObservationStingerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCarefulObservationStingerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCarefulObservationStingerRenderer>.NativeClassPtr);
			WormCarefulObservationStingerRenderer.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCarefulObservationStingerRenderer>.NativeClassPtr, "rewards");
			WormCarefulObservationStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCarefulObservationStingerRenderer>.NativeClassPtr, 100664892);
			WormCarefulObservationStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCarefulObservationStingerRenderer>.NativeClassPtr, 100664893);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0003B388 File Offset: 0x00039588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703322, XrefRangeEnd = 703344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCarefulObservationStingerRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0003B3C4 File Offset: 0x000395C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703344, XrefRangeEnd = 703349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCarefulObservationStingerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCarefulObservationStingerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCarefulObservationStingerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000081D1 File Offset: 0x000063D1
		public WormCarefulObservationStingerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0003B400 File Offset: 0x00039600
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000081DA File Offset: 0x000063DA
		public unsafe Il2CppReferenceArray<GameObject> rewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCarefulObservationStingerRenderer.NativeFieldInfoPtr_rewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCarefulObservationStingerRenderer.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_rewards;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
