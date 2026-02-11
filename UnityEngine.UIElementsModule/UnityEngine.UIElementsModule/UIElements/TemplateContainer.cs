using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D5 RID: 469
	public class TemplateContainer : BindableElement
	{
		// Token: 0x0600246A RID: 9322 RVA: 0x000A34CC File Offset: 0x000A16CC
		// Note: this type is marked as 'beforefieldinit'.
		static TemplateContainer()
		{
			Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TemplateContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr);
			TemplateContainer.NativeFieldInfoPtr__templateId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, "<templateId>k__BackingField");
			TemplateContainer.NativeFieldInfoPtr_m_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, "m_ContentContainer");
			TemplateContainer.NativeFieldInfoPtr_m_TemplateSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, "m_TemplateSource");
			TemplateContainer.NativeMethodInfoPtr_get_templateId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668811);
			TemplateContainer.NativeMethodInfoPtr_set_templateId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668812);
			TemplateContainer.NativeMethodInfoPtr_set_templateSource_Internal_set_Void_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668813);
			TemplateContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668814);
			TemplateContainer.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668815);
			TemplateContainer.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668816);
			TemplateContainer.NativeMethodInfoPtr_SetContentContainer_Internal_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, 100668817);
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000A35C4 File Offset: 0x000A17C4
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x000A35FC File Offset: 0x000A17FC
		public unsafe string templateId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.NativeMethodInfoPtr_get_templateId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.NativeMethodInfoPtr_set_templateId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x0000F039 File Offset: 0x0000D239
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x000A3640 File Offset: 0x000A1840
		public unsafe VisualTreeAsset templateSource
		{
			get
			{
				return this.m_TemplateSource;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338423, XrefRangeEnd = 338424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.NativeMethodInfoPtr_set_templateSource_Internal_set_Void_VisualTreeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000A3684 File Offset: 0x000A1884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338427, RefRangeEnd = 338428, XrefRangeStart = 338424, XrefRangeEnd = 338427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000A36C0 File Offset: 0x000A18C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338431, RefRangeEnd = 338432, XrefRangeStart = 338428, XrefRangeEnd = 338431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TemplateContainer(string templateId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(templateId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x000A370C File Offset: 0x000A190C
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateContainer.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000A3758 File Offset: 0x000A1958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303518, RefRangeEnd = 303519, XrefRangeStart = 303518, XrefRangeEnd = 303519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContentContainer(VisualElement content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.NativeMethodInfoPtr_SetContentContainer_Internal_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0000EFD3 File Offset: 0x0000D1D3
		public TemplateContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000A379C File Offset: 0x000A199C
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		public unsafe string _templateId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.NativeFieldInfoPtr__templateId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.NativeFieldInfoPtr__templateId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000A37C4 File Offset: 0x000A19C4
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x0000EFFB File Offset: 0x0000D1FB
		public unsafe VisualElement m_ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.NativeFieldInfoPtr_m_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.NativeFieldInfoPtr_m_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000A37F4 File Offset: 0x000A19F4
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0000F01A File Offset: 0x0000D21A
		public unsafe VisualTreeAsset m_TemplateSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.NativeFieldInfoPtr_m_TemplateSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.NativeFieldInfoPtr_m_TemplateSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeFieldInfoPtr__templateId_k__BackingField;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentContainer;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeFieldInfoPtr_m_TemplateSource;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_get_templateId_Public_get_String_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_set_templateId_Private_set_Void_String_0;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_set_templateSource_Internal_set_Void_VisualTreeAsset_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_SetContentContainer_Internal_Void_VisualElement_0;

		// Token: 0x020004E6 RID: 1254
		public new class UxmlFactory : UxmlFactory<TemplateContainer, TemplateContainer.UxmlTraits>
		{
			// Token: 0x06003F25 RID: 16165 RVA: 0x000FBC50 File Offset: 0x000F9E50
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<TemplateContainer.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateContainer.UxmlFactory>.NativeClassPtr);
				TemplateContainer.UxmlFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer.UxmlFactory>.NativeClassPtr, 100668818);
				TemplateContainer.UxmlFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer.UxmlFactory>.NativeClassPtr, 100668819);
				TemplateContainer.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer.UxmlFactory>.NativeClassPtr, 100668820);
			}

			// Token: 0x170012F8 RID: 4856
			// (get) Token: 0x06003F26 RID: 16166 RVA: 0x000FBCB8 File Offset: 0x000F9EB8
			public unsafe override string uxmlName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338346, XrefRangeEnd = 338348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateContainer.UxmlFactory.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170012F9 RID: 4857
			// (get) Token: 0x06003F27 RID: 16167 RVA: 0x000FBCFC File Offset: 0x000F9EFC
			public unsafe override string uxmlQualifiedName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338348, XrefRangeEnd = 338351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateContainer.UxmlFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003F28 RID: 16168 RVA: 0x000FBD40 File Offset: 0x000F9F40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338354, RefRangeEnd = 338355, XrefRangeStart = 338351, XrefRangeEnd = 338354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateContainer.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F29 RID: 16169 RVA: 0x0001A7B8 File Offset: 0x000189B8
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002CA7 RID: 11431
			private static readonly IntPtr NativeMethodInfoPtr_get_uxmlName_Public_Virtual_get_String_0;

			// Token: 0x04002CA8 RID: 11432
			private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_get_String_0;

			// Token: 0x04002CA9 RID: 11433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004E7 RID: 1255
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x06003F2A RID: 16170 RVA: 0x000FBD7C File Offset: 0x000F9F7C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<TemplateContainer.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemplateContainer>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemplateContainer.UxmlTraits>.NativeClassPtr);
				TemplateContainer.UxmlTraits.NativeFieldInfoPtr_m_Template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemplateContainer.UxmlTraits>.NativeClassPtr, "m_Template");
				TemplateContainer.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer.UxmlTraits>.NativeClassPtr, 100668821);
				TemplateContainer.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemplateContainer.UxmlTraits>.NativeClassPtr, 100668822);
			}

			// Token: 0x06003F2B RID: 16171 RVA: 0x000FBDE4 File Offset: 0x000F9FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338355, XrefRangeEnd = 338413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TemplateContainer.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F2C RID: 16172 RVA: 0x000FBE5C File Offset: 0x000FA05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338413, XrefRangeEnd = 338423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemplateContainer.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemplateContainer.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F2D RID: 16173 RVA: 0x0001A7C1 File Offset: 0x000189C1
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012FA RID: 4858
			// (get) Token: 0x06003F2E RID: 16174 RVA: 0x000FBE98 File Offset: 0x000FA098
			// (set) Token: 0x06003F2F RID: 16175 RVA: 0x0001A7CA File Offset: 0x000189CA
			public unsafe UxmlStringAttributeDescription m_Template
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.UxmlTraits.NativeFieldInfoPtr_m_Template);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TemplateContainer.UxmlTraits.NativeFieldInfoPtr_m_Template), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CAA RID: 11434
			private static readonly IntPtr NativeFieldInfoPtr_m_Template;

			// Token: 0x04002CAB RID: 11435
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002CAC RID: 11436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200059B RID: 1435
			public sealed class <get_uxmlChildElementsDescription>d__3
			{
			}
		}
	}
}
