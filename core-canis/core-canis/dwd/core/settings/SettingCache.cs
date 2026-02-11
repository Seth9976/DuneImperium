using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings
{
	// Token: 0x020000B5 RID: 181
	public class SettingCache<T> : VersionedModel
	{
		// Token: 0x06000B7D RID: 2941 RVA: 0x0003F520 File Offset: 0x0003D720
		// Note: this type is marked as 'beforefieldinit'.
		static SettingCache()
		{
			Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "SettingCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr);
			SettingCache<T>.NativeFieldInfoPtr_loadFromStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "loadFromStorage");
			SettingCache<T>.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "defaultValue");
			SettingCache<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "comparer");
			SettingCache<T>.NativeFieldInfoPtr_tempExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "tempExists");
			SettingCache<T>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "value");
			SettingCache<T>.NativeFieldInfoPtr_storedExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "storedExists");
			SettingCache<T>.NativeFieldInfoPtr_storedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "storedValue");
			SettingCache<T>.NativeFieldInfoPtr_storageCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "storageCached");
			SettingCache<T>.NativeMethodInfoPtr__ctor_Public_Void_Load_T_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664893);
			SettingCache<T>.NativeMethodInfoPtr_get_TempExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664894);
			SettingCache<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664895);
			SettingCache<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664896);
			SettingCache<T>.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664897);
			SettingCache<T>.NativeMethodInfoPtr_get_StoredExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664898);
			SettingCache<T>.NativeMethodInfoPtr_get_StoredValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664899);
			SettingCache<T>.NativeMethodInfoPtr_assertCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664900);
			SettingCache<T>.NativeMethodInfoPtr_Revert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664901);
			SettingCache<T>.NativeMethodInfoPtr_Commit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664902);
			SettingCache<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, 100664903);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0003F708 File Offset: 0x0003D908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 863694, RefRangeEnd = 863697, XrefRangeStart = 863675, XrefRangeEnd = 863694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingCache(SettingCache<T>.Load loadFromStorage, T defaultValue, IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadFromStorage);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr__ctor_Public_Void_Load_T_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003F7B0 File Offset: 0x0003D9B0
		public unsafe bool TempExists
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 863697, RefRangeEnd = 863699, XrefRangeStart = 863697, XrefRangeEnd = 863697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_get_TempExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0003F7EC File Offset: 0x0003D9EC
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0003F828 File Offset: 0x0003DA28
		public unsafe T Value
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 863699, RefRangeEnd = 863708, XrefRangeStart = 863699, XrefRangeEnd = 863699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 863711, RefRangeEnd = 863713, XrefRangeStart = 863708, XrefRangeEnd = 863711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 863714, RefRangeEnd = 863719, XrefRangeStart = 863713, XrefRangeEnd = 863714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
		public unsafe bool StoredExists
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 863719, RefRangeEnd = 863723, XrefRangeStart = 863719, XrefRangeEnd = 863719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_get_StoredExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0003F910 File Offset: 0x0003DB10
		public unsafe T StoredValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 863723, RefRangeEnd = 863725, XrefRangeStart = 863723, XrefRangeEnd = 863723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_get_StoredValue_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0003F94C File Offset: 0x0003DB4C
		[CallerCount(0)]
		public unsafe void assertCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_assertCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0003F980 File Offset: 0x0003DB80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863728, RefRangeEnd = 863730, XrefRangeStart = 863725, XrefRangeEnd = 863728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_Revert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863733, RefRangeEnd = 863735, XrefRangeStart = 863730, XrefRangeEnd = 863733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_Commit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0003F9E8 File Offset: 0x0003DBE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 863736, RefRangeEnd = 863739, XrefRangeStart = 863735, XrefRangeEnd = 863736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000060CB File Offset: 0x000042CB
		public SettingCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0003FA1C File Offset: 0x0003DC1C
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x000060D4 File Offset: 0x000042D4
		public unsafe SettingCache<T>.Load loadFromStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_loadFromStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingCache<T>.Load>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_loadFromStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003FA4C File Offset: 0x0003DC4C
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0003FA74 File Offset: 0x0003DC74
		public unsafe T defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_defaultValue);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0003FB1C File Offset: 0x0003DD1C
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x000060F3 File Offset: 0x000042F3
		public unsafe IEqualityComparer<T> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0003FB4C File Offset: 0x0003DD4C
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00006112 File Offset: 0x00004312
		public unsafe bool tempExists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_tempExists);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_tempExists)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0003FB74 File Offset: 0x0003DD74
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0003FB9C File Offset: 0x0003DD9C
		public unsafe T value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_value);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0003FC44 File Offset: 0x0003DE44
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0000612D File Offset: 0x0000432D
		public unsafe bool storedExists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_storedExists);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_storedExists)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0003FC6C File Offset: 0x0003DE6C
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x0003FC94 File Offset: 0x0003DE94
		public unsafe T storedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_storedValue);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_storedValue);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00006148 File Offset: 0x00004348
		public unsafe bool storageCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_storageCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingCache<T>.NativeFieldInfoPtr_storageCached)) = value;
			}
		}

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_loadFromStorage;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_tempExists;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_storedExists;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_storedValue;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr_storageCached;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Load_T_T_IEqualityComparer_1_T_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_TempExists_Public_get_Boolean_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredExists_Public_get_Boolean_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredValue_Public_get_T_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_assertCache_Private_Void_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Void_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x02000295 RID: 661
		public sealed class Load : MulticastDelegate
		{
			// Token: 0x06001F7B RID: 8059 RVA: 0x0008EC48 File Offset: 0x0008CE48
			// Note: this type is marked as 'beforefieldinit'.
			static Load()
			{
				Il2CppClassPointerStore<SettingCache<T>.Load>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingCache<T>>.NativeClassPtr, "Load"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				SettingCache<T>.Load.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>.Load>.NativeClassPtr, 100664904);
				SettingCache<T>.Load.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>.Load>.NativeClassPtr, 100664905);
				SettingCache<T>.Load.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>.Load>.NativeClassPtr, 100664906);
				SettingCache<T>.Load.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCache<T>.Load>.NativeClassPtr, 100664907);
			}

			// Token: 0x06001F7C RID: 8060 RVA: 0x0008ECF4 File Offset: 0x0008CEF4
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 863654, RefRangeEnd = 863669, XrefRangeStart = 863650, XrefRangeEnd = 863654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Load(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingCache<T>.Load>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.Load.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F7D RID: 8061 RVA: 0x0008ED50 File Offset: 0x0008CF50
			[CallerCount(0)]
			public unsafe bool Invoke(out T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
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
					IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.Load.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
					Il2CppException.RaiseExceptionIfNecessary(intPtr4);
					if (!typeof(T).IsValueType)
					{
						IntPtr intPtr5 = intPtr;
						value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
					}
					return *IL2CPP.il2cpp_object_unbox(intPtr3);
				}
			}

			// Token: 0x06001F7E RID: 8062 RVA: 0x0008EDDC File Offset: 0x0008CFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863669, XrefRangeEnd = 863673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(out T value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
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
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.Load.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				IntPtr intPtr6 = intPtr3;
				return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
			}

			// Token: 0x06001F7F RID: 8063 RVA: 0x0008EE90 File Offset: 0x0008D090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863673, XrefRangeEnd = 863675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out T value, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
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
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SettingCache<T>.Load.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06001F80 RID: 8064 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
			public Load(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_T_0;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0;
		}
	}
}
