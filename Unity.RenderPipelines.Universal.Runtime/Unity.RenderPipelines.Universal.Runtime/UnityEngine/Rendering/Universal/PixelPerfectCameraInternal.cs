using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.Universal;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000035 RID: 53
	[Serializable]
	public class PixelPerfectCameraInternal : Object
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00024554 File Offset: 0x00022754
		// Note: this type is marked as 'beforefieldinit'.
		static PixelPerfectCameraInternal()
		{
			Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PixelPerfectCameraInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr);
			PixelPerfectCameraInternal.NativeFieldInfoPtr_m_Component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "m_Component");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_m_SerializableComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "m_SerializableComponent");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_originalOrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "originalOrthoSize");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_hasPostProcessLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "hasPostProcessLayer");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_cropFrameXAndY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "cropFrameXAndY");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_cropFrameXOrY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "cropFrameXOrY");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_useStretchFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "useStretchFill");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "zoom");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_useOffscreenRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "useOffscreenRT");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_offscreenRTWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "offscreenRTWidth");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_offscreenRTHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "offscreenRTHeight");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_pixelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "pixelRect");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_orthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "orthoSize");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_unitsPerPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "unitsPerPixel");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_cinemachineVCamZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "cinemachineVCamZoom");
			PixelPerfectCameraInternal.NativeFieldInfoPtr_requiresUpscaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, "requiresUpscaling");
			PixelPerfectCameraInternal.NativeMethodInfoPtr__ctor_Internal_Void_IPixelPerfectCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, 100663807);
			PixelPerfectCameraInternal.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, 100663808);
			PixelPerfectCameraInternal.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, 100663809);
			PixelPerfectCameraInternal.NativeMethodInfoPtr_CalculateCameraProperties_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, 100663810);
			PixelPerfectCameraInternal.NativeMethodInfoPtr_CalculateFinalBlitPixelRect_Internal_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, 100663811);
			PixelPerfectCameraInternal.NativeMethodInfoPtr_CorrectCinemachineOrthoSize_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr, 100663812);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0002473C File Offset: 0x0002293C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601653, RefRangeEnd = 601654, XrefRangeStart = 601650, XrefRangeEnd = 601653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PixelPerfectCameraInternal(IPixelPerfectCamera component)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PixelPerfectCameraInternal>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCameraInternal.NativeMethodInfoPtr__ctor_Internal_Void_IPixelPerfectCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00024788 File Offset: 0x00022988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601654, XrefRangeEnd = 601661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCameraInternal.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000247BC File Offset: 0x000229BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601661, XrefRangeEnd = 601666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCameraInternal.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000247F0 File Offset: 0x000229F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601703, RefRangeEnd = 601704, XrefRangeStart = 601666, XrefRangeEnd = 601703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateCameraProperties(int screenWidth, int screenHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCameraInternal.NativeMethodInfoPtr_CalculateCameraProperties_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0002483C File Offset: 0x00022A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601704, XrefRangeEnd = 601719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCameraInternal.NativeMethodInfoPtr_CalculateFinalBlitPixelRect_Internal_Rect_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00024894 File Offset: 0x00022A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601738, RefRangeEnd = 601739, XrefRangeStart = 601719, XrefRangeEnd = 601738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetOrthoSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectCameraInternal.NativeMethodInfoPtr_CorrectCinemachineOrthoSize_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public PixelPerfectCameraInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000248E0 File Offset: 0x00022AE0
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003AED File Offset: 0x00001CED
		public unsafe IPixelPerfectCamera m_Component
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_m_Component);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPixelPerfectCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_m_Component), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00024910 File Offset: 0x00022B10
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003B0C File Offset: 0x00001D0C
		public unsafe PixelPerfectCamera m_SerializableComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_m_SerializableComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PixelPerfectCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_m_SerializableComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00024940 File Offset: 0x00022B40
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003B2B File Offset: 0x00001D2B
		public unsafe float originalOrthoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_originalOrthoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_originalOrthoSize)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00024968 File Offset: 0x00022B68
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003B46 File Offset: 0x00001D46
		public unsafe bool hasPostProcessLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_hasPostProcessLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_hasPostProcessLayer)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00024990 File Offset: 0x00022B90
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003B61 File Offset: 0x00001D61
		public unsafe bool cropFrameXAndY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_cropFrameXAndY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_cropFrameXAndY)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000249B8 File Offset: 0x00022BB8
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003B7C File Offset: 0x00001D7C
		public unsafe bool cropFrameXOrY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_cropFrameXOrY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_cropFrameXOrY)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x000249E0 File Offset: 0x00022BE0
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003B97 File Offset: 0x00001D97
		public unsafe bool useStretchFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_useStretchFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_useStretchFill)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00024A08 File Offset: 0x00022C08
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00003BB2 File Offset: 0x00001DB2
		public unsafe int zoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_zoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_zoom)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00024A30 File Offset: 0x00022C30
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00003BCD File Offset: 0x00001DCD
		public unsafe bool useOffscreenRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_useOffscreenRT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_useOffscreenRT)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00024A58 File Offset: 0x00022C58
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public unsafe int offscreenRTWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_offscreenRTWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_offscreenRTWidth)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00024A80 File Offset: 0x00022C80
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00003C03 File Offset: 0x00001E03
		public unsafe int offscreenRTHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_offscreenRTHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_offscreenRTHeight)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00024AA8 File Offset: 0x00022CA8
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00003C1E File Offset: 0x00001E1E
		public unsafe Rect pixelRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_pixelRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_pixelRect)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00024AD0 File Offset: 0x00022CD0
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003C39 File Offset: 0x00001E39
		public unsafe float orthoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_orthoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_orthoSize)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00024AF8 File Offset: 0x00022CF8
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003C54 File Offset: 0x00001E54
		public unsafe float unitsPerPixel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_unitsPerPixel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_unitsPerPixel)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00024B20 File Offset: 0x00022D20
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003C6F File Offset: 0x00001E6F
		public unsafe int cinemachineVCamZoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_cinemachineVCamZoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_cinemachineVCamZoom)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00024B48 File Offset: 0x00022D48
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003C8A File Offset: 0x00001E8A
		public unsafe bool requiresUpscaling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_requiresUpscaling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PixelPerfectCameraInternal.NativeFieldInfoPtr_requiresUpscaling)) = value;
			}
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_m_Component;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_m_SerializableComponent;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_originalOrthoSize;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_hasPostProcessLayer;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_cropFrameXAndY;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_cropFrameXOrY;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_useStretchFill;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_zoom;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_useOffscreenRT;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_offscreenRTWidth;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_offscreenRTHeight;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_pixelRect;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_orthoSize;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_unitsPerPixel;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_cinemachineVCamZoom;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_requiresUpscaling;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPixelPerfectCamera_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCameraProperties_Internal_Void_Int32_Int32_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFinalBlitPixelRect_Internal_Rect_Int32_Int32_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_CorrectCinemachineOrthoSize_Internal_Single_Single_0;
	}
}
