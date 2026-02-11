using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Mime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x02000251 RID: 593
	public class MailAddress : Object
	{
		// Token: 0x06002773 RID: 10099 RVA: 0x000B4398 File Offset: 0x000B2598
		// Note: this type is marked as 'beforefieldinit'.
		static MailAddress()
		{
			Il2CppClassPointerStore<MailAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "MailAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MailAddress>.NativeClassPtr);
			MailAddress.NativeFieldInfoPtr__displayNameEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, "_displayNameEncoding");
			MailAddress.NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, "_displayName");
			MailAddress.NativeFieldInfoPtr__userName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, "_userName");
			MailAddress.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, "_host");
			MailAddress.NativeFieldInfoPtr_s_encoderFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, "s_encoderFactory");
			MailAddress.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669162);
			MailAddress.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669163);
			MailAddress.NativeMethodInfoPtr__ctor_Public_Void_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669164);
			MailAddress.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669165);
			MailAddress.NativeMethodInfoPtr_get_Address_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669166);
			MailAddress.NativeMethodInfoPtr_get_SmtpAddress_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669167);
			MailAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669168);
			MailAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669169);
			MailAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MailAddress>.NativeClassPtr, 100669170);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000B44E0 File Offset: 0x000B26E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491121, XrefRangeEnd = 491129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MailAddress(string displayName, string userName, string domain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MailAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddress.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000B4550 File Offset: 0x000B2750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 491130, RefRangeEnd = 491131, XrefRangeStart = 491129, XrefRangeEnd = 491130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MailAddress(string address)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MailAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddress.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000B459C File Offset: 0x000B279C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 491153, RefRangeEnd = 491154, XrefRangeStart = 491131, XrefRangeEnd = 491153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MailAddress(string address, string displayName, Encoding displayNameEncoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MailAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayNameEncoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddress.NativeMethodInfoPtr__ctor_Public_Void_String_String_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000B460C File Offset: 0x000B280C
		public unsafe string DisplayName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddress.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000B4644 File Offset: 0x000B2844
		public unsafe string Address
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491154, XrefRangeEnd = 491157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddress.NativeMethodInfoPtr_get_Address_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000B467C File Offset: 0x000B287C
		public unsafe string SmtpAddress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491157, XrefRangeEnd = 491165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MailAddress.NativeMethodInfoPtr_get_SmtpAddress_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000B46B4 File Offset: 0x000B28B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491165, XrefRangeEnd = 491179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MailAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000B46F8 File Offset: 0x000B28F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491179, XrefRangeEnd = 491180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MailAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000B4750 File Offset: 0x000B2950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491180, XrefRangeEnd = 491181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MailAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00011033 File Offset: 0x0000F233
		public MailAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000B4798 File Offset: 0x000B2998
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x0001103C File Offset: 0x0000F23C
		public unsafe Encoding _displayNameEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__displayNameEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__displayNameEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000B47C8 File Offset: 0x000B29C8
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x0001105B File Offset: 0x0000F25B
		public unsafe string _displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x000B47F0 File Offset: 0x000B29F0
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x0001107A File Offset: 0x0000F27A
		public unsafe string _userName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__userName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__userName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000B4818 File Offset: 0x000B2A18
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x00011099 File Offset: 0x0000F299
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MailAddress.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000B4840 File Offset: 0x000B2A40
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public unsafe static EncodedStreamFactory s_encoderFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MailAddress.NativeFieldInfoPtr_s_encoderFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncodedStreamFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MailAddress.NativeFieldInfoPtr_s_encoderFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr__displayNameEncoding;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeFieldInfoPtr__displayName;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr__userName;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeFieldInfoPtr_s_encoderFactory;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Encoding_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_String_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_get_SmtpAddress_Private_get_String_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
