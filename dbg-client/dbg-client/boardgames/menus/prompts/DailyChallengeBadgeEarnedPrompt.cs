using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001EB RID: 491
	public class DailyChallengeBadgeEarnedPrompt : DismissablePrompt
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x00067ECC File Offset: 0x000660CC
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeBadgeEarnedPrompt()
		{
			Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "DailyChallengeBadgeEarnedPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr);
			DailyChallengeBadgeEarnedPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			DailyChallengeBadgeEarnedPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr, 100666656);
			DailyChallengeBadgeEarnedPrompt.NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr, 100666657);
			DailyChallengeBadgeEarnedPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr, 100666658);
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00067F4C File Offset: 0x0006614C
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00067F8C File Offset: 0x0006618C
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeBadgeEarnedPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeBadgeEarnedPrompt.NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00067FD0 File Offset: 0x000661D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 502457, RefRangeEnd = 502462, XrefRangeStart = 502457, XrefRangeEnd = 502462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeBadgeEarnedPrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeBadgeEarnedPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeBadgeEarnedPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0000CE46 File Offset: 0x0000B046
		public DailyChallengeBadgeEarnedPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0006801C File Offset: 0x0006621C
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x0000CE4F File Offset: 0x0000B04F
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarnedPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarnedPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;
	}
}
