using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks.ServerList
{
	// Token: 0x020000D8 RID: 216
	public class Favourites : Base
	{
		// Token: 0x06000E89 RID: 3721 RVA: 0x0005A9B4 File Offset: 0x00058BB4
		// Note: this type is marked as 'beforefieldinit'.
		static Favourites()
		{
			Il2CppClassPointerStore<Favourites>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "Favourites");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Favourites>.NativeClassPtr);
			Favourites.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Favourites>.NativeClassPtr, 100666713);
			Favourites.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Favourites>.NativeClassPtr, 100666714);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0005AA0C File Offset: 0x00058C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949930, XrefRangeEnd = 949933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LaunchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Favourites.NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0005AA48 File Offset: 0x00058C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949933, XrefRangeEnd = 949946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Favourites()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Favourites>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Favourites.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00003E7D File Offset: 0x0000207D
		public Favourites(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_LaunchQuery_Internal_Virtual_Void_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
