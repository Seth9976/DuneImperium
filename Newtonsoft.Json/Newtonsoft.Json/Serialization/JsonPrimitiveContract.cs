using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008E RID: 142
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x00046FF8 File Offset: 0x000451F8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPrimitiveContract()
		{
			Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonPrimitiveContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr);
			JsonPrimitiveContract.NativeFieldInfoPtr__TypeCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr, "<TypeCode>k__BackingField");
			JsonPrimitiveContract.NativeFieldInfoPtr_ReadTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr, "ReadTypeMap");
			JsonPrimitiveContract.NativeMethodInfoPtr_get_TypeCode_Internal_get_PrimitiveTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr, 100665438);
			JsonPrimitiveContract.NativeMethodInfoPtr_set_TypeCode_Internal_set_Void_PrimitiveTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr, 100665439);
			JsonPrimitiveContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr, 100665440);
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0004708C File Offset: 0x0004528C
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x000470C8 File Offset: 0x000452C8
		public unsafe PrimitiveTypeCode TypeCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPrimitiveContract.NativeMethodInfoPtr_get_TypeCode_Internal_get_PrimitiveTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPrimitiveContract.NativeMethodInfoPtr_set_TypeCode_Internal_set_Void_PrimitiveTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00047108 File Offset: 0x00045308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750007, RefRangeEnd = 750008, XrefRangeStart = 749995, XrefRangeEnd = 750007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPrimitiveContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPrimitiveContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPrimitiveContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00005D1A File Offset: 0x00003F1A
		public JsonPrimitiveContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00047154 File Offset: 0x00045354
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00005D23 File Offset: 0x00003F23
		public unsafe PrimitiveTypeCode _TypeCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPrimitiveContract.NativeFieldInfoPtr__TypeCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPrimitiveContract.NativeFieldInfoPtr__TypeCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0004717C File Offset: 0x0004537C
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00005D3E File Offset: 0x00003F3E
		public unsafe static Dictionary<Type, ReadType> ReadTypeMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonPrimitiveContract.NativeFieldInfoPtr_ReadTypeMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, ReadType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonPrimitiveContract.NativeFieldInfoPtr_ReadTypeMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr__TypeCode_k__BackingField;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_ReadTypeMap;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Internal_get_PrimitiveTypeCode_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeCode_Internal_set_Void_PrimitiveTypeCode_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
