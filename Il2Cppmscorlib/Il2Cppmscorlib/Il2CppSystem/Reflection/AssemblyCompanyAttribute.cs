using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003F4 RID: 1012
	public sealed class AssemblyCompanyAttribute : Attribute
	{
		// Token: 0x06003B6D RID: 15213 RVA: 0x0011D780 File Offset: 0x0011B980
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyCompanyAttribute()
		{
			Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyCompanyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr);
			AssemblyCompanyAttribute.NativeFieldInfoPtr__Company_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr, "<Company>k__BackingField");
			AssemblyCompanyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr, 100672170);
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x0011D7D8 File Offset: 0x0011B9D8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyCompanyAttribute(string company)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyCompanyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(company);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyCompanyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x000161F8 File Offset: 0x000143F8
		public AssemblyCompanyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x0011D824 File Offset: 0x0011BA24
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x00016201 File Offset: 0x00014401
		public unsafe string _Company_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCompanyAttribute.NativeFieldInfoPtr__Company_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCompanyAttribute.NativeFieldInfoPtr__Company_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400300F RID: 12303
		private static readonly IntPtr NativeFieldInfoPtr__Company_k__BackingField;

		// Token: 0x04003010 RID: 12304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
