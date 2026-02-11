using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000049 RID: 73
	public class NativeInputDeviceProfileAttribute : Attribute
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x00004AEC File Offset: 0x00002CEC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputDeviceProfileAttribute()
		{
			Il2CppClassPointerStore<NativeInputDeviceProfileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "NativeInputDeviceProfileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputDeviceProfileAttribute>.NativeClassPtr);
			NativeInputDeviceProfileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputDeviceProfileAttribute>.NativeClassPtr, 100664254);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000213D4 File Offset: 0x0001F5D4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeInputDeviceProfileAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeInputDeviceProfileAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputDeviceProfileAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00004B25 File Offset: 0x00002D25
		public NativeInputDeviceProfileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
