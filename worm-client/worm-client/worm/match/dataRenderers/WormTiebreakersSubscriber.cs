using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x0200016C RID: 364
	public class WormTiebreakersSubscriber : VersionedSubscriber<WormShowTiebreakerData>
	{
		// Token: 0x0600103C RID: 4156 RVA: 0x00048CE8 File Offset: 0x00046EE8
		// Note: this type is marked as 'beforefieldinit'.
		static WormTiebreakersSubscriber()
		{
			Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormTiebreakersSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr);
			WormTiebreakersSubscriber.NativeFieldInfoPtr_solari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, "solari");
			WormTiebreakersSubscriber.NativeFieldInfoPtr_spice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, "spice");
			WormTiebreakersSubscriber.NativeFieldInfoPtr_water = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, "water");
			WormTiebreakersSubscriber.NativeFieldInfoPtr_troops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, "troops");
			WormTiebreakersSubscriber.NativeFieldInfoPtr_chaumurky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, "chaumurky");
			WormTiebreakersSubscriber.NativeFieldInfoPtr_banner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, "banner");
			WormTiebreakersSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, 100665498);
			WormTiebreakersSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr, 100665499);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00048DB8 File Offset: 0x00046FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709118, XrefRangeEnd = 709127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTiebreakersSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00048DF4 File Offset: 0x00046FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709127, XrefRangeEnd = 709130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTiebreakersSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTiebreakersSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTiebreakersSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0000A897 File Offset: 0x00008A97
		public WormTiebreakersSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00048E30 File Offset: 0x00047030
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		public unsafe GameObject solari
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_solari);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_solari), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00048E60 File Offset: 0x00047060
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0000A8BF File Offset: 0x00008ABF
		public unsafe GameObject spice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_spice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_spice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00048E90 File Offset: 0x00047090
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x0000A8DE File Offset: 0x00008ADE
		public unsafe GameObject water
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_water);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_water), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00048EC0 File Offset: 0x000470C0
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0000A8FD File Offset: 0x00008AFD
		public unsafe GameObject troops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_troops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_troops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x00048EF0 File Offset: 0x000470F0
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0000A91C File Offset: 0x00008B1C
		public unsafe GameObject chaumurky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_chaumurky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_chaumurky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00048F20 File Offset: 0x00047120
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0000A93B File Offset: 0x00008B3B
		public unsafe GameObject banner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_banner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTiebreakersSubscriber.NativeFieldInfoPtr_banner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_solari;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_spice;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_water;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_troops;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_chaumurky;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_banner;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
