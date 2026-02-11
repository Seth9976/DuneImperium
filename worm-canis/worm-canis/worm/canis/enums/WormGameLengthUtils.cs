using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.canis.enums
{
	// Token: 0x0200003F RID: 63
	public static class WormGameLengthUtils : Object
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00003DAF File Offset: 0x00001FAF
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameLengthUtils()
		{
			Il2CppClassPointerStore<WormGameLengthUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.enums", "WormGameLengthUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameLengthUtils>.NativeClassPtr);
			WormGameLengthUtils.NativeMethodInfoPtr_PointsForGameLength_Public_Static_Int32_WormGameLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameLengthUtils>.NativeClassPtr, 100664719);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0007EBDC File Offset: 0x0007CDDC
		[CallerCount(0)]
		public unsafe static int PointsForGameLength(this WormGameLength len)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameLengthUtils.NativeMethodInfoPtr_PointsForGameLength_Public_Static_Int32_WormGameLength_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00003DE8 File Offset: 0x00001FE8
		public WormGameLengthUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_PointsForGameLength_Public_Static_Int32_WormGameLength_0;
	}
}
