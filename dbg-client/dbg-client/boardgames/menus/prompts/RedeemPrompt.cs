using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001FB RID: 507
	public class RedeemPrompt : BasePrompt
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x0006997C File Offset: 0x00067B7C
		// Note: this type is marked as 'beforefieldinit'.
		static RedeemPrompt()
		{
			Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "RedeemPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr);
			RedeemPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr, "<Result>k__BackingField");
			RedeemPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_2_RedeemPromptResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr, 100666723);
			RedeemPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_2_RedeemPromptResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr, 100666724);
			RedeemPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_2_RedeemPromptResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr, 100666725);
			RedeemPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr, 100666726);
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00069A10 File Offset: 0x00067C10
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x00069A48 File Offset: 0x00067C48
		public unsafe virtual ValueTuple<RedeemPromptResult, string> Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_2_RedeemPromptResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<RedeemPromptResult, string>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525246, XrefRangeEnd = 525247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_2_RedeemPromptResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00069A90 File Offset: 0x00067C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525247, XrefRangeEnd = 525248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(ValueTuple<RedeemPromptResult, string> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_2_RedeemPromptResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00069AD8 File Offset: 0x00067CD8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 520201, RefRangeEnd = 520229, XrefRangeStart = 520201, XrefRangeEnd = 520229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RedeemPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedeemPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0000D13C File Offset: 0x0000B33C
		public RedeemPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00069B14 File Offset: 0x00067D14
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0000D145 File Offset: 0x0000B345
		public ValueTuple<RedeemPromptResult, string> _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return new ValueTuple<RedeemPromptResult, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<RedeemPromptResult, string>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<RedeemPromptResult, string>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_2_RedeemPromptResult_String_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_2_RedeemPromptResult_String_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_2_RedeemPromptResult_String_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
