using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000107 RID: 263
	public static class XRSystemUniversal : Object
	{
		// Token: 0x06001621 RID: 5665 RVA: 0x0005ED2C File Offset: 0x0005CF2C
		// Note: this type is marked as 'beforefieldinit'.
		static XRSystemUniversal()
		{
			Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "XRSystemUniversal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr);
			XRSystemUniversal.NativeFieldInfoPtr_s_projMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, "s_projMatrix");
			XRSystemUniversal.NativeMethodInfoPtr_BeginLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100665844);
			XRSystemUniversal.NativeMethodInfoPtr_EndLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100665845);
			XRSystemUniversal.NativeMethodInfoPtr_UnmarkShaderProperties_Internal_Static_Void_CommandBuffer_XRPassUniversal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100665846);
			XRSystemUniversal.NativeMethodInfoPtr_MarkShaderProperties_Internal_Static_Void_CommandBuffer_XRPassUniversal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemUniversal>.NativeClassPtr, 100665847);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0005EDC0 File Offset: 0x0005CFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622902, RefRangeEnd = 622903, XrefRangeStart = 622893, XrefRangeEnd = 622902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginLateLatching(Camera camera, XRPassUniversal xrPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystemUniversal.NativeMethodInfoPtr_BeginLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0005EE08 File Offset: 0x0005D008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622911, RefRangeEnd = 622912, XrefRangeStart = 622903, XrefRangeEnd = 622911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndLateLatching(Camera camera, XRPassUniversal xrPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystemUniversal.NativeMethodInfoPtr_EndLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0005EE50 File Offset: 0x0005D050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622916, RefRangeEnd = 622917, XrefRangeStart = 622912, XrefRangeEnd = 622916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnmarkShaderProperties(CommandBuffer cmd, XRPassUniversal xrPass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystemUniversal.NativeMethodInfoPtr_UnmarkShaderProperties_Internal_Static_Void_CommandBuffer_XRPassUniversal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0005EE98 File Offset: 0x0005D098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 622938, RefRangeEnd = 622939, XrefRangeStart = 622917, XrefRangeEnd = 622938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkShaderProperties(CommandBuffer cmd, XRPassUniversal xrPass, bool renderIntoTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystemUniversal.NativeMethodInfoPtr_MarkShaderProperties_Internal_Static_Void_CommandBuffer_XRPassUniversal_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0000CE47 File Offset: 0x0000B047
		public XRSystemUniversal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x0000CE50 File Offset: 0x0000B050
		public unsafe static Il2CppStructArray<Matrix4x4> s_projMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRSystemUniversal.NativeFieldInfoPtr_s_projMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRSystemUniversal.NativeFieldInfoPtr_s_projMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeFieldInfoPtr_s_projMatrix;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_BeginLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_EndLateLatching_Internal_Static_Void_Camera_XRPassUniversal_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_UnmarkShaderProperties_Internal_Static_Void_CommandBuffer_XRPassUniversal_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_MarkShaderProperties_Internal_Static_Void_CommandBuffer_XRPassUniversal_Boolean_0;
	}
}
