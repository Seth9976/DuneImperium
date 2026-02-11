using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000078 RID: 120
	public class MultiColumnListView : BaseListView
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x00047C20 File Offset: 0x00045E20
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnListView()
		{
			Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MultiColumnListView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr);
			MultiColumnListView.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "m_Columns");
			MultiColumnListView.NativeFieldInfoPtr_m_SortingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "m_SortingEnabled");
			MultiColumnListView.NativeFieldInfoPtr_m_SortColumnDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "m_SortColumnDescriptions");
			MultiColumnListView.NativeFieldInfoPtr_m_SortedColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "m_SortedColumns");
			MultiColumnListView.NativeFieldInfoPtr_columnSortingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "columnSortingChanged");
			MultiColumnListView.NativeFieldInfoPtr_headerContextMenuPopulateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "headerContextMenuPopulateEvent");
			MultiColumnListView.NativeMethodInfoPtr_get_viewController_Public_get_MultiColumnListViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665039);
			MultiColumnListView.NativeMethodInfoPtr_get_columns_Public_get_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665040);
			MultiColumnListView.NativeMethodInfoPtr_set_columns_Private_set_Void_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665041);
			MultiColumnListView.NativeMethodInfoPtr_get_sortColumnDescriptions_Public_get_SortColumnDescriptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665042);
			MultiColumnListView.NativeMethodInfoPtr_set_sortColumnDescriptions_Private_set_Void_SortColumnDescriptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665043);
			MultiColumnListView.NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665044);
			MultiColumnListView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665045);
			MultiColumnListView.NativeMethodInfoPtr__ctor_Public_Void_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665046);
			MultiColumnListView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665047);
			MultiColumnListView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665048);
			MultiColumnListView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665049);
			MultiColumnListView.NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665050);
			MultiColumnListView.NativeMethodInfoPtr_RaiseHeaderContextMenuPopulate_Private_Void_ContextualMenuPopulateEvent_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, 100665051);
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00047DCC File Offset: 0x00045FCC
		public new unsafe MultiColumnListViewController viewController
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 302207, RefRangeEnd = 302222, XrefRangeStart = 302205, XrefRangeEnd = 302207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_get_viewController_Public_get_MultiColumnListViewController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiColumnListViewController>(intPtr3) : null;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00047E0C File Offset: 0x0004600C
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00047E4C File Offset: 0x0004604C
		public unsafe Columns columns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_get_columns_Public_get_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302222, XrefRangeEnd = 302227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_set_columns_Private_set_Void_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00047E90 File Offset: 0x00046090
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00047ED0 File Offset: 0x000460D0
		public unsafe SortColumnDescriptions sortColumnDescriptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_get_sortColumnDescriptions_Public_get_SortColumnDescriptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortColumnDescriptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302227, XrefRangeEnd = 302231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_set_sortColumnDescriptions_Private_set_Void_SortColumnDescriptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000067AC File Offset: 0x000049AC
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00047F14 File Offset: 0x00046114
		public unsafe bool sortingEnabled
		{
			get
			{
				return this.m_SortingEnabled;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302231, XrefRangeEnd = 302234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00047F54 File Offset: 0x00046154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302234, XrefRangeEnd = 302239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnListView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00047F90 File Offset: 0x00046190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302267, RefRangeEnd = 302268, XrefRangeStart = 302239, XrefRangeEnd = 302267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnListView(Columns columns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr__ctor_Public_Void_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00047FDC File Offset: 0x000461DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302268, XrefRangeEnd = 302272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CollectionViewController CreateViewController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListView.NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollectionViewController>(intPtr3) : null;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00048028 File Offset: 0x00046228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302272, XrefRangeEnd = 302306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetViewController(CollectionViewController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListView.NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00048078 File Offset: 0x00046278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302306, XrefRangeEnd = 302309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateVirtualizationController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListView.NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000480B4 File Offset: 0x000462B4
		[CallerCount(0)]
		public unsafe void RaiseColumnSortingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000480E8 File Offset: 0x000462E8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.NativeMethodInfoPtr_RaiseHeaderContextMenuPopulate_Private_Void_ContextualMenuPopulateEvent_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000066B1 File Offset: 0x000048B1
		public MultiColumnListView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0004813C File Offset: 0x0004633C
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000066BA File Offset: 0x000048BA
		public unsafe Columns m_Columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_Columns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0004816C File Offset: 0x0004636C
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x000066D9 File Offset: 0x000048D9
		public unsafe bool m_SortingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_SortingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_SortingEnabled)) = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00048194 File Offset: 0x00046394
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000066F4 File Offset: 0x000048F4
		public unsafe SortColumnDescriptions m_SortColumnDescriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_SortColumnDescriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortColumnDescriptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_SortColumnDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000481C4 File Offset: 0x000463C4
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00006713 File Offset: 0x00004913
		public unsafe List<SortColumnDescription> m_SortedColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_SortedColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SortColumnDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_m_SortedColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000481F4 File Offset: 0x000463F4
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00006732 File Offset: 0x00004932
		public unsafe Action columnSortingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_columnSortingChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_columnSortingChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00048224 File Offset: 0x00046424
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00006751 File Offset: 0x00004951
		public unsafe Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_headerContextMenuPopulateEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ContextualMenuPopulateEvent, Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.NativeFieldInfoPtr_headerContextMenuPopulateEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00006770 File Offset: 0x00004970
		public void add_columnSortingChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0000677D File Offset: 0x0000497D
		public void remove_columnSortingChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0000678A File Offset: 0x0000498A
		public void add_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00006797 File Offset: 0x00004997
		public void remove_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000067A4 File Offset: 0x000049A4
		public IEnumerable<SortColumnDescription> sortedColumns
		{
			get
			{
				return this.m_SortedColumns;
			}
		}

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingEnabled;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_m_SortColumnDescriptions;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedColumns;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_columnSortingChanged;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_headerContextMenuPopulateEvent;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_get_viewController_Public_get_MultiColumnListViewController_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_columns_Public_get_Columns_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_set_columns_Private_set_Void_Columns_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_sortColumnDescriptions_Public_get_SortColumnDescriptions_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_set_sortColumnDescriptions_Private_set_Void_SortColumnDescriptions_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_CreateViewController_Protected_Virtual_CollectionViewController_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_SetViewController_Public_Virtual_Void_CollectionViewController_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_CreateVirtualizationController_FamAndAssem_Virtual_Void_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_RaiseColumnSortingChanged_Private_Void_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_RaiseHeaderContextMenuPopulate_Private_Void_ContextualMenuPopulateEvent_Column_0;

		// Token: 0x020003A7 RID: 935
		public new class UxmlFactory : UxmlFactory<MultiColumnListView, MultiColumnListView.UxmlTraits>
		{
			// Token: 0x060038E2 RID: 14562 RVA: 0x00017C32 File Offset: 0x00015E32
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<MultiColumnListView.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnListView.UxmlFactory>.NativeClassPtr);
				MultiColumnListView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView.UxmlFactory>.NativeClassPtr, 100665052);
			}

			// Token: 0x060038E3 RID: 14563 RVA: 0x000E7B90 File Offset: 0x000E5D90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302163, RefRangeEnd = 302164, XrefRangeStart = 302160, XrefRangeEnd = 302163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnListView.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038E4 RID: 14564 RVA: 0x00017C66 File Offset: 0x00015E66
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400285C RID: 10332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003A8 RID: 936
		public new class UxmlTraits : BaseListView.UxmlTraits
		{
			// Token: 0x060038E5 RID: 14565 RVA: 0x000E7BCC File Offset: 0x000E5DCC
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultiColumnListView>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr);
				MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_SortingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr, "m_SortingEnabled");
				MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr, "m_Columns");
				MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_SortColumnDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr, "m_SortColumnDescriptions");
				MultiColumnListView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr, 100665053);
				MultiColumnListView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr, 100665054);
			}

			// Token: 0x060038E6 RID: 14566 RVA: 0x000E7C5C File Offset: 0x000E5E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302164, XrefRangeEnd = 302181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListView.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038E7 RID: 14567 RVA: 0x000E7CD4 File Offset: 0x000E5ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302181, XrefRangeEnd = 302205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnListView.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListView.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038E8 RID: 14568 RVA: 0x00017C6F File Offset: 0x00015E6F
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x060038E9 RID: 14569 RVA: 0x000E7D10 File Offset: 0x000E5F10
			// (set) Token: 0x060038EA RID: 14570 RVA: 0x00017C78 File Offset: 0x00015E78
			public unsafe UxmlBoolAttributeDescription m_SortingEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_SortingEnabled);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_SortingEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x060038EB RID: 14571 RVA: 0x000E7D40 File Offset: 0x000E5F40
			// (set) Token: 0x060038EC RID: 14572 RVA: 0x00017C97 File Offset: 0x00015E97
			public unsafe UxmlObjectAttributeDescription<Columns> m_Columns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_Columns);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlObjectAttributeDescription<Columns>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x060038ED RID: 14573 RVA: 0x000E7D70 File Offset: 0x000E5F70
			// (set) Token: 0x060038EE RID: 14574 RVA: 0x00017CB6 File Offset: 0x00015EB6
			public unsafe UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_SortColumnDescriptions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlObjectAttributeDescription<SortColumnDescriptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListView.UxmlTraits.NativeFieldInfoPtr_m_SortColumnDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400285D RID: 10333
			private static readonly IntPtr NativeFieldInfoPtr_m_SortingEnabled;

			// Token: 0x0400285E RID: 10334
			private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

			// Token: 0x0400285F RID: 10335
			private static readonly IntPtr NativeFieldInfoPtr_m_SortColumnDescriptions;

			// Token: 0x04002860 RID: 10336
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002861 RID: 10337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
