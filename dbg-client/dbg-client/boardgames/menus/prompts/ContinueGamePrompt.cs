using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E8 RID: 488
	public class ContinueGamePrompt : BasePrompt
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x00067968 File Offset: 0x00065B68
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueGamePrompt()
		{
			Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ContinueGamePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr);
			ContinueGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			ContinueGamePrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, "<Result>k__BackingField");
			ContinueGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666643);
			ContinueGamePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666644);
			ContinueGamePrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ContinueGameResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666645);
			ContinueGamePrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ContinueGameResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666646);
			ContinueGamePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666647);
			ContinueGamePrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ContinueGameResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666648);
			ContinueGamePrompt.NativeMethodInfoPtr_WithFlavor_Public_ContinueGamePrompt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr, 100666649);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00067A4C File Offset: 0x00065C4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524963, RefRangeEnd = 524967, XrefRangeStart = 524961, XrefRangeEnd = 524963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueGamePrompt(DataComposition data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueGamePrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00067A98 File Offset: 0x00065C98
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00067AD8 File Offset: 0x00065CD8
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00067B14 File Offset: 0x00065D14
		public unsafe virtual ContinueGameResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ContinueGameResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ContinueGameResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00067B54 File Offset: 0x00065D54
		[CallerCount(0)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00067B88 File Offset: 0x00065D88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 524967, RefRangeEnd = 524970, XrefRangeStart = 524967, XrefRangeEnd = 524967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(ContinueGameResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ContinueGameResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00067BC8 File Offset: 0x00065DC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524975, RefRangeEnd = 524977, XrefRangeStart = 524970, XrefRangeEnd = 524975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueGamePrompt WithFlavor(string flavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueGamePrompt.NativeMethodInfoPtr_WithFlavor_Public_ContinueGamePrompt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContinueGamePrompt>(intPtr3) : null;
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0000CD8A File Offset: 0x0000AF8A
		public ContinueGamePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00067C18 File Offset: 0x00065E18
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0000CD93 File Offset: 0x0000AF93
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00067C48 File Offset: 0x00065E48
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x0000CDB2 File Offset: 0x0000AFB2
		public unsafe ContinueGameResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueGamePrompt.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ContinueGameResult_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_ContinueGameResult_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ContinueGameResult_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavor_Public_ContinueGamePrompt_String_0;
	}
}
