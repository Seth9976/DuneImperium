using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004E RID: 78
	public class ButtonStripField : BaseField<int>
	{
		// Token: 0x0600078A RID: 1930 RVA: 0x00038388 File Offset: 0x00036588
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonStripField()
		{
			Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ButtonStripField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr);
			ButtonStripField.NativeFieldInfoPtr_m_Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr, "m_Buttons");
			ButtonStripField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr, 100664324);
			ButtonStripField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr, 100664325);
			ButtonStripField.NativeMethodInfoPtr_RefreshButtonsState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr, 100664326);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00038408 File Offset: 0x00036608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292217, XrefRangeEnd = 292230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonStripField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStripField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00038444 File Offset: 0x00036644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292230, XrefRangeEnd = 292246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonStripField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00038490 File Offset: 0x00036690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292246, XrefRangeEnd = 292257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshButtonsState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStripField.NativeMethodInfoPtr_RefreshButtonsState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000049AE File Offset: 0x00002BAE
		public ButtonStripField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000384C4 File Offset: 0x000366C4
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000049B7 File Offset: 0x00002BB7
		public unsafe List<Button> m_Buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStripField.NativeFieldInfoPtr_m_Buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonStripField.NativeFieldInfoPtr_m_Buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000384F4 File Offset: 0x000366F4
		public void AddButton(string text, [Optional] string name)
		{
			Button button = this.CreateButton(name);
			button.text = text;
			base.Add(button);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0003851C File Offset: 0x0003671C
		public void AddButton(Background icon, [Optional] string name)
		{
			Button button = this.CreateButton(name);
			VisualElement visualElement = new VisualElement();
			visualElement.AddToClassList("unity-button-strip-field__button-icon");
			visualElement.style.backgroundImage = icon;
			button.Add(visualElement);
			base.Add(button);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000049D6 File Offset: 0x00002BD6
		public Button CreateButton(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00038568 File Offset: 0x00036768
		public void OnButtonDetachFromPanel(DetachFromPanelEvent evt)
		{
			VisualElement visualElement = evt.currentTarget.TryCast<VisualElement>();
			ButtonStripField buttonStripField;
			bool flag;
			if (visualElement != null)
			{
				buttonStripField = visualElement.parent.TryCast<ButtonStripField>();
				flag = buttonStripField != null;
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2)
			{
				buttonStripField.RefreshButtonsStyling();
				buttonStripField.EnsureValueIsValid();
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000385AC File Offset: 0x000367AC
		public void RefreshButtonsStyling()
		{
			for (int i = 0; i < this.m_Buttons.Count; i++)
			{
				Button button = this.m_Buttons[i];
				bool flag = this.m_Buttons.Count == 1;
				bool flag2 = i == 0;
				bool flag3 = i == this.m_Buttons.Count - 1;
				button.EnableInClassList("unity-button-strip-field__button--alone", flag);
				button.EnableInClassList("unity-button-strip-field__button--left", !flag && flag2);
				button.EnableInClassList("unity-button-strip-field__button--right", !flag && flag3);
				button.EnableInClassList("unity-button-strip-field__button--middle", !flag && !flag2 && !flag3);
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000049E3 File Offset: 0x00002BE3
		public void EnsureValueIsValid()
		{
			this.SetValueWithoutNotify(Mathf.Clamp(this.value, 0, this.m_Buttons.Count - 1));
		}

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_m_Buttons;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Int32_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_RefreshButtonsState_Private_Void_0;

		// Token: 0x04000566 RID: 1382
		public const string className = "unity-button-strip-field";

		// Token: 0x04000567 RID: 1383
		public const string k_ButtonClass = "unity-button-strip-field__button";

		// Token: 0x04000568 RID: 1384
		public const string k_IconClass = "unity-button-strip-field__button-icon";

		// Token: 0x04000569 RID: 1385
		public const string k_ButtonLeftClass = "unity-button-strip-field__button--left";

		// Token: 0x0400056A RID: 1386
		public const string k_ButtonMiddleClass = "unity-button-strip-field__button--middle";

		// Token: 0x0400056B RID: 1387
		public const string k_ButtonRightClass = "unity-button-strip-field__button--right";

		// Token: 0x0400056C RID: 1388
		public const string k_ButtonAloneClass = "unity-button-strip-field__button--alone";

		// Token: 0x02000348 RID: 840
		public new class UxmlFactory : UxmlFactory<ButtonStripField, ButtonStripField.UxmlTraits>
		{
			// Token: 0x0600365B RID: 13915 RVA: 0x000164B8 File Offset: 0x000146B8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<ButtonStripField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonStripField.UxmlFactory>.NativeClassPtr);
				ButtonStripField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStripField.UxmlFactory>.NativeClassPtr, 100664327);
			}

			// Token: 0x0600365C RID: 13916 RVA: 0x000E05B0 File Offset: 0x000DE7B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292213, RefRangeEnd = 292214, XrefRangeStart = 292210, XrefRangeEnd = 292213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonStripField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStripField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600365D RID: 13917 RVA: 0x000164EC File Offset: 0x000146EC
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026F1 RID: 9969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000349 RID: 841
		public new class UxmlTraits : BaseField<int>.UxmlTraits
		{
			// Token: 0x0600365E RID: 13918 RVA: 0x000164F5 File Offset: 0x000146F5
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<ButtonStripField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonStripField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonStripField.UxmlTraits>.NativeClassPtr);
				ButtonStripField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonStripField.UxmlTraits>.NativeClassPtr, 100664328);
			}

			// Token: 0x0600365F RID: 13919 RVA: 0x000E05EC File Offset: 0x000DE7EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292214, XrefRangeEnd = 292217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonStripField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonStripField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003660 RID: 13920 RVA: 0x00016529 File Offset: 0x00014729
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026F2 RID: 9970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200034A RID: 842
		public sealed class <>c__DisplayClass12_0
		{
		}
	}
}
