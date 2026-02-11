using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000061 RID: 97
	public class UnityInputDeviceProfileList : ScriptableObject
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x00028C34 File Offset: 0x00026E34
		// Note: this type is marked as 'beforefieldinit'.
		static UnityInputDeviceProfileList()
		{
			Il2CppClassPointerStore<UnityInputDeviceProfileList>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnityInputDeviceProfileList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputDeviceProfileList>.NativeClassPtr);
			UnityInputDeviceProfileList.NativeFieldInfoPtr_Profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDeviceProfileList>.NativeClassPtr, "Profiles");
			UnityInputDeviceProfileList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceProfileList>.NativeClassPtr, 100664505);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00028C8C File Offset: 0x00026E8C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityInputDeviceProfileList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDeviceProfileList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceProfileList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00005C45 File Offset: 0x00003E45
		public UnityInputDeviceProfileList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00028CC8 File Offset: 0x00026EC8
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00005C4E File Offset: 0x00003E4E
		public unsafe static Il2CppStringArray Profiles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDeviceProfileList.NativeFieldInfoPtr_Profiles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDeviceProfileList.NativeFieldInfoPtr_Profiles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_Profiles;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
