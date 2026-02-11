using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks.ServerList
{
	// Token: 0x020000DD RID: 221
	public class LocalNetwork : Base
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x0005AF2C File Offset: 0x0005912C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalNetwork()
		{
			Il2CppClassPointerStore<LocalNetwork>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "LocalNetwork");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalNetwork>.NativeClassPtr);
			LocalNetwork.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNetwork>.NativeClassPtr, 100666727);
			LocalNetwork.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalNetwork>.NativeClassPtr, 100666728);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0005AF84 File Offset: 0x00059184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950110, XrefRangeEnd = 950113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LaunchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalNetwork.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0005AFC0 File Offset: 0x000591C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalNetwork()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalNetwork>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalNetwork.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00003EF2 File Offset: 0x000020F2
		public LocalNetwork(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
