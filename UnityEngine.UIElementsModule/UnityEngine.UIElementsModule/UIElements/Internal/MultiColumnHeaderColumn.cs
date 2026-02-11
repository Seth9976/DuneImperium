using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002B2 RID: 690
	public class MultiColumnHeaderColumn : VisualElement
	{
		// Token: 0x0600335F RID: 13151 RVA: 0x000D8C94 File Offset: 0x000D6E94
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumn()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr);
			MultiColumnHeaderColumn.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_sortableUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "sortableUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_sortedAscendingUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "sortedAscendingUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_sortedDescendingUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "sortedDescendingUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_movingUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "movingUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_contentContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "contentContainerUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_contentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "contentUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_defaultContentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "defaultContentUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_hasIconUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "hasIconUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_hasTitleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "hasTitleUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_titleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "titleUssClassName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_iconElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "iconElementName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_titleElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "titleElementName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_s_BoundVEPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "s_BoundVEPropertyName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_s_BindingCallbackVEPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "s_BindingCallbackVEPropertyName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_s_UnbindingCallbackVEPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "s_UnbindingCallbackVEPropertyName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_s_DestroyCallbackVEPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "s_DestroyCallbackVEPropertyName");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_m_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "m_ContentContainer");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "m_Content");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_m_SortIndicatorContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "m_SortIndicatorContainer");
			MultiColumnHeaderColumn.NativeFieldInfoPtr_m_ScheduledHeaderTemplateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "m_ScheduledHeaderTemplateUpdate");
			MultiColumnHeaderColumn.NativeFieldInfoPtr__clickable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "<clickable>k__BackingField");
			MultiColumnHeaderColumn.NativeFieldInfoPtr__mover_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "<mover>k__BackingField");
			MultiColumnHeaderColumn.NativeFieldInfoPtr__column_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, "<column>k__BackingField");
			MultiColumnHeaderColumn.NativeMethodInfoPtr_get_clickable_Public_get_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670754);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_set_clickable_Private_set_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670755);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_get_mover_Public_get_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670756);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_set_mover_Private_set_Void_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670757);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_set_sortOrderLabel_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670758);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_get_column_Public_get_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670759);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_set_column_Private_set_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670760);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_get_content_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670761);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_set_content_Public_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670762);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_get_isContentBound_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670763);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_set_isContentBound_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670764);
			MultiColumnHeaderColumn.NativeMethodInfoPtr__ctor_Public_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670765);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670766);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670767);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_InitManipulators_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670768);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_OnMoverChanged_Private_Void_ColumnMover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670769);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_UpdateDataFromColumn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670770);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_BindHeaderContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670771);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_UnbindHeaderContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670772);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_DestroyHeaderContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670773);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_CreateDefaultHeaderContent_Private_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670774);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_DefaultBindHeaderContent_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670775);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_UpdateHeaderTemplate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670776);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_UpdateGeometryFromColumn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670777);
			MultiColumnHeaderColumn.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr, 100670778);
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x000D9098 File Offset: 0x000D7298
		// (set) Token: 0x06003361 RID: 13153 RVA: 0x000D90D8 File Offset: 0x000D72D8
		public unsafe Clickable clickable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_get_clickable_Public_get_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_set_clickable_Private_set_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x000D911C File Offset: 0x000D731C
		// (set) Token: 0x06003363 RID: 13155 RVA: 0x000D915C File Offset: 0x000D735C
		public unsafe ColumnMover mover
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_get_mover_Public_get_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColumnMover>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361681, XrefRangeEnd = 361682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_set_mover_Private_set_Void_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x00014EA0 File Offset: 0x000130A0
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x000D91A0 File Offset: 0x000D73A0
		public unsafe string sortOrderLabel
		{
			get
			{
				return this.m_SortIndicatorContainer.sortOrderLabel;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 361683, RefRangeEnd = 361684, XrefRangeStart = 361682, XrefRangeEnd = 361683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_set_sortOrderLabel_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x000D91E4 File Offset: 0x000D73E4
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x000D9224 File Offset: 0x000D7424
		public unsafe Column column
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_get_column_Public_get_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Column>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361684, XrefRangeEnd = 361685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_set_column_Private_set_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x000D9268 File Offset: 0x000D7468
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x000D92A8 File Offset: 0x000D74A8
		public unsafe VisualElement content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_get_content_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 361717, RefRangeEnd = 361719, XrefRangeStart = 361685, XrefRangeEnd = 361717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_set_content_Public_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x000D92EC File Offset: 0x000D74EC
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x000D9328 File Offset: 0x000D7528
		public unsafe bool isContentBound
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 361721, RefRangeEnd = 361724, XrefRangeStart = 361719, XrefRangeEnd = 361721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_get_isContentBound_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 361733, RefRangeEnd = 361737, XrefRangeStart = 361724, XrefRangeEnd = 361733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_set_isContentBound_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000D9368 File Offset: 0x000D7568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361852, RefRangeEnd = 361853, XrefRangeStart = 361737, XrefRangeEnd = 361852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumn(Column column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumn>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr__ctor_Public_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x000D93B4 File Offset: 0x000D75B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361853, XrefRangeEnd = 361858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnChanged(Column c, ColumnDataType role)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref role;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000D9404 File Offset: 0x000D7604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361858, XrefRangeEnd = 361859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnResized(Column c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x000D9448 File Offset: 0x000D7648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361896, RefRangeEnd = 361897, XrefRangeStart = 361859, XrefRangeEnd = 361896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitManipulators()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_InitManipulators_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x000D947C File Offset: 0x000D767C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361897, XrefRangeEnd = 361902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoverChanged(ColumnMover mv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_OnMoverChanged_Private_Void_ColumnMover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x000D94C0 File Offset: 0x000D76C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361915, RefRangeEnd = 361917, XrefRangeStart = 361902, XrefRangeEnd = 361915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDataFromColumn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_UpdateDataFromColumn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000D94F4 File Offset: 0x000D76F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361917, XrefRangeEnd = 361928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindHeaderContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_BindHeaderContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000D9528 File Offset: 0x000D7728
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 361939, RefRangeEnd = 361942, XrefRangeStart = 361928, XrefRangeEnd = 361939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnbindHeaderContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_UnbindHeaderContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000D955C File Offset: 0x000D775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361942, XrefRangeEnd = 361964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHeaderContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_DestroyHeaderContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000D9590 File Offset: 0x000D7790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361964, XrefRangeEnd = 362009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement CreateDefaultHeaderContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_CreateDefaultHeaderContent_Private_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x000D95D0 File Offset: 0x000D77D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362009, XrefRangeEnd = 362052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultBindHeaderContent(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_DefaultBindHeaderContent_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x000D9614 File Offset: 0x000D7814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362080, RefRangeEnd = 362081, XrefRangeStart = 362052, XrefRangeEnd = 362080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHeaderTemplate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_UpdateHeaderTemplate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000D9648 File Offset: 0x000D7848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362086, RefRangeEnd = 362088, XrefRangeStart = 362081, XrefRangeEnd = 362086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGeometryFromColumn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_UpdateGeometryFromColumn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x000D967C File Offset: 0x000D787C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362120, RefRangeEnd = 362122, XrefRangeStart = 362088, XrefRangeEnd = 362120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumn.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00014C8C File Offset: 0x00012E8C
		public MultiColumnHeaderColumn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x000D96B0 File Offset: 0x000D78B0
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x00014C95 File Offset: 0x00012E95
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x000D96D0 File Offset: 0x000D78D0
		// (set) Token: 0x0600337D RID: 13181 RVA: 0x00014CA7 File Offset: 0x00012EA7
		public unsafe static string sortableUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_sortableUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_sortableUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x000D96F0 File Offset: 0x000D78F0
		// (set) Token: 0x0600337F RID: 13183 RVA: 0x00014CB9 File Offset: 0x00012EB9
		public unsafe static string sortedAscendingUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_sortedAscendingUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_sortedAscendingUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x000D9710 File Offset: 0x000D7910
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x00014CCB File Offset: 0x00012ECB
		public unsafe static string sortedDescendingUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_sortedDescendingUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_sortedDescendingUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06003382 RID: 13186 RVA: 0x000D9730 File Offset: 0x000D7930
		// (set) Token: 0x06003383 RID: 13187 RVA: 0x00014CDD File Offset: 0x00012EDD
		public unsafe static string movingUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_movingUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_movingUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x000D9750 File Offset: 0x000D7950
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x00014CEF File Offset: 0x00012EEF
		public unsafe static string contentContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_contentContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_contentContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x000D9770 File Offset: 0x000D7970
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x00014D01 File Offset: 0x00012F01
		public unsafe static string contentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_contentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_contentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x000D9790 File Offset: 0x000D7990
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x00014D13 File Offset: 0x00012F13
		public unsafe static string defaultContentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_defaultContentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_defaultContentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x000D97B0 File Offset: 0x000D79B0
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x00014D25 File Offset: 0x00012F25
		public unsafe static string hasIconUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_hasIconUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_hasIconUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x000D97D0 File Offset: 0x000D79D0
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x00014D37 File Offset: 0x00012F37
		public unsafe static string hasTitleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_hasTitleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_hasTitleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x000D97F0 File Offset: 0x000D79F0
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x00014D49 File Offset: 0x00012F49
		public unsafe static string titleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_titleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_titleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000D9810 File Offset: 0x000D7A10
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x00014D5B File Offset: 0x00012F5B
		public unsafe static string iconElementName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_iconElementName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_iconElementName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x000D9830 File Offset: 0x000D7A30
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x00014D6D File Offset: 0x00012F6D
		public unsafe static string titleElementName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_titleElementName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_titleElementName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x000D9850 File Offset: 0x000D7A50
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x00014D7F File Offset: 0x00012F7F
		public unsafe static string s_BoundVEPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_BoundVEPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_BoundVEPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x000D9870 File Offset: 0x000D7A70
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x00014D91 File Offset: 0x00012F91
		public unsafe static string s_BindingCallbackVEPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_BindingCallbackVEPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_BindingCallbackVEPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x000D9890 File Offset: 0x000D7A90
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x00014DA3 File Offset: 0x00012FA3
		public unsafe static string s_UnbindingCallbackVEPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_UnbindingCallbackVEPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_UnbindingCallbackVEPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x000D98B0 File Offset: 0x000D7AB0
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x00014DB5 File Offset: 0x00012FB5
		public unsafe static string s_DestroyCallbackVEPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_DestroyCallbackVEPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumn.NativeFieldInfoPtr_s_DestroyCallbackVEPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x000D98D0 File Offset: 0x000D7AD0
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x00014DC7 File Offset: 0x00012FC7
		public unsafe VisualElement m_ContentContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_ContentContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x000D9900 File Offset: 0x000D7B00
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x00014DE6 File Offset: 0x00012FE6
		public unsafe VisualElement m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x000D9930 File Offset: 0x000D7B30
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x00014E05 File Offset: 0x00013005
		public unsafe MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_SortIndicatorContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnHeaderColumnSortIndicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_SortIndicatorContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x000D9960 File Offset: 0x000D7B60
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x00014E24 File Offset: 0x00013024
		public unsafe IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_ScheduledHeaderTemplateUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr_m_ScheduledHeaderTemplateUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x000D9990 File Offset: 0x000D7B90
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x00014E43 File Offset: 0x00013043
		public unsafe Clickable _clickable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr__clickable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr__clickable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x000D99C0 File Offset: 0x000D7BC0
		// (set) Token: 0x060033A7 RID: 13223 RVA: 0x00014E62 File Offset: 0x00013062
		public unsafe ColumnMover _mover_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr__mover_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColumnMover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr__mover_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x060033A8 RID: 13224 RVA: 0x000D99F0 File Offset: 0x000D7BF0
		// (set) Token: 0x060033A9 RID: 13225 RVA: 0x00014E81 File Offset: 0x00013081
		public unsafe Column _column_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr__column_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumn.NativeFieldInfoPtr__column_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x00014EAD File Offset: 0x000130AD
		public Label title
		{
			get
			{
				VisualElement content = this.content;
				return (content != null) ? content.Q(MultiColumnHeaderColumn.titleElementName, null) : null;
			}
		}

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeFieldInfoPtr_sortableUssClassName;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeFieldInfoPtr_sortedAscendingUssClassName;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeFieldInfoPtr_sortedDescendingUssClassName;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeFieldInfoPtr_movingUssClassName;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeFieldInfoPtr_contentContainerUssClassName;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeFieldInfoPtr_contentUssClassName;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeFieldInfoPtr_defaultContentUssClassName;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeFieldInfoPtr_hasIconUssClassName;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeFieldInfoPtr_hasTitleUssClassName;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeFieldInfoPtr_titleUssClassName;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_iconElementName;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_titleElementName;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeFieldInfoPtr_s_BoundVEPropertyName;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeFieldInfoPtr_s_BindingCallbackVEPropertyName;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeFieldInfoPtr_s_UnbindingCallbackVEPropertyName;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeFieldInfoPtr_s_DestroyCallbackVEPropertyName;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentContainer;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeFieldInfoPtr_m_SortIndicatorContainer;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduledHeaderTemplateUpdate;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeFieldInfoPtr__clickable_k__BackingField;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeFieldInfoPtr__mover_k__BackingField;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeFieldInfoPtr__column_k__BackingField;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeMethodInfoPtr_get_clickable_Public_get_Clickable_0;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeMethodInfoPtr_set_clickable_Private_set_Void_Clickable_0;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeMethodInfoPtr_get_mover_Public_get_ColumnMover_0;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeMethodInfoPtr_set_mover_Private_set_Void_ColumnMover_0;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr_set_sortOrderLabel_Public_set_Void_String_0;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_get_column_Public_get_Column_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_set_column_Private_set_Void_Column_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr_get_content_Public_get_VisualElement_0;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr_set_content_Public_set_Void_VisualElement_0;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeMethodInfoPtr_get_isContentBound_Private_get_Boolean_0;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeMethodInfoPtr_set_isContentBound_Private_set_Void_Boolean_0;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Column_0;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_InitManipulators_Private_Void_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_OnMoverChanged_Private_Void_ColumnMover_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDataFromColumn_Private_Void_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr_BindHeaderContent_Private_Void_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr_UnbindHeaderContent_Private_Void_0;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHeaderContent_Private_Void_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultHeaderContent_Private_VisualElement_0;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr_DefaultBindHeaderContent_Private_Void_VisualElement_0;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHeaderTemplate_Private_Void_0;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometryFromColumn_Private_Void_0;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
	}
}
