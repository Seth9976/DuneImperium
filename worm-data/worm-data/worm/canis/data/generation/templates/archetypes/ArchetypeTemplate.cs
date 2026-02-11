using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.generation.builders.archetypes;

namespace worm.canis.data.generation.templates.archetypes
{
	// Token: 0x02000009 RID: 9
	public class ArchetypeTemplate : ArchetypeTemplateBase
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000031E4 File Offset: 0x000013E4
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeTemplate()
		{
			Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "worm.canis.data.generation.templates.archetypes", "ArchetypeTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr);
			ArchetypeTemplate.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr, "builder");
			ArchetypeTemplate.NativeMethodInfoPtr_TransformText_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr, 100663336);
			ArchetypeTemplate.NativeMethodInfoPtr_get_Builder_Public_Virtual_Final_New_get_ArchetypeScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr, 100663337);
			ArchetypeTemplate.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr, 100663338);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003264 File Offset: 0x00001464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246232, XrefRangeEnd = 1246307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string TransformText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeTemplate.NativeMethodInfoPtr_TransformText_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000032A8 File Offset: 0x000014A8
		public unsafe virtual ArchetypeScriptBuilder Builder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplate.NativeMethodInfoPtr_get_Builder_Public_Virtual_Final_New_get_ArchetypeScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeScriptBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000032E8 File Offset: 0x000014E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1246323, RefRangeEnd = 1246325, XrefRangeStart = 1246307, XrefRangeEnd = 1246323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeTemplate(ArchetypeScriptBuilder builder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeTemplate.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000217E File Offset: 0x0000037E
		public ArchetypeTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003334 File Offset: 0x00001534
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002187 File Offset: 0x00000387
		public unsafe ArchetypeScriptBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplate.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeScriptBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeTemplate.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_TransformText_Public_Virtual_New_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_Builder_Public_Virtual_Final_New_get_ArchetypeScriptBuilder_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeScriptBuilder_0;
	}
}
