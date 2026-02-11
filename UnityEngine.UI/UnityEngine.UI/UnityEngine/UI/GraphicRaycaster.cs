using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000013 RID: 19
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x060001BE RID: 446 RVA: 0x0000DD50 File Offset: 0x0000BF50
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRaycaster()
		{
			Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr);
			GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "kNoEventMaskSet");
			GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_IgnoreReversedGraphics");
			GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_BlockingObjects");
			GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_BlockingMask");
			GraphicRaycaster.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_Canvas");
			GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_RaycastResults");
			GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "s_SortedGraphics");
			GraphicRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663584);
			GraphicRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663585);
			GraphicRaycaster.NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663586);
			GraphicRaycaster.NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663587);
			GraphicRaycaster.NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663588);
			GraphicRaycaster.NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663589);
			GraphicRaycaster.NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663590);
			GraphicRaycaster.NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663591);
			GraphicRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663592);
			GraphicRaycaster.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663593);
			GraphicRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663594);
			GraphicRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663595);
			GraphicRaycaster.NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663596);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000DF10 File Offset: 0x0000C110
		public unsafe override int sortOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084478, XrefRangeEnd = 1084484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000DF58 File Offset: 0x0000C158
		public unsafe override int renderOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084484, XrefRangeEnd = 1084491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		public unsafe bool ignoreReversedGraphics
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000E01C File Offset: 0x0000C21C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000E058 File Offset: 0x0000C258
		public unsafe GraphicRaycaster.BlockingObjects blockingObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000E098 File Offset: 0x0000C298
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		public unsafe LayerMask blockingMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000E114 File Offset: 0x0000C314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084491, XrefRangeEnd = 1084500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000E150 File Offset: 0x0000C350
		public unsafe Canvas canvas
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1084508, RefRangeEnd = 1084520, XrefRangeStart = 1084500, XrefRangeEnd = 1084508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000E190 File Offset: 0x0000C390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084520, XrefRangeEnd = 1084636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		public unsafe override Camera eventCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084636, XrefRangeEnd = 1084645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000E23C File Offset: 0x0000C43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084715, RefRangeEnd = 1084716, XrefRangeStart = 1084645, XrefRangeEnd = 1084715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foundGraphics);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000029EA File Offset: 0x00000BEA
		public GraphicRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000029F3 File Offset: 0x00000BF3
		public unsafe static int kNoEventMaskSet
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002A01 File Offset: 0x00000C01
		public unsafe bool m_IgnoreReversedGraphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002A1C File Offset: 0x00000C1C
		public unsafe GraphicRaycaster.BlockingObjects m_BlockingObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000E324 File Offset: 0x0000C524
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002A37 File Offset: 0x00000C37
		public unsafe LayerMask m_BlockingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000E34C File Offset: 0x0000C54C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002A52 File Offset: 0x00000C52
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000E37C File Offset: 0x0000C57C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002A71 File Offset: 0x00000C71
		public unsafe List<Graphic> m_RaycastResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002A90 File Offset: 0x00000C90
		public unsafe static List<Graphic> s_SortedGraphics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_kNoEventMaskSet;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreReversedGraphics;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockingObjects;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockingMask;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastResults;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_s_SortedGraphics;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0;

		// Token: 0x02000086 RID: 134
		public enum BlockingObjects
		{
			// Token: 0x04000924 RID: 2340
			None,
			// Token: 0x04000925 RID: 2341
			TwoD,
			// Token: 0x04000926 RID: 2342
			ThreeD,
			// Token: 0x04000927 RID: 2343
			All
		}

		// Token: 0x02000087 RID: 135
		[ObfuscatedName("UnityEngine.UI.GraphicRaycaster+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C3B RID: 3131 RVA: 0x00035BB8 File Offset: 0x00033DB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr);
				GraphicRaycaster.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, "<>9");
				GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, "<>9__27_0");
				GraphicRaycaster.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, 100663599);
				GraphicRaycaster.__c.NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, 100663600);
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x00035C34 File Offset: 0x00033E34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x00035C70 File Offset: 0x00033E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084473, XrefRangeEnd = 1084478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Raycast_b__27_0(Graphic g1, Graphic g2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.__c.NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x0000682B File Offset: 0x00004A2B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00035CD0 File Offset: 0x00033ED0
			// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00006834 File Offset: 0x00004A34
			public unsafe static GraphicRaycaster.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00035CF8 File Offset: 0x00033EF8
			// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00006846 File Offset: 0x00004A46
			public unsafe static Comparison<Graphic> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Graphic>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000928 RID: 2344
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000929 RID: 2345
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x0400092A RID: 2346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400092B RID: 2347
			private static readonly IntPtr NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0;
		}
	}
}
