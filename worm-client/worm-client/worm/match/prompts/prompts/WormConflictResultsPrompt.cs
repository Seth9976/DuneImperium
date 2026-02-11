using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.prompts.prompts
{
	// Token: 0x020000B3 RID: 179
	public class WormConflictResultsPrompt : DismissablePrompt
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x0002E178 File Offset: 0x0002C378
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictResultsPrompt()
		{
			Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.prompts", "WormConflictResultsPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr);
			WormConflictResultsPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WormConflictResultsPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr, 100664256);
			WormConflictResultsPrompt.NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr, 100664257);
			WormConflictResultsPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr, 100664258);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x0002E1F8 File Offset: 0x0002C3F8
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x0002E238 File Offset: 0x0002C438
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPrompt.NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0002E27C File Offset: 0x0002C47C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 502457, RefRangeEnd = 502462, XrefRangeStart = 502457, XrefRangeEnd = 502462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictResultsPrompt(DataComposition promptData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictResultsPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictResultsPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00005A10 File Offset: 0x00003C10
		public WormConflictResultsPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0002E2C8 File Offset: 0x0002C4C8
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00005A19 File Offset: 0x00003C19
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictResultsPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_set_PromptData_Private_set_Void_DataComposition_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;
	}
}
