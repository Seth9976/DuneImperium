using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000039 RID: 57
	public class ShadowCaster2D : ShadowCasterGroup2D
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x000274D4 File Offset: 0x000256D4
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowCaster2D()
		{
			Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowCaster2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr);
			ShadowCaster2D.NativeFieldInfoPtr_k_CurrentComponentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "k_CurrentComponentVersion");
			ShadowCaster2D.NativeFieldInfoPtr_m_ComponentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_ComponentVersion");
			ShadowCaster2D.NativeFieldInfoPtr_m_HasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_HasRenderer");
			ShadowCaster2D.NativeFieldInfoPtr_m_UseRendererSilhouette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_UseRendererSilhouette");
			ShadowCaster2D.NativeFieldInfoPtr_m_CastsShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CastsShadows");
			ShadowCaster2D.NativeFieldInfoPtr_m_SelfShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_SelfShadows");
			ShadowCaster2D.NativeFieldInfoPtr_m_ApplyToSortingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_ApplyToSortingLayers");
			ShadowCaster2D.NativeFieldInfoPtr_m_ShapePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_ShapePath");
			ShadowCaster2D.NativeFieldInfoPtr_m_ShapePathHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_ShapePathHash");
			ShadowCaster2D.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_Mesh");
			ShadowCaster2D.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_InstanceId");
			ShadowCaster2D.NativeFieldInfoPtr_m_ShadowCasterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_ShadowCasterGroup");
			ShadowCaster2D.NativeFieldInfoPtr_m_PreviousShadowCasterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_PreviousShadowCasterGroup");
			ShadowCaster2D.NativeFieldInfoPtr_m_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_LocalBounds");
			ShadowCaster2D.NativeFieldInfoPtr_m_BoundingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_BoundingSphere");
			ShadowCaster2D.NativeFieldInfoPtr_m_PreviousShadowGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_PreviousShadowGroup");
			ShadowCaster2D.NativeFieldInfoPtr_m_PreviousCastsShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_PreviousCastsShadows");
			ShadowCaster2D.NativeFieldInfoPtr_m_PreviousPathHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_PreviousPathHash");
			ShadowCaster2D.NativeFieldInfoPtr_m_CachedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CachedPosition");
			ShadowCaster2D.NativeFieldInfoPtr_m_CachedLossyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CachedLossyScale");
			ShadowCaster2D.NativeFieldInfoPtr_m_CachedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CachedRotation");
			ShadowCaster2D.NativeFieldInfoPtr_m_CachedShadowMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CachedShadowMatrix");
			ShadowCaster2D.NativeFieldInfoPtr_m_CachedInverseShadowMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CachedInverseShadowMatrix");
			ShadowCaster2D.NativeFieldInfoPtr_m_CachedLocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, "m_CachedLocalToWorldMatrix");
			ShadowCaster2D.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663890);
			ShadowCaster2D.NativeMethodInfoPtr_get_shapePath_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663891);
			ShadowCaster2D.NativeMethodInfoPtr_get_shapePathHash_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663892);
			ShadowCaster2D.NativeMethodInfoPtr_set_shapePathHash_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663893);
			ShadowCaster2D.NativeMethodInfoPtr_CacheValues_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663894);
			ShadowCaster2D.NativeMethodInfoPtr_set_useRendererSilhouette_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663895);
			ShadowCaster2D.NativeMethodInfoPtr_get_useRendererSilhouette_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663896);
			ShadowCaster2D.NativeMethodInfoPtr_set_selfShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663897);
			ShadowCaster2D.NativeMethodInfoPtr_get_selfShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663898);
			ShadowCaster2D.NativeMethodInfoPtr_set_castsShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663899);
			ShadowCaster2D.NativeMethodInfoPtr_get_castsShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663900);
			ShadowCaster2D.NativeMethodInfoPtr_SetDefaultSortingLayers_Private_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663901);
			ShadowCaster2D.NativeMethodInfoPtr_IsLit_Internal_Boolean_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663902);
			ShadowCaster2D.NativeMethodInfoPtr_IsShadowedLayer_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663903);
			ShadowCaster2D.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663904);
			ShadowCaster2D.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663905);
			ShadowCaster2D.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663906);
			ShadowCaster2D.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663907);
			ShadowCaster2D.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663908);
			ShadowCaster2D.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663909);
			ShadowCaster2D.NativeMethodInfoPtr_UpdateBoundingSphere_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663910);
			ShadowCaster2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr, 100663911);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0002789C File Offset: 0x00025A9C
		public unsafe Mesh mesh
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000278DC File Offset: 0x00025ADC
		public unsafe Il2CppStructArray<Vector3> shapePath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_get_shapePath_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0002791C File Offset: 0x00025B1C
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00027958 File Offset: 0x00025B58
		public unsafe int shapePathHash
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_get_shapePathHash_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_set_shapePathHash_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00027998 File Offset: 0x00025B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602225, XrefRangeEnd = 602237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CacheValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShadowCaster2D.NativeMethodInfoPtr_CacheValues_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00027A14 File Offset: 0x00025C14
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x000279D4 File Offset: 0x00025BD4
		public unsafe bool useRendererSilhouette
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_get_useRendererSilhouette_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_set_useRendererSilhouette_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00027A90 File Offset: 0x00025C90
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00027A50 File Offset: 0x00025C50
		public unsafe bool selfShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_get_selfShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_set_selfShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00027B0C File Offset: 0x00025D0C
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00027ACC File Offset: 0x00025CCC
		public unsafe bool castsShadows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_get_castsShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_set_castsShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00027B48 File Offset: 0x00025D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602237, XrefRangeEnd = 602243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> SetDefaultSortingLayers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_SetDefaultSortingLayers_Private_Static_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00027B7C File Offset: 0x00025D7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 602243, RefRangeEnd = 602248, XrefRangeStart = 602243, XrefRangeEnd = 602243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLit(Light2D light)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_IsLit_Internal_Boolean_Light2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00027BCC File Offset: 0x00025DCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 602251, RefRangeEnd = 602257, XrefRangeStart = 602248, XrefRangeEnd = 602251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsShadowedLayer(int layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_IsShadowedLayer_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00027C18 File Offset: 0x00025E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602257, XrefRangeEnd = 602305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00027C4C File Offset: 0x00025E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602305, XrefRangeEnd = 602318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00027C80 File Offset: 0x00025E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602318, XrefRangeEnd = 602319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00027CB4 File Offset: 0x00025EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602319, XrefRangeEnd = 602345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00027CE8 File Offset: 0x00025EE8
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00027D1C File Offset: 0x00025F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602345, XrefRangeEnd = 602346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00027D50 File Offset: 0x00025F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602356, RefRangeEnd = 602357, XrefRangeStart = 602346, XrefRangeEnd = 602356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundingSphere()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr_UpdateBoundingSphere_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00027D84 File Offset: 0x00025F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602357, XrefRangeEnd = 602358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowCaster2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCaster2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowCaster2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00004403 File Offset: 0x00002603
		public ShadowCaster2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00027DC0 File Offset: 0x00025FC0
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000440C File Offset: 0x0000260C
		public unsafe static ShadowCaster2D.ComponentVersions k_CurrentComponentVersion
		{
			get
			{
				ShadowCaster2D.ComponentVersions componentVersions;
				IL2CPP.il2cpp_field_static_get_value(ShadowCaster2D.NativeFieldInfoPtr_k_CurrentComponentVersion, (void*)(&componentVersions));
				return componentVersions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowCaster2D.NativeFieldInfoPtr_k_CurrentComponentVersion, (void*)(&value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00027DDC File Offset: 0x00025FDC
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x0000441A File Offset: 0x0000261A
		public unsafe ShadowCaster2D.ComponentVersions m_ComponentVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ComponentVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ComponentVersion)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00027E04 File Offset: 0x00026004
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00004435 File Offset: 0x00002635
		public unsafe bool m_HasRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_HasRenderer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_HasRenderer)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00027E2C File Offset: 0x0002602C
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00004450 File Offset: 0x00002650
		public unsafe bool m_UseRendererSilhouette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_UseRendererSilhouette);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_UseRendererSilhouette)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00027E54 File Offset: 0x00026054
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0000446B File Offset: 0x0000266B
		public unsafe bool m_CastsShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CastsShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CastsShadows)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00027E7C File Offset: 0x0002607C
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00004486 File Offset: 0x00002686
		public unsafe bool m_SelfShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_SelfShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_SelfShadows)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00027EA4 File Offset: 0x000260A4
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x000044A1 File Offset: 0x000026A1
		public unsafe Il2CppStructArray<int> m_ApplyToSortingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ApplyToSortingLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ApplyToSortingLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00027ED4 File Offset: 0x000260D4
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x000044C0 File Offset: 0x000026C0
		public unsafe Il2CppStructArray<Vector3> m_ShapePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ShapePath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ShapePath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00027F04 File Offset: 0x00026104
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000044DF File Offset: 0x000026DF
		public unsafe int m_ShapePathHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ShapePathHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ShapePathHash)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00027F2C File Offset: 0x0002612C
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x000044FA File Offset: 0x000026FA
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00027F5C File Offset: 0x0002615C
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00004519 File Offset: 0x00002719
		public unsafe int m_InstanceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_InstanceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_InstanceId)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00027F84 File Offset: 0x00026184
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00004534 File Offset: 0x00002734
		public unsafe ShadowCasterGroup2D m_ShadowCasterGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ShadowCasterGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowCasterGroup2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_ShadowCasterGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00027FB4 File Offset: 0x000261B4
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00004553 File Offset: 0x00002753
		public unsafe ShadowCasterGroup2D m_PreviousShadowCasterGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousShadowCasterGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowCasterGroup2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousShadowCasterGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00027FE4 File Offset: 0x000261E4
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00004572 File Offset: 0x00002772
		public unsafe Bounds m_LocalBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_LocalBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_LocalBounds)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0002800C File Offset: 0x0002620C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x0000458D File Offset: 0x0000278D
		public unsafe BoundingSphere m_BoundingSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_BoundingSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_BoundingSphere)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00028034 File Offset: 0x00026234
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x000045A8 File Offset: 0x000027A8
		public unsafe int m_PreviousShadowGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousShadowGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousShadowGroup)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0002805C File Offset: 0x0002625C
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x000045C3 File Offset: 0x000027C3
		public unsafe bool m_PreviousCastsShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousCastsShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousCastsShadows)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00028084 File Offset: 0x00026284
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x000045DE File Offset: 0x000027DE
		public unsafe int m_PreviousPathHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousPathHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_PreviousPathHash)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x000280AC File Offset: 0x000262AC
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x000045F9 File Offset: 0x000027F9
		public unsafe Vector3 m_CachedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedPosition)) = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x000280D4 File Offset: 0x000262D4
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00004614 File Offset: 0x00002814
		public unsafe Vector3 m_CachedLossyScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedLossyScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedLossyScale)) = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x000280FC File Offset: 0x000262FC
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x0000462F File Offset: 0x0000282F
		public unsafe Quaternion m_CachedRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedRotation)) = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00028124 File Offset: 0x00026324
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x0000464A File Offset: 0x0000284A
		public unsafe Matrix4x4 m_CachedShadowMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedShadowMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedShadowMatrix)) = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0002814C File Offset: 0x0002634C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00004665 File Offset: 0x00002865
		public unsafe Matrix4x4 m_CachedInverseShadowMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedInverseShadowMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedInverseShadowMatrix)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00028174 File Offset: 0x00026374
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00004680 File Offset: 0x00002880
		public unsafe Matrix4x4 m_CachedLocalToWorldMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedLocalToWorldMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowCaster2D.NativeFieldInfoPtr_m_CachedLocalToWorldMatrix)) = value;
			}
		}

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_k_CurrentComponentVersion;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentVersion;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRenderer;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_m_UseRendererSilhouette;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_m_CastsShadows;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_m_SelfShadows;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyToSortingLayers;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapePath;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_m_ShapePathHash;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceId;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCasterGroup;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShadowCasterGroup;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalBounds;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_m_BoundingSphere;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousShadowGroup;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousCastsShadows;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPathHash;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedPosition;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedLossyScale;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedRotation;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedShadowMatrix;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedInverseShadowMatrix;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedLocalToWorldMatrix;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_shapePath_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_get_shapePathHash_Internal_get_Int32_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_set_shapePathHash_Internal_set_Void_Int32_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_CacheValues_Internal_Virtual_Void_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_set_useRendererSilhouette_Public_set_Void_Boolean_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_get_useRendererSilhouette_Public_get_Boolean_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_set_selfShadows_Public_set_Void_Boolean_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_get_selfShadows_Public_get_Boolean_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_set_castsShadows_Public_set_Void_Boolean_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_get_castsShadows_Public_get_Boolean_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultSortingLayers_Private_Static_Il2CppStructArray_1_Int32_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_IsLit_Internal_Boolean_Light2D_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_IsShadowedLayer_Internal_Boolean_Int32_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundingSphere_Private_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000162 RID: 354
		public enum ComponentVersions
		{
			// Token: 0x04001427 RID: 5159
			Version_Unserialized,
			// Token: 0x04001428 RID: 5160
			Version_1
		}
	}
}
