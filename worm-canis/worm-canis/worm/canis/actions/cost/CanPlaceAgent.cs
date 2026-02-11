using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions.cost
{
	// Token: 0x020002ED RID: 749
	public class CanPlaceAgent : CostAction
	{
		// Token: 0x06001ED4 RID: 7892 RVA: 0x000D11C8 File Offset: 0x000CF3C8
		// Note: this type is marked as 'beforefieldinit'.
		static CanPlaceAgent()
		{
			Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost", "CanPlaceAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr);
			CanPlaceAgent.NativeFieldInfoPtr_cardToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "cardToCheck");
			CanPlaceAgent.NativeFieldInfoPtr_graftedCardToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "graftedCardToCheck");
			CanPlaceAgent.NativeFieldInfoPtr_skipActivePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "skipActivePlayer");
			CanPlaceAgent.NativeFieldInfoPtr_checkAllCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "checkAllCards");
			CanPlaceAgent.NativeMethodInfoPtr__ctor_Public_Void_Match_WormImperiumPlayable_WormImperiumPlayable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, 100670560);
			CanPlaceAgent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, 100670561);
			CanPlaceAgent.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, 100670562);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000D1284 File Offset: 0x000CF484
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 172151, RefRangeEnd = 172156, XrefRangeStart = 172148, XrefRangeEnd = 172151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanPlaceAgent(Match m, WormImperiumPlayable cardToCheck = null, WormImperiumPlayable graftedCardToCheck = null, bool skipActivePlayer = false, bool checkAllCards = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardToCheck);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftedCardToCheck);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipActivePlayer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAllCards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.NativeMethodInfoPtr__ctor_Public_Void_Match_WormImperiumPlayable_WormImperiumPlayable_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000D1310 File Offset: 0x000CF510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172156, XrefRangeEnd = 172161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanPlaceAgent.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000D135C File Offset: 0x000CF55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172161, XrefRangeEnd = 172231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanPlaceAgent.NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		public CanPlaceAgent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000D13B4 File Offset: 0x000CF5B4
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x0000CED1 File Offset: 0x0000B0D1
		public unsafe WormImperiumPlayable cardToCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_cardToCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_cardToCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x000D13E4 File Offset: 0x000CF5E4
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
		public unsafe WormImperiumPlayable graftedCardToCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_graftedCardToCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_graftedCardToCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x000D1414 File Offset: 0x000CF614
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x0000CF0F File Offset: 0x0000B10F
		public unsafe bool skipActivePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_skipActivePlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_skipActivePlayer)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x000D143C File Offset: 0x000CF63C
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0000CF2A File Offset: 0x0000B12A
		public unsafe bool checkAllCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_checkAllCards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.NativeFieldInfoPtr_checkAllCards)) = value;
			}
		}

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_cardToCheck;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_graftedCardToCheck;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeFieldInfoPtr_skipActivePlayer;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeFieldInfoPtr_checkAllCards;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_WormImperiumPlayable_WormImperiumPlayable_Boolean_Boolean_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Virtual_Boolean_Context_0;

		// Token: 0x02000794 RID: 1940
		[ObfuscatedName("worm.canis.actions.cost.CanPlaceAgent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006DA3 RID: 28067 RVA: 0x00202638 File Offset: 0x00200838
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr);
				CanPlaceAgent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr, "<>9");
				CanPlaceAgent.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr, "<>9__6_0");
				CanPlaceAgent.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr, "<>9__6_2");
				CanPlaceAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr, 100670564);
				CanPlaceAgent.__c.NativeMethodInfoPtr__CanBePaid_b__6_0_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr, 100670565);
				CanPlaceAgent.__c.NativeMethodInfoPtr__CanBePaid_b__6_2_Internal_IEnumerable_1_AgentIcons_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr, 100670566);
			}

			// Token: 0x06006DA4 RID: 28068 RVA: 0x002026DC File Offset: 0x002008DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanPlaceAgent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006DA5 RID: 28069 RVA: 0x00202718 File Offset: 0x00200918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172120, XrefRangeEnd = 172127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanBePaid_b__6_0(WormAgent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.__c.NativeMethodInfoPtr__CanBePaid_b__6_0_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006DA6 RID: 28070 RVA: 0x00202768 File Offset: 0x00200968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172127, XrefRangeEnd = 172141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AgentIcons> _CanBePaid_b__6_2(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.__c.NativeMethodInfoPtr__CanBePaid_b__6_2_Internal_IEnumerable_1_AgentIcons_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AgentIcons>>(intPtr3) : null;
				}
			}

			// Token: 0x06006DA7 RID: 28071 RVA: 0x0002B9EB File Offset: 0x00029BEB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E08 RID: 7688
			// (get) Token: 0x06006DA8 RID: 28072 RVA: 0x002027B8 File Offset: 0x002009B8
			// (set) Token: 0x06006DA9 RID: 28073 RVA: 0x0002B9F4 File Offset: 0x00029BF4
			public unsafe static CanPlaceAgent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanPlaceAgent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanPlaceAgent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanPlaceAgent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E09 RID: 7689
			// (get) Token: 0x06006DAA RID: 28074 RVA: 0x002027E0 File Offset: 0x002009E0
			// (set) Token: 0x06006DAB RID: 28075 RVA: 0x0002BA06 File Offset: 0x00029C06
			public unsafe static Func<WormAgent, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanPlaceAgent.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAgent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanPlaceAgent.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E0A RID: 7690
			// (get) Token: 0x06006DAC RID: 28076 RVA: 0x00202808 File Offset: 0x00200A08
			// (set) Token: 0x06006DAD RID: 28077 RVA: 0x0002BA18 File Offset: 0x00029C18
			public unsafe static Func<Entity, IEnumerable<AgentIcons>> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanPlaceAgent.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, IEnumerable<AgentIcons>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanPlaceAgent.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040046D2 RID: 18130
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040046D3 RID: 18131
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040046D4 RID: 18132
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x040046D5 RID: 18133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040046D6 RID: 18134
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__6_0_Internal_Boolean_WormAgent_0;

			// Token: 0x040046D7 RID: 18135
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__6_2_Internal_IEnumerable_1_AgentIcons_Entity_0;
		}

		// Token: 0x02000795 RID: 1941
		[ObfuscatedName("worm.canis.actions.cost.CanPlaceAgent+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06006DAE RID: 28078 RVA: 0x00202830 File Offset: 0x00200A30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr);
				CanPlaceAgent.__c__DisplayClass6_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr, "player");
				CanPlaceAgent.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr, 100670567);
				CanPlaceAgent.__c__DisplayClass6_0.NativeMethodInfoPtr__CanBePaid_b__1_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr, 100670568);
				CanPlaceAgent.__c__DisplayClass6_0.NativeMethodInfoPtr__CanBePaid_b__3_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr, 100670569);
			}

			// Token: 0x06006DAF RID: 28079 RVA: 0x002028AC File Offset: 0x00200AAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanPlaceAgent.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006DB0 RID: 28080 RVA: 0x002028E8 File Offset: 0x00200AE8
			[CallerCount(0)]
			public unsafe bool _CanBePaid_b__1(WormAgent a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.__c__DisplayClass6_0.NativeMethodInfoPtr__CanBePaid_b__1_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006DB1 RID: 28081 RVA: 0x00202938 File Offset: 0x00200B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanBePaid_b__3(WormAgent agent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent.__c__DisplayClass6_0.NativeMethodInfoPtr__CanBePaid_b__3_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006DB2 RID: 28082 RVA: 0x0002BA2A File Offset: 0x00029C2A
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E0B RID: 7691
			// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x00202988 File Offset: 0x00200B88
			// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x0002BA33 File Offset: 0x00029C33
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.__c__DisplayClass6_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent.__c__DisplayClass6_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040046D8 RID: 18136
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040046D9 RID: 18137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040046DA RID: 18138
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__1_Internal_Boolean_WormAgent_0;

			// Token: 0x040046DB RID: 18139
			private static readonly IntPtr NativeMethodInfoPtr__CanBePaid_b__3_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000796 RID: 1942
		[ObfuscatedName("worm.canis.actions.cost.CanPlaceAgent+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06006DB5 RID: 28085 RVA: 0x002029B8 File Offset: 0x00200BB8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanPlaceAgent>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr);
				CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, "<>1__state");
				CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, "<>2__current");
				CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670570);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670571);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670572);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670573);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670574);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670575);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670576);
				CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr, 100670577);
			}

			// Token: 0x06006DB6 RID: 28086 RVA: 0x00202AC0 File Offset: 0x00200CC0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanPlaceAgent._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006DB7 RID: 28087 RVA: 0x00202B08 File Offset: 0x00200D08
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006DB8 RID: 28088 RVA: 0x00202B3C File Offset: 0x00200D3C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E0F RID: 7695
			// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x00202B78 File Offset: 0x00200D78
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006DBA RID: 28090 RVA: 0x00202BB8 File Offset: 0x00200DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172141, XrefRangeEnd = 172146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E10 RID: 7696
			// (get) Token: 0x06006DBB RID: 28091 RVA: 0x00202BEC File Offset: 0x00200DEC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006DBC RID: 28092 RVA: 0x00202C2C File Offset: 0x00200E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172146, XrefRangeEnd = 172148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006DBD RID: 28093 RVA: 0x00202C6C File Offset: 0x00200E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanPlaceAgent._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006DBE RID: 28094 RVA: 0x0002BA52 File Offset: 0x00029C52
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E0C RID: 7692
			// (get) Token: 0x06006DBF RID: 28095 RVA: 0x00202CAC File Offset: 0x00200EAC
			// (set) Token: 0x06006DC0 RID: 28096 RVA: 0x0002BA5B File Offset: 0x00029C5B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E0D RID: 7693
			// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x00202CD4 File Offset: 0x00200ED4
			// (set) Token: 0x06006DC2 RID: 28098 RVA: 0x0002BA76 File Offset: 0x00029C76
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E0E RID: 7694
			// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x00202D04 File Offset: 0x00200F04
			// (set) Token: 0x06006DC4 RID: 28100 RVA: 0x0002BA95 File Offset: 0x00029C95
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanPlaceAgent._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040046DC RID: 18140
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040046DD RID: 18141
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040046DE RID: 18142
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040046DF RID: 18143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040046E0 RID: 18144
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040046E1 RID: 18145
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040046E2 RID: 18146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040046E3 RID: 18147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040046E4 RID: 18148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040046E5 RID: 18149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040046E6 RID: 18150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
