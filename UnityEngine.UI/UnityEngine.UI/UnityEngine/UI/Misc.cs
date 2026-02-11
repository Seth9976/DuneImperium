using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200002E RID: 46
	public static class Misc : Object
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x0001B868 File Offset: 0x00019A68
		// Note: this type is marked as 'beforefieldinit'.
		static Misc()
		{
			Il2CppClassPointerStore<Misc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Misc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Misc>.NativeClassPtr);
			Misc.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Misc>.NativeClassPtr, 100664161);
			Misc.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Misc>.NativeClassPtr, 100664162);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090154, XrefRangeEnd = 1090172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Misc.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0001B8F8 File Offset: 0x00019AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1090185, RefRangeEnd = 1090187, XrefRangeStart = 1090172, XrefRangeEnd = 1090185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Misc.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00003C89 File Offset: 0x00001E89
		public Misc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;
	}
}
