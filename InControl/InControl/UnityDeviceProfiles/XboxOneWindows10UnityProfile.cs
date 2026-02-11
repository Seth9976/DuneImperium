using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000206 RID: 518
	public class XboxOneWindows10UnityProfile : InputDeviceProfile
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x00044424 File Offset: 0x00042624
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneWindows10UnityProfile()
		{
			Il2CppClassPointerStore<XboxOneWindows10UnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "XboxOneWindows10UnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneWindows10UnityProfile>.NativeClassPtr);
			XboxOneWindows10UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneWindows10UnityProfile>.NativeClassPtr, 100665630);
			XboxOneWindows10UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneWindows10UnityProfile>.NativeClassPtr, 100665631);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0004447C File Offset: 0x0004267C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849591, XrefRangeEnd = 849862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneWindows10UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x000444B8 File Offset: 0x000426B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 849862, XrefRangeEnd = 849866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneWindows10UnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneWindows10UnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneWindows10UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00006F5C File Offset: 0x0000515C
		public XboxOneWindows10UnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
