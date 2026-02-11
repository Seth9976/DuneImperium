using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001EE RID: 494
	public class FeedbackPrompt : BasePrompt
	{
		// Token: 0x06001719 RID: 5913 RVA: 0x000687E0 File Offset: 0x000669E0
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackPrompt()
		{
			Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "FeedbackPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr);
			FeedbackPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr, "<Result>k__BackingField");
			FeedbackPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr, 100666683);
			FeedbackPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_4_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr, 100666684);
			FeedbackPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_4_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr, 100666685);
			FeedbackPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_4_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr, 100666686);
			FeedbackPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr, 100666687);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00068888 File Offset: 0x00066A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525130, XrefRangeEnd = 525149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x000688C4 File Offset: 0x00066AC4
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x000688FC File Offset: 0x00066AFC
		public unsafe virtual ValueTuple<string, string, bool, bool> Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_4_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<string, string, bool, bool>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_4_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00068944 File Offset: 0x00066B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524996, RefRangeEnd = 524997, XrefRangeStart = 524996, XrefRangeEnd = 524997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(ValueTuple<string, string, bool, bool> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_4_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0006898C File Offset: 0x00066B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525153, RefRangeEnd = 525154, XrefRangeStart = 525149, XrefRangeEnd = 525153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0000CF05 File Offset: 0x0000B105
		public FeedbackPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000689C0 File Offset: 0x00066BC0
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0000CF0E File Offset: 0x0000B10E
		public ValueTuple<string, string, bool, bool> _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return new ValueTuple<string, string, bool, bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, string, bool, bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, string, bool, bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_4_String_String_Boolean_Boolean_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_4_String_String_Boolean_Boolean_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_4_String_String_Boolean_Boolean_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
