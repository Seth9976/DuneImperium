using System;
using boardgames.match.data;
using boardgames.menus.prompts;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000008 RID: 8
public class GameResultsCommand : Command
{
	// Token: 0x0600002D RID: 45 RVA: 0x0001DCDC File Offset: 0x0001BEDC
	// Note: this type is marked as 'beforefieldinit'.
	static GameResultsCommand()
	{
		Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "GameResultsCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr);
		GameResultsCommand.NativeFieldInfoPtr_gameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "gameResults");
		GameResultsCommand.NativeFieldInfoPtr_optionsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "optionsData");
		GameResultsCommand.NativeFieldInfoPtr_localResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "localResult");
		GameResultsCommand.NativeMethodInfoPtr_get_ReturnToMenus_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663321);
		GameResultsCommand.NativeMethodInfoPtr_get_LocalPlayerWon_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663322);
		GameResultsCommand.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663323);
		GameResultsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663324);
		GameResultsCommand.NativeMethodInfoPtr_runGameResultsFlow_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663325);
		GameResultsCommand.NativeMethodInfoPtr_updateChallengeHighScores_Protected_Virtual_New_Void_String_DBGGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663326);
		GameResultsCommand.NativeMethodInfoPtr_updateAchievements_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663327);
		GameResultsCommand.NativeMethodInfoPtr_getGameResultsPrompt_Protected_Virtual_New_GameResultsPrompt_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663328);
		GameResultsCommand.NativeMethodInfoPtr_configureGameResultsPromptData_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663329);
		GameResultsCommand.NativeMethodInfoPtr_getDailyChallengeScore_Protected_Virtual_New_Dictionary_2_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, 100663330);
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600002E RID: 46 RVA: 0x0001DE10 File Offset: 0x0001C010
	public unsafe virtual bool ReturnToMenus
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_get_ReturnToMenus_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600002F RID: 47 RVA: 0x0001DE58 File Offset: 0x0001C058
	public unsafe bool LocalPlayerWon
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 495005, RefRangeEnd = 495007, XrefRangeStart = 494989, XrefRangeEnd = 495005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand.NativeMethodInfoPtr_get_LocalPlayerWon_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0001DE94 File Offset: 0x0001C094
	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495007, XrefRangeEnd = 495009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameResultsCommand(DBGGameResults results)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495046, XrefRangeEnd = 495051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0001DF2C File Offset: 0x0001C12C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495051, XrefRangeEnd = 495056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator runGameResultsFlow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_runGameResultsFlow_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0001DF78 File Offset: 0x0001C178
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void updateChallengeHighScores(string scenarioName, DBGGameResultsEntry localPlayerResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localPlayerResult);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_updateChallengeHighScores_Protected_Virtual_New_Void_String_DBGGameResultsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 495066, RefRangeEnd = 495067, XrefRangeStart = 495056, XrefRangeEnd = 495066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void updateAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_updateAchievements_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0001E014 File Offset: 0x0001C214
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495067, XrefRangeEnd = 495071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameResultsPrompt getGameResultsPrompt(DataComposition data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_getGameResultsPrompt_Protected_Virtual_New_GameResultsPrompt_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameResultsPrompt>(intPtr3) : null;
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x0001E070 File Offset: 0x0001C270
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495071, XrefRangeEnd = 495126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual DataComposition configureGameResultsPromptData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_configureGameResultsPromptData_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0001E0BC File Offset: 0x0001C2BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495126, XrefRangeEnd = 495132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<LocalizableTextVariables, int> getDailyChallengeScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsCommand.NativeMethodInfoPtr_getDailyChallengeScore_Protected_Virtual_New_Dictionary_2_LocalizableTextVariables_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr3) : null;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002152 File Offset: 0x00000352
	public GameResultsCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000039 RID: 57 RVA: 0x0001E108 File Offset: 0x0001C308
	// (set) Token: 0x0600003A RID: 58 RVA: 0x0000215B File Offset: 0x0000035B
	public unsafe DBGGameResults gameResults
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.NativeFieldInfoPtr_gameResults);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.NativeFieldInfoPtr_gameResults), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600003B RID: 59 RVA: 0x0001E138 File Offset: 0x0001C338
	// (set) Token: 0x0600003C RID: 60 RVA: 0x0000217A File Offset: 0x0000037A
	public unsafe GameOptionsData optionsData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.NativeFieldInfoPtr_optionsData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameOptionsData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.NativeFieldInfoPtr_optionsData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003D RID: 61 RVA: 0x0001E168 File Offset: 0x0001C368
	// (set) Token: 0x0600003E RID: 62 RVA: 0x00002199 File Offset: 0x00000399
	public unsafe DBGGameResultsEntry localResult
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.NativeFieldInfoPtr_localResult);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResultsEntry>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.NativeFieldInfoPtr_localResult), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeFieldInfoPtr_gameResults;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeFieldInfoPtr_optionsData;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeFieldInfoPtr_localResult;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_get_ReturnToMenus_Protected_Virtual_New_get_Boolean_0;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerWon_Protected_get_Boolean_0;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_runGameResultsFlow_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr_updateChallengeHighScores_Protected_Virtual_New_Void_String_DBGGameResultsEntry_0;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_updateAchievements_Protected_Virtual_New_Void_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_getGameResultsPrompt_Protected_Virtual_New_GameResultsPrompt_DataComposition_0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr_configureGameResultsPromptData_Protected_Virtual_New_DataComposition_0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeMethodInfoPtr_getDailyChallengeScore_Protected_Virtual_New_Dictionary_2_LocalizableTextVariables_Int32_0;

	// Token: 0x020002C0 RID: 704
	[ObfuscatedName("GameResultsCommand+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Object
	{
		// Token: 0x06002124 RID: 8484 RVA: 0x0008BA88 File Offset: 0x00089C88
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass5_0>.NativeClassPtr);
			GameResultsCommand.__c__DisplayClass5_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass5_0>.NativeClassPtr, "accountID");
			GameResultsCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass5_0>.NativeClassPtr, 100663331);
			GameResultsCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__get_LocalPlayerWon_b__0_Internal_Boolean_DBGGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass5_0>.NativeClassPtr, 100663332);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0008BAF0 File Offset: 0x00089CF0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass5_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0008BB2C File Offset: 0x00089D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494756, XrefRangeEnd = 494761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_LocalPlayerWon_b__0(DBGGameResultsEntry r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__get_LocalPlayerWon_b__0_Internal_Boolean_DBGGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00011527 File Offset: 0x0000F727
		public __c__DisplayClass5_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x0008BB7C File Offset: 0x00089D7C
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x00011530 File Offset: 0x0000F730
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.__c__DisplayClass5_0.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.__c__DisplayClass5_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr__get_LocalPlayerWon_b__0_Internal_Boolean_DBGGameResultsEntry_0;
	}

	// Token: 0x020002C1 RID: 705
	[ObfuscatedName("GameResultsCommand+<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : Object
	{
		// Token: 0x0600212A RID: 8490 RVA: 0x0008BBAC File Offset: 0x00089DAC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass9_0>.NativeClassPtr);
			GameResultsCommand.__c__DisplayClass9_0.NativeFieldInfoPtr_sceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass9_0>.NativeClassPtr, "sceneChange");
			GameResultsCommand.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass9_0>.NativeClassPtr, 100663333);
			GameResultsCommand.__c__DisplayClass9_0.NativeMethodInfoPtr__runGameResultsFlow_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass9_0>.NativeClassPtr, 100663334);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0008BC14 File Offset: 0x00089E14
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass9_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsCommand.__c__DisplayClass9_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0008BC50 File Offset: 0x00089E50
		[CallerCount(0)]
		public unsafe bool _runGameResultsFlow_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand.__c__DisplayClass9_0.NativeMethodInfoPtr__runGameResultsFlow_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0001154F File Offset: 0x0000F74F
		public __c__DisplayClass9_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0008BC8C File Offset: 0x00089E8C
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00011558 File Offset: 0x0000F758
		public unsafe ChangeScene sceneChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.__c__DisplayClass9_0.NativeFieldInfoPtr_sceneChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangeScene>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand.__c__DisplayClass9_0.NativeFieldInfoPtr_sceneChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeFieldInfoPtr_sceneChange;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr__runGameResultsFlow_b__0_Internal_Boolean_0;
	}

	// Token: 0x020002C2 RID: 706
	[ObfuscatedName("GameResultsCommand+<execute>d__8")]
	public sealed class _execute_d__8 : Object
	{
		// Token: 0x06002130 RID: 8496 RVA: 0x0008BCBC File Offset: 0x00089EBC
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__8()
		{
			Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "<execute>d__8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr);
			GameResultsCommand._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, "<>1__state");
			GameResultsCommand._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, "<>2__current");
			GameResultsCommand._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, "<>4__this");
			GameResultsCommand._execute_d__8.NativeFieldInfoPtr__prompter_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, "<prompter>5__2");
			GameResultsCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, 100663335);
			GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, 100663336);
			GameResultsCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, 100663337);
			GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, 100663338);
			GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, 100663339);
			GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr, 100663340);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0008BDB0 File Offset: 0x00089FB0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__8(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsCommand._execute_d__8>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0008BDF8 File Offset: 0x00089FF8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0008BE2C File Offset: 0x0008A02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494761, XrefRangeEnd = 494795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0008BE68 File Offset: 0x0008A068
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x0008BEA8 File Offset: 0x0008A0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494795, XrefRangeEnd = 494800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0008BEDC File Offset: 0x0008A0DC
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00011577 File Offset: 0x0000F777
		public _execute_d__8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0008BF1C File Offset: 0x0008A11C
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00011580 File Offset: 0x0000F780
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x0008BF44 File Offset: 0x0008A144
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x0001159B File Offset: 0x0000F79B
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x0008BF74 File Offset: 0x0008A174
		// (set) Token: 0x0600213D RID: 8509 RVA: 0x000115BA File Offset: 0x0000F7BA
		public unsafe GameResultsCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameResultsCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0008BFA4 File Offset: 0x0008A1A4
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x000115D9 File Offset: 0x0000F7D9
		public unsafe ScopedPrompter _prompter_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr__prompter_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedPrompter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._execute_d__8.NativeFieldInfoPtr__prompter_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeFieldInfoPtr__prompter_5__2;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020002C3 RID: 707
	[ObfuscatedName("GameResultsCommand+<runGameResultsFlow>d__9")]
	public sealed class _runGameResultsFlow_d__9 : Object
	{
		// Token: 0x06002140 RID: 8512 RVA: 0x0008BFD4 File Offset: 0x0008A1D4
		// Note: this type is marked as 'beforefieldinit'.
		static _runGameResultsFlow_d__9()
		{
			Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameResultsCommand>.NativeClassPtr, "<runGameResultsFlow>d__9");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr);
			GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, "<>1__state");
			GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, "<>2__current");
			GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, "<>4__this");
			GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr__resultsPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, "<resultsPrompt>5__2");
			GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr__postMatchCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, "<postMatchCommand>5__3");
			GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, 100663341);
			GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, 100663342);
			GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, 100663343);
			GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, 100663344);
			GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, 100663345);
			GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr, 100663346);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x0008C0DC File Offset: 0x0008A2DC
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _runGameResultsFlow_d__9(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsCommand._runGameResultsFlow_d__9>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0008C124 File Offset: 0x0008A324
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0008C158 File Offset: 0x0008A358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494800, XrefRangeEnd = 494984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x0008C194 File Offset: 0x0008A394
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0008C1D4 File Offset: 0x0008A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494984, XrefRangeEnd = 494989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x0008C208 File Offset: 0x0008A408
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsCommand._runGameResultsFlow_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000115F8 File Offset: 0x0000F7F8
		public _runGameResultsFlow_d__9(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x0008C248 File Offset: 0x0008A448
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x00011601 File Offset: 0x0000F801
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x0008C270 File Offset: 0x0008A470
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x0001161C File Offset: 0x0000F81C
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x0008C2A0 File Offset: 0x0008A4A0
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x0001163B File Offset: 0x0000F83B
		public unsafe GameResultsCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameResultsCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x0008C2D0 File Offset: 0x0008A4D0
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x0001165A File Offset: 0x0000F85A
		public unsafe GameResultsPrompt _resultsPrompt_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr__resultsPrompt_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameResultsPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr__resultsPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x0008C300 File Offset: 0x0008A500
		// (set) Token: 0x06002151 RID: 8529 RVA: 0x00011679 File Offset: 0x0000F879
		public unsafe RunPostMatchFlow _postMatchCommand_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr__postMatchCommand_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPostMatchFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsCommand._runGameResultsFlow_d__9.NativeFieldInfoPtr__postMatchCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr__resultsPrompt_5__2;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr__postMatchCommand_5__3;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
