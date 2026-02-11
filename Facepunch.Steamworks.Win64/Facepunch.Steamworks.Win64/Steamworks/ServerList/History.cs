using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks.ServerList
{
	// Token: 0x020000DA RID: 218
	public class History : Base
	{
		// Token: 0x06000E91 RID: 3729 RVA: 0x0005AB54 File Offset: 0x00058D54
		// Note: this type is marked as 'beforefieldinit'.
		static History()
		{
			Il2CppClassPointerStore<History>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "History");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<History>.NativeClassPtr);
			History.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100666717);
			History.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<History>.NativeClassPtr, 100666718);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0005ABAC File Offset: 0x00058DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949949, XrefRangeEnd = 949952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LaunchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), History.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0005ABE8 File Offset: 0x00058DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe History()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<History>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(History.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00003E8F File Offset: 0x0000208F
		public History(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
