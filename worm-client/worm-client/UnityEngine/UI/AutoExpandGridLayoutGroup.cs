using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000035 RID: 53
	public class AutoExpandGridLayoutGroup : LayoutGroup
	{
		// Token: 0x0600023C RID: 572 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		// Note: this type is marked as 'beforefieldinit'.
		static AutoExpandGridLayoutGroup()
		{
			Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "UnityEngine.UI", "AutoExpandGridLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr);
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_expandSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "expandSetting");
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_StartCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "m_StartCorner");
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_StartAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "m_StartAxis");
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "m_CellSize");
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "m_Spacing");
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "m_Constraint");
			AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, "m_ConstraintCount");
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663686);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663687);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663688);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663689);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663690);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663691);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663692);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663693);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663694);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663695);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663696);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663697);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663698);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663699);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663700);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663701);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663702);
			AutoExpandGridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr, 100663703);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00020018 File Offset: 0x0001E218
		public unsafe AutoExpandGridLayoutGroup.Corner startCorner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690131, XrefRangeEnd = 690134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00020058 File Offset: 0x0001E258
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00020094 File Offset: 0x0001E294
		public unsafe AutoExpandGridLayoutGroup.Axis startAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690134, XrefRangeEnd = 690137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000200D4 File Offset: 0x0001E2D4
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00020110 File Offset: 0x0001E310
		public unsafe Vector2 cellSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690137, XrefRangeEnd = 690140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00020150 File Offset: 0x0001E350
		// (set) Token: 0x06000244 RID: 580 RVA: 0x0002018C File Offset: 0x0001E38C
		public unsafe Vector2 spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690140, XrefRangeEnd = 690143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000201CC File Offset: 0x0001E3CC
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00020208 File Offset: 0x0001E408
		public unsafe AutoExpandGridLayoutGroup.Constraint constraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690143, XrefRangeEnd = 690146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00020248 File Offset: 0x0001E448
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00020284 File Offset: 0x0001E484
		public unsafe int constraintCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690146, XrefRangeEnd = 690149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000202C4 File Offset: 0x0001E4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690149, XrefRangeEnd = 690152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoExpandGridLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoExpandGridLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00020300 File Offset: 0x0001E500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690152, XrefRangeEnd = 690169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoExpandGridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0002033C File Offset: 0x0001E53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690169, XrefRangeEnd = 690185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoExpandGridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00020378 File Offset: 0x0001E578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690185, XrefRangeEnd = 690186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoExpandGridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000203B4 File Offset: 0x0001E5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690186, XrefRangeEnd = 690187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoExpandGridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000203F0 File Offset: 0x0001E5F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 690258, RefRangeEnd = 690260, XrefRangeStart = 690187, XrefRangeEnd = 690258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCellsAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoExpandGridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000030B2 File Offset: 0x000012B2
		public AutoExpandGridLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00020430 File Offset: 0x0001E630
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000030BB File Offset: 0x000012BB
		public unsafe AutoExpandGridLayoutGroup.ExpandSetting expandSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_expandSetting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_expandSetting)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00020458 File Offset: 0x0001E658
		// (set) Token: 0x06000253 RID: 595 RVA: 0x000030D6 File Offset: 0x000012D6
		public unsafe AutoExpandGridLayoutGroup.Corner m_StartCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_StartCorner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_StartCorner)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00020480 File Offset: 0x0001E680
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000030F1 File Offset: 0x000012F1
		public unsafe AutoExpandGridLayoutGroup.Axis m_StartAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_StartAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_StartAxis)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000204A8 File Offset: 0x0001E6A8
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0000310C File Offset: 0x0000130C
		public unsafe Vector2 m_CellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_CellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_CellSize)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000204D0 File Offset: 0x0001E6D0
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00003127 File Offset: 0x00001327
		public unsafe Vector2 m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000204F8 File Offset: 0x0001E6F8
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00003142 File Offset: 0x00001342
		public unsafe AutoExpandGridLayoutGroup.Constraint m_Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_Constraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_Constraint)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00020520 File Offset: 0x0001E720
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000315D File Offset: 0x0000135D
		public unsafe int m_ConstraintCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoExpandGridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount)) = value;
			}
		}

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_expandSetting;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_StartCorner;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAxis;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_CellSize;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_Constraint;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_ConstraintCount;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0;

		// Token: 0x020002D2 RID: 722
		public enum Corner
		{
			// Token: 0x04001118 RID: 4376
			UpperLeft,
			// Token: 0x04001119 RID: 4377
			UpperRight,
			// Token: 0x0400111A RID: 4378
			LowerLeft,
			// Token: 0x0400111B RID: 4379
			LowerRight
		}

		// Token: 0x020002D3 RID: 723
		public enum Axis
		{
			// Token: 0x0400111D RID: 4381
			Horizontal,
			// Token: 0x0400111E RID: 4382
			Vertical
		}

		// Token: 0x020002D4 RID: 724
		public enum Constraint
		{
			// Token: 0x04001120 RID: 4384
			Flexible,
			// Token: 0x04001121 RID: 4385
			FixedColumnCount,
			// Token: 0x04001122 RID: 4386
			FixedRowCount
		}

		// Token: 0x020002D5 RID: 725
		public enum ExpandSetting
		{
			// Token: 0x04001124 RID: 4388
			x,
			// Token: 0x04001125 RID: 4389
			y,
			// Token: 0x04001126 RID: 4390
			both,
			// Token: 0x04001127 RID: 4391
			none
		}
	}
}
