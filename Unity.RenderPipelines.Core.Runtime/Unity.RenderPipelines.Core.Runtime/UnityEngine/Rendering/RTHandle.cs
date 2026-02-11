using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000BA RID: 186
	public class RTHandle : Object
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x0003C228 File Offset: 0x0003A428
		// Note: this type is marked as 'beforefieldinit'.
		static RTHandle()
		{
			Il2CppClassPointerStore<RTHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandle>.NativeClassPtr);
			RTHandle.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_Owner");
			RTHandle.NativeFieldInfoPtr_m_RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_RT");
			RTHandle.NativeFieldInfoPtr_m_ExternalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_ExternalTexture");
			RTHandle.NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_NameID");
			RTHandle.NativeFieldInfoPtr_m_EnableMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_EnableMSAA");
			RTHandle.NativeFieldInfoPtr_m_EnableRandomWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_EnableRandomWrite");
			RTHandle.NativeFieldInfoPtr_m_EnableHWDynamicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_EnableHWDynamicScale");
			RTHandle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_Name");
			RTHandle.NativeFieldInfoPtr_m_UseCustomHandleScales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_UseCustomHandleScales");
			RTHandle.NativeFieldInfoPtr_m_CustomHandleProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "m_CustomHandleProperties");
			RTHandle.NativeFieldInfoPtr__scaleFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "<scaleFactor>k__BackingField");
			RTHandle.NativeFieldInfoPtr_scaleFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "scaleFunc");
			RTHandle.NativeFieldInfoPtr__useScaling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "<useScaling>k__BackingField");
			RTHandle.NativeFieldInfoPtr__referenceSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, "<referenceSize>k__BackingField");
			RTHandle.NativeMethodInfoPtr_SetCustomHandleProperties_Public_Void_byref_RTHandleProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665171);
			RTHandle.NativeMethodInfoPtr_ClearCustomHandleProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665172);
			RTHandle.NativeMethodInfoPtr_get_scaleFactor_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665173);
			RTHandle.NativeMethodInfoPtr_set_scaleFactor_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665174);
			RTHandle.NativeMethodInfoPtr_get_useScaling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665175);
			RTHandle.NativeMethodInfoPtr_set_useScaling_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665176);
			RTHandle.NativeMethodInfoPtr_get_referenceSize_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665177);
			RTHandle.NativeMethodInfoPtr_set_referenceSize_Internal_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665178);
			RTHandle.NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665179);
			RTHandle.NativeMethodInfoPtr_get_rt_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665180);
			RTHandle.NativeMethodInfoPtr_get_nameID_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665181);
			RTHandle.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665182);
			RTHandle.NativeMethodInfoPtr_get_isMSAAEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665183);
			RTHandle.NativeMethodInfoPtr__ctor_Internal_Void_RTHandleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665184);
			RTHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665185);
			RTHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Texture_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665186);
			RTHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTexture_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665187);
			RTHandle.NativeMethodInfoPtr_SetRenderTexture_Internal_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665188);
			RTHandle.NativeMethodInfoPtr_SetTexture_Internal_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665189);
			RTHandle.NativeMethodInfoPtr_SetTexture_Internal_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665190);
			RTHandle.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665191);
			RTHandle.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665192);
			RTHandle.NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665193);
			RTHandle.NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665194);
			RTHandle.NativeMethodInfoPtr_SwitchToFastMemory_Public_Void_CommandBuffer_Single_FastMemoryFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665195);
			RTHandle.NativeMethodInfoPtr_CopyToFastMemory_Public_Void_CommandBuffer_Single_FastMemoryFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665196);
			RTHandle.NativeMethodInfoPtr_SwitchOutFastMemory_Public_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandle>.NativeClassPtr, 100665197);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0003C58C File Offset: 0x0003A78C
		[CallerCount(0)]
		public unsafe void SetCustomHandleProperties([In] ref RTHandleProperties properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &properties;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_SetCustomHandleProperties_Public_Void_byref_RTHandleProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0003C5CC File Offset: 0x0003A7CC
		[CallerCount(0)]
		public unsafe void ClearCustomHandleProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_ClearCustomHandleProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0003C600 File Offset: 0x0003A800
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x0003C63C File Offset: 0x0003A83C
		public unsafe Vector2 scaleFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_scaleFactor_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_set_scaleFactor_Internal_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0003C67C File Offset: 0x0003A87C
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0003C6B8 File Offset: 0x0003A8B8
		public unsafe bool useScaling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_useScaling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_set_useScaling_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003C6F8 File Offset: 0x0003A8F8
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0003C734 File Offset: 0x0003A934
		public unsafe Vector2Int referenceSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_referenceSize_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_set_referenceSize_Internal_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0003C774 File Offset: 0x0003A974
		public unsafe RTHandleProperties rtHandleProperties
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 972057, RefRangeEnd = 972093, XrefRangeStart = 972057, XrefRangeEnd = 972057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0003C7B0 File Offset: 0x0003A9B0
		public unsafe RenderTexture rt
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_rt_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0003C7F0 File Offset: 0x0003A9F0
		public unsafe RenderTargetIdentifier nameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_nameID_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0003C82C File Offset: 0x0003AA2C
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003C864 File Offset: 0x0003AA64
		public unsafe bool isMSAAEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_get_isMSAAEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle(RTHandleSystem owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTHandle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr__ctor_Internal_Void_RTHandleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 972093, RefRangeEnd = 972120, XrefRangeStart = 972093, XrefRangeEnd = 972093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(RTHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0003C930 File Offset: 0x0003AB30
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 972124, RefRangeEnd = 972132, XrefRangeStart = 972120, XrefRangeEnd = 972124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Texture(RTHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Texture_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0003C974 File Offset: 0x0003AB74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 972132, RefRangeEnd = 972135, XrefRangeStart = 972132, XrefRangeEnd = 972132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTexture(RTHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTexture_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0003C9B8 File Offset: 0x0003ABB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 972138, RefRangeEnd = 972142, XrefRangeStart = 972135, XrefRangeEnd = 972138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTexture(RenderTexture rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_SetRenderTexture_Internal_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0003C9FC File Offset: 0x0003ABFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972142, XrefRangeEnd = 972145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(Texture tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_SetTexture_Internal_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0003CA40 File Offset: 0x0003AC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 972147, RefRangeEnd = 972149, XrefRangeStart = 972145, XrefRangeEnd = 972147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(RenderTargetIdentifier tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_SetTexture_Internal_Void_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0003CA80 File Offset: 0x0003AC80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 972160, RefRangeEnd = 972164, XrefRangeStart = 972149, XrefRangeEnd = 972160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0003CABC File Offset: 0x0003ACBC
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 972175, RefRangeEnd = 972256, XrefRangeStart = 972164, XrefRangeEnd = 972175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0003CAF0 File Offset: 0x0003ACF0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 972258, RefRangeEnd = 972270, XrefRangeStart = 972256, XrefRangeEnd = 972258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetScaledSize(Vector2Int refSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0003CB3C File Offset: 0x0003AD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972270, XrefRangeEnd = 972272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetScaledSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0003CB78 File Offset: 0x0003AD78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972275, RefRangeEnd = 972276, XrefRangeStart = 972272, XrefRangeEnd = 972275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1f, FastMemoryFlags flags = FastMemoryFlags.SpillTop, bool copyContents = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref residencyFraction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_SwitchToFastMemory_Public_Void_CommandBuffer_Single_FastMemoryFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972276, XrefRangeEnd = 972279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1f, FastMemoryFlags flags = FastMemoryFlags.SpillTop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref residencyFraction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_CopyToFastMemory_Public_Void_CommandBuffer_Single_FastMemoryFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003CC44 File Offset: 0x0003AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972279, XrefRangeEnd = 972281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandle.NativeMethodInfoPtr_SwitchOutFastMemory_Public_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00007BD2 File Offset: 0x00005DD2
		public RTHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003CC94 File Offset: 0x0003AE94
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00007BDB File Offset: 0x00005DDB
		public unsafe RTHandleSystem m_Owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_Owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_Owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0003CCC4 File Offset: 0x0003AEC4
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00007BFA File Offset: 0x00005DFA
		public unsafe RenderTexture m_RT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_RT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_RT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00007C19 File Offset: 0x00005E19
		public unsafe Texture m_ExternalTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_ExternalTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_ExternalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0003CD24 File Offset: 0x0003AF24
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00007C38 File Offset: 0x00005E38
		public unsafe RenderTargetIdentifier m_NameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_NameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_NameID)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0003CD4C File Offset: 0x0003AF4C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00007C53 File Offset: 0x00005E53
		public unsafe bool m_EnableMSAA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_EnableMSAA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_EnableMSAA)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0003CD74 File Offset: 0x0003AF74
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00007C6E File Offset: 0x00005E6E
		public unsafe bool m_EnableRandomWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_EnableRandomWrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_EnableRandomWrite)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0003CD9C File Offset: 0x0003AF9C
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00007C89 File Offset: 0x00005E89
		public unsafe bool m_EnableHWDynamicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_EnableHWDynamicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_EnableHWDynamicScale)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0003CDC4 File Offset: 0x0003AFC4
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00007CA4 File Offset: 0x00005EA4
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0003CDEC File Offset: 0x0003AFEC
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00007CC3 File Offset: 0x00005EC3
		public unsafe bool m_UseCustomHandleScales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_UseCustomHandleScales);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_UseCustomHandleScales)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0003CE14 File Offset: 0x0003B014
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00007CDE File Offset: 0x00005EDE
		public unsafe RTHandleProperties m_CustomHandleProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_CustomHandleProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_m_CustomHandleProperties)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0003CE3C File Offset: 0x0003B03C
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00007CF9 File Offset: 0x00005EF9
		public unsafe Vector2 _scaleFactor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr__scaleFactor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr__scaleFactor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0003CE64 File Offset: 0x0003B064
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00007D14 File Offset: 0x00005F14
		public unsafe ScaleFunc scaleFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_scaleFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr_scaleFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0003CE94 File Offset: 0x0003B094
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00007D33 File Offset: 0x00005F33
		public unsafe bool _useScaling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr__useScaling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr__useScaling_k__BackingField)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0003CEBC File Offset: 0x0003B0BC
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00007D4E File Offset: 0x00005F4E
		public unsafe Vector2Int _referenceSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr__referenceSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTHandle.NativeFieldInfoPtr__referenceSize_k__BackingField)) = value;
			}
		}

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_m_RT;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_m_ExternalTexture;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_m_NameID;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableMSAA;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableRandomWrite;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableHWDynamicScale;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr_m_UseCustomHandleScales;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomHandleProperties;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr__scaleFactor_k__BackingField;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr_scaleFunc;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr__useScaling_k__BackingField;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr__referenceSize_k__BackingField;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomHandleProperties_Public_Void_byref_RTHandleProperties_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_ClearCustomHandleProperties_Public_Void_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Vector2_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleFactor_Internal_set_Void_Vector2_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_get_useScaling_Public_get_Boolean_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_set_useScaling_Internal_set_Void_Boolean_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceSize_Public_get_Vector2Int_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceSize_Internal_set_Void_Vector2Int_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_get_rtHandleProperties_Public_get_RTHandleProperties_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_rt_Public_get_RenderTexture_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_get_nameID_Public_get_RenderTargetIdentifier_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_get_isMSAAEnabled_Public_get_Boolean_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RTHandleSystem_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RTHandle_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Texture_RTHandle_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTexture_RTHandle_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTexture_Internal_Void_RenderTexture_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Internal_Void_Texture_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Internal_Void_RenderTargetIdentifier_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Int32_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToFastMemory_Public_Void_CommandBuffer_Single_FastMemoryFlags_Boolean_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_CopyToFastMemory_Public_Void_CommandBuffer_Single_FastMemoryFlags_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOutFastMemory_Public_Void_CommandBuffer_Boolean_0;
	}
}
