using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class RectTransformUtility : Object
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003BD4 File Offset: 0x00001DD4
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformUtility()
		{
			Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "RectTransformUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr);
			RectTransformUtility.NativeFieldInfoPtr_s_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, "s_Corners");
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663361);
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663362);
			RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663363);
			RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663364);
			RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663365);
			RectTransformUtility.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663366);
			RectTransformUtility.NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663367);
			RectTransformUtility.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663368);
			RectTransformUtility.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663369);
			RectTransformUtility.NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663370);
			RectTransformUtility.NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663371);
			RectTransformUtility.NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663372);
			RectTransformUtility.NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663373);
			RectTransformUtility.NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663374);
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_Transform_Canvas_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663376);
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_RectTransform_Canvas_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663377);
			RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_RectTransform_Camera_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663378);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003D6C File Offset: 0x00001F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256711, RefRangeEnd = 1256712, XrefRangeStart = 1256706, XrefRangeEnd = 1256711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003DD0 File Offset: 0x00001FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256717, RefRangeEnd = 1256718, XrefRangeStart = 1256712, XrefRangeEnd = 1256717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003E24 File Offset: 0x00002024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256718, XrefRangeEnd = 1256723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003E94 File Offset: 0x00002094
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1256736, RefRangeEnd = 1256745, XrefRangeStart = 1256723, XrefRangeEnd = 1256736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003EF8 File Offset: 0x000020F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1256753, RefRangeEnd = 1256755, XrefRangeStart = 1256745, XrefRangeEnd = 1256753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003F68 File Offset: 0x00002168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256782, RefRangeEnd = 1256783, XrefRangeStart = 1256755, XrefRangeEnd = 1256782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003FD8 File Offset: 0x000021D8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1256789, RefRangeEnd = 1256801, XrefRangeStart = 1256783, XrefRangeEnd = 1256789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004048 File Offset: 0x00002248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256810, RefRangeEnd = 1256811, XrefRangeStart = 1256801, XrefRangeEnd = 1256810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004098 File Offset: 0x00002298
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1256816, RefRangeEnd = 1256823, XrefRangeStart = 1256811, XrefRangeEnd = 1256816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000040E8 File Offset: 0x000022E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256843, RefRangeEnd = 1256844, XrefRangeStart = 1256823, XrefRangeEnd = 1256843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000413C File Offset: 0x0000233C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256848, RefRangeEnd = 1256849, XrefRangeStart = 1256844, XrefRangeEnd = 1256848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds CalculateRelativeRectTransformBounds(Transform trans)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004180 File Offset: 0x00002380
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1256876, RefRangeEnd = 1256881, XrefRangeStart = 1256849, XrefRangeEnd = 1256876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepPositioning;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000041E0 File Offset: 0x000023E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1256911, RefRangeEnd = 1256914, XrefRangeStart = 1256881, XrefRangeEnd = 1256911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepPositioning;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004234 File Offset: 0x00002434
		[CallerCount(0)]
		public unsafe static Vector2 GetTransposed(Vector2 input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004274 File Offset: 0x00002474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256914, XrefRangeEnd = 1256916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_Transform_Canvas_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000042D8 File Offset: 0x000024D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256916, XrefRangeEnd = 1256918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_RectTransform_Canvas_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004330 File Offset: 0x00002530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256918, XrefRangeEnd = 1256920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_RectTransform_Camera_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000020B5 File Offset: 0x000002B5
		public RectTransformUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000043A0 File Offset: 0x000025A0
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000020BE File Offset: 0x000002BE
		public unsafe static Il2CppStructArray<Vector3> s_Corners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectTransformUtility.NativeFieldInfoPtr_s_Corners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectTransformUtility.NativeFieldInfoPtr_s_Corners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000043C8 File Offset: 0x000025C8
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint)
		{
			return RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint, null);
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_s_Corners;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_Transform_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRelativeRectTransformBounds_Public_Static_Bounds_Transform_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_Transform_Canvas_byref_Vector2_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_RectTransform_Canvas_byref_Rect_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_RectTransform_Camera_byref_Vector4_0;
	}
}
