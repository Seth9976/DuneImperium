using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000060 RID: 96
	public class UnityInputDeviceProfileAttribute : Attribute
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x00005C03 File Offset: 0x00003E03
		// Note: this type is marked as 'beforefieldinit'.
		static UnityInputDeviceProfileAttribute()
		{
			Il2CppClassPointerStore<UnityInputDeviceProfileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnityInputDeviceProfileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputDeviceProfileAttribute>.NativeClassPtr);
			UnityInputDeviceProfileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDeviceProfileAttribute>.NativeClassPtr, 100664504);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00028BF8 File Offset: 0x00026DF8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityInputDeviceProfileAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDeviceProfileAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDeviceProfileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00005C3C File Offset: 0x00003E3C
		public UnityInputDeviceProfileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
