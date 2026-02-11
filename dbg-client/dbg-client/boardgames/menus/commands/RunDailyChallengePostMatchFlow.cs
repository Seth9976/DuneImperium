using System;
using boardgames.match.data;
using Canis.utils.localization;
using dbgclient.data;
using dbgclient.menus.commands;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.commands
{
	// Token: 0x02000225 RID: 549
	public class RunDailyChallengePostMatchFlow : Command
	{
		// Token: 0x06001914 RID: 6420 RVA: 0x0006F058 File Offset: 0x0006D258
		// Note: this type is marked as 'beforefieldinit'.
		static RunDailyChallengePostMatchFlow()
		{
			Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunDailyChallengePostMatchFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr);
			RunDailyChallengePostMatchFlow.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, "GameOptions");
			RunDailyChallengePostMatchFlow.NativeFieldInfoPtr_DailyChallengeScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, "DailyChallengeScore");
			RunDailyChallengePostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, 100667117);
			RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, 100667118);
			RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_ShowOutOfAttemptsPrompt_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, 100667119);
			RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_ShowScorePrompt_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, 100667120);
			RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_GetScore_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, 100667121);
			RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_RunLeaderboardFlow_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, 100667122);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0006F128 File Offset: 0x0006D328
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDailyChallengePostMatchFlow(GameOptionsData gameOptions, Dictionary<LocalizableTextVariables, int> dailyChallengeScore)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyChallengeScore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow.NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Dictionary_2_LocalizableTextVariables_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0006F188 File Offset: 0x0006D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528541, XrefRangeEnd = 528546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528546, XrefRangeEnd = 528560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ShowOutOfAttemptsPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_ShowOutOfAttemptsPrompt_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0006F220 File Offset: 0x0006D420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528560, XrefRangeEnd = 528584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ShowScorePrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_ShowScorePrompt_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0006F26C File Offset: 0x0006D46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528584, XrefRangeEnd = 528599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_GetScore_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0006F2B4 File Offset: 0x0006D4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528599, XrefRangeEnd = 528604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RunLeaderboardFlow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow.NativeMethodInfoPtr_RunLeaderboardFlow_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0000DD64 File Offset: 0x0000BF64
		public RunDailyChallengePostMatchFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0006F2F4 File Offset: 0x0006D4F4
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000DD6D File Offset: 0x0000BF6D
		public unsafe GameOptionsData GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0006F324 File Offset: 0x0006D524
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public unsafe Dictionary<LocalizableTextVariables, int> DailyChallengeScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow.NativeFieldInfoPtr_DailyChallengeScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow.NativeFieldInfoPtr_DailyChallengeScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeScore;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameOptionsData_Dictionary_2_LocalizableTextVariables_Int32_0;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutOfAttemptsPrompt_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_ShowScorePrompt_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_GetScore_Protected_Virtual_New_Int32_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_RunLeaderboardFlow_Protected_IEnumerator_0;

		// Token: 0x02000402 RID: 1026
		[ObfuscatedName("boardgames.menus.commands.RunDailyChallengePostMatchFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600303A RID: 12346 RVA: 0x000B875C File Offset: 0x000B695C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr);
				RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr, "<>9");
				RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr, "<>9__7_0");
				RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr, "<>9__7_1");
				RunDailyChallengePostMatchFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr, 100667124);
				RunDailyChallengePostMatchFlow.__c.NativeMethodInfoPtr__RunLeaderboardFlow_b__7_0_Internal_DailyChallengeLeaderboardData_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr, 100667125);
				RunDailyChallengePostMatchFlow.__c.NativeMethodInfoPtr__RunLeaderboardFlow_b__7_1_Internal_Boolean_DailyChallengeLeaderboardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr, 100667126);
			}

			// Token: 0x0600303B RID: 12347 RVA: 0x000B8800 File Offset: 0x000B6A00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600303C RID: 12348 RVA: 0x000B883C File Offset: 0x000B6A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528410, XrefRangeEnd = 528414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DailyChallengeLeaderboardData _RunLeaderboardFlow_b__7_0(DataComposition rankData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rankData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow.__c.NativeMethodInfoPtr__RunLeaderboardFlow_b__7_0_Internal_DailyChallengeLeaderboardData_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboardData>(intPtr3) : null;
				}
			}

			// Token: 0x0600303D RID: 12349 RVA: 0x000B888C File Offset: 0x000B6A8C
			[CallerCount(0)]
			public unsafe bool _RunLeaderboardFlow_b__7_1(DailyChallengeLeaderboardData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow.__c.NativeMethodInfoPtr__RunLeaderboardFlow_b__7_1_Internal_Boolean_DailyChallengeLeaderboardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600303E RID: 12350 RVA: 0x00018EF3 File Offset: 0x000170F3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE6 RID: 3558
			// (get) Token: 0x0600303F RID: 12351 RVA: 0x000B88DC File Offset: 0x000B6ADC
			// (set) Token: 0x06003040 RID: 12352 RVA: 0x00018EFC File Offset: 0x000170FC
			public unsafe static RunDailyChallengePostMatchFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDailyChallengePostMatchFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE7 RID: 3559
			// (get) Token: 0x06003041 RID: 12353 RVA: 0x000B8904 File Offset: 0x000B6B04
			// (set) Token: 0x06003042 RID: 12354 RVA: 0x00018F0E File Offset: 0x0001710E
			public unsafe static Func<DataComposition, DailyChallengeLeaderboardData> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, DailyChallengeLeaderboardData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE8 RID: 3560
			// (get) Token: 0x06003043 RID: 12355 RVA: 0x000B892C File Offset: 0x000B6B2C
			// (set) Token: 0x06003044 RID: 12356 RVA: 0x00018F20 File Offset: 0x00017120
			public unsafe static Func<DailyChallengeLeaderboardData, bool> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DailyChallengeLeaderboardData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunDailyChallengePostMatchFlow.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DD4 RID: 7636
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001DD5 RID: 7637
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001DD6 RID: 7638
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04001DD7 RID: 7639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DD8 RID: 7640
			private static readonly IntPtr NativeMethodInfoPtr__RunLeaderboardFlow_b__7_0_Internal_DailyChallengeLeaderboardData_DataComposition_0;

			// Token: 0x04001DD9 RID: 7641
			private static readonly IntPtr NativeMethodInfoPtr__RunLeaderboardFlow_b__7_1_Internal_Boolean_DailyChallengeLeaderboardData_0;
		}

		// Token: 0x02000403 RID: 1027
		[ObfuscatedName("boardgames.menus.commands.RunDailyChallengePostMatchFlow+<RunLeaderboardFlow>d__7")]
		public sealed class _RunLeaderboardFlow_d__7 : Object
		{
			// Token: 0x06003045 RID: 12357 RVA: 0x000B8954 File Offset: 0x000B6B54
			// Note: this type is marked as 'beforefieldinit'.
			static _RunLeaderboardFlow_d__7()
			{
				Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, "<RunLeaderboardFlow>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr);
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, "<>1__state");
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, "<>2__current");
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, "<>4__this");
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr__leaderboardFlow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, "<leaderboardFlow>5__2");
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr__playAgainPrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, "<playAgainPrompt>5__3");
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, 100667127);
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, 100667128);
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, 100667129);
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, 100667130);
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, 100667131);
				RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr, 100667132);
			}

			// Token: 0x06003046 RID: 12358 RVA: 0x000B8A5C File Offset: 0x000B6C5C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunLeaderboardFlow_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003047 RID: 12359 RVA: 0x000B8AA4 File Offset: 0x000B6CA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003048 RID: 12360 RVA: 0x000B8AD8 File Offset: 0x000B6CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528414, XrefRangeEnd = 528529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DEE RID: 3566
			// (get) Token: 0x06003049 RID: 12361 RVA: 0x000B8B14 File Offset: 0x000B6D14
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600304A RID: 12362 RVA: 0x000B8B54 File Offset: 0x000B6D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528529, XrefRangeEnd = 528534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DEF RID: 3567
			// (get) Token: 0x0600304B RID: 12363 RVA: 0x000B8B88 File Offset: 0x000B6D88
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600304C RID: 12364 RVA: 0x00018F32 File Offset: 0x00017132
			public _RunLeaderboardFlow_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE9 RID: 3561
			// (get) Token: 0x0600304D RID: 12365 RVA: 0x000B8BC8 File Offset: 0x000B6DC8
			// (set) Token: 0x0600304E RID: 12366 RVA: 0x00018F3B File Offset: 0x0001713B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DEA RID: 3562
			// (get) Token: 0x0600304F RID: 12367 RVA: 0x000B8BF0 File Offset: 0x000B6DF0
			// (set) Token: 0x06003050 RID: 12368 RVA: 0x00018F56 File Offset: 0x00017156
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEB RID: 3563
			// (get) Token: 0x06003051 RID: 12369 RVA: 0x000B8C20 File Offset: 0x000B6E20
			// (set) Token: 0x06003052 RID: 12370 RVA: 0x00018F75 File Offset: 0x00017175
			public unsafe RunDailyChallengePostMatchFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDailyChallengePostMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEC RID: 3564
			// (get) Token: 0x06003053 RID: 12371 RVA: 0x000B8C50 File Offset: 0x000B6E50
			// (set) Token: 0x06003054 RID: 12372 RVA: 0x00018F94 File Offset: 0x00017194
			public unsafe RunDailyChallengeLeaderboardFlow _leaderboardFlow_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr__leaderboardFlow_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDailyChallengeLeaderboardFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr__leaderboardFlow_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DED RID: 3565
			// (get) Token: 0x06003055 RID: 12373 RVA: 0x000B8C80 File Offset: 0x000B6E80
			// (set) Token: 0x06003056 RID: 12374 RVA: 0x00018FB3 File Offset: 0x000171B3
			public unsafe ConfirmOrDenyPrompt _playAgainPrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr__playAgainPrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._RunLeaderboardFlow_d__7.NativeFieldInfoPtr__playAgainPrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DDA RID: 7642
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DDB RID: 7643
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DDC RID: 7644
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DDD RID: 7645
			private static readonly IntPtr NativeFieldInfoPtr__leaderboardFlow_5__2;

			// Token: 0x04001DDE RID: 7646
			private static readonly IntPtr NativeFieldInfoPtr__playAgainPrompt_5__3;

			// Token: 0x04001DDF RID: 7647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DE0 RID: 7648
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DE1 RID: 7649
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DE2 RID: 7650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DE3 RID: 7651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DE4 RID: 7652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000404 RID: 1028
		[ObfuscatedName("boardgames.menus.commands.RunDailyChallengePostMatchFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06003057 RID: 12375 RVA: 0x000B8CB0 File Offset: 0x000B6EB0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr);
				RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, 100667133);
				RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, 100667134);
				RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, 100667135);
				RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, 100667136);
				RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, 100667137);
				RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr, 100667138);
			}

			// Token: 0x06003058 RID: 12376 RVA: 0x000B8D90 File Offset: 0x000B6F90
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengePostMatchFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003059 RID: 12377 RVA: 0x000B8DD8 File Offset: 0x000B6FD8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600305A RID: 12378 RVA: 0x000B8E0C File Offset: 0x000B700C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528534, XrefRangeEnd = 528536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DF3 RID: 3571
			// (get) Token: 0x0600305B RID: 12379 RVA: 0x000B8E48 File Offset: 0x000B7048
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600305C RID: 12380 RVA: 0x000B8E88 File Offset: 0x000B7088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528536, XrefRangeEnd = 528541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DF4 RID: 3572
			// (get) Token: 0x0600305D RID: 12381 RVA: 0x000B8EBC File Offset: 0x000B70BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengePostMatchFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600305E RID: 12382 RVA: 0x00018FD2 File Offset: 0x000171D2
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DF0 RID: 3568
			// (get) Token: 0x0600305F RID: 12383 RVA: 0x000B8EFC File Offset: 0x000B70FC
			// (set) Token: 0x06003060 RID: 12384 RVA: 0x00018FDB File Offset: 0x000171DB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DF1 RID: 3569
			// (get) Token: 0x06003061 RID: 12385 RVA: 0x000B8F24 File Offset: 0x000B7124
			// (set) Token: 0x06003062 RID: 12386 RVA: 0x00018FF6 File Offset: 0x000171F6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF2 RID: 3570
			// (get) Token: 0x06003063 RID: 12387 RVA: 0x000B8F54 File Offset: 0x000B7154
			// (set) Token: 0x06003064 RID: 12388 RVA: 0x00019015 File Offset: 0x00017215
			public unsafe RunDailyChallengePostMatchFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDailyChallengePostMatchFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDailyChallengePostMatchFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DE5 RID: 7653
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DE6 RID: 7654
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DE7 RID: 7655
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DE8 RID: 7656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DE9 RID: 7657
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DEA RID: 7658
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DEB RID: 7659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DEC RID: 7660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DED RID: 7661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
