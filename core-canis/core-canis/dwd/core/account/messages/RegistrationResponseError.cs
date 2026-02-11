using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.account.messages
{
	// Token: 0x02000225 RID: 549
	public class RegistrationResponseError : Object
	{
		// Token: 0x06001DEB RID: 7659 RVA: 0x00089CDC File Offset: 0x00087EDC
		// Note: this type is marked as 'beforefieldinit'.
		static RegistrationResponseError()
		{
			Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.messages", "RegistrationResponseError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr);
			RegistrationResponseError.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr, "Code");
			RegistrationResponseError.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr, "Text");
			RegistrationResponseError.NativeFieldInfoPtr_LocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr, "LocKey");
			RegistrationResponseError.NativeFieldInfoPtr_InfoUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr, "InfoUrl");
			RegistrationResponseError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr, 100668096);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00089D70 File Offset: 0x00087F70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistrationResponseError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistrationResponseError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistrationResponseError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0000CC87 File Offset: 0x0000AE87
		public RegistrationResponseError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00089DAC File Offset: 0x00087FAC
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000CC90 File Offset: 0x0000AE90
		public unsafe int Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_Code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_Code)) = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00089DD4 File Offset: 0x00087FD4
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000CCAB File Offset: 0x0000AEAB
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00089DFC File Offset: 0x00087FFC
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000CCCA File Offset: 0x0000AECA
		public unsafe string LocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_LocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_LocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00089E24 File Offset: 0x00088024
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x0000CCE9 File Offset: 0x0000AEE9
		public unsafe string InfoUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_InfoUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationResponseError.NativeFieldInfoPtr_InfoUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeFieldInfoPtr_Code;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeFieldInfoPtr_LocKey;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeFieldInfoPtr_InfoUrl;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
