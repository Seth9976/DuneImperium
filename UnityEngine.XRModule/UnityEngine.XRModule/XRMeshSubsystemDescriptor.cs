using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000018 RID: 24
	public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem>
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00002C34 File Offset: 0x00000E34
		// Note: this type is marked as 'beforefieldinit'.
		static XRMeshSubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRMeshSubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr);
			XRMeshSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr, 100663387);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00006694 File Offset: 0x00004894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258902, XrefRangeEnd = 1258905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRMeshSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRMeshSubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002C6D File Offset: 0x00000E6D
		public XRMeshSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
