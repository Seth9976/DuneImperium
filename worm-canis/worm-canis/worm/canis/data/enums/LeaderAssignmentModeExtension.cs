using System;
using canis.archetypes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions;
using worm.canis.entities;

namespace worm.canis.data.enums
{
	// Token: 0x020000D5 RID: 213
	public static class LeaderAssignmentModeExtension : Object
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x00097AB0 File Offset: 0x00095CB0
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderAssignmentModeExtension()
		{
			Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.enums", "LeaderAssignmentModeExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_NeedsAssignment_Private_Static_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665931);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_NonHagalNeedsAssignment_Private_Static_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665932);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_HagalNeedsAssignment_Private_Static_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665933);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_StandardLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665934);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_DraftLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665935);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_RandomLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665936);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_CustomSoloLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665937);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_HagalLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665938);
			LeaderAssignmentModeExtension.NativeMethodInfoPtr_LeaderAssignment_Public_Static_IEnumerable_1_AssignLeader_LeaderAssignmentMode_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, 100665939);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00097B94 File Offset: 0x00095D94
		[CallerCount(0)]
		public unsafe static bool NeedsAssignment(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_NeedsAssignment_Private_Static_Boolean_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00097BD8 File Offset: 0x00095DD8
		[CallerCount(0)]
		public unsafe static bool NonHagalNeedsAssignment(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_NonHagalNeedsAssignment_Private_Static_Boolean_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00097C1C File Offset: 0x00095E1C
		[CallerCount(0)]
		public unsafe static bool HagalNeedsAssignment(WormPlayer player)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_HagalNeedsAssignment_Private_Static_Boolean_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00097C60 File Offset: 0x00095E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76860, XrefRangeEnd = 76866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssignLeader> StandardLeaderAssignment(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_StandardLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00097CA4 File Offset: 0x00095EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76866, XrefRangeEnd = 76872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssignLeader> DraftLeaderAssignment(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_DraftLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00097CE8 File Offset: 0x00095EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76872, XrefRangeEnd = 76878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssignLeader> RandomLeaderAssignment(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_RandomLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00097D2C File Offset: 0x00095F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76878, XrefRangeEnd = 76884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssignLeader> CustomSoloLeaderAssignment(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_CustomSoloLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00097D70 File Offset: 0x00095F70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76890, RefRangeEnd = 76893, XrefRangeStart = 76884, XrefRangeEnd = 76890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssignLeader> HagalLeaderAssignment(WormMatch match)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_HagalLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00097DB4 File Offset: 0x00095FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76908, RefRangeEnd = 76909, XrefRangeStart = 76893, XrefRangeEnd = 76908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssignLeader> LeaderAssignment(this LeaderAssignmentMode mode, WormMatch match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.NativeMethodInfoPtr_LeaderAssignment_Public_Static_IEnumerable_1_AssignLeader_LeaderAssignmentMode_WormMatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000076E1 File Offset: 0x000058E1
		public LeaderAssignmentModeExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_NeedsAssignment_Private_Static_Boolean_WormPlayer_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_NonHagalNeedsAssignment_Private_Static_Boolean_WormPlayer_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_HagalNeedsAssignment_Private_Static_Boolean_WormPlayer_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_StandardLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_DraftLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_RandomLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_CustomSoloLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_HagalLeaderAssignment_Private_Static_IEnumerable_1_AssignLeader_WormMatch_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_LeaderAssignment_Public_Static_IEnumerable_1_AssignLeader_LeaderAssignmentMode_WormMatch_0;

		// Token: 0x02000629 RID: 1577
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>O")]
		public static class __O : Object
		{
			// Token: 0x06004F33 RID: 20275 RVA: 0x001A654C File Offset: 0x001A474C
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__O>.NativeClassPtr);
				LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__0___NonHagalNeedsAssignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__O>.NativeClassPtr, "<0>__NonHagalNeedsAssignment");
				LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__1___NeedsAssignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__O>.NativeClassPtr, "<1>__NeedsAssignment");
				LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__2___HagalNeedsAssignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__O>.NativeClassPtr, "<2>__HagalNeedsAssignment");
			}

			// Token: 0x06004F34 RID: 20276 RVA: 0x0001B3BA File Offset: 0x000195BA
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001367 RID: 4967
			// (get) Token: 0x06004F35 RID: 20277 RVA: 0x001A65B4 File Offset: 0x001A47B4
			// (set) Token: 0x06004F36 RID: 20278 RVA: 0x0001B3C3 File Offset: 0x000195C3
			public unsafe static Func<WormPlayer, bool> _0___NonHagalNeedsAssignment
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__0___NonHagalNeedsAssignment, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__0___NonHagalNeedsAssignment, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001368 RID: 4968
			// (get) Token: 0x06004F37 RID: 20279 RVA: 0x001A65DC File Offset: 0x001A47DC
			// (set) Token: 0x06004F38 RID: 20280 RVA: 0x0001B3D5 File Offset: 0x000195D5
			public unsafe static Func<WormPlayer, bool> _1___NeedsAssignment
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__1___NeedsAssignment, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__1___NeedsAssignment, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001369 RID: 4969
			// (get) Token: 0x06004F39 RID: 20281 RVA: 0x001A6604 File Offset: 0x001A4804
			// (set) Token: 0x06004F3A RID: 20282 RVA: 0x0001B3E7 File Offset: 0x000195E7
			public unsafe static Func<WormPlayer, bool> _2___HagalNeedsAssignment
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__2___HagalNeedsAssignment, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__O.NativeFieldInfoPtr__2___HagalNeedsAssignment, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003407 RID: 13319
			private static readonly IntPtr NativeFieldInfoPtr__0___NonHagalNeedsAssignment;

			// Token: 0x04003408 RID: 13320
			private static readonly IntPtr NativeFieldInfoPtr__1___NeedsAssignment;

			// Token: 0x04003409 RID: 13321
			private static readonly IntPtr NativeFieldInfoPtr__2___HagalNeedsAssignment;
		}

		// Token: 0x0200062A RID: 1578
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06004F3B RID: 20283 RVA: 0x001A662C File Offset: 0x001A482C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__3_1");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__4_1");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__4_2");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__5_0");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__5_2");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__5_3");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__6_1");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__6_2");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__6_3");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__6_4");
				LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, "<>9__7_1");
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665941);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__StandardLeaderAssignment_b__3_1_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665942);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__DraftLeaderAssignment_b__4_1_Internal_Int32_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665943);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__DraftLeaderAssignment_b__4_2_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665944);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__RandomLeaderAssignment_b__5_0_Internal_IEnumerable_1_ArchetypeID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665945);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__RandomLeaderAssignment_b__5_2_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665946);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__RandomLeaderAssignment_b__5_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665947);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_1_Internal_Int32_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665948);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_2_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665949);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665950);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665951);
				LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__HagalLeaderAssignment_b__7_1_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr, 100665952);
			}

			// Token: 0x06004F3C RID: 20284 RVA: 0x001A6838 File Offset: 0x001A4A38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F3D RID: 20285 RVA: 0x001A6874 File Offset: 0x001A4A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _StandardLeaderAssignment_b__3_1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__StandardLeaderAssignment_b__3_1_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06004F3E RID: 20286 RVA: 0x001A68C4 File Offset: 0x001A4AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76112, XrefRangeEnd = 76120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DraftLeaderAssignment_b__4_1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__DraftLeaderAssignment_b__4_1_Internal_Int32_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F3F RID: 20287 RVA: 0x001A6914 File Offset: 0x001A4B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _DraftLeaderAssignment_b__4_2(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__DraftLeaderAssignment_b__4_2_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06004F40 RID: 20288 RVA: 0x001A6964 File Offset: 0x001A4B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76120, XrefRangeEnd = 76133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ArchetypeID> _RandomLeaderAssignment_b__5_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__RandomLeaderAssignment_b__5_0_Internal_IEnumerable_1_ArchetypeID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr3) : null;
				}
			}

			// Token: 0x06004F41 RID: 20289 RVA: 0x001A69B4 File Offset: 0x001A4BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _RandomLeaderAssignment_b__5_2(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__RandomLeaderAssignment_b__5_2_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06004F42 RID: 20290 RVA: 0x001A6A04 File Offset: 0x001A4C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RandomLeaderAssignment_b__5_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__RandomLeaderAssignment_b__5_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F43 RID: 20291 RVA: 0x001A6A54 File Offset: 0x001A4C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76133, XrefRangeEnd = 76141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CustomSoloLeaderAssignment_b__6_1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_1_Internal_Int32_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F44 RID: 20292 RVA: 0x001A6AA4 File Offset: 0x001A4CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _CustomSoloLeaderAssignment_b__6_2(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_2_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06004F45 RID: 20293 RVA: 0x001A6AF4 File Offset: 0x001A4CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CustomSoloLeaderAssignment_b__6_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F46 RID: 20294 RVA: 0x001A6B44 File Offset: 0x001A4D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CustomSoloLeaderAssignment_b__6_4(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F47 RID: 20295 RVA: 0x001A6B94 File Offset: 0x001A4D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _HagalLeaderAssignment_b__7_1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c.NativeMethodInfoPtr__HagalLeaderAssignment_b__7_1_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06004F48 RID: 20296 RVA: 0x0001B3F9 File Offset: 0x000195F9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700136A RID: 4970
			// (get) Token: 0x06004F49 RID: 20297 RVA: 0x001A6BE4 File Offset: 0x001A4DE4
			// (set) Token: 0x06004F4A RID: 20298 RVA: 0x0001B402 File Offset: 0x00019602
			public unsafe static LeaderAssignmentModeExtension.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderAssignmentModeExtension.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136B RID: 4971
			// (get) Token: 0x06004F4B RID: 20299 RVA: 0x001A6C0C File Offset: 0x001A4E0C
			// (set) Token: 0x06004F4C RID: 20300 RVA: 0x0001B414 File Offset: 0x00019614
			public unsafe static Func<Archetype, ArchetypeID> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136C RID: 4972
			// (get) Token: 0x06004F4D RID: 20301 RVA: 0x001A6C34 File Offset: 0x001A4E34
			// (set) Token: 0x06004F4E RID: 20302 RVA: 0x0001B426 File Offset: 0x00019626
			public unsafe static Func<Archetype, int> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136D RID: 4973
			// (get) Token: 0x06004F4F RID: 20303 RVA: 0x001A6C5C File Offset: 0x001A4E5C
			// (set) Token: 0x06004F50 RID: 20304 RVA: 0x0001B438 File Offset: 0x00019638
			public unsafe static Func<Archetype, ArchetypeID> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136E RID: 4974
			// (get) Token: 0x06004F51 RID: 20305 RVA: 0x001A6C84 File Offset: 0x001A4E84
			// (set) Token: 0x06004F52 RID: 20306 RVA: 0x0001B44A File Offset: 0x0001964A
			public unsafe static Func<WormPlayer, IEnumerable<ArchetypeID>> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, IEnumerable<ArchetypeID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700136F RID: 4975
			// (get) Token: 0x06004F53 RID: 20307 RVA: 0x001A6CAC File Offset: 0x001A4EAC
			// (set) Token: 0x06004F54 RID: 20308 RVA: 0x0001B45C File Offset: 0x0001965C
			public unsafe static Func<Archetype, ArchetypeID> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001370 RID: 4976
			// (get) Token: 0x06004F55 RID: 20309 RVA: 0x001A6CD4 File Offset: 0x001A4ED4
			// (set) Token: 0x06004F56 RID: 20310 RVA: 0x0001B46E File Offset: 0x0001966E
			public unsafe static Func<WormPlayer, bool> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001371 RID: 4977
			// (get) Token: 0x06004F57 RID: 20311 RVA: 0x001A6CFC File Offset: 0x001A4EFC
			// (set) Token: 0x06004F58 RID: 20312 RVA: 0x0001B480 File Offset: 0x00019680
			public unsafe static Func<Archetype, int> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001372 RID: 4978
			// (get) Token: 0x06004F59 RID: 20313 RVA: 0x001A6D24 File Offset: 0x001A4F24
			// (set) Token: 0x06004F5A RID: 20314 RVA: 0x0001B492 File Offset: 0x00019692
			public unsafe static Func<Archetype, ArchetypeID> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001373 RID: 4979
			// (get) Token: 0x06004F5B RID: 20315 RVA: 0x001A6D4C File Offset: 0x001A4F4C
			// (set) Token: 0x06004F5C RID: 20316 RVA: 0x0001B4A4 File Offset: 0x000196A4
			public unsafe static Func<WormPlayer, bool> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001374 RID: 4980
			// (get) Token: 0x06004F5D RID: 20317 RVA: 0x001A6D74 File Offset: 0x001A4F74
			// (set) Token: 0x06004F5E RID: 20318 RVA: 0x0001B4B6 File Offset: 0x000196B6
			public unsafe static Func<WormPlayer, bool> __9__6_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__6_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001375 RID: 4981
			// (get) Token: 0x06004F5F RID: 20319 RVA: 0x001A6D9C File Offset: 0x001A4F9C
			// (set) Token: 0x06004F60 RID: 20320 RVA: 0x0001B4C8 File Offset: 0x000196C8
			public unsafe static Func<Archetype, ArchetypeID> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LeaderAssignmentModeExtension.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400340A RID: 13322
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400340B RID: 13323
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x0400340C RID: 13324
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400340D RID: 13325
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x0400340E RID: 13326
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400340F RID: 13327
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04003410 RID: 13328
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x04003411 RID: 13329
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04003412 RID: 13330
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04003413 RID: 13331
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x04003414 RID: 13332
			private static readonly IntPtr NativeFieldInfoPtr___9__6_4;

			// Token: 0x04003415 RID: 13333
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04003416 RID: 13334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003417 RID: 13335
			private static readonly IntPtr NativeMethodInfoPtr__StandardLeaderAssignment_b__3_1_Internal_ArchetypeID_Archetype_0;

			// Token: 0x04003418 RID: 13336
			private static readonly IntPtr NativeMethodInfoPtr__DraftLeaderAssignment_b__4_1_Internal_Int32_Archetype_0;

			// Token: 0x04003419 RID: 13337
			private static readonly IntPtr NativeMethodInfoPtr__DraftLeaderAssignment_b__4_2_Internal_ArchetypeID_Archetype_0;

			// Token: 0x0400341A RID: 13338
			private static readonly IntPtr NativeMethodInfoPtr__RandomLeaderAssignment_b__5_0_Internal_IEnumerable_1_ArchetypeID_WormPlayer_0;

			// Token: 0x0400341B RID: 13339
			private static readonly IntPtr NativeMethodInfoPtr__RandomLeaderAssignment_b__5_2_Internal_ArchetypeID_Archetype_0;

			// Token: 0x0400341C RID: 13340
			private static readonly IntPtr NativeMethodInfoPtr__RandomLeaderAssignment_b__5_3_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400341D RID: 13341
			private static readonly IntPtr NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_1_Internal_Int32_Archetype_0;

			// Token: 0x0400341E RID: 13342
			private static readonly IntPtr NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_2_Internal_ArchetypeID_Archetype_0;

			// Token: 0x0400341F RID: 13343
			private static readonly IntPtr NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_3_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003420 RID: 13344
			private static readonly IntPtr NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__6_4_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003421 RID: 13345
			private static readonly IntPtr NativeMethodInfoPtr__HagalLeaderAssignment_b__7_1_Internal_ArchetypeID_Archetype_0;
		}

		// Token: 0x0200062B RID: 1579
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06004F61 RID: 20321 RVA: 0x001A6DC4 File Offset: 0x001A4FC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_0>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_0>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_0>.NativeClassPtr, 100665953);
				LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeMethodInfoPtr__StandardLeaderAssignment_b__0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_0>.NativeClassPtr, 100665954);
			}

			// Token: 0x06004F62 RID: 20322 RVA: 0x001A6E2C File Offset: 0x001A502C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F63 RID: 20323 RVA: 0x001A6E68 File Offset: 0x001A5068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76141, XrefRangeEnd = 76148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StandardLeaderAssignment_b__0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeMethodInfoPtr__StandardLeaderAssignment_b__0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F64 RID: 20324 RVA: 0x0001B4DA File Offset: 0x000196DA
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001376 RID: 4982
			// (get) Token: 0x06004F65 RID: 20325 RVA: 0x001A6EB8 File Offset: 0x001A50B8
			// (set) Token: 0x06004F66 RID: 20326 RVA: 0x0001B4E3 File Offset: 0x000196E3
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass3_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003422 RID: 13346
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04003423 RID: 13347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003424 RID: 13348
			private static readonly IntPtr NativeMethodInfoPtr__StandardLeaderAssignment_b__0_Internal_Boolean_Archetype_0;
		}

		// Token: 0x0200062C RID: 1580
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x06004F67 RID: 20327 RVA: 0x001A6EE8 File Offset: 0x001A50E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_1>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_1>.NativeClassPtr, "options");
				LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_1>.NativeClassPtr, 100665955);
				LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeMethodInfoPtr__StandardLeaderAssignment_b__2_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_1>.NativeClassPtr, 100665956);
			}

			// Token: 0x06004F68 RID: 20328 RVA: 0x001A6F50 File Offset: 0x001A5150
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F69 RID: 20329 RVA: 0x001A6F8C File Offset: 0x001A518C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76148, XrefRangeEnd = 76152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StandardLeaderAssignment_b__2(ArchetypeID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeMethodInfoPtr__StandardLeaderAssignment_b__2_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F6A RID: 20330 RVA: 0x0001B502 File Offset: 0x00019702
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001377 RID: 4983
			// (get) Token: 0x06004F6B RID: 20331 RVA: 0x001A6FDC File Offset: 0x001A51DC
			// (set) Token: 0x06004F6C RID: 20332 RVA: 0x0001B50B File Offset: 0x0001970B
			public unsafe List<ArchetypeID> options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass3_1.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003425 RID: 13349
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04003426 RID: 13350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003427 RID: 13351
			private static readonly IntPtr NativeMethodInfoPtr__StandardLeaderAssignment_b__2_Internal_Boolean_ArchetypeID_0;
		}

		// Token: 0x0200062D RID: 1581
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06004F6D RID: 20333 RVA: 0x001A700C File Offset: 0x001A520C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass4_0>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass4_0>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass4_0>.NativeClassPtr, 100665957);
				LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeMethodInfoPtr__DraftLeaderAssignment_b__0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass4_0>.NativeClassPtr, 100665958);
			}

			// Token: 0x06004F6E RID: 20334 RVA: 0x001A7074 File Offset: 0x001A5274
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F6F RID: 20335 RVA: 0x001A70B0 File Offset: 0x001A52B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DraftLeaderAssignment_b__0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeMethodInfoPtr__DraftLeaderAssignment_b__0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F70 RID: 20336 RVA: 0x0001B52A File Offset: 0x0001972A
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001378 RID: 4984
			// (get) Token: 0x06004F71 RID: 20337 RVA: 0x001A7100 File Offset: 0x001A5300
			// (set) Token: 0x06004F72 RID: 20338 RVA: 0x0001B533 File Offset: 0x00019733
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass4_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003428 RID: 13352
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04003429 RID: 13353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400342A RID: 13354
			private static readonly IntPtr NativeMethodInfoPtr__DraftLeaderAssignment_b__0_Internal_Boolean_Archetype_0;
		}

		// Token: 0x0200062E RID: 1582
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06004F73 RID: 20339 RVA: 0x001A7130 File Offset: 0x001A5330
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeFieldInfoPtr_assignedLeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr, "assignedLeaders");
				LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr, 100665959);
				LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeMethodInfoPtr__RandomLeaderAssignment_b__1_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr, 100665960);
			}

			// Token: 0x06004F74 RID: 20340 RVA: 0x001A71AC File Offset: 0x001A53AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F75 RID: 20341 RVA: 0x001A71E8 File Offset: 0x001A53E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76152, XrefRangeEnd = 76164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RandomLeaderAssignment_b__1(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeMethodInfoPtr__RandomLeaderAssignment_b__1_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F76 RID: 20342 RVA: 0x0001B552 File Offset: 0x00019752
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001379 RID: 4985
			// (get) Token: 0x06004F77 RID: 20343 RVA: 0x001A7238 File Offset: 0x001A5438
			// (set) Token: 0x06004F78 RID: 20344 RVA: 0x0001B55B File Offset: 0x0001975B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700137A RID: 4986
			// (get) Token: 0x06004F79 RID: 20345 RVA: 0x001A7268 File Offset: 0x001A5468
			// (set) Token: 0x06004F7A RID: 20346 RVA: 0x0001B57A File Offset: 0x0001977A
			public unsafe List<ArchetypeID> assignedLeaders
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeFieldInfoPtr_assignedLeaders);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass5_0.NativeFieldInfoPtr_assignedLeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400342B RID: 13355
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400342C RID: 13356
			private static readonly IntPtr NativeFieldInfoPtr_assignedLeaders;

			// Token: 0x0400342D RID: 13357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400342E RID: 13358
			private static readonly IntPtr NativeMethodInfoPtr__RandomLeaderAssignment_b__1_Internal_Boolean_Archetype_0;
		}

		// Token: 0x0200062F RID: 1583
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06004F7B RID: 20347 RVA: 0x001A7298 File Offset: 0x001A5498
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass6_0>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass6_0>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass6_0>.NativeClassPtr, 100665961);
				LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass6_0>.NativeClassPtr, 100665962);
			}

			// Token: 0x06004F7C RID: 20348 RVA: 0x001A7300 File Offset: 0x001A5500
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F7D RID: 20349 RVA: 0x001A733C File Offset: 0x001A553C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CustomSoloLeaderAssignment_b__0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F7E RID: 20350 RVA: 0x0001B599 File Offset: 0x00019799
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700137B RID: 4987
			// (get) Token: 0x06004F7F RID: 20351 RVA: 0x001A738C File Offset: 0x001A558C
			// (set) Token: 0x06004F80 RID: 20352 RVA: 0x0001B5A2 File Offset: 0x000197A2
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass6_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400342F RID: 13359
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04003430 RID: 13360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003431 RID: 13361
			private static readonly IntPtr NativeMethodInfoPtr__CustomSoloLeaderAssignment_b__0_Internal_Boolean_Archetype_0;
		}

		// Token: 0x02000630 RID: 1584
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06004F81 RID: 20353 RVA: 0x001A73BC File Offset: 0x001A55BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass7_0>.NativeClassPtr);
				LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass7_0>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass7_0>.NativeClassPtr, 100665963);
				LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeMethodInfoPtr__HagalLeaderAssignment_b__0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass7_0>.NativeClassPtr, 100665964);
			}

			// Token: 0x06004F82 RID: 20354 RVA: 0x001A7424 File Offset: 0x001A5624
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F83 RID: 20355 RVA: 0x001A7460 File Offset: 0x001A5660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76164, XrefRangeEnd = 76180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HagalLeaderAssignment_b__0(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeMethodInfoPtr__HagalLeaderAssignment_b__0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004F84 RID: 20356 RVA: 0x0001B5C1 File Offset: 0x000197C1
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700137C RID: 4988
			// (get) Token: 0x06004F85 RID: 20357 RVA: 0x001A74B0 File Offset: 0x001A56B0
			// (set) Token: 0x06004F86 RID: 20358 RVA: 0x0001B5CA File Offset: 0x000197CA
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension.__c__DisplayClass7_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003432 RID: 13362
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04003433 RID: 13363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003434 RID: 13364
			private static readonly IntPtr NativeMethodInfoPtr__HagalLeaderAssignment_b__0_Internal_Boolean_Archetype_0;
		}

		// Token: 0x02000631 RID: 1585
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<CustomSoloLeaderAssignment>d__6")]
		public sealed class _CustomSoloLeaderAssignment_d__6 : Object
		{
			// Token: 0x06004F87 RID: 20359 RVA: 0x001A74E0 File Offset: 0x001A56E0
			// Note: this type is marked as 'beforefieldinit'.
			static _CustomSoloLeaderAssignment_d__6()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<CustomSoloLeaderAssignment>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>1__state");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>2__current");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>l__initialThreadId");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>3__match");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>8__1");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr__leaderArchetypes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<leaderArchetypes>5__2");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>7__wrap2");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, "<>7__wrap3");
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665965);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665966);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665967);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665968);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665969);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665970);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665971);
				LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr, 100665972);
			}

			// Token: 0x06004F88 RID: 20360 RVA: 0x001A7660 File Offset: 0x001A5860
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CustomSoloLeaderAssignment_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F89 RID: 20361 RVA: 0x001A76A8 File Offset: 0x001A58A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F8A RID: 20362 RVA: 0x001A76DC File Offset: 0x001A58DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76180, XrefRangeEnd = 76311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001386 RID: 4998
			// (get) Token: 0x06004F8B RID: 20363 RVA: 0x001A7718 File Offset: 0x001A5918
			public unsafe AssignLeader System.Collections.Generic.IEnumerator<worm.canis.actions.AssignLeader>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr3) : null;
				}
			}

			// Token: 0x06004F8C RID: 20364 RVA: 0x001A7758 File Offset: 0x001A5958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76311, XrefRangeEnd = 76316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001387 RID: 4999
			// (get) Token: 0x06004F8D RID: 20365 RVA: 0x001A778C File Offset: 0x001A598C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F8E RID: 20366 RVA: 0x001A77CC File Offset: 0x001A59CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76316, XrefRangeEnd = 76324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<AssignLeader> System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr3) : null;
			}

			// Token: 0x06004F8F RID: 20367 RVA: 0x001A780C File Offset: 0x001A5A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004F90 RID: 20368 RVA: 0x0001B5E9 File Offset: 0x000197E9
			public _CustomSoloLeaderAssignment_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700137D RID: 4989
			// (get) Token: 0x06004F91 RID: 20369 RVA: 0x001A784C File Offset: 0x001A5A4C
			// (set) Token: 0x06004F92 RID: 20370 RVA: 0x0001B5F2 File Offset: 0x000197F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700137E RID: 4990
			// (get) Token: 0x06004F93 RID: 20371 RVA: 0x001A7874 File Offset: 0x001A5A74
			// (set) Token: 0x06004F94 RID: 20372 RVA: 0x0001B60D File Offset: 0x0001980D
			public unsafe AssignLeader __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700137F RID: 4991
			// (get) Token: 0x06004F95 RID: 20373 RVA: 0x001A78A4 File Offset: 0x001A5AA4
			// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0001B62C File Offset: 0x0001982C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001380 RID: 4992
			// (get) Token: 0x06004F97 RID: 20375 RVA: 0x001A78CC File Offset: 0x001A5ACC
			// (set) Token: 0x06004F98 RID: 20376 RVA: 0x0001B647 File Offset: 0x00019847
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001381 RID: 4993
			// (get) Token: 0x06004F99 RID: 20377 RVA: 0x001A78FC File Offset: 0x001A5AFC
			// (set) Token: 0x06004F9A RID: 20378 RVA: 0x0001B666 File Offset: 0x00019866
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001382 RID: 4994
			// (get) Token: 0x06004F9B RID: 20379 RVA: 0x001A792C File Offset: 0x001A5B2C
			// (set) Token: 0x06004F9C RID: 20380 RVA: 0x0001B685 File Offset: 0x00019885
			public unsafe LeaderAssignmentModeExtension.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderAssignmentModeExtension.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001383 RID: 4995
			// (get) Token: 0x06004F9D RID: 20381 RVA: 0x001A795C File Offset: 0x001A5B5C
			// (set) Token: 0x06004F9E RID: 20382 RVA: 0x0001B6A4 File Offset: 0x000198A4
			public unsafe List<ArchetypeID> _leaderArchetypes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr__leaderArchetypes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr__leaderArchetypes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001384 RID: 4996
			// (get) Token: 0x06004F9F RID: 20383 RVA: 0x001A798C File Offset: 0x001A5B8C
			// (set) Token: 0x06004FA0 RID: 20384 RVA: 0x0001B6C3 File Offset: 0x000198C3
			public unsafe Il2CppReferenceArray<WormPlayer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001385 RID: 4997
			// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x001A79BC File Offset: 0x001A5BBC
			// (set) Token: 0x06004FA2 RID: 20386 RVA: 0x0001B6E2 File Offset: 0x000198E2
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._CustomSoloLeaderAssignment_d__6.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x04003435 RID: 13365
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003436 RID: 13366
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003437 RID: 13367
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003438 RID: 13368
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04003439 RID: 13369
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400343A RID: 13370
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400343B RID: 13371
			private static readonly IntPtr NativeFieldInfoPtr__leaderArchetypes_5__2;

			// Token: 0x0400343C RID: 13372
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400343D RID: 13373
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400343E RID: 13374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400343F RID: 13375
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003440 RID: 13376
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003441 RID: 13377
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0;

			// Token: 0x04003442 RID: 13378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003443 RID: 13379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003444 RID: 13380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0;

			// Token: 0x04003445 RID: 13381
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000632 RID: 1586
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<DraftLeaderAssignment>d__4")]
		public sealed class _DraftLeaderAssignment_d__4 : Object
		{
			// Token: 0x06004FA3 RID: 20387 RVA: 0x001A79E4 File Offset: 0x001A5BE4
			// Note: this type is marked as 'beforefieldinit'.
			static _DraftLeaderAssignment_d__4()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<DraftLeaderAssignment>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>1__state");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>2__current");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>l__initialThreadId");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>3__match");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>8__1");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>7__wrap1");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, "<>7__wrap2");
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665973);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665974);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665975);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665976);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665977);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665978);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665979);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665980);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665981);
				LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr, 100665982);
			}

			// Token: 0x06004FA4 RID: 20388 RVA: 0x001A7B78 File Offset: 0x001A5D78
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DraftLeaderAssignment_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FA5 RID: 20389 RVA: 0x001A7BC0 File Offset: 0x001A5DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76324, XrefRangeEnd = 76334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FA6 RID: 20390 RVA: 0x001A7BF4 File Offset: 0x001A5DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76334, XrefRangeEnd = 76460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FA7 RID: 20391 RVA: 0x001A7C30 File Offset: 0x001A5E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76460, XrefRangeEnd = 76463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FA8 RID: 20392 RVA: 0x001A7C64 File Offset: 0x001A5E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76463, XrefRangeEnd = 76466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001390 RID: 5008
			// (get) Token: 0x06004FA9 RID: 20393 RVA: 0x001A7C98 File Offset: 0x001A5E98
			public unsafe AssignLeader System.Collections.Generic.IEnumerator<worm.canis.actions.AssignLeader>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr3) : null;
				}
			}

			// Token: 0x06004FAA RID: 20394 RVA: 0x001A7CD8 File Offset: 0x001A5ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76466, XrefRangeEnd = 76471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001391 RID: 5009
			// (get) Token: 0x06004FAB RID: 20395 RVA: 0x001A7D0C File Offset: 0x001A5F0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FAC RID: 20396 RVA: 0x001A7D4C File Offset: 0x001A5F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76471, XrefRangeEnd = 76479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<AssignLeader> System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr3) : null;
			}

			// Token: 0x06004FAD RID: 20397 RVA: 0x001A7D8C File Offset: 0x001A5F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004FAE RID: 20398 RVA: 0x0001B6FD File Offset: 0x000198FD
			public _DraftLeaderAssignment_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001388 RID: 5000
			// (get) Token: 0x06004FAF RID: 20399 RVA: 0x001A7DCC File Offset: 0x001A5FCC
			// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x0001B706 File Offset: 0x00019906
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001389 RID: 5001
			// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x001A7DF4 File Offset: 0x001A5FF4
			// (set) Token: 0x06004FB2 RID: 20402 RVA: 0x0001B721 File Offset: 0x00019921
			public unsafe AssignLeader __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138A RID: 5002
			// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x001A7E24 File Offset: 0x001A6024
			// (set) Token: 0x06004FB4 RID: 20404 RVA: 0x0001B740 File Offset: 0x00019940
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700138B RID: 5003
			// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x001A7E4C File Offset: 0x001A604C
			// (set) Token: 0x06004FB6 RID: 20406 RVA: 0x0001B75B File Offset: 0x0001995B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138C RID: 5004
			// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x001A7E7C File Offset: 0x001A607C
			// (set) Token: 0x06004FB8 RID: 20408 RVA: 0x0001B77A File Offset: 0x0001997A
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138D RID: 5005
			// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x001A7EAC File Offset: 0x001A60AC
			// (set) Token: 0x06004FBA RID: 20410 RVA: 0x0001B799 File Offset: 0x00019999
			public unsafe LeaderAssignmentModeExtension.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderAssignmentModeExtension.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138E RID: 5006
			// (get) Token: 0x06004FBB RID: 20411 RVA: 0x001A7EDC File Offset: 0x001A60DC
			// (set) Token: 0x06004FBC RID: 20412 RVA: 0x0001B7B8 File Offset: 0x000199B8
			public unsafe IEnumerator<WormPlayer> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700138F RID: 5007
			// (get) Token: 0x06004FBD RID: 20413 RVA: 0x001A7F0C File Offset: 0x001A610C
			// (set) Token: 0x06004FBE RID: 20414 RVA: 0x0001B7D7 File Offset: 0x000199D7
			public unsafe IEnumerator<AssignLeader> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._DraftLeaderAssignment_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003446 RID: 13382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003447 RID: 13383
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003448 RID: 13384
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003449 RID: 13385
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400344A RID: 13386
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400344B RID: 13387
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400344C RID: 13388
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400344D RID: 13389
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400344E RID: 13390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400344F RID: 13391
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003450 RID: 13392
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003451 RID: 13393
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003452 RID: 13394
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003453 RID: 13395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0;

			// Token: 0x04003454 RID: 13396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003455 RID: 13397
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003456 RID: 13398
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0;

			// Token: 0x04003457 RID: 13399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000633 RID: 1587
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<HagalLeaderAssignment>d__7")]
		public sealed class _HagalLeaderAssignment_d__7 : Object
		{
			// Token: 0x06004FBF RID: 20415 RVA: 0x001A7F3C File Offset: 0x001A613C
			// Note: this type is marked as 'beforefieldinit'.
			static _HagalLeaderAssignment_d__7()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<HagalLeaderAssignment>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>1__state");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>2__current");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>l__initialThreadId");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>3__match");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>8__1");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr__hagalArchetypes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<hagalArchetypes>5__2");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>7__wrap2");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, "<>7__wrap3");
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665983);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665984);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665985);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665986);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665987);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665988);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665989);
				LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr, 100665990);
			}

			// Token: 0x06004FC0 RID: 20416 RVA: 0x001A80BC File Offset: 0x001A62BC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HagalLeaderAssignment_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FC1 RID: 20417 RVA: 0x001A8104 File Offset: 0x001A6304
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FC2 RID: 20418 RVA: 0x001A8138 File Offset: 0x001A6338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76479, XrefRangeEnd = 76547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700139B RID: 5019
			// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x001A8174 File Offset: 0x001A6374
			public unsafe AssignLeader System.Collections.Generic.IEnumerator<worm.canis.actions.AssignLeader>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x001A81B4 File Offset: 0x001A63B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76547, XrefRangeEnd = 76552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700139C RID: 5020
			// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x001A81E8 File Offset: 0x001A63E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FC6 RID: 20422 RVA: 0x001A8228 File Offset: 0x001A6428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76552, XrefRangeEnd = 76560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<AssignLeader> System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr3) : null;
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x001A8268 File Offset: 0x001A6468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004FC8 RID: 20424 RVA: 0x0001B7F6 File Offset: 0x000199F6
			public _HagalLeaderAssignment_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001392 RID: 5010
			// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x001A82A8 File Offset: 0x001A64A8
			// (set) Token: 0x06004FCA RID: 20426 RVA: 0x0001B7FF File Offset: 0x000199FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001393 RID: 5011
			// (get) Token: 0x06004FCB RID: 20427 RVA: 0x001A82D0 File Offset: 0x001A64D0
			// (set) Token: 0x06004FCC RID: 20428 RVA: 0x0001B81A File Offset: 0x00019A1A
			public unsafe AssignLeader __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001394 RID: 5012
			// (get) Token: 0x06004FCD RID: 20429 RVA: 0x001A8300 File Offset: 0x001A6500
			// (set) Token: 0x06004FCE RID: 20430 RVA: 0x0001B839 File Offset: 0x00019A39
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001395 RID: 5013
			// (get) Token: 0x06004FCF RID: 20431 RVA: 0x001A8328 File Offset: 0x001A6528
			// (set) Token: 0x06004FD0 RID: 20432 RVA: 0x0001B854 File Offset: 0x00019A54
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001396 RID: 5014
			// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x001A8358 File Offset: 0x001A6558
			// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x0001B873 File Offset: 0x00019A73
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001397 RID: 5015
			// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x001A8388 File Offset: 0x001A6588
			// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x0001B892 File Offset: 0x00019A92
			public unsafe LeaderAssignmentModeExtension.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderAssignmentModeExtension.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001398 RID: 5016
			// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x001A83B8 File Offset: 0x001A65B8
			// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x0001B8B1 File Offset: 0x00019AB1
			public unsafe List<ArchetypeID> _hagalArchetypes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr__hagalArchetypes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr__hagalArchetypes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001399 RID: 5017
			// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x001A83E8 File Offset: 0x001A65E8
			// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x0001B8D0 File Offset: 0x00019AD0
			public unsafe Il2CppReferenceArray<WormPlayer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700139A RID: 5018
			// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x001A8418 File Offset: 0x001A6618
			// (set) Token: 0x06004FDA RID: 20442 RVA: 0x0001B8EF File Offset: 0x00019AEF
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._HagalLeaderAssignment_d__7.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x04003458 RID: 13400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003459 RID: 13401
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400345A RID: 13402
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400345B RID: 13403
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400345C RID: 13404
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400345D RID: 13405
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400345E RID: 13406
			private static readonly IntPtr NativeFieldInfoPtr__hagalArchetypes_5__2;

			// Token: 0x0400345F RID: 13407
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04003460 RID: 13408
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003461 RID: 13409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003462 RID: 13410
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003463 RID: 13411
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003464 RID: 13412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0;

			// Token: 0x04003465 RID: 13413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003466 RID: 13414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003467 RID: 13415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0;

			// Token: 0x04003468 RID: 13416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000634 RID: 1588
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<RandomLeaderAssignment>d__5")]
		public sealed class _RandomLeaderAssignment_d__5 : Object
		{
			// Token: 0x06004FDB RID: 20443 RVA: 0x001A8440 File Offset: 0x001A6640
			// Note: this type is marked as 'beforefieldinit'.
			static _RandomLeaderAssignment_d__5()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<RandomLeaderAssignment>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<>1__state");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<>2__current");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<>l__initialThreadId");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<>3__match");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<>8__1");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__leaderArchetypes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<leaderArchetypes>5__2");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__unassignedPlayers_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<unassignedPlayers>5__3");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<i>5__4");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, "<>7__wrap4");
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665991);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665992);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665993);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665994);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665995);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665996);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665997);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665998);
				LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr, 100665999);
			}

			// Token: 0x06004FDC RID: 20444 RVA: 0x001A85E8 File Offset: 0x001A67E8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RandomLeaderAssignment_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FDD RID: 20445 RVA: 0x001A8630 File Offset: 0x001A6830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76560, XrefRangeEnd = 76565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FDE RID: 20446 RVA: 0x001A8664 File Offset: 0x001A6864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76565, XrefRangeEnd = 76688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FDF RID: 20447 RVA: 0x001A86A0 File Offset: 0x001A68A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76688, XrefRangeEnd = 76691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013A7 RID: 5031
			// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x001A86D4 File Offset: 0x001A68D4
			public unsafe AssignLeader System.Collections.Generic.IEnumerator<worm.canis.actions.AssignLeader>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE1 RID: 20449 RVA: 0x001A8714 File Offset: 0x001A6914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76691, XrefRangeEnd = 76696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013A8 RID: 5032
			// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x001A8748 File Offset: 0x001A6948
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FE3 RID: 20451 RVA: 0x001A8788 File Offset: 0x001A6988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76696, XrefRangeEnd = 76704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<AssignLeader> System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr3) : null;
			}

			// Token: 0x06004FE4 RID: 20452 RVA: 0x001A87C8 File Offset: 0x001A69C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004FE5 RID: 20453 RVA: 0x0001B90A File Offset: 0x00019B0A
			public _RandomLeaderAssignment_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700139D RID: 5021
			// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x001A8808 File Offset: 0x001A6A08
			// (set) Token: 0x06004FE7 RID: 20455 RVA: 0x0001B913 File Offset: 0x00019B13
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700139E RID: 5022
			// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x001A8830 File Offset: 0x001A6A30
			// (set) Token: 0x06004FE9 RID: 20457 RVA: 0x0001B92E File Offset: 0x00019B2E
			public unsafe AssignLeader __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700139F RID: 5023
			// (get) Token: 0x06004FEA RID: 20458 RVA: 0x001A8860 File Offset: 0x001A6A60
			// (set) Token: 0x06004FEB RID: 20459 RVA: 0x0001B94D File Offset: 0x00019B4D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170013A0 RID: 5024
			// (get) Token: 0x06004FEC RID: 20460 RVA: 0x001A8888 File Offset: 0x001A6A88
			// (set) Token: 0x06004FED RID: 20461 RVA: 0x0001B968 File Offset: 0x00019B68
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A1 RID: 5025
			// (get) Token: 0x06004FEE RID: 20462 RVA: 0x001A88B8 File Offset: 0x001A6AB8
			// (set) Token: 0x06004FEF RID: 20463 RVA: 0x0001B987 File Offset: 0x00019B87
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A2 RID: 5026
			// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x001A88E8 File Offset: 0x001A6AE8
			// (set) Token: 0x06004FF1 RID: 20465 RVA: 0x0001B9A6 File Offset: 0x00019BA6
			public unsafe LeaderAssignmentModeExtension.__c__DisplayClass5_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderAssignmentModeExtension.__c__DisplayClass5_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A3 RID: 5027
			// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x001A8918 File Offset: 0x001A6B18
			// (set) Token: 0x06004FF3 RID: 20467 RVA: 0x0001B9C5 File Offset: 0x00019BC5
			public unsafe List<ArchetypeID> _leaderArchetypes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__leaderArchetypes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__leaderArchetypes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A4 RID: 5028
			// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x001A8948 File Offset: 0x001A6B48
			// (set) Token: 0x06004FF5 RID: 20469 RVA: 0x0001B9E4 File Offset: 0x00019BE4
			public unsafe Il2CppReferenceArray<WormPlayer> _unassignedPlayers_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__unassignedPlayers_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__unassignedPlayers_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013A5 RID: 5029
			// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x001A8978 File Offset: 0x001A6B78
			// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x0001BA03 File Offset: 0x00019C03
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x170013A6 RID: 5030
			// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x001A89A0 File Offset: 0x001A6BA0
			// (set) Token: 0x06004FF9 RID: 20473 RVA: 0x0001BA1E File Offset: 0x00019C1E
			public unsafe IEnumerator<AssignLeader> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._RandomLeaderAssignment_d__5.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003469 RID: 13417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400346A RID: 13418
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400346B RID: 13419
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400346C RID: 13420
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400346D RID: 13421
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400346E RID: 13422
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400346F RID: 13423
			private static readonly IntPtr NativeFieldInfoPtr__leaderArchetypes_5__2;

			// Token: 0x04003470 RID: 13424
			private static readonly IntPtr NativeFieldInfoPtr__unassignedPlayers_5__3;

			// Token: 0x04003471 RID: 13425
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04003472 RID: 13426
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04003473 RID: 13427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003474 RID: 13428
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003475 RID: 13429
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003476 RID: 13430
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003477 RID: 13431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0;

			// Token: 0x04003478 RID: 13432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003479 RID: 13433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400347A RID: 13434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0;

			// Token: 0x0400347B RID: 13435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000635 RID: 1589
		[ObfuscatedName("worm.canis.data.enums.LeaderAssignmentModeExtension+<StandardLeaderAssignment>d__3")]
		public sealed class _StandardLeaderAssignment_d__3 : Object
		{
			// Token: 0x06004FFA RID: 20474 RVA: 0x001A89D0 File Offset: 0x001A6BD0
			// Note: this type is marked as 'beforefieldinit'.
			static _StandardLeaderAssignment_d__3()
			{
				Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeaderAssignmentModeExtension>.NativeClassPtr, "<StandardLeaderAssignment>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>1__state");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>2__current");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>l__initialThreadId");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "match");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>3__match");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>8__1");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr__leaderArchetypes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<leaderArchetypes>5__2");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>7__wrap2");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, "<>7__wrap3");
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666000);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666001);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666002);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666003);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666004);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666005);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666006);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666007);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666008);
				LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr, 100666009);
			}

			// Token: 0x06004FFB RID: 20475 RVA: 0x001A8B78 File Offset: 0x001A6D78
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StandardLeaderAssignment_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FFC RID: 20476 RVA: 0x001A8BC0 File Offset: 0x001A6DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76704, XrefRangeEnd = 76714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FFD RID: 20477 RVA: 0x001A8BF4 File Offset: 0x001A6DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76714, XrefRangeEnd = 76841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004FFE RID: 20478 RVA: 0x001A8C30 File Offset: 0x001A6E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76841, XrefRangeEnd = 76844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FFF RID: 20479 RVA: 0x001A8C64 File Offset: 0x001A6E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76844, XrefRangeEnd = 76847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013B2 RID: 5042
			// (get) Token: 0x06005000 RID: 20480 RVA: 0x001A8C98 File Offset: 0x001A6E98
			public unsafe AssignLeader System.Collections.Generic.IEnumerator<worm.canis.actions.AssignLeader>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr3) : null;
				}
			}

			// Token: 0x06005001 RID: 20481 RVA: 0x001A8CD8 File Offset: 0x001A6ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76847, XrefRangeEnd = 76852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013B3 RID: 5043
			// (get) Token: 0x06005002 RID: 20482 RVA: 0x001A8D0C File Offset: 0x001A6F0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005003 RID: 20483 RVA: 0x001A8D4C File Offset: 0x001A6F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76852, XrefRangeEnd = 76860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<AssignLeader> System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr3) : null;
			}

			// Token: 0x06005004 RID: 20484 RVA: 0x001A8D8C File Offset: 0x001A6F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005005 RID: 20485 RVA: 0x0001BA3D File Offset: 0x00019C3D
			public _StandardLeaderAssignment_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013A9 RID: 5033
			// (get) Token: 0x06005006 RID: 20486 RVA: 0x001A8DCC File Offset: 0x001A6FCC
			// (set) Token: 0x06005007 RID: 20487 RVA: 0x0001BA46 File Offset: 0x00019C46
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170013AA RID: 5034
			// (get) Token: 0x06005008 RID: 20488 RVA: 0x001A8DF4 File Offset: 0x001A6FF4
			// (set) Token: 0x06005009 RID: 20489 RVA: 0x0001BA61 File Offset: 0x00019C61
			public unsafe AssignLeader __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AB RID: 5035
			// (get) Token: 0x0600500A RID: 20490 RVA: 0x001A8E24 File Offset: 0x001A7024
			// (set) Token: 0x0600500B RID: 20491 RVA: 0x0001BA80 File Offset: 0x00019C80
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170013AC RID: 5036
			// (get) Token: 0x0600500C RID: 20492 RVA: 0x001A8E4C File Offset: 0x001A704C
			// (set) Token: 0x0600500D RID: 20493 RVA: 0x0001BA9B File Offset: 0x00019C9B
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AD RID: 5037
			// (get) Token: 0x0600500E RID: 20494 RVA: 0x001A8E7C File Offset: 0x001A707C
			// (set) Token: 0x0600500F RID: 20495 RVA: 0x0001BABA File Offset: 0x00019CBA
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AE RID: 5038
			// (get) Token: 0x06005010 RID: 20496 RVA: 0x001A8EAC File Offset: 0x001A70AC
			// (set) Token: 0x06005011 RID: 20497 RVA: 0x0001BAD9 File Offset: 0x00019CD9
			public unsafe LeaderAssignmentModeExtension.__c__DisplayClass3_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderAssignmentModeExtension.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013AF RID: 5039
			// (get) Token: 0x06005012 RID: 20498 RVA: 0x001A8EDC File Offset: 0x001A70DC
			// (set) Token: 0x06005013 RID: 20499 RVA: 0x0001BAF8 File Offset: 0x00019CF8
			public unsafe List<ArchetypeID> _leaderArchetypes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr__leaderArchetypes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr__leaderArchetypes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B0 RID: 5040
			// (get) Token: 0x06005014 RID: 20500 RVA: 0x001A8F0C File Offset: 0x001A710C
			// (set) Token: 0x06005015 RID: 20501 RVA: 0x0001BB17 File Offset: 0x00019D17
			public unsafe IEnumerator<WormPlayer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013B1 RID: 5041
			// (get) Token: 0x06005016 RID: 20502 RVA: 0x001A8F3C File Offset: 0x001A713C
			// (set) Token: 0x06005017 RID: 20503 RVA: 0x0001BB36 File Offset: 0x00019D36
			public unsafe IEnumerator<AssignLeader> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<AssignLeader>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderAssignmentModeExtension._StandardLeaderAssignment_d__3.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400347C RID: 13436
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400347D RID: 13437
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400347E RID: 13438
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400347F RID: 13439
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04003480 RID: 13440
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04003481 RID: 13441
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003482 RID: 13442
			private static readonly IntPtr NativeFieldInfoPtr__leaderArchetypes_5__2;

			// Token: 0x04003483 RID: 13443
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04003484 RID: 13444
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003485 RID: 13445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003486 RID: 13446
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003487 RID: 13447
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003488 RID: 13448
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003489 RID: 13449
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400348A RID: 13450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_actions_AssignLeader__get_Current_Private_Virtual_Final_New_get_AssignLeader_0;

			// Token: 0x0400348B RID: 13451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400348C RID: 13452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400348D RID: 13453
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_actions_AssignLeader__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_AssignLeader_0;

			// Token: 0x0400348E RID: 13454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
