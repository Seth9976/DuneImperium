using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000080 RID: 128
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x00042688 File Offset: 0x00040888
		// Note: this type is marked as 'beforefieldinit'.
		static JsonArrayContract()
		{
			Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonArrayContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr);
			JsonArrayContract.NativeFieldInfoPtr__CollectionItemType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "<CollectionItemType>k__BackingField");
			JsonArrayContract.NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "<IsMultidimensionalArray>k__BackingField");
			JsonArrayContract.NativeFieldInfoPtr__genericCollectionDefinitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_genericCollectionDefinitionType");
			JsonArrayContract.NativeFieldInfoPtr__genericWrapperType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_genericWrapperType");
			JsonArrayContract.NativeFieldInfoPtr__genericWrapperCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_genericWrapperCreator");
			JsonArrayContract.NativeFieldInfoPtr__genericTemporaryCollectionCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_genericTemporaryCollectionCreator");
			JsonArrayContract.NativeFieldInfoPtr__IsArray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "<IsArray>k__BackingField");
			JsonArrayContract.NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "<ShouldCreateWrapper>k__BackingField");
			JsonArrayContract.NativeFieldInfoPtr__CanDeserialize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "<CanDeserialize>k__BackingField");
			JsonArrayContract.NativeFieldInfoPtr__parameterizedConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_parameterizedConstructor");
			JsonArrayContract.NativeFieldInfoPtr__parameterizedCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_parameterizedCreator");
			JsonArrayContract.NativeFieldInfoPtr__overrideCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "_overrideCreator");
			JsonArrayContract.NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, "<HasParameterizedCreator>k__BackingField");
			JsonArrayContract.NativeMethodInfoPtr_get_CollectionItemType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665292);
			JsonArrayContract.NativeMethodInfoPtr_get_IsMultidimensionalArray_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665293);
			JsonArrayContract.NativeMethodInfoPtr_get_IsArray_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665294);
			JsonArrayContract.NativeMethodInfoPtr_get_ShouldCreateWrapper_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665295);
			JsonArrayContract.NativeMethodInfoPtr_get_CanDeserialize_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665296);
			JsonArrayContract.NativeMethodInfoPtr_set_CanDeserialize_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665297);
			JsonArrayContract.NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665298);
			JsonArrayContract.NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665299);
			JsonArrayContract.NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665300);
			JsonArrayContract.NativeMethodInfoPtr_get_HasParameterizedCreator_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665301);
			JsonArrayContract.NativeMethodInfoPtr_set_HasParameterizedCreator_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665302);
			JsonArrayContract.NativeMethodInfoPtr_get_HasParameterizedCreatorInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665303);
			JsonArrayContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665304);
			JsonArrayContract.NativeMethodInfoPtr_CreateWrapper_Internal_IWrappedCollection_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665305);
			JsonArrayContract.NativeMethodInfoPtr_CreateTemporaryCollection_Internal_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665306);
			JsonArrayContract.NativeMethodInfoPtr_StoreFSharpListCreatorIfNecessary_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr, 100665307);
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x000428FC File Offset: 0x00040AFC
		public unsafe Type CollectionItemType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_CollectionItemType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0004293C File Offset: 0x00040B3C
		public unsafe bool IsMultidimensionalArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_IsMultidimensionalArray_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00042978 File Offset: 0x00040B78
		public unsafe bool IsArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_IsArray_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x000429B4 File Offset: 0x00040BB4
		public unsafe bool ShouldCreateWrapper
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_ShouldCreateWrapper_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000429F0 File Offset: 0x00040BF0
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00042A2C File Offset: 0x00040C2C
		public unsafe bool CanDeserialize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_CanDeserialize_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_set_CanDeserialize_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00042A6C File Offset: 0x00040C6C
		public unsafe ObjectConstructor<Object> ParameterizedCreator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748827, XrefRangeEnd = 748836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00042AAC File Offset: 0x00040CAC
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00042AEC File Offset: 0x00040CEC
		public unsafe ObjectConstructor<Object> OverrideCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748836, XrefRangeEnd = 748837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00042B30 File Offset: 0x00040D30
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00042B6C File Offset: 0x00040D6C
		public unsafe bool HasParameterizedCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_HasParameterizedCreator_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_set_HasParameterizedCreator_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00042BAC File Offset: 0x00040DAC
		public unsafe bool HasParameterizedCreatorInternal
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 748841, RefRangeEnd = 748844, XrefRangeStart = 748837, XrefRangeEnd = 748841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_get_HasParameterizedCreatorInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00042BE8 File Offset: 0x00040DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749103, RefRangeEnd = 749104, XrefRangeStart = 748844, XrefRangeEnd = 749103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonArrayContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonArrayContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00042C34 File Offset: 0x00040E34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 749156, RefRangeEnd = 749160, XrefRangeStart = 749104, XrefRangeEnd = 749156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IWrappedCollection CreateWrapper(Object list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_CreateWrapper_Internal_IWrappedCollection_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWrappedCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00042C84 File Offset: 0x00040E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749160, XrefRangeEnd = 749190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList CreateTemporaryCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_CreateTemporaryCollection_Internal_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00042CC4 File Offset: 0x00040EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 749207, RefRangeEnd = 749209, XrefRangeStart = 749190, XrefRangeEnd = 749207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreFSharpListCreatorIfNecessary(Type underlyingType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayContract.NativeMethodInfoPtr_StoreFSharpListCreatorIfNecessary_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0000528B File Offset: 0x0000348B
		public JsonArrayContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00042D08 File Offset: 0x00040F08
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00005294 File Offset: 0x00003494
		public unsafe Type _CollectionItemType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__CollectionItemType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__CollectionItemType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00042D38 File Offset: 0x00040F38
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000052B3 File Offset: 0x000034B3
		public unsafe bool _IsMultidimensionalArray_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField)) = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00042D60 File Offset: 0x00040F60
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x000052CE File Offset: 0x000034CE
		public unsafe Type _genericCollectionDefinitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericCollectionDefinitionType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericCollectionDefinitionType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00042D90 File Offset: 0x00040F90
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000052ED File Offset: 0x000034ED
		public unsafe Type _genericWrapperType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericWrapperType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericWrapperType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00042DC0 File Offset: 0x00040FC0
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0000530C File Offset: 0x0000350C
		public unsafe ObjectConstructor<Object> _genericWrapperCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericWrapperCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericWrapperCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00042DF0 File Offset: 0x00040FF0
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0000532B File Offset: 0x0000352B
		public unsafe Func<Object> _genericTemporaryCollectionCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericTemporaryCollectionCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__genericTemporaryCollectionCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00042E20 File Offset: 0x00041020
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0000534A File Offset: 0x0000354A
		public unsafe bool _IsArray_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__IsArray_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__IsArray_k__BackingField)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00042E48 File Offset: 0x00041048
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00005365 File Offset: 0x00003565
		public unsafe bool _ShouldCreateWrapper_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00042E70 File Offset: 0x00041070
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00005380 File Offset: 0x00003580
		public unsafe bool _CanDeserialize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__CanDeserialize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__CanDeserialize_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00042E98 File Offset: 0x00041098
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0000539B File Offset: 0x0000359B
		public unsafe ConstructorInfo _parameterizedConstructor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__parameterizedConstructor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__parameterizedConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00042EC8 File Offset: 0x000410C8
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000053BA File Offset: 0x000035BA
		public unsafe ObjectConstructor<Object> _parameterizedCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__parameterizedCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__parameterizedCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00042EF8 File Offset: 0x000410F8
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000053D9 File Offset: 0x000035D9
		public unsafe ObjectConstructor<Object> _overrideCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__overrideCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__overrideCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00042F28 File Offset: 0x00041128
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000053F8 File Offset: 0x000035F8
		public unsafe bool _HasParameterizedCreator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayContract.NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField)) = value;
			}
		}

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr__CollectionItemType_k__BackingField;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr__IsMultidimensionalArray_k__BackingField;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr__genericCollectionDefinitionType;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr__genericWrapperType;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr__genericWrapperCreator;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr__genericTemporaryCollectionCreator;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr__IsArray_k__BackingField;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr__CanDeserialize_k__BackingField;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr__parameterizedConstructor;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr__parameterizedCreator;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr__overrideCreator;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get_CollectionItemType_Public_get_Type_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMultidimensionalArray_Public_get_Boolean_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_get_IsArray_Internal_get_Boolean_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldCreateWrapper_Internal_get_Boolean_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDeserialize_Internal_get_Boolean_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_set_CanDeserialize_Private_set_Void_Boolean_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_get_HasParameterizedCreator_Public_get_Boolean_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_set_HasParameterizedCreator_Public_set_Void_Boolean_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_get_HasParameterizedCreatorInternal_Internal_get_Boolean_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_CreateWrapper_Internal_IWrappedCollection_Object_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryCollection_Internal_IList_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_StoreFSharpListCreatorIfNecessary_Private_Void_Type_0;
	}
}
