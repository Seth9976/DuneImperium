using System;
using dwd.core.account;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.account
{
	// Token: 0x02000180 RID: 384
	public static class AccountExtensions : Object
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x0000AE30 File Offset: 0x00009030
		// Note: this type is marked as 'beforefieldinit'.
		static AccountExtensions()
		{
			Il2CppClassPointerStore<AccountExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.account", "AccountExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountExtensions>.NativeClassPtr);
			AccountExtensions.NativeMethodInfoPtr_ToSerializableAccount_Public_Static_SerializableAccount_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountExtensions>.NativeClassPtr, 100666091);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0004BD7C File Offset: 0x00049F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001678, RefRangeEnd = 1001679, XrefRangeStart = 1001627, XrefRangeEnd = 1001678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializableAccount ToSerializableAccount(this PlatformToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountExtensions.NativeMethodInfoPtr_ToSerializableAccount_Public_Static_SerializableAccount_PlatformToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAccount>(intPtr3) : null;
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0000AE69 File Offset: 0x00009069
		public AccountExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_ToSerializableAccount_Public_Static_SerializableAccount_PlatformToken_0;
	}
}
