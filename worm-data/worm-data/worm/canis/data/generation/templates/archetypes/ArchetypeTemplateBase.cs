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

namespace worm.canis.data.generation.templates.archetypes
{
	// Token: 0x0200000A RID: 10
	public class ArchetypeTemplateBase : Object
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00003364 File Offset: 0x00001564
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeTemplateBase()
		{
			Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data.generation.templates.archetypes", "ArchetypeTemplateBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr);
			ArchetypeTemplateBase.NativeFieldInfoPtr_generationEnvironmentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "generationEnvironmentField");
			ArchetypeTemplateBase.NativeFieldInfoPtr_errorsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "errorsField");
			ArchetypeTemplateBase.NativeFieldInfoPtr_indentLengthsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "indentLengthsField");
			ArchetypeTemplateBase.NativeFieldInfoPtr_currentIndentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "currentIndentField");
			ArchetypeTemplateBase.NativeFieldInfoPtr_endsWithNewline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "endsWithNewline");
			ArchetypeTemplateBase.NativeFieldInfoPtr_sessionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "sessionField");
			ArchetypeTemplateBase.NativeFieldInfoPtr_toStringHelperField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "toStringHelperField");
			ArchetypeTemplateBase.NativeMethodInfoPtr_get_GenerationEnvironment_Protected_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663339);
			ArchetypeTemplateBase.NativeMethodInfoPtr_set_GenerationEnvironment_Protected_set_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663340);
			ArchetypeTemplateBase.NativeMethodInfoPtr_get_Errors_Public_get_CompilerErrorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663341);
			ArchetypeTemplateBase.NativeMethodInfoPtr_get_indentLengths_Private_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663342);
			ArchetypeTemplateBase.NativeMethodInfoPtr_get_CurrentIndent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663343);
			ArchetypeTemplateBase.NativeMethodInfoPtr_get_Session_Public_Virtual_New_get_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663344);
			ArchetypeTemplateBase.NativeMethodInfoPtr_set_Session_Public_Virtual_New_set_Void_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663345);
			ArchetypeTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663346);
			ArchetypeTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663347);
			ArchetypeTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663348);
			ArchetypeTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663349);
			ArchetypeTemplateBase.NativeMethodInfoPtr_Error_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663350);
			ArchetypeTemplateBase.NativeMethodInfoPtr_Warning_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663351);
			ArchetypeTemplateBase.NativeMethodInfoPtr_PushIndent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663352);
			ArchetypeTemplateBase.NativeMethodInfoPtr_PopIndent_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663353);
			ArchetypeTemplateBase.NativeMethodInfoPtr_ClearIndent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663354);
			ArchetypeTemplateBase.NativeMethodInfoPtr_get_ToStringHelper_Public_get_ToStringInstanceHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663355);
			ArchetypeTemplateBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, 100663356);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000035C8 File Offset: 0x000017C8
		public unsafe StringBuilder GenerationEnvironment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1246367, RefRangeEnd = 1246370, XrefRangeStart = 1246362, XrefRangeEnd = 1246367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_get_GenerationEnvironment_Protected_get_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_set_GenerationEnvironment_Protected_set_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000360C File Offset: 0x0000180C
		public unsafe CompilerErrorCollection Errors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246370, XrefRangeEnd = 1246375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_get_Errors_Public_get_CompilerErrorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompilerErrorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000364C File Offset: 0x0000184C
		public unsafe List<int> indentLengths
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1246382, RefRangeEnd = 1246389, XrefRangeStart = 1246375, XrefRangeEnd = 1246382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_get_indentLengths_Private_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000368C File Offset: 0x0000188C
		public unsafe string CurrentIndent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_get_CurrentIndent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00003710 File Offset: 0x00001910
		public unsafe virtual IDictionary<string, Object> Session
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeTemplateBase.NativeMethodInfoPtr_get_Session_Public_Virtual_New_get_IDictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeTemplateBase.NativeMethodInfoPtr_set_Session_Public_Virtual_New_set_Void_IDictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003760 File Offset: 0x00001960
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1246402, RefRangeEnd = 1246424, XrefRangeStart = 1246389, XrefRangeEnd = 1246402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(string textToAppend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToAppend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000037A4 File Offset: 0x000019A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246424, XrefRangeEnd = 1246431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLine(string textToAppend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToAppend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000037E8 File Offset: 0x000019E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246431, XrefRangeEnd = 1246437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_Write_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000384C File Offset: 0x00001A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246437, XrefRangeEnd = 1246449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_WriteLine_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000038B0 File Offset: 0x00001AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246449, XrefRangeEnd = 1246461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Error(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_Error_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000038F4 File Offset: 0x00001AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246461, XrefRangeEnd = 1246474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warning(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_Warning_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003938 File Offset: 0x00001B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246474, XrefRangeEnd = 1246480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushIndent(string indent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(indent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_PushIndent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000397C File Offset: 0x00001B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246480, XrefRangeEnd = 1246497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PopIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_PopIndent_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000039B4 File Offset: 0x00001BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246497, XrefRangeEnd = 1246504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_ClearIndent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000039E8 File Offset: 0x00001BE8
		public unsafe ArchetypeTemplateBase.ToStringInstanceHelper ToStringHelper
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr_get_ToStringHelper_Public_get_ToStringInstanceHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeTemplateBase.ToStringInstanceHelper>(intPtr3) : null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003A28 File Offset: 0x00001C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246504, XrefRangeEnd = 1246519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeTemplateBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000021A6 File Offset: 0x000003A6
		public void Write(string format, params Object[] args)
		{
			this.Write(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000021B5 File Offset: 0x000003B5
		public void WriteLine(string format, params Object[] args)
		{
			this.WriteLine(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000021C4 File Offset: 0x000003C4
		public ArchetypeTemplateBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003A64 File Offset: 0x00001C64
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021CD File Offset: 0x000003CD
		public unsafe StringBuilder generationEnvironmentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_generationEnvironmentField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_generationEnvironmentField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003A94 File Offset: 0x00001C94
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000021EC File Offset: 0x000003EC
		public unsafe CompilerErrorCollection errorsField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_errorsField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompilerErrorCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_errorsField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003AC4 File Offset: 0x00001CC4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000220B File Offset: 0x0000040B
		public unsafe List<int> indentLengthsField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_indentLengthsField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_indentLengthsField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000222A File Offset: 0x0000042A
		public unsafe string currentIndentField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_currentIndentField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_currentIndentField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003B1C File Offset: 0x00001D1C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002249 File Offset: 0x00000449
		public unsafe bool endsWithNewline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_endsWithNewline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_endsWithNewline)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003B44 File Offset: 0x00001D44
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002264 File Offset: 0x00000464
		public unsafe IDictionary<string, Object> sessionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_sessionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_sessionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003B74 File Offset: 0x00001D74
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002283 File Offset: 0x00000483
		public unsafe ArchetypeTemplateBase.ToStringInstanceHelper toStringHelperField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_toStringHelperField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeTemplateBase.ToStringInstanceHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.NativeFieldInfoPtr_toStringHelperField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_generationEnvironmentField;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_errorsField;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_indentLengthsField;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_currentIndentField;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_endsWithNewline;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_sessionField;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_toStringHelperField;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_GenerationEnvironment_Protected_get_StringBuilder_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_GenerationEnvironment_Protected_set_Void_StringBuilder_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_Errors_Public_get_CompilerErrorCollection_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_indentLengths_Private_get_List_1_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentIndent_Public_get_String_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_Session_Public_Virtual_New_get_IDictionary_2_String_Object_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_set_Session_Public_Virtual_New_set_Void_IDictionary_2_String_Object_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Void_String_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Error_Public_Void_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Warning_Public_Void_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_PushIndent_Public_Void_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_PopIndent_Public_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_ClearIndent_Public_Void_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_ToStringHelper_Public_get_ToStringInstanceHelper_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000013 RID: 19
		public class ToStringInstanceHelper : Object
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x00004A88 File Offset: 0x00002C88
			// Note: this type is marked as 'beforefieldinit'.
			static ToStringInstanceHelper()
			{
				Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeTemplateBase>.NativeClassPtr, "ToStringInstanceHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr);
				ArchetypeTemplateBase.ToStringInstanceHelper.NativeFieldInfoPtr_formatProviderField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr, "formatProviderField");
				ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_get_FormatProvider_Public_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663357);
				ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_set_FormatProvider_Public_set_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663358);
				ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_ToStringWithCulture_Public_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663359);
				ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr, 100663360);
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004B18 File Offset: 0x00002D18
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00004B58 File Offset: 0x00002D58
			public unsafe IFormatProvider FormatProvider
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_get_FormatProvider_Public_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_set_FormatProvider_Public_set_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00004B9C File Offset: 0x00002D9C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1246349, RefRangeEnd = 1246356, XrefRangeStart = 1246325, XrefRangeEnd = 1246349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ToStringWithCulture(Object objectToConvert)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectToConvert);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr_ToStringWithCulture_Public_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00004BE4 File Offset: 0x00002DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246356, XrefRangeEnd = 1246362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToStringInstanceHelper()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeTemplateBase.ToStringInstanceHelper>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplateBase.ToStringInstanceHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00002520 File Offset: 0x00000720
			public ToStringInstanceHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00004C20 File Offset: 0x00002E20
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00002529 File Offset: 0x00000729
			public unsafe IFormatProvider formatProviderField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.ToStringInstanceHelper.NativeFieldInfoPtr_formatProviderField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplateBase.ToStringInstanceHelper.NativeFieldInfoPtr_formatProviderField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeFieldInfoPtr_formatProviderField;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_get_IFormatProvider_0;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeMethodInfoPtr_set_FormatProvider_Public_set_Void_IFormatProvider_0;

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeMethodInfoPtr_ToStringWithCulture_Public_String_Object_0;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
