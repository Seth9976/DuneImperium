using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks.ServerList
{
	// Token: 0x020000DB RID: 219
	public class Internet : Base
	{
		// Token: 0x06000E95 RID: 3733 RVA: 0x0005AC24 File Offset: 0x00058E24
		// Note: this type is marked as 'beforefieldinit'.
		static Internet()
		{
			Il2CppClassPointerStore<Internet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "Internet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Internet>.NativeClassPtr);
			Internet.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Internet>.NativeClassPtr, 100666719);
			Internet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Internet>.NativeClassPtr, 100666720);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0005AC7C File Offset: 0x00058E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949952, XrefRangeEnd = 949955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LaunchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Internet.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0005ACB8 File Offset: 0x00058EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Internet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Internet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Internet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00003E98 File Offset: 0x00002098
		public Internet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
