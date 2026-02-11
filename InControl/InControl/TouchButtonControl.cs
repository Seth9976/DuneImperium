using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004D RID: 77
	public class TouchButtonControl : TouchControl
	{
		// Token: 0x0600072A RID: 1834 RVA: 0x000215CC File Offset: 0x0001F7CC
		// Note: this type is marked as 'beforefieldinit'.
		static TouchButtonControl()
		{
			Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchButtonControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr);
			TouchButtonControl.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "anchor");
			TouchButtonControl.NativeFieldInfoPtr_offsetUnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "offsetUnitType");
			TouchButtonControl.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "offset");
			TouchButtonControl.NativeFieldInfoPtr_lockAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "lockAspectRatio");
			TouchButtonControl.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "target");
			TouchButtonControl.NativeFieldInfoPtr_allowSlideToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "allowSlideToggle");
			TouchButtonControl.NativeFieldInfoPtr_toggleOnLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "toggleOnLeave");
			TouchButtonControl.NativeFieldInfoPtr_pressureSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "pressureSensitive");
			TouchButtonControl.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "button");
			TouchButtonControl.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "buttonState");
			TouchButtonControl.NativeFieldInfoPtr_currentTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "currentTouch");
			TouchButtonControl.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, "dirty");
			TouchButtonControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664257);
			TouchButtonControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664258);
			TouchButtonControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664259);
			TouchButtonControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664260);
			TouchButtonControl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664261);
			TouchButtonControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664262);
			TouchButtonControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664263);
			TouchButtonControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664264);
			TouchButtonControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664265);
			TouchButtonControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664266);
			TouchButtonControl.NativeMethodInfoPtr_get_ButtonState_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664267);
			TouchButtonControl.NativeMethodInfoPtr_set_ButtonState_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664268);
			TouchButtonControl.NativeMethodInfoPtr_get_ButtonPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664269);
			TouchButtonControl.NativeMethodInfoPtr_set_ButtonPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664270);
			TouchButtonControl.NativeMethodInfoPtr_get_Anchor_Public_get_TouchControlAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664271);
			TouchButtonControl.NativeMethodInfoPtr_set_Anchor_Public_set_Void_TouchControlAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664272);
			TouchButtonControl.NativeMethodInfoPtr_get_Offset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664273);
			TouchButtonControl.NativeMethodInfoPtr_set_Offset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664274);
			TouchButtonControl.NativeMethodInfoPtr_get_OffsetUnitType_Public_get_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664275);
			TouchButtonControl.NativeMethodInfoPtr_set_OffsetUnitType_Public_set_Void_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664276);
			TouchButtonControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr, 100664277);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00021890 File Offset: 0x0001FA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784665, XrefRangeEnd = 784669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000218CC File Offset: 0x0001FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784669, XrefRangeEnd = 784674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00021908 File Offset: 0x0001FB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784674, XrefRangeEnd = 784679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00021944 File Offset: 0x0001FB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784679, XrefRangeEnd = 784684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00021980 File Offset: 0x0001FB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784684, XrefRangeEnd = 784685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000219B4 File Offset: 0x0001FBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784685, XrefRangeEnd = 784692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00021A0C File Offset: 0x0001FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784692, XrefRangeEnd = 784693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CommitControlState(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00021A64 File Offset: 0x0001FC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784693, XrefRangeEnd = 784696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchBegan(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00021AB4 File Offset: 0x0001FCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784696, XrefRangeEnd = 784699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchMoved(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00021B04 File Offset: 0x0001FD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784699, XrefRangeEnd = 784700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TouchEnded(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchButtonControl.NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00021B54 File Offset: 0x0001FD54
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00021B90 File Offset: 0x0001FD90
		public unsafe bool ButtonState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_get_ButtonState_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_set_ButtonState_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00021C0C File Offset: 0x0001FE0C
		public unsafe Vector3 ButtonPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784700, XrefRangeEnd = 784704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_get_ButtonPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784704, XrefRangeEnd = 784710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_set_ButtonPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00021C4C File Offset: 0x0001FE4C
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x00021C88 File Offset: 0x0001FE88
		public unsafe TouchControlAnchor Anchor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_get_Anchor_Public_get_TouchControlAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_set_Anchor_Public_set_Void_TouchControlAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00021CC8 File Offset: 0x0001FEC8
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00021D04 File Offset: 0x0001FF04
		public unsafe Vector2 Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_get_Offset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_set_Offset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00021D44 File Offset: 0x0001FF44
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00021D80 File Offset: 0x0001FF80
		public unsafe TouchUnitType OffsetUnitType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_get_OffsetUnitType_Public_get_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr_set_OffsetUnitType_Public_set_Void_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00021DC0 File Offset: 0x0001FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784710, XrefRangeEnd = 784716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchButtonControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchButtonControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchButtonControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00004B6D File Offset: 0x00002D6D
		public TouchButtonControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00021DFC File Offset: 0x0001FFFC
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00004B76 File Offset: 0x00002D76
		public unsafe TouchControlAnchor anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_anchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_anchor)) = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00021E24 File Offset: 0x00020024
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00004B91 File Offset: 0x00002D91
		public unsafe TouchUnitType offsetUnitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_offsetUnitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_offsetUnitType)) = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00021E4C File Offset: 0x0002004C
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00004BAC File Offset: 0x00002DAC
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00021E74 File Offset: 0x00020074
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00004BC7 File Offset: 0x00002DC7
		public unsafe bool lockAspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_lockAspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_lockAspectRatio)) = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00021E9C File Offset: 0x0002009C
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00004BE2 File Offset: 0x00002DE2
		public unsafe TouchControl.ButtonTarget target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_target);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_target)) = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00021EC4 File Offset: 0x000200C4
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00004BFD File Offset: 0x00002DFD
		public unsafe bool allowSlideToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_allowSlideToggle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_allowSlideToggle)) = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00021EEC File Offset: 0x000200EC
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00004C18 File Offset: 0x00002E18
		public unsafe bool toggleOnLeave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_toggleOnLeave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_toggleOnLeave)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00021F14 File Offset: 0x00020114
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00004C33 File Offset: 0x00002E33
		public unsafe bool pressureSensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_pressureSensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_pressureSensitive)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00021F3C File Offset: 0x0002013C
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004C4E File Offset: 0x00002E4E
		public unsafe TouchSprite button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00021F6C File Offset: 0x0002016C
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00004C6D File Offset: 0x00002E6D
		public unsafe bool buttonState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_buttonState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_buttonState)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00021F94 File Offset: 0x00020194
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00004C88 File Offset: 0x00002E88
		public unsafe Touch currentTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_currentTouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_currentTouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00021FC4 File Offset: 0x000201C4
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00004CA7 File Offset: 0x00002EA7
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchButtonControl.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_offsetUnitType;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_lockAspectRatio;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_allowSlideToggle;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_toggleOnLeave;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_pressureSensitive;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_buttonState;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_currentTouch;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_CreateControl_Public_Virtual_Void_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_DestroyControl_Public_Virtual_Void_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureControl_Public_Virtual_Void_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Virtual_Void_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_SubmitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_CommitControlState_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_TouchBegan_Public_Virtual_Void_Touch_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_TouchMoved_Public_Virtual_Void_Touch_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_TouchEnded_Public_Virtual_Void_Touch_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonState_Private_get_Boolean_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_set_ButtonState_Private_set_Void_Boolean_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_get_ButtonPosition_Public_get_Vector3_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_set_ButtonPosition_Public_set_Void_Vector3_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchor_Public_get_TouchControlAnchor_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchor_Public_set_Void_TouchControlAnchor_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Vector2_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_set_Offset_Public_set_Void_Vector2_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetUnitType_Public_get_TouchUnitType_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetUnitType_Public_set_Void_TouchUnitType_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
