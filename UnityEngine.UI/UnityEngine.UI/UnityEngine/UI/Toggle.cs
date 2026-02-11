using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003B RID: 59
	public class Toggle : Selectable
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x000250E4 File Offset: 0x000232E4
		// Note: this type is marked as 'beforefieldinit'.
		static Toggle()
		{
			Il2CppClassPointerStore<Toggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Toggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle>.NativeClassPtr);
			Toggle.NativeFieldInfoPtr_toggleTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "toggleTransition");
			Toggle.NativeFieldInfoPtr_graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "graphic");
			Toggle.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "m_Group");
			Toggle.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "onValueChanged");
			Toggle.NativeFieldInfoPtr_m_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "m_IsOn");
			Toggle.NativeMethodInfoPtr_get_group_Public_get_ToggleGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664531);
			Toggle.NativeMethodInfoPtr_set_group_Public_set_Void_ToggleGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664532);
			Toggle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664533);
			Toggle.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664534);
			Toggle.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664535);
			Toggle.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664536);
			Toggle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664537);
			Toggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664538);
			Toggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664539);
			Toggle.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664540);
			Toggle.NativeMethodInfoPtr_SetToggleGroup_Private_Void_ToggleGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664541);
			Toggle.NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664542);
			Toggle.NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664543);
			Toggle.NativeMethodInfoPtr_SetIsOnWithoutNotify_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664544);
			Toggle.NativeMethodInfoPtr_Set_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664545);
			Toggle.NativeMethodInfoPtr_PlayEffect_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664546);
			Toggle.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664547);
			Toggle.NativeMethodInfoPtr_InternalToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664548);
			Toggle.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664549);
			Toggle.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664550);
			Toggle.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664551);
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002531C File Offset: 0x0002351C
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0002535C File Offset: 0x0002355C
		public unsafe ToggleGroup group
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_get_group_Public_get_ToggleGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1092788, RefRangeEnd = 1092793, XrefRangeStart = 1092786, XrefRangeEnd = 1092788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_set_group_Public_set_Void_ToggleGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000253A0 File Offset: 0x000235A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1092804, RefRangeEnd = 1092806, XrefRangeStart = 1092793, XrefRangeEnd = 1092804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000253DC File Offset: 0x000235DC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00025428 File Offset: 0x00023628
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00025464 File Offset: 0x00023664
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000254A0 File Offset: 0x000236A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092806, XrefRangeEnd = 1092813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000254DC File Offset: 0x000236DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092813, XrefRangeEnd = 1092816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00025518 File Offset: 0x00023718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092816, XrefRangeEnd = 1092818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00025554 File Offset: 0x00023754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092818, XrefRangeEnd = 1092830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00025590 File Offset: 0x00023790
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1092856, RefRangeEnd = 1092859, XrefRangeStart = 1092830, XrefRangeEnd = 1092856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setMemberValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_SetToggleGroup_Private_Void_ToggleGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000255E0 File Offset: 0x000237E0
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0002561C File Offset: 0x0002381C
		public unsafe bool isOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 1092860, RefRangeEnd = 1092943, XrefRangeStart = 1092859, XrefRangeEnd = 1092860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002565C File Offset: 0x0002385C
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1092944, RefRangeEnd = 1092973, XrefRangeStart = 1092943, XrefRangeEnd = 1092944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOnWithoutNotify(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_SetIsOnWithoutNotify_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002569C File Offset: 0x0002389C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1092987, RefRangeEnd = 1092998, XrefRangeStart = 1092973, XrefRangeEnd = 1092987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool value, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_Set_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000256E8 File Offset: 0x000238E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1093003, RefRangeEnd = 1093007, XrefRangeStart = 1092998, XrefRangeEnd = 1093003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayEffect(bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_PlayEffect_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00025728 File Offset: 0x00023928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093008, RefRangeEnd = 1093009, XrefRangeStart = 1093007, XrefRangeEnd = 1093008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00025764 File Offset: 0x00023964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093010, RefRangeEnd = 1093011, XrefRangeStart = 1093009, XrefRangeEnd = 1093010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_InternalToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00025798 File Offset: 0x00023998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093012, RefRangeEnd = 1093013, XrefRangeStart = 1093011, XrefRangeEnd = 1093012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000257E8 File Offset: 0x000239E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093010, RefRangeEnd = 1093011, XrefRangeStart = 1093010, XrefRangeEnd = 1093011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00025838 File Offset: 0x00023A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000049C3 File Offset: 0x00002BC3
		public Toggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00025878 File Offset: 0x00023A78
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x000049CC File Offset: 0x00002BCC
		public unsafe Toggle.ToggleTransition toggleTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_toggleTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_toggleTransition)) = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000258A0 File Offset: 0x00023AA0
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x000049E7 File Offset: 0x00002BE7
		public unsafe Graphic graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x000258D0 File Offset: 0x00023AD0
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00004A06 File Offset: 0x00002C06
		public unsafe ToggleGroup m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00025900 File Offset: 0x00023B00
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00004A25 File Offset: 0x00002C25
		public unsafe Toggle.ToggleEvent onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle.ToggleEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00025930 File Offset: 0x00023B30
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00004A44 File Offset: 0x00002C44
		public unsafe bool m_IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_IsOn)) = value;
			}
		}

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_toggleTransition;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_graphic;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOn;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_get_group_Public_get_ToggleGroup_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_set_group_Public_set_Void_ToggleGroup_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_SetToggleGroup_Private_Void_ToggleGroup_Boolean_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOnWithoutNotify_Public_Void_Boolean_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Boolean_Boolean_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_PlayEffect_Private_Void_Boolean_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_InternalToggle_Private_Void_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000B8 RID: 184
		public enum ToggleTransition
		{
			// Token: 0x04000A18 RID: 2584
			None,
			// Token: 0x04000A19 RID: 2585
			Fade
		}

		// Token: 0x020000B9 RID: 185
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
			// Token: 0x06000CF0 RID: 3312 RVA: 0x00006EA2 File Offset: 0x000050A2
			// Note: this type is marked as 'beforefieldinit'.
			static ToggleEvent()
			{
				Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "ToggleEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr);
				Toggle.ToggleEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr, 100664552);
			}

			// Token: 0x06000CF1 RID: 3313 RVA: 0x00037B0C File Offset: 0x00035D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1092783, XrefRangeEnd = 1092786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToggleEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.ToggleEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CF2 RID: 3314 RVA: 0x00006ED6 File Offset: 0x000050D6
			public ToggleEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000A1A RID: 2586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
