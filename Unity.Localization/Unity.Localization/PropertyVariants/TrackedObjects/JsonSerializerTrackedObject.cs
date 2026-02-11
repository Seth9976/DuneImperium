using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class JsonSerializerTrackedObject : TrackedObject
	{
		// Token: 0x06000BF4 RID: 3060 RVA: 0x00036384 File Offset: 0x00034584
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializerTrackedObject()
		{
			Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "JsonSerializerTrackedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr);
			JsonSerializerTrackedObject.NativeFieldInfoPtr_m_UpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, "m_UpdateType");
			JsonSerializerTrackedObject.NativeMethodInfoPtr_get_UpdateType_Public_get_ApplyChangesMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665263);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_set_UpdateType_Public_set_Void_ApplyChangesMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665264);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_AddTrackedProperty_Public_Virtual_Void_ITrackedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665265);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665266);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_ApplyArraySizes_Private_Void_IEnumerable_1_ArraySizeTrackedProperty_JObject_LocaleIdentifier_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665267);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_ApplyJson_Private_Void_JObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665268);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_GetNextArrayItem_Internal_Static_ArrayResult_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665269);
			JsonSerializerTrackedObject.NativeMethodInfoPtr_GetPropertyFromPath_Internal_Static_JToken_String_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665270);
			JsonSerializerTrackedObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, 100665271);
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0003647C File Offset: 0x0003467C
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000364B8 File Offset: 0x000346B8
		public unsafe JsonSerializerTrackedObject.ApplyChangesMethod UpdateType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr_get_UpdateType_Public_get_ApplyChangesMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr_set_UpdateType_Public_set_Void_ApplyChangesMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000364F8 File Offset: 0x000346F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080102, XrefRangeEnd = 1080114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddTrackedProperty(ITrackedProperty trackedProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trackedProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerTrackedObject.NativeMethodInfoPtr_AddTrackedProperty_Public_Virtual_Void_ITrackedProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00036548 File Offset: 0x00034748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080114, XrefRangeEnd = 1080340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variantLocale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultLocale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerTrackedObject.NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000365B0 File Offset: 0x000347B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1080377, RefRangeEnd = 1080379, XrefRangeStart = 1080340, XrefRangeEnd = 1080377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyArraySizes(IEnumerable<ArraySizeTrackedProperty> arraySizes, JObject jsonObject, LocaleIdentifier variantLocale, LocaleIdentifier defaultLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arraySizes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(variantLocale));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(defaultLocale));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr_ApplyArraySizes_Private_Void_IEnumerable_1_ArraySizeTrackedProperty_JObject_LocaleIdentifier_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00036634 File Offset: 0x00034834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080379, XrefRangeEnd = 1080381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyJson(JObject jsonObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jsonObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr_ApplyJson_Private_Void_JObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00036678 File Offset: 0x00034878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1080392, RefRangeEnd = 1080394, XrefRangeStart = 1080381, XrefRangeEnd = 1080392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializerTrackedObject.ArrayResult GetNextArrayItem(string path, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr_GetNextArrayItem_Internal_Static_ArrayResult_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JsonSerializerTrackedObject.ArrayResult(intPtr);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000366C4 File Offset: 0x000348C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1080438, RefRangeEnd = 1080443, XrefRangeStart = 1080394, XrefRangeEnd = 1080438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken GetPropertyFromPath(string path, JContainer obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr_GetPropertyFromPath_Internal_Static_JToken_String_JContainer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0003671C File Offset: 0x0003491C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080443, XrefRangeEnd = 1080444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerTrackedObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0000714E File Offset: 0x0000534E
		public JsonSerializerTrackedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00036758 File Offset: 0x00034958
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00007157 File Offset: 0x00005357
		public unsafe JsonSerializerTrackedObject.ApplyChangesMethod m_UpdateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.NativeFieldInfoPtr_m_UpdateType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.NativeFieldInfoPtr_m_UpdateType)) = value;
			}
		}

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateType;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateType_Public_get_ApplyChangesMethod_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateType_Public_set_Void_ApplyChangesMethod_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_AddTrackedProperty_Public_Virtual_Void_ITrackedProperty_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocale_Public_Virtual_AsyncOperationHandle_Locale_Locale_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_ApplyArraySizes_Private_Void_IEnumerable_1_ArraySizeTrackedProperty_JObject_LocaleIdentifier_LocaleIdentifier_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_ApplyJson_Private_Void_JObject_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_GetNextArrayItem_Internal_Static_ArrayResult_String_Int32_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyFromPath_Internal_Static_JToken_String_JContainer_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000183 RID: 387
		public enum ApplyChangesMethod
		{
			// Token: 0x04000AE6 RID: 2790
			Partial,
			// Token: 0x04000AE7 RID: 2791
			Full
		}

		// Token: 0x02000184 RID: 388
		public class DeferredJsonStringOperation : Object
		{
			// Token: 0x06000FE1 RID: 4065 RVA: 0x000437B8 File Offset: 0x000419B8
			// Note: this type is marked as 'beforefieldinit'.
			static DeferredJsonStringOperation()
			{
				Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, "DeferredJsonStringOperation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr);
				JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_jsonValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr, "jsonValue");
				JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr, "callback");
				JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr, "Pool");
				JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr, 100665272);
				JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeMethodInfoPtr_OnStringLoaded_Private_Void_AsyncOperationHandle_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr, 100665273);
			}

			// Token: 0x06000FE2 RID: 4066 RVA: 0x00043848 File Offset: 0x00041A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079972, XrefRangeEnd = 1079980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeferredJsonStringOperation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FE3 RID: 4067 RVA: 0x00043884 File Offset: 0x00041A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079980, XrefRangeEnd = 1079992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStringLoaded(AsyncOperationHandle<string> asyncOperationHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(asyncOperationHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeMethodInfoPtr_OnStringLoaded_Private_Void_AsyncOperationHandle_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FE4 RID: 4068 RVA: 0x00008A45 File Offset: 0x00006C45
			public DeferredJsonStringOperation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000438CC File Offset: 0x00041ACC
			// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00008A4E File Offset: 0x00006C4E
			public unsafe JValue jsonValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_jsonValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_jsonValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000438FC File Offset: 0x00041AFC
			// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00008A6D File Offset: 0x00006C6D
			public unsafe Action<AsyncOperationHandle<string>> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0004392C File Offset: 0x00041B2C
			// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00008A8C File Offset: 0x00006C8C
			public unsafe static ObjectPool<JsonSerializerTrackedObject.DeferredJsonStringOperation> Pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<JsonSerializerTrackedObject.DeferredJsonStringOperation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerTrackedObject.DeferredJsonStringOperation.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AE8 RID: 2792
			private static readonly IntPtr NativeFieldInfoPtr_jsonValue;

			// Token: 0x04000AE9 RID: 2793
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000AEA RID: 2794
			private static readonly IntPtr NativeFieldInfoPtr_Pool;

			// Token: 0x04000AEB RID: 2795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AEC RID: 2796
			private static readonly IntPtr NativeMethodInfoPtr_OnStringLoaded_Private_Void_AsyncOperationHandle_1_String_0;

			// Token: 0x02000190 RID: 400
			[ObfuscatedName("UnityEngine.Localization.PropertyVariants.TrackedObjects.JsonSerializerTrackedObject+DeferredJsonStringOperation+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001037 RID: 4151 RVA: 0x000445C8 File Offset: 0x000427C8
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>.NativeClassPtr);
					JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>.NativeClassPtr, "<>9");
					JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>.NativeClassPtr, 100665276);
					JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_DeferredJsonStringOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>.NativeClassPtr, 100665277);
				}

				// Token: 0x06001038 RID: 4152 RVA: 0x00044630 File Offset: 0x00042830
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001039 RID: 4153 RVA: 0x0004466C File Offset: 0x0004286C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079961, XrefRangeEnd = 1079972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe JsonSerializerTrackedObject.DeferredJsonStringOperation __cctor_b__5_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_DeferredJsonStringOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializerTrackedObject.DeferredJsonStringOperation>(intPtr3) : null;
				}

				// Token: 0x0600103A RID: 4154 RVA: 0x00008D97 File Offset: 0x00006F97
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700045A RID: 1114
				// (get) Token: 0x0600103B RID: 4155 RVA: 0x000446AC File Offset: 0x000428AC
				// (set) Token: 0x0600103C RID: 4156 RVA: 0x00008DA0 File Offset: 0x00006FA0
				public unsafe static JsonSerializerTrackedObject.DeferredJsonStringOperation.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerTrackedObject.DeferredJsonStringOperation.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonSerializerTrackedObject.DeferredJsonStringOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000B13 RID: 2835
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000B14 RID: 2836
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000B15 RID: 2837
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_DeferredJsonStringOperation_0;
			}
		}

		// Token: 0x02000185 RID: 389
		public class DeferredJsonObjectOperation : Object
		{
			// Token: 0x06000FEB RID: 4075 RVA: 0x00043954 File Offset: 0x00041B54
			// Note: this type is marked as 'beforefieldinit'.
			static DeferredJsonObjectOperation()
			{
				Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, "DeferredJsonObjectOperation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr);
				JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_jsonValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr, "jsonValue");
				JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr, "callback");
				JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr, "Pool");
				JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr, 100665278);
				JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeMethodInfoPtr_OnAssetLoaded_Private_Void_AsyncOperationHandle_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr, 100665279);
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x000439E4 File Offset: 0x00041BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080003, XrefRangeEnd = 1080011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeferredJsonObjectOperation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FED RID: 4077 RVA: 0x00043A20 File Offset: 0x00041C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080011, XrefRangeEnd = 1080034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnAssetLoaded(AsyncOperationHandle<Object> asyncOperationHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(asyncOperationHandle));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeMethodInfoPtr_OnAssetLoaded_Private_Void_AsyncOperationHandle_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FEE RID: 4078 RVA: 0x00008A9E File Offset: 0x00006C9E
			public DeferredJsonObjectOperation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00043A68 File Offset: 0x00041C68
			// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00008AA7 File Offset: 0x00006CA7
			public unsafe JValue jsonValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_jsonValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_jsonValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00043A98 File Offset: 0x00041C98
			// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00008AC6 File Offset: 0x00006CC6
			public unsafe Action<AsyncOperationHandle<Object>> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00043AC8 File Offset: 0x00041CC8
			// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00008AE5 File Offset: 0x00006CE5
			public unsafe static ObjectPool<JsonSerializerTrackedObject.DeferredJsonObjectOperation> Pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<JsonSerializerTrackedObject.DeferredJsonObjectOperation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerTrackedObject.DeferredJsonObjectOperation.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AED RID: 2797
			private static readonly IntPtr NativeFieldInfoPtr_jsonValue;

			// Token: 0x04000AEE RID: 2798
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000AEF RID: 2799
			private static readonly IntPtr NativeFieldInfoPtr_Pool;

			// Token: 0x04000AF0 RID: 2800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AF1 RID: 2801
			private static readonly IntPtr NativeMethodInfoPtr_OnAssetLoaded_Private_Void_AsyncOperationHandle_1_Object_0;

			// Token: 0x02000191 RID: 401
			[ObfuscatedName("UnityEngine.Localization.PropertyVariants.TrackedObjects.JsonSerializerTrackedObject+DeferredJsonObjectOperation+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x0600103D RID: 4157 RVA: 0x000446D4 File Offset: 0x000428D4
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>.NativeClassPtr);
					JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>.NativeClassPtr, "<>9");
					JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>.NativeClassPtr, 100665282);
					JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_DeferredJsonObjectOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>.NativeClassPtr, 100665283);
				}

				// Token: 0x0600103E RID: 4158 RVA: 0x0004473C File Offset: 0x0004293C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600103F RID: 4159 RVA: 0x00044778 File Offset: 0x00042978
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079992, XrefRangeEnd = 1080003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe JsonSerializerTrackedObject.DeferredJsonObjectOperation __cctor_b__5_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_DeferredJsonObjectOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializerTrackedObject.DeferredJsonObjectOperation>(intPtr3) : null;
				}

				// Token: 0x06001040 RID: 4160 RVA: 0x00008DB2 File Offset: 0x00006FB2
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700045B RID: 1115
				// (get) Token: 0x06001041 RID: 4161 RVA: 0x000447B8 File Offset: 0x000429B8
				// (set) Token: 0x06001042 RID: 4162 RVA: 0x00008DBB File Offset: 0x00006FBB
				public unsafe static JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonSerializerTrackedObject.DeferredJsonObjectOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000B16 RID: 2838
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04000B17 RID: 2839
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04000B18 RID: 2840
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_DeferredJsonObjectOperation_0;
			}
		}

		// Token: 0x02000186 RID: 390
		public sealed class ArrayResult : ValueType
		{
			// Token: 0x06000FF5 RID: 4085 RVA: 0x00043AF0 File Offset: 0x00041CF0
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayResult()
			{
				Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, "ArrayResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr);
				JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, "path");
				JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, "arrayStartIndex");
				JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayDataIndexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, "arrayDataIndexStart");
				JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayDataIndexEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, "arrayDataIndexEnd");
				JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr_get_IsArraySize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, 100665284);
				JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr_get_IsArrayElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, 100665285);
				JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr_GetDataIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, 100665286);
				JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr, 100665287);
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00043BBC File Offset: 0x00041DBC
			public unsafe bool IsArraySize
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr_get_IsArraySize_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00043C00 File Offset: 0x00041E00
			public unsafe bool IsArrayElement
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1080039, RefRangeEnd = 1080040, XrefRangeStart = 1080034, XrefRangeEnd = 1080039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr_get_IsArrayElement_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FF8 RID: 4088 RVA: 0x00043C44 File Offset: 0x00041E44
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1080061, RefRangeEnd = 1080062, XrefRangeStart = 1080040, XrefRangeEnd = 1080061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetDataIndex()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr_GetDataIndex_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000FF9 RID: 4089 RVA: 0x00043C88 File Offset: 0x00041E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080062, XrefRangeEnd = 1080063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrayResult(string p, int start, int bracketStart, int bracketEnd)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bracketStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bracketEnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.ArrayResult.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FFA RID: 4090 RVA: 0x00008AF7 File Offset: 0x00006CF7
			public ArrayResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x00008B00 File Offset: 0x00006D00
			public ArrayResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.ArrayResult>.NativeClassPtr))
			{
			}

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00043D04 File Offset: 0x00041F04
			// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00008B12 File Offset: 0x00006D12
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00043D2C File Offset: 0x00041F2C
			// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00008B31 File Offset: 0x00006D31
			public unsafe int arrayStartIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayStartIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayStartIndex)) = value;
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06001000 RID: 4096 RVA: 0x00043D54 File Offset: 0x00041F54
			// (set) Token: 0x06001001 RID: 4097 RVA: 0x00008B4C File Offset: 0x00006D4C
			public unsafe int arrayDataIndexStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayDataIndexStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayDataIndexStart)) = value;
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06001002 RID: 4098 RVA: 0x00043D7C File Offset: 0x00041F7C
			// (set) Token: 0x06001003 RID: 4099 RVA: 0x00008B67 File Offset: 0x00006D67
			public unsafe int arrayDataIndexEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayDataIndexEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.ArrayResult.NativeFieldInfoPtr_arrayDataIndexEnd)) = value;
				}
			}

			// Token: 0x04000AF2 RID: 2802
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04000AF3 RID: 2803
			private static readonly IntPtr NativeFieldInfoPtr_arrayStartIndex;

			// Token: 0x04000AF4 RID: 2804
			private static readonly IntPtr NativeFieldInfoPtr_arrayDataIndexStart;

			// Token: 0x04000AF5 RID: 2805
			private static readonly IntPtr NativeFieldInfoPtr_arrayDataIndexEnd;

			// Token: 0x04000AF6 RID: 2806
			private static readonly IntPtr NativeMethodInfoPtr_get_IsArraySize_Public_get_Boolean_0;

			// Token: 0x04000AF7 RID: 2807
			private static readonly IntPtr NativeMethodInfoPtr_get_IsArrayElement_Public_get_Boolean_0;

			// Token: 0x04000AF8 RID: 2808
			private static readonly IntPtr NativeMethodInfoPtr_GetDataIndex_Public_Int32_0;

			// Token: 0x04000AF9 RID: 2809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;
		}

		// Token: 0x02000187 RID: 391
		[ObfuscatedName("UnityEngine.Localization.PropertyVariants.TrackedObjects.JsonSerializerTrackedObject+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001004 RID: 4100 RVA: 0x00043DA4 File Offset: 0x00041FA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerTrackedObject>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr);
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_arraySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, "arraySizes");
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_jsonObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, "jsonObject");
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_variantLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, "variantLocale");
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_defaultLocaleIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, "defaultLocaleIdentifier");
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_asyncOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, "asyncOperations");
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, 100665288);
				JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeMethodInfoPtr__ApplyLocale_b__0_Internal_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr, 100665289);
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x00043E70 File Offset: 0x00042070
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerTrackedObject.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001006 RID: 4102 RVA: 0x00043EAC File Offset: 0x000420AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080063, XrefRangeEnd = 1080102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ApplyLocale_b__0(AsyncOperationHandle<IList<AsyncOperationHandle>> res)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(res));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeMethodInfoPtr__ApplyLocale_b__0_Internal_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001007 RID: 4103 RVA: 0x00008B82 File Offset: 0x00006D82
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06001008 RID: 4104 RVA: 0x00043EF4 File Offset: 0x000420F4
			// (set) Token: 0x06001009 RID: 4105 RVA: 0x00008B8B File Offset: 0x00006D8B
			public unsafe JsonSerializerTrackedObject __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerTrackedObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x0600100A RID: 4106 RVA: 0x00043F24 File Offset: 0x00042124
			// (set) Token: 0x0600100B RID: 4107 RVA: 0x00008BAA File Offset: 0x00006DAA
			public unsafe List<ArraySizeTrackedProperty> arraySizes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_arraySizes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArraySizeTrackedProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_arraySizes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x0600100C RID: 4108 RVA: 0x00043F54 File Offset: 0x00042154
			// (set) Token: 0x0600100D RID: 4109 RVA: 0x00008BC9 File Offset: 0x00006DC9
			public unsafe JObject jsonObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_jsonObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_jsonObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x0600100E RID: 4110 RVA: 0x00043F84 File Offset: 0x00042184
			// (set) Token: 0x0600100F RID: 4111 RVA: 0x00008BE8 File Offset: 0x00006DE8
			public unsafe Locale variantLocale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_variantLocale);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_variantLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06001010 RID: 4112 RVA: 0x00043FB4 File Offset: 0x000421B4
			// (set) Token: 0x06001011 RID: 4113 RVA: 0x00008C07 File Offset: 0x00006E07
			public LocaleIdentifier defaultLocaleIdentifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_defaultLocaleIdentifier);
					return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_defaultLocaleIdentifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06001012 RID: 4114 RVA: 0x00043FE4 File Offset: 0x000421E4
			// (set) Token: 0x06001013 RID: 4115 RVA: 0x00008C35 File Offset: 0x00006E35
			public unsafe List<AsyncOperationHandle> asyncOperations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_asyncOperations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerTrackedObject.__c__DisplayClass8_0.NativeFieldInfoPtr_asyncOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AFA RID: 2810
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000AFB RID: 2811
			private static readonly IntPtr NativeFieldInfoPtr_arraySizes;

			// Token: 0x04000AFC RID: 2812
			private static readonly IntPtr NativeFieldInfoPtr_jsonObject;

			// Token: 0x04000AFD RID: 2813
			private static readonly IntPtr NativeFieldInfoPtr_variantLocale;

			// Token: 0x04000AFE RID: 2814
			private static readonly IntPtr NativeFieldInfoPtr_defaultLocaleIdentifier;

			// Token: 0x04000AFF RID: 2815
			private static readonly IntPtr NativeFieldInfoPtr_asyncOperations;

			// Token: 0x04000B00 RID: 2816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000B01 RID: 2817
			private static readonly IntPtr NativeMethodInfoPtr__ApplyLocale_b__0_Internal_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;
		}
	}
}
