using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E1 RID: 481
	public class ChallengesSelectPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x06001682 RID: 5762 RVA: 0x000663F8 File Offset: 0x000645F8
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengesSelectPrompt()
		{
			Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ChallengesSelectPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr);
			ChallengesSelectPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, "<Result>k__BackingField");
			ChallengesSelectPrompt.NativeFieldInfoPtr_skipReturnToMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, "skipReturnToMenu");
			ChallengesSelectPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, 100666596);
			ChallengesSelectPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, 100666597);
			ChallengesSelectPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, 100666598);
			ChallengesSelectPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, 100666599);
			ChallengesSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr, 100666600);
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x000664B4 File Offset: 0x000646B4
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x000664F4 File Offset: 0x000646F4
		public unsafe virtual MatchInitData Result
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00066538 File Offset: 0x00064738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524566, XrefRangeEnd = 524567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengesSelectPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00066574 File Offset: 0x00064774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524568, RefRangeEnd = 524569, XrefRangeStart = 524567, XrefRangeEnd = 524568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(MatchInitData result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000665B8 File Offset: 0x000647B8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 524574, RefRangeEnd = 524584, XrefRangeStart = 524569, XrefRangeEnd = 524574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengesSelectPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesSelectPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesSelectPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0000CB8F File Offset: 0x0000AD8F
		public ChallengesSelectPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x000665F4 File Offset: 0x000647F4
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x0000CB98 File Offset: 0x0000AD98
		public unsafe MatchInitData _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x00066624 File Offset: 0x00064824
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x0000CBB7 File Offset: 0x0000ADB7
		public unsafe bool skipReturnToMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPrompt.NativeFieldInfoPtr_skipReturnToMenu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesSelectPrompt.NativeFieldInfoPtr_skipReturnToMenu)) = value;
			}
		}

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeFieldInfoPtr_skipReturnToMenu;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_MatchInitData_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_MatchInitData_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_MatchInitData_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
