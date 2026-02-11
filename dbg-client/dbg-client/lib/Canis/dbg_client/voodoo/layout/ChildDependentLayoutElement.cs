using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace lib.canis.dbg_client.voodoo.layout
{
	// Token: 0x02000035 RID: 53
	public class ChildDependentLayoutElement : UIBehaviour
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00023AB0 File Offset: 0x00021CB0
		// Note: this type is marked as 'beforefieldinit'.
		static ChildDependentLayoutElement()
		{
			Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.voodoo.layout", "ChildDependentLayoutElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr);
			ChildDependentLayoutElement.NativeFieldInfoPtr_childContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "childContainer");
			ChildDependentLayoutElement.NativeFieldInfoPtr_withChildWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "withChildWidth");
			ChildDependentLayoutElement.NativeFieldInfoPtr_withChildHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "withChildHeight");
			ChildDependentLayoutElement.NativeFieldInfoPtr_withoutChildWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "withoutChildWidth");
			ChildDependentLayoutElement.NativeFieldInfoPtr_withoutChildHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "withoutChildHeight");
			ChildDependentLayoutElement.NativeFieldInfoPtr_cachedHasChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "cachedHasChild");
			ChildDependentLayoutElement.NativeFieldInfoPtr_m_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "m_preferredWidth");
			ChildDependentLayoutElement.NativeFieldInfoPtr_m_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "m_preferredHeight");
			ChildDependentLayoutElement.NativeFieldInfoPtr__minWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "<minWidth>k__BackingField");
			ChildDependentLayoutElement.NativeFieldInfoPtr__flexibleWidth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "<flexibleWidth>k__BackingField");
			ChildDependentLayoutElement.NativeFieldInfoPtr__minHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "<minHeight>k__BackingField");
			ChildDependentLayoutElement.NativeFieldInfoPtr__flexibleHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "<flexibleHeight>k__BackingField");
			ChildDependentLayoutElement.NativeFieldInfoPtr__layoutPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "<layoutPriority>k__BackingField");
			ChildDependentLayoutElement.NativeFieldInfoPtr__ignoreLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, "<ignoreLayout>k__BackingField");
			ChildDependentLayoutElement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663608);
			ChildDependentLayoutElement.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663609);
			ChildDependentLayoutElement.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663610);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663611);
			ChildDependentLayoutElement.NativeMethodInfoPtr_set_preferredWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663612);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663613);
			ChildDependentLayoutElement.NativeMethodInfoPtr_set_preferredHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663614);
			ChildDependentLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663615);
			ChildDependentLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663616);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663617);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663618);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663619);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663620);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663621);
			ChildDependentLayoutElement.NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663622);
			ChildDependentLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr, 100663623);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00023D38 File Offset: 0x00021F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497985, XrefRangeEnd = 497987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChildDependentLayoutElement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00023D74 File Offset: 0x00021F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 497987, XrefRangeEnd = 497995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 498012, RefRangeEnd = 498018, XrefRangeStart = 497995, XrefRangeEnd = 498012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00023DDC File Offset: 0x00021FDC
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00023E18 File Offset: 0x00022018
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498018, XrefRangeEnd = 498020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_set_preferredWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00023E58 File Offset: 0x00022058
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00023E94 File Offset: 0x00022094
		public unsafe virtual float preferredHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498020, XrefRangeEnd = 498022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_set_preferredHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00023ED4 File Offset: 0x000220D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChildDependentLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00023F10 File Offset: 0x00022110
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChildDependentLayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00023F4C File Offset: 0x0002214C
		public unsafe virtual float minWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00023F88 File Offset: 0x00022188
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00023FC4 File Offset: 0x000221C4
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00024000 File Offset: 0x00022200
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0002403C File Offset: 0x0002223C
		public unsafe virtual int layoutPriority
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00024078 File Offset: 0x00022278
		public unsafe virtual bool ignoreLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000240B4 File Offset: 0x000222B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498022, XrefRangeEnd = 498023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChildDependentLayoutElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildDependentLayoutElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildDependentLayoutElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002D21 File Offset: 0x00000F21
		public ChildDependentLayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000240F0 File Offset: 0x000222F0
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe GameObject childContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_childContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_childContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00024120 File Offset: 0x00022320
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002D49 File Offset: 0x00000F49
		public unsafe float withChildWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withChildWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withChildWidth)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00024148 File Offset: 0x00022348
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002D64 File Offset: 0x00000F64
		public unsafe float withChildHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withChildHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withChildHeight)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00024170 File Offset: 0x00022370
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002D7F File Offset: 0x00000F7F
		public unsafe float withoutChildWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withoutChildWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withoutChildWidth)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00024198 File Offset: 0x00022398
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002D9A File Offset: 0x00000F9A
		public unsafe float withoutChildHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withoutChildHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_withoutChildHeight)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000241C0 File Offset: 0x000223C0
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public unsafe bool cachedHasChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_cachedHasChild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_cachedHasChild)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000241E8 File Offset: 0x000223E8
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public unsafe float m_preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_m_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_m_preferredWidth)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00024210 File Offset: 0x00022410
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002DEB File Offset: 0x00000FEB
		public unsafe float m_preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_m_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr_m_preferredHeight)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00024238 File Offset: 0x00022438
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002E06 File Offset: 0x00001006
		public unsafe float _minWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__minWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__minWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00024260 File Offset: 0x00022460
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002E21 File Offset: 0x00001021
		public unsafe float _flexibleWidth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__flexibleWidth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__flexibleWidth_k__BackingField)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00024288 File Offset: 0x00022488
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002E3C File Offset: 0x0000103C
		public unsafe float _minHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__minHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__minHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000242B0 File Offset: 0x000224B0
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002E57 File Offset: 0x00001057
		public unsafe float _flexibleHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__flexibleHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__flexibleHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000242D8 File Offset: 0x000224D8
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002E72 File Offset: 0x00001072
		public unsafe int _layoutPriority_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__layoutPriority_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__layoutPriority_k__BackingField)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00024300 File Offset: 0x00022500
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002E8D File Offset: 0x0000108D
		public unsafe bool _ignoreLayout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__ignoreLayout_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildDependentLayoutElement.NativeFieldInfoPtr__ignoreLayout_k__BackingField)) = value;
			}
		}

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_childContainer;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_withChildWidth;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_withChildHeight;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeFieldInfoPtr_withoutChildWidth;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeFieldInfoPtr_withoutChildHeight;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_cachedHasChild;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredWidth;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredHeight;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr__minWidth_k__BackingField;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr__flexibleWidth_k__BackingField;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr__minHeight_k__BackingField;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr__flexibleHeight_k__BackingField;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr__layoutPriority_k__BackingField;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr__ignoreLayout_k__BackingField;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_set_preferredWidth_Public_set_Void_Single_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_set_preferredHeight_Public_set_Void_Single_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreLayout_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
