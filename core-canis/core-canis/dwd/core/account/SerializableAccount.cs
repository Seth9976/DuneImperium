using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.account
{
	// Token: 0x02000220 RID: 544
	public class SerializableAccount : Object
	{
		// Token: 0x06001DB6 RID: 7606 RVA: 0x000893B0 File Offset: 0x000875B0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableAccount()
		{
			Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account", "SerializableAccount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr);
			SerializableAccount.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr, "Username");
			SerializableAccount.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr, "AccountID");
			SerializableAccount.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr, "Attributes");
			SerializableAccount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr, 100668077);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00089430 File Offset: 0x00087630
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAccount()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAccount>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAccount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0000CA56 File Offset: 0x0000AC56
		public SerializableAccount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0008946C File Offset: 0x0008766C
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0000CA5F File Offset: 0x0000AC5F
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAccount.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAccount.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00089494 File Offset: 0x00087694
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0000CA7E File Offset: 0x0000AC7E
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAccount.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAccount.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000894C4 File Offset: 0x000876C4
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0000CA9D File Offset: 0x0000AC9D
		public unsafe SerializableAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAccount.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAccount.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
