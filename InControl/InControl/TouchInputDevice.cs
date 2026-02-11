using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl
{
	// Token: 0x02000056 RID: 86
	public class TouchInputDevice : InputDevice
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x000055C9 File Offset: 0x000037C9
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInputDevice()
		{
			Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr);
			TouchInputDevice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr, 100664368);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000253F8 File Offset: 0x000235F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 785223, XrefRangeEnd = 785229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInputDevice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInputDevice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputDevice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00005602 File Offset: 0x00003802
		public TouchInputDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
