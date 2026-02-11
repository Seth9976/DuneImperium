using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022E RID: 558
	[StructLayout(2)]
	public struct ScriptableCullingParameters
	{
		// Token: 0x0600254D RID: 9549 RVA: 0x0009F284 File Offset: 0x0009D484
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableCullingParameters()
		{
			Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableCullingParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr);
			ScriptableCullingParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_IsOrthographic");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_LODParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LODParameters");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_MaximumCullingPlaneCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "maximumCullingPlaneCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingPlanes");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingPlaneCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingMask");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_SceneMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_SceneMask");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ViewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ViewID");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_LayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_LayerCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_layerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "layerCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_LayerFarCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LayerFarCullDistances");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_LayerCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LayerCull");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingMatrix");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_Origin");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ShadowDistance");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ShadowNearPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ShadowNearPlaneOffset");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingOptions");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ReflectionProbeSortingCriteria");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CameraProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CameraProperties");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_AccurateOcclusionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_AccurateOcclusionThreshold");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_MaximumPortalCullingJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_MaximumPortalCullingJobs");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountLowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_CullingJobCountLowerLimit");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountUpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_CullingJobCountUpperLimit");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoViewMatrix");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoProjectionMatrix");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoSeparationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoSeparationDistance");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_maximumVisibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_maximumVisibleLights");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ConservativeEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ConservativeEnclosingSphere");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_NumIterationsEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_NumIterationsEnclosingSphere");
			ScriptableCullingParameters.NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668099);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668100);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668101);
			ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668102);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668103);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668104);
			ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668105);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668106);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668107);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668108);
			ScriptableCullingParameters.NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668109);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668110);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668111);
			ScriptableCullingParameters.NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668112);
			ScriptableCullingParameters.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668113);
			ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668114);
			ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668115);
			ScriptableCullingParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668116);
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0009FAE8 File Offset: 0x0009DCE8
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x0009F674 File Offset: 0x0009D874
		public unsafe int maximumVisibleLights
		{
			get
			{
				return this.m_maximumVisibleLights;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683458, RefRangeEnd = 683460, XrefRangeStart = 683458, XrefRangeEnd = 683458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x0009FB00 File Offset: 0x0009DD00
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x0009F6A8 File Offset: 0x0009D8A8
		public unsafe bool conservativeEnclosingSphere
		{
			get
			{
				return this.m_ConservativeEnclosingSphere;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683460, RefRangeEnd = 683461, XrefRangeStart = 683460, XrefRangeEnd = 683460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0009FB18 File Offset: 0x0009DD18
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0009F6DC File Offset: 0x0009D8DC
		public unsafe int numIterationsEnclosingSphere
		{
			get
			{
				return this.m_NumIterationsEnclosingSphere;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683461, RefRangeEnd = 683462, XrefRangeStart = 683461, XrefRangeEnd = 683461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x0009F710 File Offset: 0x0009D910
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x0009FB30 File Offset: 0x0009DD30
		public unsafe int cullingPlaneCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683462, RefRangeEnd = 683463, XrefRangeStart = 683462, XrefRangeEnd = 683462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value < 0 || value > 10;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Format("{0} was {1}, but must be at least 0 and less than {2}", "value", value, 10));
				}
				this.m_CullingPlaneCount = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0009FB78 File Offset: 0x0009DD78
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x0009F740 File Offset: 0x0009D940
		public unsafe bool isOrthographic
		{
			get
			{
				return Convert.ToBoolean(this.m_IsOrthographic);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683467, RefRangeEnd = 683468, XrefRangeStart = 683463, XrefRangeEnd = 683467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x0009FBF8 File Offset: 0x0009DDF8
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x0009F774 File Offset: 0x0009D974
		public unsafe float shadowDistance
		{
			get
			{
				return this.m_ShadowDistance;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683468, RefRangeEnd = 683470, XrefRangeStart = 683468, XrefRangeEnd = 683468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x0009F7A8 File Offset: 0x0009D9A8
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		public unsafe CullingOptions cullingOptions
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 683470, RefRangeEnd = 683476, XrefRangeStart = 683470, XrefRangeEnd = 683470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 683476, RefRangeEnd = 683483, XrefRangeStart = 683476, XrefRangeEnd = 683476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x0009FC28 File Offset: 0x0009DE28
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x0009F80C File Offset: 0x0009DA0C
		public unsafe ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
		{
			get
			{
				return this.m_ReflectionProbeSortingCriteria;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683483, RefRangeEnd = 683484, XrefRangeStart = 683483, XrefRangeEnd = 683483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x0009FC58 File Offset: 0x0009DE58
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x0009F840 File Offset: 0x0009DA40
		public unsafe Matrix4x4 stereoViewMatrix
		{
			get
			{
				return this.m_StereoViewMatrix;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683484, RefRangeEnd = 683485, XrefRangeStart = 683484, XrefRangeEnd = 683484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x0009F874 File Offset: 0x0009DA74
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
		public unsafe Matrix4x4 stereoProjectionMatrix
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683485, RefRangeEnd = 683486, XrefRangeStart = 683485, XrefRangeEnd = 683485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x0009FC70 File Offset: 0x0009DE70
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x0009F8D8 File Offset: 0x0009DAD8
		public unsafe float stereoSeparationDistance
		{
			get
			{
				return this.m_StereoSeparationDistance;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683486, RefRangeEnd = 683487, XrefRangeStart = 683486, XrefRangeEnd = 683486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0009F90C File Offset: 0x0009DB0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683487, RefRangeEnd = 683489, XrefRangeStart = 683487, XrefRangeEnd = 683487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLayerCullingDistance(int layerIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x0009F94C File Offset: 0x0009DB4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 683492, RefRangeEnd = 683495, XrefRangeStart = 683489, XrefRangeEnd = 683492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetCullingPlane(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0009F98C File Offset: 0x0009DB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683513, RefRangeEnd = 683514, XrefRangeStart = 683495, XrefRangeEnd = 683513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptableCullingParameters other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0009F9CC File Offset: 0x0009DBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683514, XrefRangeEnd = 683521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0009FA10 File Offset: 0x0009DC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683521, XrefRangeEnd = 683541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x0009FA40 File Offset: 0x0009DC40
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x0000EC0A File Offset: 0x0000CE0A
		public unsafe static int k_MaximumCullingPlaneCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0009FA5C File Offset: 0x0009DC5C
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x0000EC18 File Offset: 0x0000CE18
		public unsafe static int maximumCullingPlaneCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0009FA78 File Offset: 0x0009DC78
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x0000EC26 File Offset: 0x0000CE26
		public unsafe static int k_LayerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_LayerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_LayerCount, (void*)(&value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0009FA94 File Offset: 0x0009DC94
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x0000EC34 File Offset: 0x0000CE34
		public unsafe static int layerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_layerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_layerCount, (void*)(&value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0009FAB0 File Offset: 0x0009DCB0
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x0000EC42 File Offset: 0x0000CE42
		public unsafe static int k_CullingJobCountLowerLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountLowerLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountLowerLimit, (void*)(&value));
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0009FACC File Offset: 0x0009DCCC
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x0000EC50 File Offset: 0x0000CE50
		public unsafe static int k_CullingJobCountUpperLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountUpperLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountUpperLimit, (void*)(&value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0009FB98 File Offset: 0x0009DD98
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x0000EC5E File Offset: 0x0000CE5E
		public LODParameters lodParameters
		{
			get
			{
				return this.m_LODParameters;
			}
			set
			{
				this.m_LODParameters = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x0009FBB0 File Offset: 0x0009DDB0
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x0000EC68 File Offset: 0x0000CE68
		public uint cullingMask
		{
			get
			{
				return this.m_CullingMask;
			}
			set
			{
				this.m_CullingMask = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x0009FBC8 File Offset: 0x0009DDC8
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0000EC72 File Offset: 0x0000CE72
		public Matrix4x4 cullingMatrix
		{
			get
			{
				return this.m_CullingMatrix;
			}
			set
			{
				this.m_CullingMatrix = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x0009FBE0 File Offset: 0x0009DDE0
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		public Vector3 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x0009FC10 File Offset: 0x0009DE10
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x0000EC86 File Offset: 0x0000CE86
		public float shadowNearPlaneOffset
		{
			get
			{
				return this.m_ShadowNearPlaneOffset;
			}
			set
			{
				this.m_ShadowNearPlaneOffset = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0009FC40 File Offset: 0x0009DE40
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0000EC90 File Offset: 0x0000CE90
		public CameraProperties cameraProperties
		{
			get
			{
				return this.m_CameraProperties;
			}
			set
			{
				this.m_CameraProperties = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x0009FC88 File Offset: 0x0009DE88
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x0000EC9A File Offset: 0x0000CE9A
		public float accurateOcclusionThreshold
		{
			get
			{
				return this.m_AccurateOcclusionThreshold;
			}
			set
			{
				this.m_AccurateOcclusionThreshold = Mathf.Max(-1f, value);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0009FCA0 File Offset: 0x0009DEA0
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0000ECAE File Offset: 0x0000CEAE
		public int maximumPortalCullingJobs
		{
			get
			{
				return this.m_MaximumPortalCullingJobs;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		public static int cullingJobsLowerLimit
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x0009FCCC File Offset: 0x0009DECC
		public static int cullingJobsUpperLimit
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0000ECBB File Offset: 0x0000CEBB
		public void SetLayerCullingDistance(int layerIndex, float distance)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		public void SetCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0009FCE0 File Offset: 0x0009DEE0
		public static bool operator ==(ScriptableCullingParameters left, ScriptableCullingParameters right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0009FCFC File Offset: 0x0009DEFC
		public static bool operator !=(ScriptableCullingParameters left, ScriptableCullingParameters right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOrthographic;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeFieldInfoPtr_m_LODParameters;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlanes;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMask;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeFieldInfoPtr_m_SceneMask;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewID;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeFieldInfoPtr_k_LayerCount;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeFieldInfoPtr_layerCount;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerFarCullDistances;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerCull;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMatrix;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeFieldInfoPtr_m_Origin;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowDistance;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowNearPlaneOffset;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingOptions;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraProperties;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeFieldInfoPtr_m_AccurateOcclusionThreshold;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeFieldInfoPtr_m_MaximumPortalCullingJobs;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeFieldInfoPtr_k_CullingJobCountLowerLimit;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeFieldInfoPtr_k_CullingJobCountUpperLimit;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeFieldInfoPtr_m_StereoViewMatrix;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeFieldInfoPtr_m_StereoProjectionMatrix;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeFieldInfoPtr_m_StereoSeparationDistance;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeFieldInfoPtr_m_maximumVisibleLights;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeFieldInfoPtr_m_ConservativeEnclosingSphere;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeFieldInfoPtr_m_NumIterationsEnclosingSphere;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002162 RID: 8546
		[FieldOffset(0)]
		public int m_IsOrthographic;

		// Token: 0x04002163 RID: 8547
		[FieldOffset(4)]
		public LODParameters m_LODParameters;

		// Token: 0x04002164 RID: 8548
		[FieldOffset(32)]
		public ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer m_CullingPlanes;

		// Token: 0x04002165 RID: 8549
		[FieldOffset(192)]
		public int m_CullingPlaneCount;

		// Token: 0x04002166 RID: 8550
		[FieldOffset(196)]
		public uint m_CullingMask;

		// Token: 0x04002167 RID: 8551
		[FieldOffset(200)]
		public ulong m_SceneMask;

		// Token: 0x04002168 RID: 8552
		[FieldOffset(208)]
		public ulong m_ViewID;

		// Token: 0x04002169 RID: 8553
		[FieldOffset(216)]
		public ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer m_LayerFarCullDistances;

		// Token: 0x0400216A RID: 8554
		[FieldOffset(344)]
		public int m_LayerCull;

		// Token: 0x0400216B RID: 8555
		[FieldOffset(348)]
		public Matrix4x4 m_CullingMatrix;

		// Token: 0x0400216C RID: 8556
		[FieldOffset(412)]
		public Vector3 m_Origin;

		// Token: 0x0400216D RID: 8557
		[FieldOffset(424)]
		public float m_ShadowDistance;

		// Token: 0x0400216E RID: 8558
		[FieldOffset(428)]
		public float m_ShadowNearPlaneOffset;

		// Token: 0x0400216F RID: 8559
		[FieldOffset(432)]
		public CullingOptions m_CullingOptions;

		// Token: 0x04002170 RID: 8560
		[FieldOffset(436)]
		public ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;

		// Token: 0x04002171 RID: 8561
		[FieldOffset(440)]
		public CameraProperties m_CameraProperties;

		// Token: 0x04002172 RID: 8562
		[FieldOffset(1432)]
		public float m_AccurateOcclusionThreshold;

		// Token: 0x04002173 RID: 8563
		[FieldOffset(1436)]
		public int m_MaximumPortalCullingJobs;

		// Token: 0x04002174 RID: 8564
		[FieldOffset(1440)]
		public Matrix4x4 m_StereoViewMatrix;

		// Token: 0x04002175 RID: 8565
		[FieldOffset(1504)]
		public Matrix4x4 m_StereoProjectionMatrix;

		// Token: 0x04002176 RID: 8566
		[FieldOffset(1568)]
		public float m_StereoSeparationDistance;

		// Token: 0x04002177 RID: 8567
		[FieldOffset(1572)]
		public int m_maximumVisibleLights;

		// Token: 0x04002178 RID: 8568
		[FieldOffset(1576)]
		[MarshalAs(4)]
		public bool m_ConservativeEnclosingSphere;

		// Token: 0x04002179 RID: 8569
		[FieldOffset(1580)]
		public int m_NumIterationsEnclosingSphere;

		// Token: 0x020009D4 RID: 2516
		[ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_CullingPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_CullingPlanes_e__FixedBuffer
		{
			// Token: 0x06003CC6 RID: 15558 RVA: 0x00016610 File Offset: 0x00014810
			// Note: this type is marked as 'beforefieldinit'.
			static _m_CullingPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
				ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CC7 RID: 15559 RVA: 0x00016644 File Offset: 0x00014844
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D28 RID: 11560
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D29 RID: 11561
			[FieldOffset(0)]
			public byte FixedElementField;
		}

		// Token: 0x020009D5 RID: 2517
		[ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_LayerFarCullDistances>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_LayerFarCullDistances_e__FixedBuffer
		{
			// Token: 0x06003CC8 RID: 15560 RVA: 0x00016656 File Offset: 0x00014856
			// Note: this type is marked as 'beforefieldinit'.
			static _m_LayerFarCullDistances_e__FixedBuffer()
			{
				Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_LayerFarCullDistances>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr);
				ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003CC9 RID: 15561 RVA: 0x0001668A File Offset: 0x0001488A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D2A RID: 11562
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002D2B RID: 11563
			[FieldOffset(0)]
			public float FixedElementField;
		}
	}
}
