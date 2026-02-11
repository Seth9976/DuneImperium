using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.localization
{
	// Token: 0x0200000F RID: 15
	public static class L : Object
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00006710 File Offset: 0x00004910
		// Note: this type is marked as 'beforefieldinit'.
		static L()
		{
			Il2CppClassPointerStore<L>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.localization", "L");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<L>.NativeClassPtr);
			L.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "initialized");
			L.NativeFieldInfoPtr_baseVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "baseVersion");
			L.NativeFieldInfoPtr_localizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "localizer");
			L.NativeMethodInfoPtr_get_Localizer_Public_Static_get_ILocalizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663374);
			L.NativeMethodInfoPtr_get_Version_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663375);
			L.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663376);
			L.NativeMethodInfoPtr_SetLocalizer_Public_Static_Void_IVersionedLocalizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663377);
			L.NativeMethodInfoPtr_LT_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663378);
			L.NativeMethodInfoPtr_LT_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663379);
			L.NativeMethodInfoPtr_Localize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663380);
			L.NativeMethodInfoPtr_Localize_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663381);
			L.NativeMethodInfoPtr_TryLocalize_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663382);
			L.NativeMethodInfoPtr_TryLocalize_Public_Static_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663383);
			L.NativeMethodInfoPtr_LocalizeIfNeeded_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663384);
			L.NativeMethodInfoPtr_Has_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100663385);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000686C File Offset: 0x00004A6C
		public unsafe static ILocalizer Localizer
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1176554, RefRangeEnd = 1176565, XrefRangeStart = 1176528, XrefRangeEnd = 1176554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_get_Localizer_Public_Static_get_ILocalizer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalizer>(intPtr3) : null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000068A0 File Offset: 0x00004AA0
		public unsafe static ulong Version
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1176580, RefRangeEnd = 1176583, XrefRangeStart = 1176565, XrefRangeEnd = 1176580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_get_Version_Public_Static_get_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000068D0 File Offset: 0x00004AD0
		public unsafe static bool Initialized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1176590, RefRangeEnd = 1176591, XrefRangeStart = 1176583, XrefRangeEnd = 1176590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00006900 File Offset: 0x00004B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176591, XrefRangeEnd = 1176607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalizer(IVersionedLocalizer newLocalizer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newLocalizer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_SetLocalizer_Public_Static_Void_IVersionedLocalizer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00006938 File Offset: 0x00004B38
		[CallerCount(233)]
		[CachedScanResults(RefRangeStart = 1176617, RefRangeEnd = 1176850, XrefRangeStart = 1176607, XrefRangeEnd = 1176617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LT(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_LT_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00006974 File Offset: 0x00004B74
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 1176857, RefRangeEnd = 1176924, XrefRangeStart = 1176850, XrefRangeEnd = 1176857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LT(string key, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_LT_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000069D0 File Offset: 0x00004BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176924, XrefRangeEnd = 1176934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Localize(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_Localize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00006A0C File Offset: 0x00004C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176934, XrefRangeEnd = 1176941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Localize(string key, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_Localize_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006A68 File Offset: 0x00004C68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1176951, RefRangeEnd = 1176961, XrefRangeStart = 1176941, XrefRangeEnd = 1176951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryLocalize(string key, out string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_TryLocalize_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1176968, RefRangeEnd = 1176969, XrefRangeStart = 1176961, XrefRangeEnd = 1176968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryLocalize(string key, out string value, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_TryLocalize_Public_Static_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006B40 File Offset: 0x00004D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1176979, RefRangeEnd = 1176981, XrefRangeStart = 1176969, XrefRangeEnd = 1176979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LocalizeIfNeeded(this string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_LocalizeIfNeeded_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00006B7C File Offset: 0x00004D7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1176984, RefRangeEnd = 1176988, XrefRangeStart = 1176981, XrefRangeEnd = 1176984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Has(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(L.NativeMethodInfoPtr_Has_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000022B1 File Offset: 0x000004B1
		public static string LT(string key, params Object[] args)
		{
			return L.LT(key, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000022BF File Offset: 0x000004BF
		public static string Localize(string key, params Object[] args)
		{
			return L.Localize(key, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000022CD File Offset: 0x000004CD
		public static bool TryLocalize(string key, out string value, params Object[] args)
		{
			return L.TryLocalize(key, out value, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000022DC File Offset: 0x000004DC
		public L(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00006BC0 File Offset: 0x00004DC0
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000022E5 File Offset: 0x000004E5
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(L.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(L.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006BDC File Offset: 0x00004DDC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000022F3 File Offset: 0x000004F3
		public unsafe static ulong baseVersion
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(L.NativeFieldInfoPtr_baseVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(L.NativeFieldInfoPtr_baseVersion, (void*)(&value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006BF8 File Offset: 0x00004DF8
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002301 File Offset: 0x00000501
		public unsafe static IVersionedLocalizer localizer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(L.NativeFieldInfoPtr_localizer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVersionedLocalizer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(L.NativeFieldInfoPtr_localizer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_baseVersion;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_localizer;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_Localizer_Public_Static_get_ILocalizer_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Static_get_UInt64_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalizer_Public_Static_Void_IVersionedLocalizer_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_LT_Public_Static_String_String_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_LT_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Localize_Public_Static_String_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Localize_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_TryLocalize_Public_Static_Boolean_String_byref_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_TryLocalize_Public_Static_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_LocalizeIfNeeded_Public_Static_String_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Static_Boolean_String_0;
	}
}
