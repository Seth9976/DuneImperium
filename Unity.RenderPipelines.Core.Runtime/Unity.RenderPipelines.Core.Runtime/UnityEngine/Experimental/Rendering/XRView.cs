using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200000D RID: 13
	public sealed class XRView : ValueType
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		// Note: this type is marked as 'beforefieldinit'.
		static XRView()
		{
			Il2CppClassPointerStore<XRView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRView>.NativeClassPtr);
			XRView.NativeFieldInfoPtr_projMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "projMatrix");
			XRView.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "viewMatrix");
			XRView.NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "viewport");
			XRView.NativeFieldInfoPtr_occlusionMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "occlusionMesh");
			XRView.NativeFieldInfoPtr_textureArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "textureArraySlice");
			XRView.NativeFieldInfoPtr_eyeCenterUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "eyeCenterUV");
			XRView.NativeMethodInfoPtr__ctor_Internal_Void_Matrix4x4_Matrix4x4_Rect_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRView>.NativeClassPtr, 100663414);
			XRView.NativeMethodInfoPtr_ComputeEyeCenterUV_Private_Static_Vector2_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRView>.NativeClassPtr, 100663415);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00011BB8 File Offset: 0x0000FDB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 954589, RefRangeEnd = 954591, XrefRangeStart = 954584, XrefRangeEnd = 954589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Rect viewport, Mesh occlusionMesh, int textureArraySlice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRView>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref projMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewport;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occlusionMesh);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureArraySlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRView.NativeMethodInfoPtr__ctor_Internal_Void_Matrix4x4_Matrix4x4_Rect_Mesh_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00011C44 File Offset: 0x0000FE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954591, XrefRangeEnd = 954595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ComputeEyeCenterUV(Matrix4x4 proj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRView.NativeMethodInfoPtr_ComputeEyeCenterUV_Private_Static_Vector2_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000278B File Offset: 0x0000098B
		public XRView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002794 File Offset: 0x00000994
		public XRView()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRView>.NativeClassPtr))
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00011C84 File Offset: 0x0000FE84
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000027A6 File Offset: 0x000009A6
		public unsafe Matrix4x4 projMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_projMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_projMatrix)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00011CAC File Offset: 0x0000FEAC
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000027C1 File Offset: 0x000009C1
		public unsafe Matrix4x4 viewMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_viewMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_viewMatrix)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00011CD4 File Offset: 0x0000FED4
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000027DC File Offset: 0x000009DC
		public unsafe Rect viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_viewport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_viewport)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00011CFC File Offset: 0x0000FEFC
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000027F7 File Offset: 0x000009F7
		public unsafe Mesh occlusionMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_occlusionMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_occlusionMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00011D2C File Offset: 0x0000FF2C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002816 File Offset: 0x00000A16
		public unsafe int textureArraySlice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_textureArraySlice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_textureArraySlice)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00011D54 File Offset: 0x0000FF54
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002831 File Offset: 0x00000A31
		public unsafe Vector2 eyeCenterUV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_eyeCenterUV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRView.NativeFieldInfoPtr_eyeCenterUV)) = value;
			}
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_projMatrix;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_viewMatrix;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_viewport;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMesh;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_textureArraySlice;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_eyeCenterUV;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Matrix4x4_Matrix4x4_Rect_Mesh_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_ComputeEyeCenterUV_Private_Static_Vector2_Matrix4x4_0;
	}
}
