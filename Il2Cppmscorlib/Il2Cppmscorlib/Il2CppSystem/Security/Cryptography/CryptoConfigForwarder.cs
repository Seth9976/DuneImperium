using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200027B RID: 635
	public static class CryptoConfigForwarder : Object
	{
		// Token: 0x060028F1 RID: 10481 RVA: 0x0000D8AD File Offset: 0x0000BAAD
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConfigForwarder()
		{
			Il2CppClassPointerStore<CryptoConfigForwarder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoConfigForwarder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConfigForwarder>.NativeClassPtr);
			CryptoConfigForwarder.NativeMethodInfoPtr_CreateFromName_Internal_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfigForwarder>.NativeClassPtr, 100669989);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000DBA7C File Offset: 0x000D9C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375132, RefRangeEnd = 1375133, XrefRangeStart = 1375128, XrefRangeEnd = 1375132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfigForwarder.NativeMethodInfoPtr_CreateFromName_Internal_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0000D8E6 File Offset: 0x0000BAE6
		public CryptoConfigForwarder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Internal_Static_Object_String_0;
	}
}
