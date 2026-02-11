using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace InControl.Internal
{
	// Token: 0x02000075 RID: 117
	public class CodeWriter : Object
	{
		// Token: 0x06000ACA RID: 2762 RVA: 0x0002ED44 File Offset: 0x0002CF44
		// Note: this type is marked as 'beforefieldinit'.
		static CodeWriter()
		{
			Il2CppClassPointerStore<CodeWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.Internal", "CodeWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr);
			CodeWriter.NativeFieldInfoPtr_newLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, "newLine");
			CodeWriter.NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, "indent");
			CodeWriter.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, "stringBuilder");
			CodeWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664782);
			CodeWriter.NativeMethodInfoPtr_IncreaseIndent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664783);
			CodeWriter.NativeMethodInfoPtr_DecreaseIndent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664784);
			CodeWriter.NativeMethodInfoPtr_Append_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664785);
			CodeWriter.NativeMethodInfoPtr_Append_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664786);
			CodeWriter.NativeMethodInfoPtr_AppendLine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664787);
			CodeWriter.NativeMethodInfoPtr_AppendLine_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664788);
			CodeWriter.NativeMethodInfoPtr_AppendFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664789);
			CodeWriter.NativeMethodInfoPtr_AppendLineFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664790);
			CodeWriter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr, 100664791);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0002EE78 File Offset: 0x0002D078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792120, XrefRangeEnd = 792126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodeWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334680, RefRangeEnd = 334682, XrefRangeStart = 334680, XrefRangeEnd = 334682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_IncreaseIndent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334682, RefRangeEnd = 334686, XrefRangeStart = 334682, XrefRangeEnd = 334686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecreaseIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_DecreaseIndent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0002EF1C File Offset: 0x0002D11C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 792144, RefRangeEnd = 792147, XrefRangeStart = 792126, XrefRangeEnd = 792144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_Append_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0002EF60 File Offset: 0x0002D160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792147, XrefRangeEnd = 792166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(bool trim, string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trim;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_Append_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792166, XrefRangeEnd = 792169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendLine(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_AppendLine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792169, XrefRangeEnd = 792171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendLine(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_AppendLine_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0002F034 File Offset: 0x0002D234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792171, XrefRangeEnd = 792173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_AppendFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0002F098 File Offset: 0x0002D298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792173, XrefRangeEnd = 792177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendLineFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeWriter.NativeMethodInfoPtr_AppendLineFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792177, XrefRangeEnd = 792178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CodeWriter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000604E File Offset: 0x0000424E
		public void AppendFormat(string format, params Object[] args)
		{
			this.AppendFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0000605D File Offset: 0x0000425D
		public void AppendLineFormat(string format, params Object[] args)
		{
			this.AppendLineFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000606C File Offset: 0x0000426C
		public CodeWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002F140 File Offset: 0x0002D340
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00006075 File Offset: 0x00004275
		public unsafe static char newLine
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(CodeWriter.NativeFieldInfoPtr_newLine, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CodeWriter.NativeFieldInfoPtr_newLine, (void*)(&value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002F15C File Offset: 0x0002D35C
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00006083 File Offset: 0x00004283
		public unsafe int indent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodeWriter.NativeFieldInfoPtr_indent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodeWriter.NativeFieldInfoPtr_indent)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002F184 File Offset: 0x0002D384
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0000609E File Offset: 0x0000429E
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodeWriter.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CodeWriter.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr_newLine;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_indent;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseIndent_Public_Void_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_DecreaseIndent_Public_Void_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_String_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Boolean_String_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_AppendLine_Public_Void_String_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_AppendLine_Public_Void_Int32_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_AppendFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_AppendLineFormat_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
