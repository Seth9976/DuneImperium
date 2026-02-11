using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public class CameraRaycastHelper : Object
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002BD8 File Offset: 0x00000DD8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRaycastHelper()
		{
			Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "CameraRaycastHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663314);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663315);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663316);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002C58 File Offset: 0x00000E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266757, XrefRangeEnd = 1266759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002CC8 File Offset: 0x00000EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266759, XrefRangeEnd = 1266761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D38 File Offset: 0x00000F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266761, XrefRangeEnd = 1266763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266763, XrefRangeEnd = 1266765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020E2 File Offset: 0x000002E2
		public CameraRaycastHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0;
	}
}
