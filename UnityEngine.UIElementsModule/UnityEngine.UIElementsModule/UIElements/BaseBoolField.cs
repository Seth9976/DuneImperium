using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003C RID: 60
	public class BaseBoolField : BaseField<bool>
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x0002EF68 File Offset: 0x0002D168
		// Note: this type is marked as 'beforefieldinit'.
		static BaseBoolField()
		{
			Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseBoolField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr);
			BaseBoolField.NativeFieldInfoPtr_m_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, "m_Label");
			BaseBoolField.NativeFieldInfoPtr_m_CheckMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, "m_CheckMark");
			BaseBoolField.NativeFieldInfoPtr_m_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, "m_Clickable");
			BaseBoolField.NativeFieldInfoPtr_m_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, "m_OriginalText");
			BaseBoolField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663981);
			BaseBoolField.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663982);
			BaseBoolField.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663983);
			BaseBoolField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663984);
			BaseBoolField.NativeMethodInfoPtr_InitLabel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663985);
			BaseBoolField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663986);
			BaseBoolField.NativeMethodInfoPtr_OnClickEvent_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663987);
			BaseBoolField.NativeMethodInfoPtr_ToggleValue_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663988);
			BaseBoolField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663989);
			BaseBoolField.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663990);
			BaseBoolField.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr, 100663991);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0002F0C4 File Offset: 0x0002D2C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288334, RefRangeEnd = 288337, XrefRangeStart = 288283, XrefRangeEnd = 288334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseBoolField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseBoolField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBoolField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0002F110 File Offset: 0x0002D310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288337, XrefRangeEnd = 288339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBoolField.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0002F154 File Offset: 0x0002D354
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0002F18C File Offset: 0x0002D38C
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBoolField.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 288342, RefRangeEnd = 288350, XrefRangeStart = 288339, XrefRangeEnd = 288342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBoolField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288360, RefRangeEnd = 288362, XrefRangeStart = 288350, XrefRangeEnd = 288360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseBoolField.NativeMethodInfoPtr_InitLabel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0002F20C File Offset: 0x0002D40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288377, RefRangeEnd = 288378, XrefRangeStart = 288362, XrefRangeEnd = 288377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseBoolField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002F258 File Offset: 0x0002D458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288378, XrefRangeEnd = 288406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClickEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseBoolField.NativeMethodInfoPtr_OnClickEvent_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0002F29C File Offset: 0x0002D49C
		[CallerCount(0)]
		public unsafe virtual void ToggleValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseBoolField.NativeMethodInfoPtr_ToggleValue_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002F2D8 File Offset: 0x0002D4D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288417, RefRangeEnd = 288418, XrefRangeStart = 288406, XrefRangeEnd = 288417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseBoolField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002F314 File Offset: 0x0002D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288418, XrefRangeEnd = 288436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseBoolField.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002F350 File Offset: 0x0002D550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288436, XrefRangeEnd = 288454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseBoolField.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000359D File Offset: 0x0000179D
		public BaseBoolField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0002F38C File Offset: 0x0002D58C
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x000035A6 File Offset: 0x000017A6
		public unsafe Label m_Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0002F3BC File Offset: 0x0002D5BC
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x000035C5 File Offset: 0x000017C5
		public unsafe VisualElement m_CheckMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_CheckMark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_CheckMark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0002F3EC File Offset: 0x0002D5EC
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000035E4 File Offset: 0x000017E4
		public unsafe Clickable m_Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0002F41C File Offset: 0x0002D61C
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003603 File Offset: 0x00001803
		public unsafe string m_OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseBoolField.NativeFieldInfoPtr_m_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00003622 File Offset: 0x00001822
		public Label boolFieldLabelElement
		{
			get
			{
				return this.m_Label;
			}
		}

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_m_Label;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_m_CheckMark;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_m_Clickable;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalText;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_InitLabel_Protected_Virtual_New_Void_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_OnClickEvent_Private_Void_EventBase_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_ToggleValue_Protected_Virtual_New_Void_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0;
	}
}
