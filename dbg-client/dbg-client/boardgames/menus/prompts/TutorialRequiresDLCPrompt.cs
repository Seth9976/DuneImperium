using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001FE RID: 510
	public class TutorialRequiresDLCPrompt : BasePrompt
	{
		// Token: 0x0600177A RID: 6010 RVA: 0x00069C6C File Offset: 0x00067E6C
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialRequiresDLCPrompt()
		{
			Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "TutorialRequiresDLCPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr);
			TutorialRequiresDLCPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			TutorialRequiresDLCPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, "<Result>k__BackingField");
			TutorialRequiresDLCPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, 100666729);
			TutorialRequiresDLCPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, 100666730);
			TutorialRequiresDLCPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_TutorialRequiresDLCPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, 100666731);
			TutorialRequiresDLCPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_TutorialRequiresDLCPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, 100666732);
			TutorialRequiresDLCPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_TutorialRequiresDLCPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr, 100666733);
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x00069D28 File Offset: 0x00067F28
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00069D68 File Offset: 0x00067F68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524963, RefRangeEnd = 524967, XrefRangeStart = 524963, XrefRangeEnd = 524967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialRequiresDLCPrompt(DataComposition data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialRequiresDLCPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00069DB4 File Offset: 0x00067FB4
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x00069DF0 File Offset: 0x00067FF0
		public unsafe virtual TutorialRequiresDLCPromptResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_TutorialRequiresDLCPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_TutorialRequiresDLCPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00069E30 File Offset: 0x00068030
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 524967, RefRangeEnd = 524970, XrefRangeStart = 524967, XrefRangeEnd = 524970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(TutorialRequiresDLCPromptResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialRequiresDLCPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_TutorialRequiresDLCPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0000D19B File Offset: 0x0000B39B
		public TutorialRequiresDLCPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00069E70 File Offset: 0x00068070
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialRequiresDLCPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialRequiresDLCPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00069EA0 File Offset: 0x000680A0
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		public unsafe TutorialRequiresDLCPromptResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialRequiresDLCPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialRequiresDLCPrompt.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_TutorialRequiresDLCPromptResult_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_TutorialRequiresDLCPromptResult_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_TutorialRequiresDLCPromptResult_0;
	}
}
