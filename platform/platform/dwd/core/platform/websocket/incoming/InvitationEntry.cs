using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000039 RID: 57
	public class InvitationEntry : TypedMessage
	{
		// Token: 0x060001DF RID: 479 RVA: 0x0000B5DC File Offset: 0x000097DC
		// Note: this type is marked as 'beforefieldinit'.
		static InvitationEntry()
		{
			Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "InvitationEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr);
			InvitationEntry.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "From");
			InvitationEntry.NativeFieldInfoPtr_FromUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "FromUsername");
			InvitationEntry.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "To");
			InvitationEntry.NativeFieldInfoPtr_ToUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "ToUsername");
			InvitationEntry.NativeFieldInfoPtr_Created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "Created");
			InvitationEntry.NativeFieldInfoPtr_toGamerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "toGamerTag");
			InvitationEntry.NativeFieldInfoPtr_fromGamerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "fromGamerTag");
			InvitationEntry.NativeFieldInfoPtr_toXuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "toXuid");
			InvitationEntry.NativeFieldInfoPtr_fromXuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, "fromXuid");
			InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663612);
			InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663613);
			InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663614);
			InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663615);
			InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663616);
			InvitationEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663617);
			InvitationEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr, 100663618);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000B74C File Offset: 0x0000994C
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.AccountID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000B784 File Offset: 0x00009984
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.Username
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000B7BC File Offset: 0x000099BC
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.ScreenName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1167935, RefRangeEnd = 1167941, XrefRangeStart = 1167933, XrefRangeEnd = 1167935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000B7F4 File Offset: 0x000099F4
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.ScreenNameID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167941, XrefRangeEnd = 1167943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000B82C File Offset: 0x00009A2C
		public unsafe virtual bool dwd.core.platform.providers.IUserEntry.Online
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000B868 File Offset: 0x00009A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167943, XrefRangeEnd = 1167944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(InvitationEntry other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvitationEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvitationEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvitationEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002EB4 File Offset: 0x000010B4
		public InvitationEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002EBD File Offset: 0x000010BD
		public unsafe string From
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_From);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_From), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000B91C File Offset: 0x00009B1C
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002EDC File Offset: 0x000010DC
		public unsafe string FromUsername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_FromUsername);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_FromUsername), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000B944 File Offset: 0x00009B44
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002EFB File Offset: 0x000010FB
		public unsafe string To
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_To);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_To), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000B96C File Offset: 0x00009B6C
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002F1A File Offset: 0x0000111A
		public unsafe string ToUsername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_ToUsername);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_ToUsername), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000B994 File Offset: 0x00009B94
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002F39 File Offset: 0x00001139
		public unsafe long Created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_Created);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_Created)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000B9BC File Offset: 0x00009BBC
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002F54 File Offset: 0x00001154
		public unsafe string toGamerTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_toGamerTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_toGamerTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002F73 File Offset: 0x00001173
		public unsafe string fromGamerTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_fromGamerTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_fromGamerTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000BA0C File Offset: 0x00009C0C
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002F92 File Offset: 0x00001192
		public unsafe string toXuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_toXuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_toXuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000BA34 File Offset: 0x00009C34
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002FB1 File Offset: 0x000011B1
		public unsafe string fromXuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_fromXuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvitationEntry.NativeFieldInfoPtr_fromXuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_From;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_FromUsername;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_To;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_ToUsername;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_Created;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_toGamerTag;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_fromGamerTag;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_toXuid;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_fromXuid;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InvitationEntry_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
