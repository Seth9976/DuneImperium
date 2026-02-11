using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000D RID: 13
	public sealed class LinkInfo : ValueType
	{
		// Token: 0x0600015A RID: 346 RVA: 0x0000B134 File Offset: 0x00009334
		// Note: this type is marked as 'beforefieldinit'.
		static LinkInfo()
		{
			Il2CppClassPointerStore<LinkInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "LinkInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr);
			LinkInfo.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "hashCode");
			LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkIdFirstCharacterIndex");
			LinkInfo.NativeFieldInfoPtr_linkIdLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkIdLength");
			LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkTextfirstCharacterIndex");
			LinkInfo.NativeFieldInfoPtr_linkTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkTextLength");
			LinkInfo.NativeFieldInfoPtr_linkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkId");
			LinkInfo.NativeFieldInfoPtr_m_LinkIdString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "m_LinkIdString");
			LinkInfo.NativeFieldInfoPtr_m_LinkTextString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "m_LinkTextString");
			LinkInfo.NativeMethodInfoPtr_SetLinkId_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, 100663444);
			LinkInfo.NativeMethodInfoPtr_GetLinkText_Public_String_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, 100663445);
			LinkInfo.NativeMethodInfoPtr_GetLinkId_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, 100663446);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000B240 File Offset: 0x00009440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100122, XrefRangeEnd = 1100130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLinkId(Il2CppStructArray<char> text, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInfo.NativeMethodInfoPtr_SetLinkId_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000B2A4 File Offset: 0x000094A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1100137, RefRangeEnd = 1100141, XrefRangeStart = 1100130, XrefRangeEnd = 1100137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLinkText(TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInfo.NativeMethodInfoPtr_GetLinkText_Public_String_TextInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000B2F4 File Offset: 0x000094F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1100144, RefRangeEnd = 1100149, XrefRangeStart = 1100141, XrefRangeEnd = 1100144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLinkId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkInfo.NativeMethodInfoPtr_GetLinkId_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002A71 File Offset: 0x00000C71
		public LinkInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002A7A File Offset: 0x00000C7A
		public LinkInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000B330 File Offset: 0x00009530
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002A8C File Offset: 0x00000C8C
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000B358 File Offset: 0x00009558
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public unsafe int linkIdFirstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkIdFirstCharacterIndex)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000B380 File Offset: 0x00009580
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002AC2 File Offset: 0x00000CC2
		public unsafe int linkIdLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkIdLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkIdLength)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000B3A8 File Offset: 0x000095A8
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002ADD File Offset: 0x00000CDD
		public unsafe int linkTextfirstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkTextfirstCharacterIndex)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000B3D0 File Offset: 0x000095D0
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public unsafe int linkTextLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkTextLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkTextLength)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000B3F8 File Offset: 0x000095F8
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002B13 File Offset: 0x00000D13
		public unsafe Il2CppStructArray<char> linkId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_linkId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000B428 File Offset: 0x00009628
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002B32 File Offset: 0x00000D32
		public unsafe string m_LinkIdString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_m_LinkIdString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_m_LinkIdString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000B450 File Offset: 0x00009650
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002B51 File Offset: 0x00000D51
		public unsafe string m_LinkTextString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_m_LinkTextString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkInfo.NativeFieldInfoPtr_m_LinkTextString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_linkIdFirstCharacterIndex;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_linkIdLength;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_linkTextfirstCharacterIndex;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_linkTextLength;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_linkId;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_m_LinkIdString;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_m_LinkTextString;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_SetLinkId_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkText_Public_String_TextInfo_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_GetLinkId_Public_String_0;
	}
}
