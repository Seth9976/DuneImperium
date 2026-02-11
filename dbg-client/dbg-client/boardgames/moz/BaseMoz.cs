using System;
using dwd.core.input.compositeModule;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace boardgames.moz
{
	// Token: 0x0200010C RID: 268
	public class BaseMoz : MonoBehaviour
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x00042DC4 File Offset: 0x00040FC4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseMoz()
		{
			Il2CppClassPointerStore<BaseMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "BaseMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr);
			BaseMoz.NativeFieldInfoPtr_isMozExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "isMozExclusive");
			BaseMoz.NativeFieldInfoPtr_mozDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "mozDelay");
			BaseMoz.NativeFieldInfoPtr_enterEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "enterEventData");
			BaseMoz.NativeFieldInfoPtr_isPointerEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "isPointerEntered");
			BaseMoz.NativeFieldInfoPtr__MozActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "<MozActive>k__BackingField");
			BaseMoz.NativeFieldInfoPtr_showMozTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "showMozTime");
			BaseMoz.NativeFieldInfoPtr_disableMozForPhones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "disableMozForPhones");
			BaseMoz.NativeFieldInfoPtr_ignorePointerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "ignorePointerEnter");
			BaseMoz.NativeFieldInfoPtr_mozManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "mozManager");
			BaseMoz.NativeFieldInfoPtr_currentInputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "currentInputModuleType");
			BaseMoz.NativeFieldInfoPtr_mousePositionLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "mousePositionLastFrame");
			BaseMoz.NativeFieldInfoPtr_touchInputWasLastDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "touchInputWasLastDetected");
			BaseMoz.NativeFieldInfoPtr_Overridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, "Overridden");
			BaseMoz.NativeMethodInfoPtr_get_MozActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665058);
			BaseMoz.NativeMethodInfoPtr_set_MozActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665059);
			BaseMoz.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665060);
			BaseMoz.NativeMethodInfoPtr_Reset_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665061);
			BaseMoz.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665062);
			BaseMoz.NativeMethodInfoPtr_PrepareToMoz_Public_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665063);
			BaseMoz.NativeMethodInfoPtr_invokePrepareToMoz_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665064);
			BaseMoz.NativeMethodInfoPtr_ManagedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665065);
			BaseMoz.NativeMethodInfoPtr_initMoz_Protected_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665066);
			BaseMoz.NativeMethodInfoPtr_updateMoz_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665067);
			BaseMoz.NativeMethodInfoPtr_endMoz_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665068);
			BaseMoz.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665069);
			BaseMoz.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665070);
			BaseMoz.NativeMethodInfoPtr_LosePointer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665071);
			BaseMoz.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665072);
			BaseMoz.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665073);
			BaseMoz.NativeMethodInfoPtr_CalculateRectTransformEdgeBleed_Protected_Vector2_RectTransform_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665074);
			BaseMoz.NativeMethodInfoPtr_Event_ToggleMozOnButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665075);
			BaseMoz.NativeMethodInfoPtr_Event_ActivateMozOnToggleState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665076);
			BaseMoz.NativeMethodInfoPtr_Event_EndMoz_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665077);
			BaseMoz.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr, 100665078);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0004309C File Offset: 0x0004129C
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x000430D8 File Offset: 0x000412D8
		public unsafe bool MozActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_get_MozActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483221, RefRangeEnd = 483222, XrefRangeStart = 483221, XrefRangeEnd = 483222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_set_MozActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00043118 File Offset: 0x00041318
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 509207, RefRangeEnd = 509213, XrefRangeStart = 509197, XrefRangeEnd = 509207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMoz.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00043154 File Offset: 0x00041354
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMoz.NativeMethodInfoPtr_Reset_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00043190 File Offset: 0x00041390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509225, RefRangeEnd = 509227, XrefRangeStart = 509213, XrefRangeEnd = 509225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000431D4 File Offset: 0x000413D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509227, XrefRangeEnd = 509239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareToMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_PrepareToMoz_Public_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00043218 File Offset: 0x00041418
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void invokePrepareToMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMoz.NativeMethodInfoPtr_invokePrepareToMoz_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00043268 File Offset: 0x00041468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509259, RefRangeEnd = 509261, XrefRangeStart = 509239, XrefRangeEnd = 509259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManagedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_ManagedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0004329C File Offset: 0x0004149C
		[CallerCount(0)]
		public unsafe virtual void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMoz.NativeMethodInfoPtr_initMoz_Protected_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000432EC File Offset: 0x000414EC
		[CallerCount(0)]
		public unsafe virtual void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMoz.NativeMethodInfoPtr_updateMoz_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00043328 File Offset: 0x00041528
		[CallerCount(0)]
		public unsafe virtual void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseMoz.NativeMethodInfoPtr_endMoz_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00043364 File Offset: 0x00041564
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 509262, RefRangeEnd = 509265, XrefRangeStart = 509261, XrefRangeEnd = 509262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000433A8 File Offset: 0x000415A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509265, XrefRangeEnd = 509270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000433EC File Offset: 0x000415EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509270, XrefRangeEnd = 509271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LosePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_LosePointer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00043420 File Offset: 0x00041620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00043454 File Offset: 0x00041654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509271, XrefRangeEnd = 509276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00043488 File Offset: 0x00041688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509276, XrefRangeEnd = 509288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateRectTransformEdgeBleed(RectTransform rectTransform, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_CalculateRectTransformEdgeBleed_Protected_Vector2_RectTransform_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000434E8 File Offset: 0x000416E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509288, RefRangeEnd = 509289, XrefRangeStart = 509288, XrefRangeEnd = 509288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleMozOnButtonPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_Event_ToggleMozOnButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0004351C File Offset: 0x0004171C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509289, RefRangeEnd = 509291, XrefRangeStart = 509289, XrefRangeEnd = 509289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ActivateMozOnToggleState(bool toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toggle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_Event_ActivateMozOnToggleState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004355C File Offset: 0x0004175C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 509291, RefRangeEnd = 509293, XrefRangeStart = 509291, XrefRangeEnd = 509291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_EndMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr_Event_EndMoz_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00043590 File Offset: 0x00041790
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 509296, RefRangeEnd = 509303, XrefRangeStart = 509293, XrefRangeEnd = 509296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseMoz.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00007A89 File Offset: 0x00005C89
		public BaseMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x000435CC File Offset: 0x000417CC
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00007A92 File Offset: 0x00005C92
		public unsafe bool isMozExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_isMozExclusive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_isMozExclusive)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x000435F4 File Offset: 0x000417F4
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00007AAD File Offset: 0x00005CAD
		public unsafe float mozDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_mozDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_mozDelay)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0004361C File Offset: 0x0004181C
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public unsafe PointerEventData enterEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_enterEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_enterEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0004364C File Offset: 0x0004184C
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00007AE7 File Offset: 0x00005CE7
		public unsafe bool isPointerEntered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_isPointerEntered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_isPointerEntered)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00043674 File Offset: 0x00041874
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00007B02 File Offset: 0x00005D02
		public unsafe bool _MozActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr__MozActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr__MozActive_k__BackingField)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0004369C File Offset: 0x0004189C
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00007B1D File Offset: 0x00005D1D
		public unsafe float showMozTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_showMozTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_showMozTime)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000436C4 File Offset: 0x000418C4
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00007B38 File Offset: 0x00005D38
		public unsafe bool disableMozForPhones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_disableMozForPhones);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_disableMozForPhones)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000436EC File Offset: 0x000418EC
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007B53 File Offset: 0x00005D53
		public unsafe bool ignorePointerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_ignorePointerEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_ignorePointerEnter)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00043714 File Offset: 0x00041914
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00007B6E File Offset: 0x00005D6E
		public unsafe MozManager mozManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_mozManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MozManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_mozManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00043744 File Offset: 0x00041944
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00007B8D File Offset: 0x00005D8D
		public unsafe CurrentInputModuleType currentInputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_currentInputModuleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurrentInputModuleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_currentInputModuleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00043774 File Offset: 0x00041974
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x00007BAC File Offset: 0x00005DAC
		public unsafe Vector3 mousePositionLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_mousePositionLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_mousePositionLastFrame)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0004379C File Offset: 0x0004199C
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00007BC7 File Offset: 0x00005DC7
		public unsafe bool touchInputWasLastDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_touchInputWasLastDetected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_touchInputWasLastDetected)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000437C4 File Offset: 0x000419C4
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00007BE2 File Offset: 0x00005DE2
		public unsafe bool Overridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_Overridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseMoz.NativeFieldInfoPtr_Overridden)) = value;
			}
		}

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_isMozExclusive;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_mozDelay;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_enterEventData;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_isPointerEntered;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr__MozActive_k__BackingField;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_showMozTime;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_disableMozForPhones;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_ignorePointerEnter;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_mozManager;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_currentInputModuleType;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_mousePositionLastFrame;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_touchInputWasLastDetected;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_Overridden;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_get_MozActive_Public_get_Boolean_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_set_MozActive_Private_set_Void_Boolean_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Virtual_New_Void_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_PrepareToMoz_Public_Void_PointerEventData_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_invokePrepareToMoz_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_ManagedUpdate_Public_Void_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Abstract_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_LosePointer_Public_Void_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRectTransformEdgeBleed_Protected_Vector2_RectTransform_Camera_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMozOnButtonPress_Public_Void_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_Event_ActivateMozOnToggleState_Public_Void_Boolean_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_Event_EndMoz_Public_Void_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
