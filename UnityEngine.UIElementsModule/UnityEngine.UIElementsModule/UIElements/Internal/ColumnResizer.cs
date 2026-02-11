using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002AE RID: 686
	public class ColumnResizer : PointerManipulator
	{
		// Token: 0x060032CB RID: 13003 RVA: 0x000D6C60 File Offset: 0x000D4E60
		// Note: this type is marked as 'beforefieldinit'.
		static ColumnResizer()
		{
			Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "ColumnResizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr);
			ColumnResizer.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "m_Start");
			ColumnResizer.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "m_Active");
			ColumnResizer.NativeFieldInfoPtr_m_Resizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "m_Resizing");
			ColumnResizer.NativeFieldInfoPtr_m_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "m_Header");
			ColumnResizer.NativeFieldInfoPtr_m_Column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "m_Column");
			ColumnResizer.NativeFieldInfoPtr_m_PreviewElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "m_PreviewElement");
			ColumnResizer.NativeFieldInfoPtr__columnLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "<columnLayout>k__BackingField");
			ColumnResizer.NativeFieldInfoPtr__preview_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, "<preview>k__BackingField");
			ColumnResizer.NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670668);
			ColumnResizer.NativeMethodInfoPtr_set_columnLayout_Public_set_Void_ColumnLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670669);
			ColumnResizer.NativeMethodInfoPtr_get_preview_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670670);
			ColumnResizer.NativeMethodInfoPtr_set_preview_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670671);
			ColumnResizer.NativeMethodInfoPtr__ctor_Public_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670672);
			ColumnResizer.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670673);
			ColumnResizer.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670674);
			ColumnResizer.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670675);
			ColumnResizer.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670676);
			ColumnResizer.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670677);
			ColumnResizer.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670678);
			ColumnResizer.NativeMethodInfoPtr_BeginDragResize_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670679);
			ColumnResizer.NativeMethodInfoPtr_DragResize_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670680);
			ColumnResizer.NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670681);
			ColumnResizer.NativeMethodInfoPtr_EndDragResize_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr, 100670682);
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x000D6E5C File Offset: 0x000D505C
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x000D6E9C File Offset: 0x000D509C
		public unsafe ColumnLayout columnLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_set_columnLayout_Public_set_Void_ColumnLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x000D6EE0 File Offset: 0x000D50E0
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x000D6F1C File Offset: 0x000D511C
		public unsafe bool preview
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_get_preview_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_set_preview_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000D6F5C File Offset: 0x000D515C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360387, XrefRangeEnd = 360392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColumnResizer(Column column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColumnResizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr__ctor_Public_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000D6FA8 File Offset: 0x000D51A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360392, XrefRangeEnd = 360433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColumnResizer.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000D6FE4 File Offset: 0x000D51E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360433, XrefRangeEnd = 360474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColumnResizer.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000D7020 File Offset: 0x000D5220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360474, XrefRangeEnd = 360478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyDown(KeyDownEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000D7064 File Offset: 0x000D5264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360478, XrefRangeEnd = 360521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000D70A8 File Offset: 0x000D52A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360521, XrefRangeEnd = 360533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000D70EC File Offset: 0x000D52EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360533, XrefRangeEnd = 360549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x000D7130 File Offset: 0x000D5330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360549, XrefRangeEnd = 360551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginDragResize(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_BeginDragResize_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000D7170 File Offset: 0x000D5370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360551, XrefRangeEnd = 360553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DragResize(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_DragResize_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x000D71B0 File Offset: 0x000D53B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 360560, RefRangeEnd = 360564, XrefRangeStart = 360553, XrefRangeEnd = 360560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreviewPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x000D71E4 File Offset: 0x000D53E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360564, XrefRangeEnd = 360567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDragResize(float pos, bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cancelled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnResizer.NativeMethodInfoPtr_EndDragResize_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x000148AA File Offset: 0x00012AAA
		public ColumnResizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x000D7230 File Offset: 0x000D5430
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x000148B3 File Offset: 0x00012AB3
		public unsafe Vector2 m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Start)) = value;
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x000D7258 File Offset: 0x000D5458
		// (set) Token: 0x060032DF RID: 13023 RVA: 0x000148CE File Offset: 0x00012ACE
		public unsafe bool m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Active)) = value;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x000D7280 File Offset: 0x000D5480
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x000148E9 File Offset: 0x00012AE9
		public unsafe bool m_Resizing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Resizing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Resizing)) = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x000D72A8 File Offset: 0x000D54A8
		// (set) Token: 0x060032E3 RID: 13027 RVA: 0x00014904 File Offset: 0x00012B04
		public unsafe MultiColumnCollectionHeader m_Header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnCollectionHeader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x000D72D8 File Offset: 0x000D54D8
		// (set) Token: 0x060032E5 RID: 13029 RVA: 0x00014923 File Offset: 0x00012B23
		public unsafe Column m_Column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_Column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x000D7308 File Offset: 0x000D5508
		// (set) Token: 0x060032E7 RID: 13031 RVA: 0x00014942 File Offset: 0x00012B42
		public unsafe VisualElement m_PreviewElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_PreviewElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr_m_PreviewElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x000D7338 File Offset: 0x000D5538
		// (set) Token: 0x060032E9 RID: 13033 RVA: 0x00014961 File Offset: 0x00012B61
		public unsafe ColumnLayout _columnLayout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr__columnLayout_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr__columnLayout_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x000D7368 File Offset: 0x000D5568
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x00014980 File Offset: 0x00012B80
		public unsafe bool _preview_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr__preview_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnResizer.NativeFieldInfoPtr__preview_k__BackingField)) = value;
			}
		}

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeFieldInfoPtr_m_Resizing;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeFieldInfoPtr_m_Header;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeFieldInfoPtr_m_Column;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewElement;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeFieldInfoPtr__columnLayout_k__BackingField;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeFieldInfoPtr__preview_k__BackingField;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_get_columnLayout_Public_get_ColumnLayout_0;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_set_columnLayout_Public_set_Void_ColumnLayout_0;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeMethodInfoPtr_get_preview_Public_get_Boolean_0;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeMethodInfoPtr_set_preview_Public_set_Void_Boolean_0;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Column_0;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_BeginDragResize_Private_Void_Single_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_DragResize_Private_Void_Single_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_EndDragResize_Private_Void_Single_Boolean_0;
	}
}
