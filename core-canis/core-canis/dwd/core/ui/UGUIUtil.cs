using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.ui
{
	// Token: 0x020000A2 RID: 162
	public static class UGUIUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0003CEAC File Offset: 0x0003B0AC
		// Note: this type is marked as 'beforefieldinit'.
		static UGUIUtil()
		{
			Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.ui", "UGUIUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr);
			UGUIUtil.NativeMethodInfoPtr_PositionRectWithinRect_Public_Static_Vector2_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664814);
			UGUIUtil.NativeMethodInfoPtr_PositionRectWithinRect_Public_Static_Vector2_ScreenRect_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664815);
			UGUIUtil.NativeMethodInfoPtr_CanvasRectToScreenRect_Public_Static_ScreenRect_Rect_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664816);
			UGUIUtil.NativeMethodInfoPtr_CanvasVectorToScreenVector_Public_Static_Vector2_Vector2_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664817);
			UGUIUtil.NativeMethodInfoPtr_ScreenRectToCanvasRect_Public_Static_Rect_ScreenRect_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664818);
			UGUIUtil.NativeMethodInfoPtr_getCanvasSize_Private_Static_Vector2_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664819);
			UGUIUtil.NativeMethodInfoPtr_ScreenPointToCanvasPoint_Public_Static_Vector2_Vector2_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664820);
			UGUIUtil.NativeMethodInfoPtr_GetCanvasRect_Public_Static_Rect_MonoBounds_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664821);
			UGUIUtil.NativeMethodInfoPtr_GetScreenRectOutOfBoundsDimensions_Public_Static_Vector2_ScreenRect_ScreenRect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664822);
			UGUIUtil.NativeMethodInfoPtr_GetBoundsAsCanvasRect_Public_Static_Rect_Bounds_Transform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664823);
			UGUIUtil.NativeMethodInfoPtr_GetBoundsAsCanvasRect_Public_Static_Rect_Bounds_GlobalTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664824);
			UGUIUtil.NativeMethodInfoPtr_GetScreenRectForCanvasBoundsAtRootScreenPosition_Public_Static_ScreenRect_Vector2_Bounds_GlobalTransform_Canvas_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIUtil>.NativeClassPtr, 100664825);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003CFCC File Offset: 0x0003B1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863231, XrefRangeEnd = 863245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PositionRectWithinRect(Rect elementRect, Rect boundaryRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundaryRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_PositionRectWithinRect_Public_Static_Vector2_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0003D018 File Offset: 0x0003B218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863245, XrefRangeEnd = 863257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PositionRectWithinRect(ScreenRect elementRect, ScreenRect boundaryRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundaryRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_PositionRectWithinRect_Public_Static_Vector2_ScreenRect_ScreenRect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003D064 File Offset: 0x0003B264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863257, XrefRangeEnd = 863267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenRect CanvasRectToScreenRect(Rect canvasRect, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canvasRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_CanvasRectToScreenRect_Public_Static_ScreenRect_Rect_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863267, XrefRangeEnd = 863274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 CanvasVectorToScreenVector(Vector2 canvasVector, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canvasVector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_CanvasVectorToScreenVector_Public_Static_Vector2_Vector2_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0003D104 File Offset: 0x0003B304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863287, RefRangeEnd = 863288, XrefRangeStart = 863274, XrefRangeEnd = 863287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect ScreenRectToCanvasRect(ScreenRect screenRect, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_ScreenRectToCanvasRect_Public_Static_Rect_ScreenRect_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0003D154 File Offset: 0x0003B354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863288, XrefRangeEnd = 863294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 getCanvasSize(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_getCanvasSize_Private_Static_Vector2_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003D198 File Offset: 0x0003B398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863303, RefRangeEnd = 863305, XrefRangeStart = 863294, XrefRangeEnd = 863303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ScreenPointToCanvasPoint(Vector2 screenPoint, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_ScreenPointToCanvasPoint_Public_Static_Vector2_Vector2_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863305, XrefRangeEnd = 863314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetCanvasRect(MonoBounds bounds, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_GetCanvasRect_Public_Static_Rect_MonoBounds_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0003D23C File Offset: 0x0003B43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863314, XrefRangeEnd = 863340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetScreenRectOutOfBoundsDimensions(ScreenRect smallerRect, ScreenRect boundaryRect, bool overExtendFailsSilently = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref smallerRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundaryRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overExtendFailsSilently;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_GetScreenRectOutOfBoundsDimensions_Public_Static_Vector2_ScreenRect_ScreenRect_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0003D298 File Offset: 0x0003B498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863340, XrefRangeEnd = 863342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetBoundsAsCanvasRect(Bounds bounds, Transform boundsContainer, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boundsContainer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_GetBoundsAsCanvasRect_Public_Static_Rect_Bounds_Transform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0003D2FC File Offset: 0x0003B4FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863351, RefRangeEnd = 863353, XrefRangeStart = 863342, XrefRangeEnd = 863351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetBoundsAsCanvasRect(Bounds bounds, GlobalTransform boundsContainer, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundsContainer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_GetBoundsAsCanvasRect_Public_Static_Rect_Bounds_GlobalTransform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0003D35C File Offset: 0x0003B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863353, XrefRangeEnd = 863373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenRect GetScreenRectForCanvasBoundsAtRootScreenPosition(Vector2 rootScreenPosition, Bounds targetBounds, GlobalTransform boundsContainerTransform, Canvas canvas, float targetScale = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rootScreenPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundsContainerTransform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIUtil.NativeMethodInfoPtr_GetScreenRectForCanvasBoundsAtRootScreenPosition_Public_Static_ScreenRect_Vector2_Bounds_GlobalTransform_Canvas_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00005DCC File Offset: 0x00003FCC
		public UGUIUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_PositionRectWithinRect_Public_Static_Vector2_Rect_Rect_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_PositionRectWithinRect_Public_Static_Vector2_ScreenRect_ScreenRect_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_CanvasRectToScreenRect_Public_Static_ScreenRect_Rect_Canvas_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_CanvasVectorToScreenVector_Public_Static_Vector2_Vector2_Canvas_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_ScreenRectToCanvasRect_Public_Static_Rect_ScreenRect_Canvas_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_getCanvasSize_Private_Static_Vector2_Canvas_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToCanvasPoint_Public_Static_Vector2_Vector2_Canvas_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasRect_Public_Static_Rect_MonoBounds_Canvas_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenRectOutOfBoundsDimensions_Public_Static_Vector2_ScreenRect_ScreenRect_Boolean_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundsAsCanvasRect_Public_Static_Rect_Bounds_Transform_Canvas_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundsAsCanvasRect_Public_Static_Rect_Bounds_GlobalTransform_Canvas_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenRectForCanvasBoundsAtRootScreenPosition_Public_Static_ScreenRect_Vector2_Bounds_GlobalTransform_Canvas_Single_0;
	}
}
