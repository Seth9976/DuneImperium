using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.match.selection
{
	// Token: 0x02000260 RID: 608
	public class CustomChoiceInfoPromptBehaviour : PromptBehaviour<CustomChoiceInfoPrompt>
	{
		// Token: 0x06001BDF RID: 7135 RVA: 0x00079230 File Offset: 0x00077430
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceInfoPromptBehaviour()
		{
			Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "CustomChoiceInfoPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr);
			CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, "confirmButton");
			CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_choiceItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, "choiceItems");
			CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_additionalItemTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, "additionalItemTemplate");
			CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_additionalItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, "additionalItemContainer");
			CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, "result");
			CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, 100667840);
			CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_Event_SelectChoice_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, 100667841);
			CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_Event_Resolve_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, 100667842);
			CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, 100667843);
			CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr, 100667844);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00079328 File Offset: 0x00077528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534406, XrefRangeEnd = 534452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00079364 File Offset: 0x00077564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534457, RefRangeEnd = 534458, XrefRangeStart = 534452, XrefRangeEnd = 534457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Event_SelectChoice(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_Event_SelectChoice_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000793B0 File Offset: 0x000775B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534458, XrefRangeEnd = 534465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Resolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_Event_Resolve_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000793EC File Offset: 0x000775EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534465, XrefRangeEnd = 534472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00079428 File Offset: 0x00077628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534472, XrefRangeEnd = 534482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceInfoPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceInfoPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000F085 File Offset: 0x0000D285
		public CustomChoiceInfoPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00079464 File Offset: 0x00077664
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0000F08E File Offset: 0x0000D28E
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00079494 File Offset: 0x00077694
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000F0AD File Offset: 0x0000D2AD
		public unsafe List<CustomChoiceInfoPromptItem> choiceItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_choiceItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CustomChoiceInfoPromptItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_choiceItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000794C4 File Offset: 0x000776C4
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		public unsafe CustomChoiceInfoPromptItem additionalItemTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_additionalItemTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceInfoPromptItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_additionalItemTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000794F4 File Offset: 0x000776F4
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0000F0EB File Offset: 0x0000D2EB
		public unsafe Transform additionalItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_additionalItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_additionalItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00079524 File Offset: 0x00077724
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0000F10A File Offset: 0x0000D30A
		public unsafe int result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptBehaviour.NativeFieldInfoPtr_result)) = value;
			}
		}

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_choiceItems;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_additionalItemTemplate;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_additionalItemContainer;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectChoice_Public_Boolean_Int32_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_Event_Resolve_Public_Virtual_New_Void_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Virtual_New_Void_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
