using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	// Token: 0x02000006 RID: 6
	public class PixelPerfectCamera : MonoBehaviour
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00015A04 File Offset: 0x00013C04
		// Note: this type is marked as 'beforefieldinit'.
		static PixelPerfectCamera()
		{
			Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Experimental.Rendering.Universal", "PixelPerfectCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr);
			PixelPerfectCamera.NativeFieldInfoPtr_m_AssetsPPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_AssetsPPU");
			PixelPerfectCamera.NativeFieldInfoPtr_m_RefResolutionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_RefResolutionX");
			PixelPerfectCamera.NativeFieldInfoPtr_m_RefResolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_RefResolutionY");
			PixelPerfectCamera.NativeFieldInfoPtr_m_CropFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_CropFrame");
			PixelPerfectCamera.NativeFieldInfoPtr_m_GridSnapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_GridSnapping");
			PixelPerfectCamera.NativeFieldInfoPtr_m_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_FilterMode");
			PixelPerfectCamera.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_Camera");
			PixelPerfectCamera.NativeFieldInfoPtr_m_Internal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_Internal");
			PixelPerfectCamera.NativeFieldInfoPtr_m_CinemachineCompatibilityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, "m_CinemachineCompatibilityMode");
			PixelPerfectCamera.NativeMethodInfoPtr_get_cropFrame_Public_get_CropFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663318);
			PixelPerfectCamera.NativeMethodInfoPtr_set_cropFrame_Public_set_Void_CropFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663319);
			PixelPerfectCamera.NativeMethodInfoPtr_get_gridSnapping_Public_get_GridSnapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663320);
			PixelPerfectCamera.NativeMethodInfoPtr_set_gridSnapping_Public_set_Void_GridSnapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663321);
			PixelPerfectCamera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663322);
			PixelPerfectCamera.NativeMethodInfoPtr_get_assetsPPU_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663323);
			PixelPerfectCamera.NativeMethodInfoPtr_set_assetsPPU_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663324);
			PixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionX_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663325);
			PixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionX_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663326);
			PixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionY_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663327);
			PixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionY_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663328);
			PixelPerfectCamera.NativeMethodInfoPtr_get_upscaleRT_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663329);
			PixelPerfectCamera.NativeMethodInfoPtr_set_upscaleRT_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663330);
			PixelPerfectCamera.NativeMethodInfoPtr_get_pixelSnapping_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663331);
			PixelPerfectCamera.NativeMethodInfoPtr_set_pixelSnapping_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663332);
			PixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameX_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663333);
			PixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameX_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663334);
			PixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameY_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663335);
			PixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameY_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663336);
			PixelPerfectCamera.NativeMethodInfoPtr_get_stretchFill_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663337);
			PixelPerfectCamera.NativeMethodInfoPtr_set_stretchFill_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663338);
			PixelPerfectCamera.NativeMethodInfoPtr_get_pixelRatio_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663339);
			PixelPerfectCamera.NativeMethodInfoPtr_get_requiresUpscalePass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663340);
			PixelPerfectCamera.NativeMethodInfoPtr_RoundToPixel_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663341);
			PixelPerfectCamera.NativeMethodInfoPtr_CorrectCinemachineOrthoSize_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663342);
			PixelPerfectCamera.NativeMethodInfoPtr_get_finalBlitFilterMode_Internal_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663343);
			PixelPerfectCamera.NativeMethodInfoPtr_get_offscreenRTSize_Internal_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663344);
			PixelPerfectCamera.NativeMethodInfoPtr_get_cameraRTSize_Private_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663345);
			PixelPerfectCamera.NativeMethodInfoPtr_PixelSnap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663346);
			PixelPerfectCamera.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663347);
			PixelPerfectCamera.NativeMethodInfoPtr_UpdateCameraProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663348);
			PixelPerfectCamera.NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663349);
			PixelPerfectCamera.NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663350);
			PixelPerfectCamera.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663351);
			PixelPerfectCamera.NativeMethodInfoPtr_OnDisable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663352);
			PixelPerfectCamera.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663353);
			PixelPerfectCamera.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663354);
			PixelPerfectCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr, 100663355);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00015DE0 File Offset: 0x00013FE0
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00015E1C File Offset: 0x0001401C
		public unsafe PixelPerfectCamera.CropFrame cropFrame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_cropFrame_Public_get_CropFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_cropFrame_Public_set_Void_CropFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00015E5C File Offset: 0x0001405C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00015E98 File Offset: 0x00014098
		public unsafe PixelPerfectCamera.GridSnapping gridSnapping
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_gridSnapping_Public_get_GridSnapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_gridSnapping_Public_set_Void_GridSnapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00015ED8 File Offset: 0x000140D8
		public unsafe float orthographicSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00015F14 File Offset: 0x00014114
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00015F50 File Offset: 0x00014150
		public unsafe virtual int assetsPPU
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_assetsPPU_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_assetsPPU_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00015F90 File Offset: 0x00014190
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00015FCC File Offset: 0x000141CC
		public unsafe virtual int refResolutionX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionX_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionX_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0001600C File Offset: 0x0001420C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00016048 File Offset: 0x00014248
		public unsafe virtual int refResolutionY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_refResolutionY_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_refResolutionY_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00016088 File Offset: 0x00014288
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000160C4 File Offset: 0x000142C4
		public unsafe virtual bool upscaleRT
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_upscaleRT_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_upscaleRT_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00016104 File Offset: 0x00014304
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00016140 File Offset: 0x00014340
		public unsafe virtual bool pixelSnapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_pixelSnapping_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_pixelSnapping_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00016180 File Offset: 0x00014380
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000161BC File Offset: 0x000143BC
		public unsafe virtual bool cropFrameX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameX_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameX_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000161FC File Offset: 0x000143FC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00016238 File Offset: 0x00014438
		public unsafe virtual bool cropFrameY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_cropFrameY_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_cropFrameY_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00016278 File Offset: 0x00014478
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000162B4 File Offset: 0x000144B4
		public unsafe virtual bool stretchFill
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_stretchFill_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_set_stretchFill_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000162F4 File Offset: 0x000144F4
		public unsafe int pixelRatio
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 596500, RefRangeEnd = 596502, XrefRangeStart = 596500, XrefRangeEnd = 596500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_pixelRatio_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00016330 File Offset: 0x00014530
		public unsafe bool requiresUpscalePass
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 596502, RefRangeEnd = 596504, XrefRangeStart = 596502, XrefRangeEnd = 596502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_requiresUpscalePass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0001636C File Offset: 0x0001456C
		[CallerCount(0)]
		public unsafe Vector3 RoundToPixel(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_RoundToPixel_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000163B8 File Offset: 0x000145B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596504, XrefRangeEnd = 596505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetOrthoSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_CorrectCinemachineOrthoSize_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00016404 File Offset: 0x00014604
		public unsafe FilterMode finalBlitFilterMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 596505, RefRangeEnd = 596506, XrefRangeStart = 596505, XrefRangeEnd = 596505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_finalBlitFilterMode_Internal_get_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00016440 File Offset: 0x00014640
		public unsafe Vector2Int offscreenRTSize
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 596506, RefRangeEnd = 596512, XrefRangeStart = 596506, XrefRangeEnd = 596506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_offscreenRTSize_Internal_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0001647C File Offset: 0x0001467C
		public unsafe Vector2Int cameraRTSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596512, XrefRangeEnd = 596519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_get_cameraRTSize_Private_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000164B8 File Offset: 0x000146B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596539, RefRangeEnd = 596540, XrefRangeStart = 596519, XrefRangeEnd = 596539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PixelSnap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_PixelSnap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000164EC File Offset: 0x000146EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596540, XrefRangeEnd = 596550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00016520 File Offset: 0x00014720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 596560, RefRangeEnd = 596562, XrefRangeStart = 596550, XrefRangeEnd = 596560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_UpdateCameraProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00016554 File Offset: 0x00014754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596562, XrefRangeEnd = 596570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000165A4 File Offset: 0x000147A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596570, XrefRangeEnd = 596575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000165F4 File Offset: 0x000147F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596575, XrefRangeEnd = 596591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00016628 File Offset: 0x00014828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596591, XrefRangeEnd = 596610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_OnDisable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0001665C File Offset: 0x0001485C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00016690 File Offset: 0x00014890
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000166C4 File Offset: 0x000148C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596610, XrefRangeEnd = 596611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PixelPerfectCamera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PixelPerfectCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021E1 File Offset: 0x000003E1
		public PixelPerfectCamera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00016700 File Offset: 0x00014900
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021EA File Offset: 0x000003EA
		public unsafe int m_AssetsPPU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_AssetsPPU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_AssetsPPU)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00016728 File Offset: 0x00014928
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002205 File Offset: 0x00000405
		public unsafe int m_RefResolutionX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_RefResolutionX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_RefResolutionX)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00016750 File Offset: 0x00014950
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002220 File Offset: 0x00000420
		public unsafe int m_RefResolutionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_RefResolutionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_RefResolutionY)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00016778 File Offset: 0x00014978
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000223B File Offset: 0x0000043B
		public unsafe PixelPerfectCamera.CropFrame m_CropFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_CropFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_CropFrame)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000167A0 File Offset: 0x000149A0
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe PixelPerfectCamera.GridSnapping m_GridSnapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_GridSnapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_GridSnapping)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000167C8 File Offset: 0x000149C8
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002271 File Offset: 0x00000471
		public unsafe PixelPerfectCamera.PixelPerfectFilterMode m_FilterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_FilterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_FilterMode)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000167F0 File Offset: 0x000149F0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000228C File Offset: 0x0000048C
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00016820 File Offset: 0x00014A20
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000022AB File Offset: 0x000004AB
		public unsafe PixelPerfectCameraInternal m_Internal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_Internal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PixelPerfectCameraInternal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_Internal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00016850 File Offset: 0x00014A50
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000022CA File Offset: 0x000004CA
		public unsafe bool m_CinemachineCompatibilityMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_CinemachineCompatibilityMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCamera.NativeFieldInfoPtr_m_CinemachineCompatibilityMode)) = value;
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetsPPU;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_RefResolutionX;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_RefResolutionY;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_m_CropFrame;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_m_GridSnapping;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterMode;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_m_Internal;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_m_CinemachineCompatibilityMode;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_cropFrame_Public_get_CropFrame_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_cropFrame_Public_set_Void_CropFrame_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_gridSnapping_Public_get_GridSnapping_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_gridSnapping_Public_set_Void_GridSnapping_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_assetsPPU_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_set_assetsPPU_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_refResolutionX_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_set_refResolutionX_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_refResolutionY_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_set_refResolutionY_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_upscaleRT_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_set_upscaleRT_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelSnapping_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelSnapping_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_cropFrameX_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_set_cropFrameX_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_cropFrameY_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_set_cropFrameY_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchFill_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchFill_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRatio_Public_get_Int32_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresUpscalePass_Public_get_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_RoundToPixel_Public_Vector3_Vector3_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_CorrectCinemachineOrthoSize_Public_Single_Single_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_finalBlitFilterMode_Internal_get_FilterMode_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_offscreenRTSize_Internal_get_Vector2Int_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraRTSize_Private_get_Vector2Int_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_PixelSnap_Private_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraProperties_Private_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Internal_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000146 RID: 326
		public enum CropFrame
		{
			// Token: 0x0400139F RID: 5023
			None,
			// Token: 0x040013A0 RID: 5024
			Pillarbox,
			// Token: 0x040013A1 RID: 5025
			Letterbox,
			// Token: 0x040013A2 RID: 5026
			Windowbox,
			// Token: 0x040013A3 RID: 5027
			StretchFill
		}

		// Token: 0x02000147 RID: 327
		public enum GridSnapping
		{
			// Token: 0x040013A5 RID: 5029
			None,
			// Token: 0x040013A6 RID: 5030
			PixelSnapping,
			// Token: 0x040013A7 RID: 5031
			UpscaleRenderTexture
		}

		// Token: 0x02000148 RID: 328
		public enum PixelPerfectFilterMode
		{
			// Token: 0x040013A9 RID: 5033
			RetroAA,
			// Token: 0x040013AA RID: 5034
			Point
		}

		// Token: 0x02000149 RID: 329
		public enum ComponentVersions
		{
			// Token: 0x040013AC RID: 5036
			Version_Unserialized,
			// Token: 0x040013AD RID: 5037
			Version_1
		}
	}
}
