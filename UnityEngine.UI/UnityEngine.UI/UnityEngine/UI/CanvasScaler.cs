using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001B RID: 27
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00015494 File Offset: 0x00013694
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScaler()
		{
			Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "CanvasScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr);
			CanvasScaler.NativeFieldInfoPtr_m_UiScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_UiScaleMode");
			CanvasScaler.NativeFieldInfoPtr_m_ReferencePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ReferencePixelsPerUnit");
			CanvasScaler.NativeFieldInfoPtr_m_ScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_m_ReferenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ReferenceResolution");
			CanvasScaler.NativeFieldInfoPtr_m_ScreenMatchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_ScreenMatchMode");
			CanvasScaler.NativeFieldInfoPtr_m_MatchWidthOrHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_MatchWidthOrHeight");
			CanvasScaler.NativeFieldInfoPtr_kLogBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "kLogBase");
			CanvasScaler.NativeFieldInfoPtr_m_PhysicalUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PhysicalUnit");
			CanvasScaler.NativeFieldInfoPtr_m_FallbackScreenDPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_FallbackScreenDPI");
			CanvasScaler.NativeFieldInfoPtr_m_DefaultSpriteDPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_DefaultSpriteDPI");
			CanvasScaler.NativeFieldInfoPtr_m_DynamicPixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_DynamicPixelsPerUnit");
			CanvasScaler.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_Canvas");
			CanvasScaler.NativeFieldInfoPtr_m_PrevScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PrevScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PrevReferencePixelsPerUnit");
			CanvasScaler.NativeFieldInfoPtr_m_PresetInfoIsWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "m_PresetInfoIsWorld");
			CanvasScaler.NativeMethodInfoPtr_get_uiScaleMode_Public_get_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663896);
			CanvasScaler.NativeMethodInfoPtr_set_uiScaleMode_Public_set_Void_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663897);
			CanvasScaler.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663898);
			CanvasScaler.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663899);
			CanvasScaler.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663900);
			CanvasScaler.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663901);
			CanvasScaler.NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663902);
			CanvasScaler.NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663903);
			CanvasScaler.NativeMethodInfoPtr_get_screenMatchMode_Public_get_ScreenMatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663904);
			CanvasScaler.NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_ScreenMatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663905);
			CanvasScaler.NativeMethodInfoPtr_get_matchWidthOrHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663906);
			CanvasScaler.NativeMethodInfoPtr_set_matchWidthOrHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663907);
			CanvasScaler.NativeMethodInfoPtr_get_physicalUnit_Public_get_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663908);
			CanvasScaler.NativeMethodInfoPtr_set_physicalUnit_Public_set_Void_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663909);
			CanvasScaler.NativeMethodInfoPtr_get_fallbackScreenDPI_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663910);
			CanvasScaler.NativeMethodInfoPtr_set_fallbackScreenDPI_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663911);
			CanvasScaler.NativeMethodInfoPtr_get_defaultSpriteDPI_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663912);
			CanvasScaler.NativeMethodInfoPtr_set_defaultSpriteDPI_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663913);
			CanvasScaler.NativeMethodInfoPtr_get_dynamicPixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663914);
			CanvasScaler.NativeMethodInfoPtr_set_dynamicPixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663915);
			CanvasScaler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663916);
			CanvasScaler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663917);
			CanvasScaler.NativeMethodInfoPtr_Canvas_preWillRenderCanvases_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663918);
			CanvasScaler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663919);
			CanvasScaler.NativeMethodInfoPtr_Handle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663920);
			CanvasScaler.NativeMethodInfoPtr_HandleWorldCanvas_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663921);
			CanvasScaler.NativeMethodInfoPtr_HandleConstantPixelSize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663922);
			CanvasScaler.NativeMethodInfoPtr_HandleScaleWithScreenSize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663923);
			CanvasScaler.NativeMethodInfoPtr_HandleConstantPhysicalSize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663924);
			CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663925);
			CanvasScaler.NativeMethodInfoPtr_SetReferencePixelsPerUnit_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100663926);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0001585C File Offset: 0x00013A5C
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00015898 File Offset: 0x00013A98
		public unsafe CanvasScaler.ScaleMode uiScaleMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_uiScaleMode_Public_get_ScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_uiScaleMode_Public_set_Void_ScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000158D8 File Offset: 0x00013AD8
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00015914 File Offset: 0x00013B14
		public unsafe float referencePixelsPerUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604705, RefRangeEnd = 604706, XrefRangeStart = 604705, XrefRangeEnd = 604706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00015954 File Offset: 0x00013B54
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00015990 File Offset: 0x00013B90
		public unsafe float scaleFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000159D0 File Offset: 0x00013BD0
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00015A0C File Offset: 0x00013C0C
		public unsafe Vector2 referenceResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1088003, RefRangeEnd = 1088005, XrefRangeStart = 1088002, XrefRangeEnd = 1088003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00015A4C File Offset: 0x00013C4C
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00015A88 File Offset: 0x00013C88
		public unsafe CanvasScaler.ScreenMatchMode screenMatchMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_screenMatchMode_Public_get_ScreenMatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_ScreenMatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00015AC8 File Offset: 0x00013CC8
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00015B04 File Offset: 0x00013D04
		public unsafe float matchWidthOrHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_matchWidthOrHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_matchWidthOrHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00015B44 File Offset: 0x00013D44
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00015B80 File Offset: 0x00013D80
		public unsafe CanvasScaler.Unit physicalUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_physicalUnit_Public_get_Unit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_physicalUnit_Public_set_Void_Unit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00015BC0 File Offset: 0x00013DC0
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00015BFC File Offset: 0x00013DFC
		public unsafe float fallbackScreenDPI
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_fallbackScreenDPI_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_fallbackScreenDPI_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00015C3C File Offset: 0x00013E3C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00015C78 File Offset: 0x00013E78
		public unsafe float defaultSpriteDPI
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_defaultSpriteDPI_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_defaultSpriteDPI_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00015CB8 File Offset: 0x00013EB8
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00015CF4 File Offset: 0x00013EF4
		public unsafe float dynamicPixelsPerUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_dynamicPixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318239, RefRangeEnd = 318240, XrefRangeStart = 318239, XrefRangeEnd = 318240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_set_dynamicPixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00015D34 File Offset: 0x00013F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088005, XrefRangeEnd = 1088006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScaler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00015D70 File Offset: 0x00013F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088006, XrefRangeEnd = 1088018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00015DAC File Offset: 0x00013FAC
		[CallerCount(0)]
		public unsafe void Canvas_preWillRenderCanvases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_Canvas_preWillRenderCanvases_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088018, XrefRangeEnd = 1088029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00015E1C File Offset: 0x0001401C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088029, XrefRangeEnd = 1088035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Handle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_Handle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00015E58 File Offset: 0x00014058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088035, XrefRangeEnd = 1088037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleWorldCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleWorldCanvas_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00015E94 File Offset: 0x00014094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088037, XrefRangeEnd = 1088039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleConstantPixelSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleConstantPixelSize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00015ED0 File Offset: 0x000140D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088039, XrefRangeEnd = 1088057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleScaleWithScreenSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleScaleWithScreenSize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00015F0C File Offset: 0x0001410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088057, XrefRangeEnd = 1088063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleConstantPhysicalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanvasScaler.NativeMethodInfoPtr_HandleConstantPhysicalSize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00015F48 File Offset: 0x00014148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088063, XrefRangeEnd = 1088064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleFactor(float scaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00015F88 File Offset: 0x00014188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088064, XrefRangeEnd = 1088065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref referencePixelsPerUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetReferencePixelsPerUnit_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00003417 File Offset: 0x00001617
		public CanvasScaler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00015FC8 File Offset: 0x000141C8
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003420 File Offset: 0x00001620
		public unsafe CanvasScaler.ScaleMode m_UiScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_UiScaleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_UiScaleMode)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00015FF0 File Offset: 0x000141F0
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0000343B File Offset: 0x0000163B
		public unsafe float m_ReferencePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferencePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferencePixelsPerUnit)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00016018 File Offset: 0x00014218
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00003456 File Offset: 0x00001656
		public unsafe float m_ScaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScaleFactor)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00016040 File Offset: 0x00014240
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00003471 File Offset: 0x00001671
		public unsafe Vector2 m_ReferenceResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ReferenceResolution)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00016068 File Offset: 0x00014268
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000348C File Offset: 0x0000168C
		public unsafe CanvasScaler.ScreenMatchMode m_ScreenMatchMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScreenMatchMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_ScreenMatchMode)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00016090 File Offset: 0x00014290
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x000034A7 File Offset: 0x000016A7
		public unsafe float m_MatchWidthOrHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_MatchWidthOrHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_MatchWidthOrHeight)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000160B8 File Offset: 0x000142B8
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000034C2 File Offset: 0x000016C2
		public unsafe static float kLogBase
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_kLogBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_kLogBase, (void*)(&value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000160D4 File Offset: 0x000142D4
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000034D0 File Offset: 0x000016D0
		public unsafe CanvasScaler.Unit m_PhysicalUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PhysicalUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PhysicalUnit)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000160FC File Offset: 0x000142FC
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000034EB File Offset: 0x000016EB
		public unsafe float m_FallbackScreenDPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_FallbackScreenDPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_FallbackScreenDPI)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00016124 File Offset: 0x00014324
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003506 File Offset: 0x00001706
		public unsafe float m_DefaultSpriteDPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DefaultSpriteDPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DefaultSpriteDPI)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0001614C File Offset: 0x0001434C
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003521 File Offset: 0x00001721
		public unsafe float m_DynamicPixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DynamicPixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_DynamicPixelsPerUnit)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00016174 File Offset: 0x00014374
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000353C File Offset: 0x0000173C
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000161A4 File Offset: 0x000143A4
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000355B File Offset: 0x0000175B
		public unsafe float m_PrevScaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevScaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevScaleFactor)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000161CC File Offset: 0x000143CC
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003576 File Offset: 0x00001776
		public unsafe float m_PrevReferencePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000161F4 File Offset: 0x000143F4
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003591 File Offset: 0x00001791
		public unsafe bool m_PresetInfoIsWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PresetInfoIsWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_m_PresetInfoIsWorld)) = value;
			}
		}

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_m_UiScaleMode;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferencePixelsPerUnit;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleFactor;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceResolution;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenMatchMode;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_m_MatchWidthOrHeight;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_kLogBase;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_m_PhysicalUnit;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackScreenDPI;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultSpriteDPI;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_m_DynamicPixelsPerUnit;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevScaleFactor;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevReferencePixelsPerUnit;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_m_PresetInfoIsWorld;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_uiScaleMode_Public_get_ScaleMode_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_uiScaleMode_Public_set_Void_ScaleMode_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_screenMatchMode_Public_get_ScreenMatchMode_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_ScreenMatchMode_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_get_matchWidthOrHeight_Public_get_Single_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_set_matchWidthOrHeight_Public_set_Void_Single_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_physicalUnit_Public_get_Unit_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_set_physicalUnit_Public_set_Void_Unit_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackScreenDPI_Public_get_Single_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackScreenDPI_Public_set_Void_Single_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSpriteDPI_Public_get_Single_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultSpriteDPI_Public_set_Void_Single_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_get_dynamicPixelsPerUnit_Public_get_Single_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_set_dynamicPixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_Canvas_preWillRenderCanvases_Private_Void_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Protected_Virtual_New_Void_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_HandleWorldCanvas_Protected_Virtual_New_Void_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_HandleConstantPixelSize_Protected_Virtual_New_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_HandleScaleWithScreenSize_Protected_Virtual_New_Void_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_HandleConstantPhysicalSize_Protected_Virtual_New_Void_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleFactor_Protected_Void_Single_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_SetReferencePixelsPerUnit_Protected_Void_Single_0;

		// Token: 0x0200009C RID: 156
		public enum ScaleMode
		{
			// Token: 0x0400098B RID: 2443
			ConstantPixelSize,
			// Token: 0x0400098C RID: 2444
			ScaleWithScreenSize,
			// Token: 0x0400098D RID: 2445
			ConstantPhysicalSize
		}

		// Token: 0x0200009D RID: 157
		public enum ScreenMatchMode
		{
			// Token: 0x0400098F RID: 2447
			MatchWidthOrHeight,
			// Token: 0x04000990 RID: 2448
			Expand,
			// Token: 0x04000991 RID: 2449
			Shrink
		}

		// Token: 0x0200009E RID: 158
		public enum Unit
		{
			// Token: 0x04000993 RID: 2451
			Centimeters,
			// Token: 0x04000994 RID: 2452
			Millimeters,
			// Token: 0x04000995 RID: 2453
			Inches,
			// Token: 0x04000996 RID: 2454
			Points,
			// Token: 0x04000997 RID: 2455
			Picas
		}
	}
}
