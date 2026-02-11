using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using XInputDotNetPure;

namespace InControl
{
	// Token: 0x02000072 RID: 114
	public class XInputDevice : InputDevice
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x0002E068 File Offset: 0x0002C268
		// Note: this type is marked as 'beforefieldinit'.
		static XInputDevice()
		{
			Il2CppClassPointerStore<XInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "XInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr);
			XInputDevice.NativeFieldInfoPtr_LowerDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, "LowerDeadZone");
			XInputDevice.NativeFieldInfoPtr_UpperDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, "UpperDeadZone");
			XInputDevice.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, "owner");
			XInputDevice.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, "state");
			XInputDevice.NativeFieldInfoPtr__DeviceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, "<DeviceIndex>k__BackingField");
			XInputDevice.NativeMethodInfoPtr_get_DeviceIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664750);
			XInputDevice.NativeMethodInfoPtr_set_DeviceIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664751);
			XInputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_XInputDeviceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664752);
			XInputDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664753);
			XInputDevice.NativeMethodInfoPtr_Vibrate_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664754);
			XInputDevice.NativeMethodInfoPtr_GetState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664755);
			XInputDevice.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr, 100664756);
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002E188 File Offset: 0x0002C388
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		public unsafe int DeviceIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDevice.NativeMethodInfoPtr_get_DeviceIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDevice.NativeMethodInfoPtr_set_DeviceIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0002E204 File Offset: 0x0002C404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 791214, RefRangeEnd = 791215, XrefRangeStart = 791130, XrefRangeEnd = 791214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XInputDevice(int deviceIndex, XInputDeviceManager owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDevice.NativeMethodInfoPtr__ctor_Public_Void_Int32_XInputDeviceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0002E260 File Offset: 0x0002C460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791215, XrefRangeEnd = 791234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XInputDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002E2B8 File Offset: 0x0002C4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791234, XrefRangeEnd = 791235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Vibrate(float leftSpeed, float rightSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftSpeed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XInputDevice.NativeMethodInfoPtr_Vibrate_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0002E310 File Offset: 0x0002C510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 791238, RefRangeEnd = 791240, XrefRangeStart = 791235, XrefRangeEnd = 791238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDevice.NativeMethodInfoPtr_GetState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002E344 File Offset: 0x0002C544
		public unsafe bool IsConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XInputDevice.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00005EA9 File Offset: 0x000040A9
		public XInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002E380 File Offset: 0x0002C580
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00005EB2 File Offset: 0x000040B2
		public unsafe static float LowerDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(XInputDevice.NativeFieldInfoPtr_LowerDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XInputDevice.NativeFieldInfoPtr_LowerDeadZone, (void*)(&value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002E39C File Offset: 0x0002C59C
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00005EC0 File Offset: 0x000040C0
		public unsafe static float UpperDeadZone
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(XInputDevice.NativeFieldInfoPtr_UpperDeadZone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XInputDevice.NativeFieldInfoPtr_UpperDeadZone, (void*)(&value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002E3B8 File Offset: 0x0002C5B8
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00005ECE File Offset: 0x000040CE
		public unsafe XInputDeviceManager owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDevice.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XInputDeviceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDevice.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002E3E8 File Offset: 0x0002C5E8
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00005EED File Offset: 0x000040ED
		public unsafe GamePadState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDevice.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDevice.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002E410 File Offset: 0x0002C610
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00005F08 File Offset: 0x00004108
		public unsafe int _DeviceIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDevice.NativeFieldInfoPtr__DeviceIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XInputDevice.NativeFieldInfoPtr__DeviceIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_LowerDeadZone;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_UpperDeadZone;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr__DeviceIndex_k__BackingField;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_get_DeviceIndex_Public_get_Int32_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_set_DeviceIndex_Private_set_Void_Int32_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_XInputDeviceManager_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_Vibrate_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Internal_Void_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;
	}
}
