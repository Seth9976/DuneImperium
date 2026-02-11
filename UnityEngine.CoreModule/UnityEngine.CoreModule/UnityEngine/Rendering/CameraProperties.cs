using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022C RID: 556
	[StructLayout(2)]
	public struct CameraProperties
	{
		// Token: 0x0600253E RID: 9534 RVA: 0x0009EDA0 File Offset: 0x0009CFA0
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProperties()
		{
			Il2CppClassPointerStore<CameraProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CameraProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr);
			CameraProperties.NativeFieldInfoPtr_k_NumLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "k_NumLayers");
			CameraProperties.NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "screenRect");
			CameraProperties.NativeFieldInfoPtr_viewDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "viewDir");
			CameraProperties.NativeFieldInfoPtr_projectionNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionNear");
			CameraProperties.NativeFieldInfoPtr_projectionFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionFar");
			CameraProperties.NativeFieldInfoPtr_cameraNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraNear");
			CameraProperties.NativeFieldInfoPtr_cameraFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraFar");
			CameraProperties.NativeFieldInfoPtr_cameraAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraAspect");
			CameraProperties.NativeFieldInfoPtr_cameraToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraToWorld");
			CameraProperties.NativeFieldInfoPtr_actualWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "actualWorldToClip");
			CameraProperties.NativeFieldInfoPtr_cameraClipToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraClipToWorld");
			CameraProperties.NativeFieldInfoPtr_cameraWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraWorldToClip");
			CameraProperties.NativeFieldInfoPtr_implicitProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "implicitProjection");
			CameraProperties.NativeFieldInfoPtr_stereoWorldToClipLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "stereoWorldToClipLeft");
			CameraProperties.NativeFieldInfoPtr_stereoWorldToClipRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "stereoWorldToClipRight");
			CameraProperties.NativeFieldInfoPtr_worldToCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "worldToCamera");
			CameraProperties.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "up");
			CameraProperties.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "right");
			CameraProperties.NativeFieldInfoPtr_transformDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "transformDirection");
			CameraProperties.NativeFieldInfoPtr_cameraEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraEuler");
			CameraProperties.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "velocity");
			CameraProperties.NativeFieldInfoPtr_farPlaneWorldSpaceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "farPlaneWorldSpaceLength");
			CameraProperties.NativeFieldInfoPtr_rendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "rendererCount");
			CameraProperties.NativeFieldInfoPtr_k_PlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "k_PlaneCount");
			CameraProperties.NativeFieldInfoPtr_m_ShadowCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "m_ShadowCullPlanes");
			CameraProperties.NativeFieldInfoPtr_m_CameraCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "m_CameraCullPlanes");
			CameraProperties.NativeFieldInfoPtr_baseFarDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "baseFarDistance");
			CameraProperties.NativeFieldInfoPtr_shadowCullCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "shadowCullCenter");
			CameraProperties.NativeFieldInfoPtr_layerCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "layerCullDistances");
			CameraProperties.NativeFieldInfoPtr_layerCullSpherical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "layerCullSpherical");
			CameraProperties.NativeFieldInfoPtr_coreCameraValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "coreCameraValues");
			CameraProperties.NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraType");
			CameraProperties.NativeFieldInfoPtr_projectionIsOblique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionIsOblique");
			CameraProperties.NativeFieldInfoPtr_isImplicitProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "isImplicitProjectionMatrix");
			CameraProperties.NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668094);
			CameraProperties.NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668095);
			CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668096);
			CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668097);
			CameraProperties.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668098);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x0009F0DC File Offset: 0x0009D2DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 683368, RefRangeEnd = 683371, XrefRangeStart = 683368, XrefRangeEnd = 683368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetShadowCullingPlane(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0009F11C File Offset: 0x0009D31C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 683371, RefRangeEnd = 683374, XrefRangeStart = 683371, XrefRangeEnd = 683371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetCameraCullingPlane(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0009F15C File Offset: 0x0009D35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683407, RefRangeEnd = 683408, XrefRangeStart = 683374, XrefRangeEnd = 683407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CameraProperties other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0009F19C File Offset: 0x0009D39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683408, XrefRangeEnd = 683412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x0009F1E0 File Offset: 0x0009D3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683457, RefRangeEnd = 683458, XrefRangeStart = 683412, XrefRangeEnd = 683457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, ref this));
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x0009F210 File Offset: 0x0009D410
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x0000EBC2 File Offset: 0x0000CDC2
		public unsafe static int k_NumLayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CameraProperties.NativeFieldInfoPtr_k_NumLayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraProperties.NativeFieldInfoPtr_k_NumLayers, (void*)(&value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0009F22C File Offset: 0x0009D42C
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public unsafe static int k_PlaneCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CameraProperties.NativeFieldInfoPtr_k_PlaneCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraProperties.NativeFieldInfoPtr_k_PlaneCount, (void*)(&value));
			}
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0000EBDE File Offset: 0x0000CDDE
		public void SetShadowCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x0000EBEB File Offset: 0x0000CDEB
		public void SetCameraCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0009F248 File Offset: 0x0009D448
		public static bool operator ==(CameraProperties left, CameraProperties right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0009F264 File Offset: 0x0009D464
		public static bool operator !=(CameraProperties left, CameraProperties right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr_k_NumLayers;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_screenRect;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_viewDir;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_projectionNear;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_projectionFar;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeFieldInfoPtr_cameraNear;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_cameraFar;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_cameraAspect;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_cameraToWorld;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_actualWorldToClip;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_cameraClipToWorld;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_cameraWorldToClip;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_implicitProjection;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_stereoWorldToClipLeft;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_stereoWorldToClipRight;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_worldToCamera;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr_transformDirection;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeFieldInfoPtr_cameraEuler;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_farPlaneWorldSpaceLength;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_rendererCount;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr_k_PlaneCount;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCullPlanes;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraCullPlanes;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_baseFarDistance;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr_shadowCullCenter;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_layerCullDistances;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_layerCullSpherical;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_coreCameraValues;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_cameraType;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_projectionIsOblique;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_isImplicitProjectionMatrix;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002109 RID: 8457
		[FieldOffset(0)]
		public Rect screenRect;

		// Token: 0x0400210A RID: 8458
		[FieldOffset(16)]
		public Vector3 viewDir;

		// Token: 0x0400210B RID: 8459
		[FieldOffset(28)]
		public float projectionNear;

		// Token: 0x0400210C RID: 8460
		[FieldOffset(32)]
		public float projectionFar;

		// Token: 0x0400210D RID: 8461
		[FieldOffset(36)]
		public float cameraNear;

		// Token: 0x0400210E RID: 8462
		[FieldOffset(40)]
		public float cameraFar;

		// Token: 0x0400210F RID: 8463
		[FieldOffset(44)]
		public float cameraAspect;

		// Token: 0x04002110 RID: 8464
		[FieldOffset(48)]
		public Matrix4x4 cameraToWorld;

		// Token: 0x04002111 RID: 8465
		[FieldOffset(112)]
		public Matrix4x4 actualWorldToClip;

		// Token: 0x04002112 RID: 8466
		[FieldOffset(176)]
		public Matrix4x4 cameraClipToWorld;

		// Token: 0x04002113 RID: 8467
		[FieldOffset(240)]
		public Matrix4x4 cameraWorldToClip;

		// Token: 0x04002114 RID: 8468
		[FieldOffset(304)]
		public Matrix4x4 implicitProjection;

		// Token: 0x04002115 RID: 8469
		[FieldOffset(368)]
		public Matrix4x4 stereoWorldToClipLeft;

		// Token: 0x04002116 RID: 8470
		[FieldOffset(432)]
		public Matrix4x4 stereoWorldToClipRight;

		// Token: 0x04002117 RID: 8471
		[FieldOffset(496)]
		public Matrix4x4 worldToCamera;

		// Token: 0x04002118 RID: 8472
		[FieldOffset(560)]
		public Vector3 up;

		// Token: 0x04002119 RID: 8473
		[FieldOffset(572)]
		public Vector3 right;

		// Token: 0x0400211A RID: 8474
		[FieldOffset(584)]
		public Vector3 transformDirection;

		// Token: 0x0400211B RID: 8475
		[FieldOffset(596)]
		public Vector3 cameraEuler;

		// Token: 0x0400211C RID: 8476
		[FieldOffset(608)]
		public Vector3 velocity;

		// Token: 0x0400211D RID: 8477
		[FieldOffset(620)]
		public float farPlaneWorldSpaceLength;

		// Token: 0x0400211E RID: 8478
		[FieldOffset(624)]
		public uint rendererCount;

		// Token: 0x0400211F RID: 8479
		[FieldOffset(628)]
		public CameraProperties._m_ShadowCullPlanes_e__FixedBuffer m_ShadowCullPlanes;

		// Token: 0x04002120 RID: 8480
		[FieldOffset(724)]
		public CameraProperties._m_CameraCullPlanes_e__FixedBuffer m_CameraCullPlanes;

		// Token: 0x04002121 RID: 8481
		[FieldOffset(820)]
		public float baseFarDistance;

		// Token: 0x04002122 RID: 8482
		[FieldOffset(824)]
		public Vector3 shadowCullCenter;

		// Token: 0x04002123 RID: 8483
		[FieldOffset(836)]
		public CameraProperties._layerCullDistances_e__FixedBuffer layerCullDistances;

		// Token: 0x04002124 RID: 8484
		[FieldOffset(964)]
		public int layerCullSpherical;

		// Token: 0x04002125 RID: 8485
		[FieldOffset(968)]
		public CoreCameraValues coreCameraValues;

		// Token: 0x04002126 RID: 8486
		[FieldOffset(980)]
		public uint cameraType;

		// Token: 0x04002127 RID: 8487
		[FieldOffset(984)]
		public int projectionIsOblique;

		// Token: 0x04002128 RID: 8488
		[FieldOffset(988)]
		public int isImplicitProjectionMatrix;

		// Token: 0x020009D1 RID: 2513
		[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<layerCullDistances>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _layerCullDistances_e__FixedBuffer
		{
			// Token: 0x06003CC0 RID: 15552 RVA: 0x0001653E File Offset: 0x0001473E
			// Note: this type is marked as 'beforefieldinit'.
			static _layerCullDistances_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<layerCullDistances>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr);
				CameraProperties._layerCullDistances_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CC1 RID: 15553 RVA: 0x00016572 File Offset: 0x00014772
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D22 RID: 11554
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D23 RID: 11555
			[FieldOffset(0)]
			public float FixedElementField;
		}

		// Token: 0x020009D2 RID: 2514
		[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_CameraCullPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_CameraCullPlanes_e__FixedBuffer
		{
			// Token: 0x06003CC2 RID: 15554 RVA: 0x00016584 File Offset: 0x00014784
			// Note: this type is marked as 'beforefieldinit'.
			static _m_CameraCullPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_CameraCullPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr);
				CameraProperties._m_CameraCullPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CC3 RID: 15555 RVA: 0x000165B8 File Offset: 0x000147B8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D24 RID: 11556
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D25 RID: 11557
			[FieldOffset(0)]
			public byte FixedElementField;
		}

		// Token: 0x020009D3 RID: 2515
		[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_ShadowCullPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_ShadowCullPlanes_e__FixedBuffer
		{
			// Token: 0x06003CC4 RID: 15556 RVA: 0x000165CA File Offset: 0x000147CA
			// Note: this type is marked as 'beforefieldinit'.
			static _m_ShadowCullPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_ShadowCullPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr);
				CameraProperties._m_ShadowCullPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CC5 RID: 15557 RVA: 0x000165FE File Offset: 0x000147FE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D26 RID: 11558
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D27 RID: 11559
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
