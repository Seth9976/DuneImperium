using System;
using dwd.core.data;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001F1 RID: 497
	public class FriendsListPrompt : BasePrompt
	{
		// Token: 0x0600172B RID: 5931 RVA: 0x00068C00 File Offset: 0x00066E00
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListPrompt()
		{
			Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "FriendsListPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr);
			FriendsListPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, "<Result>k__BackingField");
			FriendsListPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			FriendsListPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_FriendsListPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666693);
			FriendsListPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_FriendsListPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666694);
			FriendsListPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666695);
			FriendsListPrompt.NativeMethodInfoPtr__ctor_Public_Void_ScrollPositionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666696);
			FriendsListPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_FriendsListPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666697);
			FriendsListPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666698);
			FriendsListPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666699);
			FriendsListPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr, 100666700);
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00068CF8 File Offset: 0x00066EF8
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x00068D34 File Offset: 0x00066F34
		public unsafe virtual FriendsListPromptResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_FriendsListPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_FriendsListPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00068D74 File Offset: 0x00066F74
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00068DB4 File Offset: 0x00066FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525154, XrefRangeEnd = 525179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListPrompt(ScrollPositionData scrollData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr__ctor_Public_Void_ScrollPositionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00068E00 File Offset: 0x00067000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 520197, RefRangeEnd = 520200, XrefRangeStart = 520197, XrefRangeEnd = 520200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(FriendsListPromptResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_FriendsListPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00068E40 File Offset: 0x00067040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520196, RefRangeEnd = 520197, XrefRangeStart = 520196, XrefRangeEnd = 520197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00068E74 File Offset: 0x00067074
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00068EC4 File Offset: 0x000670C4
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0000CF64 File Offset: 0x0000B164
		public FriendsListPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00068F00 File Offset: 0x00067100
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x0000CF6D File Offset: 0x0000B16D
		public unsafe FriendsListPromptResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPrompt.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00068F28 File Offset: 0x00067128
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000CF88 File Offset: 0x0000B188
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_FriendsListPromptResult_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_FriendsListPromptResult_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScrollPositionData_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_FriendsListPromptResult_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0;
	}
}
