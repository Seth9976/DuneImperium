using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x0200011B RID: 283
	public static class NormalReconstruction : Object
	{
		// Token: 0x06001890 RID: 6288 RVA: 0x0006798C File Offset: 0x00065B8C
		// Note: this type is marked as 'beforefieldinit'.
		static NormalReconstruction()
		{
			Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "NormalReconstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr);
			NormalReconstruction.NativeFieldInfoPtr_s_NormalReconstructionMatrixID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, "s_NormalReconstructionMatrixID");
			NormalReconstruction.NativeFieldInfoPtr_s_NormalReconstructionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, "s_NormalReconstructionMatrix");
			NormalReconstruction.NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalReconstruction>.NativeClassPtr, 100666161);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000679F8 File Offset: 0x00065BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 626503, RefRangeEnd = 626505, XrefRangeStart = 626485, XrefRangeEnd = 626503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupProperties(CommandBuffer cmd, [In] ref CameraData cameraData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalReconstruction.NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_byref_CameraData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000E052 File Offset: 0x0000C252
		public NormalReconstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00067A44 File Offset: 0x00065C44
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x0000E05B File Offset: 0x0000C25B
		public unsafe static int s_NormalReconstructionMatrixID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NormalReconstruction.NativeFieldInfoPtr_s_NormalReconstructionMatrixID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalReconstruction.NativeFieldInfoPtr_s_NormalReconstructionMatrixID, (void*)(&value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00067A60 File Offset: 0x00065C60
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x0000E069 File Offset: 0x0000C269
		public unsafe static Il2CppStructArray<Matrix4x4> s_NormalReconstructionMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalReconstruction.NativeFieldInfoPtr_s_NormalReconstructionMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalReconstruction.NativeFieldInfoPtr_s_NormalReconstructionMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr_s_NormalReconstructionMatrixID;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_s_NormalReconstructionMatrix;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_SetupProperties_Public_Static_Void_CommandBuffer_byref_CameraData_0;
	}
}
