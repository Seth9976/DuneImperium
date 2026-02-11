using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace CanisData.generation.generators
{
	// Token: 0x02000025 RID: 37
	public class ConstantsScriptGenerator : ScriptGenerator
	{
		// Token: 0x06000154 RID: 340 RVA: 0x000088C4 File Offset: 0x00006AC4
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantsScriptGenerator()
		{
			Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.generators", "ConstantsScriptGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr);
			ConstantsScriptGenerator.NativeFieldInfoPtr_projectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, "projectName");
			ConstantsScriptGenerator.NativeFieldInfoPtr_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, "setName");
			ConstantsScriptGenerator.NativeFieldInfoPtr_directive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, "directive");
			ConstantsScriptGenerator.NativeFieldInfoPtr_constantDefinitionBuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, "constantDefinitionBuilders");
			ConstantsScriptGenerator.NativeFieldInfoPtr_rowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, "rowData");
			ConstantsScriptGenerator.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, 100663469);
			ConstantsScriptGenerator.NativeMethodInfoPtr_SetRowData_Public_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, 100663470);
			ConstantsScriptGenerator.NativeMethodInfoPtr_ParseConstant_Private_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, 100663471);
			ConstantsScriptGenerator.NativeMethodInfoPtr_MakeBuilder_Public_Virtual_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, 100663472);
			ConstantsScriptGenerator.NativeMethodInfoPtr_Generate_Public_Virtual_ParserArtifact_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr, 100663473);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000089BC File Offset: 0x00006BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224334, XrefRangeEnd = 1224355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantsScriptGenerator(string setName, string projectName, string directive = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsScriptGenerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(setName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(projectName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directive);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptGenerator.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008A2C File Offset: 0x00006C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRowData(Dictionary<string, string> rowData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rowData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptGenerator.NativeMethodInfoPtr_SetRowData_Public_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008A70 File Offset: 0x00006C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1224389, RefRangeEnd = 1224390, XrefRangeStart = 1224355, XrefRangeEnd = 1224389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantsScriptBuilder.ConstantDefinitionBuilder ParseConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptGenerator.NativeMethodInfoPtr_ParseConstant_Private_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantsScriptBuilder.ConstantDefinitionBuilder>(intPtr3) : null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008AB0 File Offset: 0x00006CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224390, XrefRangeEnd = 1224404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ScriptBuilder MakeBuilder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsScriptGenerator.NativeMethodInfoPtr_MakeBuilder_Public_Virtual_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptBuilder>(intPtr3) : null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008AFC File Offset: 0x00006CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224404, XrefRangeEnd = 1224439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParserArtifact Generate(ScriptBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsScriptGenerator.NativeMethodInfoPtr_Generate_Public_Virtual_ParserArtifact_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParserArtifact>(intPtr3) : null;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002A8A File Offset: 0x00000C8A
		public ConstantsScriptGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00008B58 File Offset: 0x00006D58
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002A93 File Offset: 0x00000C93
		public unsafe string projectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_projectName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_projectName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00008B80 File Offset: 0x00006D80
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public unsafe string setName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_setName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_setName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00008BA8 File Offset: 0x00006DA8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002AD1 File Offset: 0x00000CD1
		public unsafe string directive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_directive);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_directive), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00008BD0 File Offset: 0x00006DD0
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public unsafe List<ConstantsScriptBuilder.ConstantDefinitionBuilder> constantDefinitionBuilders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_constantDefinitionBuilders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantsScriptBuilder.ConstantDefinitionBuilder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_constantDefinitionBuilders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00008C00 File Offset: 0x00006E00
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002B0F File Offset: 0x00000D0F
		public unsafe Dictionary<string, string> rowData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_rowData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptGenerator.NativeFieldInfoPtr_rowData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_projectName;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_setName;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_directive;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_constantDefinitionBuilders;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_rowData;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_SetRowData_Public_Void_Dictionary_2_String_String_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_ParseConstant_Private_ConstantDefinitionBuilder_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_MakeBuilder_Public_Virtual_ScriptBuilder_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_ParserArtifact_ScriptBuilder_0;
	}
}
