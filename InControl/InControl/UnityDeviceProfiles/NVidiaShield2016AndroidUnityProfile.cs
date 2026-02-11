using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200018D RID: 397
	public class NVidiaShield2016AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F6A RID: 3946 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		// Note: this type is marked as 'beforefieldinit'.
		static NVidiaShield2016AndroidUnityProfile()
		{
			Il2CppClassPointerStore<NVidiaShield2016AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NVidiaShield2016AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NVidiaShield2016AndroidUnityProfile>.NativeClassPtr);
			NVidiaShield2016AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShield2016AndroidUnityProfile>.NativeClassPtr, 100665388);
			NVidiaShield2016AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NVidiaShield2016AndroidUnityProfile>.NativeClassPtr, 100665389);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0003E22C File Offset: 0x0003C42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825490, XrefRangeEnd = 825658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NVidiaShield2016AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0003E268 File Offset: 0x0003C468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 825658, XrefRangeEnd = 825662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NVidiaShield2016AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NVidiaShield2016AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NVidiaShield2016AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00006B1B File Offset: 0x00004D1B
		public NVidiaShield2016AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
