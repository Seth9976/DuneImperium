using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.utils
{
	// Token: 0x020000F3 RID: 243
	public static class GameObjectUtils : global::Il2CppSystem.Object
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x0000704D File Offset: 0x0000524D
		// Note: this type is marked as 'beforefieldinit'.
		static GameObjectUtils()
		{
			Il2CppClassPointerStore<GameObjectUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.utils", "GameObjectUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectUtils>.NativeClassPtr);
			GameObjectUtils.NativeMethodInfoPtr_GetFullPath_Public_Static_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtils>.NativeClassPtr, 100664800);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0003E430 File Offset: 0x0003C630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506755, XrefRangeEnd = 506772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPath(this GameObject go)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtils.NativeMethodInfoPtr_GetFullPath_Public_Static_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00007086 File Offset: 0x00005286
		public GameObjectUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPath_Public_Static_String_GameObject_0;
	}
}
