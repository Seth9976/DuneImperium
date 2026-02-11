using System;
using Canis;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.networking;

namespace worm.match.commands
{
	// Token: 0x02000233 RID: 563
	public class WormGameResultsCommand : GameResultsCommand
	{
		// Token: 0x06001877 RID: 6263 RVA: 0x000625EC File Offset: 0x000607EC
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsCommand()
		{
			Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands", "WormGameResultsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr);
			WormGameResultsCommand.NativeFieldInfoPtr_wormGameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, "wormGameResults");
			WormGameResultsCommand.NativeMethodInfoPtr_get_ReturnToMenus_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, 100666678);
			WormGameResultsCommand.NativeMethodInfoPtr__ctor_Public_Void_WormGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, 100666679);
			WormGameResultsCommand.NativeMethodInfoPtr_updateAchievements_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, 100666680);
			WormGameResultsCommand.NativeMethodInfoPtr_configureGameResultsPromptData_Protected_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, 100666681);
			WormGameResultsCommand.NativeMethodInfoPtr_getDailyChallengeScore_Protected_Virtual_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, 100666682);
			WormGameResultsCommand.NativeMethodInfoPtr__configureGameResultsPromptData_b__5_0_Private_Boolean_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, 100666683);
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x000626A8 File Offset: 0x000608A8
		public unsafe override bool ReturnToMenus
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsCommand.NativeMethodInfoPtr_get_ReturnToMenus_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000626F0 File Offset: 0x000608F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718449, XrefRangeEnd = 718451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsCommand(WormGameResults results)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.NativeMethodInfoPtr__ctor_Public_Void_WormGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0006273C File Offset: 0x0006093C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718451, XrefRangeEnd = 718653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsCommand.NativeMethodInfoPtr_updateAchievements_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00062778 File Offset: 0x00060978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718653, XrefRangeEnd = 718710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition configureGameResultsPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsCommand.NativeMethodInfoPtr_configureGameResultsPromptData_Protected_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000627C4 File Offset: 0x000609C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718710, XrefRangeEnd = 718735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<LocalizableTextVariables, int> getDailyChallengeScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsCommand.NativeMethodInfoPtr_getDailyChallengeScore_Protected_Virtual_Dictionary_2_LocalizableTextVariables_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr3) : null;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00062810 File Offset: 0x00060A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718735, XrefRangeEnd = 718740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _configureGameResultsPromptData_b__5_0(WormGameResultsEntry r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.NativeMethodInfoPtr__configureGameResultsPromptData_b__5_0_Private_Boolean_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		public WormGameResultsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x00062860 File Offset: 0x00060A60
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x0000E7E1 File Offset: 0x0000C9E1
		public unsafe WormGameResults wormGameResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsCommand.NativeFieldInfoPtr_wormGameResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGameResults>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsCommand.NativeFieldInfoPtr_wormGameResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_wormGameResults;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnToMenus_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormGameResults_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_updateAchievements_Protected_Virtual_Void_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_configureGameResultsPromptData_Protected_Virtual_DataComposition_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_getDailyChallengeScore_Protected_Virtual_Dictionary_2_LocalizableTextVariables_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr__configureGameResultsPromptData_b__5_0_Private_Boolean_WormGameResultsEntry_0;

		// Token: 0x02000404 RID: 1028
		[ObfuscatedName("worm.match.commands.WormGameResultsCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002A18 RID: 10776 RVA: 0x000978D0 File Offset: 0x00095AD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGameResultsCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr);
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__4_0");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__4_1");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__4_2");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__4_3");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__4_4");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__4_5");
				WormGameResultsCommand.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, "<>9__6_0");
				WormGameResultsCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666685);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_0_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666686);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_1_Internal_MatchInitData_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666687);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_2_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666688);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_3_Internal_MatchInitData_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666689);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_4_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666690);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_5_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666691);
				WormGameResultsCommand.__c.NativeMethodInfoPtr__getDailyChallengeScore_b__6_0_Internal_Boolean_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr, 100666692);
			}

			// Token: 0x06002A19 RID: 10777 RVA: 0x00097A3C File Offset: 0x00095C3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A1A RID: 10778 RVA: 0x00097A78 File Offset: 0x00095C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718433, XrefRangeEnd = 718437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updateAchievements_b__4_0(MatchInitData challenge)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_0_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A1B RID: 10779 RVA: 0x00097AC8 File Offset: 0x00095CC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchInitData _updateAchievements_b__4_1(MatchInitData challenge)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_1_Internal_MatchInitData_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
				}
			}

			// Token: 0x06002A1C RID: 10780 RVA: 0x00097B18 File Offset: 0x00095D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718437, XrefRangeEnd = 718441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updateAchievements_b__4_2(MatchInitData challenge)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_2_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A1D RID: 10781 RVA: 0x00097B68 File Offset: 0x00095D68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchInitData _updateAchievements_b__4_3(MatchInitData challenge)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_3_Internal_MatchInitData_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
				}
			}

			// Token: 0x06002A1E RID: 10782 RVA: 0x00097BB8 File Offset: 0x00095DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718441, XrefRangeEnd = 718443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updateAchievements_b__4_4(MatchInitData match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_4_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A1F RID: 10783 RVA: 0x00097C08 File Offset: 0x00095E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updateAchievements_b__4_5(MatchInitData match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__updateAchievements_b__4_5_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A20 RID: 10784 RVA: 0x00097C58 File Offset: 0x00095E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718443, XrefRangeEnd = 718449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getDailyChallengeScore_b__6_0(WormGameResultsEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsCommand.__c.NativeMethodInfoPtr__getDailyChallengeScore_b__6_0_Internal_Boolean_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A21 RID: 10785 RVA: 0x00017095 File Offset: 0x00015295
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x06002A22 RID: 10786 RVA: 0x00097CA8 File Offset: 0x00095EA8
			// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0001709E File Offset: 0x0001529E
			public unsafe static WormGameResultsCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormGameResultsCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEC RID: 3052
			// (get) Token: 0x06002A24 RID: 10788 RVA: 0x00097CD0 File Offset: 0x00095ED0
			// (set) Token: 0x06002A25 RID: 10789 RVA: 0x000170B0 File Offset: 0x000152B0
			public unsafe static Func<MatchInitData, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x06002A26 RID: 10790 RVA: 0x00097CF8 File Offset: 0x00095EF8
			// (set) Token: 0x06002A27 RID: 10791 RVA: 0x000170C2 File Offset: 0x000152C2
			public unsafe static Func<MatchInitData, MatchInitData> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, MatchInitData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00097D20 File Offset: 0x00095F20
			// (set) Token: 0x06002A29 RID: 10793 RVA: 0x000170D4 File Offset: 0x000152D4
			public unsafe static Func<MatchInitData, bool> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x06002A2A RID: 10794 RVA: 0x00097D48 File Offset: 0x00095F48
			// (set) Token: 0x06002A2B RID: 10795 RVA: 0x000170E6 File Offset: 0x000152E6
			public unsafe static Func<MatchInitData, MatchInitData> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, MatchInitData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00097D70 File Offset: 0x00095F70
			// (set) Token: 0x06002A2D RID: 10797 RVA: 0x000170F8 File Offset: 0x000152F8
			public unsafe static Func<MatchInitData, bool> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x06002A2E RID: 10798 RVA: 0x00097D98 File Offset: 0x00095F98
			// (set) Token: 0x06002A2F RID: 10799 RVA: 0x0001710A File Offset: 0x0001530A
			public unsafe static Func<MatchInitData, bool> __9__4_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__4_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF2 RID: 3058
			// (get) Token: 0x06002A30 RID: 10800 RVA: 0x00097DC0 File Offset: 0x00095FC0
			// (set) Token: 0x06002A31 RID: 10801 RVA: 0x0001711C File Offset: 0x0001531C
			public unsafe static Func<WormGameResultsEntry, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormGameResultsCommand.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001869 RID: 6249
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400186A RID: 6250
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400186B RID: 6251
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400186C RID: 6252
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x0400186D RID: 6253
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x0400186E RID: 6254
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x0400186F RID: 6255
			private static readonly IntPtr NativeFieldInfoPtr___9__4_5;

			// Token: 0x04001870 RID: 6256
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001871 RID: 6257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001872 RID: 6258
			private static readonly IntPtr NativeMethodInfoPtr__updateAchievements_b__4_0_Internal_Boolean_MatchInitData_0;

			// Token: 0x04001873 RID: 6259
			private static readonly IntPtr NativeMethodInfoPtr__updateAchievements_b__4_1_Internal_MatchInitData_MatchInitData_0;

			// Token: 0x04001874 RID: 6260
			private static readonly IntPtr NativeMethodInfoPtr__updateAchievements_b__4_2_Internal_Boolean_MatchInitData_0;

			// Token: 0x04001875 RID: 6261
			private static readonly IntPtr NativeMethodInfoPtr__updateAchievements_b__4_3_Internal_MatchInitData_MatchInitData_0;

			// Token: 0x04001876 RID: 6262
			private static readonly IntPtr NativeMethodInfoPtr__updateAchievements_b__4_4_Internal_Boolean_MatchInitData_0;

			// Token: 0x04001877 RID: 6263
			private static readonly IntPtr NativeMethodInfoPtr__updateAchievements_b__4_5_Internal_Boolean_MatchInitData_0;

			// Token: 0x04001878 RID: 6264
			private static readonly IntPtr NativeMethodInfoPtr__getDailyChallengeScore_b__6_0_Internal_Boolean_WormGameResultsEntry_0;
		}
	}
}
