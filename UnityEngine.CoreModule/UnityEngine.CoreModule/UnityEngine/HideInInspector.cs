using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012B RID: 299
	public sealed class HideInInspector : Attribute
	{
		// Token: 0x060017A3 RID: 6051 RVA: 0x000095B2 File Offset: 0x000077B2
		// Note: this type is marked as 'beforefieldinit'.
		static HideInInspector()
		{
			Il2CppClassPointerStore<HideInInspector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HideInInspector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr);
			HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr, 100666527);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0007001C File Offset: 0x0006E21C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideInInspector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000095EB File Offset: 0x000077EB
		public HideInInspector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
