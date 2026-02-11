using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions;

namespace worm.canis.entities
{
	// Token: 0x0200003A RID: 58
	public class WormTleilaxuTrack : WormTrack
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x0007E0FC File Offset: 0x0007C2FC
		// Note: this type is marked as 'beforefieldinit'.
		static WormTleilaxuTrack()
		{
			Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormTleilaxuTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr);
			WormTleilaxuTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, 100664666);
			WormTleilaxuTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, 100664667);
			WormTleilaxuTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, 100664668);
			WormTleilaxuTrack.NativeMethodInfoPtr_GetRankBonuses_Private_List_1_ValueTuple_2_AttributeDefinition_1_Nullable_1_Int32_Int32_WormPlayer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, 100664669);
			WormTleilaxuTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, 100664670);
			WormTleilaxuTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, 100664671);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0007E1A4 File Offset: 0x0007C3A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48742, RefRangeEnd = 48744, XrefRangeStart = 48721, XrefRangeEnd = 48742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxuTrack(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0007E1F0 File Offset: 0x0007C3F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45845, RefRangeEnd = 45848, XrefRangeStart = 45845, XrefRangeEnd = 45848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxuTrack(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0007E260 File Offset: 0x0007C460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48744, XrefRangeEnd = 48831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTleilaxuTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0007E29C File Offset: 0x0007C49C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48868, RefRangeEnd = 48870, XrefRangeStart = 48831, XrefRangeEnd = 48868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<AttributeDefinition<Nullable<int>>, int>> GetRankBonuses(WormPlayer player, int currentRank, int newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack.NativeMethodInfoPtr_GetRankBonuses_Private_List_1_ValueTuple_2_AttributeDefinition_1_Nullable_1_Int32_Int32_WormPlayer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>>(intPtr3) : null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0007E308 File Offset: 0x0007C508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48870, XrefRangeEnd = 48877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> ChangeRankBonuses(WormPlayer player, int currentRank, int newRank, ActionLogModes logMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTleilaxuTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0007E390 File Offset: 0x0007C590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48877, XrefRangeEnd = 48885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> ChangeRank(WormPlayer player, global::Canis.actions.Action triggeringAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeringAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTleilaxuTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00003D6C File Offset: 0x00001F6C
		public WormTleilaxuTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_GetRankBonuses_Private_List_1_ValueTuple_2_AttributeDefinition_1_Nullable_1_Int32_Int32_WormPlayer_Int32_Int32_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0;

		// Token: 0x020005D7 RID: 1495
		[ObfuscatedName("worm.canis.entities.WormTleilaxuTrack+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060048A0 RID: 18592 RVA: 0x0018F2E4 File Offset: 0x0018D4E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr);
				WormTleilaxuTrack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr, "<>9");
				WormTleilaxuTrack.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr, "<>9__5_0");
				WormTleilaxuTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr, 100664673);
				WormTleilaxuTrack.__c.NativeMethodInfoPtr__ChangeRank_b__5_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr, 100664674);
			}

			// Token: 0x060048A1 RID: 18593 RVA: 0x0018F360 File Offset: 0x0018D560
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048A2 RID: 18594 RVA: 0x0018F39C File Offset: 0x0018D59C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeRank_b__5_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack.__c.NativeMethodInfoPtr__ChangeRank_b__5_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060048A3 RID: 18595 RVA: 0x0001899A File Offset: 0x00016B9A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001194 RID: 4500
			// (get) Token: 0x060048A4 RID: 18596 RVA: 0x0018F3EC File Offset: 0x0018D5EC
			// (set) Token: 0x060048A5 RID: 18597 RVA: 0x000189A3 File Offset: 0x00016BA3
			public unsafe static WormTleilaxuTrack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTleilaxuTrack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTleilaxuTrack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001195 RID: 4501
			// (get) Token: 0x060048A6 RID: 18598 RVA: 0x0018F414 File Offset: 0x0018D614
			// (set) Token: 0x060048A7 RID: 18599 RVA: 0x000189B5 File Offset: 0x00016BB5
			public unsafe static Func<WormPlayer, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormTleilaxuTrack.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormTleilaxuTrack.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FBB RID: 12219
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002FBC RID: 12220
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04002FBD RID: 12221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002FBE RID: 12222
			private static readonly IntPtr NativeMethodInfoPtr__ChangeRank_b__5_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020005D8 RID: 1496
		[ObfuscatedName("worm.canis.entities.WormTleilaxuTrack+<ChangeRank>d__5")]
		public sealed class _ChangeRank_d__5 : Object
		{
			// Token: 0x060048A8 RID: 18600 RVA: 0x0018F43C File Offset: 0x0018D63C
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRank_d__5()
			{
				Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, "<ChangeRank>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr);
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>1__state");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>2__current");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>l__initialThreadId");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr_triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "triggeringAction");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___3__triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>3__triggeringAction");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>4__this");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "player");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>3__player");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__amount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<amount>5__2");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__logMode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<logMode>5__3");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__marker_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<marker>5__4");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__currentRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<currentRank>5__5");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__newRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<newRank>5__6");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__childUndo_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<childUndo>5__7");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__newRankSpace_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<newRankSpace>5__8");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__i_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<i>5__9");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__bonusResources_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<bonusResources>5__10");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__sequenceHelper_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<sequenceHelper>5__11");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>7__wrap11");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>7__wrap12");
				WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, "<>7__wrap13");
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664675);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664676);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664677);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664678);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664679);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664680);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664681);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664682);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664683);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664684);
				WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr, 100664685);
			}

			// Token: 0x060048A9 RID: 18601 RVA: 0x0018F6E8 File Offset: 0x0018D8E8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRank_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRank_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060048AA RID: 18602 RVA: 0x0018F730 File Offset: 0x0018D930
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048AB RID: 18603 RVA: 0x0018F764 File Offset: 0x0018D964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48202, XrefRangeEnd = 48469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060048AC RID: 18604 RVA: 0x0018F7A0 File Offset: 0x0018D9A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48472, RefRangeEnd = 48473, XrefRangeStart = 48469, XrefRangeEnd = 48472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048AD RID: 18605 RVA: 0x0018F7D4 File Offset: 0x0018D9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48473, XrefRangeEnd = 48476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048AE RID: 18606 RVA: 0x0018F808 File Offset: 0x0018DA08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48479, RefRangeEnd = 48480, XrefRangeStart = 48476, XrefRangeEnd = 48479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011AB RID: 4523
			// (get) Token: 0x060048AF RID: 18607 RVA: 0x0018F83C File Offset: 0x0018DA3C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060048B0 RID: 18608 RVA: 0x0018F87C File Offset: 0x0018DA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48480, XrefRangeEnd = 48485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011AC RID: 4524
			// (get) Token: 0x060048B1 RID: 18609 RVA: 0x0018F8B0 File Offset: 0x0018DAB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060048B2 RID: 18610 RVA: 0x0018F8F0 File Offset: 0x0018DAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48485, XrefRangeEnd = 48495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060048B3 RID: 18611 RVA: 0x0018F930 File Offset: 0x0018DB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRank_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060048B4 RID: 18612 RVA: 0x000189C7 File Offset: 0x00016BC7
			public _ChangeRank_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001196 RID: 4502
			// (get) Token: 0x060048B5 RID: 18613 RVA: 0x0018F970 File Offset: 0x0018DB70
			// (set) Token: 0x060048B6 RID: 18614 RVA: 0x000189D0 File Offset: 0x00016BD0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001197 RID: 4503
			// (get) Token: 0x060048B7 RID: 18615 RVA: 0x0018F998 File Offset: 0x0018DB98
			// (set) Token: 0x060048B8 RID: 18616 RVA: 0x000189EB File Offset: 0x00016BEB
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001198 RID: 4504
			// (get) Token: 0x060048B9 RID: 18617 RVA: 0x0018F9C8 File Offset: 0x0018DBC8
			// (set) Token: 0x060048BA RID: 18618 RVA: 0x00018A0A File Offset: 0x00016C0A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001199 RID: 4505
			// (get) Token: 0x060048BB RID: 18619 RVA: 0x0018F9F0 File Offset: 0x0018DBF0
			// (set) Token: 0x060048BC RID: 18620 RVA: 0x00018A25 File Offset: 0x00016C25
			public unsafe global::Canis.actions.Action triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr_triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr_triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119A RID: 4506
			// (get) Token: 0x060048BD RID: 18621 RVA: 0x0018FA20 File Offset: 0x0018DC20
			// (set) Token: 0x060048BE RID: 18622 RVA: 0x00018A44 File Offset: 0x00016C44
			public unsafe global::Canis.actions.Action __3__triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___3__triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___3__triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119B RID: 4507
			// (get) Token: 0x060048BF RID: 18623 RVA: 0x0018FA50 File Offset: 0x0018DC50
			// (set) Token: 0x060048C0 RID: 18624 RVA: 0x00018A63 File Offset: 0x00016C63
			public unsafe WormTleilaxuTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119C RID: 4508
			// (get) Token: 0x060048C1 RID: 18625 RVA: 0x0018FA80 File Offset: 0x0018DC80
			// (set) Token: 0x060048C2 RID: 18626 RVA: 0x00018A82 File Offset: 0x00016C82
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119D RID: 4509
			// (get) Token: 0x060048C3 RID: 18627 RVA: 0x0018FAB0 File Offset: 0x0018DCB0
			// (set) Token: 0x060048C4 RID: 18628 RVA: 0x00018AA1 File Offset: 0x00016CA1
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700119E RID: 4510
			// (get) Token: 0x060048C5 RID: 18629 RVA: 0x0018FAE0 File Offset: 0x0018DCE0
			// (set) Token: 0x060048C6 RID: 18630 RVA: 0x00018AC0 File Offset: 0x00016CC0
			public unsafe int _amount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__amount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__amount_5__2)) = value;
				}
			}

			// Token: 0x1700119F RID: 4511
			// (get) Token: 0x060048C7 RID: 18631 RVA: 0x0018FB08 File Offset: 0x0018DD08
			// (set) Token: 0x060048C8 RID: 18632 RVA: 0x00018ADB File Offset: 0x00016CDB
			public unsafe ActionLogModes _logMode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__logMode_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__logMode_5__3)) = value;
				}
			}

			// Token: 0x170011A0 RID: 4512
			// (get) Token: 0x060048C9 RID: 18633 RVA: 0x0018FB30 File Offset: 0x0018DD30
			// (set) Token: 0x060048CA RID: 18634 RVA: 0x00018AF6 File Offset: 0x00016CF6
			public unsafe Entity _marker_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__marker_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__marker_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A1 RID: 4513
			// (get) Token: 0x060048CB RID: 18635 RVA: 0x0018FB60 File Offset: 0x0018DD60
			// (set) Token: 0x060048CC RID: 18636 RVA: 0x00018B15 File Offset: 0x00016D15
			public unsafe int _currentRank_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__currentRank_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__currentRank_5__5)) = value;
				}
			}

			// Token: 0x170011A2 RID: 4514
			// (get) Token: 0x060048CD RID: 18637 RVA: 0x0018FB88 File Offset: 0x0018DD88
			// (set) Token: 0x060048CE RID: 18638 RVA: 0x00018B30 File Offset: 0x00016D30
			public unsafe int _newRank_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__newRank_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__newRank_5__6)) = value;
				}
			}

			// Token: 0x170011A3 RID: 4515
			// (get) Token: 0x060048CF RID: 18639 RVA: 0x0018FBB0 File Offset: 0x0018DDB0
			// (set) Token: 0x060048D0 RID: 18640 RVA: 0x00018B4B File Offset: 0x00016D4B
			public unsafe UndoNode _childUndo_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__childUndo_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__childUndo_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A4 RID: 4516
			// (get) Token: 0x060048D1 RID: 18641 RVA: 0x0018FBE0 File Offset: 0x0018DDE0
			// (set) Token: 0x060048D2 RID: 18642 RVA: 0x00018B6A File Offset: 0x00016D6A
			public unsafe WormSpace _newRankSpace_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__newRankSpace_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__newRankSpace_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A5 RID: 4517
			// (get) Token: 0x060048D3 RID: 18643 RVA: 0x0018FC10 File Offset: 0x0018DE10
			// (set) Token: 0x060048D4 RID: 18644 RVA: 0x00018B89 File Offset: 0x00016D89
			public unsafe int _i_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__i_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__i_5__9)) = value;
				}
			}

			// Token: 0x170011A6 RID: 4518
			// (get) Token: 0x060048D5 RID: 18645 RVA: 0x0018FC38 File Offset: 0x0018DE38
			// (set) Token: 0x060048D6 RID: 18646 RVA: 0x00018BA4 File Offset: 0x00016DA4
			public unsafe List<ValueTuple<AttributeDefinition<Nullable<int>>, int>> _bonusResources_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__bonusResources_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__bonusResources_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A7 RID: 4519
			// (get) Token: 0x060048D7 RID: 18647 RVA: 0x0018FC68 File Offset: 0x0018DE68
			// (set) Token: 0x060048D8 RID: 18648 RVA: 0x00018BC3 File Offset: 0x00016DC3
			public unsafe SequenceHelper _sequenceHelper_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__sequenceHelper_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr__sequenceHelper_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011A8 RID: 4520
			// (get) Token: 0x060048D9 RID: 18649 RVA: 0x0018FC98 File Offset: 0x0018DE98
			// (set) Token: 0x060048DA RID: 18650 RVA: 0x00018BE2 File Offset: 0x00016DE2
			public List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap11);
					return new List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011A9 RID: 4521
			// (get) Token: 0x060048DB RID: 18651 RVA: 0x0018FCC8 File Offset: 0x0018DEC8
			// (set) Token: 0x060048DC RID: 18652 RVA: 0x00018C10 File Offset: 0x00016E10
			public unsafe IEnumerator<WormPlayer> __7__wrap12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AA RID: 4522
			// (get) Token: 0x060048DD RID: 18653 RVA: 0x0018FCF8 File Offset: 0x0018DEF8
			// (set) Token: 0x060048DE RID: 18654 RVA: 0x00018C2F File Offset: 0x00016E2F
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRank_d__5.NativeFieldInfoPtr___7__wrap13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FBF RID: 12223
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002FC0 RID: 12224
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002FC1 RID: 12225
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002FC2 RID: 12226
			private static readonly IntPtr NativeFieldInfoPtr_triggeringAction;

			// Token: 0x04002FC3 RID: 12227
			private static readonly IntPtr NativeFieldInfoPtr___3__triggeringAction;

			// Token: 0x04002FC4 RID: 12228
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002FC5 RID: 12229
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002FC6 RID: 12230
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002FC7 RID: 12231
			private static readonly IntPtr NativeFieldInfoPtr__amount_5__2;

			// Token: 0x04002FC8 RID: 12232
			private static readonly IntPtr NativeFieldInfoPtr__logMode_5__3;

			// Token: 0x04002FC9 RID: 12233
			private static readonly IntPtr NativeFieldInfoPtr__marker_5__4;

			// Token: 0x04002FCA RID: 12234
			private static readonly IntPtr NativeFieldInfoPtr__currentRank_5__5;

			// Token: 0x04002FCB RID: 12235
			private static readonly IntPtr NativeFieldInfoPtr__newRank_5__6;

			// Token: 0x04002FCC RID: 12236
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__7;

			// Token: 0x04002FCD RID: 12237
			private static readonly IntPtr NativeFieldInfoPtr__newRankSpace_5__8;

			// Token: 0x04002FCE RID: 12238
			private static readonly IntPtr NativeFieldInfoPtr__i_5__9;

			// Token: 0x04002FCF RID: 12239
			private static readonly IntPtr NativeFieldInfoPtr__bonusResources_5__10;

			// Token: 0x04002FD0 RID: 12240
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__11;

			// Token: 0x04002FD1 RID: 12241
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x04002FD2 RID: 12242
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap12;

			// Token: 0x04002FD3 RID: 12243
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap13;

			// Token: 0x04002FD4 RID: 12244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002FD5 RID: 12245
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FD6 RID: 12246
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FD7 RID: 12247
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002FD8 RID: 12248
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002FD9 RID: 12249
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04002FDA RID: 12250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002FDB RID: 12251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FDC RID: 12252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FDD RID: 12253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002FDE RID: 12254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005D9 RID: 1497
		[ObfuscatedName("worm.canis.entities.WormTleilaxuTrack+<ChangeRankBonuses>d__4")]
		public sealed class _ChangeRankBonuses_d__4 : Object
		{
			// Token: 0x060048DF RID: 18655 RVA: 0x0018FD28 File Offset: 0x0018DF28
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRankBonuses_d__4()
			{
				Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTleilaxuTrack>.NativeClassPtr, "<ChangeRankBonuses>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>1__state");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>2__current");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>l__initialThreadId");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>4__this");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_newRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "newRank");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__newRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>3__newRank");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_currentRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "currentRank");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__currentRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>3__currentRank");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_logMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "logMode");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__logMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>3__logMode");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "player");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>3__player");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__bonusResources_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<bonusResources>5__2");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>7__wrap2");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<>7__wrap3");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__bonus_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<bonus>5__5");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__spiceSpace_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, "<spiceSpace>5__6");
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664686);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664687);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664688);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664689);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664690);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664691);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664692);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664693);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664694);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664695);
				WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr, 100664696);
			}

			// Token: 0x060048E0 RID: 18656 RVA: 0x0018FF84 File Offset: 0x0018E184
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRankBonuses_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrack._ChangeRankBonuses_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060048E1 RID: 18657 RVA: 0x0018FFCC File Offset: 0x0018E1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48495, XrefRangeEnd = 48510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048E2 RID: 18658 RVA: 0x00190000 File Offset: 0x0018E200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48510, XrefRangeEnd = 48697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060048E3 RID: 18659 RVA: 0x0019003C File Offset: 0x0018E23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48697, XrefRangeEnd = 48700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048E4 RID: 18660 RVA: 0x00190070 File Offset: 0x0018E270
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48703, RefRangeEnd = 48704, XrefRangeStart = 48700, XrefRangeEnd = 48703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060048E5 RID: 18661 RVA: 0x001900A4 File Offset: 0x0018E2A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48704, XrefRangeEnd = 48707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x060048E6 RID: 18662 RVA: 0x001900D8 File Offset: 0x0018E2D8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060048E7 RID: 18663 RVA: 0x00190118 File Offset: 0x0018E318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48707, XrefRangeEnd = 48712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x060048E8 RID: 18664 RVA: 0x0019014C File Offset: 0x0018E34C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060048E9 RID: 18665 RVA: 0x0019018C File Offset: 0x0018E38C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48712, XrefRangeEnd = 48721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060048EA RID: 18666 RVA: 0x001901CC File Offset: 0x0018E3CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060048EB RID: 18667 RVA: 0x00018C4E File Offset: 0x00016E4E
			public _ChangeRankBonuses_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011AD RID: 4525
			// (get) Token: 0x060048EC RID: 18668 RVA: 0x0019020C File Offset: 0x0018E40C
			// (set) Token: 0x060048ED RID: 18669 RVA: 0x00018C57 File Offset: 0x00016E57
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170011AE RID: 4526
			// (get) Token: 0x060048EE RID: 18670 RVA: 0x00190234 File Offset: 0x0018E434
			// (set) Token: 0x060048EF RID: 18671 RVA: 0x00018C72 File Offset: 0x00016E72
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011AF RID: 4527
			// (get) Token: 0x060048F0 RID: 18672 RVA: 0x00190264 File Offset: 0x0018E464
			// (set) Token: 0x060048F1 RID: 18673 RVA: 0x00018C91 File Offset: 0x00016E91
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170011B0 RID: 4528
			// (get) Token: 0x060048F2 RID: 18674 RVA: 0x0019028C File Offset: 0x0018E48C
			// (set) Token: 0x060048F3 RID: 18675 RVA: 0x00018CAC File Offset: 0x00016EAC
			public unsafe WormTleilaxuTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTleilaxuTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B1 RID: 4529
			// (get) Token: 0x060048F4 RID: 18676 RVA: 0x001902BC File Offset: 0x0018E4BC
			// (set) Token: 0x060048F5 RID: 18677 RVA: 0x00018CCB File Offset: 0x00016ECB
			public unsafe int newRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_newRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_newRank)) = value;
				}
			}

			// Token: 0x170011B2 RID: 4530
			// (get) Token: 0x060048F6 RID: 18678 RVA: 0x001902E4 File Offset: 0x0018E4E4
			// (set) Token: 0x060048F7 RID: 18679 RVA: 0x00018CE6 File Offset: 0x00016EE6
			public unsafe int __3__newRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__newRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__newRank)) = value;
				}
			}

			// Token: 0x170011B3 RID: 4531
			// (get) Token: 0x060048F8 RID: 18680 RVA: 0x0019030C File Offset: 0x0018E50C
			// (set) Token: 0x060048F9 RID: 18681 RVA: 0x00018D01 File Offset: 0x00016F01
			public unsafe int currentRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_currentRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_currentRank)) = value;
				}
			}

			// Token: 0x170011B4 RID: 4532
			// (get) Token: 0x060048FA RID: 18682 RVA: 0x00190334 File Offset: 0x0018E534
			// (set) Token: 0x060048FB RID: 18683 RVA: 0x00018D1C File Offset: 0x00016F1C
			public unsafe int __3__currentRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__currentRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__currentRank)) = value;
				}
			}

			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x060048FC RID: 18684 RVA: 0x0019035C File Offset: 0x0018E55C
			// (set) Token: 0x060048FD RID: 18685 RVA: 0x00018D37 File Offset: 0x00016F37
			public unsafe ActionLogModes logMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_logMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_logMode)) = value;
				}
			}

			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x060048FE RID: 18686 RVA: 0x00190384 File Offset: 0x0018E584
			// (set) Token: 0x060048FF RID: 18687 RVA: 0x00018D52 File Offset: 0x00016F52
			public unsafe ActionLogModes __3__logMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__logMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__logMode)) = value;
				}
			}

			// Token: 0x170011B7 RID: 4535
			// (get) Token: 0x06004900 RID: 18688 RVA: 0x001903AC File Offset: 0x0018E5AC
			// (set) Token: 0x06004901 RID: 18689 RVA: 0x00018D6D File Offset: 0x00016F6D
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B8 RID: 4536
			// (get) Token: 0x06004902 RID: 18690 RVA: 0x001903DC File Offset: 0x0018E5DC
			// (set) Token: 0x06004903 RID: 18691 RVA: 0x00018D8C File Offset: 0x00016F8C
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011B9 RID: 4537
			// (get) Token: 0x06004904 RID: 18692 RVA: 0x0019040C File Offset: 0x0018E60C
			// (set) Token: 0x06004905 RID: 18693 RVA: 0x00018DAB File Offset: 0x00016FAB
			public unsafe List<ValueTuple<AttributeDefinition<Nullable<int>>, int>> _bonusResources_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__bonusResources_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__bonusResources_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011BA RID: 4538
			// (get) Token: 0x06004906 RID: 18694 RVA: 0x0019043C File Offset: 0x0018E63C
			// (set) Token: 0x06004907 RID: 18695 RVA: 0x00018DCA File Offset: 0x00016FCA
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011BB RID: 4539
			// (get) Token: 0x06004908 RID: 18696 RVA: 0x0019046C File Offset: 0x0018E66C
			// (set) Token: 0x06004909 RID: 18697 RVA: 0x00018DE9 File Offset: 0x00016FE9
			public List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___7__wrap3);
					return new List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011BC RID: 4540
			// (get) Token: 0x0600490A RID: 18698 RVA: 0x0019049C File Offset: 0x0018E69C
			// (set) Token: 0x0600490B RID: 18699 RVA: 0x00018E17 File Offset: 0x00017017
			public ValueTuple<AttributeDefinition<Nullable<int>>, int> _bonus_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__bonus_5__5);
					return new ValueTuple<AttributeDefinition<Nullable<int>>, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__bonus_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<AttributeDefinition<Nullable<int>>, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x0600490C RID: 18700 RVA: 0x001904CC File Offset: 0x0018E6CC
			// (set) Token: 0x0600490D RID: 18701 RVA: 0x00018E45 File Offset: 0x00017045
			public unsafe WormSpace _spiceSpace_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__spiceSpace_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxuTrack._ChangeRankBonuses_d__4.NativeFieldInfoPtr__spiceSpace_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FDF RID: 12255
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002FE0 RID: 12256
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002FE1 RID: 12257
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002FE2 RID: 12258
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002FE3 RID: 12259
			private static readonly IntPtr NativeFieldInfoPtr_newRank;

			// Token: 0x04002FE4 RID: 12260
			private static readonly IntPtr NativeFieldInfoPtr___3__newRank;

			// Token: 0x04002FE5 RID: 12261
			private static readonly IntPtr NativeFieldInfoPtr_currentRank;

			// Token: 0x04002FE6 RID: 12262
			private static readonly IntPtr NativeFieldInfoPtr___3__currentRank;

			// Token: 0x04002FE7 RID: 12263
			private static readonly IntPtr NativeFieldInfoPtr_logMode;

			// Token: 0x04002FE8 RID: 12264
			private static readonly IntPtr NativeFieldInfoPtr___3__logMode;

			// Token: 0x04002FE9 RID: 12265
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002FEA RID: 12266
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002FEB RID: 12267
			private static readonly IntPtr NativeFieldInfoPtr__bonusResources_5__2;

			// Token: 0x04002FEC RID: 12268
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002FED RID: 12269
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04002FEE RID: 12270
			private static readonly IntPtr NativeFieldInfoPtr__bonus_5__5;

			// Token: 0x04002FEF RID: 12271
			private static readonly IntPtr NativeFieldInfoPtr__spiceSpace_5__6;

			// Token: 0x04002FF0 RID: 12272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002FF1 RID: 12273
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FF2 RID: 12274
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002FF3 RID: 12275
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002FF4 RID: 12276
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002FF5 RID: 12277
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04002FF6 RID: 12278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002FF7 RID: 12279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002FF8 RID: 12280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002FF9 RID: 12281
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002FFA RID: 12282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
