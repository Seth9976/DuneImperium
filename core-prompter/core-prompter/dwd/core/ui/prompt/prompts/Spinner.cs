using System;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000028 RID: 40
	public class Spinner : Object
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00008498 File Offset: 0x00006698
		// Note: this type is marked as 'beforefieldinit'.
		static Spinner()
		{
			Il2CppClassPointerStore<Spinner>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "Spinner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spinner>.NativeClassPtr);
			Spinner.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "<PromptData>k__BackingField");
			Spinner.NativeFieldInfoPtr__Resolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "<Resolved>k__BackingField");
			Spinner.NativeFieldInfoPtr__Unblocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "<Unblocked>k__BackingField");
			Spinner.NativeFieldInfoPtr__TheySeenMe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "<TheySeenMe>k__BackingField");
			Spinner.NativeFieldInfoPtr_ShownMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "ShownMessage");
			Spinner.NativeFieldInfoPtr_ShownTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spinner>.NativeClassPtr, "ShownTitle");
			Spinner.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663430);
			Spinner.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663431);
			Spinner.NativeMethodInfoPtr_set_Resolved_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663432);
			Spinner.NativeMethodInfoPtr_get_Unblocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663433);
			Spinner.NativeMethodInfoPtr_set_Unblocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663434);
			Spinner.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663435);
			Spinner.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663436);
			Spinner.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663437);
			Spinner.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663438);
			Spinner.NativeMethodInfoPtr_Unblock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663439);
			Spinner.NativeMethodInfoPtr_dwd_core_ui_prompt_prompts_IYieldablePrompt_YieldsTo_Private_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663440);
			Spinner.NativeMethodInfoPtr_dwd_core_ui_prompt_prompts_IYieldablePrompt_get_DismissOnYield_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spinner>.NativeClassPtr, 100663441);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00008630 File Offset: 0x00006830
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00008670 File Offset: 0x00006870
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000086AC File Offset: 0x000068AC
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_set_Resolved_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000086EC File Offset: 0x000068EC
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00008728 File Offset: 0x00006928
		public unsafe bool Unblocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_get_Unblocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_set_Unblocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00008768 File Offset: 0x00006968
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000087A4 File Offset: 0x000069A4
		public unsafe virtual bool TheySeenMe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000087E4 File Offset: 0x000069E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1213832, RefRangeEnd = 1213837, XrefRangeStart = 1213805, XrefRangeEnd = 1213832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spinner(LocalizedString shownMessage = null, LocalizedString shownTitle = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spinner>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shownMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shownTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008844 File Offset: 0x00006A44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1213837, RefRangeEnd = 1213842, XrefRangeStart = 1213837, XrefRangeEnd = 1213837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008878 File Offset: 0x00006A78
		[CallerCount(0)]
		public unsafe void Unblock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_Unblock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000088AC File Offset: 0x00006AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213842, XrefRangeEnd = 1213847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool dwd_core_ui_prompt_prompts_IYieldablePrompt_YieldsTo(IPrompt other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_dwd_core_ui_prompt_prompts_IYieldablePrompt_YieldsTo_Private_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000088FC File Offset: 0x00006AFC
		public unsafe virtual bool dwd.core.ui.prompt.prompts.IYieldablePrompt.DismissOnYield
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spinner.NativeMethodInfoPtr_dwd_core_ui_prompt_prompts_IYieldablePrompt_get_DismissOnYield_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public Spinner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00008938 File Offset: 0x00006B38
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002BCF File Offset: 0x00000DCF
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00008968 File Offset: 0x00006B68
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002BEE File Offset: 0x00000DEE
		public unsafe bool _Resolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__Resolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__Resolved_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00008990 File Offset: 0x00006B90
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002C09 File Offset: 0x00000E09
		public unsafe bool _Unblocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__Unblocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__Unblocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000089B8 File Offset: 0x00006BB8
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002C24 File Offset: 0x00000E24
		public unsafe bool _TheySeenMe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__TheySeenMe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr__TheySeenMe_k__BackingField)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000089E0 File Offset: 0x00006BE0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002C3F File Offset: 0x00000E3F
		public unsafe LocalizedString ShownMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_ShownMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_ShownMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00008A10 File Offset: 0x00006C10
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002C5E File Offset: 0x00000E5E
		public unsafe LocalizedString ShownTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_ShownTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spinner.NativeFieldInfoPtr_ShownTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr__Resolved_k__BackingField;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__Unblocked_k__BackingField;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__TheySeenMe_k__BackingField;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_ShownMessage;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_ShownTitle;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolved_Private_set_Void_Boolean_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_Unblocked_Public_get_Boolean_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_set_Unblocked_Private_set_Void_Boolean_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_Unblock_Public_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_ui_prompt_prompts_IYieldablePrompt_YieldsTo_Private_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_ui_prompt_prompts_IYieldablePrompt_get_DismissOnYield_Private_Virtual_Final_New_get_Boolean_0;
	}
}
