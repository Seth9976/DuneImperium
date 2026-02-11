using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x0200001C RID: 28
	public sealed class JsonConverterAttribute : Attribute
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00015BC8 File Offset: 0x00013DC8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonConverterAttribute()
		{
			Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonConverterAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr);
			JsonConverterAttribute.NativeFieldInfoPtr__converterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr, "_converterType");
			JsonConverterAttribute.NativeFieldInfoPtr__ConverterParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr, "<ConverterParameters>k__BackingField");
			JsonConverterAttribute.NativeMethodInfoPtr_get_ConverterType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr, 100663438);
			JsonConverterAttribute.NativeMethodInfoPtr_get_ConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr, 100663439);
			JsonConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr, 100663440);
			JsonConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr, 100663441);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00015C70 File Offset: 0x00013E70
		public unsafe Type ConverterType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConverterAttribute.NativeMethodInfoPtr_get_ConverterType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00015CB0 File Offset: 0x00013EB0
		public unsafe Il2CppReferenceArray<Object> ConverterParameters
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConverterAttribute.NativeMethodInfoPtr_get_ConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727914, XrefRangeEnd = 727926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonConverterAttribute(Type converterType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00015D3C File Offset: 0x00013F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727926, XrefRangeEnd = 727939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonConverterAttribute(Type converterType, [Optional] Il2CppReferenceArray<Object> converterParameters)
		{
			if (converterParameters == null)
			{
				converterParameters = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonConverterAttribute>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converterParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000025B0 File Offset: 0x000007B0
		public JsonConverterAttribute(Type converterType, params Object[] converterParameters)
			: this(converterType, new Il2CppReferenceArray<Object>(converterParameters))
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000025BF File Offset: 0x000007BF
		public JsonConverterAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00015DA8 File Offset: 0x00013FA8
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000025C8 File Offset: 0x000007C8
		public unsafe Type _converterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonConverterAttribute.NativeFieldInfoPtr__converterType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonConverterAttribute.NativeFieldInfoPtr__converterType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00015DD8 File Offset: 0x00013FD8
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000025E7 File Offset: 0x000007E7
		public unsafe Il2CppReferenceArray<Object> _ConverterParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonConverterAttribute.NativeFieldInfoPtr__ConverterParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonConverterAttribute.NativeFieldInfoPtr__ConverterParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr__converterType;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr__ConverterParameters_k__BackingField;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_get_ConverterType_Public_get_Type_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_get_ConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_0;
	}
}
