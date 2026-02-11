using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000034 RID: 52
	public class IPixelPerfectCamera : Il2CppObjectBase
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00023F4C File Offset: 0x0002214C
		// Note: this type is marked as 'beforefieldinit'.
		static IPixelPerfectCamera()
		{
			Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "IPixelPerfectCamera");
			IPixelPerfectCamera.NativeMethodInfoPtr_get_assetsPPU_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663791);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_assetsPPU_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663792);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionX_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663793);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionX_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663794);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionY_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663795);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionY_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663796);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_upscaleRT_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663797);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_upscaleRT_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663798);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_pixelSnapping_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663799);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_pixelSnapping_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663800);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameX_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663801);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameX_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663802);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameY_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663803);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameY_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663804);
			IPixelPerfectCamera.NativeMethodInfoPtr_get_stretchFill_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663805);
			IPixelPerfectCamera.NativeMethodInfoPtr_set_stretchFill_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPixelPerfectCamera>.NativeClassPtr, 100663806);
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x000240B4 File Offset: 0x000222B4
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000240FC File Offset: 0x000222FC
		public unsafe virtual int assetsPPU
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_assetsPPU_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_assetsPPU_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00024148 File Offset: 0x00022348
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00024190 File Offset: 0x00022390
		public unsafe virtual int refResolutionX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionX_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionX_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x000241DC File Offset: 0x000223DC
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00024224 File Offset: 0x00022424
		public unsafe virtual int refResolutionY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionY_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionY_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00024270 File Offset: 0x00022470
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000242B8 File Offset: 0x000224B8
		public unsafe virtual bool upscaleRT
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_upscaleRT_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_upscaleRT_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00024304 File Offset: 0x00022504
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0002434C File Offset: 0x0002254C
		public unsafe virtual bool pixelSnapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_pixelSnapping_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_pixelSnapping_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00024398 File Offset: 0x00022598
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x000243E0 File Offset: 0x000225E0
		public unsafe virtual bool cropFrameX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameX_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameX_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0002442C File Offset: 0x0002262C
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00024474 File Offset: 0x00022674
		public unsafe virtual bool cropFrameY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameY_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameY_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000244C0 File Offset: 0x000226C0
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00024508 File Offset: 0x00022708
		public unsafe virtual bool stretchFill
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_get_stretchFill_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPixelPerfectCamera.NativeMethodInfoPtr_set_stretchFill_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00003ADB File Offset: 0x00001CDB
		public IPixelPerfectCamera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_get_assetsPPU_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_set_assetsPPU_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_get_refResolutionX_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_set_refResolutionX_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_refResolutionY_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_set_refResolutionY_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_get_upscaleRT_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_set_upscaleRT_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelSnapping_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelSnapping_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_get_cropFrameX_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_set_cropFrameX_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_get_cropFrameY_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_set_cropFrameY_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchFill_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchFill_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
