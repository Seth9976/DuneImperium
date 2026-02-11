using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000D7 RID: 215
	public class EnumPrefDefinition<T> : PrefDefinition<T> where T : new()
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x00046348 File Offset: 0x00044548
		// Note: this type is marked as 'beforefieldinit'.
		static EnumPrefDefinition()
		{
			Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "EnumPrefDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr);
			EnumPrefDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_T_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, 100665154);
			EnumPrefDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, 100665155);
			EnumPrefDefinition<T>.NativeMethodInfoPtr_tryGetEnum_Private_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, 100665156);
			EnumPrefDefinition<T>.NativeMethodInfoPtr_setEnum_Private_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, 100665157);
			EnumPrefDefinition<T>.NativeMethodInfoPtr_UserPref_Public_Static_EnumPrefDefinition_1_T_String_T_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, 100665158);
			EnumPrefDefinition<T>.NativeMethodInfoPtr_SystemPref_Public_Static_EnumPrefDefinition_1_T_String_T_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, 100665159);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0004642C File Offset: 0x0004462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865548, XrefRangeEnd = 865550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumPrefDefinition(string key, bool isAccountSetting, T defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_T_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000464E0 File Offset: 0x000446E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865550, XrefRangeEnd = 865636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumPrefDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0004652C File Offset: 0x0004472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865636, XrefRangeEnd = 865645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool tryGetEnum(string key, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.NativeMethodInfoPtr_tryGetEnum_Private_Static_Boolean_String_byref_T_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000465BC File Offset: 0x000447BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865645, XrefRangeEnd = 865655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setEnum(string key, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.NativeMethodInfoPtr_setEnum_Private_Static_Void_String_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0004663C File Offset: 0x0004483C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865655, XrefRangeEnd = 865663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumPrefDefinition<T> UserPref(string key, T defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.NativeMethodInfoPtr_UserPref_Public_Static_EnumPrefDefinition_1_T_String_T_ISetting_1_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<EnumPrefDefinition<T>>(intPtr4) : null;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000466DC File Offset: 0x000448DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865663, XrefRangeEnd = 865671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumPrefDefinition<T> SystemPref(string key, T defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.NativeMethodInfoPtr_SystemPref_Public_Static_EnumPrefDefinition_1_T_String_T_ISetting_1_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<EnumPrefDefinition<T>>(intPtr4) : null;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00006906 File Offset: 0x00004B06
		public EnumPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_T_ISetting_1_String_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_T_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_tryGetEnum_Private_Static_Boolean_String_byref_T_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_setEnum_Private_Static_Void_String_T_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_EnumPrefDefinition_1_T_String_T_ISetting_1_String_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_EnumPrefDefinition_1_T_String_T_ISetting_1_String_0;

		// Token: 0x020002A4 RID: 676
		public class Comparer : Object
		{
			// Token: 0x06002018 RID: 8216 RVA: 0x00091044 File Offset: 0x0008F244
			// Note: this type is marked as 'beforefieldinit'.
			static Comparer()
			{
				Il2CppClassPointerStore<EnumPrefDefinition<T>.Comparer>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, "Comparer"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumPrefDefinition<T>.Comparer>.NativeClassPtr);
				EnumPrefDefinition<T>.Comparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_T__Equals_Private_Virtual_Final_New_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>.Comparer>.NativeClassPtr, 100665160);
				EnumPrefDefinition<T>.Comparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_T__GetHashCode_Private_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>.Comparer>.NativeClassPtr, 100665161);
				EnumPrefDefinition<T>.Comparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPrefDefinition<T>.Comparer>.NativeClassPtr, 100665162);
			}

			// Token: 0x06002019 RID: 8217 RVA: 0x000910E8 File Offset: 0x0008F2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865529, XrefRangeEnd = 865541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_Generic_IEqualityComparer_T__Equals(T x, T y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = y;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref y;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.Comparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_T__Equals_Private_Virtual_Final_New_Boolean_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x0600201A RID: 8218 RVA: 0x000911B4 File Offset: 0x0008F3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865541, XrefRangeEnd = 865548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_Generic_IEqualityComparer_T__GetHashCode(T obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = obj;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref obj;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.Comparer.NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_T__GetHashCode_Private_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600201B RID: 8219 RVA: 0x00091238 File Offset: 0x0008F438
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Comparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumPrefDefinition<T>.Comparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumPrefDefinition<T>.Comparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600201C RID: 8220 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
			public Comparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001663 RID: 5731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_T__Equals_Private_Virtual_Final_New_Boolean_T_T_0;

			// Token: 0x04001664 RID: 5732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_T__GetHashCode_Private_Virtual_Final_New_Int32_T_0;

			// Token: 0x04001665 RID: 5733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002A5 RID: 677
		[ObfuscatedName("dwd.core.settings.playerPrefs.definitions.EnumPrefDefinition`1+<>O")]
		public static class __O : Object
		{
			// Token: 0x0600201D RID: 8221 RVA: 0x00091274 File Offset: 0x0008F474
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<EnumPrefDefinition<T>.__O>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumPrefDefinition<T>>.NativeClassPtr, "<>O"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumPrefDefinition<T>.__O>.NativeClassPtr);
				EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__0___tryGetEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumPrefDefinition<T>.__O>.NativeClassPtr, "<0>__tryGetEnum");
				EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__1___setEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumPrefDefinition<T>.__O>.NativeClassPtr, "<1>__setEnum");
				EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__2___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumPrefDefinition<T>.__O>.NativeClassPtr, "<2>__DeleteKey");
			}

			// Token: 0x0600201E RID: 8222 RVA: 0x0000DACD File Offset: 0x0000BCCD
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x0600201F RID: 8223 RVA: 0x00091318 File Offset: 0x0008F518
			// (set) Token: 0x06002020 RID: 8224 RVA: 0x0000DAD6 File Offset: 0x0000BCD6
			public unsafe static PrefSetting<T>.Load _0___tryGetEnum
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__0___tryGetEnum, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__0___tryGetEnum, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x06002021 RID: 8225 RVA: 0x00091340 File Offset: 0x0008F540
			// (set) Token: 0x06002022 RID: 8226 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
			public unsafe static PrefSetting<T>.Store _1___setEnum
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__1___setEnum, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__1___setEnum, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06002023 RID: 8227 RVA: 0x00091368 File Offset: 0x0008F568
			// (set) Token: 0x06002024 RID: 8228 RVA: 0x0000DAFA File Offset: 0x0000BCFA
			public unsafe static PrefSetting<T>.DeleteKey _2___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__2___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumPrefDefinition<T>.__O.NativeFieldInfoPtr__2___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001666 RID: 5734
			private static readonly IntPtr NativeFieldInfoPtr__0___tryGetEnum;

			// Token: 0x04001667 RID: 5735
			private static readonly IntPtr NativeFieldInfoPtr__1___setEnum;

			// Token: 0x04001668 RID: 5736
			private static readonly IntPtr NativeFieldInfoPtr__2___DeleteKey;
		}
	}
}
