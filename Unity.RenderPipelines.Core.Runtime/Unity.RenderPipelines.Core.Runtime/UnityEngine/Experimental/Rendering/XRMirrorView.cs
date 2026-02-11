using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000008 RID: 8
	public static class XRMirrorView : Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000F640 File Offset: 0x0000D840
		// Note: this type is marked as 'beforefieldinit'.
		static XRMirrorView()
		{
			Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRMirrorView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr);
			XRMirrorView.NativeFieldInfoPtr_s_MirrorViewMaterialProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "s_MirrorViewMaterialProperty");
			XRMirrorView.NativeFieldInfoPtr_k_MirrorViewProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_MirrorViewProfilingSampler");
			XRMirrorView.NativeFieldInfoPtr_k_SourceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceTex");
			XRMirrorView.NativeFieldInfoPtr_k_SourceTexArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceTexArraySlice");
			XRMirrorView.NativeFieldInfoPtr_k_ScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_ScaleBias");
			XRMirrorView.NativeFieldInfoPtr_k_ScaleBiasRt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_ScaleBiasRt");
			XRMirrorView.NativeFieldInfoPtr_k_SRGBRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SRGBRead");
			XRMirrorView.NativeFieldInfoPtr_k_SRGBWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SRGBWrite");
			XRMirrorView.NativeFieldInfoPtr_k_MaxNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_MaxNits");
			XRMirrorView.NativeFieldInfoPtr_k_SourceMaxNits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceMaxNits");
			XRMirrorView.NativeFieldInfoPtr_k_SourceHDREncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_SourceHDREncoding");
			XRMirrorView.NativeFieldInfoPtr_k_ColorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, "k_ColorTransform");
			XRMirrorView.NativeMethodInfoPtr_RenderMirrorView_Internal_Static_Void_CommandBuffer_Camera_Material_XRDisplaySubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMirrorView>.NativeClassPtr, 100663335);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000F774 File Offset: 0x0000D974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953590, RefRangeEnd = 953591, XrefRangeStart = 953446, XrefRangeEnd = 953590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(display);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMirrorView.NativeMethodInfoPtr_RenderMirrorView_Internal_Static_Void_CommandBuffer_Camera_Material_XRDisplaySubsystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002322 File Offset: 0x00000522
		public XRMirrorView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000232B File Offset: 0x0000052B
		public unsafe static MaterialPropertyBlock s_MirrorViewMaterialProperty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_s_MirrorViewMaterialProperty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_s_MirrorViewMaterialProperty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000F808 File Offset: 0x0000DA08
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000233D File Offset: 0x0000053D
		public unsafe static ProfilingSampler k_MirrorViewProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_MirrorViewProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_MirrorViewProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000F830 File Offset: 0x0000DA30
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000234F File Offset: 0x0000054F
		public unsafe static int k_SourceTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_SourceTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_SourceTex, (void*)(&value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000F84C File Offset: 0x0000DA4C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000235D File Offset: 0x0000055D
		public unsafe static int k_SourceTexArraySlice
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_SourceTexArraySlice, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_SourceTexArraySlice, (void*)(&value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000F868 File Offset: 0x0000DA68
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000236B File Offset: 0x0000056B
		public unsafe static int k_ScaleBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_ScaleBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_ScaleBias, (void*)(&value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000F884 File Offset: 0x0000DA84
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe static int k_ScaleBiasRt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_ScaleBiasRt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_ScaleBiasRt, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002387 File Offset: 0x00000587
		public unsafe static int k_SRGBRead
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_SRGBRead, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_SRGBRead, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000F8BC File Offset: 0x0000DABC
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002395 File Offset: 0x00000595
		public unsafe static int k_SRGBWrite
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_SRGBWrite, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_SRGBWrite, (void*)(&value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000023A3 File Offset: 0x000005A3
		public unsafe static int k_MaxNits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_MaxNits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_MaxNits, (void*)(&value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000F8F4 File Offset: 0x0000DAF4
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000023B1 File Offset: 0x000005B1
		public unsafe static int k_SourceMaxNits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_SourceMaxNits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_SourceMaxNits, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000F910 File Offset: 0x0000DB10
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe static int k_SourceHDREncoding
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_SourceHDREncoding, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_SourceHDREncoding, (void*)(&value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000F92C File Offset: 0x0000DB2C
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000023CD File Offset: 0x000005CD
		public unsafe static int k_ColorTransform
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XRMirrorView.NativeFieldInfoPtr_k_ColorTransform, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRMirrorView.NativeFieldInfoPtr_k_ColorTransform, (void*)(&value));
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_s_MirrorViewMaterialProperty;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_k_MirrorViewProfilingSampler;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceTex;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceTexArraySlice;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_k_ScaleBias;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_k_ScaleBiasRt;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_k_SRGBRead;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_k_SRGBWrite;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxNits;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceMaxNits;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_k_SourceHDREncoding;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_k_ColorTransform;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_RenderMirrorView_Internal_Static_Void_CommandBuffer_Camera_Material_XRDisplaySubsystem_0;
	}
}
