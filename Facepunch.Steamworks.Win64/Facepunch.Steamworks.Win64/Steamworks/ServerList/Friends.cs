using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks.ServerList
{
	// Token: 0x020000D9 RID: 217
	public class Friends : Base
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x0005AA84 File Offset: 0x00058C84
		// Note: this type is marked as 'beforefieldinit'.
		static Friends()
		{
			Il2CppClassPointerStore<Friends>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "Friends");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friends>.NativeClassPtr);
			Friends.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friends>.NativeClassPtr, 100666715);
			Friends.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friends>.NativeClassPtr, 100666716);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0005AADC File Offset: 0x00058CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949946, XrefRangeEnd = 949949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LaunchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Friends.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0005AB18 File Offset: 0x00058D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Friends()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friends>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friends.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00003E86 File Offset: 0x00002086
		public Friends(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
