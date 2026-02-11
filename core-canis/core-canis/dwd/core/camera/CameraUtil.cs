using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.camera
{
	// Token: 0x020000A3 RID: 163
	public static class CameraUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003D3D8 File Offset: 0x0003B5D8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraUtil()
		{
			Il2CppClassPointerStore<CameraUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.camera", "CameraUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr);
			CameraUtil.NativeMethodInfoPtr_PositionWithinScreenRect_Public_Static_Vector2_ScreenRect_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr, 100664826);
			CameraUtil.NativeMethodInfoPtr_positionWithinBounds_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr, 100664827);
			CameraUtil.NativeMethodInfoPtr_IsInViewport_Public_Static_Boolean_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr, 100664828);
			CameraUtil.NativeMethodInfoPtr_IsInViewport_Public_Static_Boolean_Camera_Vector3_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr, 100664829);
			CameraUtil.NativeMethodInfoPtr_CameraSizeAtDepth_Public_Static_Vector2_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr, 100664830);
			CameraUtil.NativeMethodInfoPtr_ValidateScreenTransform_Public_Static_String_Transform_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtil>.NativeClassPtr, 100664831);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0003D480 File Offset: 0x0003B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863373, XrefRangeEnd = 863379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PositionWithinScreenRect(ScreenRect screenRect, Vector2 itemScreenSize, Vector2 screenPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemScreenSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUtil.NativeMethodInfoPtr_PositionWithinScreenRect_Public_Static_Vector2_ScreenRect_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0003D4DC File Offset: 0x0003B6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863385, RefRangeEnd = 863387, XrefRangeStart = 863379, XrefRangeEnd = 863385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float positionWithinBounds(float position, float size, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUtil.NativeMethodInfoPtr_positionWithinBounds_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0003D544 File Offset: 0x0003B744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863387, XrefRangeEnd = 863388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInViewport(Camera cam, Vector3 pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUtil.NativeMethodInfoPtr_IsInViewport_Public_Static_Boolean_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0003D594 File Offset: 0x0003B794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863388, XrefRangeEnd = 863389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInViewport(Camera cam, Vector3 pos, Rect viewport)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewport;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUtil.NativeMethodInfoPtr_IsInViewport_Public_Static_Boolean_Camera_Vector3_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0003D5F4 File Offset: 0x0003B7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863389, XrefRangeEnd = 863396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 CameraSizeAtDepth(Camera camera, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUtil.NativeMethodInfoPtr_CameraSizeAtDepth_Public_Static_Vector2_Camera_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0003D644 File Offset: 0x0003B844
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ValidateScreenTransform(Transform transform, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraUtil.NativeMethodInfoPtr_ValidateScreenTransform_Public_Static_String_Transform_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00005DD5 File Offset: 0x00003FD5
		public CameraUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_PositionWithinScreenRect_Public_Static_Vector2_ScreenRect_Vector2_Vector2_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_positionWithinBounds_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_IsInViewport_Public_Static_Boolean_Camera_Vector3_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_IsInViewport_Public_Static_Boolean_Camera_Vector3_Rect_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_CameraSizeAtDepth_Public_Static_Vector2_Camera_Single_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_ValidateScreenTransform_Public_Static_String_Transform_Camera_0;
	}
}
