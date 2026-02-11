using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004ED RID: 1261
	public static class KeyValuePair : Object
	{
		// Token: 0x06004DB5 RID: 19893 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePair()
		{
			Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyValuePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr);
			KeyValuePair.NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr, 100674971);
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x001689BC File Offset: 0x00166BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1420617, RefRangeEnd = 1420618, XrefRangeStart = 1420607, XrefRangeEnd = 1420617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PairToString(Object key, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair.NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x0001C1FD File Offset: 0x0001A3FD
		public KeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F89 RID: 16265
		private static readonly IntPtr NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0;
	}
}
