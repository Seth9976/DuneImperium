using System;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.account
{
	// Token: 0x02000221 RID: 545
	public static class AccountExtensions : Object
	{
		// Token: 0x06001DBF RID: 7615 RVA: 0x0000CABC File Offset: 0x0000ACBC
		// Note: this type is marked as 'beforefieldinit'.
		static AccountExtensions()
		{
			Il2CppClassPointerStore<AccountExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account", "AccountExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountExtensions>.NativeClassPtr);
			AccountExtensions.NativeMethodInfoPtr_ToSerializableAccount_Public_Static_SerializableAccount_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountExtensions>.NativeClassPtr, 100668078);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000894F4 File Offset: 0x000876F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 886678, RefRangeEnd = 886682, XrefRangeStart = 886627, XrefRangeEnd = 886678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0000CAF5 File Offset: 0x0000ACF5
		public AccountExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_ToSerializableAccount_Public_Static_SerializableAccount_PlatformToken_0;
	}
}
