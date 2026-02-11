using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000128 RID: 296
	public class WormGainInfluenceAbilityRenderer : Observer
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x00040FA4 File Offset: 0x0003F1A4
		// Note: this type is marked as 'beforefieldinit'.
		static WormGainInfluenceAbilityRenderer()
		{
			Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGainInfluenceAbilityRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr);
			WormGainInfluenceAbilityRenderer.NativeFieldInfoPtr_factionDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr, "factionDisplays");
			WormGainInfluenceAbilityRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr, 100665138);
			WormGainInfluenceAbilityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr, 100665139);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00041010 File Offset: 0x0003F210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705693, XrefRangeEnd = 705748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGainInfluenceAbilityRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0004104C File Offset: 0x0003F24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705748, XrefRangeEnd = 705756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGainInfluenceAbilityRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGainInfluenceAbilityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0000927C File Offset: 0x0000747C
		public WormGainInfluenceAbilityRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00041088 File Offset: 0x0003F288
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x00009285 File Offset: 0x00007485
		public unsafe Il2CppReferenceArray<WormGainInfluenceAbilityRenderer.FactionDisplayPair> factionDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceAbilityRenderer.NativeFieldInfoPtr_factionDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormGainInfluenceAbilityRenderer.FactionDisplayPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceAbilityRenderer.NativeFieldInfoPtr_factionDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_factionDisplays;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000385 RID: 901
		[Serializable]
		public sealed class FactionDisplayPair : ValueType
		{
			// Token: 0x06002441 RID: 9281 RVA: 0x00085CF4 File Offset: 0x00083EF4
			// Note: this type is marked as 'beforefieldinit'.
			static FactionDisplayPair()
			{
				Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer.FactionDisplayPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer>.NativeClassPtr, "FactionDisplayPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer.FactionDisplayPair>.NativeClassPtr);
				WormGainInfluenceAbilityRenderer.FactionDisplayPair.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer.FactionDisplayPair>.NativeClassPtr, "faction");
				WormGainInfluenceAbilityRenderer.FactionDisplayPair.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer.FactionDisplayPair>.NativeClassPtr, "display");
			}

			// Token: 0x06002442 RID: 9282 RVA: 0x000143BD File Offset: 0x000125BD
			public FactionDisplayPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002443 RID: 9283 RVA: 0x000143C6 File Offset: 0x000125C6
			public FactionDisplayPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGainInfluenceAbilityRenderer.FactionDisplayPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06002444 RID: 9284 RVA: 0x00085D48 File Offset: 0x00083F48
			// (set) Token: 0x06002445 RID: 9285 RVA: 0x000143D8 File Offset: 0x000125D8
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceAbilityRenderer.FactionDisplayPair.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceAbilityRenderer.FactionDisplayPair.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06002446 RID: 9286 RVA: 0x00085D70 File Offset: 0x00083F70
			// (set) Token: 0x06002447 RID: 9287 RVA: 0x000143F3 File Offset: 0x000125F3
			public unsafe GameObject display
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceAbilityRenderer.FactionDisplayPair.NativeFieldInfoPtr_display);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGainInfluenceAbilityRenderer.FactionDisplayPair.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeFieldInfoPtr_display;
		}
	}
}
