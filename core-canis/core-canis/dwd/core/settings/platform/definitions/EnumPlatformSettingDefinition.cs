using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.platform.definitions
{
	// Token: 0x020000E3 RID: 227
	public class EnumPlatformSettingDefinition<T> : PlatformSettingDefinition<T> where T : Enum, new()
	{
		// Token: 0x06000DBC RID: 3516 RVA: 0x000495D4 File Offset: 0x000477D4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumPlatformSettingDefinition()
		{
			Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform.definitions", "EnumPlatformSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>>.NativeClassPtr);
			EnumPlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>>.NativeClassPtr, 100665270);
			EnumPlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>>.NativeClassPtr, 100665271);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00049668 File Offset: 0x00047868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866485, XrefRangeEnd = 866488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumPlatformSettingDefinition(string key, T defaultValue, PlatformSettingStorageNamespacing namespacing = PlatformSettingStorageNamespacing.KeepForNew, IEqualityComparer<T> comparer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref namespacing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0004971C File Offset: 0x0004791C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866488, XrefRangeEnd = 866513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlatformSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumPlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public EnumPlatformSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_T_0;

		// Token: 0x020002AA RID: 682
		[ObfuscatedName("dwd.core.settings.platform.definitions.EnumPlatformSettingDefinition`1+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002045 RID: 8261 RVA: 0x00091C7C File Offset: 0x0008FE7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>>.NativeClassPtr, "<>c__DisplayClass1_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr);
				EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, "storage");
				EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665272);
				EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665273);
				EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665274);
			}

			// Token: 0x06002046 RID: 8262 RVA: 0x00091D34 File Offset: 0x0008FF34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002047 RID: 8263 RVA: 0x00091D70 File Offset: 0x0008FF70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866472, XrefRangeEnd = 866480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_String_byref_T_PDM_0(string key, out T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_T_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002048 RID: 8264 RVA: 0x00091E0C File Offset: 0x0009000C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866480, XrefRangeEnd = 866485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ISaveSettingRequest Method_Internal_ISaveSettingRequest_String_T_PDM_0(string key, T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_T_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}

			// Token: 0x06002049 RID: 8265 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x0600204A RID: 8266 RVA: 0x00091EA4 File Offset: 0x000900A4
			// (set) Token: 0x0600204B RID: 8267 RVA: 0x0000DBBD File Offset: 0x0000BDBD
			public unsafe IPlatformSettingStorage<int> storage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlatformSettingStorage<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeFieldInfoPtr_storage;

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_T_PDM_0;

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_T_PDM_0;
		}
	}
}
