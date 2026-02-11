using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004A RID: 74
	public class NativeInputDeviceProfileList : ScriptableObject
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00021410 File Offset: 0x0001F610
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputDeviceProfileList()
		{
			Il2CppClassPointerStore<NativeInputDeviceProfileList>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "NativeInputDeviceProfileList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputDeviceProfileList>.NativeClassPtr);
			NativeInputDeviceProfileList.NativeFieldInfoPtr_Profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputDeviceProfileList>.NativeClassPtr, "Profiles");
			NativeInputDeviceProfileList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceProfileList>.NativeClassPtr, 100664255);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00021468 File Offset: 0x0001F668
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeInputDeviceProfileList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeInputDeviceProfileList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceProfileList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00004B2E File Offset: 0x00002D2E
		public NativeInputDeviceProfileList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000214A4 File Offset: 0x0001F6A4
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00004B37 File Offset: 0x00002D37
		public unsafe static Il2CppStringArray Profiles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputDeviceProfileList.NativeFieldInfoPtr_Profiles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputDeviceProfileList.NativeFieldInfoPtr_Profiles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_Profiles;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
