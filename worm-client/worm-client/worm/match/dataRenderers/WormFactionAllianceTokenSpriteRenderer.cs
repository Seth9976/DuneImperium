using System;
using boardgames.match.behaviours;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using voodoo;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000121 RID: 289
	public class WormFactionAllianceTokenSpriteRenderer : VersionedDataComponentObserver<WormFactionData>
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x00040258 File Offset: 0x0003E458
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionAllianceTokenSpriteRenderer()
		{
			Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFactionAllianceTokenSpriteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr);
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_spriteFactionPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "spriteFactionPairs");
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "sprite");
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "image");
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_cacheFactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "cacheFactions");
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_twoVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "twoVP");
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_allianceTokenRuleMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "allianceTokenRuleMod");
			WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_moveTrackVPRulesMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "moveTrackVPRulesMod");
			WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, 100665106);
			WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr_InternalInit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, 100665107);
			WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, 100665108);
			WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, 100665109);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00040364 File Offset: 0x0003E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705443, XrefRangeEnd = 705450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000403A0 File Offset: 0x0003E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705450, XrefRangeEnd = 705455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InternalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr_InternalInit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000403E0 File Offset: 0x0003E5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705455, XrefRangeEnd = 705488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0004041C File Offset: 0x0003E61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705488, XrefRangeEnd = 705498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionAllianceTokenSpriteRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00008FB0 File Offset: 0x000071B0
		public WormFactionAllianceTokenSpriteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00040458 File Offset: 0x0003E658
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00008FB9 File Offset: 0x000071B9
		public unsafe List<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair> spriteFactionPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_spriteFactionPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_spriteFactionPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00040488 File Offset: 0x0003E688
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00008FD8 File Offset: 0x000071D8
		public unsafe SpriteRenderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x000404B8 File Offset: 0x0003E6B8
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00008FF7 File Offset: 0x000071F7
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x000404E8 File Offset: 0x0003E6E8
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00009016 File Offset: 0x00007216
		public Nullable<Factions> cacheFactions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_cacheFactions);
				return new Nullable<Factions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Factions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_cacheFactions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Factions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00040518 File Offset: 0x0003E718
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00009044 File Offset: 0x00007244
		public unsafe bool twoVP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_twoVP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_twoVP)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00040540 File Offset: 0x0003E740
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0000905F File Offset: 0x0000725F
		public unsafe static int allianceTokenRuleMod
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_allianceTokenRuleMod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_allianceTokenRuleMod, (void*)(&value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0004055C File Offset: 0x0003E75C
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x0000906D File Offset: 0x0000726D
		public unsafe static int moveTrackVPRulesMod
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_moveTrackVPRulesMod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFactionAllianceTokenSpriteRenderer.NativeFieldInfoPtr_moveTrackVPRulesMod, (void*)(&value));
			}
		}

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_spriteFactionPairs;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_cacheFactions;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_twoVP;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_allianceTokenRuleMod;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_moveTrackVPRulesMod;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_InternalInit_Private_IEnumerator_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000381 RID: 897
		[Serializable]
		public class SpriteFactionPair : global::Il2CppSystem.Object
		{
			// Token: 0x06002419 RID: 9241 RVA: 0x0008568C File Offset: 0x0008388C
			// Note: this type is marked as 'beforefieldinit'.
			static SpriteFactionPair()
			{
				Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "SpriteFactionPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr);
				WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr, "faction");
				WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_standardSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr, "standardSprite");
				WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_twoVpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr, "twoVpSprite");
				WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr, 100665110);
			}

			// Token: 0x0600241A RID: 9242 RVA: 0x00085708 File Offset: 0x00083908
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpriteFactionPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600241B RID: 9243 RVA: 0x0001422F File Offset: 0x0001242F
			public SpriteFactionPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x0600241C RID: 9244 RVA: 0x00085744 File Offset: 0x00083944
			// (set) Token: 0x0600241D RID: 9245 RVA: 0x00014238 File Offset: 0x00012438
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x0600241E RID: 9246 RVA: 0x0008576C File Offset: 0x0008396C
			// (set) Token: 0x0600241F RID: 9247 RVA: 0x00014253 File Offset: 0x00012453
			public unsafe Sprite standardSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_standardSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_standardSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009FE RID: 2558
			// (get) Token: 0x06002420 RID: 9248 RVA: 0x0008579C File Offset: 0x0008399C
			// (set) Token: 0x06002421 RID: 9249 RVA: 0x00014272 File Offset: 0x00012472
			public unsafe Sprite twoVpSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_twoVpSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer.SpriteFactionPair.NativeFieldInfoPtr_twoVpSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014B3 RID: 5299
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x040014B4 RID: 5300
			private static readonly IntPtr NativeFieldInfoPtr_standardSprite;

			// Token: 0x040014B5 RID: 5301
			private static readonly IntPtr NativeFieldInfoPtr_twoVpSprite;

			// Token: 0x040014B6 RID: 5302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000382 RID: 898
		[ObfuscatedName("worm.match.dataRenderers.WormFactionAllianceTokenSpriteRenderer+<InternalInit>d__9")]
		public sealed class _InternalInit_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06002422 RID: 9250 RVA: 0x000857CC File Offset: 0x000839CC
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalInit_d__9()
			{
				Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer>.NativeClassPtr, "<InternalInit>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr);
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, "<>1__state");
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, "<>2__current");
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, "<>4__this");
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, "<matchHub>5__2");
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr__entitiesProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, "<entitiesProvider>5__3");
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, 100665111);
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, 100665112);
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, 100665113);
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, 100665114);
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, 100665115);
				WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr, 100665116);
			}

			// Token: 0x06002423 RID: 9251 RVA: 0x000858D4 File Offset: 0x00083AD4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InternalInit_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002424 RID: 9252 RVA: 0x0008591C File Offset: 0x00083B1C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002425 RID: 9253 RVA: 0x00085950 File Offset: 0x00083B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705426, XrefRangeEnd = 705438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x06002426 RID: 9254 RVA: 0x0008598C File Offset: 0x00083B8C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002427 RID: 9255 RVA: 0x000859CC File Offset: 0x00083BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705438, XrefRangeEnd = 705443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x06002428 RID: 9256 RVA: 0x00085A00 File Offset: 0x00083C00
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002429 RID: 9257 RVA: 0x00014291 File Offset: 0x00012491
			public _InternalInit_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x0600242A RID: 9258 RVA: 0x00085A40 File Offset: 0x00083C40
			// (set) Token: 0x0600242B RID: 9259 RVA: 0x0001429A File Offset: 0x0001249A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A00 RID: 2560
			// (get) Token: 0x0600242C RID: 9260 RVA: 0x00085A68 File Offset: 0x00083C68
			// (set) Token: 0x0600242D RID: 9261 RVA: 0x000142B5 File Offset: 0x000124B5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x0600242E RID: 9262 RVA: 0x00085A98 File Offset: 0x00083C98
			// (set) Token: 0x0600242F RID: 9263 RVA: 0x000142D4 File Offset: 0x000124D4
			public unsafe WormFactionAllianceTokenSpriteRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionAllianceTokenSpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x06002430 RID: 9264 RVA: 0x00085AC8 File Offset: 0x00083CC8
			// (set) Token: 0x06002431 RID: 9265 RVA: 0x000142F3 File Offset: 0x000124F3
			public unsafe DBGMatchHub _matchHub_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr__matchHub_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06002432 RID: 9266 RVA: 0x00085AF8 File Offset: 0x00083CF8
			// (set) Token: 0x06002433 RID: 9267 RVA: 0x00014312 File Offset: 0x00012512
			public unsafe EntitiesProvider _entitiesProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr__entitiesProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionAllianceTokenSpriteRenderer._InternalInit_d__9.NativeFieldInfoPtr__entitiesProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014B7 RID: 5303
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014B8 RID: 5304
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014B9 RID: 5305
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014BA RID: 5306
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

			// Token: 0x040014BB RID: 5307
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__3;

			// Token: 0x040014BC RID: 5308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014BD RID: 5309
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014BE RID: 5310
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014BF RID: 5311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
