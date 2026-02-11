using System;
using boardgames.input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.camera
{
	// Token: 0x0200029D RID: 669
	public class CinemachineControlProvider : MonoBehaviour
	{
		// Token: 0x06001FCB RID: 8139 RVA: 0x00087624 File Offset: 0x00085824
		// Note: this type is marked as 'beforefieldinit'.
		static CinemachineControlProvider()
		{
			Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "CinemachineControlProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr);
			CinemachineControlProvider.NativeFieldInfoPtr_cameraLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "cameraLookup");
			CinemachineControlProvider.NativeFieldInfoPtr_scrollDisabler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "scrollDisabler");
			CinemachineControlProvider.NativeFieldInfoPtr_activeVCC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "activeVCC");
			CinemachineControlProvider.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "mainCamera");
			CinemachineControlProvider.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "forwardVector");
			CinemachineControlProvider.NativeFieldInfoPtr_worldPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "worldPlane");
			CinemachineControlProvider.NativeMethodInfoPtr_get_ActiveVCC_Public_get_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668578);
			CinemachineControlProvider.NativeMethodInfoPtr_get_CurrentVCFlavors_Public_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668579);
			CinemachineControlProvider.NativeMethodInfoPtr_get_CurrentPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668580);
			CinemachineControlProvider.NativeMethodInfoPtr_get_ForwardVector_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668581);
			CinemachineControlProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668582);
			CinemachineControlProvider.NativeMethodInfoPtr_TryGetCamera_Public_Boolean_HashSet_1_String_byref_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668583);
			CinemachineControlProvider.NativeMethodInfoPtr_TranslateScreenDelta_Public_Virtual_Final_New_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668584);
			CinemachineControlProvider.NativeMethodInfoPtr_ZoomScreenDelta_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668585);
			CinemachineControlProvider.NativeMethodInfoPtr_SwitchToCamera_Public_Void_HashSet_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668586);
			CinemachineControlProvider.NativeMethodInfoPtr_SwitchToCameraRoutine_Public_IEnumerator_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668587);
			CinemachineControlProvider.NativeMethodInfoPtr_RegisterCamera_Public_Void_IVirtualCameraController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668588);
			CinemachineControlProvider.NativeMethodInfoPtr_UnregisterCamera_Public_Void_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668589);
			CinemachineControlProvider.NativeMethodInfoPtr_getMoveDelta_Private_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668590);
			CinemachineControlProvider.NativeMethodInfoPtr_SetShakeGlobal_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668591);
			CinemachineControlProvider.NativeMethodInfoPtr_IsActiveVirtualCamera_Public_Boolean_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668592);
			CinemachineControlProvider.NativeMethodInfoPtr_SwitchToFallbackCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668593);
			CinemachineControlProvider.NativeMethodInfoPtr__switchCameraInternal_Private_Void_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668594);
			CinemachineControlProvider.NativeMethodInfoPtr_MoveFallbackCamera_Private_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668595);
			CinemachineControlProvider.NativeMethodInfoPtr_ZoomFallbackCamera_Private_IVirtualCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668596);
			CinemachineControlProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, 100668597);
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0008785C File Offset: 0x00085A5C
		public unsafe IVirtualCameraController ActiveVCC
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_get_ActiveVCC_Public_get_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVirtualCameraController>(intPtr3) : null;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0008789C File Offset: 0x00085A9C
		public unsafe HashSet<string> CurrentVCFlavors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541596, XrefRangeEnd = 541605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_get_CurrentVCFlavors_Public_get_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x000878DC File Offset: 0x00085ADC
		public unsafe virtual Vector3 CurrentPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541605, XrefRangeEnd = 541612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_get_CurrentPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00087918 File Offset: 0x00085B18
		public unsafe Vector3 ForwardVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_get_ForwardVector_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00087954 File Offset: 0x00085B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541612, XrefRangeEnd = 541632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00087988 File Offset: 0x00085B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541632, XrefRangeEnd = 541636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCamera(HashSet<string> lookupFlavors, out IVirtualCameraController virtualCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookupFlavors);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_TryGetCamera_Public_Boolean_HashSet_1_String_byref_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			virtualCamera = ((intPtr4 == 0) ? null : new IVirtualCameraController(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000879F8 File Offset: 0x00085BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541636, XrefRangeEnd = 541644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TranslateScreenDelta(Vector3 startPosition, Vector3 endPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_TranslateScreenDelta_Public_Virtual_Final_New_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00087A44 File Offset: 0x00085C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541644, XrefRangeEnd = 541667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZoomScreenDelta(float direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_ZoomScreenDelta_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00087A84 File Offset: 0x00085C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541667, XrefRangeEnd = 541681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchToCamera(HashSet<string> lookupFlavors, bool autoSwitch = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookupFlavors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoSwitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_SwitchToCamera_Public_Void_HashSet_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00087AD4 File Offset: 0x00085CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541681, XrefRangeEnd = 541687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SwitchToCameraRoutine(HashSet<string> lookupFlavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookupFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_SwitchToCameraRoutine_Public_IEnumerator_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00087B24 File Offset: 0x00085D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541687, XrefRangeEnd = 541705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCamera(IVirtualCameraController vc, bool trySwitch = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trySwitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_RegisterCamera_Public_Void_IVirtualCameraController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00087B74 File Offset: 0x00085D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541705, XrefRangeEnd = 541716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCamera(IVirtualCameraController vc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_UnregisterCamera_Public_Void_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00087BB8 File Offset: 0x00085DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 541726, RefRangeEnd = 541727, XrefRangeStart = 541716, XrefRangeEnd = 541726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 getMoveDelta(Vector3 startPosition, Vector3 endPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_getMoveDelta_Private_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00087C10 File Offset: 0x00085E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541727, XrefRangeEnd = 541769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShakeGlobal(float amplitude, float frequency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amplitude;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frequency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_SetShakeGlobal_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00087C5C File Offset: 0x00085E5C
		[CallerCount(0)]
		public unsafe bool IsActiveVirtualCamera(IVirtualCameraController virtualCameraController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(virtualCameraController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_IsActiveVirtualCamera_Public_Boolean_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00087CAC File Offset: 0x00085EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541769, XrefRangeEnd = 541771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchToFallbackCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_SwitchToFallbackCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00087CE0 File Offset: 0x00085EE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 541779, RefRangeEnd = 541783, XrefRangeStart = 541771, XrefRangeEnd = 541779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _switchCameraInternal(IVirtualCameraController nextVCC)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextVCC);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr__switchCameraInternal_Private_Void_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00087D24 File Offset: 0x00085F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 541798, RefRangeEnd = 541800, XrefRangeStart = 541783, XrefRangeEnd = 541798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IVirtualCameraController MoveFallbackCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_MoveFallbackCamera_Private_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVirtualCameraController>(intPtr3) : null;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00087D64 File Offset: 0x00085F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541800, XrefRangeEnd = 541815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IVirtualCameraController ZoomFallbackCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr_ZoomFallbackCamera_Private_IVirtualCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVirtualCameraController>(intPtr3) : null;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00087DA4 File Offset: 0x00085FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541815, XrefRangeEnd = 541828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CinemachineControlProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00010C00 File Offset: 0x0000EE00
		public CinemachineControlProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00087DE0 File Offset: 0x00085FE0
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00010C09 File Offset: 0x0000EE09
		public unsafe Dictionary<HashSet<string>, IVirtualCameraController> cameraLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_cameraLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<HashSet<string>, IVirtualCameraController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_cameraLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00087E10 File Offset: 0x00086010
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00010C28 File Offset: 0x0000EE28
		public unsafe Disabler<GameObject> scrollDisabler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_scrollDisabler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_scrollDisabler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00087E40 File Offset: 0x00086040
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00010C47 File Offset: 0x0000EE47
		public unsafe IVirtualCameraController activeVCC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_activeVCC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVirtualCameraController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_activeVCC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00087E70 File Offset: 0x00086070
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00010C66 File Offset: 0x0000EE66
		public unsafe Camera mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00087EA0 File Offset: 0x000860A0
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x00010C85 File Offset: 0x0000EE85
		public unsafe Vector3 forwardVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_forwardVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_forwardVector)) = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x00087EC8 File Offset: 0x000860C8
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x00010CA0 File Offset: 0x0000EEA0
		public unsafe Plane worldPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_worldPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider.NativeFieldInfoPtr_worldPlane)) = value;
			}
		}

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeFieldInfoPtr_cameraLookup;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeFieldInfoPtr_scrollDisabler;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeFieldInfoPtr_activeVCC;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeFieldInfoPtr_mainCamera;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_forwardVector;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_worldPlane;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveVCC_Public_get_IVirtualCameraController_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVCFlavors_Public_get_HashSet_1_String_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_get_ForwardVector_Public_get_Vector3_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCamera_Public_Boolean_HashSet_1_String_byref_IVirtualCameraController_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_TranslateScreenDelta_Public_Virtual_Final_New_Void_Vector3_Vector3_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_ZoomScreenDelta_Public_Void_Single_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToCamera_Public_Void_HashSet_1_String_Boolean_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToCameraRoutine_Public_IEnumerator_HashSet_1_String_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCamera_Public_Void_IVirtualCameraController_Boolean_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCamera_Public_Void_IVirtualCameraController_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_getMoveDelta_Private_Vector3_Vector3_Vector3_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_SetShakeGlobal_Public_Void_Single_Single_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_IsActiveVirtualCamera_Public_Boolean_IVirtualCameraController_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToFallbackCamera_Public_Void_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr__switchCameraInternal_Private_Void_IVirtualCameraController_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_MoveFallbackCamera_Private_IVirtualCameraController_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_ZoomFallbackCamera_Private_IVirtualCameraController_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200049A RID: 1178
		[ObfuscatedName("boardgames.camera.CinemachineControlProvider+<SwitchToCameraRoutine>d__19")]
		public sealed class _SwitchToCameraRoutine_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x060037EA RID: 14314 RVA: 0x000CF8EC File Offset: 0x000CDAEC
			// Note: this type is marked as 'beforefieldinit'.
			static _SwitchToCameraRoutine_d__19()
			{
				Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineControlProvider>.NativeClassPtr, "<SwitchToCameraRoutine>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr);
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, "<>1__state");
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, "<>2__current");
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, "<>4__this");
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr_lookupFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, "lookupFlavors");
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr__nextVCC_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, "<nextVCC>5__2");
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, 100668598);
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, 100668599);
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, 100668600);
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, 100668601);
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, 100668602);
				CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr, 100668603);
			}

			// Token: 0x060037EB RID: 14315 RVA: 0x000CF9F4 File Offset: 0x000CDBF4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SwitchToCameraRoutine_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineControlProvider._SwitchToCameraRoutine_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060037EC RID: 14316 RVA: 0x000CFA3C File Offset: 0x000CDC3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037ED RID: 14317 RVA: 0x000CFA70 File Offset: 0x000CDC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541579, XrefRangeEnd = 541591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x060037EE RID: 14318 RVA: 0x000CFAAC File Offset: 0x000CDCAC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037EF RID: 14319 RVA: 0x000CFAEC File Offset: 0x000CDCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 541591, XrefRangeEnd = 541596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x060037F0 RID: 14320 RVA: 0x000CFB20 File Offset: 0x000CDD20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060037F1 RID: 14321 RVA: 0x0001CBF7 File Offset: 0x0001ADF7
			public _SwitchToCameraRoutine_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x060037F2 RID: 14322 RVA: 0x000CFB60 File Offset: 0x000CDD60
			// (set) Token: 0x060037F3 RID: 14323 RVA: 0x0001CC00 File Offset: 0x0001AE00
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x060037F4 RID: 14324 RVA: 0x000CFB88 File Offset: 0x000CDD88
			// (set) Token: 0x060037F5 RID: 14325 RVA: 0x0001CC1B File Offset: 0x0001AE1B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x060037F6 RID: 14326 RVA: 0x000CFBB8 File Offset: 0x000CDDB8
			// (set) Token: 0x060037F7 RID: 14327 RVA: 0x0001CC3A File Offset: 0x0001AE3A
			public unsafe CinemachineControlProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineControlProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x060037F8 RID: 14328 RVA: 0x000CFBE8 File Offset: 0x000CDDE8
			// (set) Token: 0x060037F9 RID: 14329 RVA: 0x0001CC59 File Offset: 0x0001AE59
			public unsafe HashSet<string> lookupFlavors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr_lookupFlavors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr_lookupFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x060037FA RID: 14330 RVA: 0x000CFC18 File Offset: 0x000CDE18
			// (set) Token: 0x060037FB RID: 14331 RVA: 0x0001CC78 File Offset: 0x0001AE78
			public unsafe IVirtualCameraController _nextVCC_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr__nextVCC_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVirtualCameraController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CinemachineControlProvider._SwitchToCameraRoutine_d__19.NativeFieldInfoPtr__nextVCC_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002264 RID: 8804
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002265 RID: 8805
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002266 RID: 8806
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002267 RID: 8807
			private static readonly IntPtr NativeFieldInfoPtr_lookupFlavors;

			// Token: 0x04002268 RID: 8808
			private static readonly IntPtr NativeFieldInfoPtr__nextVCC_5__2;

			// Token: 0x04002269 RID: 8809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400226A RID: 8810
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400226B RID: 8811
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400226C RID: 8812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400226D RID: 8813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400226E RID: 8814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
