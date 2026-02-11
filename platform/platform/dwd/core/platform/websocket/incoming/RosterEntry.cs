using System;
using dwd.core.platform.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x02000041 RID: 65
	public class RosterEntry : TypedMessage
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000C270 File Offset: 0x0000A470
		// Note: this type is marked as 'beforefieldinit'.
		static RosterEntry()
		{
			Il2CppClassPointerStore<RosterEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "RosterEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr);
			RosterEntry.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "AccountID");
			RosterEntry.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "Username");
			RosterEntry.NativeFieldInfoPtr_Created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "Created");
			RosterEntry.NativeFieldInfoPtr_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "Online");
			RosterEntry.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "Status");
			RosterEntry.NativeFieldInfoPtr_PlaysThisGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "PlaysThisGame");
			RosterEntry.NativeFieldInfoPtr_Xuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "Xuid");
			RosterEntry.NativeFieldInfoPtr_InGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "InGame");
			RosterEntry.NativeFieldInfoPtr_ObserversAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "ObserversAllowed");
			RosterEntry.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, "GameSession");
			RosterEntry.NativeMethodInfoPtr_get_ScreenName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663627);
			RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663628);
			RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663629);
			RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663630);
			RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663631);
			RosterEntry.NativeMethodInfoPtr_get_ScreenNameInternal_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663632);
			RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663633);
			RosterEntry.NativeMethodInfoPtr_Update_Public_Void_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663634);
			RosterEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663635);
			RosterEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663636);
			RosterEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr, 100663637);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000C444 File Offset: 0x0000A644
		public unsafe string ScreenName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1167935, RefRangeEnd = 1167941, XrefRangeStart = 1167935, XrefRangeEnd = 1167941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_get_ScreenName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000C47C File Offset: 0x0000A67C
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.AccountID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.Username
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.ScreenName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1167935, RefRangeEnd = 1167941, XrefRangeStart = 1167935, XrefRangeEnd = 1167941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000C524 File Offset: 0x0000A724
		public unsafe virtual string dwd.core.platform.providers.IUserEntry.ScreenNameID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000C55C File Offset: 0x0000A75C
		public unsafe string ScreenNameInternal
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1167935, RefRangeEnd = 1167941, XrefRangeStart = 1167935, XrefRangeEnd = 1167941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_get_ScreenNameInternal_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000C594 File Offset: 0x0000A794
		public unsafe virtual bool dwd.core.platform.providers.IUserEntry.Online
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167950, XrefRangeEnd = 1167954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(RosterEntry other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_Update_Public_Void_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000C614 File Offset: 0x0000A814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167954, XrefRangeEnd = 1167955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(RosterEntry other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000C664 File Offset: 0x0000A864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167955, XrefRangeEnd = 1167980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RosterEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RosterEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RosterEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RosterEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003201 File Offset: 0x00001401
		public RosterEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000320A File Offset: 0x0000140A
		public unsafe string AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_AccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_AccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000C70C File Offset: 0x0000A90C
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003229 File Offset: 0x00001429
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000C734 File Offset: 0x0000A934
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003248 File Offset: 0x00001448
		public unsafe long Created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Created);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Created)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000C75C File Offset: 0x0000A95C
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00003263 File Offset: 0x00001463
		public unsafe bool Online
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Online);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Online)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000C784 File Offset: 0x0000A984
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000327E File Offset: 0x0000147E
		public unsafe Il2CppReferenceArray<UserStatus> Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UserStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000C7B4 File Offset: 0x0000A9B4
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000329D File Offset: 0x0000149D
		public unsafe bool PlaysThisGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_PlaysThisGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_PlaysThisGame)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000032B8 File Offset: 0x000014B8
		public unsafe string Xuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Xuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_Xuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000C804 File Offset: 0x0000AA04
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000032D7 File Offset: 0x000014D7
		public unsafe bool InGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_InGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_InGame)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C82C File Offset: 0x0000AA2C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000032F2 File Offset: 0x000014F2
		public unsafe bool ObserversAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_ObserversAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_ObserversAllowed)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000C854 File Offset: 0x0000AA54
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000330D File Offset: 0x0000150D
		public unsafe ObserverGameSession GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObserverGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RosterEntry.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_Created;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_Online;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_PlaysThisGame;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_Xuid;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_InGame;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_ObserversAllowed;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenName_Public_get_String_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_AccountID_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Username_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_ScreenNameID_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenNameInternal_Private_get_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_platform_providers_IUserEntry_get_Online_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_RosterEntry_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RosterEntry_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
