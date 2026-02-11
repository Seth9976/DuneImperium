using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.moz
{
	// Token: 0x0200011A RID: 282
	public class MobileTapMoz : Object
	{
		// Token: 0x06000C94 RID: 3220 RVA: 0x0004538C File Offset: 0x0004358C
		// Note: this type is marked as 'beforefieldinit'.
		static MobileTapMoz()
		{
			Il2CppClassPointerStore<MobileTapMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "MobileTapMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileTapMoz>.NativeClassPtr);
			MobileTapMoz.NativeMethodInfoPtr_ShouldUse_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTapMoz>.NativeClassPtr, 100665129);
			MobileTapMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTapMoz>.NativeClassPtr, 100665130);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000453E4 File Offset: 0x000435E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509867, XrefRangeEnd = 509870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldUse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTapMoz.NativeMethodInfoPtr_ShouldUse_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00045420 File Offset: 0x00043620
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MobileTapMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileTapMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MobileTapMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000081BF File Offset: 0x000063BF
		public MobileTapMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUse_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
