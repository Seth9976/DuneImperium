using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008E RID: 142
	public class Toggle : BaseBoolField
	{
		// Token: 0x06000E57 RID: 3671 RVA: 0x0004F98C File Offset: 0x0004DB8C
		// Note: this type is marked as 'beforefieldinit'.
		static Toggle()
		{
			Il2CppClassPointerStore<Toggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Toggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle>.NativeClassPtr);
			Toggle.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "ussClassName");
			Toggle.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "labelUssClassName");
			Toggle.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "inputUssClassName");
			Toggle.NativeFieldInfoPtr_noTextVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "noTextVariantUssClassName");
			Toggle.NativeFieldInfoPtr_checkmarkUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "checkmarkUssClassName");
			Toggle.NativeFieldInfoPtr_textUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "textUssClassName");
			Toggle.NativeFieldInfoPtr_mixedValuesUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "mixedValuesUssClassName");
			Toggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100665349);
			Toggle.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100665350);
			Toggle.NativeMethodInfoPtr_InitLabel_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100665351);
			Toggle.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100665352);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0004FA98 File Offset: 0x0004DC98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306035, RefRangeEnd = 306037, XrefRangeStart = 306018, XrefRangeEnd = 306035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0004FAD4 File Offset: 0x0004DCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306037, XrefRangeEnd = 306054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0004FB20 File Offset: 0x0004DD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306054, XrefRangeEnd = 306061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_InitLabel_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0004FB5C File Offset: 0x0004DD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306061, XrefRangeEnd = 306079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000075C5 File Offset: 0x000057C5
		public Toggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0004FB98 File Offset: 0x0004DD98
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x000075CE File Offset: 0x000057CE
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0004FBB8 File Offset: 0x0004DDB8
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x000075E0 File Offset: 0x000057E0
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x000075F2 File Offset: 0x000057F2
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0004FBF8 File Offset: 0x0004DDF8
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00007604 File Offset: 0x00005804
		public unsafe static string noTextVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_noTextVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_noTextVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0004FC18 File Offset: 0x0004DE18
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00007616 File Offset: 0x00005816
		public unsafe static string checkmarkUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_checkmarkUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_checkmarkUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0004FC38 File Offset: 0x0004DE38
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00007628 File Offset: 0x00005828
		public unsafe static string textUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_textUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_textUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0004FC58 File Offset: 0x0004DE58
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0000763A File Offset: 0x0000583A
		public unsafe static string mixedValuesUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Toggle.NativeFieldInfoPtr_mixedValuesUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Toggle.NativeFieldInfoPtr_mixedValuesUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr_noTextVariantUssClassName;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeFieldInfoPtr_checkmarkUssClassName;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeFieldInfoPtr_textUssClassName;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_mixedValuesUssClassName;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_InitLabel_Protected_Virtual_Void_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x020003C9 RID: 969
		public new class UxmlFactory : UxmlFactory<Toggle, Toggle.UxmlTraits>
		{
			// Token: 0x060039B6 RID: 14774 RVA: 0x00018596 File Offset: 0x00016796
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Toggle.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle.UxmlFactory>.NativeClassPtr);
				Toggle.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle.UxmlFactory>.NativeClassPtr, 100665354);
			}

			// Token: 0x060039B7 RID: 14775 RVA: 0x000EA204 File Offset: 0x000E8404
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 305993, RefRangeEnd = 305994, XrefRangeStart = 305990, XrefRangeEnd = 305993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B8 RID: 14776 RVA: 0x000185CA File Offset: 0x000167CA
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028D0 RID: 10448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003CA RID: 970
		public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
			// Token: 0x060039B9 RID: 14777 RVA: 0x000EA240 File Offset: 0x000E8440
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Toggle.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle.UxmlTraits>.NativeClassPtr);
				Toggle.UxmlTraits.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle.UxmlTraits>.NativeClassPtr, "m_Text");
				Toggle.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle.UxmlTraits>.NativeClassPtr, 100665355);
				Toggle.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle.UxmlTraits>.NativeClassPtr, 100665356);
			}

			// Token: 0x060039BA RID: 14778 RVA: 0x000EA2A8 File Offset: 0x000E84A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305994, XrefRangeEnd = 306002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039BB RID: 14779 RVA: 0x000EA320 File Offset: 0x000E8520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306002, XrefRangeEnd = 306018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039BC RID: 14780 RVA: 0x000185D3 File Offset: 0x000167D3
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011B9 RID: 4537
			// (get) Token: 0x060039BD RID: 14781 RVA: 0x000EA35C File Offset: 0x000E855C
			// (set) Token: 0x060039BE RID: 14782 RVA: 0x000185DC File Offset: 0x000167DC
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.UxmlTraits.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.UxmlTraits.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040028D1 RID: 10449
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040028D2 RID: 10450
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040028D3 RID: 10451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
