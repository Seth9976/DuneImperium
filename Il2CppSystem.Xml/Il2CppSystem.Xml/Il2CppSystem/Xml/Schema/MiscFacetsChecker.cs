using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000174 RID: 372
	public class MiscFacetsChecker : FacetsChecker
	{
		// Token: 0x06001D7C RID: 7548 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		// Note: this type is marked as 'beforefieldinit'.
		static MiscFacetsChecker()
		{
			Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "MiscFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr);
			MiscFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr, 100667758);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0009282C File Offset: 0x00090A2C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MiscFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiscFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiscFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0000C1DD File Offset: 0x0000A3DD
		public MiscFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
