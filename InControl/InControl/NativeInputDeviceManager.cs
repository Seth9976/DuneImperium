using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace InControl
{
	// Token: 0x02000048 RID: 72
	public class NativeInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00020D74 File Offset: 0x0001EF74
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputDeviceManager()
		{
			Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "NativeInputDeviceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr);
			NativeInputDeviceManager.NativeFieldInfoPtr_CustomFindDetachedDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "CustomFindDetachedDevice");
			NativeInputDeviceManager.NativeFieldInfoPtr_attachedDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "attachedDevices");
			NativeInputDeviceManager.NativeFieldInfoPtr_detachedDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "detachedDevices");
			NativeInputDeviceManager.NativeFieldInfoPtr_systemDeviceProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "systemDeviceProfiles");
			NativeInputDeviceManager.NativeFieldInfoPtr_customDeviceProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "customDeviceProfiles");
			NativeInputDeviceManager.NativeFieldInfoPtr_deviceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "deviceEvents");
			NativeInputDeviceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664236);
			NativeInputDeviceManager.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664237);
			NativeInputDeviceManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664238);
			NativeInputDeviceManager.NativeMethodInfoPtr_DetectDevice_Private_Void_UInt32_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664239);
			NativeInputDeviceManager.NativeMethodInfoPtr_AttachDevice_Private_Void_NativeInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664240);
			NativeInputDeviceManager.NativeMethodInfoPtr_DetachDevice_Private_Void_NativeInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664241);
			NativeInputDeviceManager.NativeMethodInfoPtr_FindAttachedDevice_Private_NativeInputDevice_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664242);
			NativeInputDeviceManager.NativeMethodInfoPtr_FindDetachedDevice_Private_NativeInputDevice_InputDeviceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664243);
			NativeInputDeviceManager.NativeMethodInfoPtr_SystemFindDetachedDevice_Private_Static_NativeInputDevice_InputDeviceInfo_ReadOnlyCollection_1_NativeInputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664244);
			NativeInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfile_Private_Void_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664245);
			NativeInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfiles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664246);
			NativeInputDeviceManager.NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Boolean_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664247);
			NativeInputDeviceManager.NativeMethodInfoPtr_Enable_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, 100664248);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00020F20 File Offset: 0x0001F120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784227, XrefRangeEnd = 784314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeInputDeviceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00020F5C File Offset: 0x0001F15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDeviceManager.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00020F98 File Offset: 0x0001F198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784314, XrefRangeEnd = 784403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeInputDeviceManager.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00020FF0 File Offset: 0x0001F1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 784474, RefRangeEnd = 784475, XrefRangeStart = 784403, XrefRangeEnd = 784474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectDevice(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_DetectDevice_Private_Void_UInt32_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00021048 File Offset: 0x0001F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784475, XrefRangeEnd = 784489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachDevice(NativeInputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_AttachDevice_Private_Void_NativeInputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0002108C File Offset: 0x0001F28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784489, XrefRangeEnd = 784526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachDevice(NativeInputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(device);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_DetachDevice_Private_Void_NativeInputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000210D0 File Offset: 0x0001F2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784526, XrefRangeEnd = 784530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeInputDevice FindAttachedDevice(uint deviceHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_FindAttachedDevice_Private_NativeInputDevice_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NativeInputDevice>(intPtr3) : null;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0002111C File Offset: 0x0001F31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784530, XrefRangeEnd = 784539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeInputDevice FindDetachedDevice(InputDeviceInfo deviceInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_FindDetachedDevice_Private_NativeInputDevice_InputDeviceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NativeInputDevice>(intPtr3) : null;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00021174 File Offset: 0x0001F374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 784561, RefRangeEnd = 784563, XrefRangeStart = 784539, XrefRangeEnd = 784561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeInputDevice SystemFindDetachedDevice(InputDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deviceInfo));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detachedDevices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_SystemFindDetachedDevice_Private_Static_NativeInputDevice_InputDeviceInfo_ReadOnlyCollection_1_NativeInputDevice_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NativeInputDevice>(intPtr3) : null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000211D0 File Offset: 0x0001F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784563, XrefRangeEnd = 784567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deviceProfile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfile_Private_Void_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00021214 File Offset: 0x0001F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784567, XrefRangeEnd = 784584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSystemDeviceProfiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_AddSystemDeviceProfiles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00021248 File Offset: 0x0001F448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 784627, RefRangeEnd = 784628, XrefRangeStart = 784584, XrefRangeEnd = 784627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPlatformSupport(ICollection<string> errors)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Boolean_ICollection_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0002128C File Offset: 0x0001F48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 784664, RefRangeEnd = 784665, XrefRangeStart = 784628, XrefRangeEnd = 784664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Enable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.NativeMethodInfoPtr_Enable_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00004A36 File Offset: 0x00002C36
		public NativeInputDeviceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x000212BC File Offset: 0x0001F4BC
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00004A3F File Offset: 0x00002C3F
		public unsafe static Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputDeviceManager.NativeFieldInfoPtr_CustomFindDetachedDevice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputDeviceManager.NativeFieldInfoPtr_CustomFindDetachedDevice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000212E4 File Offset: 0x0001F4E4
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00004A51 File Offset: 0x00002C51
		public unsafe List<NativeInputDevice> attachedDevices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_attachedDevices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NativeInputDevice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_attachedDevices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00021314 File Offset: 0x0001F514
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00004A70 File Offset: 0x00002C70
		public unsafe List<NativeInputDevice> detachedDevices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_detachedDevices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NativeInputDevice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_detachedDevices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00021344 File Offset: 0x0001F544
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00004A8F File Offset: 0x00002C8F
		public unsafe List<InputDeviceProfile> systemDeviceProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_systemDeviceProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDeviceProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_systemDeviceProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00021374 File Offset: 0x0001F574
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00004AAE File Offset: 0x00002CAE
		public unsafe List<InputDeviceProfile> customDeviceProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_customDeviceProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDeviceProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_customDeviceProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000213A4 File Offset: 0x0001F5A4
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00004ACD File Offset: 0x00002CCD
		public unsafe Il2CppStructArray<uint> deviceEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_deviceEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.NativeFieldInfoPtr_deviceEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_CustomFindDetachedDevice;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_attachedDevices;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_detachedDevices;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_systemDeviceProfiles;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_customDeviceProfiles;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_deviceEvents;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_DetectDevice_Private_Void_UInt32_InputDeviceInfo_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_AttachDevice_Private_Void_NativeInputDevice_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_DetachDevice_Private_Void_NativeInputDevice_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_FindAttachedDevice_Private_NativeInputDevice_UInt32_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_FindDetachedDevice_Private_NativeInputDevice_InputDeviceInfo_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_SystemFindDetachedDevice_Private_Static_NativeInputDevice_InputDeviceInfo_ReadOnlyCollection_1_NativeInputDevice_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_AddSystemDeviceProfile_Private_Void_InputDeviceProfile_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_AddSystemDeviceProfiles_Private_Void_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlatformSupport_Public_Static_Boolean_ICollection_1_String_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Internal_Static_Boolean_0;

		// Token: 0x02000218 RID: 536
		[ObfuscatedName("InControl.NativeInputDeviceManager+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600119E RID: 4510 RVA: 0x00045330 File Offset: 0x00043530
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeInputDeviceManager>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr);
				NativeInputDeviceManager.__c__DisplayClass9_0.NativeFieldInfoPtr_deviceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr, "deviceInfo");
				NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr, 100664249);
				NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__0_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr, 100664250);
				NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__1_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr, 100664251);
				NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__2_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr, 100664252);
				NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__3_Internal_Boolean_InputDeviceProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr, 100664253);
			}

			// Token: 0x0600119F RID: 4511 RVA: 0x000453D4 File Offset: 0x000435D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeInputDeviceManager.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011A0 RID: 4512 RVA: 0x00045410 File Offset: 0x00043610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784225, XrefRangeEnd = 784226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__0(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__0_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011A1 RID: 4513 RVA: 0x00045460 File Offset: 0x00043660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__1(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__1_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011A2 RID: 4514 RVA: 0x000454B0 File Offset: 0x000436B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784226, XrefRangeEnd = 784227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__2(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__2_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011A3 RID: 4515 RVA: 0x00045500 File Offset: 0x00043700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetectDevice_b__3(InputDeviceProfile profile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceManager.__c__DisplayClass9_0.NativeMethodInfoPtr__DetectDevice_b__3_Internal_Boolean_InputDeviceProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011A4 RID: 4516 RVA: 0x00007165 File Offset: 0x00005365
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00045550 File Offset: 0x00043750
			// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0000716E File Offset: 0x0000536E
			public InputDeviceInfo deviceInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.__c__DisplayClass9_0.NativeFieldInfoPtr_deviceInfo);
					return new InputDeviceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeInputDeviceManager.__c__DisplayClass9_0.NativeFieldInfoPtr_deviceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000DA6 RID: 3494
			private static readonly IntPtr NativeFieldInfoPtr_deviceInfo;

			// Token: 0x04000DA7 RID: 3495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DA8 RID: 3496
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__0_Internal_Boolean_InputDeviceProfile_0;

			// Token: 0x04000DA9 RID: 3497
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__1_Internal_Boolean_InputDeviceProfile_0;

			// Token: 0x04000DAA RID: 3498
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__2_Internal_Boolean_InputDeviceProfile_0;

			// Token: 0x04000DAB RID: 3499
			private static readonly IntPtr NativeMethodInfoPtr__DetectDevice_b__3_Internal_Boolean_InputDeviceProfile_0;
		}
	}
}
