using System;
using boardgames.chat;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001FC RID: 508
	public class ReportPlayerPrompt : ResolvablePrompt<ValueTuple<string, Nullable<ReportReason>>>
	{
		// Token: 0x06001774 RID: 6004 RVA: 0x00069B44 File Offset: 0x00067D44
		// Note: this type is marked as 'beforefieldinit'.
		static ReportPlayerPrompt()
		{
			Il2CppClassPointerStore<ReportPlayerPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ReportPlayerPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportPlayerPrompt>.NativeClassPtr);
			ReportPlayerPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportPlayerPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			ReportPlayerPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPrompt>.NativeClassPtr, 100666727);
			ReportPlayerPrompt.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPrompt>.NativeClassPtr, 100666728);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x00069BB0 File Offset: 0x00067DB0
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00069BF0 File Offset: 0x00067DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525248, XrefRangeEnd = 525282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportPlayerPrompt(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportPlayerPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPrompt.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0000D173 File Offset: 0x0000B373
		public ReportPlayerPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00069C3C File Offset: 0x00067E3C
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0000D17C File Offset: 0x0000B37C
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportPlayerPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportPlayerPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
