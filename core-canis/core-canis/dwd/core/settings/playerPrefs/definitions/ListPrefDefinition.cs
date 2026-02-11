using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000DA RID: 218
	public class ListPrefDefinition<T> : PrefDefinition<List<T>>
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x00046B9C File Offset: 0x00044D9C
		// Note: this type is marked as 'beforefieldinit'.
		static ListPrefDefinition()
		{
			Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "ListPrefDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr);
			ListPrefDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_List_1_T_IEqualityComparer_1_List_1_T_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665171);
			ListPrefDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665172);
			ListPrefDefinition<T>.NativeMethodInfoPtr_TryGet_Private_Static_Boolean_String_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665173);
			ListPrefDefinition<T>.NativeMethodInfoPtr_Store_Private_Static_Void_String_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665174);
			ListPrefDefinition<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665175);
			ListPrefDefinition<T>.NativeMethodInfoPtr_Remove_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665176);
			ListPrefDefinition<T>.NativeMethodInfoPtr_UserPref_Public_Static_ListPrefDefinition_1_T_String_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665177);
			ListPrefDefinition<T>.NativeMethodInfoPtr_SystemPref_Public_Static_ListPrefDefinition_1_T_String_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, 100665178);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00046CA8 File Offset: 0x00044EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 865708, RefRangeEnd = 865711, XrefRangeStart = 865707, XrefRangeEnd = 865708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListPrefDefinition(string key, bool isAccountSetting, List<T> defaultValue, IEqualityComparer<List<T>> comparer = null, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_List_1_T_IEqualityComparer_1_List_1_T_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00046D3C File Offset: 0x00044F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865711, XrefRangeEnd = 865772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<List<T>> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListPrefDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_List_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<List<T>>>(intPtr3) : null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00046D88 File Offset: 0x00044F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865772, XrefRangeEnd = 865785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGet(string key, out List<T> value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr_TryGet_Private_Static_Boolean_String_byref_List_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new List<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00046DEC File Offset: 0x00044FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865785, XrefRangeEnd = 865795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Store(string key, List<T> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr_Store_Private_Static_Void_String_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00046E34 File Offset: 0x00045034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865809, RefRangeEnd = 865810, XrefRangeStart = 865795, XrefRangeEnd = 865809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00046EAC File Offset: 0x000450AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865810, XrefRangeEnd = 865822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr_Remove_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00046F24 File Offset: 0x00045124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865822, XrefRangeEnd = 865827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ListPrefDefinition<T> UserPref(string key, List<T> defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr_UserPref_Public_Static_ListPrefDefinition_1_T_String_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListPrefDefinition<T>>(intPtr3) : null;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00046F7C File Offset: 0x0004517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865827, XrefRangeEnd = 865832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ListPrefDefinition<T> SystemPref(string key, List<T> defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPrefDefinition<T>.NativeMethodInfoPtr_SystemPref_Public_Static_ListPrefDefinition_1_T_String_List_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListPrefDefinition<T>>(intPtr3) : null;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00006921 File Offset: 0x00004B21
		public ListPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_List_1_T_IEqualityComparer_1_List_1_T_ISetting_1_String_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_List_1_T_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Private_Static_Boolean_String_byref_List_1_T_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_Store_Private_Static_Void_String_List_1_T_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_ListPrefDefinition_1_T_String_List_1_T_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_ListPrefDefinition_1_T_String_List_1_T_0;

		// Token: 0x020002A6 RID: 678
		[ObfuscatedName("dwd.core.settings.playerPrefs.definitions.ListPrefDefinition`1+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002025 RID: 8229 RVA: 0x00091390 File Offset: 0x0008F590
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ListPrefDefinition<T>.__O>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListPrefDefinition<T>>.NativeClassPtr, "<>O"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPrefDefinition<T>.__O>.NativeClassPtr);
				ListPrefDefinition<T>.__O.NativeFieldInfoPtr__0___TryGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPrefDefinition<T>.__O>.NativeClassPtr, "<0>__TryGet");
				ListPrefDefinition<T>.__O.NativeFieldInfoPtr__1___Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPrefDefinition<T>.__O>.NativeClassPtr, "<1>__Store");
				ListPrefDefinition<T>.__O.NativeFieldInfoPtr__2___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPrefDefinition<T>.__O>.NativeClassPtr, "<2>__DeleteKey");
			}

			// Token: 0x06002026 RID: 8230 RVA: 0x0000DB0C File Offset: 0x0000BD0C
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x06002027 RID: 8231 RVA: 0x00091434 File Offset: 0x0008F634
			// (set) Token: 0x06002028 RID: 8232 RVA: 0x0000DB15 File Offset: 0x0000BD15
			public unsafe static PrefSetting<List<T>>.Load _0___TryGet
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListPrefDefinition<T>.__O.NativeFieldInfoPtr__0___TryGet, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<List<T>>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListPrefDefinition<T>.__O.NativeFieldInfoPtr__0___TryGet, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x06002029 RID: 8233 RVA: 0x0009145C File Offset: 0x0008F65C
			// (set) Token: 0x0600202A RID: 8234 RVA: 0x0000DB27 File Offset: 0x0000BD27
			public unsafe static PrefSetting<List<T>>.Store _1___Store
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListPrefDefinition<T>.__O.NativeFieldInfoPtr__1___Store, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<List<T>>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListPrefDefinition<T>.__O.NativeFieldInfoPtr__1___Store, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x0600202B RID: 8235 RVA: 0x00091484 File Offset: 0x0008F684
			// (set) Token: 0x0600202C RID: 8236 RVA: 0x0000DB39 File Offset: 0x0000BD39
			public unsafe static PrefSetting<List<T>>.DeleteKey _2___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListPrefDefinition<T>.__O.NativeFieldInfoPtr__2___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<List<T>>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListPrefDefinition<T>.__O.NativeFieldInfoPtr__2___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001669 RID: 5737
			private static readonly IntPtr NativeFieldInfoPtr__0___TryGet;

			// Token: 0x0400166A RID: 5738
			private static readonly IntPtr NativeFieldInfoPtr__1___Store;

			// Token: 0x0400166B RID: 5739
			private static readonly IntPtr NativeFieldInfoPtr__2___DeleteKey;
		}
	}
}
