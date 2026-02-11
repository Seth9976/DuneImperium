using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000261 RID: 609
	public class SHA384 : HashAlgorithm
	{
		// Token: 0x06002777 RID: 10103 RVA: 0x000D6720 File Offset: 0x000D4920
		// Note: this type is marked as 'beforefieldinit'.
		static SHA384()
		{
			Il2CppClassPointerStore<SHA384>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA384");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA384>.NativeClassPtr);
			SHA384.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384>.NativeClassPtr, 100669812);
			SHA384.NativeMethodInfoPtr_Create_Public_Static_SHA384_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA384>.NativeClassPtr, 100669813);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000D6778 File Offset: 0x000D4978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373481, XrefRangeEnd = 1373482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA384()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA384>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x000D67B4 File Offset: 0x000D49B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1373486, RefRangeEnd = 1373488, XrefRangeStart = 1373482, XrefRangeEnd = 1373486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA384 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA384.NativeMethodInfoPtr_Create_Public_Static_SHA384_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA384>(intPtr3) : null;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0000CE66 File Offset: 0x0000B066
		public SHA384(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA384_0;
	}
}
