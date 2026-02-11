using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppSystem.Net
{
	// Token: 0x020001F3 RID: 499
	public class DigestSession : Object
	{
		// Token: 0x06001ED8 RID: 7896 RVA: 0x00093E14 File Offset: 0x00092014
		// Note: this type is marked as 'beforefieldinit'.
		static DigestSession()
		{
			Il2CppClassPointerStore<DigestSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "DigestSession");
			DigestSession.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "rng");
			DigestSession.NativeFieldInfoPtr_lastUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "lastUse");
			DigestSession.NativeFieldInfoPtr__nc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "_nc");
			DigestSession.NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "hash");
			DigestSession.NativeFieldInfoPtr_parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "parser");
			DigestSession.NativeFieldInfoPtr__cnonce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, "_cnonce");
			DigestSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667987);
			DigestSession.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667988);
			DigestSession.NativeMethodInfoPtr_get_Realm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667989);
			DigestSession.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667990);
			DigestSession.NativeMethodInfoPtr_get_Opaque_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667991);
			DigestSession.NativeMethodInfoPtr_get_QOP_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667992);
			DigestSession.NativeMethodInfoPtr_get_CNonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667993);
			DigestSession.NativeMethodInfoPtr_Parse_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667994);
			DigestSession.NativeMethodInfoPtr_HashToHexString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667995);
			DigestSession.NativeMethodInfoPtr_HA1_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667996);
			DigestSession.NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667997);
			DigestSession.NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667998);
			DigestSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100667999);
			DigestSession.NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigestSession>.NativeClassPtr, 100668000);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00093FCC File Offset: 0x000921CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478979, XrefRangeEnd = 478984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigestSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigestSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00094008 File Offset: 0x00092208
		public unsafe string Algorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00094040 File Offset: 0x00092240
		public unsafe string Realm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Realm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00094078 File Offset: 0x00092278
		public unsafe string Nonce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x000940B0 File Offset: 0x000922B0
		public unsafe string Opaque
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_Opaque_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x000940E8 File Offset: 0x000922E8
		public unsafe string QOP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_QOP_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00094120 File Offset: 0x00092320
		public unsafe string CNonce
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 478997, RefRangeEnd = 479002, XrefRangeStart = 478984, XrefRangeEnd = 478997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_CNonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00094158 File Offset: 0x00092358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479024, RefRangeEnd = 479026, XrefRangeStart = 479002, XrefRangeEnd = 479024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Parse(string challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Parse_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000941A8 File Offset: 0x000923A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 479037, RefRangeEnd = 479044, XrefRangeStart = 479026, XrefRangeEnd = 479037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HashToHexString(string toBeHashed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toBeHashed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HashToHexString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000941F0 File Offset: 0x000923F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479044, XrefRangeEnd = 479058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HA1(string username, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HA1_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0009424C File Offset: 0x0009244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479058, XrefRangeEnd = 479068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string HA2(HttpWebRequest webRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00094294 File Offset: 0x00092494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479108, RefRangeEnd = 479109, XrefRangeStart = 479068, XrefRangeEnd = 479108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Response(string username, string password, HttpWebRequest webRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00094300 File Offset: 0x00092500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479177, RefRangeEnd = 479179, XrefRangeStart = 479109, XrefRangeEnd = 479177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x00094364 File Offset: 0x00092564
		public unsafe DateTime LastUse
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigestSession.NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0000D1DD File Offset: 0x0000B3DD
		public DigestSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x000943A0 File Offset: 0x000925A0
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x0000D1E6 File Offset: 0x0000B3E6
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DigestSession.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigestSession.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x000943C8 File Offset: 0x000925C8
		// (set) Token: 0x06001EEB RID: 7915 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
		public unsafe DateTime lastUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_lastUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_lastUse)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x000943F0 File Offset: 0x000925F0
		// (set) Token: 0x06001EED RID: 7917 RVA: 0x0000D213 File Offset: 0x0000B413
		public unsafe int _nc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__nc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__nc)) = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00094418 File Offset: 0x00092618
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x0000D22E File Offset: 0x0000B42E
		public unsafe HashAlgorithm hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_hash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_hash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00094448 File Offset: 0x00092648
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0000D24D File Offset: 0x0000B44D
		public unsafe DigestHeaderParser parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DigestHeaderParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr_parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00094478 File Offset: 0x00092678
		// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x0000D26C File Offset: 0x0000B46C
		public unsafe string _cnonce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__cnonce);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigestSession.NativeFieldInfoPtr__cnonce), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr_lastUse;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr__nc;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr_hash;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr_parser;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr__cnonce;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_get_Realm_Public_get_String_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_get_Opaque_Public_get_String_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_get_QOP_Public_get_String_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_get_CNonce_Public_get_String_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Boolean_String_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_HashToHexString_Private_String_String_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_HA1_Private_String_String_String_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_HA2_Private_String_HttpWebRequest_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_Response_Private_String_String_String_HttpWebRequest_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Authorization_WebRequest_ICredentials_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUse_Public_get_DateTime_0;
	}
}
