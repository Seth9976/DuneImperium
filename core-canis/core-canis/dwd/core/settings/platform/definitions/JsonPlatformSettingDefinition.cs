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
	// Token: 0x020000E6 RID: 230
	public class JsonPlatformSettingDefinition<T> : PlatformSettingDefinition<T>
	{
		// Token: 0x06000DC8 RID: 3528 RVA: 0x00049AC4 File Offset: 0x00047CC4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPlatformSettingDefinition()
		{
			Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform.definitions", "JsonPlatformSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>>.NativeClassPtr);
			JsonPlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>>.NativeClassPtr, 100665281);
			JsonPlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>>.NativeClassPtr, 100665282);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00049B58 File Offset: 0x00047D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866542, XrefRangeEnd = 866543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPlatformSettingDefinition(string key, T defaultValue, PlatformSettingStorageNamespacing namespacing = PlatformSettingStorageNamespacing.KeepForNew, IEqualityComparer<T> comparer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>>.NativeClassPtr))
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonPlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00049C0C File Offset: 0x00047E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866543, XrefRangeEnd = 866579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlatformSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonPlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00006BC2 File Offset: 0x00004DC2
		public JsonPlatformSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PlatformSetting_1_T_0;

		// Token: 0x020002AB RID: 683
		[ObfuscatedName("dwd.core.settings.platform.definitions.JsonPlatformSettingDefinition`1+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600204C RID: 8268 RVA: 0x00091ED4 File Offset: 0x000900D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>>.NativeClassPtr, "<>c__DisplayClass1_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr);
				JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, "storage");
				JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665283);
				JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665284);
				JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665285);
			}

			// Token: 0x0600204D RID: 8269 RVA: 0x00091FA0 File Offset: 0x000901A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600204E RID: 8270 RVA: 0x00091FDC File Offset: 0x000901DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866527, XrefRangeEnd = 866534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_T_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x0600204F RID: 8271 RVA: 0x00092078 File Offset: 0x00090278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866534, XrefRangeEnd = 866542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_T_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}

			// Token: 0x06002050 RID: 8272 RVA: 0x0000DBDC File Offset: 0x0000BDDC
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06002051 RID: 8273 RVA: 0x00092110 File Offset: 0x00090310
			// (set) Token: 0x06002052 RID: 8274 RVA: 0x0000DBE5 File Offset: 0x0000BDE5
			public unsafe IPlatformSettingStorage<string> storage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPlatformSettingStorage<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_storage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06002053 RID: 8275 RVA: 0x00092140 File Offset: 0x00090340
			// (set) Token: 0x06002054 RID: 8276 RVA: 0x0000DC04 File Offset: 0x0000BE04
			public unsafe JsonPlatformSettingDefinition<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonPlatformSettingDefinition<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPlatformSettingDefinition<T>.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeFieldInfoPtr_storage;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_String_byref_T_PDM_0;

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_ISaveSettingRequest_String_T_PDM_0;
		}
	}
}
