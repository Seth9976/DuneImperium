using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lib.canis.Utils
{
	// Token: 0x02000007 RID: 7
	public static class TransformUtil : global::Il2CppSystem.Object
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000020FE File Offset: 0x000002FE
		// Note: this type is marked as 'beforefieldinit'.
		static TransformUtil()
		{
			Il2CppClassPointerStore<TransformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "lib.canis.Utils", "TransformUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtil>.NativeClassPtr);
			TransformUtil.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtil>.NativeClassPtr, 100663309);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004A9C File Offset: 0x00002C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1176370, RefRangeEnd = 1176371, XrefRangeStart = 1176355, XrefRangeEnd = 1176370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPath(this Transform current)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtil.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002137 File Offset: 0x00000337
		public TransformUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0;
	}
}
