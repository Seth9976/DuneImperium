using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using worm.canis.actions.phases;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200010C RID: 268
	public class WormConflictAllPlayersRewardsRenderer : Subscriber<WormConflictAllPlayersRewardsData>
	{
		// Token: 0x06000C1F RID: 3103 RVA: 0x0003CFF8 File Offset: 0x0003B1F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictAllPlayersRewardsRenderer()
		{
			Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormConflictAllPlayersRewardsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr);
			WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_playerRewardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, "playerRewardPrefab");
			WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_playerAnchorSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, "playerAnchorSlots");
			WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_tieAnchorShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, "tieAnchorShift");
			WormConflictAllPlayersRewardsRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, 100664975);
			WormConflictAllPlayersRewardsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, 100664976);
			WormConflictAllPlayersRewardsRenderer.NativeMethodInfoPtr__modelChanged_b__3_1_Private_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, 100664977);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0003D0A0 File Offset: 0x0003B2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703944, XrefRangeEnd = 704031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictAllPlayersRewardsRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003D0DC File Offset: 0x0003B2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704031, XrefRangeEnd = 704038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictAllPlayersRewardsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003D118 File Offset: 0x0003B318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704038, XrefRangeEnd = 704053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _modelChanged_b__3_1(EntityComponent player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.NativeMethodInfoPtr__modelChanged_b__3_1_Private_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000085BC File Offset: 0x000067BC
		public WormConflictAllPlayersRewardsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0003D168 File Offset: 0x0003B368
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x000085C5 File Offset: 0x000067C5
		public unsafe GameObject playerRewardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_playerRewardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_playerRewardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0003D198 File Offset: 0x0003B398
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x000085E4 File Offset: 0x000067E4
		public unsafe Il2CppReferenceArray<Transform> playerAnchorSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_playerAnchorSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_playerAnchorSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x00008603 File Offset: 0x00006803
		public unsafe float tieAnchorShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_tieAnchorShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.NativeFieldInfoPtr_tieAnchorShift)) = value;
			}
		}

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_playerRewardPrefab;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_playerAnchorSlots;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_tieAnchorShift;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__3_1_Private_Int32_EntityComponent_0;

		// Token: 0x0200036F RID: 879
		[ObfuscatedName("worm.match.dataRenderers.WormConflictAllPlayersRewardsRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600236C RID: 9068 RVA: 0x00083944 File Offset: 0x00081B44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr);
				WormConflictAllPlayersRewardsRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr, "<>9");
				WormConflictAllPlayersRewardsRenderer.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr, "<>9__3_0");
				WormConflictAllPlayersRewardsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr, 100664979);
				WormConflictAllPlayersRewardsRenderer.__c.NativeMethodInfoPtr__modelChanged_b__3_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr, 100664980);
			}

			// Token: 0x0600236D RID: 9069 RVA: 0x000839C0 File Offset: 0x00081BC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600236E RID: 9070 RVA: 0x000839FC File Offset: 0x00081BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703930, XrefRangeEnd = 703934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__3_0(EntityComponent player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.__c.NativeMethodInfoPtr__modelChanged_b__3_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x00013C8B File Offset: 0x00011E8B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x06002370 RID: 9072 RVA: 0x00083A4C File Offset: 0x00081C4C
			// (set) Token: 0x06002371 RID: 9073 RVA: 0x00013C94 File Offset: 0x00011E94
			public unsafe static WormConflictAllPlayersRewardsRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictAllPlayersRewardsRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictAllPlayersRewardsRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictAllPlayersRewardsRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06002372 RID: 9074 RVA: 0x00083A74 File Offset: 0x00081C74
			// (set) Token: 0x06002373 RID: 9075 RVA: 0x00013CA6 File Offset: 0x00011EA6
			public unsafe static Func<EntityComponent, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictAllPlayersRewardsRenderer.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictAllPlayersRewardsRenderer.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001459 RID: 5209
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400145A RID: 5210
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400145B RID: 5211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400145C RID: 5212
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__3_0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000370 RID: 880
		[ObfuscatedName("worm.match.dataRenderers.WormConflictAllPlayersRewardsRenderer+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002374 RID: 9076 RVA: 0x00083A9C File Offset: 0x00081C9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0>.NativeClassPtr);
				WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0>.NativeClassPtr, "player");
				WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0>.NativeClassPtr, 100664981);
				WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__modelChanged_b__2_Internal_Boolean_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0>.NativeClassPtr, 100664982);
			}

			// Token: 0x06002375 RID: 9077 RVA: 0x00083B04 File Offset: 0x00081D04
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002376 RID: 9078 RVA: 0x00083B40 File Offset: 0x00081D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703934, XrefRangeEnd = 703939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__2(SerializedPlayerReward pr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeMethodInfoPtr__modelChanged_b__2_Internal_Boolean_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002377 RID: 9079 RVA: 0x00013CB8 File Offset: 0x00011EB8
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06002378 RID: 9080 RVA: 0x00083B90 File Offset: 0x00081D90
			// (set) Token: 0x06002379 RID: 9081 RVA: 0x00013CC1 File Offset: 0x00011EC1
			public unsafe EntityComponent player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400145D RID: 5213
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400145E RID: 5214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400145F RID: 5215
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__2_Internal_Boolean_SerializedPlayerReward_0;
		}

		// Token: 0x02000371 RID: 881
		[ObfuscatedName("worm.match.dataRenderers.WormConflictAllPlayersRewardsRenderer+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : global::Il2CppSystem.Object
		{
			// Token: 0x0600237A RID: 9082 RVA: 0x00083BC0 File Offset: 0x00081DC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1>.NativeClassPtr);
				WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1>.NativeClassPtr, "player");
				WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1>.NativeClassPtr, 100664983);
				WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__modelChanged_b__3_Internal_Boolean_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1>.NativeClassPtr, 100664984);
			}

			// Token: 0x0600237B RID: 9083 RVA: 0x00083C28 File Offset: 0x00081E28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600237C RID: 9084 RVA: 0x00083C64 File Offset: 0x00081E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703939, XrefRangeEnd = 703944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__3(SerializedPlayerReward pr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeMethodInfoPtr__modelChanged_b__3_Internal_Boolean_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600237D RID: 9085 RVA: 0x00013CE0 File Offset: 0x00011EE0
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x0600237E RID: 9086 RVA: 0x00083CB4 File Offset: 0x00081EB4
			// (set) Token: 0x0600237F RID: 9087 RVA: 0x00013CE9 File Offset: 0x00011EE9
			public unsafe EntityComponent player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictAllPlayersRewardsRenderer.__c__DisplayClass3_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001460 RID: 5216
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04001461 RID: 5217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001462 RID: 5218
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__3_Internal_Boolean_SerializedPlayerReward_0;
		}
	}
}
