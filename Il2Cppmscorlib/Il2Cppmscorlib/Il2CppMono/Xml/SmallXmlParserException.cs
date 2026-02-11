using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Xml
{
	// Token: 0x0200001D RID: 29
	public class SmallXmlParserException : SystemException
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00028CB0 File Offset: 0x00026EB0
		// Note: this type is marked as 'beforefieldinit'.
		static SmallXmlParserException()
		{
			Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SmallXmlParserException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr);
			SmallXmlParserException.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr, "line");
			SmallXmlParserException.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr, "column");
			SmallXmlParserException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr, 100663483);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00028D1C File Offset: 0x00026F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276431, XrefRangeEnd = 1276440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmallXmlParserException(string msg, int line, int column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParserException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000254C File Offset: 0x0000074C
		public SmallXmlParserException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00028D84 File Offset: 0x00026F84
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002555 File Offset: 0x00000755
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00028DAC File Offset: 0x00026FAC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002570 File Offset: 0x00000770
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
	}
}
