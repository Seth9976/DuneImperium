using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.localization
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class LocalizableText : Object
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00006C20 File Offset: 0x00004E20
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizableText()
		{
			Il2CppClassPointerStore<LocalizableText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.localization", "LocalizableText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr);
			LocalizableText.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, "Empty");
			LocalizableText.NativeFieldInfoPtr_trimChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, "trimChars");
			LocalizableText.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, "ID");
			LocalizableText.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, 100663387);
			LocalizableText.NativeMethodInfoPtr_get_DisplayText_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, 100663388);
			LocalizableText.NativeMethodInfoPtr_HasId_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, 100663389);
			LocalizableText.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, 100663390);
			LocalizableText.NativeMethodInfoPtr_TryLocalize_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, 100663391);
			LocalizableText.NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr, 100663392);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006D04 File Offset: 0x00004F04
		[CallerCount(632)]
		[CachedScanResults(RefRangeStart = 1177001, RefRangeEnd = 1177633, XrefRangeStart = 1176988, XrefRangeEnd = 1177001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizableText(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizableText>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableText.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00006D50 File Offset: 0x00004F50
		public unsafe virtual string DisplayText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177633, XrefRangeEnd = 1177637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizableText.NativeMethodInfoPtr_get_DisplayText_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006D94 File Offset: 0x00004F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177637, XrefRangeEnd = 1177640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasId(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableText.NativeMethodInfoPtr_HasId_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006DE4 File Offset: 0x00004FE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizableText.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006E28 File Offset: 0x00005028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177640, XrefRangeEnd = 1177653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string TryLocalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizableText.NativeMethodInfoPtr_TryLocalize_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006E6C File Offset: 0x0000506C
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 1177653, RefRangeEnd = 1177728, XrefRangeStart = 1177653, XrefRangeEnd = 1177653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(LocalizableText text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizableText.NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizableText_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002313 File Offset: 0x00000513
		public LocalizableText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006EA8 File Offset: 0x000050A8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000231C File Offset: 0x0000051C
		public unsafe static LocalizableText Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizableText.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizableText.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006ED0 File Offset: 0x000050D0
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000232E File Offset: 0x0000052E
		public unsafe static Il2CppStructArray<char> trimChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizableText.NativeFieldInfoPtr_trimChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizableText.NativeFieldInfoPtr_trimChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006EF8 File Offset: 0x000050F8
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002340 File Offset: 0x00000540
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizableText.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizableText.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_trimChars;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayText_Public_Virtual_New_get_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_HasId_Public_Boolean_String_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_TryLocalize_Public_Virtual_New_String_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_LocalizableText_0;
	}
}
