using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Core.Output
{
	// Token: 0x02000082 RID: 130
	public class TextWriterOutput : Object
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x00020990 File Offset: 0x0001EB90
		// Note: this type is marked as 'beforefieldinit'.
		static TextWriterOutput()
		{
			Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Output", "TextWriterOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr);
			TextWriterOutput.NativeFieldInfoPtr__Output_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr, "<Output>k__BackingField");
			TextWriterOutput.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr, 100664443);
			TextWriterOutput.NativeMethodInfoPtr_get_Output_Public_get_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr, 100664444);
			TextWriterOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr, 100664445);
			TextWriterOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr, 100664446);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00020A24 File Offset: 0x0001EC24
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriterOutput(TextWriter output)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriterOutput>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriterOutput.NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00020A70 File Offset: 0x0001EC70
		public unsafe TextWriter Output
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriterOutput.NativeMethodInfoPtr_get_Output_Public_get_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074181, XrefRangeEnd = 1074182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string text, IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriterOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00020B04 File Offset: 0x0001ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074182, XrefRangeEnd = 1074184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriterOutput.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000045F5 File Offset: 0x000027F5
		public TextWriterOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00020B78 File Offset: 0x0001ED78
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x000045FE File Offset: 0x000027FE
		public unsafe TextWriter _Output_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriterOutput.NativeFieldInfoPtr__Output_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriterOutput.NativeFieldInfoPtr__Output_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr__Output_k__BackingField;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextWriter_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_get_Output_Public_get_TextWriter_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_IFormattingInfo_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_String_Int32_Int32_IFormattingInfo_0;
	}
}
