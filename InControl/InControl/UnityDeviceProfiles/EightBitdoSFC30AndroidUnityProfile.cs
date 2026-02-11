using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000173 RID: 371
	public class EightBitdoSFC30AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000F02 RID: 3842 RVA: 0x0003CCB4 File Offset: 0x0003AEB4
		// Note: this type is marked as 'beforefieldinit'.
		static EightBitdoSFC30AndroidUnityProfile()
		{
			Il2CppClassPointerStore<EightBitdoSFC30AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "EightBitdoSFC30AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightBitdoSFC30AndroidUnityProfile>.NativeClassPtr);
			EightBitdoSFC30AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoSFC30AndroidUnityProfile>.NativeClassPtr, 100665336);
			EightBitdoSFC30AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightBitdoSFC30AndroidUnityProfile>.NativeClassPtr, 100665337);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821039, XrefRangeEnd = 821180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EightBitdoSFC30AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0003CD48 File Offset: 0x0003AF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 821180, XrefRangeEnd = 821184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EightBitdoSFC30AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightBitdoSFC30AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightBitdoSFC30AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00006A31 File Offset: 0x00004C31
		public EightBitdoSFC30AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
