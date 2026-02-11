using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace CanisData.generation.templates
{
	// Token: 0x02000021 RID: 33
	public class ConstantsTemplate : ConstantsTemplateBase
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00007B5C File Offset: 0x00005D5C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantsTemplate()
		{
			Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.templates", "ConstantsTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr);
			ConstantsTemplate.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr, "builder");
			ConstantsTemplate.NativeMethodInfoPtr_TransformText_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr, 100663438);
			ConstantsTemplate.NativeMethodInfoPtr_get_Builder_Public_Virtual_Final_New_get_ConstantsScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr, 100663439);
			ConstantsTemplate.NativeMethodInfoPtr__ctor_Public_Void_ConstantsScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr, 100663440);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00007BDC File Offset: 0x00005DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223892, XrefRangeEnd = 1224119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string TransformText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantsTemplate.NativeMethodInfoPtr_TransformText_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00007C20 File Offset: 0x00005E20
		public unsafe virtual ConstantsScriptBuilder Builder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplate.NativeMethodInfoPtr_get_Builder_Public_Virtual_Final_New_get_ConstantsScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantsScriptBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007C60 File Offset: 0x00005E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224119, XrefRangeEnd = 1224135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantsTemplate(ConstantsScriptBuilder builder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsTemplate.NativeMethodInfoPtr__ctor_Public_Void_ConstantsScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000292D File Offset: 0x00000B2D
		public ConstantsTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00007CAC File Offset: 0x00005EAC
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002936 File Offset: 0x00000B36
		public unsafe ConstantsScriptBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplate.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantsScriptBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsTemplate.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_TransformText_Public_Virtual_New_String_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_Builder_Public_Virtual_Final_New_get_ConstantsScriptBuilder_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConstantsScriptBuilder_0;
	}
}
