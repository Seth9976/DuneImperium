using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.moz
{
	// Token: 0x02000119 RID: 281
	public class IUseTapMoz : Il2CppObjectBase
	{
		// Token: 0x06000C90 RID: 3216 RVA: 0x000452C4 File Offset: 0x000434C4
		// Note: this type is marked as 'beforefieldinit'.
		static IUseTapMoz()
		{
			Il2CppClassPointerStore<IUseTapMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "IUseTapMoz");
			IUseTapMoz.NativeMethodInfoPtr_ShouldUse_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUseTapMoz>.NativeClassPtr, 100665127);
			IUseTapMoz.NativeMethodInfoPtr_ShouldUseTap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUseTapMoz>.NativeClassPtr, 100665128);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00045314 File Offset: 0x00043514
		[CallerCount(0)]
		public unsafe virtual bool ShouldUse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUseTapMoz.NativeMethodInfoPtr_ShouldUse_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0004535C File Offset: 0x0004355C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509866, RefRangeEnd = 509867, XrefRangeStart = 509856, XrefRangeEnd = 509866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldUseTap()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUseTapMoz.NativeMethodInfoPtr_ShouldUseTap_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000081B6 File Offset: 0x000063B6
		public IUseTapMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUse_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUseTap_Public_Static_Boolean_0;
	}
}
