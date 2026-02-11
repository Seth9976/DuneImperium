using System;
using boardgames.data;
using boardgames.menus.commands;
using boardgames.menus.ui;
using Canis;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using worm.dataProviders;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000DD RID: 221
	public class WormLocalPlayModePromptBehaviour : MonoBehaviour
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x000350D8 File Offset: 0x000332D8
		// Note: this type is marked as 'beforefieldinit'.
		static WormLocalPlayModePromptBehaviour()
		{
			Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormLocalPlayModePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr);
			WormLocalPlayModePromptBehaviour.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, "timer");
			WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, 100664589);
			WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_SinglePlayer_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, 100664590);
			WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_PlaySinglePlayer_Private_Static_IEnumerator_SerializedMatchComponent_RunCheckContinueOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, 100664591);
			WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_Skirmish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, 100664592);
			WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_ReloadSkirmish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, 100664593);
			WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, 100664594);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00035194 File Offset: 0x00033394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700062, XrefRangeEnd = 700067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000351D4 File Offset: 0x000333D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700067, XrefRangeEnd = 700116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SinglePlayer(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_SinglePlayer_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00035218 File Offset: 0x00033418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700116, XrefRangeEnd = 700122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator PlaySinglePlayer(SerializedMatchComponent soloMatchData, RunCheckContinueOfflineMatchFlow continueFlow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(soloMatchData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continueFlow);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_PlaySinglePlayer_Private_Static_IEnumerator_SerializedMatchComponent_RunCheckContinueOfflineMatchFlow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00035270 File Offset: 0x00033470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700122, XrefRangeEnd = 700132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Skirmish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_Skirmish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000352A4 File Offset: 0x000334A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700132, XrefRangeEnd = 700137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ReloadSkirmish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr_Event_ReloadSkirmish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000352D8 File Offset: 0x000334D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLocalPlayModePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00006E19 File Offset: 0x00005019
		public WormLocalPlayModePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00035314 File Offset: 0x00033514
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00006E22 File Offset: 0x00005022
		public unsafe DailyChallengeTimerDisplay timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour.NativeFieldInfoPtr_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeTimerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_Event_SinglePlayer_Public_Void_DataComposition_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_PlaySinglePlayer_Private_Static_IEnumerator_SerializedMatchComponent_RunCheckContinueOfflineMatchFlow_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_Event_Skirmish_Public_Void_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_Event_ReloadSkirmish_Public_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200033B RID: 827
		[ObfuscatedName("worm.match.prompts.behaviours.WormLocalPlayModePromptBehaviour+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06002171 RID: 8561 RVA: 0x00012C87 File Offset: 0x00010E87
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__O>.NativeClassPtr);
				WormLocalPlayModePromptBehaviour.__O.NativeFieldInfoPtr__0___IsLoggedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__O>.NativeClassPtr, "<0>__IsLoggedIn");
			}

			// Token: 0x06002172 RID: 8562 RVA: 0x00012CBB File Offset: 0x00010EBB
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000935 RID: 2357
			// (get) Token: 0x06002173 RID: 8563 RVA: 0x0007DF14 File Offset: 0x0007C114
			// (set) Token: 0x06002174 RID: 8564 RVA: 0x00012CC4 File Offset: 0x00010EC4
			public unsafe static Func<bool> _0___IsLoggedIn
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormLocalPlayModePromptBehaviour.__O.NativeFieldInfoPtr__0___IsLoggedIn, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormLocalPlayModePromptBehaviour.__O.NativeFieldInfoPtr__0___IsLoggedIn, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001345 RID: 4933
			private static readonly IntPtr NativeFieldInfoPtr__0___IsLoggedIn;
		}

		// Token: 0x0200033C RID: 828
		[ObfuscatedName("worm.match.prompts.behaviours.WormLocalPlayModePromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002175 RID: 8565 RVA: 0x0007DF3C File Offset: 0x0007C13C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr);
				WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr, "<>9__2_0");
				WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr, "<>9__3_0");
				WormLocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr, 100664596);
				WormLocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__Event_SinglePlayer_b__2_0_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr, 100664597);
				WormLocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__PlaySinglePlayer_b__3_0_Internal_IFailable_RunConfigureNewOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr, 100664598);
			}

			// Token: 0x06002176 RID: 8566 RVA: 0x0007DFE0 File Offset: 0x0007C1E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002177 RID: 8567 RVA: 0x0007E01C File Offset: 0x0007C21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700015, XrefRangeEnd = 700019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_SinglePlayer_b__2_0(MatchInitData s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__Event_SinglePlayer_b__2_0_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002178 RID: 8568 RVA: 0x0007E06C File Offset: 0x0007C26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700019, XrefRangeEnd = 700025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _PlaySinglePlayer_b__3_0(RunConfigureNewOfflineMatchFlow f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.__c.NativeMethodInfoPtr__PlaySinglePlayer_b__3_0_Internal_IFailable_RunConfigureNewOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x06002179 RID: 8569 RVA: 0x00012CD6 File Offset: 0x00010ED6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000936 RID: 2358
			// (get) Token: 0x0600217A RID: 8570 RVA: 0x0007E0BC File Offset: 0x0007C2BC
			// (set) Token: 0x0600217B RID: 8571 RVA: 0x00012CDF File Offset: 0x00010EDF
			public unsafe static WormLocalPlayModePromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLocalPlayModePromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000937 RID: 2359
			// (get) Token: 0x0600217C RID: 8572 RVA: 0x0007E0E4 File Offset: 0x0007C2E4
			// (set) Token: 0x0600217D RID: 8573 RVA: 0x00012CF1 File Offset: 0x00010EF1
			public unsafe static Func<MatchInitData, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000938 RID: 2360
			// (get) Token: 0x0600217E RID: 8574 RVA: 0x0007E10C File Offset: 0x0007C30C
			// (set) Token: 0x0600217F RID: 8575 RVA: 0x00012D03 File Offset: 0x00010F03
			public unsafe static Func<RunConfigureNewOfflineMatchFlow, IFailable> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunConfigureNewOfflineMatchFlow, IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormLocalPlayModePromptBehaviour.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001346 RID: 4934
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001347 RID: 4935
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001348 RID: 4936
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001349 RID: 4937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400134A RID: 4938
			private static readonly IntPtr NativeMethodInfoPtr__Event_SinglePlayer_b__2_0_Internal_Boolean_MatchInitData_0;

			// Token: 0x0400134B RID: 4939
			private static readonly IntPtr NativeMethodInfoPtr__PlaySinglePlayer_b__3_0_Internal_IFailable_RunConfigureNewOfflineMatchFlow_0;
		}

		// Token: 0x0200033D RID: 829
		[ObfuscatedName("worm.match.prompts.behaviours.WormLocalPlayModePromptBehaviour+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002180 RID: 8576 RVA: 0x0007E134 File Offset: 0x0007C334
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr);
				WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr_soloMatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, "soloMatchData");
				WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, 100664599);
				WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__Event_SinglePlayer_b__1_Internal_IEnumerator_RunCheckContinueOfflineMatchFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, 100664600);
			}

			// Token: 0x06002181 RID: 8577 RVA: 0x0007E19C File Offset: 0x0007C39C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002182 RID: 8578 RVA: 0x0007E1D8 File Offset: 0x0007C3D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700025, XrefRangeEnd = 700031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Event_SinglePlayer_b__1(RunCheckContinueOfflineMatchFlow f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__Event_SinglePlayer_b__1_Internal_IEnumerator_RunCheckContinueOfflineMatchFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06002183 RID: 8579 RVA: 0x00012D15 File Offset: 0x00010F15
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x06002184 RID: 8580 RVA: 0x0007E228 File Offset: 0x0007C428
			// (set) Token: 0x06002185 RID: 8581 RVA: 0x00012D1E File Offset: 0x00010F1E
			public unsafe SerializedMatchComponent soloMatchData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr_soloMatchData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedMatchComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr_soloMatchData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400134C RID: 4940
			private static readonly IntPtr NativeFieldInfoPtr_soloMatchData;

			// Token: 0x0400134D RID: 4941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400134E RID: 4942
			private static readonly IntPtr NativeMethodInfoPtr__Event_SinglePlayer_b__1_Internal_IEnumerator_RunCheckContinueOfflineMatchFlow_0;
		}

		// Token: 0x0200033E RID: 830
		[ObfuscatedName("worm.match.prompts.behaviours.WormLocalPlayModePromptBehaviour+<PlaySinglePlayer>d__3")]
		public sealed class _PlaySinglePlayer_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06002186 RID: 8582 RVA: 0x0007E258 File Offset: 0x0007C458
			// Note: this type is marked as 'beforefieldinit'.
			static _PlaySinglePlayer_d__3()
			{
				Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, "<PlaySinglePlayer>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr);
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, "<>1__state");
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, "<>2__current");
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr_continueFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, "continueFlow");
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr_soloMatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, "soloMatchData");
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, 100664601);
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, 100664602);
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, 100664603);
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, 100664604);
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, 100664605);
				WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr, 100664606);
			}

			// Token: 0x06002187 RID: 8583 RVA: 0x0007E34C File Offset: 0x0007C54C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlaySinglePlayer_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002188 RID: 8584 RVA: 0x0007E394 File Offset: 0x0007C594
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002189 RID: 8585 RVA: 0x0007E3C8 File Offset: 0x0007C5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700031, XrefRangeEnd = 700037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x0600218A RID: 8586 RVA: 0x0007E404 File Offset: 0x0007C604
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600218B RID: 8587 RVA: 0x0007E444 File Offset: 0x0007C644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700037, XrefRangeEnd = 700042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x0600218C RID: 8588 RVA: 0x0007E478 File Offset: 0x0007C678
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600218D RID: 8589 RVA: 0x00012D3D File Offset: 0x00010F3D
			public _PlaySinglePlayer_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x0007E4B8 File Offset: 0x0007C6B8
			// (set) Token: 0x0600218F RID: 8591 RVA: 0x00012D46 File Offset: 0x00010F46
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x0007E4E0 File Offset: 0x0007C6E0
			// (set) Token: 0x06002191 RID: 8593 RVA: 0x00012D61 File Offset: 0x00010F61
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093C RID: 2364
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x0007E510 File Offset: 0x0007C710
			// (set) Token: 0x06002193 RID: 8595 RVA: 0x00012D80 File Offset: 0x00010F80
			public unsafe RunCheckContinueOfflineMatchFlow continueFlow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr_continueFlow);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCheckContinueOfflineMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr_continueFlow), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x06002194 RID: 8596 RVA: 0x0007E540 File Offset: 0x0007C740
			// (set) Token: 0x06002195 RID: 8597 RVA: 0x00012D9F File Offset: 0x00010F9F
			public unsafe SerializedMatchComponent soloMatchData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr_soloMatchData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedMatchComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._PlaySinglePlayer_d__3.NativeFieldInfoPtr_soloMatchData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400134F RID: 4943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001350 RID: 4944
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001351 RID: 4945
			private static readonly IntPtr NativeFieldInfoPtr_continueFlow;

			// Token: 0x04001352 RID: 4946
			private static readonly IntPtr NativeFieldInfoPtr_soloMatchData;

			// Token: 0x04001353 RID: 4947
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001354 RID: 4948
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001355 RID: 4949
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001356 RID: 4950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001357 RID: 4951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001358 RID: 4952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200033F RID: 831
		[ObfuscatedName("worm.match.prompts.behaviours.WormLocalPlayModePromptBehaviour+<Start>d__1")]
		public sealed class _Start_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x06002196 RID: 8598 RVA: 0x0007E570 File Offset: 0x0007C770
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr);
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, "<>1__state");
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, "<>2__current");
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, "<>4__this");
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, "<provider>5__2");
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, 100664607);
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, 100664608);
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, 100664609);
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, 100664610);
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, 100664611);
				WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr, 100664612);
			}

			// Token: 0x06002197 RID: 8599 RVA: 0x0007E664 File Offset: 0x0007C864
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLocalPlayModePromptBehaviour._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002198 RID: 8600 RVA: 0x0007E6AC File Offset: 0x0007C8AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002199 RID: 8601 RVA: 0x0007E6E0 File Offset: 0x0007C8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700042, XrefRangeEnd = 700057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x0600219A RID: 8602 RVA: 0x0007E71C File Offset: 0x0007C91C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600219B RID: 8603 RVA: 0x0007E75C File Offset: 0x0007C95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 700057, XrefRangeEnd = 700062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x0007E790 File Offset: 0x0007C990
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLocalPlayModePromptBehaviour._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600219D RID: 8605 RVA: 0x00012DBE File Offset: 0x00010FBE
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
			// (set) Token: 0x0600219F RID: 8607 RVA: 0x00012DC7 File Offset: 0x00010FC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0007E7F8 File Offset: 0x0007C9F8
			// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00012DE2 File Offset: 0x00010FE2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x060021A2 RID: 8610 RVA: 0x0007E828 File Offset: 0x0007CA28
			// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00012E01 File Offset: 0x00011001
			public unsafe WormLocalPlayModePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLocalPlayModePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x060021A4 RID: 8612 RVA: 0x0007E858 File Offset: 0x0007CA58
			// (set) Token: 0x060021A5 RID: 8613 RVA: 0x00012E20 File Offset: 0x00011020
			public unsafe WormDailyChallengeProvider _provider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr__provider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDailyChallengeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLocalPlayModePromptBehaviour._Start_d__1.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001359 RID: 4953
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400135A RID: 4954
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400135B RID: 4955
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400135C RID: 4956
			private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

			// Token: 0x0400135D RID: 4957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400135E RID: 4958
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400135F RID: 4959
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001360 RID: 4960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001361 RID: 4961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001362 RID: 4962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
