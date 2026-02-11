using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000081 RID: 129
	public class RadioButton : BaseBoolField
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x0004A300 File Offset: 0x00048500
		// Note: this type is marked as 'beforefieldinit'.
		static RadioButton()
		{
			Il2CppClassPointerStore<RadioButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RadioButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadioButton>.NativeClassPtr);
			RadioButton.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "ussClassName");
			RadioButton.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "labelUssClassName");
			RadioButton.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "inputUssClassName");
			RadioButton.NativeFieldInfoPtr_checkmarkBackgroundUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "checkmarkBackgroundUssClassName");
			RadioButton.NativeFieldInfoPtr_checkmarkUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "checkmarkUssClassName");
			RadioButton.NativeFieldInfoPtr_textUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "textUssClassName");
			RadioButton.NativeFieldInfoPtr_m_CheckmarkBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "m_CheckmarkBackground");
			RadioButton.NativeMethodInfoPtr_get_value_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665138);
			RadioButton.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665139);
			RadioButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665140);
			RadioButton.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665141);
			RadioButton.NativeMethodInfoPtr_OnOptionAttachToPanel_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665142);
			RadioButton.NativeMethodInfoPtr_OnOptionDetachFromPanel_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665143);
			RadioButton.NativeMethodInfoPtr_InitLabel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665144);
			RadioButton.NativeMethodInfoPtr_ToggleValue_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665145);
			RadioButton.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBoxOption_SetSelected_Private_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665146);
			RadioButton.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665147);
			RadioButton.NativeMethodInfoPtr_UpdateCheckmark_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665148);
			RadioButton.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, 100665149);
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0004A4AC File Offset: 0x000486AC
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x0004A4F4 File Offset: 0x000486F4
		public unsafe override bool value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303071, XrefRangeEnd = 303074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.NativeMethodInfoPtr_get_value_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303074, XrefRangeEnd = 303087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0004A540 File Offset: 0x00048740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303088, RefRangeEnd = 303089, XrefRangeStart = 303087, XrefRangeEnd = 303088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RadioButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0004A57C File Offset: 0x0004877C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303138, RefRangeEnd = 303139, XrefRangeStart = 303089, XrefRangeEnd = 303138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RadioButton(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButton>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0004A5C8 File Offset: 0x000487C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303139, XrefRangeEnd = 303145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOptionAttachToPanel(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.NativeMethodInfoPtr_OnOptionAttachToPanel_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0004A60C File Offset: 0x0004880C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303145, XrefRangeEnd = 303151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOptionDetachFromPanel(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.NativeMethodInfoPtr_OnOptionDetachFromPanel_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0004A650 File Offset: 0x00048850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303151, XrefRangeEnd = 303158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.NativeMethodInfoPtr_InitLabel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0004A68C File Offset: 0x0004888C
		[CallerCount(0)]
		public unsafe override void ToggleValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.NativeMethodInfoPtr_ToggleValue_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0004A6C8 File Offset: 0x000488C8
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBoxOption_SetSelected(bool selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBoxOption_SetSelected_Private_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0004A708 File Offset: 0x00048908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303158, XrefRangeEnd = 303160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0004A754 File Offset: 0x00048954
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303169, RefRangeEnd = 303172, XrefRangeStart = 303160, XrefRangeEnd = 303169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCheckmark()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.NativeMethodInfoPtr_UpdateCheckmark_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0004A788 File Offset: 0x00048988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303172, XrefRangeEnd = 303179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00006C48 File Offset: 0x00004E48
		public RadioButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0004A7C4 File Offset: 0x000489C4
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00006C51 File Offset: 0x00004E51
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButton.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButton.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0004A7E4 File Offset: 0x000489E4
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00006C63 File Offset: 0x00004E63
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButton.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButton.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0004A804 File Offset: 0x00048A04
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00006C75 File Offset: 0x00004E75
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButton.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButton.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0004A824 File Offset: 0x00048A24
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00006C87 File Offset: 0x00004E87
		public unsafe static string checkmarkBackgroundUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButton.NativeFieldInfoPtr_checkmarkBackgroundUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButton.NativeFieldInfoPtr_checkmarkBackgroundUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0004A844 File Offset: 0x00048A44
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00006C99 File Offset: 0x00004E99
		public unsafe static string checkmarkUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButton.NativeFieldInfoPtr_checkmarkUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButton.NativeFieldInfoPtr_checkmarkUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0004A864 File Offset: 0x00048A64
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00006CAB File Offset: 0x00004EAB
		public unsafe static string textUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButton.NativeFieldInfoPtr_textUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButton.NativeFieldInfoPtr_textUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0004A884 File Offset: 0x00048A84
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00006CBD File Offset: 0x00004EBD
		public unsafe VisualElement m_CheckmarkBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButton.NativeFieldInfoPtr_m_CheckmarkBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButton.NativeFieldInfoPtr_m_CheckmarkBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00006CDC File Offset: 0x00004EDC
		public void SetSelected(bool selected)
		{
			this.SetSelected(selected);
		}

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_checkmarkBackgroundUssClassName;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_checkmarkUssClassName;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_textUssClassName;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_m_CheckmarkBackground;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Boolean_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionAttachToPanel_Private_Void_AttachToPanelEvent_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionDetachFromPanel_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_InitLabel_Protected_Virtual_Void_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_ToggleValue_Protected_Virtual_Void_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBoxOption_SetSelected_Private_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Boolean_0;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCheckmark_Private_Void_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x020003B4 RID: 948
		public new class UxmlFactory : UxmlFactory<RadioButton, RadioButton.UxmlTraits>
		{
			// Token: 0x0600392F RID: 14639 RVA: 0x00017F7C File Offset: 0x0001617C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<RadioButton.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadioButton.UxmlFactory>.NativeClassPtr);
				RadioButton.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton.UxmlFactory>.NativeClassPtr, 100665151);
			}

			// Token: 0x06003930 RID: 14640 RVA: 0x000E89DC File Offset: 0x000E6BDC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303050, RefRangeEnd = 303051, XrefRangeStart = 303047, XrefRangeEnd = 303050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButton.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003931 RID: 14641 RVA: 0x00017FB0 File Offset: 0x000161B0
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400287F RID: 10367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003B5 RID: 949
		public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
			// Token: 0x06003932 RID: 14642 RVA: 0x000E8A18 File Offset: 0x000E6C18
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<RadioButton.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadioButton>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadioButton.UxmlTraits>.NativeClassPtr);
				RadioButton.UxmlTraits.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButton.UxmlTraits>.NativeClassPtr, "m_Text");
				RadioButton.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton.UxmlTraits>.NativeClassPtr, 100665152);
				RadioButton.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButton.UxmlTraits>.NativeClassPtr, 100665153);
			}

			// Token: 0x06003933 RID: 14643 RVA: 0x000E8A80 File Offset: 0x000E6C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303051, XrefRangeEnd = 303059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButton.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003934 RID: 14644 RVA: 0x000E8AF8 File Offset: 0x000E6CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303059, XrefRangeEnd = 303071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButton.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButton.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003935 RID: 14645 RVA: 0x00017FB9 File Offset: 0x000161B9
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001194 RID: 4500
			// (get) Token: 0x06003936 RID: 14646 RVA: 0x000E8B34 File Offset: 0x000E6D34
			// (set) Token: 0x06003937 RID: 14647 RVA: 0x00017FC2 File Offset: 0x000161C2
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButton.UxmlTraits.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButton.UxmlTraits.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002880 RID: 10368
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04002881 RID: 10369
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002882 RID: 10370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
