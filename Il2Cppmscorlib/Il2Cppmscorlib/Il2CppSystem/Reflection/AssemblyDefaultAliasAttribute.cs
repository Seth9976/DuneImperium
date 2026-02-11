using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003F8 RID: 1016
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		// Token: 0x06003B7C RID: 15228 RVA: 0x0011D9E4 File Offset: 0x0011BBE4
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDefaultAliasAttribute()
		{
			Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDefaultAliasAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr);
			AssemblyDefaultAliasAttribute.NativeFieldInfoPtr__DefaultAlias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr, "<DefaultAlias>k__BackingField");
			AssemblyDefaultAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr, 100672173);
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x0011DA3C File Offset: 0x0011BC3C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDefaultAliasAttribute(string defaultAlias)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDefaultAliasAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(defaultAlias);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDefaultAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00016270 File Offset: 0x00014470
		public AssemblyDefaultAliasAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x0011DA88 File Offset: 0x0011BC88
		// (set) Token: 0x06003B80 RID: 15232 RVA: 0x00016279 File Offset: 0x00014479
		public unsafe string _DefaultAlias_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDefaultAliasAttribute.NativeFieldInfoPtr__DefaultAlias_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDefaultAliasAttribute.NativeFieldInfoPtr__DefaultAlias_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003018 RID: 12312
		private static readonly IntPtr NativeFieldInfoPtr__DefaultAlias_k__BackingField;

		// Token: 0x04003019 RID: 12313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
