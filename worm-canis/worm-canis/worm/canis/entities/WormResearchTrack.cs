using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.actions;

namespace worm.canis.entities
{
	// Token: 0x02000034 RID: 52
	public class WormResearchTrack : WormTrack
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x0007CC28 File Offset: 0x0007AE28
		// Note: this type is marked as 'beforefieldinit'.
		static WormResearchTrack()
		{
			Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormResearchTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr);
			WormResearchTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664543);
			WormResearchTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664544);
			WormResearchTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664545);
			WormResearchTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664546);
			WormResearchTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664547);
			WormResearchTrack.NativeMethodInfoPtr_SpaceValue_Public_AIValueSummer_1_Double_WormSpace_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664548);
			WormResearchTrack.NativeMethodInfoPtr_get_SpaceDefs_Private_Static_get_IEnumerable_1_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, 100664549);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45842, RefRangeEnd = 45844, XrefRangeStart = 45835, XrefRangeEnd = 45842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResearchTrack(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0007CD30 File Offset: 0x0007AF30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45845, RefRangeEnd = 45848, XrefRangeStart = 45844, XrefRangeEnd = 45845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResearchTrack(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0007CDA0 File Offset: 0x0007AFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45848, XrefRangeEnd = 45949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResearchTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0007CDDC File Offset: 0x0007AFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45949, XrefRangeEnd = 45956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResearchTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0007CE64 File Offset: 0x0007B064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45956, XrefRangeEnd = 45964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResearchTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0007CED4 File Offset: 0x0007B0D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46033, RefRangeEnd = 46036, XrefRangeStart = 45964, XrefRangeEnd = 46033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> SpaceValue(WormSpace space, WormPlayer forPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.NativeMethodInfoPtr_SpaceValue_Public_AIValueSummer_1_Double_WormSpace_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0007CF38 File Offset: 0x0007B138
		public unsafe static IEnumerable<MutableAttributes> SpaceDefs
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 46894, RefRangeEnd = 46895, XrefRangeStart = 46036, XrefRangeEnd = 46894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.NativeMethodInfoPtr_get_SpaceDefs_Private_Static_get_IEnumerable_1_MutableAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MutableAttributes>>(intPtr3) : null;
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00003C9F File Offset: 0x00001E9F
		public WormResearchTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_SpaceValue_Public_AIValueSummer_1_Double_WormSpace_WormPlayer_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_get_SpaceDefs_Private_Static_get_IEnumerable_1_MutableAttributes_0;

		// Token: 0x020005CA RID: 1482
		[ObfuscatedName("worm.canis.entities.WormResearchTrack+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060047A4 RID: 18340 RVA: 0x0018C5B0 File Offset: 0x0018A7B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr);
				WormResearchTrack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr, "<>9");
				WormResearchTrack.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr, "<>9__2_0");
				WormResearchTrack.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr, "<>9__3_0");
				WormResearchTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr, 100664551);
				WormResearchTrack.__c.NativeMethodInfoPtr__Initialize_b__2_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr, 100664552);
				WormResearchTrack.__c.NativeMethodInfoPtr__ChangeRankBonuses_b__3_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr, 100664553);
			}

			// Token: 0x060047A5 RID: 18341 RVA: 0x0018C654 File Offset: 0x0018A854
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchTrack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047A6 RID: 18342 RVA: 0x0018C690 File Offset: 0x0018A890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45361, XrefRangeEnd = 45362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__2_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.__c.NativeMethodInfoPtr__Initialize_b__2_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047A7 RID: 18343 RVA: 0x0018C6E0 File Offset: 0x0018A8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45362, XrefRangeEnd = 45363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeRankBonuses_b__3_0(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack.__c.NativeMethodInfoPtr__ChangeRankBonuses_b__3_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047A8 RID: 18344 RVA: 0x000180C8 File Offset: 0x000162C8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x060047A9 RID: 18345 RVA: 0x0018C730 File Offset: 0x0018A930
			// (set) Token: 0x060047AA RID: 18346 RVA: 0x000180D1 File Offset: 0x000162D1
			public unsafe static WormResearchTrack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormResearchTrack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResearchTrack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormResearchTrack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x060047AB RID: 18347 RVA: 0x0018C758 File Offset: 0x0018A958
			// (set) Token: 0x060047AC RID: 18348 RVA: 0x000180E3 File Offset: 0x000162E3
			public unsafe static Func<WormPlayer, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormResearchTrack.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormResearchTrack.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x060047AD RID: 18349 RVA: 0x0018C780 File Offset: 0x0018A980
			// (set) Token: 0x060047AE RID: 18350 RVA: 0x000180F5 File Offset: 0x000162F5
			public unsafe static Func<WormAbilityDefinition, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormResearchTrack.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormResearchTrack.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F26 RID: 12070
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002F27 RID: 12071
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04002F28 RID: 12072
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002F29 RID: 12073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F2A RID: 12074
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__2_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002F2B RID: 12075
			private static readonly IntPtr NativeMethodInfoPtr__ChangeRankBonuses_b__3_0_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x020005CB RID: 1483
		[ObfuscatedName("worm.canis.entities.WormResearchTrack+<ChangeRank>d__4")]
		public sealed class _ChangeRank_d__4 : Object
		{
			// Token: 0x060047AF RID: 18351 RVA: 0x0018C7A8 File Offset: 0x0018A9A8
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRank_d__4()
			{
				Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, "<ChangeRank>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr);
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>1__state");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>2__current");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>l__initialThreadId");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr_triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "triggeringAction");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>3__triggeringAction");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>4__this");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "player");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>3__player");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__logMode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<logMode>5__2");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__marker_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<marker>5__3");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__currentRank_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<currentRank>5__4");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<newRank>5__5");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__childUndo_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<childUndo>5__6");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRankSpace_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<newRankSpace>5__7");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__sequenceHelper_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<sequenceHelper>5__8");
				WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, "<>7__wrap8");
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664554);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664555);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664556);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664557);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664558);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664559);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664560);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664561);
				WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr, 100664562);
			}

			// Token: 0x060047B0 RID: 18352 RVA: 0x0018C9C8 File Offset: 0x0018ABC8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRank_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchTrack._ChangeRank_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047B1 RID: 18353 RVA: 0x0018CA10 File Offset: 0x0018AC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45363, XrefRangeEnd = 45366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047B2 RID: 18354 RVA: 0x0018CA44 File Offset: 0x0018AC44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45366, XrefRangeEnd = 45571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060047B3 RID: 18355 RVA: 0x0018CA80 File Offset: 0x0018AC80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45574, RefRangeEnd = 45575, XrefRangeStart = 45571, XrefRangeEnd = 45574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700114E RID: 4430
			// (get) Token: 0x060047B4 RID: 18356 RVA: 0x0018CAB4 File Offset: 0x0018ACB4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060047B5 RID: 18357 RVA: 0x0018CAF4 File Offset: 0x0018ACF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45575, XrefRangeEnd = 45580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700114F RID: 4431
			// (get) Token: 0x060047B6 RID: 18358 RVA: 0x0018CB28 File Offset: 0x0018AD28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060047B7 RID: 18359 RVA: 0x0018CB68 File Offset: 0x0018AD68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45580, XrefRangeEnd = 45590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060047B8 RID: 18360 RVA: 0x0018CBA8 File Offset: 0x0018ADA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060047B9 RID: 18361 RVA: 0x00018107 File Offset: 0x00016307
			public _ChangeRank_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x060047BA RID: 18362 RVA: 0x0018CBE8 File Offset: 0x0018ADE8
			// (set) Token: 0x060047BB RID: 18363 RVA: 0x00018110 File Offset: 0x00016310
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x060047BC RID: 18364 RVA: 0x0018CC10 File Offset: 0x0018AE10
			// (set) Token: 0x060047BD RID: 18365 RVA: 0x0001812B File Offset: 0x0001632B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x060047BE RID: 18366 RVA: 0x0018CC40 File Offset: 0x0018AE40
			// (set) Token: 0x060047BF RID: 18367 RVA: 0x0001814A File Offset: 0x0001634A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x060047C0 RID: 18368 RVA: 0x0018CC68 File Offset: 0x0018AE68
			// (set) Token: 0x060047C1 RID: 18369 RVA: 0x00018165 File Offset: 0x00016365
			public unsafe global::Canis.actions.Action triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr_triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr_triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x060047C2 RID: 18370 RVA: 0x0018CC98 File Offset: 0x0018AE98
			// (set) Token: 0x060047C3 RID: 18371 RVA: 0x00018184 File Offset: 0x00016384
			public unsafe global::Canis.actions.Action __3__triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x060047C4 RID: 18372 RVA: 0x0018CCC8 File Offset: 0x0018AEC8
			// (set) Token: 0x060047C5 RID: 18373 RVA: 0x000181A3 File Offset: 0x000163A3
			public unsafe WormResearchTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResearchTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x060047C6 RID: 18374 RVA: 0x0018CCF8 File Offset: 0x0018AEF8
			// (set) Token: 0x060047C7 RID: 18375 RVA: 0x000181C2 File Offset: 0x000163C2
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001145 RID: 4421
			// (get) Token: 0x060047C8 RID: 18376 RVA: 0x0018CD28 File Offset: 0x0018AF28
			// (set) Token: 0x060047C9 RID: 18377 RVA: 0x000181E1 File Offset: 0x000163E1
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x060047CA RID: 18378 RVA: 0x0018CD58 File Offset: 0x0018AF58
			// (set) Token: 0x060047CB RID: 18379 RVA: 0x00018200 File Offset: 0x00016400
			public unsafe ActionLogModes _logMode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__logMode_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__logMode_5__2)) = value;
				}
			}

			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x060047CC RID: 18380 RVA: 0x0018CD80 File Offset: 0x0018AF80
			// (set) Token: 0x060047CD RID: 18381 RVA: 0x0001821B File Offset: 0x0001641B
			public unsafe Entity _marker_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__marker_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__marker_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x060047CE RID: 18382 RVA: 0x0018CDB0 File Offset: 0x0018AFB0
			// (set) Token: 0x060047CF RID: 18383 RVA: 0x0001823A File Offset: 0x0001643A
			public unsafe int _currentRank_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__currentRank_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__currentRank_5__4)) = value;
				}
			}

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x060047D0 RID: 18384 RVA: 0x0018CDD8 File Offset: 0x0018AFD8
			// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00018255 File Offset: 0x00016455
			public unsafe int _newRank_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRank_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRank_5__5)) = value;
				}
			}

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x060047D2 RID: 18386 RVA: 0x0018CE00 File Offset: 0x0018B000
			// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00018270 File Offset: 0x00016470
			public unsafe UndoNode _childUndo_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__childUndo_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__childUndo_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x060047D4 RID: 18388 RVA: 0x0018CE30 File Offset: 0x0018B030
			// (set) Token: 0x060047D5 RID: 18389 RVA: 0x0001828F File Offset: 0x0001648F
			public unsafe WormSpace _newRankSpace_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRankSpace_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRankSpace_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x060047D6 RID: 18390 RVA: 0x0018CE60 File Offset: 0x0018B060
			// (set) Token: 0x060047D7 RID: 18391 RVA: 0x000182AE File Offset: 0x000164AE
			public unsafe SequenceHelper _sequenceHelper_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__sequenceHelper_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr__sequenceHelper_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x060047D8 RID: 18392 RVA: 0x0018CE90 File Offset: 0x0018B090
			// (set) Token: 0x060047D9 RID: 18393 RVA: 0x000182CD File Offset: 0x000164CD
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___7__wrap8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRank_d__4.NativeFieldInfoPtr___7__wrap8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F2C RID: 12076
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F2D RID: 12077
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F2E RID: 12078
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F2F RID: 12079
			private static readonly IntPtr NativeFieldInfoPtr_triggeringAction;

			// Token: 0x04002F30 RID: 12080
			private static readonly IntPtr NativeFieldInfoPtr___3__triggeringAction;

			// Token: 0x04002F31 RID: 12081
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F32 RID: 12082
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F33 RID: 12083
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002F34 RID: 12084
			private static readonly IntPtr NativeFieldInfoPtr__logMode_5__2;

			// Token: 0x04002F35 RID: 12085
			private static readonly IntPtr NativeFieldInfoPtr__marker_5__3;

			// Token: 0x04002F36 RID: 12086
			private static readonly IntPtr NativeFieldInfoPtr__currentRank_5__4;

			// Token: 0x04002F37 RID: 12087
			private static readonly IntPtr NativeFieldInfoPtr__newRank_5__5;

			// Token: 0x04002F38 RID: 12088
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__6;

			// Token: 0x04002F39 RID: 12089
			private static readonly IntPtr NativeFieldInfoPtr__newRankSpace_5__7;

			// Token: 0x04002F3A RID: 12090
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__8;

			// Token: 0x04002F3B RID: 12091
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04002F3C RID: 12092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002F3D RID: 12093
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F3E RID: 12094
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002F3F RID: 12095
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002F40 RID: 12096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002F41 RID: 12097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F42 RID: 12098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002F43 RID: 12099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002F44 RID: 12100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005CC RID: 1484
		[ObfuscatedName("worm.canis.entities.WormResearchTrack+<ChangeRankBonuses>d__3")]
		public sealed class _ChangeRankBonuses_d__3 : Object
		{
			// Token: 0x060047DA RID: 18394 RVA: 0x0018CEC0 File Offset: 0x0018B0C0
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRankBonuses_d__3()
			{
				Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormResearchTrack>.NativeClassPtr, "<ChangeRankBonuses>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>1__state");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>2__current");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>l__initialThreadId");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>4__this");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_newRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "newRank");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__newRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>3__newRank");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "player");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>3__player");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_logMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "logMode");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__logMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>3__logMode");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr__newSpace_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<newSpace>5__2");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr__logResources_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<logResources>5__3");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>7__wrap3");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>7__wrap4");
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664563);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664564);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664565);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664566);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664567);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664568);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664569);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664570);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664571);
				WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664572);
			}

			// Token: 0x060047DB RID: 18395 RVA: 0x0018D0CC File Offset: 0x0018B2CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRankBonuses_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResearchTrack._ChangeRankBonuses_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047DC RID: 18396 RVA: 0x0018D114 File Offset: 0x0018B314
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047DD RID: 18397 RVA: 0x0018D148 File Offset: 0x0018B348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45590, XrefRangeEnd = 45815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060047DE RID: 18398 RVA: 0x0018D184 File Offset: 0x0018B384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45815, XrefRangeEnd = 45818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047DF RID: 18399 RVA: 0x0018D1B8 File Offset: 0x0018B3B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45818, XrefRangeEnd = 45821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700115E RID: 4446
			// (get) Token: 0x060047E0 RID: 18400 RVA: 0x0018D1EC File Offset: 0x0018B3EC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060047E1 RID: 18401 RVA: 0x0018D22C File Offset: 0x0018B42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45821, XrefRangeEnd = 45826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700115F RID: 4447
			// (get) Token: 0x060047E2 RID: 18402 RVA: 0x0018D260 File Offset: 0x0018B460
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060047E3 RID: 18403 RVA: 0x0018D2A0 File Offset: 0x0018B4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45826, XrefRangeEnd = 45835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060047E4 RID: 18404 RVA: 0x0018D2E0 File Offset: 0x0018B4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResearchTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060047E5 RID: 18405 RVA: 0x000182EC File Offset: 0x000164EC
			public _ChangeRankBonuses_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001150 RID: 4432
			// (get) Token: 0x060047E6 RID: 18406 RVA: 0x0018D320 File Offset: 0x0018B520
			// (set) Token: 0x060047E7 RID: 18407 RVA: 0x000182F5 File Offset: 0x000164F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x060047E8 RID: 18408 RVA: 0x0018D348 File Offset: 0x0018B548
			// (set) Token: 0x060047E9 RID: 18409 RVA: 0x00018310 File Offset: 0x00016510
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x060047EA RID: 18410 RVA: 0x0018D378 File Offset: 0x0018B578
			// (set) Token: 0x060047EB RID: 18411 RVA: 0x0001832F File Offset: 0x0001652F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x060047EC RID: 18412 RVA: 0x0018D3A0 File Offset: 0x0018B5A0
			// (set) Token: 0x060047ED RID: 18413 RVA: 0x0001834A File Offset: 0x0001654A
			public unsafe WormResearchTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormResearchTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001154 RID: 4436
			// (get) Token: 0x060047EE RID: 18414 RVA: 0x0018D3D0 File Offset: 0x0018B5D0
			// (set) Token: 0x060047EF RID: 18415 RVA: 0x00018369 File Offset: 0x00016569
			public unsafe int newRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_newRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_newRank)) = value;
				}
			}

			// Token: 0x17001155 RID: 4437
			// (get) Token: 0x060047F0 RID: 18416 RVA: 0x0018D3F8 File Offset: 0x0018B5F8
			// (set) Token: 0x060047F1 RID: 18417 RVA: 0x00018384 File Offset: 0x00016584
			public unsafe int __3__newRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__newRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__newRank)) = value;
				}
			}

			// Token: 0x17001156 RID: 4438
			// (get) Token: 0x060047F2 RID: 18418 RVA: 0x0018D420 File Offset: 0x0018B620
			// (set) Token: 0x060047F3 RID: 18419 RVA: 0x0001839F File Offset: 0x0001659F
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x060047F4 RID: 18420 RVA: 0x0018D450 File Offset: 0x0018B650
			// (set) Token: 0x060047F5 RID: 18421 RVA: 0x000183BE File Offset: 0x000165BE
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x060047F6 RID: 18422 RVA: 0x0018D480 File Offset: 0x0018B680
			// (set) Token: 0x060047F7 RID: 18423 RVA: 0x000183DD File Offset: 0x000165DD
			public unsafe ActionLogModes logMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_logMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr_logMode)) = value;
				}
			}

			// Token: 0x17001159 RID: 4441
			// (get) Token: 0x060047F8 RID: 18424 RVA: 0x0018D4A8 File Offset: 0x0018B6A8
			// (set) Token: 0x060047F9 RID: 18425 RVA: 0x000183F8 File Offset: 0x000165F8
			public unsafe ActionLogModes __3__logMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__logMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___3__logMode)) = value;
				}
			}

			// Token: 0x1700115A RID: 4442
			// (get) Token: 0x060047FA RID: 18426 RVA: 0x0018D4D0 File Offset: 0x0018B6D0
			// (set) Token: 0x060047FB RID: 18427 RVA: 0x00018413 File Offset: 0x00016613
			public unsafe WormSpace _newSpace_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr__newSpace_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr__newSpace_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700115B RID: 4443
			// (get) Token: 0x060047FC RID: 18428 RVA: 0x0018D500 File Offset: 0x0018B700
			// (set) Token: 0x060047FD RID: 18429 RVA: 0x00018432 File Offset: 0x00016632
			public unsafe List<ValueTuple<AttributeDefinition<Nullable<int>>, int>> _logResources_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr__logResources_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<AttributeDefinition<Nullable<int>>, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr__logResources_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700115C RID: 4444
			// (get) Token: 0x060047FE RID: 18430 RVA: 0x0018D530 File Offset: 0x0018B730
			// (set) Token: 0x060047FF RID: 18431 RVA: 0x00018451 File Offset: 0x00016651
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700115D RID: 4445
			// (get) Token: 0x06004800 RID: 18432 RVA: 0x0018D560 File Offset: 0x0018B760
			// (set) Token: 0x06004801 RID: 18433 RVA: 0x00018470 File Offset: 0x00016670
			public List<AbilityID>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___7__wrap4);
					return new List<AbilityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResearchTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AbilityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002F45 RID: 12101
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F46 RID: 12102
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F47 RID: 12103
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F48 RID: 12104
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F49 RID: 12105
			private static readonly IntPtr NativeFieldInfoPtr_newRank;

			// Token: 0x04002F4A RID: 12106
			private static readonly IntPtr NativeFieldInfoPtr___3__newRank;

			// Token: 0x04002F4B RID: 12107
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F4C RID: 12108
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002F4D RID: 12109
			private static readonly IntPtr NativeFieldInfoPtr_logMode;

			// Token: 0x04002F4E RID: 12110
			private static readonly IntPtr NativeFieldInfoPtr___3__logMode;

			// Token: 0x04002F4F RID: 12111
			private static readonly IntPtr NativeFieldInfoPtr__newSpace_5__2;

			// Token: 0x04002F50 RID: 12112
			private static readonly IntPtr NativeFieldInfoPtr__logResources_5__3;

			// Token: 0x04002F51 RID: 12113
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04002F52 RID: 12114
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04002F53 RID: 12115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002F54 RID: 12116
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F55 RID: 12117
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002F56 RID: 12118
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002F57 RID: 12119
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002F58 RID: 12120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002F59 RID: 12121
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F5A RID: 12122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002F5B RID: 12123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002F5C RID: 12124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
