using System;
using Canis;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.prompts
{
	// Token: 0x020001F3 RID: 499
	public class GameResultsPrompt : ResolvablePrompt<MatchInitData>
	{
		// Token: 0x06001742 RID: 5954 RVA: 0x00069158 File Offset: 0x00067358
		// Note: this type is marked as 'beforefieldinit'.
		static GameResultsPrompt()
		{
			Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "GameResultsPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr);
			GameResultsPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			GameResultsPrompt.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, "GameID");
			GameResultsPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, 100666706);
			GameResultsPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, 100666707);
			GameResultsPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, 100666708);
			GameResultsPrompt.NativeMethodInfoPtr_WithFlavor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, 100666709);
			GameResultsPrompt.NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, 100666710);
			GameResultsPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr, 100666711);
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00069228 File Offset: 0x00067428
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00069268 File Offset: 0x00067468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525185, RefRangeEnd = 525186, XrefRangeStart = 525179, XrefRangeEnd = 525185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameResultsPrompt(DataComposition data, DBGGameResults message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameResultsPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_DBGGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000692C8 File Offset: 0x000674C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525186, XrefRangeEnd = 525187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_New_Boolean_IPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00069320 File Offset: 0x00067520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525187, XrefRangeEnd = 525194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithFlavor(string flavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPrompt.NativeMethodInfoPtr_WithFlavor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00069364 File Offset: 0x00067564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525194, XrefRangeEnd = 525217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithFlavors(IEnumerable<string> flavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameResultsPrompt.NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x000693A8 File Offset: 0x000675A8
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameResultsPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0000CFCF File Offset: 0x0000B1CF
		public GameResultsPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000693F0 File Offset: 0x000675F0
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00069420 File Offset: 0x00067620
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0000CFF7 File Offset: 0x0000B1F7
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPrompt.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameResultsPrompt.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_DBGGameResults_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_New_Boolean_IPrompt_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavor_Public_Void_String_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_New_get_Boolean_0;
	}
}
