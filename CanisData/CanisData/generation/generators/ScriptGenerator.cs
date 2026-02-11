using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CanisData.generation.generators
{
	// Token: 0x02000028 RID: 40
	public class ScriptGenerator : Object
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00009150 File Offset: 0x00007350
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptGenerator()
		{
			Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.generators", "ScriptGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr);
			ScriptGenerator.NativeFieldInfoPtr__RelativePathName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr, "<RelativePathName>k__BackingField");
			ScriptGenerator.NativeMethodInfoPtr_get_RelativePathName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr, 100663482);
			ScriptGenerator.NativeMethodInfoPtr_set_RelativePathName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr, 100663483);
			ScriptGenerator.NativeMethodInfoPtr_MakeBuilder_Public_Abstract_Virtual_New_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr, 100663484);
			ScriptGenerator.NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_ParserArtifact_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr, 100663485);
			ScriptGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr, 100663486);
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000091F8 File Offset: 0x000073F8
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00009230 File Offset: 0x00007430
		public unsafe string RelativePathName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGenerator.NativeMethodInfoPtr_get_RelativePathName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGenerator.NativeMethodInfoPtr_set_RelativePathName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009274 File Offset: 0x00007474
		[CallerCount(0)]
		public unsafe virtual ScriptBuilder MakeBuilder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptGenerator.NativeMethodInfoPtr_MakeBuilder_Public_Abstract_Virtual_New_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptBuilder>(intPtr3) : null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000092C0 File Offset: 0x000074C0
		[CallerCount(0)]
		public unsafe virtual ParserArtifact Generate(ScriptBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptGenerator.NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_ParserArtifact_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParserArtifact>(intPtr3) : null;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000931C File Offset: 0x0000751C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public ScriptGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00009358 File Offset: 0x00007558
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002BAE File Offset: 0x00000DAE
		public unsafe string _RelativePathName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGenerator.NativeFieldInfoPtr__RelativePathName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptGenerator.NativeFieldInfoPtr__RelativePathName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr__RelativePathName_k__BackingField;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativePathName_Public_get_String_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_set_RelativePathName_Public_set_Void_String_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_MakeBuilder_Public_Abstract_Virtual_New_ScriptBuilder_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_ParserArtifact_ScriptBuilder_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
