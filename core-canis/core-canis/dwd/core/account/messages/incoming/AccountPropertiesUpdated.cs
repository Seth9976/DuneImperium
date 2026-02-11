using System;
using Canis.attributes;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account.messages.incoming
{
	// Token: 0x02000227 RID: 551
	public class AccountPropertiesUpdated : NetworkMessageEvent
	{
		// Token: 0x06001DFB RID: 7675 RVA: 0x00089F20 File Offset: 0x00088120
		// Note: this type is marked as 'beforefieldinit'.
		static AccountPropertiesUpdated()
		{
			Il2CppClassPointerStore<AccountPropertiesUpdated>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.messages.incoming", "AccountPropertiesUpdated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountPropertiesUpdated>.NativeClassPtr);
			AccountPropertiesUpdated.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPropertiesUpdated>.NativeClassPtr, "AccountID");
			AccountPropertiesUpdated.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountPropertiesUpdated>.NativeClassPtr, "Attributes");
			AccountPropertiesUpdated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountPropertiesUpdated>.NativeClassPtr, 100668098);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00089F8C File Offset: 0x0008818C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountPropertiesUpdated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountPropertiesUpdated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountPropertiesUpdated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0000CD30 File Offset: 0x0000AF30
		public AccountPropertiesUpdated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00089FC8 File Offset: 0x000881C8
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0000CD39 File Offset: 0x0000AF39
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertiesUpdated.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertiesUpdated.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00089FF8 File Offset: 0x000881F8
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0000CD58 File Offset: 0x0000AF58
		public unsafe SerializableAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertiesUpdated.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountPropertiesUpdated.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
