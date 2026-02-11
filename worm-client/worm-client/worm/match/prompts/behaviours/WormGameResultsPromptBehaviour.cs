using System;
using boardgames.match;
using boardgames.menus.prompts.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using worm.match.data;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D7 RID: 215
	public class WormGameResultsPromptBehaviour : GameResultsPromptBehaviour
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x00033DAC File Offset: 0x00031FAC
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsPromptBehaviour()
		{
			Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormGameResultsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr);
			WormGameResultsPromptBehaviour.NativeFieldInfoPtr_wonPlayerSubscriptionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "wonPlayerSubscriptionProvider");
			WormGameResultsPromptBehaviour.NativeFieldInfoPtr_placeSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "placeSlots");
			WormGameResultsPromptBehaviour.NativeFieldInfoPtr_onLocalPlayerWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "onLocalPlayerWon");
			WormGameResultsPromptBehaviour.NativeFieldInfoPtr_onLocalPlayerLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "onLocalPlayerLost");
			WormGameResultsPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "entities");
			WormGameResultsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, 100664529);
			WormGameResultsPromptBehaviour.NativeMethodInfoPtr_configurePlayerEntries_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, 100664530);
			WormGameResultsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, 100664531);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00033E7C File Offset: 0x0003207C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699339, XrefRangeEnd = 699414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00033EB8 File Offset: 0x000320B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699414, XrefRangeEnd = 699519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void configurePlayerEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsPromptBehaviour.NativeMethodInfoPtr_configurePlayerEntries_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00033EF4 File Offset: 0x000320F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699519, XrefRangeEnd = 699533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000069FC File Offset: 0x00004BFC
		public WormGameResultsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00033F30 File Offset: 0x00032130
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00006A05 File Offset: 0x00004C05
		public unsafe SubscriptionProvider wonPlayerSubscriptionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_wonPlayerSubscriptionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_wonPlayerSubscriptionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00033F60 File Offset: 0x00032160
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00006A24 File Offset: 0x00004C24
		public unsafe Il2CppReferenceArray<Transform> placeSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_placeSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_placeSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00033F90 File Offset: 0x00032190
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00006A43 File Offset: 0x00004C43
		public unsafe UnityEvent onLocalPlayerWon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_onLocalPlayerWon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_onLocalPlayerWon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00033FC0 File Offset: 0x000321C0
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00006A62 File Offset: 0x00004C62
		public unsafe UnityEvent onLocalPlayerLost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_onLocalPlayerLost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_onLocalPlayerLost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00033FF0 File Offset: 0x000321F0
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00006A81 File Offset: 0x00004C81
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_wonPlayerSubscriptionProvider;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_placeSlots;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerWon;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerLost;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_configurePlayerEntries_Protected_Virtual_Void_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000333 RID: 819
		[ObfuscatedName("worm.match.prompts.behaviours.WormGameResultsPromptBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600211C RID: 8476 RVA: 0x0007CECC File Offset: 0x0007B0CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr);
				WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr, "<>9__5_0");
				WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr, "<>9__6_0");
				WormGameResultsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr, 100664533);
				WormGameResultsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_0_Internal_Boolean_GameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr, 100664534);
				WormGameResultsPromptBehaviour.__c.NativeMethodInfoPtr__configurePlayerEntries_b__6_0_Internal_Int32_WormGameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr, 100664535);
			}

			// Token: 0x0600211D RID: 8477 RVA: 0x0007CF70 File Offset: 0x0007B170
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600211E RID: 8478 RVA: 0x0007CFAC File Offset: 0x0007B1AC
			[CallerCount(0)]
			public unsafe bool _initialize_b__5_0(GameResultsPlayerData player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_0_Internal_Boolean_GameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600211F RID: 8479 RVA: 0x0007CFFC File Offset: 0x0007B1FC
			[CallerCount(0)]
			public unsafe int _configurePlayerEntries_b__6_0(WormGameResultsPlayerData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c.NativeMethodInfoPtr__configurePlayerEntries_b__6_0_Internal_Int32_WormGameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002120 RID: 8480 RVA: 0x00012A02 File Offset: 0x00010C02
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x06002121 RID: 8481 RVA: 0x0007D04C File Offset: 0x0007B24C
			// (set) Token: 0x06002122 RID: 8482 RVA: 0x00012A0B File Offset: 0x00010C0B
			public unsafe static WormGameResultsPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGameResultsPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06002123 RID: 8483 RVA: 0x0007D074 File Offset: 0x0007B274
			// (set) Token: 0x06002124 RID: 8484 RVA: 0x00012A1D File Offset: 0x00010C1D
			public unsafe static Func<GameResultsPlayerData, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameResultsPlayerData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x06002125 RID: 8485 RVA: 0x0007D09C File Offset: 0x0007B29C
			// (set) Token: 0x06002126 RID: 8486 RVA: 0x00012A2F File Offset: 0x00010C2F
			public unsafe static Func<WormGameResultsPlayerData, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsPlayerData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsPromptBehaviour.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001314 RID: 4884
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001317 RID: 4887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001318 RID: 4888
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__5_0_Internal_Boolean_GameResultsPlayerData_0;

			// Token: 0x04001319 RID: 4889
			private static readonly IntPtr NativeMethodInfoPtr__configurePlayerEntries_b__6_0_Internal_Int32_WormGameResultsPlayerData_0;
		}

		// Token: 0x02000334 RID: 820
		[ObfuscatedName("worm.match.prompts.behaviours.WormGameResultsPromptBehaviour+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002127 RID: 8487 RVA: 0x0007D0C4 File Offset: 0x0007B2C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGameResultsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr);
				WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_playerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, "playerData");
				WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664536);
				WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__1_Internal_Boolean_WormGameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664537);
				WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__2_Internal_Boolean_WormGameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664538);
				WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__3_Internal_Boolean_WormGameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664539);
				WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__4_Internal_Boolean_WormGameResultsPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100664540);
			}

			// Token: 0x06002128 RID: 8488 RVA: 0x0007D168 File Offset: 0x0007B368
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsPromptBehaviour.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002129 RID: 8489 RVA: 0x0007D1A4 File Offset: 0x0007B3A4
			[CallerCount(0)]
			public unsafe bool _configurePlayerEntries_b__1(WormGameResultsPlayerData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__1_Internal_Boolean_WormGameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600212A RID: 8490 RVA: 0x0007D1F4 File Offset: 0x0007B3F4
			[CallerCount(0)]
			public unsafe bool _configurePlayerEntries_b__2(WormGameResultsPlayerData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__2_Internal_Boolean_WormGameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600212B RID: 8491 RVA: 0x0007D244 File Offset: 0x0007B444
			[CallerCount(0)]
			public unsafe bool _configurePlayerEntries_b__3(WormGameResultsPlayerData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__3_Internal_Boolean_WormGameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600212C RID: 8492 RVA: 0x0007D294 File Offset: 0x0007B494
			[CallerCount(0)]
			public unsafe bool _configurePlayerEntries_b__4(WormGameResultsPlayerData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__configurePlayerEntries_b__4_Internal_Boolean_WormGameResultsPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600212D RID: 8493 RVA: 0x00012A41 File Offset: 0x00010C41
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x0600212E RID: 8494 RVA: 0x0007D2E4 File Offset: 0x0007B4E4
			// (set) Token: 0x0600212F RID: 8495 RVA: 0x00012A4A File Offset: 0x00010C4A
			public unsafe WormGameResultsPlayerData playerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_playerData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGameResultsPlayerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPromptBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_playerData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400131A RID: 4890
			private static readonly IntPtr NativeFieldInfoPtr_playerData;

			// Token: 0x0400131B RID: 4891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400131C RID: 4892
			private static readonly IntPtr NativeMethodInfoPtr__configurePlayerEntries_b__1_Internal_Boolean_WormGameResultsPlayerData_0;

			// Token: 0x0400131D RID: 4893
			private static readonly IntPtr NativeMethodInfoPtr__configurePlayerEntries_b__2_Internal_Boolean_WormGameResultsPlayerData_0;

			// Token: 0x0400131E RID: 4894
			private static readonly IntPtr NativeMethodInfoPtr__configurePlayerEntries_b__3_Internal_Boolean_WormGameResultsPlayerData_0;

			// Token: 0x0400131F RID: 4895
			private static readonly IntPtr NativeMethodInfoPtr__configurePlayerEntries_b__4_Internal_Boolean_WormGameResultsPlayerData_0;
		}
	}
}
