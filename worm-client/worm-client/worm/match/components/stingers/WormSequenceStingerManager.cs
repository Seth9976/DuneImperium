using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x02000227 RID: 551
	public class WormSequenceStingerManager : MonoBehaviour
	{
		// Token: 0x0600181B RID: 6171 RVA: 0x0006148C File Offset: 0x0005F68C
		// Note: this type is marked as 'beforefieldinit'.
		static WormSequenceStingerManager()
		{
			Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormSequenceStingerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr);
			WormSequenceStingerManager.NativeFieldInfoPtr_stingerTypePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr, "stingerTypePairs");
			WormSequenceStingerManager.NativeFieldInfoPtr_isTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr, "isTutorial");
			WormSequenceStingerManager.NativeMethodInfoPtr_ShowStinger_Public_IEnumerator_StingerType_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr, 100666638);
			WormSequenceStingerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr, 100666639);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0006150C File Offset: 0x0005F70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 718058, RefRangeEnd = 718059, XrefRangeStart = 718052, XrefRangeEnd = 718058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowStinger(WormSequenceStingerManager.StingerType type, IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager.NativeMethodInfoPtr_ShowStinger_Public_IEnumerator_StingerType_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0006156C File Offset: 0x0005F76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718059, XrefRangeEnd = 718067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSequenceStingerManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0000E510 File Offset: 0x0000C710
		public WormSequenceStingerManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000615A8 File Offset: 0x0005F7A8
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000E519 File Offset: 0x0000C719
		public unsafe List<WormSequenceStingerManager.StingerTypePair> stingerTypePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.NativeFieldInfoPtr_stingerTypePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormSequenceStingerManager.StingerTypePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.NativeFieldInfoPtr_stingerTypePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000615D8 File Offset: 0x0005F7D8
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000E538 File Offset: 0x0000C738
		public Nullable<bool> isTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.NativeFieldInfoPtr_isTutorial);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.NativeFieldInfoPtr_isTutorial), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeFieldInfoPtr_stingerTypePairs;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeFieldInfoPtr_isTutorial;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_ShowStinger_Public_IEnumerator_StingerType_IHasAttributes_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000400 RID: 1024
		public enum StingerType
		{
			// Token: 0x04001835 RID: 6197
			RevealCards,
			// Token: 0x04001836 RID: 6198
			LeaderAbility,
			// Token: 0x04001837 RID: 6199
			AgentAbility,
			// Token: 0x04001838 RID: 6200
			RevealAbility,
			// Token: 0x04001839 RID: 6201
			SignetAbility,
			// Token: 0x0400183A RID: 6202
			AcquireCard,
			// Token: 0x0400183B RID: 6203
			HagalConvertResources,
			// Token: 0x0400183C RID: 6204
			HagalRefillDeckFromDiscard,
			// Token: 0x0400183D RID: 6205
			IntrigueRefillDeckFromDiscard,
			// Token: 0x0400183E RID: 6206
			HagalTurn,
			// Token: 0x0400183F RID: 6207
			ControlledSpaceTroop,
			// Token: 0x04001840 RID: 6208
			DiscardedCards,
			// Token: 0x04001841 RID: 6209
			CombatPass,
			// Token: 0x04001842 RID: 6210
			PlayerTurn,
			// Token: 0x04001843 RID: 6211
			LastRound,
			// Token: 0x04001844 RID: 6212
			AcquireTechTile,
			// Token: 0x04001845 RID: 6213
			EndGameTechTileVP,
			// Token: 0x04001846 RID: 6214
			TechTileAbility,
			// Token: 0x04001847 RID: 6215
			FreighterRecalled,
			// Token: 0x04001848 RID: 6216
			PlayGraftedCards,
			// Token: 0x04001849 RID: 6217
			PlayCardNoGraft,
			// Token: 0x0400184A RID: 6218
			TleilaxuTrack,
			// Token: 0x0400184B RID: 6219
			ResearchTrack,
			// Token: 0x0400184C RID: 6220
			TleilaxuTrackNoRewards,
			// Token: 0x0400184D RID: 6221
			PlayCard,
			// Token: 0x0400184E RID: 6222
			PlayCardTrashSelf,
			// Token: 0x0400184F RID: 6223
			UndoPlayCard,
			// Token: 0x04001850 RID: 6224
			PlayIntrigue,
			// Token: 0x04001851 RID: 6225
			AcquireCardReclaimedForces,
			// Token: 0x04001852 RID: 6226
			ResearchTrackNoRewards,
			// Token: 0x04001853 RID: 6227
			AddImperiumToBottom
		}

		// Token: 0x02000401 RID: 1025
		[Serializable]
		public sealed class StingerTypePair : ValueType
		{
			// Token: 0x060029F0 RID: 10736 RVA: 0x0009726C File Offset: 0x0009546C
			// Note: this type is marked as 'beforefieldinit'.
			static StingerTypePair()
			{
				Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr, "StingerTypePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr);
				WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr, "type");
				WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_stinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr, "stinger");
				WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_showWithAnimationsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr, "showWithAnimationsDisabled");
			}

			// Token: 0x060029F1 RID: 10737 RVA: 0x00016F00 File Offset: 0x00015100
			public StingerTypePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060029F2 RID: 10738 RVA: 0x00016F09 File Offset: 0x00015109
			public StingerTypePair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr))
			{
			}

			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000972D4 File Offset: 0x000954D4
			// (set) Token: 0x060029F4 RID: 10740 RVA: 0x00016F1B File Offset: 0x0001511B
			public unsafe WormSequenceStingerManager.StingerType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17000BDE RID: 3038
			// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000972FC File Offset: 0x000954FC
			// (set) Token: 0x060029F6 RID: 10742 RVA: 0x00016F36 File Offset: 0x00015136
			public unsafe WormSequenceStinger stinger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_stinger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSequenceStinger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_stinger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0009732C File Offset: 0x0009552C
			// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00016F55 File Offset: 0x00015155
			public unsafe bool showWithAnimationsDisabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_showWithAnimationsDisabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager.StingerTypePair.NativeFieldInfoPtr_showWithAnimationsDisabled)) = value;
				}
			}

			// Token: 0x04001854 RID: 6228
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001855 RID: 6229
			private static readonly IntPtr NativeFieldInfoPtr_stinger;

			// Token: 0x04001856 RID: 6230
			private static readonly IntPtr NativeFieldInfoPtr_showWithAnimationsDisabled;
		}

		// Token: 0x02000402 RID: 1026
		[ObfuscatedName("worm.match.components.stingers.WormSequenceStingerManager+<ShowStinger>d__4")]
		public sealed class _ShowStinger_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x060029F9 RID: 10745 RVA: 0x00097354 File Offset: 0x00095554
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowStinger_d__4()
			{
				Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSequenceStingerManager>.NativeClassPtr, "<ShowStinger>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr);
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "<>1__state");
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "<>2__current");
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "<>4__this");
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "type");
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "attributes");
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "<>7__wrap1");
				WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr__stingerTypePair_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, "<stingerTypePair>5__3");
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666640);
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666641);
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666642);
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666643);
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666644);
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666645);
				WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr, 100666646);
			}

			// Token: 0x060029FA RID: 10746 RVA: 0x00097498 File Offset: 0x00095698
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowStinger_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSequenceStingerManager._ShowStinger_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029FB RID: 10747 RVA: 0x000974E0 File Offset: 0x000956E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717963, XrefRangeEnd = 717968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029FC RID: 10748 RVA: 0x00097514 File Offset: 0x00095714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717968, XrefRangeEnd = 718044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060029FD RID: 10749 RVA: 0x00097550 File Offset: 0x00095750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718044, XrefRangeEnd = 718047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x060029FE RID: 10750 RVA: 0x00097584 File Offset: 0x00095784
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029FF RID: 10751 RVA: 0x000975C4 File Offset: 0x000957C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718047, XrefRangeEnd = 718052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000975F8 File Offset: 0x000957F8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStingerManager._ShowStinger_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A01 RID: 10753 RVA: 0x00016F70 File Offset: 0x00015170
			public _ShowStinger_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x06002A02 RID: 10754 RVA: 0x00097638 File Offset: 0x00095838
			// (set) Token: 0x06002A03 RID: 10755 RVA: 0x00016F79 File Offset: 0x00015179
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x06002A04 RID: 10756 RVA: 0x00097660 File Offset: 0x00095860
			// (set) Token: 0x06002A05 RID: 10757 RVA: 0x00016F94 File Offset: 0x00015194
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x06002A06 RID: 10758 RVA: 0x00097690 File Offset: 0x00095890
			// (set) Token: 0x06002A07 RID: 10759 RVA: 0x00016FB3 File Offset: 0x000151B3
			public unsafe WormSequenceStingerManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSequenceStingerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000976C0 File Offset: 0x000958C0
			// (set) Token: 0x06002A09 RID: 10761 RVA: 0x00016FD2 File Offset: 0x000151D2
			public unsafe WormSequenceStingerManager.StingerType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000976E8 File Offset: 0x000958E8
			// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00016FED File Offset: 0x000151ED
			public unsafe IHasAttributes attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr_attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x06002A0C RID: 10764 RVA: 0x00097718 File Offset: 0x00095918
			// (set) Token: 0x06002A0D RID: 10765 RVA: 0x0001700C File Offset: 0x0001520C
			public List<WormSequenceStingerManager.StingerTypePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___7__wrap1);
					return new List<WormSequenceStingerManager.StingerTypePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormSequenceStingerManager.StingerTypePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormSequenceStingerManager.StingerTypePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x06002A0E RID: 10766 RVA: 0x00097748 File Offset: 0x00095948
			// (set) Token: 0x06002A0F RID: 10767 RVA: 0x0001703A File Offset: 0x0001523A
			public WormSequenceStingerManager.StingerTypePair _stingerTypePair_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr__stingerTypePair_5__3);
					return new WormSequenceStingerManager.StingerTypePair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStingerManager._ShowStinger_d__4.NativeFieldInfoPtr__stingerTypePair_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormSequenceStingerManager.StingerTypePair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001857 RID: 6231
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001858 RID: 6232
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001859 RID: 6233
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400185A RID: 6234
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400185B RID: 6235
			private static readonly IntPtr NativeFieldInfoPtr_attributes;

			// Token: 0x0400185C RID: 6236
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400185D RID: 6237
			private static readonly IntPtr NativeFieldInfoPtr__stingerTypePair_5__3;

			// Token: 0x0400185E RID: 6238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400185F RID: 6239
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001860 RID: 6240
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001861 RID: 6241
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001862 RID: 6242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001863 RID: 6243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001864 RID: 6244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
