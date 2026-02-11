using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace InControl
{
	// Token: 0x02000038 RID: 56
	public class InputDeviceManager : Object
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00018F88 File Offset: 0x00017188
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceManager()
		{
			Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputDeviceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr);
			InputDeviceManager.NativeFieldInfoPtr_devices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr, "devices");
			InputDeviceManager.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr, 100663931);
			InputDeviceManager.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr, 100663932);
			InputDeviceManager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr, 100663933);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00019008 File Offset: 0x00017208
		[CallerCount(0)]
		public unsafe virtual void Update(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceManager.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00019060 File Offset: 0x00017260
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDeviceManager.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001909C File Offset: 0x0001729C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 774902, RefRangeEnd = 774905, XrefRangeStart = 774894, XrefRangeEnd = 774902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDeviceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDeviceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceManager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00003D6C File Offset: 0x00001F6C
		public InputDeviceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x000190D8 File Offset: 0x000172D8
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00003D75 File Offset: 0x00001F75
		public unsafe List<InputDevice> devices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceManager.NativeFieldInfoPtr_devices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDeviceManager.NativeFieldInfoPtr_devices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_devices;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UInt64_Single_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
