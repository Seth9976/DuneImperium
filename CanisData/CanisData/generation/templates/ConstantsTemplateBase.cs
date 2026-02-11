using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.CodeDom.Compiler;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace CanisData.generation.templates
{
	// Token: 0x02000022 RID: 34
	public class ConstantsTemplateBase : Object
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00007CDC File Offset: 0x00005EDC
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantsTemplateBase()
		{
			Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.templates", "ConstantsTemplateBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr);
			ConstantsTemplateBase.NativeFieldInfoPtr_generationEnvironmentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "generationEnvironmentField");
			ConstantsTemplateBase.NativeFieldInfoPtr_errorsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "errorsField");
			ConstantsTemplateBase.NativeFieldInfoPtr_indentLengthsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "indentLengthsField");
			ConstantsTemplateBase.NativeFieldInfoPtr_currentIndentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "currentIndentField");
			ConstantsTemplateBase.NativeFieldInfoPtr_endsWithNewline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "endsWithNewline");
			ConstantsTemplateBase.NativeFieldInfoPtr_sessionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "sessionField");
			ConstantsTemplateBase.NativeFieldInfoPtr_toStringHelperField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "toStringHelperField");
			ConstantsTemplateBase.NativeMethodInfoPtr_get_GenerationEnvironment_Protected_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663441);
			ConstantsTemplateBase.NativeMethodInfoPtr_set_GenerationEnvironment_Protected_set_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663442);
			ConstantsTemplateBase.NativeMethodInfoPtr_get_Errors_Public_get_CompilerErrorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663443);
			ConstantsTemplateBase.NativeMethodInfoPtr_get_indentLengths_Private_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663444);
			ConstantsTemplateBase.NativeMethodInfoPtr_get_CurrentIndent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663445);
			ConstantsTemplateBase.NativeMethodInfoPtr_get_Session_Public_Virtual_New_get_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663446);
			ConstantsTemplateBase.NativeMethodInfoPtr_set_Session_Public_Virtual_New_set_Void_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663447);
			ConstantsTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663448);
			ConstantsTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663449);
			ConstantsTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663450);
			ConstantsTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663451);
			ConstantsTemplateBase.NativeMethodInfoPtr_Error_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663452);
			ConstantsTemplateBase.NativeMethodInfoPtr_Warning_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663453);
			ConstantsTemplateBase.NativeMethodInfoPtr_PushIndent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663454);
			ConstantsTemplateBase.NativeMethodInfoPtr_PopIndent_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663455);
			ConstantsTemplateBase.NativeMethodInfoPtr_ClearIndent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663456);
			ConstantsTemplateBase.NativeMethodInfoPtr_get_ToStringHelper_Public_get_ToStringInstanceHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663457);
			ConstantsTemplateBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, 100663458);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00007F00 File Offset: 0x00006100
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00007F40 File Offset: 0x00006140
		public unsafe StringBuilder GenerationEnvironment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1224176, RefRangeEnd = 1224179, XrefRangeStart = 1224171, XrefRangeEnd = 1224176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_get_GenerationEnvironment_Protected_get_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_set_GenerationEnvironment_Protected_set_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00007F84 File Offset: 0x00006184
		public unsafe CompilerErrorCollection Errors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224179, XrefRangeEnd = 1224184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_get_Errors_Public_get_CompilerErrorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompilerErrorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00007FC4 File Offset: 0x000061C4
		public unsafe List<int> indentLengths
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1224191, RefRangeEnd = 1224198, XrefRangeStart = 1224184, XrefRangeEnd = 1224191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_get_indentLengths_Private_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00008004 File Offset: 0x00006204
		public unsafe string CurrentIndent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_get_CurrentIndent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000803C File Offset: 0x0000623C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00008088 File Offset: 0x00006288
		public unsafe virtual IDictionary<string, Object> Session
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsTemplateBase.NativeMethodInfoPtr_get_Session_Public_Virtual_New_get_IDictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsTemplateBase.NativeMethodInfoPtr_set_Session_Public_Virtual_New_set_Void_IDictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000080D8 File Offset: 0x000062D8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1224211, RefRangeEnd = 1224239, XrefRangeStart = 1224198, XrefRangeEnd = 1224211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(string textToAppend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToAppend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000811C File Offset: 0x0000631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224239, XrefRangeEnd = 1224246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLine(string textToAppend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToAppend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008160 File Offset: 0x00006360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224246, XrefRangeEnd = 1224252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(string format, [Optional] Il2CppReferenceArray<Object> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000081C4 File Offset: 0x000063C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224252, XrefRangeEnd = 1224264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLine(string format, [Optional] Il2CppReferenceArray<Object> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008228 File Offset: 0x00006428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224264, XrefRangeEnd = 1224276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Error(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_Error_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000826C File Offset: 0x0000646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224276, XrefRangeEnd = 1224289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warning(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_Warning_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000082B0 File Offset: 0x000064B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224289, XrefRangeEnd = 1224295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushIndent(string indent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(indent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_PushIndent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000082F4 File Offset: 0x000064F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224295, XrefRangeEnd = 1224312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PopIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_PopIndent_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000832C File Offset: 0x0000652C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224312, XrefRangeEnd = 1224319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_ClearIndent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00008360 File Offset: 0x00006560
		public unsafe ConstantsTemplateBase.ToStringInstanceHelper ToStringHelper
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr_get_ToStringHelper_Public_get_ToStringInstanceHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantsTemplateBase.ToStringInstanceHelper>(intPtr3) : null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000083A0 File Offset: 0x000065A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224319, XrefRangeEnd = 1224334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantsTemplateBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002955 File Offset: 0x00000B55
		public void Write(string format, params Object[] args)
		{
			this.Write(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002964 File Offset: 0x00000B64
		public void WriteLine(string format, params Object[] args)
		{
			this.WriteLine(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002973 File Offset: 0x00000B73
		public ConstantsTemplateBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000083DC File Offset: 0x000065DC
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000297C File Offset: 0x00000B7C
		public unsafe StringBuilder generationEnvironmentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_generationEnvironmentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_generationEnvironmentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000840C File Offset: 0x0000660C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000299B File Offset: 0x00000B9B
		public unsafe CompilerErrorCollection errorsField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_errorsField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompilerErrorCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_errorsField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000843C File Offset: 0x0000663C
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000029BA File Offset: 0x00000BBA
		public unsafe List<int> indentLengthsField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_indentLengthsField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_indentLengthsField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000846C File Offset: 0x0000666C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000029D9 File Offset: 0x00000BD9
		public unsafe string currentIndentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_currentIndentField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_currentIndentField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00008494 File Offset: 0x00006694
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe bool endsWithNewline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_endsWithNewline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_endsWithNewline)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000084BC File Offset: 0x000066BC
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe IDictionary<string, Object> sessionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_sessionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_sessionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000084EC File Offset: 0x000066EC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002A32 File Offset: 0x00000C32
		public unsafe ConstantsTemplateBase.ToStringInstanceHelper toStringHelperField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_toStringHelperField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantsTemplateBase.ToStringInstanceHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.NativeFieldInfoPtr_toStringHelperField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_generationEnvironmentField;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_errorsField;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_indentLengthsField;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_currentIndentField;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_endsWithNewline;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_sessionField;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_toStringHelperField;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_GenerationEnvironment_Protected_get_StringBuilder_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_set_GenerationEnvironment_Protected_set_Void_StringBuilder_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_get_Errors_Public_get_CompilerErrorCollection_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_indentLengths_Private_get_List_1_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentIndent_Public_get_String_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_get_Session_Public_Virtual_New_get_IDictionary_2_String_Object_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_set_Session_Public_Virtual_New_set_Void_IDictionary_2_String_Object_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_String_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Void_String_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Void_String_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_Warning_Public_Void_String_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_PushIndent_Public_Void_String_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_PopIndent_Public_String_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_ClearIndent_Public_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_get_ToStringHelper_Public_get_ToStringInstanceHelper_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000041 RID: 65
		public class ToStringInstanceHelper : Object
		{
			// Token: 0x0600029A RID: 666 RVA: 0x0000C1DC File Offset: 0x0000A3DC
			// Note: this type is marked as 'beforefieldinit'.
			static ToStringInstanceHelper()
			{
				Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstantsTemplateBase>.NativeClassPtr, "ToStringInstanceHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr);
				ConstantsTemplateBase.ToStringInstanceHelper.NativeFieldInfoPtr_formatProviderField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr, "formatProviderField");
				ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_get_FormatProvider_Public_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663459);
				ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_set_FormatProvider_Public_set_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663460);
				ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_ToStringWithCulture_Public_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663461);
				ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663462);
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x0600029B RID: 667 RVA: 0x0000C26C File Offset: 0x0000A46C
			// (set) Token: 0x0600029C RID: 668 RVA: 0x0000C2AC File Offset: 0x0000A4AC
			public unsafe IFormatProvider FormatProvider
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_get_FormatProvider_Public_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224135, XrefRangeEnd = 1224136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_set_FormatProvider_Public_set_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600029D RID: 669 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1224160, RefRangeEnd = 1224165, XrefRangeStart = 1224136, XrefRangeEnd = 1224160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ToStringWithCulture(Object objectToConvert)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectToConvert);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_ToStringWithCulture_Public_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600029E RID: 670 RVA: 0x0000C338 File Offset: 0x0000A538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224165, XrefRangeEnd = 1224171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToStringInstanceHelper()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsTemplateBase.ToStringInstanceHelper>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029F RID: 671 RVA: 0x00003672 File Offset: 0x00001872
			public ToStringInstanceHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000C374 File Offset: 0x0000A574
			// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000367B File Offset: 0x0000187B
			public unsafe IFormatProvider formatProviderField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.ToStringInstanceHelper.NativeFieldInfoPtr_formatProviderField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplateBase.ToStringInstanceHelper.NativeFieldInfoPtr_formatProviderField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400017F RID: 383
			private static readonly IntPtr NativeFieldInfoPtr_formatProviderField;

			// Token: 0x04000180 RID: 384
			private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_get_IFormatProvider_0;

			// Token: 0x04000181 RID: 385
			private static readonly IntPtr NativeMethodInfoPtr_set_FormatProvider_Public_set_Void_IFormatProvider_0;

			// Token: 0x04000182 RID: 386
			private static readonly IntPtr NativeMethodInfoPtr_ToStringWithCulture_Public_String_Object_0;

			// Token: 0x04000183 RID: 387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
