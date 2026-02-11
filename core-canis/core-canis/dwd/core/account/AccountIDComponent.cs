using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account
{
	// Token: 0x0200021D RID: 541
	public class AccountIDComponent : VersionedDataComponent
	{
		// Token: 0x06001D9B RID: 7579 RVA: 0x00088DFC File Offset: 0x00086FFC
		// Note: this type is marked as 'beforefieldinit'.
		static AccountIDComponent()
		{
			Il2CppClassPointerStore<AccountIDComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account", "AccountIDComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountIDComponent>.NativeClassPtr);
			AccountIDComponent.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDComponent>.NativeClassPtr, "AccountID");
			AccountIDComponent.NativeMethodInfoPtr__ctor_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDComponent>.NativeClassPtr, 100668064);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00088E54 File Offset: 0x00087054
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountIDComponent(AccountID accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountIDComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountIDComponent.NativeMethodInfoPtr__ctor_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0000C990 File Offset: 0x0000AB90
		public AccountIDComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x00088EA0 File Offset: 0x000870A0
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0000C999 File Offset: 0x0000AB99
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDComponent.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDComponent.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_0;
	}
}
