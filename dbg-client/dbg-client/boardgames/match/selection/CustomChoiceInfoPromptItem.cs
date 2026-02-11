using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace boardgames.match.selection
{
	// Token: 0x02000261 RID: 609
	public class CustomChoiceInfoPromptItem : MonoBehaviour
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x0007954C File Offset: 0x0007774C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomChoiceInfoPromptItem()
		{
			Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "CustomChoiceInfoPromptItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr);
			CustomChoiceInfoPromptItem.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, "label");
			CustomChoiceInfoPromptItem.NativeFieldInfoPtr_promptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, "promptBehaviour");
			CustomChoiceInfoPromptItem.NativeFieldInfoPtr_choiceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, "choiceIndex");
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_Int32_LocalizableText_CustomChoiceInfoPromptBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667845);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Select_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667846);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Select_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667847);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Event_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667848);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Event_Select_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667849);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_SelectAndResolve_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667850);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Event_SelectAndResolve_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667851);
			CustomChoiceInfoPromptItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr, 100667852);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00079658 File Offset: 0x00077858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534482, XrefRangeEnd = 534484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(int index, LocalizableText text, CustomChoiceInfoPromptBehaviour behaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_Int32_LocalizableText_CustomChoiceInfoPromptBehaviour_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000796C8 File Offset: 0x000778C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 534488, RefRangeEnd = 534491, XrefRangeStart = 534484, XrefRangeEnd = 534488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Select_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00079704 File Offset: 0x00077904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534491, XrefRangeEnd = 534495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Select(bool select)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref select;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Select_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00079750 File Offset: 0x00077950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534495, XrefRangeEnd = 534496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Event_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00079784 File Offset: 0x00077984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534496, XrefRangeEnd = 534502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Select(bool select)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref select;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Event_Select_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000797C4 File Offset: 0x000779C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534502, XrefRangeEnd = 534503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SelectAndResolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr_SelectAndResolve_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00079800 File Offset: 0x00077A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534503, XrefRangeEnd = 534504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectAndResolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr_Event_SelectAndResolve_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00079834 File Offset: 0x00077A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534504, XrefRangeEnd = 534505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceInfoPromptItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomChoiceInfoPromptItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomChoiceInfoPromptItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0000F125 File Offset: 0x0000D325
		public CustomChoiceInfoPromptItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00079870 File Offset: 0x00077A70
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0000F12E File Offset: 0x0000D32E
		public unsafe TextMeshProUGUI label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptItem.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptItem.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000798A0 File Offset: 0x00077AA0
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x0000F14D File Offset: 0x0000D34D
		public unsafe CustomChoiceInfoPromptBehaviour promptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptItem.NativeFieldInfoPtr_promptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomChoiceInfoPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptItem.NativeFieldInfoPtr_promptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000798D0 File Offset: 0x00077AD0
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0000F16C File Offset: 0x0000D36C
		public unsafe int choiceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptItem.NativeFieldInfoPtr_choiceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomChoiceInfoPromptItem.NativeFieldInfoPtr_choiceIndex)) = value;
			}
		}

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr_promptBehaviour;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_choiceIndex;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_Int32_LocalizableText_CustomChoiceInfoPromptBehaviour_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Boolean_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Boolean_Boolean_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_Event_Select_Public_Void_Boolean_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_SelectAndResolve_Public_Boolean_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectAndResolve_Public_Void_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
