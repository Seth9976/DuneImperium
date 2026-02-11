using System;
using dwd.core.platform.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.authentication
{
	// Token: 0x0200002A RID: 42
	public class PlatformToken : Object
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformToken()
		{
			Il2CppClassPointerStore<PlatformToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.platform.authentication", "PlatformToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr);
			PlatformToken.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, "AccountID");
			PlatformToken.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, "Username");
			PlatformToken.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, "Timestamp");
			PlatformToken.NativeFieldInfoPtr_IPAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, "IPAddress");
			PlatformToken.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, "Attributes");
			PlatformToken.NativeFieldInfoPtr_Signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, "Signature");
			PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, 100663544);
			PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, 100663545);
			PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, 100663546);
			PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, 100663547);
			PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, 100663548);
			PlatformToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr, 100663549);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000ACD8 File Offset: 0x00008ED8
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.AccountID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000AD10 File Offset: 0x00008F10
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.Username
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181259, XrefRangeEnd = 1181272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000AD48 File Offset: 0x00008F48
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.ScreenName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181272, XrefRangeEnd = 1181278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000AD80 File Offset: 0x00008F80
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.ScreenNameID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181278, XrefRangeEnd = 1181284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		public unsafe virtual bool dwd.core.platform.providers.IUserEntry.Online
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformToken.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002789 File Offset: 0x00000989
		public PlatformToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000AE30 File Offset: 0x00009030
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002792 File Offset: 0x00000992
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000AE58 File Offset: 0x00009058
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000027B1 File Offset: 0x000009B1
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000AE80 File Offset: 0x00009080
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000027D0 File Offset: 0x000009D0
		public unsafe long Timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Timestamp)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000AEA8 File Offset: 0x000090A8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x000027EB File Offset: 0x000009EB
		public unsafe string IPAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_IPAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_IPAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000AED0 File Offset: 0x000090D0
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000280A File Offset: 0x00000A0A
		public unsafe PlatformAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000AF00 File Offset: 0x00009100
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002829 File Offset: 0x00000A29
		public unsafe string Signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformToken.NativeFieldInfoPtr_Signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_IPAddress;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_Signature;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
