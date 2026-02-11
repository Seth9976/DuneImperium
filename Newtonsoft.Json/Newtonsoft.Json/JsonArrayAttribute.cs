using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Newtonsoft.Json
{
	// Token: 0x02000016 RID: 22
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00012A00 File Offset: 0x00010C00
		// Note: this type is marked as 'beforefieldinit'.
		static JsonArrayAttribute()
		{
			Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonArrayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr);
			JsonArrayAttribute.NativeFieldInfoPtr__allowNullItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr, "_allowNullItems");
			JsonArrayAttribute.NativeMethodInfoPtr_get_AllowNullItems_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr, 100663322);
			JsonArrayAttribute.NativeMethodInfoPtr_set_AllowNullItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr, 100663323);
			JsonArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr, 100663324);
			JsonArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr, 100663325);
			JsonArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr, 100663326);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00012AA8 File Offset: 0x00010CA8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00012AE4 File Offset: 0x00010CE4
		public unsafe bool AllowNullItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayAttribute.NativeMethodInfoPtr_get_AllowNullItems_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayAttribute.NativeMethodInfoPtr_set_AllowNullItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00012B24 File Offset: 0x00010D24
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonArrayAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00012B60 File Offset: 0x00010D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726991, XrefRangeEnd = 726992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonArrayAttribute(bool allowNullItems)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowNullItems;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00012BA8 File Offset: 0x00010DA8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonArrayAttribute(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonArrayAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000022AC File Offset: 0x000004AC
		public JsonArrayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00012BF4 File Offset: 0x00010DF4
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000022B5 File Offset: 0x000004B5
		public unsafe bool _allowNullItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayAttribute.NativeFieldInfoPtr__allowNullItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonArrayAttribute.NativeFieldInfoPtr__allowNullItems)) = value;
			}
		}

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__allowNullItems;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowNullItems_Public_get_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowNullItems_Public_set_Void_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
