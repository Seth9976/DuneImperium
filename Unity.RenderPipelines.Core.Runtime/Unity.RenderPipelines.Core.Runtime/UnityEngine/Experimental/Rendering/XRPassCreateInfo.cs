using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200000A RID: 10
	public sealed class XRPassCreateInfo : ValueType
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000FD78 File Offset: 0x0000DF78
		// Note: this type is marked as 'beforefieldinit'.
		static XRPassCreateInfo()
		{
			Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRPassCreateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr);
			XRPassCreateInfo.NativeFieldInfoPtr_renderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "renderTarget");
			XRPassCreateInfo.NativeFieldInfoPtr_renderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "renderTargetDesc");
			XRPassCreateInfo.NativeFieldInfoPtr_cullingParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "cullingParameters");
			XRPassCreateInfo.NativeFieldInfoPtr_occlusionMeshMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "occlusionMeshMaterial");
			XRPassCreateInfo.NativeFieldInfoPtr_occlusionMeshScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "occlusionMeshScale");
			XRPassCreateInfo.NativeFieldInfoPtr_foveatedRenderingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "foveatedRenderingInfo");
			XRPassCreateInfo.NativeFieldInfoPtr_multipassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "multipassId");
			XRPassCreateInfo.NativeFieldInfoPtr_cullingPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "cullingPassId");
			XRPassCreateInfo.NativeFieldInfoPtr_copyDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "copyDepth");
			XRPassCreateInfo.NativeFieldInfoPtr_xrSdkRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "xrSdkRenderPass");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000246E File Offset: 0x0000066E
		public XRPassCreateInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002477 File Offset: 0x00000677
		public XRPassCreateInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000FE70 File Offset: 0x0000E070
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002489 File Offset: 0x00000689
		public unsafe RenderTargetIdentifier renderTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_renderTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_renderTarget)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000FE98 File Offset: 0x0000E098
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000024A4 File Offset: 0x000006A4
		public unsafe RenderTextureDescriptor renderTargetDesc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_renderTargetDesc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_renderTargetDesc)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000024BF File Offset: 0x000006BF
		public unsafe ScriptableCullingParameters cullingParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_cullingParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_cullingParameters)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000024DA File Offset: 0x000006DA
		public unsafe Material occlusionMeshMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_occlusionMeshMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_occlusionMeshMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000FF18 File Offset: 0x0000E118
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000024F9 File Offset: 0x000006F9
		public unsafe float occlusionMeshScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_occlusionMeshScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_occlusionMeshScale)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000FF40 File Offset: 0x0000E140
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002514 File Offset: 0x00000714
		public unsafe IntPtr foveatedRenderingInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_foveatedRenderingInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_foveatedRenderingInfo)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000FF68 File Offset: 0x0000E168
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000252F File Offset: 0x0000072F
		public unsafe int multipassId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_multipassId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_multipassId)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000FF90 File Offset: 0x0000E190
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000254A File Offset: 0x0000074A
		public unsafe int cullingPassId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_cullingPassId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_cullingPassId)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002565 File Offset: 0x00000765
		public unsafe bool copyDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_copyDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_copyDepth)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002580 File Offset: 0x00000780
		public unsafe XRDisplaySubsystem.XRRenderPass xrSdkRenderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_xrSdkRenderPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassCreateInfo.NativeFieldInfoPtr_xrSdkRenderPass)) = value;
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_renderTarget;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetDesc;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_cullingParameters;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMeshMaterial;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMeshScale;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_foveatedRenderingInfo;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_multipassId;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_cullingPassId;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_copyDepth;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_xrSdkRenderPass;
	}
}
