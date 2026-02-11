using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.platform.definitions
{
	// Token: 0x020000E7 RID: 231
	public class ListPlatformSettingDefinition<T> : PlatformSettingDefinition<IReadOnlyList<T>>
	{
		// Token: 0x06000DCC RID: 3532 RVA: 0x00049C58 File Offset: 0x00047E58
		// Note: this type is marked as 'beforefieldinit'.
		static ListPlatformSettingDefinition()
		{
			Il2CppClassPointerStore<ListPlatformSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform.definitions", "ListPlatformSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>>.NativeClassPtr);
			ListPlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_IReadOnlyList_1_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>>.NativeClassPtr, 100665286);
			ListPlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>>.NativeClassPtr, 100665287);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00049CEC File Offset: 0x00047EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866600, XrefRangeEnd = 866603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListPlatformSettingDefinition(string key, IReadOnlyList<T> defaultValue, PlatformSettingStorageNamespacing namespacing = PlatformSettingStorageNamespacing.KeepForNew, IEqualityComparer<IReadOnlyList<T>> comparer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref namespacing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_IReadOnlyList_1_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_IReadOnlyList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00049D6C File Offset: 0x00047F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866603, XrefRangeEnd = 866628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlatformSetting<IReadOnlyList<T>> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListPlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_IReadOnlyList_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSetting<IReadOnlyList<T>>>(intPtr3) : null;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00006BCB File Offset: 0x00004DCB
		public ListPlatformSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IReadOnlyList_1_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_IReadOnlyList_1_T_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_IReadOnlyList_1_T_0;

		// Token: 0x020002AC RID: 684
		[ObfuscatedName("dwd.core.settings.platform.definitions.ListPlatformSettingDefinition`1+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002055 RID: 8277 RVA: 0x00092170 File Offset: 0x00090370
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>>.NativeClassPtr, "<>c__DisplayClass1_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr);
				ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, "storage");
				ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665288);
				ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_IReadOnlyList_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665289);
				ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_IReadOnlyList_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665290);
			}

			// Token: 0x06002056 RID: 8278 RVA: 0x00092228 File Offset: 0x00090428
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002057 RID: 8279 RVA: 0x00092264 File Offset: 0x00090464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866579, XrefRangeEnd = 866593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_String_byref_IReadOnlyList_1_T_PDM_0(string key, out IReadOnlyList<T> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_IReadOnlyList_1_T_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new IReadOnlyList<T>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06002058 RID: 8280 RVA: 0x000922D4 File Offset: 0x000904D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866593, XrefRangeEnd = 866600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ISaveSettingRequest Method_Internal_ISaveSettingRequest_String_IReadOnlyList_1_T_PDM_0(string key, IReadOnlyList<T> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_IReadOnlyList_1_T_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}

			// Token: 0x06002059 RID: 8281 RVA: 0x0000DC23 File Offset: 0x0000BE23
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x0600205A RID: 8282 RVA: 0x00092338 File Offset: 0x00090538
			// (set) Token: 0x0600205B RID: 8283 RVA: 0x0000DC2C File Offset: 0x0000BE2C
			public unsafe IPlatformSettingStorage<string> storage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlatformSettingStorage<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeFieldInfoPtr_storage;

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_IReadOnlyList_1_T_PDM_0;

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_IReadOnlyList_1_T_PDM_0;
		}
	}
}
