using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000102 RID: 258
	public class WormCarefulObservationRenderer : VersionedView<IAttribute<List<Factions>>>
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x0003B1B8 File Offset: 0x000393B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormCarefulObservationRenderer()
		{
			Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCarefulObservationRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr);
			WormCarefulObservationRenderer.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr, "rewards");
			WormCarefulObservationRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr, 100664889);
			WormCarefulObservationRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr, 100664890);
			WormCarefulObservationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr, 100664891);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0003B238 File Offset: 0x00039438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703286, XrefRangeEnd = 703308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCarefulObservationRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0003B274 File Offset: 0x00039474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703308, XrefRangeEnd = 703315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCarefulObservationRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0003B2B0 File Offset: 0x000394B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703315, XrefRangeEnd = 703322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCarefulObservationRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCarefulObservationRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCarefulObservationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000081A9 File Offset: 0x000063A9
		public WormCarefulObservationRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0003B2EC File Offset: 0x000394EC
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x000081B2 File Offset: 0x000063B2
		public unsafe Il2CppReferenceArray<GameObject> rewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCarefulObservationRenderer.NativeFieldInfoPtr_rewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCarefulObservationRenderer.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr_rewards;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
