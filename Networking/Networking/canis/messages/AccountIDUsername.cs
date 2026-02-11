using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.messages
{
	// Token: 0x02000029 RID: 41
	public class AccountIDUsername : Object
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00009664 File Offset: 0x00007864
		// Note: this type is marked as 'beforefieldinit'.
		static AccountIDUsername()
		{
			Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "AccountIDUsername");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr);
			AccountIDUsername.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr, "accountID");
			AccountIDUsername.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr, "username");
			AccountIDUsername.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr, 100663365);
			AccountIDUsername.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr, 100663366);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000096E4 File Offset: 0x000078E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193603, XrefRangeEnd = 1193606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccountIDUsername.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00009728 File Offset: 0x00007928
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountIDUsername()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountIDUsername>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountIDUsername.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002E5B File Offset: 0x0000105B
		public AccountIDUsername(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00009764 File Offset: 0x00007964
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002E64 File Offset: 0x00001064
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsername.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsername.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00009794 File Offset: 0x00007994
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002E83 File Offset: 0x00001083
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsername.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsername.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
