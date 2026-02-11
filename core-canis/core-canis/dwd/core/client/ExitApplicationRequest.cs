using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.client
{
	// Token: 0x020001EB RID: 491
	public class ExitApplicationRequest : Request
	{
		// Token: 0x06001AC3 RID: 6851 RVA: 0x0000B81B File Offset: 0x00009A1B
		// Note: this type is marked as 'beforefieldinit'.
		static ExitApplicationRequest()
		{
			Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.client", "ExitApplicationRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr);
			ExitApplicationRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr, 100667574);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x0007E880 File Offset: 0x0007CA80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 880491, RefRangeEnd = 880498, XrefRangeStart = 880491, XrefRangeEnd = 880498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitApplicationRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0000B854 File Offset: 0x00009A54
		public ExitApplicationRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
