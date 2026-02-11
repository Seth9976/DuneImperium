using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000020 RID: 32
	public class JsonExtensionDataAttribute : Attribute
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0001616C File Offset: 0x0001436C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonExtensionDataAttribute()
		{
			Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonExtensionDataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr);
			JsonExtensionDataAttribute.NativeFieldInfoPtr__WriteData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, "<WriteData>k__BackingField");
			JsonExtensionDataAttribute.NativeFieldInfoPtr__ReadData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, "<ReadData>k__BackingField");
			JsonExtensionDataAttribute.NativeMethodInfoPtr_get_WriteData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, 100663450);
			JsonExtensionDataAttribute.NativeMethodInfoPtr_set_WriteData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, 100663451);
			JsonExtensionDataAttribute.NativeMethodInfoPtr_get_ReadData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, 100663452);
			JsonExtensionDataAttribute.NativeMethodInfoPtr_set_ReadData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, 100663453);
			JsonExtensionDataAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr, 100663454);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00016228 File Offset: 0x00014428
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00016264 File Offset: 0x00014464
		public unsafe bool WriteData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonExtensionDataAttribute.NativeMethodInfoPtr_get_WriteData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonExtensionDataAttribute.NativeMethodInfoPtr_set_WriteData_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000162A4 File Offset: 0x000144A4
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000162E0 File Offset: 0x000144E0
		public unsafe bool ReadData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonExtensionDataAttribute.NativeMethodInfoPtr_get_ReadData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonExtensionDataAttribute.NativeMethodInfoPtr_set_ReadData_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00016320 File Offset: 0x00014520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727991, XrefRangeEnd = 727992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonExtensionDataAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonExtensionDataAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonExtensionDataAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000265A File Offset: 0x0000085A
		public JsonExtensionDataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0001635C File Offset: 0x0001455C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002663 File Offset: 0x00000863
		public unsafe bool _WriteData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonExtensionDataAttribute.NativeFieldInfoPtr__WriteData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonExtensionDataAttribute.NativeFieldInfoPtr__WriteData_k__BackingField)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00016384 File Offset: 0x00014584
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000267E File Offset: 0x0000087E
		public unsafe bool _ReadData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonExtensionDataAttribute.NativeFieldInfoPtr__ReadData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonExtensionDataAttribute.NativeFieldInfoPtr__ReadData_k__BackingField)) = value;
			}
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr__WriteData_k__BackingField;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr__ReadData_k__BackingField;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteData_Public_get_Boolean_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_set_WriteData_Public_set_Void_Boolean_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadData_Public_get_Boolean_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadData_Public_set_Void_Boolean_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
