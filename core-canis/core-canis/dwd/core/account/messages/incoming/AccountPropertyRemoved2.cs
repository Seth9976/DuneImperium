using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account.messages.incoming
{
	// Token: 0x02000229 RID: 553
	public class AccountPropertyRemoved2 : NetworkMessageEvent
	{
		// Token: 0x06001E09 RID: 7689 RVA: 0x0008A130 File Offset: 0x00088330
		// Note: this type is marked as 'beforefieldinit'.
		static AccountPropertyRemoved2()
		{
			Il2CppClassPointerStore<AccountPropertyRemoved2>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.messages.incoming", "AccountPropertyRemoved2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountPropertyRemoved2>.NativeClassPtr);
			AccountPropertyRemoved2.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPropertyRemoved2>.NativeClassPtr, "AccountID");
			AccountPropertyRemoved2.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPropertyRemoved2>.NativeClassPtr, "Attribute");
			AccountPropertyRemoved2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPropertyRemoved2>.NativeClassPtr, 100668100);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0008A19C File Offset: 0x0008839C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountPropertyRemoved2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountPropertyRemoved2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPropertyRemoved2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0000CDBE File Offset: 0x0000AFBE
		public AccountPropertyRemoved2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0008A1D8 File Offset: 0x000883D8
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x0000CDC7 File Offset: 0x0000AFC7
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved2.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved2.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0008A208 File Offset: 0x00088408
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0000CDE6 File Offset: 0x0000AFE6
		public unsafe int Attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved2.NativeFieldInfoPtr_Attribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved2.NativeFieldInfoPtr_Attribute)) = value;
			}
		}

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
