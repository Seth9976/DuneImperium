using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes
{
	// Token: 0x02000014 RID: 20
	public class TextBundleImageData : VersionedDataComponent
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00006100 File Offset: 0x00004300
		// Note: this type is marked as 'beforefieldinit'.
		static TextBundleImageData()
		{
			Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "TextBundleImageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr);
			TextBundleImageData.NativeFieldInfoPtr_imageToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, "imageToken");
			TextBundleImageData.NativeFieldInfoPtr_imageLocalizedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, "imageLocalizedText");
			TextBundleImageData.NativeMethodInfoPtr_get_ImageToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, 100663413);
			TextBundleImageData.NativeMethodInfoPtr_set_ImageToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, 100663414);
			TextBundleImageData.NativeMethodInfoPtr_get_ImageLocalizedText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, 100663415);
			TextBundleImageData.NativeMethodInfoPtr_set_ImageLocalizedText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, 100663416);
			TextBundleImageData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, 100663417);
			TextBundleImageData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr, 100663418);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000061D0 File Offset: 0x000043D0
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00006208 File Offset: 0x00004408
		public unsafe string ImageToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundleImageData.NativeMethodInfoPtr_get_ImageToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234912, RefRangeEnd = 1234913, XrefRangeStart = 1234909, XrefRangeEnd = 1234912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundleImageData.NativeMethodInfoPtr_set_ImageToken_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000624C File Offset: 0x0000444C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00006284 File Offset: 0x00004484
		public unsafe string ImageLocalizedText
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundleImageData.NativeMethodInfoPtr_get_ImageLocalizedText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1234916, RefRangeEnd = 1234917, XrefRangeStart = 1234913, XrefRangeEnd = 1234916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundleImageData.NativeMethodInfoPtr_set_ImageLocalizedText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000062C8 File Offset: 0x000044C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 514302, RefRangeEnd = 514309, XrefRangeStart = 514302, XrefRangeEnd = 514309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextBundleImageData(string token, string localizedText)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextBundleImageData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localizedText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextBundleImageData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006328 File Offset: 0x00004528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234917, XrefRangeEnd = 1234933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextBundleImageData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002704 File Offset: 0x00000904
		public TextBundleImageData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000636C File Offset: 0x0000456C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000270D File Offset: 0x0000090D
		public unsafe string imageToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundleImageData.NativeFieldInfoPtr_imageToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundleImageData.NativeFieldInfoPtr_imageToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006394 File Offset: 0x00004594
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe string imageLocalizedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundleImageData.NativeFieldInfoPtr_imageLocalizedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextBundleImageData.NativeFieldInfoPtr_imageLocalizedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_imageToken;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_imageLocalizedText;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageToken_Public_get_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageToken_Public_set_Void_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageLocalizedText_Public_get_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageLocalizedText_Public_set_Void_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
