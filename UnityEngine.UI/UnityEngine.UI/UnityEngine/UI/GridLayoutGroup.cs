using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001D RID: 29
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x0001675C File Offset: 0x0001495C
		// Note: this type is marked as 'beforefieldinit'.
		static GridLayoutGroup()
		{
			Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GridLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr);
			GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_StartCorner");
			GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_StartAxis");
			GridLayoutGroup.NativeFieldInfoPtr_m_CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_CellSize");
			GridLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_Spacing");
			GridLayoutGroup.NativeFieldInfoPtr_m_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_Constraint");
			GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, "m_ConstraintCount");
			GridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663940);
			GridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663941);
			GridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663942);
			GridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663943);
			GridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663944);
			GridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663945);
			GridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663946);
			GridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663947);
			GridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663948);
			GridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663949);
			GridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663950);
			GridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663951);
			GridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663952);
			GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663953);
			GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663954);
			GridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663955);
			GridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663956);
			GridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr, 100663957);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001696C File Offset: 0x00014B6C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x000169A8 File Offset: 0x00014BA8
		public unsafe GridLayoutGroup.Corner startCorner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088136, XrefRangeEnd = 1088139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000169E8 File Offset: 0x00014BE8
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00016A24 File Offset: 0x00014C24
		public unsafe GridLayoutGroup.Axis startAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088139, XrefRangeEnd = 1088142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00016A64 File Offset: 0x00014C64
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00016AA0 File Offset: 0x00014CA0
		public unsafe Vector2 cellSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1088145, RefRangeEnd = 1088146, XrefRangeStart = 1088142, XrefRangeEnd = 1088145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00016AE0 File Offset: 0x00014CE0
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00016B1C File Offset: 0x00014D1C
		public unsafe Vector2 spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1088149, RefRangeEnd = 1088150, XrefRangeStart = 1088146, XrefRangeEnd = 1088149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00016B5C File Offset: 0x00014D5C
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00016B98 File Offset: 0x00014D98
		public unsafe GridLayoutGroup.Constraint constraint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088150, XrefRangeEnd = 1088153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00016BD8 File Offset: 0x00014DD8
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00016C14 File Offset: 0x00014E14
		public unsafe int constraintCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088153, XrefRangeEnd = 1088156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00016C54 File Offset: 0x00014E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1088159, RefRangeEnd = 1088160, XrefRangeStart = 1088156, XrefRangeEnd = 1088159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00016C90 File Offset: 0x00014E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088160, XrefRangeEnd = 1088176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00016CCC File Offset: 0x00014ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088176, XrefRangeEnd = 1088191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00016D08 File Offset: 0x00014F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088191, XrefRangeEnd = 1088192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00016D44 File Offset: 0x00014F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088192, XrefRangeEnd = 1088193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00016D80 File Offset: 0x00014F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1088238, RefRangeEnd = 1088240, XrefRangeStart = 1088193, XrefRangeEnd = 1088238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCellsAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridLayoutGroup.NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00003625 File Offset: 0x00001825
		public GridLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00016DC0 File Offset: 0x00014FC0
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0000362E File Offset: 0x0000182E
		public unsafe GridLayoutGroup.Corner m_StartCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartCorner)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00016DE8 File Offset: 0x00014FE8
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00003649 File Offset: 0x00001849
		public unsafe GridLayoutGroup.Axis m_StartAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_StartAxis)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00016E10 File Offset: 0x00015010
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00003664 File Offset: 0x00001864
		public unsafe Vector2 m_CellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_CellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_CellSize)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00016E38 File Offset: 0x00015038
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000367F File Offset: 0x0000187F
		public unsafe Vector2 m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00016E60 File Offset: 0x00015060
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0000369A File Offset: 0x0000189A
		public unsafe GridLayoutGroup.Constraint m_Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Constraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_Constraint)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00016E88 File Offset: 0x00015088
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x000036B5 File Offset: 0x000018B5
		public unsafe int m_ConstraintCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridLayoutGroup.NativeFieldInfoPtr_m_ConstraintCount)) = value;
			}
		}

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_m_StartCorner;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAxis;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_m_CellSize;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_m_Constraint;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_m_ConstraintCount;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_get_startCorner_Public_get_Corner_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_set_startCorner_Public_set_Void_Corner_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_get_startAxis_Public_get_Axis_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_set_startAxis_Public_set_Void_Axis_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_get_cellSize_Public_get_Vector2_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_set_cellSize_Public_set_Void_Vector2_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Vector2_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Vector2_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_get_constraint_Public_get_Constraint_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_set_constraint_Public_set_Void_Constraint_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_get_constraintCount_Public_get_Int32_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_set_constraintCount_Public_set_Void_Int32_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_SetCellsAlongAxis_Private_Void_Int32_0;

		// Token: 0x020000A0 RID: 160
		public enum Corner
		{
			// Token: 0x0400099D RID: 2461
			UpperLeft,
			// Token: 0x0400099E RID: 2462
			UpperRight,
			// Token: 0x0400099F RID: 2463
			LowerLeft,
			// Token: 0x040009A0 RID: 2464
			LowerRight
		}

		// Token: 0x020000A1 RID: 161
		public enum Axis
		{
			// Token: 0x040009A2 RID: 2466
			Horizontal,
			// Token: 0x040009A3 RID: 2467
			Vertical
		}

		// Token: 0x020000A2 RID: 162
		public enum Constraint
		{
			// Token: 0x040009A5 RID: 2469
			Flexible,
			// Token: 0x040009A6 RID: 2470
			FixedColumnCount,
			// Token: 0x040009A7 RID: 2471
			FixedRowCount
		}
	}
}
