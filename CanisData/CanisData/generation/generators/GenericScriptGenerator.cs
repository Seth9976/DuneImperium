using System;
using CanisData.generation.builders;
using CanisData.generation.templates;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CanisData.generation.generators
{
	// Token: 0x02000027 RID: 39
	public class GenericScriptGenerator<BuilderType> : ScriptGenerator where BuilderType : ScriptBuilder, new()
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00008EB8 File Offset: 0x000070B8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericScriptGenerator()
		{
			Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.generators", "GenericScriptGenerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BuilderType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr);
			GenericScriptGenerator<BuilderType>.NativeFieldInfoPtr_templateFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr, "templateFactory");
			GenericScriptGenerator<BuilderType>.NativeFieldInfoPtr_builderDecorator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr, "builderDecorator");
			GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr_MakeBuilder_Public_Virtual_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr, 100663478);
			GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_MakeTemplateInstance_1_BuilderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr, 100663479);
			GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_MakeTemplateInstance_1_BuilderType_BuilderDecorator_1_BuilderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr, 100663480);
			GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr_Generate_Public_Virtual_ParserArtifact_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr, 100663481);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008F9C File Offset: 0x0000719C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224439, XrefRangeEnd = 1224440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ScriptBuilder MakeBuilder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr_MakeBuilder_Public_Virtual_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptBuilder>(intPtr3) : null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008FE8 File Offset: 0x000071E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224440, XrefRangeEnd = 1224443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericScriptGenerator(MakeTemplateInstance<BuilderType> templateFactory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(templateFactory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_MakeTemplateInstance_1_BuilderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00009034 File Offset: 0x00007234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1224446, RefRangeEnd = 1224448, XrefRangeStart = 1224443, XrefRangeEnd = 1224446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericScriptGenerator(MakeTemplateInstance<BuilderType> templateFactory, BuilderDecorator<BuilderType> builderDecorator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericScriptGenerator<BuilderType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(templateFactory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builderDecorator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr__ctor_Public_Void_MakeTemplateInstance_1_BuilderType_BuilderDecorator_1_BuilderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009094 File Offset: 0x00007294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224448, XrefRangeEnd = 1224467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ParserArtifact Generate(ScriptBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericScriptGenerator<BuilderType>.NativeMethodInfoPtr_Generate_Public_Virtual_ParserArtifact_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParserArtifact>(intPtr3) : null;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002B5E File Offset: 0x00000D5E
		public GenericScriptGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000090F0 File Offset: 0x000072F0
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002B67 File Offset: 0x00000D67
		public unsafe MakeTemplateInstance<BuilderType> templateFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericScriptGenerator<BuilderType>.NativeFieldInfoPtr_templateFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MakeTemplateInstance<BuilderType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericScriptGenerator<BuilderType>.NativeFieldInfoPtr_templateFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00009120 File Offset: 0x00007320
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002B86 File Offset: 0x00000D86
		public unsafe BuilderDecorator<BuilderType> builderDecorator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericScriptGenerator<BuilderType>.NativeFieldInfoPtr_builderDecorator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuilderDecorator<BuilderType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericScriptGenerator<BuilderType>.NativeFieldInfoPtr_builderDecorator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_templateFactory;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_builderDecorator;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_MakeBuilder_Public_Virtual_ScriptBuilder_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MakeTemplateInstance_1_BuilderType_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MakeTemplateInstance_1_BuilderType_BuilderDecorator_1_BuilderType_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_ParserArtifact_ScriptBuilder_0;
	}
}
