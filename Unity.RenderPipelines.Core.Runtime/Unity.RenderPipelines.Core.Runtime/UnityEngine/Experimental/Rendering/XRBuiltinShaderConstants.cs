using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000006 RID: 6
	public static class XRBuiltinShaderConstants : Object
	{
		// Token: 0x06000038 RID: 56 RVA: 0x0000EE40 File Offset: 0x0000D040
		// Note: this type is marked as 'beforefieldinit'.
		static XRBuiltinShaderConstants()
		{
			Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRBuiltinShaderConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr);
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoCameraProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoCameraProjection");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoCameraInvProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoCameraInvProjection");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixV");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixInvV");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixP");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixInvP");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixVP");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoMatrixInvVP");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "unity_StereoWorldSpaceCameraPos");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_cameraProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_cameraProjMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invCameraProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invCameraProjMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_viewMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invViewMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_projMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_projMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invProjMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_viewProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_viewProjMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invViewProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_invViewProjMatrix");
			XRBuiltinShaderConstants.NativeFieldInfoPtr_s_worldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, "s_worldSpaceCameraPos");
			XRBuiltinShaderConstants.NativeMethodInfoPtr_UpdateBuiltinShaderConstants_Public_Static_Void_Matrix4x4_Matrix4x4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663324);
			XRBuiltinShaderConstants.NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663325);
			XRBuiltinShaderConstants.NativeMethodInfoPtr_Update_Public_Static_Void_XRPass_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRBuiltinShaderConstants>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000F014 File Offset: 0x0000D214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953227, XrefRangeEnd = 953246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRBuiltinShaderConstants.NativeMethodInfoPtr_UpdateBuiltinShaderConstants_Public_Static_Void_Matrix4x4_Matrix4x4_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000F070 File Offset: 0x0000D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953246, XrefRangeEnd = 953268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBuiltinShaderConstants(CommandBuffer cmd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRBuiltinShaderConstants.NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953268, XrefRangeEnd = 953322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRBuiltinShaderConstants.NativeMethodInfoPtr_Update_Public_Static_Void_XRPass_CommandBuffer_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000021D1 File Offset: 0x000003D1
		public XRBuiltinShaderConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000F100 File Offset: 0x0000D300
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000021DA File Offset: 0x000003DA
		public unsafe static int unity_StereoCameraProjection
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoCameraProjection, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoCameraProjection, (void*)(&value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000F11C File Offset: 0x0000D31C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021E8 File Offset: 0x000003E8
		public unsafe static int unity_StereoCameraInvProjection
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoCameraInvProjection, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoCameraInvProjection, (void*)(&value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000F138 File Offset: 0x0000D338
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021F6 File Offset: 0x000003F6
		public unsafe static int unity_StereoMatrixV
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixV, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixV, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000F154 File Offset: 0x0000D354
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002204 File Offset: 0x00000404
		public unsafe static int unity_StereoMatrixInvV
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvV, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvV, (void*)(&value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000F170 File Offset: 0x0000D370
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002212 File Offset: 0x00000412
		public unsafe static int unity_StereoMatrixP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixP, (void*)(&value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000F18C File Offset: 0x0000D38C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002220 File Offset: 0x00000420
		public unsafe static int unity_StereoMatrixInvP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvP, (void*)(&value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000F1A8 File Offset: 0x0000D3A8
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000222E File Offset: 0x0000042E
		public unsafe static int unity_StereoMatrixVP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixVP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixVP, (void*)(&value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000223C File Offset: 0x0000043C
		public unsafe static int unity_StereoMatrixInvVP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvVP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoMatrixInvVP, (void*)(&value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000224A File Offset: 0x0000044A
		public unsafe static int unity_StereoWorldSpaceCameraPos
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos, (void*)(&value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002258 File Offset: 0x00000458
		public unsafe static Il2CppStructArray<Matrix4x4> s_cameraProjMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_cameraProjMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_cameraProjMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000F224 File Offset: 0x0000D424
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000226A File Offset: 0x0000046A
		public unsafe static Il2CppStructArray<Matrix4x4> s_invCameraProjMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invCameraProjMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invCameraProjMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000F24C File Offset: 0x0000D44C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000227C File Offset: 0x0000047C
		public unsafe static Il2CppStructArray<Matrix4x4> s_viewMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_viewMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_viewMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000F274 File Offset: 0x0000D474
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000228E File Offset: 0x0000048E
		public unsafe static Il2CppStructArray<Matrix4x4> s_invViewMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invViewMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invViewMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000F29C File Offset: 0x0000D49C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000022A0 File Offset: 0x000004A0
		public unsafe static Il2CppStructArray<Matrix4x4> s_projMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_projMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_projMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000022B2 File Offset: 0x000004B2
		public unsafe static Il2CppStructArray<Matrix4x4> s_invProjMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invProjMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invProjMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000022C4 File Offset: 0x000004C4
		public unsafe static Il2CppStructArray<Matrix4x4> s_viewProjMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_viewProjMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_viewProjMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000F314 File Offset: 0x0000D514
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000022D6 File Offset: 0x000004D6
		public unsafe static Il2CppStructArray<Matrix4x4> s_invViewProjMatrix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invViewProjMatrix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_invViewProjMatrix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000F33C File Offset: 0x0000D53C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000022E8 File Offset: 0x000004E8
		public unsafe static Il2CppStructArray<Vector4> s_worldSpaceCameraPos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_worldSpaceCameraPos, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRBuiltinShaderConstants.NativeFieldInfoPtr_s_worldSpaceCameraPos, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoCameraProjection;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoCameraInvProjection;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoMatrixV;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoMatrixInvV;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoMatrixP;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoMatrixInvP;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoMatrixVP;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoMatrixInvVP;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_unity_StereoWorldSpaceCameraPos;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_s_cameraProjMatrix;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_s_invCameraProjMatrix;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_s_viewMatrix;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_s_invViewMatrix;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_s_projMatrix;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_s_invProjMatrix;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_s_viewProjMatrix;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_s_invViewProjMatrix;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_s_worldSpaceCameraPos;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBuiltinShaderConstants_Public_Static_Void_Matrix4x4_Matrix4x4_Boolean_Int32_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_SetBuiltinShaderConstants_Public_Static_Void_CommandBuffer_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_XRPass_CommandBuffer_Boolean_0;
	}
}
