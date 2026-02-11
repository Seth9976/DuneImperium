using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000E8 RID: 232
	public static class CameraExtensions : Object
	{
		// Token: 0x0600116E RID: 4462 RVA: 0x00051ECC File Offset: 0x000500CC
		// Note: this type is marked as 'beforefieldinit'.
		static CameraExtensions()
		{
			Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CameraExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr);
			CameraExtensions.NativeMethodInfoPtr_GetUniversalAdditionalCameraData_Public_Static_UniversalAdditionalCameraData_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665505);
			CameraExtensions.NativeMethodInfoPtr_GetVolumeFrameworkUpdateMode_Public_Static_VolumeFrameworkUpdateMode_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665506);
			CameraExtensions.NativeMethodInfoPtr_SetVolumeFrameworkUpdateMode_Public_Static_Void_Camera_VolumeFrameworkUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665507);
			CameraExtensions.NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665508);
			CameraExtensions.NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665509);
			CameraExtensions.NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665510);
			CameraExtensions.NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665511);
			CameraExtensions.NativeMethodInfoPtr_GetVolumeLayerMaskAndTrigger_Internal_Static_Void_Camera_UniversalAdditionalCameraData_byref_LayerMask_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraExtensions>.NativeClassPtr, 100665512);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00051F9C File Offset: 0x0005019C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618764, XrefRangeEnd = 618771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_GetUniversalAdditionalCameraData_Public_Static_UniversalAdditionalCameraData_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData>(intPtr3) : null;
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00051FE0 File Offset: 0x000501E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618771, XrefRangeEnd = 618779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_GetVolumeFrameworkUpdateMode_Public_Static_VolumeFrameworkUpdateMode_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00052024 File Offset: 0x00050224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618779, XrefRangeEnd = 618790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVolumeFrameworkUpdateMode(this Camera camera, VolumeFrameworkUpdateMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_SetVolumeFrameworkUpdateMode_Public_Static_Void_Camera_VolumeFrameworkUpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00052068 File Offset: 0x00050268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618790, XrefRangeEnd = 618799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateVolumeStack(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000520A0 File Offset: 0x000502A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 618811, RefRangeEnd = 618814, XrefRangeStart = 618799, XrefRangeEnd = 618811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000520E8 File Offset: 0x000502E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618814, XrefRangeEnd = 618827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyVolumeStack(this Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00052120 File Offset: 0x00050320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618832, RefRangeEnd = 618833, XrefRangeStart = 618827, XrefRangeEnd = 618832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00052168 File Offset: 0x00050368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 618860, RefRangeEnd = 618862, XrefRangeStart = 618833, XrefRangeEnd = 618860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetVolumeLayerMaskAndTrigger(this Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &layerMask;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CameraExtensions.NativeMethodInfoPtr_GetVolumeLayerMaskAndTrigger_Internal_Static_Void_Camera_UniversalAdditionalCameraData_byref_LayerMask_byref_Transform_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			trigger = ((intPtr4 == 0) ? null : new Transform(intPtr4));
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0000A6B4 File Offset: 0x000088B4
		public CameraExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_GetUniversalAdditionalCameraData_Public_Static_UniversalAdditionalCameraData_Camera_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeFrameworkUpdateMode_Public_Static_VolumeFrameworkUpdateMode_Camera_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_SetVolumeFrameworkUpdateMode_Public_Static_Void_Camera_VolumeFrameworkUpdateMode_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_DestroyVolumeStack_Public_Static_Void_Camera_UniversalAdditionalCameraData_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeLayerMaskAndTrigger_Internal_Static_Void_Camera_UniversalAdditionalCameraData_byref_LayerMask_byref_Transform_0;
	}
}
