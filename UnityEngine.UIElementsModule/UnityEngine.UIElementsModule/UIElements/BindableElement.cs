using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000021 RID: 33
	public class BindableElement : VisualElement
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00023434 File Offset: 0x00021634
		// Note: this type is marked as 'beforefieldinit'.
		static BindableElement()
		{
			Il2CppClassPointerStore<BindableElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BindableElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableElement>.NativeClassPtr);
			BindableElement.NativeFieldInfoPtr__binding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, "<binding>k__BackingField");
			BindableElement.NativeFieldInfoPtr__bindingPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, "<bindingPath>k__BackingField");
			BindableElement.NativeMethodInfoPtr_get_binding_Public_Virtual_Final_New_get_IBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, 100663545);
			BindableElement.NativeMethodInfoPtr_set_bindingPath_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, 100663546);
			BindableElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, 100663547);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000234C8 File Offset: 0x000216C8
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002827 File Offset: 0x00000A27
		public unsafe virtual IBinding binding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindableElement.NativeMethodInfoPtr_get_binding_Public_Virtual_Final_New_get_IBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBinding>(intPtr3) : null;
			}
			set
			{
				this._binding_k__BackingField = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002830 File Offset: 0x00000A30
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00023508 File Offset: 0x00021708
		public unsafe virtual string bindingPath
		{
			get
			{
				return this._bindingPath_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283990, XrefRangeEnd = 283991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindableElement.NativeMethodInfoPtr_set_bindingPath_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0002354C File Offset: 0x0002174C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 283995, RefRangeEnd = 284008, XrefRangeStart = 283991, XrefRangeEnd = 283995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindableElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindableElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000027E0 File Offset: 0x000009E0
		public BindableElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00023588 File Offset: 0x00021788
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000027E9 File Offset: 0x000009E9
		public unsafe IBinding _binding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindableElement.NativeFieldInfoPtr__binding_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IBinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindableElement.NativeFieldInfoPtr__binding_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000235B8 File Offset: 0x000217B8
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002808 File Offset: 0x00000A08
		public unsafe string _bindingPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindableElement.NativeFieldInfoPtr__bindingPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindableElement.NativeFieldInfoPtr__bindingPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr__binding_k__BackingField;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr__bindingPath_k__BackingField;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_get_binding_Public_Virtual_Final_New_get_IBinding_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingPath_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000322 RID: 802
		public new class UxmlFactory : UxmlFactory<BindableElement, BindableElement.UxmlTraits>
		{
			// Token: 0x06003523 RID: 13603 RVA: 0x000158C7 File Offset: 0x00013AC7
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<BindableElement.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableElement.UxmlFactory>.NativeClassPtr);
				BindableElement.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableElement.UxmlFactory>.NativeClassPtr, 100663548);
			}

			// Token: 0x06003524 RID: 13604 RVA: 0x000DCC08 File Offset: 0x000DAE08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283952, RefRangeEnd = 283953, XrefRangeStart = 283949, XrefRangeEnd = 283952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableElement.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindableElement.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003525 RID: 13605 RVA: 0x000158FB File Offset: 0x00013AFB
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002632 RID: 9778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000323 RID: 803
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06003526 RID: 13606 RVA: 0x000DCC44 File Offset: 0x000DAE44
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BindableElement.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindableElement>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableElement.UxmlTraits>.NativeClassPtr);
				BindableElement.UxmlTraits.NativeFieldInfoPtr_m_PropertyPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableElement.UxmlTraits>.NativeClassPtr, "m_PropertyPath");
				BindableElement.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableElement.UxmlTraits>.NativeClassPtr, 100663549);
				BindableElement.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableElement.UxmlTraits>.NativeClassPtr, 100663550);
			}

			// Token: 0x06003527 RID: 13607 RVA: 0x000DCCAC File Offset: 0x000DAEAC
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 283963, RefRangeEnd = 283971, XrefRangeStart = 283953, XrefRangeEnd = 283963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableElement.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindableElement.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003528 RID: 13608 RVA: 0x000DCCE8 File Offset: 0x000DAEE8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 283980, RefRangeEnd = 283990, XrefRangeStart = 283971, XrefRangeEnd = 283980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BindableElement.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003529 RID: 13609 RVA: 0x00015904 File Offset: 0x00013B04
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700107D RID: 4221
			// (get) Token: 0x0600352A RID: 13610 RVA: 0x000DCD60 File Offset: 0x000DAF60
			// (set) Token: 0x0600352B RID: 13611 RVA: 0x0001590D File Offset: 0x00013B0D
			public unsafe UxmlStringAttributeDescription m_PropertyPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindableElement.UxmlTraits.NativeFieldInfoPtr_m_PropertyPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindableElement.UxmlTraits.NativeFieldInfoPtr_m_PropertyPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002633 RID: 9779
			private static readonly IntPtr NativeFieldInfoPtr_m_PropertyPath;

			// Token: 0x04002634 RID: 9780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002635 RID: 9781
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;
		}
	}
}
