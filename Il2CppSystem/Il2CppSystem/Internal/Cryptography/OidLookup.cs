using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Security.Cryptography;

namespace Internal.Cryptography
{
	// Token: 0x02000051 RID: 81
	public static class OidLookup : Object
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x0002E1EC File Offset: 0x0002C3EC
		// Note: this type is marked as 'beforefieldinit'.
		static OidLookup()
		{
			Il2CppClassPointerStore<OidLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Internal.Cryptography", "OidLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidLookup>.NativeClassPtr);
			OidLookup.NativeFieldInfoPtr_s_lateBoundOidToFriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_lateBoundOidToFriendlyName");
			OidLookup.NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_lateBoundFriendlyNameToOid");
			OidLookup.NativeFieldInfoPtr_s_friendlyNameToOid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_friendlyNameToOid");
			OidLookup.NativeFieldInfoPtr_s_oidToFriendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_oidToFriendlyName");
			OidLookup.NativeFieldInfoPtr_s_compatOids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "s_compatOids");
			OidLookup.NativeMethodInfoPtr_ToFriendlyName_Public_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664139);
			OidLookup.NativeMethodInfoPtr_ToOid_Public_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664140);
			OidLookup.NativeMethodInfoPtr_ShouldUseCache_Private_Static_Boolean_OidGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664141);
			OidLookup.NativeMethodInfoPtr_NativeOidToFriendlyName_Private_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664142);
			OidLookup.NativeMethodInfoPtr_NativeFriendlyNameToOid_Private_Static_String_String_OidGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, 100664143);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0002E2E4 File Offset: 0x0002C4E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 433072, RefRangeEnd = 433075, XrefRangeStart = 433043, XrefRangeEnd = 433072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallBackToAllGroups;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.NativeMethodInfoPtr_ToFriendlyName_Public_Static_String_String_OidGroup_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002E33C File Offset: 0x0002C53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433099, RefRangeEnd = 433100, XrefRangeStart = 433075, XrefRangeEnd = 433099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallBackToAllGroups;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.NativeMethodInfoPtr_ToOid_Public_Static_String_String_OidGroup_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002E394 File Offset: 0x0002C594
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldUseCache(OidGroup oidGroup)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oidGroup;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.NativeMethodInfoPtr_ShouldUseCache_Private_Static_Boolean_OidGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002E3D4 File Offset: 0x0002C5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433126, RefRangeEnd = 433127, XrefRangeStart = 433100, XrefRangeEnd = 433126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallBackToAllGroups;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.NativeMethodInfoPtr_NativeOidToFriendlyName_Private_Static_String_String_OidGroup_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0002E42C File Offset: 0x0002C62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433153, RefRangeEnd = 433154, XrefRangeStart = 433127, XrefRangeEnd = 433153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(friendlyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oidGroup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallBackToAllGroups;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.NativeMethodInfoPtr_NativeFriendlyNameToOid_Private_Static_String_String_OidGroup_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00003770 File Offset: 0x00001970
		public OidLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0002E484 File Offset: 0x0002C684
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00003779 File Offset: 0x00001979
		public unsafe static ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OidLookup.NativeFieldInfoPtr_s_lateBoundOidToFriendlyName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OidLookup.NativeFieldInfoPtr_s_lateBoundOidToFriendlyName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002E4AC File Offset: 0x0002C6AC
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0000378B File Offset: 0x0000198B
		public unsafe static ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OidLookup.NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OidLookup.NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x0000379D File Offset: 0x0000199D
		public unsafe static Dictionary<string, string> s_friendlyNameToOid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OidLookup.NativeFieldInfoPtr_s_friendlyNameToOid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OidLookup.NativeFieldInfoPtr_s_friendlyNameToOid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x000037AF File Offset: 0x000019AF
		public unsafe static Dictionary<string, string> s_oidToFriendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OidLookup.NativeFieldInfoPtr_s_oidToFriendlyName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OidLookup.NativeFieldInfoPtr_s_oidToFriendlyName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0002E524 File Offset: 0x0002C724
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x000037C1 File Offset: 0x000019C1
		public unsafe static Dictionary<string, string> s_compatOids
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OidLookup.NativeFieldInfoPtr_s_compatOids, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OidLookup.NativeFieldInfoPtr_s_compatOids, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_s_lateBoundOidToFriendlyName;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_s_lateBoundFriendlyNameToOid;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_s_friendlyNameToOid;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_s_oidToFriendlyName;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_s_compatOids;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_ToFriendlyName_Public_Static_String_String_OidGroup_Boolean_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_ToOid_Public_Static_String_String_OidGroup_Boolean_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUseCache_Private_Static_Boolean_OidGroup_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_NativeOidToFriendlyName_Private_Static_String_String_OidGroup_Boolean_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_NativeFriendlyNameToOid_Private_Static_String_String_OidGroup_Boolean_0;

		// Token: 0x020002BE RID: 702
		[ObfuscatedName("Internal.Cryptography.OidLookup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002B30 RID: 11056 RVA: 0x000BFDF4 File Offset: 0x000BDFF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OidLookup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr);
				OidLookup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr, "<>9");
				OidLookup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr, 100664146);
				OidLookup.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr, 100664147);
				OidLookup.__c.NativeMethodInfoPtr___cctor_b__10_1_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr, 100664148);
			}

			// Token: 0x06002B31 RID: 11057 RVA: 0x000BFE70 File Offset: 0x000BE070
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OidLookup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B32 RID: 11058 RVA: 0x000BFEAC File Offset: 0x000BE0AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433041, XrefRangeEnd = 433042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __cctor_b__10_0(KeyValuePair<string, string> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002B33 RID: 11059 RVA: 0x000BFEFC File Offset: 0x000BE0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433042, XrefRangeEnd = 433043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __cctor_b__10_1(KeyValuePair<string, string> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidLookup.__c.NativeMethodInfoPtr___cctor_b__10_1_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002B34 RID: 11060 RVA: 0x00013582 File Offset: 0x00011782
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000BFF4C File Offset: 0x000BE14C
			// (set) Token: 0x06002B36 RID: 11062 RVA: 0x0001358B File Offset: 0x0001178B
			public unsafe static OidLookup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OidLookup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidLookup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OidLookup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021E4 RID: 8676
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040021E5 RID: 8677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021E6 RID: 8678
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__10_0_Internal_String_KeyValuePair_2_String_String_0;

			// Token: 0x040021E7 RID: 8679
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__10_1_Internal_String_KeyValuePair_2_String_String_0;
		}
	}
}
