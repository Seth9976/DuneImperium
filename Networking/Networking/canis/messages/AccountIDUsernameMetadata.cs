using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x0200002B RID: 43
	public class AccountIDUsernameMetadata : Object
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00009944 File Offset: 0x00007B44
		// Note: this type is marked as 'beforefieldinit'.
		static AccountIDUsernameMetadata()
		{
			Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "AccountIDUsernameMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr);
			AccountIDUsernameMetadata.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr, "accountID");
			AccountIDUsernameMetadata.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr, "username");
			AccountIDUsernameMetadata.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr, "metadata");
			AccountIDUsernameMetadata.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr, 100663368);
			AccountIDUsernameMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr, 100663369);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000099D8 File Offset: 0x00007BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193625, XrefRangeEnd = 1193653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccountIDUsernameMetadata.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009A1C File Offset: 0x00007C1C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountIDUsernameMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountIDUsernameMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002F27 File Offset: 0x00001127
		public AccountIDUsernameMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00009A58 File Offset: 0x00007C58
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002F30 File Offset: 0x00001130
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsernameMetadata.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsernameMetadata.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009A88 File Offset: 0x00007C88
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002F4F File Offset: 0x0000114F
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsernameMetadata.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsernameMetadata.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00009AB0 File Offset: 0x00007CB0
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002F6E File Offset: 0x0000116E
		public unsafe Dictionary<string, string> metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsernameMetadata.NativeFieldInfoPtr_metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountIDUsernameMetadata.NativeFieldInfoPtr_metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C2 RID: 194
		[ObfuscatedName("Canis.messages.AccountIDUsernameMetadata+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600064F RID: 1615 RVA: 0x00016784 File Offset: 0x00014984
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AccountIDUsernameMetadata>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr);
				AccountIDUsernameMetadata.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr, "<>9");
				AccountIDUsernameMetadata.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr, "<>9__3_0");
				AccountIDUsernameMetadata.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr, 100663371);
				AccountIDUsernameMetadata.__c.NativeMethodInfoPtr__ToString_b__3_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr, 100663372);
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x00016800 File Offset: 0x00014A00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountIDUsernameMetadata.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountIDUsernameMetadata.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x0001683C File Offset: 0x00014A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193606, XrefRangeEnd = 1193625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__3_0(KeyValuePair<string, string> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountIDUsernameMetadata.__c.NativeMethodInfoPtr__ToString_b__3_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00005F3D File Offset: 0x0000413D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001688C File Offset: 0x00014A8C
			// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005F46 File Offset: 0x00004146
			public unsafe static AccountIDUsernameMetadata.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AccountIDUsernameMetadata.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AccountIDUsernameMetadata.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000655 RID: 1621 RVA: 0x000168B4 File Offset: 0x00014AB4
			// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005F58 File Offset: 0x00004158
			public unsafe static Func<KeyValuePair<string, string>, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AccountIDUsernameMetadata.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AccountIDUsernameMetadata.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__3_0_Internal_String_KeyValuePair_2_String_String_0;
		}
	}
}
