using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x0200000A RID: 10
	public class FormUrlEncodedContent : ByteArrayContent
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00006130 File Offset: 0x00004330
		// Note: this type is marked as 'beforefieldinit'.
		static FormUrlEncodedContent()
		{
			Il2CppClassPointerStore<FormUrlEncodedContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "FormUrlEncodedContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormUrlEncodedContent>.NativeClassPtr);
			FormUrlEncodedContent.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormUrlEncodedContent>.NativeClassPtr, 100663362);
			FormUrlEncodedContent.NativeMethodInfoPtr_EncodeContent_Private_Static_Il2CppStructArray_1_Byte_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormUrlEncodedContent>.NativeClassPtr, 100663363);
			FormUrlEncodedContent.NativeMethodInfoPtr_SerializeValue_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormUrlEncodedContent>.NativeClassPtr, 100663364);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000619C File Offset: 0x0000439C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171064, RefRangeEnd = 1171065, XrefRangeStart = 1171049, XrefRangeEnd = 1171064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormUrlEncodedContent(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormUrlEncodedContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameValueCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormUrlEncodedContent.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000061E8 File Offset: 0x000043E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171106, RefRangeEnd = 1171107, XrefRangeStart = 1171065, XrefRangeEnd = 1171106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeContent(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameValueCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormUrlEncodedContent.NativeMethodInfoPtr_EncodeContent_Private_Static_Il2CppStructArray_1_Byte_IEnumerable_1_KeyValuePair_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000622C File Offset: 0x0000442C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1171117, RefRangeEnd = 1171119, XrefRangeStart = 1171107, XrefRangeEnd = 1171117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormUrlEncodedContent.NativeMethodInfoPtr_SerializeValue_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000241D File Offset: 0x0000061D
		public FormUrlEncodedContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_EncodeContent_Private_Static_Il2CppStructArray_1_Byte_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Static_Il2CppStructArray_1_Byte_String_0;
	}
}
