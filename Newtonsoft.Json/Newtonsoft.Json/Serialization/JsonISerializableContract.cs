using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008B RID: 139
	public class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x06000B6C RID: 2924 RVA: 0x00046204 File Offset: 0x00044404
		// Note: this type is marked as 'beforefieldinit'.
		static JsonISerializableContract()
		{
			Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonISerializableContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr);
			JsonISerializableContract.NativeFieldInfoPtr__ISerializableCreator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr, "<ISerializableCreator>k__BackingField");
			JsonISerializableContract.NativeMethodInfoPtr_get_ISerializableCreator_Public_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr, 100665409);
			JsonISerializableContract.NativeMethodInfoPtr_set_ISerializableCreator_Public_set_Void_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr, 100665410);
			JsonISerializableContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr, 100665411);
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00046284 File Offset: 0x00044484
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x000462C4 File Offset: 0x000444C4
		public unsafe ObjectConstructor<Object> ISerializableCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonISerializableContract.NativeMethodInfoPtr_get_ISerializableCreator_Public_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonISerializableContract.NativeMethodInfoPtr_set_ISerializableCreator_Public_set_Void_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00046308 File Offset: 0x00044508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749907, XrefRangeEnd = 749908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonISerializableContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonISerializableContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonISerializableContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00005AC1 File Offset: 0x00003CC1
		public JsonISerializableContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00046354 File Offset: 0x00044554
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00005ACA File Offset: 0x00003CCA
		public unsafe ObjectConstructor<Object> _ISerializableCreator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonISerializableContract.NativeFieldInfoPtr__ISerializableCreator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonISerializableContract.NativeFieldInfoPtr__ISerializableCreator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr__ISerializableCreator_k__BackingField;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_get_ISerializableCreator_Public_get_ObjectConstructor_1_Object_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_set_ISerializableCreator_Public_set_Void_ObjectConstructor_1_Object_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
