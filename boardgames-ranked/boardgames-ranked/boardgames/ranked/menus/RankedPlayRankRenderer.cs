using System;
using boardgames.ranked.networking.responses;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x02000027 RID: 39
	public class RankedPlayRankRenderer : MonoBehaviour
	{
		// Token: 0x06000165 RID: 357 RVA: 0x000074F0 File Offset: 0x000056F0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayRankRenderer()
		{
			Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr);
			RankedPlayRankRenderer.NativeFieldInfoPtr_objectsByRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr, "objectsByRank");
			RankedPlayRankRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr, 100663412);
			RankedPlayRankRenderer.NativeMethodInfoPtr_ShowRank_Public_Void_RankName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr, 100663413);
			RankedPlayRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr, 100663414);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007570 File Offset: 0x00005770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225529, XrefRangeEnd = 1225530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayRankRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000075A4 File Offset: 0x000057A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1225536, RefRangeEnd = 1225540, XrefRangeStart = 1225530, XrefRangeEnd = 1225536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowRank(RankName rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayRankRenderer.NativeMethodInfoPtr_ShowRank_Public_Void_RankName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000075E4 File Offset: 0x000057E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225540, XrefRangeEnd = 1225552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002D8E File Offset: 0x00000F8E
		public RankedPlayRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00007620 File Offset: 0x00005820
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002D97 File Offset: 0x00000F97
		public unsafe Il2CppReferenceArray<RankedPlayRankRenderer.RankPair> objectsByRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayRankRenderer.NativeFieldInfoPtr_objectsByRank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RankedPlayRankRenderer.RankPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayRankRenderer.NativeFieldInfoPtr_objectsByRank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_objectsByRank;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_ShowRank_Public_Void_RankName_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000041 RID: 65
		[Serializable]
		public sealed class RankPair : ValueType
		{
			// Token: 0x06000231 RID: 561 RVA: 0x000099D4 File Offset: 0x00007BD4
			// Note: this type is marked as 'beforefieldinit'.
			static RankPair()
			{
				Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedPlayRankRenderer>.NativeClassPtr, "RankPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr);
				RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr, "All");
				RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr, "rank");
				RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr, "show");
				RankedPlayRankRenderer.RankPair.NativeMethodInfoPtr_GetAll_Public_Static_Il2CppReferenceArray_1_RankPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr, 100663415);
			}

			// Token: 0x06000232 RID: 562 RVA: 0x00009A50 File Offset: 0x00007C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225489, XrefRangeEnd = 1225529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppReferenceArray<RankedPlayRankRenderer.RankPair> GetAll()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayRankRenderer.RankPair.NativeMethodInfoPtr_GetAll_Public_Static_Il2CppReferenceArray_1_RankPair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RankedPlayRankRenderer.RankPair>>(intPtr3) : null;
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00003373 File Offset: 0x00001573
			public RankPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000234 RID: 564 RVA: 0x0000337C File Offset: 0x0000157C
			public RankPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr))
			{
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000235 RID: 565 RVA: 0x00009A84 File Offset: 0x00007C84
			// (set) Token: 0x06000236 RID: 566 RVA: 0x0000338E File Offset: 0x0000158E
			public unsafe static Il2CppReferenceArray<RankedPlayRankRenderer.RankPair> All
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_All, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RankedPlayRankRenderer.RankPair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_All, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000237 RID: 567 RVA: 0x00009AAC File Offset: 0x00007CAC
			// (set) Token: 0x06000238 RID: 568 RVA: 0x000033A0 File Offset: 0x000015A0
			public unsafe RankName rank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_rank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_rank)) = value;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000239 RID: 569 RVA: 0x00009AD4 File Offset: 0x00007CD4
			// (set) Token: 0x0600023A RID: 570 RVA: 0x000033BB File Offset: 0x000015BB
			public unsafe GameObject show
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_show);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayRankRenderer.RankPair.NativeFieldInfoPtr_show), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeFieldInfoPtr_All;

			// Token: 0x04000134 RID: 308
			private static readonly IntPtr NativeFieldInfoPtr_rank;

			// Token: 0x04000135 RID: 309
			private static readonly IntPtr NativeFieldInfoPtr_show;

			// Token: 0x04000136 RID: 310
			private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Il2CppReferenceArray_1_RankPair_0;

			// Token: 0x0200004F RID: 79
			[ObfuscatedName("boardgames.ranked.menus.RankedPlayRankRenderer+RankPair+<>c")]
			[Serializable]
			public sealed class __c : global::Il2CppSystem.Object
			{
				// Token: 0x060002D8 RID: 728 RVA: 0x0000B750 File Offset: 0x00009950
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair.__c>.NativeClassPtr);
					RankedPlayRankRenderer.RankPair.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair.__c>.NativeClassPtr, "<>9");
					RankedPlayRankRenderer.RankPair.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair.__c>.NativeClassPtr, 100663418);
					RankedPlayRankRenderer.RankPair.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_RankPair_RankName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair.__c>.NativeClassPtr, 100663419);
				}

				// Token: 0x060002D9 RID: 729 RVA: 0x0000B7B8 File Offset: 0x000099B8
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayRankRenderer.RankPair.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayRankRenderer.RankPair.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060002DA RID: 730 RVA: 0x0000B7F4 File Offset: 0x000099F4
				[CallerCount(0)]
				public unsafe RankedPlayRankRenderer.RankPair __cctor_b__5_0(RankName r)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref r;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayRankRenderer.RankPair.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_RankPair_RankName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new RankedPlayRankRenderer.RankPair(intPtr);
					}
				}

				// Token: 0x060002DB RID: 731 RVA: 0x000038FB File Offset: 0x00001AFB
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000D4 RID: 212
				// (get) Token: 0x060002DC RID: 732 RVA: 0x0000B838 File Offset: 0x00009A38
				// (set) Token: 0x060002DD RID: 733 RVA: 0x00003904 File Offset: 0x00001B04
				public unsafe static RankedPlayRankRenderer.RankPair.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(RankedPlayRankRenderer.RankPair.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedPlayRankRenderer.RankPair.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(RankedPlayRankRenderer.RankPair.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000192 RID: 402
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000193 RID: 403
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000194 RID: 404
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_RankPair_RankName_0;
			}
		}
	}
}
