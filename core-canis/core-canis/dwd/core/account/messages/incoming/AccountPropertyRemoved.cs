using System;
using Canis.attributes;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account.messages.incoming
{
	// Token: 0x02000228 RID: 552
	public class AccountPropertyRemoved : NetworkMessageEvent
	{
		// Token: 0x06001E02 RID: 7682 RVA: 0x0008A028 File Offset: 0x00088228
		// Note: this type is marked as 'beforefieldinit'.
		static AccountPropertyRemoved()
		{
			Il2CppClassPointerStore<AccountPropertyRemoved>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.messages.incoming", "AccountPropertyRemoved");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountPropertyRemoved>.NativeClassPtr);
			AccountPropertyRemoved.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPropertyRemoved>.NativeClassPtr, "AccountID");
			AccountPropertyRemoved.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPropertyRemoved>.NativeClassPtr, "Attribute");
			AccountPropertyRemoved.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPropertyRemoved>.NativeClassPtr, 100668099);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0008A094 File Offset: 0x00088294
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountPropertyRemoved()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountPropertyRemoved>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPropertyRemoved.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0000CD77 File Offset: 0x0000AF77
		public AccountPropertyRemoved(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0008A0D0 File Offset: 0x000882D0
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0000CD80 File Offset: 0x0000AF80
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0008A100 File Offset: 0x00088300
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0000CD9F File Offset: 0x0000AF9F
		public unsafe IAttribute Attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved.NativeFieldInfoPtr_Attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertyRemoved.NativeFieldInfoPtr_Attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
