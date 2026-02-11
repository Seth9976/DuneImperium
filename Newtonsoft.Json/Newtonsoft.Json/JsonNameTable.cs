using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000022 RID: 34
	public class JsonNameTable : Object
	{
		// Token: 0x06000114 RID: 276 RVA: 0x000163E8 File Offset: 0x000145E8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonNameTable()
		{
			Il2CppClassPointerStore<JsonNameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonNameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonNameTable>.NativeClassPtr);
			JsonNameTable.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonNameTable>.NativeClassPtr, 100663456);
			JsonNameTable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonNameTable>.NativeClassPtr, 100663457);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00016440 File Offset: 0x00014640
		[CallerCount(0)]
		public unsafe virtual string Get(Il2CppStructArray<char> key, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonNameTable.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000164B0 File Offset: 0x000146B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonNameTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonNameTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonNameTable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000026DB File Offset: 0x000008DB
		public JsonNameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
