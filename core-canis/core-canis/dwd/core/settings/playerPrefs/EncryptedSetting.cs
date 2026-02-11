using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000CA RID: 202
	public class EncryptedSetting : PrefSetting<string>
	{
		// Token: 0x06000C8E RID: 3214 RVA: 0x00043AB4 File Offset: 0x00041CB4
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptedSetting()
		{
			Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "EncryptedSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr);
			EncryptedSetting.NativeFieldInfoPtr_KEYSIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, "KEYSIZE");
			EncryptedSetting.NativeFieldInfoPtr_BLOCKSIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, "BLOCKSIZE");
			EncryptedSetting.NativeFieldInfoPtr_rijndael = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, "rijndael");
			EncryptedSetting.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStructArray_1_Byte_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, 100665061);
			EncryptedSetting.NativeMethodInfoPtr_set_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, 100665062);
			EncryptedSetting.NativeMethodInfoPtr_Get_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, 100665063);
			EncryptedSetting.NativeMethodInfoPtr_modValue_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, 100665064);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00043B70 File Offset: 0x00041D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864621, RefRangeEnd = 864622, XrefRangeStart = 864568, XrefRangeEnd = 864621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncryptedSetting(string key, string defaultValue, Il2CppStructArray<byte> salt, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedSetting.NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStructArray_1_Byte_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00043BF4 File Offset: 0x00041DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864622, XrefRangeEnd = 864632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void set(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncryptedSetting.NativeMethodInfoPtr_set_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00043C44 File Offset: 0x00041E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864632, XrefRangeEnd = 864652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncryptedSetting.NativeMethodInfoPtr_Get_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00043C88 File Offset: 0x00041E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 864677, RefRangeEnd = 864679, XrefRangeStart = 864652, XrefRangeEnd = 864677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> modValue(Il2CppStructArray<byte> buffer, bool encrypt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encrypt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedSetting.NativeMethodInfoPtr_modValue_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0000671B File Offset: 0x0000491B
		public EncryptedSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00043CE8 File Offset: 0x00041EE8
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00006724 File Offset: 0x00004924
		public unsafe static int KEYSIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncryptedSetting.NativeFieldInfoPtr_KEYSIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncryptedSetting.NativeFieldInfoPtr_KEYSIZE, (void*)(&value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00043D04 File Offset: 0x00041F04
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00006732 File Offset: 0x00004932
		public unsafe static int BLOCKSIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncryptedSetting.NativeFieldInfoPtr_BLOCKSIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncryptedSetting.NativeFieldInfoPtr_BLOCKSIZE, (void*)(&value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00043D20 File Offset: 0x00041F20
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00006740 File Offset: 0x00004940
		public unsafe RijndaelManaged rijndael
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptedSetting.NativeFieldInfoPtr_rijndael);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RijndaelManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptedSetting.NativeFieldInfoPtr_rijndael), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_KEYSIZE;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_BLOCKSIZE;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_rijndael;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Il2CppStructArray_1_Byte_ISetting_1_String_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_set_Protected_Virtual_Void_String_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_modValue_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x0200029F RID: 671
		[ObfuscatedName("dwd.core.settings.playerPrefs.EncryptedSetting+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001FDE RID: 8158 RVA: 0x000904C8 File Offset: 0x0008E6C8
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<EncryptedSetting.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EncryptedSetting>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptedSetting.__O>.NativeClassPtr);
				EncryptedSetting.__O.NativeFieldInfoPtr__0___TryGetString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedSetting.__O>.NativeClassPtr, "<0>__TryGetString");
				EncryptedSetting.__O.NativeFieldInfoPtr__1___SetString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedSetting.__O>.NativeClassPtr, "<1>__SetString");
				EncryptedSetting.__O.NativeFieldInfoPtr__2___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedSetting.__O>.NativeClassPtr, "<2>__DeleteKey");
			}

			// Token: 0x06001FDF RID: 8159 RVA: 0x0000D93B File Offset: 0x0000BB3B
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x00090530 File Offset: 0x0008E730
			// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x0000D944 File Offset: 0x0000BB44
			public unsafe static PrefSetting<string>.Load _0___TryGetString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EncryptedSetting.__O.NativeFieldInfoPtr__0___TryGetString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EncryptedSetting.__O.NativeFieldInfoPtr__0___TryGetString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00090558 File Offset: 0x0008E758
			// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0000D956 File Offset: 0x0000BB56
			public unsafe static PrefSetting<string>.Store _1___SetString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EncryptedSetting.__O.NativeFieldInfoPtr__1___SetString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EncryptedSetting.__O.NativeFieldInfoPtr__1___SetString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x00090580 File Offset: 0x0008E780
			// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x0000D968 File Offset: 0x0000BB68
			public unsafe static PrefSetting<string>.DeleteKey _2___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EncryptedSetting.__O.NativeFieldInfoPtr__2___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EncryptedSetting.__O.NativeFieldInfoPtr__2___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeFieldInfoPtr__0___TryGetString;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeFieldInfoPtr__1___SetString;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeFieldInfoPtr__2___DeleteKey;
		}
	}
}
