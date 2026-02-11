using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000A RID: 10
	public class UserProfile : Object
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00003538 File Offset: 0x00001738
		// Note: this type is marked as 'beforefieldinit'.
		static UserProfile()
		{
			Il2CppClassPointerStore<UserProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms.Impl", "UserProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserProfile>.NativeClassPtr);
			UserProfile.NativeFieldInfoPtr_m_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, "m_UserName");
			UserProfile.NativeFieldInfoPtr_m_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, "m_ID");
			UserProfile.NativeFieldInfoPtr_m_legacyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, "m_legacyID");
			UserProfile.NativeFieldInfoPtr_m_IsFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, "m_IsFriend");
			UserProfile.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, "m_State");
			UserProfile.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, "m_Image");
			UserProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, 100663315);
			UserProfile.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, 100663316);
			UserProfile.NativeMethodInfoPtr_get_userName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, 100663317);
			UserProfile.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, 100663318);
			UserProfile.NativeMethodInfoPtr_get_isFriend_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, 100663319);
			UserProfile.NativeMethodInfoPtr_get_state_Public_Virtual_Final_New_get_UserState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserProfile>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003658 File Offset: 0x00001858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270720, XrefRangeEnd = 1270737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003694 File Offset: 0x00001894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270737, XrefRangeEnd = 1270759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UserProfile.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000036D8 File Offset: 0x000018D8
		public unsafe virtual string userName
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserProfile.NativeMethodInfoPtr_get_userName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003710 File Offset: 0x00001910
		public unsafe virtual string id
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserProfile.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe virtual bool isFriend
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 317535, RefRangeEnd = 317537, XrefRangeStart = 317535, XrefRangeEnd = 317537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserProfile.NativeMethodInfoPtr_get_isFriend_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003784 File Offset: 0x00001984
		public unsafe virtual UserState state
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserProfile.NativeMethodInfoPtr_get_state_Public_Virtual_Final_New_get_UserState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000231B File Offset: 0x0000051B
		public UserProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000037C0 File Offset: 0x000019C0
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002324 File Offset: 0x00000524
		public unsafe string m_UserName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_UserName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_UserName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000037E8 File Offset: 0x000019E8
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002343 File Offset: 0x00000543
		public unsafe string m_ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003810 File Offset: 0x00001A10
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002362 File Offset: 0x00000562
		public unsafe string m_legacyID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_legacyID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_legacyID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00003838 File Offset: 0x00001A38
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002381 File Offset: 0x00000581
		public unsafe bool m_IsFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_IsFriend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_IsFriend)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003860 File Offset: 0x00001A60
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000239C File Offset: 0x0000059C
		public unsafe UserState m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_State)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe Texture2D m_Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserProfile.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000023D6 File Offset: 0x000005D6
		public void SetUserName(string name)
		{
			this.m_UserName = name;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000023E0 File Offset: 0x000005E0
		public void SetUserID(string id)
		{
			this.m_ID = id;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023EA File Offset: 0x000005EA
		public void SetLegacyUserID(string id)
		{
			this.m_legacyID = id;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023F4 File Offset: 0x000005F4
		public void SetUserGameID(string id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002401 File Offset: 0x00000601
		public void SetImage(Texture2D image)
		{
			this.m_Image = image;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000240B File Offset: 0x0000060B
		public void SetIsFriend(bool value)
		{
			this.m_IsFriend = value;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002415 File Offset: 0x00000615
		public void SetState(UserState state)
		{
			this.m_State = state;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000241F File Offset: 0x0000061F
		public string legacyId
		{
			get
			{
				throw new NotSupportedException("legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000242C File Offset: 0x0000062C
		public string gameId
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000038B8 File Offset: 0x00001AB8
		public Texture2D image
		{
			get
			{
				return this.m_Image;
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_m_UserName;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_m_ID;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_m_legacyID;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_IsFriend;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_Image;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_userName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_isFriend_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_Virtual_Final_New_get_UserState_0;

		// Token: 0x0400002F RID: 47
		public const string legacyIdObsoleteMessage = "legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead";
	}
}
