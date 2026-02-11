using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.views
{
	// Token: 0x020000AC RID: 172
	public class WormFactionTrackUIView : UnitView
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x0002CF80 File Offset: 0x0002B180
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionTrackUIView()
		{
			Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormFactionTrackUIView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr);
			WormFactionTrackUIView.NativeFieldInfoPtr_factionPrefabPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr, "factionPrefabPairs");
			WormFactionTrackUIView.NativeFieldInfoPtr_trackRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr, "trackRoot");
			WormFactionTrackUIView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr, 100664234);
			WormFactionTrackUIView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr, 100664235);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0002D000 File Offset: 0x0002B200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696705, XrefRangeEnd = 696729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionTrackUIView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0002D060 File Offset: 0x0002B260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696729, XrefRangeEnd = 696737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionTrackUIView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackUIView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00005551 File Offset: 0x00003751
		public WormFactionTrackUIView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0002D09C File Offset: 0x0002B29C
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x0000555A File Offset: 0x0000375A
		public unsafe List<WormFactionTrackUIView.FactionPrefabPair> factionPrefabPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.NativeFieldInfoPtr_factionPrefabPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormFactionTrackUIView.FactionPrefabPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.NativeFieldInfoPtr_factionPrefabPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0002D0CC File Offset: 0x0002B2CC
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00005579 File Offset: 0x00003779
		public unsafe RectTransform trackRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.NativeFieldInfoPtr_trackRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.NativeFieldInfoPtr_trackRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_factionPrefabPairs;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_trackRoot;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000312 RID: 786
		[Serializable]
		public sealed class FactionPrefabPair : ValueType
		{
			// Token: 0x06001FAB RID: 8107 RVA: 0x00078E10 File Offset: 0x00077010
			// Note: this type is marked as 'beforefieldinit'.
			static FactionPrefabPair()
			{
				Il2CppClassPointerStore<WormFactionTrackUIView.FactionPrefabPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr, "FactionPrefabPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrackUIView.FactionPrefabPair>.NativeClassPtr);
				WormFactionTrackUIView.FactionPrefabPair.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackUIView.FactionPrefabPair>.NativeClassPtr, "faction");
				WormFactionTrackUIView.FactionPrefabPair.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackUIView.FactionPrefabPair>.NativeClassPtr, "prefab");
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x00011D78 File Offset: 0x0000FF78
			public FactionPrefabPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x00011D81 File Offset: 0x0000FF81
			public FactionPrefabPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrackUIView.FactionPrefabPair>.NativeClassPtr))
			{
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00078E64 File Offset: 0x00077064
			// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00011D93 File Offset: 0x0000FF93
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.FactionPrefabPair.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.FactionPrefabPair.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00078E8C File Offset: 0x0007708C
			// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00011DAE File Offset: 0x0000FFAE
			public unsafe GameObject prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.FactionPrefabPair.NativeFieldInfoPtr_prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.FactionPrefabPair.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400124B RID: 4683
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x0400124C RID: 4684
			private static readonly IntPtr NativeFieldInfoPtr_prefab;
		}

		// Token: 0x02000313 RID: 787
		[ObfuscatedName("worm.match.views.WormFactionTrackUIView+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001FB2 RID: 8114 RVA: 0x00078EBC File Offset: 0x000770BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormFactionTrackUIView.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionTrackUIView>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionTrackUIView.__c__DisplayClass3_0>.NativeClassPtr);
				WormFactionTrackUIView.__c__DisplayClass3_0.NativeFieldInfoPtr_ec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionTrackUIView.__c__DisplayClass3_0>.NativeClassPtr, "ec");
				WormFactionTrackUIView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackUIView.__c__DisplayClass3_0>.NativeClassPtr, 100664236);
				WormFactionTrackUIView.__c__DisplayClass3_0.NativeMethodInfoPtr__Init_b__0_Internal_Boolean_FactionPrefabPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionTrackUIView.__c__DisplayClass3_0>.NativeClassPtr, 100664237);
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x00078F24 File Offset: 0x00077124
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionTrackUIView.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackUIView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FB4 RID: 8116 RVA: 0x00078F60 File Offset: 0x00077160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696701, XrefRangeEnd = 696705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__0(WormFactionTrackUIView.FactionPrefabPair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionTrackUIView.__c__DisplayClass3_0.NativeMethodInfoPtr__Init_b__0_Internal_Boolean_FactionPrefabPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FB5 RID: 8117 RVA: 0x00011DCD File Offset: 0x0000FFCD
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00078FB4 File Offset: 0x000771B4
			// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00011DD6 File Offset: 0x0000FFD6
			public unsafe EntityComponent ec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.__c__DisplayClass3_0.NativeFieldInfoPtr_ec);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionTrackUIView.__c__DisplayClass3_0.NativeFieldInfoPtr_ec), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400124D RID: 4685
			private static readonly IntPtr NativeFieldInfoPtr_ec;

			// Token: 0x0400124E RID: 4686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400124F RID: 4687
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__0_Internal_Boolean_FactionPrefabPair_0;
		}
	}
}
