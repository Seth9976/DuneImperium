using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000079 RID: 121
	public class MultiColumnTreeView : BaseTreeView
	{
		// Token: 0x06000C2B RID: 3115 RVA: 0x00048254 File Offset: 0x00046454
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnTreeView()
		{
			Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MultiColumnTreeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr);
			MultiColumnTreeView.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "m_Columns");
			MultiColumnTreeView.NativeFieldInfoPtr_m_SortingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "m_SortingEnabled");
			MultiColumnTreeView.NativeFieldInfoPtr_m_SortColumnDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "m_SortColumnDescriptions");
			MultiColumnTreeView.NativeFieldInfoPtr_m_SortedColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "m_SortedColumns");
			MultiColumnTreeView.NativeFieldInfoPtr_columnSortingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "columnSortingChanged");
			MultiColumnTreeView.NativeFieldInfoPtr_headerContextMenuPopulateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "headerContextMenuPopulateEvent");
			MultiColumnTreeView.NativeMethodInfoPtr_get_viewController_Public_get_MultiColumnTreeViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665055);
			MultiColumnTreeView.NativeMethodInfoPtr_get_columns_Public_get_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665056);
			MultiColumnTreeView.NativeMethodInfoPtr_set_columns_Private_set_Void_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665057);
			MultiColumnTreeView.NativeMethodInfoPtr_get_sortColumnDescriptions_Public_get_SortColumnDescriptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665058);
			MultiColumnTreeView.NativeMethodInfoPtr_set_sortColumnDescriptions_Private_set_Void_SortColumnDescriptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665059);
			MultiColumnTreeView.NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665060);
			MultiColumnTreeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665061);
			MultiColumnTreeView.NativeMethodInfoPtr__ctor_Public_Void_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665062);
			MultiColumnTreeView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665063);
			MultiColumnTreeView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665064);
			MultiColumnTreeView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665065);
			MultiColumnTreeView.NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665066);
			MultiColumnTreeView.NativeMethodInfoPtr_RaiseHeaderContextMenuPopulate_Private_Void_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, 100665067);
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00048400 File Offset: 0x00046600
		public new unsafe MultiColumnTreeViewController viewController
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 302356, RefRangeEnd = 302371, XrefRangeStart = 302354, XrefRangeEnd = 302356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_get_viewController_Public_get_MultiColumnTreeViewController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiColumnTreeViewController>(intPtr3) : null;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00048440 File Offset: 0x00046640
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00048480 File Offset: 0x00046680
		public unsafe Columns columns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_get_columns_Public_get_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302371, XrefRangeEnd = 302376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_set_columns_Private_set_Void_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000484C4 File Offset: 0x000466C4
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00048504 File Offset: 0x00046704
		public unsafe SortColumnDescriptions sortColumnDescriptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_get_sortColumnDescriptions_Public_get_SortColumnDescriptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortColumnDescriptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302376, XrefRangeEnd = 302380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_set_sortColumnDescriptions_Private_set_Void_SortColumnDescriptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000068AF File Offset: 0x00004AAF
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00048548 File Offset: 0x00046748
		public unsafe bool sortingEnabled
		{
			get
			{
				return this.m_SortingEnabled;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302380, XrefRangeEnd = 302383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00048588 File Offset: 0x00046788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302383, XrefRangeEnd = 302388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnTreeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000485C4 File Offset: 0x000467C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302416, RefRangeEnd = 302417, XrefRangeStart = 302388, XrefRangeEnd = 302416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnTreeView(Columns columns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr__ctor_Public_Void_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00048610 File Offset: 0x00046810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302417, XrefRangeEnd = 302423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CollectionViewController CreateViewController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0004865C File Offset: 0x0004685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302423, XrefRangeEnd = 302457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetViewController(CollectionViewController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000486AC File Offset: 0x000468AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302457, XrefRangeEnd = 302460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateVirtualizationController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000486E8 File Offset: 0x000468E8
		[CallerCount(0)]
		public unsafe void RaiseColumnSortingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0004871C File Offset: 0x0004691C
		[CallerCount(0)]
		public unsafe void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.NativeMethodInfoPtr_RaiseHeaderContextMenuPopulate_Private_Void_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000067B4 File Offset: 0x000049B4
		public MultiColumnTreeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00048770 File Offset: 0x00046970
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x000067BD File Offset: 0x000049BD
		public unsafe Columns m_Columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_Columns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000487A0 File Offset: 0x000469A0
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x000067DC File Offset: 0x000049DC
		public unsafe bool m_SortingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_SortingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_SortingEnabled)) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000487C8 File Offset: 0x000469C8
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000067F7 File Offset: 0x000049F7
		public unsafe SortColumnDescriptions m_SortColumnDescriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_SortColumnDescriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortColumnDescriptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_SortColumnDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000487F8 File Offset: 0x000469F8
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00006816 File Offset: 0x00004A16
		public unsafe List<SortColumnDescription> m_SortedColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_SortedColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SortColumnDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_m_SortedColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00048828 File Offset: 0x00046A28
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00006835 File Offset: 0x00004A35
		public unsafe Action columnSortingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_columnSortingChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_columnSortingChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00048858 File Offset: 0x00046A58
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00006854 File Offset: 0x00004A54
		public unsafe Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_headerContextMenuPopulateEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ContextualMenuPopulateEvent, Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.NativeFieldInfoPtr_headerContextMenuPopulateEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00006873 File Offset: 0x00004A73
		public void add_columnSortingChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00006880 File Offset: 0x00004A80
		public void remove_columnSortingChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0000688D File Offset: 0x00004A8D
		public void add_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0000689A File Offset: 0x00004A9A
		public void remove_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000068A7 File Offset: 0x00004AA7
		public IEnumerable<SortColumnDescription> sortedColumns
		{
			get
			{
				return this.m_SortedColumns;
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000068B7 File Offset: 0x00004AB7
		public override void SetRootItemsInternal<T>(IList<TreeViewItemData<T>> rootItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000068C4 File Offset: 0x00004AC4
		public override IEnumerable<TreeViewItemData<T>> GetSelectedItemsInternal<T>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000068D1 File Offset: 0x00004AD1
		public override T GetItemDataForIndexInternal<T>(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000068DE File Offset: 0x00004ADE
		public override T GetItemDataForIdInternal<T>(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000068EB File Offset: 0x00004AEB
		public override void AddItemInternal<T>(TreeViewItemData<T> item, int parentId, int childIndex, bool rebuildTree)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000068F8 File Offset: 0x00004AF8
		public DefaultMultiColumnTreeViewController<T> <SetRootItemsInternal>b__27_0<T>()
		{
			return new DefaultMultiColumnTreeViewController<T>(this.columns, this.m_SortColumnDescriptions, this.m_SortedColumns);
		}

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingEnabled;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr_m_SortColumnDescriptions;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedColumns;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr_columnSortingChanged;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr_headerContextMenuPopulateEvent;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_viewController_Public_get_MultiColumnTreeViewController_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_columns_Public_get_Columns_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_set_columns_Private_set_Void_Columns_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_get_sortColumnDescriptions_Public_get_SortColumnDescriptions_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_set_sortColumnDescriptions_Private_set_Void_SortColumnDescriptions_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_RaiseHeaderContextMenuPopulate_Private_Void_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x020003A9 RID: 937
		public new class UxmlFactory : UxmlFactory<MultiColumnTreeView, MultiColumnTreeView.UxmlTraits>
		{
			// Token: 0x060038EF RID: 14575 RVA: 0x00017CD5 File Offset: 0x00015ED5
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<MultiColumnTreeView.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnTreeView.UxmlFactory>.NativeClassPtr);
				MultiColumnTreeView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView.UxmlFactory>.NativeClassPtr, 100665068);
			}

			// Token: 0x060038F0 RID: 14576 RVA: 0x000E7DA0 File Offset: 0x000E5FA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302312, RefRangeEnd = 302313, XrefRangeStart = 302309, XrefRangeEnd = 302312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnTreeView.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038F1 RID: 14577 RVA: 0x00017D09 File Offset: 0x00015F09
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002862 RID: 10338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003AA RID: 938
		public new class UxmlTraits : BaseTreeView.UxmlTraits
		{
			// Token: 0x060038F2 RID: 14578 RVA: 0x000E7DDC File Offset: 0x000E5FDC
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnTreeView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr);
				MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_SortingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr, "m_SortingEnabled");
				MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr, "m_Columns");
				MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_SortColumnDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr, "m_SortColumnDescriptions");
				MultiColumnTreeView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr, 100665069);
				MultiColumnTreeView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr, 100665070);
			}

			// Token: 0x060038F3 RID: 14579 RVA: 0x000E7E6C File Offset: 0x000E606C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302313, XrefRangeEnd = 302330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038F4 RID: 14580 RVA: 0x000E7EE4 File Offset: 0x000E60E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302330, XrefRangeEnd = 302354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnTreeView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038F5 RID: 14581 RVA: 0x00017D12 File Offset: 0x00015F12
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x060038F6 RID: 14582 RVA: 0x000E7F20 File Offset: 0x000E6120
			// (set) Token: 0x060038F7 RID: 14583 RVA: 0x00017D1B File Offset: 0x00015F1B
			public unsafe UxmlBoolAttributeDescription m_SortingEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_SortingEnabled);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_SortingEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x060038F8 RID: 14584 RVA: 0x000E7F50 File Offset: 0x000E6150
			// (set) Token: 0x060038F9 RID: 14585 RVA: 0x00017D3A File Offset: 0x00015F3A
			public unsafe UxmlObjectAttributeDescription<Columns> m_Columns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_Columns);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlObjectAttributeDescription<Columns>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x060038FA RID: 14586 RVA: 0x000E7F80 File Offset: 0x000E6180
			// (set) Token: 0x060038FB RID: 14587 RVA: 0x00017D59 File Offset: 0x00015F59
			public unsafe UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_SortColumnDescriptions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlObjectAttributeDescription<SortColumnDescriptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeView.UxmlTraits.NativeFieldInfoPtr_m_SortColumnDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002863 RID: 10339
			private static readonly IntPtr NativeFieldInfoPtr_m_SortingEnabled;

			// Token: 0x04002864 RID: 10340
			private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

			// Token: 0x04002865 RID: 10341
			private static readonly IntPtr NativeFieldInfoPtr_m_SortColumnDescriptions;

			// Token: 0x04002866 RID: 10342
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002867 RID: 10343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
