using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.data.async
{
	// Token: 0x020001E5 RID: 485
	public class IAsyncData : Il2CppObjectBase
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x0007DCD0 File Offset: 0x0007BED0
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncData()
		{
			Il2CppClassPointerStore<IAsyncData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.async", "IAsyncData");
			IAsyncData.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncData>.NativeClassPtr, 100667512);
			IAsyncData.NativeMethodInfoPtr_get_RequestError_Public_Virtual_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncData>.NativeClassPtr, 100667513);
			IAsyncData.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncData>.NativeClassPtr, 100667514);
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0007DD34 File Offset: 0x0007BF34
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncData.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0007DD7C File Offset: 0x0007BF7C
		public unsafe virtual ErrorInfo RequestError
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883793, XrefRangeEnd = 883797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncData.NativeMethodInfoPtr_get_RequestError_Public_Virtual_New_get_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0007DDC0 File Offset: 0x0007BFC0
		[CallerCount(0)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncData.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000B74C File Offset: 0x0000994C
		public IAsyncData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestError_Public_Virtual_New_get_ErrorInfo_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0;
	}
}
