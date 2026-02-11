using System;
using Canis;
using Canis.actions;
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
	// Token: 0x02000035 RID: 53
	public class WormShippingTrack : WormTrack
	{
		// Token: 0x060004C5 RID: 1221 RVA: 0x0007CF6C File Offset: 0x0007B16C
		// Note: this type is marked as 'beforefieldinit'.
		static WormShippingTrack()
		{
			Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormShippingTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr);
			WormShippingTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, 100664573);
			WormShippingTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, 100664574);
			WormShippingTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, 100664575);
			WormShippingTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, 100664576);
			WormShippingTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, 100664577);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0007D000 File Offset: 0x0007B200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47417, RefRangeEnd = 47419, XrefRangeStart = 47410, XrefRangeEnd = 47417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShippingTrack(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0007D04C File Offset: 0x0007B24C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45845, RefRangeEnd = 45848, XrefRangeStart = 45845, XrefRangeEnd = 45848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShippingTrack(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0007D0BC File Offset: 0x0007B2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47419, XrefRangeEnd = 47522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShippingTrack.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0007D0F8 File Offset: 0x0007B2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47522, XrefRangeEnd = 47528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShippingTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0007D180 File Offset: 0x0007B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47528, XrefRangeEnd = 47536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShippingTrack.NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public WormShippingTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRankBonuses_Protected_Virtual_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRank_Public_Virtual_IEnumerable_1_Action_WormPlayer_Action_0;

		// Token: 0x020005CD RID: 1485
		[ObfuscatedName("worm.canis.entities.WormShippingTrack+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004802 RID: 18434 RVA: 0x0018D590 File Offset: 0x0018B790
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr);
				WormShippingTrack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, "<>9");
				WormShippingTrack.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, "<>9__4_0");
				WormShippingTrack.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, "<>9__4_1");
				WormShippingTrack.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, "<>9__4_2");
				WormShippingTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, 100664579);
				WormShippingTrack.__c.NativeMethodInfoPtr__ChangeRank_b__4_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, 100664580);
				WormShippingTrack.__c.NativeMethodInfoPtr__ChangeRank_b__4_1_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, 100664581);
				WormShippingTrack.__c.NativeMethodInfoPtr__ChangeRank_b__4_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr, 100664582);
			}

			// Token: 0x06004803 RID: 18435 RVA: 0x0018D65C File Offset: 0x0018B85C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004804 RID: 18436 RVA: 0x0018D698 File Offset: 0x0018B898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46895, XrefRangeEnd = 46897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _ChangeRank_b__4_0(WormTechTileStack stack)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack.__c.NativeMethodInfoPtr__ChangeRank_b__4_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06004805 RID: 18437 RVA: 0x0018D6E8 File Offset: 0x0018B8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46897, XrefRangeEnd = 46902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeRank_b__4_1(WormTechTilePlayable wtt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wtt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack.__c.NativeMethodInfoPtr__ChangeRank_b__4_1_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004806 RID: 18438 RVA: 0x0018D738 File Offset: 0x0018B938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46902, XrefRangeEnd = 46907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeRank_b__4_2(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack.__c.NativeMethodInfoPtr__ChangeRank_b__4_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004807 RID: 18439 RVA: 0x0001849E File Offset: 0x0001669E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001160 RID: 4448
			// (get) Token: 0x06004808 RID: 18440 RVA: 0x0018D788 File Offset: 0x0018B988
			// (set) Token: 0x06004809 RID: 18441 RVA: 0x000184A7 File Offset: 0x000166A7
			public unsafe static WormShippingTrack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShippingTrack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShippingTrack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShippingTrack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001161 RID: 4449
			// (get) Token: 0x0600480A RID: 18442 RVA: 0x0018D7B0 File Offset: 0x0018B9B0
			// (set) Token: 0x0600480B RID: 18443 RVA: 0x000184B9 File Offset: 0x000166B9
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShippingTrack.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShippingTrack.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001162 RID: 4450
			// (get) Token: 0x0600480C RID: 18444 RVA: 0x0018D7D8 File Offset: 0x0018B9D8
			// (set) Token: 0x0600480D RID: 18445 RVA: 0x000184CB File Offset: 0x000166CB
			public unsafe static Func<WormTechTilePlayable, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShippingTrack.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShippingTrack.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001163 RID: 4451
			// (get) Token: 0x0600480E RID: 18446 RVA: 0x0018D800 File Offset: 0x0018BA00
			// (set) Token: 0x0600480F RID: 18447 RVA: 0x000184DD File Offset: 0x000166DD
			public unsafe static Func<Entity, bool> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormShippingTrack.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormShippingTrack.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F5D RID: 12125
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002F5E RID: 12126
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04002F5F RID: 12127
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04002F60 RID: 12128
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04002F61 RID: 12129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F62 RID: 12130
			private static readonly IntPtr NativeMethodInfoPtr__ChangeRank_b__4_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0;

			// Token: 0x04002F63 RID: 12131
			private static readonly IntPtr NativeMethodInfoPtr__ChangeRank_b__4_1_Internal_Boolean_WormTechTilePlayable_0;

			// Token: 0x04002F64 RID: 12132
			private static readonly IntPtr NativeMethodInfoPtr__ChangeRank_b__4_2_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005CE RID: 1486
		[ObfuscatedName("worm.canis.entities.WormShippingTrack+<ChangeRank>d__4")]
		public sealed class _ChangeRank_d__4 : Object
		{
			// Token: 0x06004810 RID: 18448 RVA: 0x0018D828 File Offset: 0x0018BA28
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRank_d__4()
			{
				Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, "<ChangeRank>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr);
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>1__state");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>2__current");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>l__initialThreadId");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr_triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "triggeringAction");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__triggeringAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>3__triggeringAction");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>4__this");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "player");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>3__player");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__amount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<amount>5__2");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__logMode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<logMode>5__3");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__marker_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<marker>5__4");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__currentRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<currentRank>5__5");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<newRank>5__6");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__childUndo_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<childUndo>5__7");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRankSpace_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<newRankSpace>5__8");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__sequenceHelper_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<sequenceHelper>5__9");
				WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, "<>7__wrap9");
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664583);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664584);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664585);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664586);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664587);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664588);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664589);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664590);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664591);
				WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr, 100664592);
			}

			// Token: 0x06004811 RID: 18449 RVA: 0x0018DA70 File Offset: 0x0018BC70
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRank_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrack._ChangeRank_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004812 RID: 18450 RVA: 0x0018DAB8 File Offset: 0x0018BCB8
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004813 RID: 18451 RVA: 0x0018DAEC File Offset: 0x0018BCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46907, XrefRangeEnd = 47377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004814 RID: 18452 RVA: 0x0018DB28 File Offset: 0x0018BD28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47377, XrefRangeEnd = 47380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004815 RID: 18453 RVA: 0x0018DB5C File Offset: 0x0018BD5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47380, XrefRangeEnd = 47383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001175 RID: 4469
			// (get) Token: 0x06004816 RID: 18454 RVA: 0x0018DB90 File Offset: 0x0018BD90
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004817 RID: 18455 RVA: 0x0018DBD0 File Offset: 0x0018BDD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47383, XrefRangeEnd = 47388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001176 RID: 4470
			// (get) Token: 0x06004818 RID: 18456 RVA: 0x0018DC04 File Offset: 0x0018BE04
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004819 RID: 18457 RVA: 0x0018DC44 File Offset: 0x0018BE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47388, XrefRangeEnd = 47398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600481A RID: 18458 RVA: 0x0018DC84 File Offset: 0x0018BE84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRank_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600481B RID: 18459 RVA: 0x000184EF File Offset: 0x000166EF
			public _ChangeRank_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001164 RID: 4452
			// (get) Token: 0x0600481C RID: 18460 RVA: 0x0018DCC4 File Offset: 0x0018BEC4
			// (set) Token: 0x0600481D RID: 18461 RVA: 0x000184F8 File Offset: 0x000166F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001165 RID: 4453
			// (get) Token: 0x0600481E RID: 18462 RVA: 0x0018DCEC File Offset: 0x0018BEEC
			// (set) Token: 0x0600481F RID: 18463 RVA: 0x00018513 File Offset: 0x00016713
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001166 RID: 4454
			// (get) Token: 0x06004820 RID: 18464 RVA: 0x0018DD1C File Offset: 0x0018BF1C
			// (set) Token: 0x06004821 RID: 18465 RVA: 0x00018532 File Offset: 0x00016732
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001167 RID: 4455
			// (get) Token: 0x06004822 RID: 18466 RVA: 0x0018DD44 File Offset: 0x0018BF44
			// (set) Token: 0x06004823 RID: 18467 RVA: 0x0001854D File Offset: 0x0001674D
			public unsafe global::Canis.actions.Action triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr_triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr_triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001168 RID: 4456
			// (get) Token: 0x06004824 RID: 18468 RVA: 0x0018DD74 File Offset: 0x0018BF74
			// (set) Token: 0x06004825 RID: 18469 RVA: 0x0001856C File Offset: 0x0001676C
			public unsafe global::Canis.actions.Action __3__triggeringAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__triggeringAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__triggeringAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001169 RID: 4457
			// (get) Token: 0x06004826 RID: 18470 RVA: 0x0018DDA4 File Offset: 0x0018BFA4
			// (set) Token: 0x06004827 RID: 18471 RVA: 0x0001858B File Offset: 0x0001678B
			public unsafe WormShippingTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShippingTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116A RID: 4458
			// (get) Token: 0x06004828 RID: 18472 RVA: 0x0018DDD4 File Offset: 0x0018BFD4
			// (set) Token: 0x06004829 RID: 18473 RVA: 0x000185AA File Offset: 0x000167AA
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116B RID: 4459
			// (get) Token: 0x0600482A RID: 18474 RVA: 0x0018DE04 File Offset: 0x0018C004
			// (set) Token: 0x0600482B RID: 18475 RVA: 0x000185C9 File Offset: 0x000167C9
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116C RID: 4460
			// (get) Token: 0x0600482C RID: 18476 RVA: 0x0018DE34 File Offset: 0x0018C034
			// (set) Token: 0x0600482D RID: 18477 RVA: 0x000185E8 File Offset: 0x000167E8
			public unsafe int _amount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__amount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__amount_5__2)) = value;
				}
			}

			// Token: 0x1700116D RID: 4461
			// (get) Token: 0x0600482E RID: 18478 RVA: 0x0018DE5C File Offset: 0x0018C05C
			// (set) Token: 0x0600482F RID: 18479 RVA: 0x00018603 File Offset: 0x00016803
			public unsafe ActionLogModes _logMode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__logMode_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__logMode_5__3)) = value;
				}
			}

			// Token: 0x1700116E RID: 4462
			// (get) Token: 0x06004830 RID: 18480 RVA: 0x0018DE84 File Offset: 0x0018C084
			// (set) Token: 0x06004831 RID: 18481 RVA: 0x0001861E File Offset: 0x0001681E
			public unsafe Entity _marker_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__marker_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__marker_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116F RID: 4463
			// (get) Token: 0x06004832 RID: 18482 RVA: 0x0018DEB4 File Offset: 0x0018C0B4
			// (set) Token: 0x06004833 RID: 18483 RVA: 0x0001863D File Offset: 0x0001683D
			public unsafe int _currentRank_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__currentRank_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__currentRank_5__5)) = value;
				}
			}

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x06004834 RID: 18484 RVA: 0x0018DEDC File Offset: 0x0018C0DC
			// (set) Token: 0x06004835 RID: 18485 RVA: 0x00018658 File Offset: 0x00016858
			public unsafe int _newRank_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRank_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRank_5__6)) = value;
				}
			}

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x06004836 RID: 18486 RVA: 0x0018DF04 File Offset: 0x0018C104
			// (set) Token: 0x06004837 RID: 18487 RVA: 0x00018673 File Offset: 0x00016873
			public unsafe UndoNode _childUndo_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__childUndo_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__childUndo_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x06004838 RID: 18488 RVA: 0x0018DF34 File Offset: 0x0018C134
			// (set) Token: 0x06004839 RID: 18489 RVA: 0x00018692 File Offset: 0x00016892
			public unsafe WormSpace _newRankSpace_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRankSpace_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__newRankSpace_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x0600483A RID: 18490 RVA: 0x0018DF64 File Offset: 0x0018C164
			// (set) Token: 0x0600483B RID: 18491 RVA: 0x000186B1 File Offset: 0x000168B1
			public unsafe SequenceHelper _sequenceHelper_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__sequenceHelper_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr__sequenceHelper_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x0600483C RID: 18492 RVA: 0x0018DF94 File Offset: 0x0018C194
			// (set) Token: 0x0600483D RID: 18493 RVA: 0x000186D0 File Offset: 0x000168D0
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRank_d__4.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F65 RID: 12133
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F66 RID: 12134
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F67 RID: 12135
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F68 RID: 12136
			private static readonly IntPtr NativeFieldInfoPtr_triggeringAction;

			// Token: 0x04002F69 RID: 12137
			private static readonly IntPtr NativeFieldInfoPtr___3__triggeringAction;

			// Token: 0x04002F6A RID: 12138
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F6B RID: 12139
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F6C RID: 12140
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002F6D RID: 12141
			private static readonly IntPtr NativeFieldInfoPtr__amount_5__2;

			// Token: 0x04002F6E RID: 12142
			private static readonly IntPtr NativeFieldInfoPtr__logMode_5__3;

			// Token: 0x04002F6F RID: 12143
			private static readonly IntPtr NativeFieldInfoPtr__marker_5__4;

			// Token: 0x04002F70 RID: 12144
			private static readonly IntPtr NativeFieldInfoPtr__currentRank_5__5;

			// Token: 0x04002F71 RID: 12145
			private static readonly IntPtr NativeFieldInfoPtr__newRank_5__6;

			// Token: 0x04002F72 RID: 12146
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__7;

			// Token: 0x04002F73 RID: 12147
			private static readonly IntPtr NativeFieldInfoPtr__newRankSpace_5__8;

			// Token: 0x04002F74 RID: 12148
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__9;

			// Token: 0x04002F75 RID: 12149
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04002F76 RID: 12150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002F77 RID: 12151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F78 RID: 12152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002F79 RID: 12153
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002F7A RID: 12154
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002F7B RID: 12155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002F7C RID: 12156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F7D RID: 12157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002F7E RID: 12158
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002F7F RID: 12159
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005CF RID: 1487
		[ObfuscatedName("worm.canis.entities.WormShippingTrack+<ChangeRankBonuses>d__3")]
		public sealed class _ChangeRankBonuses_d__3 : Object
		{
			// Token: 0x0600483E RID: 18494 RVA: 0x0018DFC4 File Offset: 0x0018C1C4
			// Note: this type is marked as 'beforefieldinit'.
			static _ChangeRankBonuses_d__3()
			{
				Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShippingTrack>.NativeClassPtr, "<ChangeRankBonuses>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>1__state");
				WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>2__current");
				WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>l__initialThreadId");
				WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, "<>4__this");
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664593);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664594);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664595);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664596);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664597);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664598);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664599);
				WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr, 100664600);
			}

			// Token: 0x0600483F RID: 18495 RVA: 0x0018E0E0 File Offset: 0x0018C2E0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChangeRankBonuses_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShippingTrack._ChangeRankBonuses_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004840 RID: 18496 RVA: 0x0018E128 File Offset: 0x0018C328
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004841 RID: 18497 RVA: 0x0018E15C File Offset: 0x0018C35C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47398, XrefRangeEnd = 47403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700117B RID: 4475
			// (get) Token: 0x06004842 RID: 18498 RVA: 0x0018E198 File Offset: 0x0018C398
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004843 RID: 18499 RVA: 0x0018E1D8 File Offset: 0x0018C3D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47403, XrefRangeEnd = 47408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700117C RID: 4476
			// (get) Token: 0x06004844 RID: 18500 RVA: 0x0018E20C File Offset: 0x0018C40C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004845 RID: 18501 RVA: 0x0018E24C File Offset: 0x0018C44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47408, XrefRangeEnd = 47410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004846 RID: 18502 RVA: 0x0018E28C File Offset: 0x0018C48C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShippingTrack._ChangeRankBonuses_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004847 RID: 18503 RVA: 0x000186EF File Offset: 0x000168EF
			public _ChangeRankBonuses_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001177 RID: 4471
			// (get) Token: 0x06004848 RID: 18504 RVA: 0x0018E2CC File Offset: 0x0018C4CC
			// (set) Token: 0x06004849 RID: 18505 RVA: 0x000186F8 File Offset: 0x000168F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001178 RID: 4472
			// (get) Token: 0x0600484A RID: 18506 RVA: 0x0018E2F4 File Offset: 0x0018C4F4
			// (set) Token: 0x0600484B RID: 18507 RVA: 0x00018713 File Offset: 0x00016913
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001179 RID: 4473
			// (get) Token: 0x0600484C RID: 18508 RVA: 0x0018E324 File Offset: 0x0018C524
			// (set) Token: 0x0600484D RID: 18509 RVA: 0x00018732 File Offset: 0x00016932
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700117A RID: 4474
			// (get) Token: 0x0600484E RID: 18510 RVA: 0x0018E34C File Offset: 0x0018C54C
			// (set) Token: 0x0600484F RID: 18511 RVA: 0x0001874D File Offset: 0x0001694D
			public unsafe WormShippingTrack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShippingTrack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShippingTrack._ChangeRankBonuses_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F80 RID: 12160
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F81 RID: 12161
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F82 RID: 12162
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F83 RID: 12163
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F84 RID: 12164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002F85 RID: 12165
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F86 RID: 12166
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002F87 RID: 12167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002F88 RID: 12168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F89 RID: 12169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002F8A RID: 12170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002F8B RID: 12171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
