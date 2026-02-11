using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Analytics
{
	// Token: 0x02000007 RID: 7
	public static class AnalyticsSessionInfo : Object
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000039F4 File Offset: 0x00001BF4
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsSessionInfo()
		{
			Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "AnalyticsSessionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr);
			AnalyticsSessionInfo.NativeFieldInfoPtr_sessionStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "sessionStateChanged");
			AnalyticsSessionInfo.NativeFieldInfoPtr_identityTokenChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "identityTokenChanged");
			AnalyticsSessionInfo.NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, 100663303);
			AnalyticsSessionInfo.NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, 100663304);
			AnalyticsSessionInfo.get_sessionStateDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionStateDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionState");
			AnalyticsSessionInfo.get_sessionIdDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionIdDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionId");
			AnalyticsSessionInfo.get_sessionCountDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionCountDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionCount");
			AnalyticsSessionInfo.get_sessionElapsedTimeDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionElapsedTimeDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionElapsedTime");
			AnalyticsSessionInfo.get_sessionFirstRunDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_sessionFirstRunDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionFirstRun");
			AnalyticsSessionInfo.get_userIdDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_userIdDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_userId");
			AnalyticsSessionInfo.get_identityTokenInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_identityTokenInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_identityTokenInternal");
			AnalyticsSessionInfo.get_customUserIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_customUserIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_customUserIdInternal");
			AnalyticsSessionInfo.set_customUserIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.set_customUserIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::set_customUserIdInternal");
			AnalyticsSessionInfo.get_customDeviceIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.get_customDeviceIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_customDeviceIdInternal");
			AnalyticsSessionInfo.set_customDeviceIdInternalDelegateField = IL2CPP.ResolveICall<AnalyticsSessionInfo.set_customDeviceIdInternalDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::set_customDeviceIdInternal");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003B1C File Offset: 0x00001D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272274, XrefRangeEnd = 1272276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sessionState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionElapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003B78 File Offset: 0x00001D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272276, XrefRangeEnd = 1272278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallIdentityTokenChanged(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000024DD File Offset: 0x000006DD
		public AnalyticsSessionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003BB0 File Offset: 0x00001DB0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000024E6 File Offset: 0x000006E6
		public unsafe static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnalyticsSessionInfo.NativeFieldInfoPtr_sessionStateChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsSessionInfo.SessionStateChanged>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnalyticsSessionInfo.NativeFieldInfoPtr_sessionStateChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003BD8 File Offset: 0x00001DD8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000024F8 File Offset: 0x000006F8
		public unsafe static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnalyticsSessionInfo.NativeFieldInfoPtr_identityTokenChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsSessionInfo.IdentityTokenChanged>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnalyticsSessionInfo.NativeFieldInfoPtr_identityTokenChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000250A File Offset: 0x0000070A
		public static void add_sessionStateChanged(AnalyticsSessionInfo.SessionStateChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002517 File Offset: 0x00000717
		public static void remove_sessionStateChanged(AnalyticsSessionInfo.SessionStateChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002524 File Offset: 0x00000724
		public static AnalyticsSessionState sessionState
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionStateDelegateField();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002530 File Offset: 0x00000730
		public static long sessionId
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionIdDelegateField();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000253C File Offset: 0x0000073C
		public static long sessionCount
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionCountDelegateField();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002548 File Offset: 0x00000748
		public static long sessionElapsedTime
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionElapsedTimeDelegateField();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002554 File Offset: 0x00000754
		public static bool sessionFirstRun
		{
			get
			{
				return AnalyticsSessionInfo.get_sessionFirstRunDelegateField();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003C00 File Offset: 0x00001E00
		public static string userId
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_userIdDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003C20 File Offset: 0x00001E20
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003C48 File Offset: 0x00001E48
		public static string customUserId
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = null;
				}
				else
				{
					text = AnalyticsSessionInfo.customUserIdInternal;
				}
				return text;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					AnalyticsSessionInfo.customUserIdInternal = value;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00003C68 File Offset: 0x00001E68
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00003C90 File Offset: 0x00001E90
		public static string customDeviceId
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = null;
				}
				else
				{
					text = AnalyticsSessionInfo.customDeviceIdInternal;
				}
				return text;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					AnalyticsSessionInfo.customDeviceIdInternal = value;
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002560 File Offset: 0x00000760
		public static void add_identityTokenChanged(AnalyticsSessionInfo.IdentityTokenChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000256D File Offset: 0x0000076D
		public static void remove_identityTokenChanged(AnalyticsSessionInfo.IdentityTokenChanged value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public static string identityToken
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = null;
				}
				else
				{
					text = AnalyticsSessionInfo.identityTokenInternal;
				}
				return text;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public static string identityTokenInternal
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_identityTokenInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003CF8 File Offset: 0x00001EF8
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000257A File Offset: 0x0000077A
		public static string customUserIdInternal
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_customUserIdInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnalyticsSessionInfo.set_customUserIdInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003D18 File Offset: 0x00001F18
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000258C File Offset: 0x0000078C
		public static string customDeviceIdInternal
		{
			get
			{
				IntPtr intPtr = AnalyticsSessionInfo.get_customDeviceIdInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				AnalyticsSessionInfo.set_customDeviceIdInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_sessionStateChanged;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_identityTokenChanged;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly AnalyticsSessionInfo.get_sessionStateDelegate get_sessionStateDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly AnalyticsSessionInfo.get_sessionIdDelegate get_sessionIdDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly AnalyticsSessionInfo.get_sessionCountDelegate get_sessionCountDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly AnalyticsSessionInfo.get_sessionElapsedTimeDelegate get_sessionElapsedTimeDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly AnalyticsSessionInfo.get_sessionFirstRunDelegate get_sessionFirstRunDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly AnalyticsSessionInfo.get_userIdDelegate get_userIdDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly AnalyticsSessionInfo.get_identityTokenInternalDelegate get_identityTokenInternalDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly AnalyticsSessionInfo.get_customUserIdInternalDelegate get_customUserIdInternalDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly AnalyticsSessionInfo.set_customUserIdInternalDelegate set_customUserIdInternalDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly AnalyticsSessionInfo.get_customDeviceIdInternalDelegate get_customDeviceIdInternalDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly AnalyticsSessionInfo.set_customDeviceIdInternalDelegate set_customDeviceIdInternalDelegateField;

		// Token: 0x02000045 RID: 69
		public sealed class SessionStateChanged : MulticastDelegate
		{
			// Token: 0x06000155 RID: 341 RVA: 0x000028B2 File Offset: 0x00000AB2
			// Note: this type is marked as 'beforefieldinit'.
			static SessionStateChanged()
			{
				Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "SessionStateChanged");
				AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr, 100663305);
				AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr, 100663306);
			}

			// Token: 0x06000156 RID: 342 RVA: 0x00004B8C File Offset: 0x00002D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272271, XrefRangeEnd = 1272274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SessionStateChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSessionInfo.SessionStateChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00004BE8 File Offset: 0x00002DE8
			[CallerCount(0)]
			public unsafe void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sessionState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionElapsedTime;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.SessionStateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000158 RID: 344 RVA: 0x000028F0 File Offset: 0x00000AF0
			public SessionStateChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000159 RID: 345 RVA: 0x000028F9 File Offset: 0x00000AF9
			public static implicit operator AnalyticsSessionInfo.SessionStateChanged(Action<AnalyticsSessionState, long, long, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<AnalyticsSessionInfo.SessionStateChanged>(A_0);
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00002901 File Offset: 0x00000B01
			public static AnalyticsSessionInfo.SessionStateChanged operator +(AnalyticsSessionInfo.SessionStateChanged A_0, AnalyticsSessionInfo.SessionStateChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnalyticsSessionInfo.SessionStateChanged>();
			}

			// Token: 0x0600015B RID: 347 RVA: 0x0000290F File Offset: 0x00000B0F
			public static AnalyticsSessionInfo.SessionStateChanged operator -(AnalyticsSessionInfo.SessionStateChanged A_0, AnalyticsSessionInfo.SessionStateChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnalyticsSessionInfo.SessionStateChanged>();
				}
				return delegate2;
			}

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0;
		}

		// Token: 0x02000046 RID: 70
		public sealed class IdentityTokenChanged : MulticastDelegate
		{
			// Token: 0x0600015C RID: 348 RVA: 0x00002920 File Offset: 0x00000B20
			// Note: this type is marked as 'beforefieldinit'.
			static IdentityTokenChanged()
			{
				Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "IdentityTokenChanged");
				AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr, 100663307);
				AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr, 100663308);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00004C50 File Offset: 0x00002E50
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IdentityTokenChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSessionInfo.IdentityTokenChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00004CAC File Offset: 0x00002EAC
			[CallerCount(0)]
			public unsafe void Invoke(string token)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSessionInfo.IdentityTokenChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600015F RID: 351 RVA: 0x0000295E File Offset: 0x00000B5E
			public IdentityTokenChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00002967 File Offset: 0x00000B67
			public static implicit operator AnalyticsSessionInfo.IdentityTokenChanged(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<AnalyticsSessionInfo.IdentityTokenChanged>(A_0);
			}

			// Token: 0x06000161 RID: 353 RVA: 0x0000296F File Offset: 0x00000B6F
			public static AnalyticsSessionInfo.IdentityTokenChanged operator +(AnalyticsSessionInfo.IdentityTokenChanged A_0, AnalyticsSessionInfo.IdentityTokenChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnalyticsSessionInfo.IdentityTokenChanged>();
			}

			// Token: 0x06000162 RID: 354 RVA: 0x0000297D File Offset: 0x00000B7D
			public static AnalyticsSessionInfo.IdentityTokenChanged operator -(AnalyticsSessionInfo.IdentityTokenChanged A_0, AnalyticsSessionInfo.IdentityTokenChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnalyticsSessionInfo.IdentityTokenChanged>();
				}
				return delegate2;
			}

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;
		}

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate AnalyticsSessionState get_sessionStateDelegate();

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate long get_sessionIdDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate long get_sessionCountDelegate();

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate long get_sessionElapsedTimeDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate bool get_sessionFirstRunDelegate();

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate IntPtr get_userIdDelegate();

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate IntPtr get_identityTokenInternalDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate IntPtr get_customUserIdInternalDelegate();

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate void set_customUserIdInternalDelegate(IntPtr value);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate IntPtr get_customDeviceIdInternalDelegate();

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void set_customDeviceIdInternalDelegate(IntPtr value);
	}
}
