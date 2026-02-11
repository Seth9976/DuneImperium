using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003F5 RID: 1013
	public sealed class AssemblyConfigurationAttribute : Attribute
	{
		// Token: 0x06003B72 RID: 15218 RVA: 0x0011D84C File Offset: 0x0011BA4C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyConfigurationAttribute()
		{
			Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyConfigurationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr);
			AssemblyConfigurationAttribute.NativeFieldInfoPtr__Configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr, "<Configuration>k__BackingField");
			AssemblyConfigurationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr, 100672171);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0011D8A4 File Offset: 0x0011BAA4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyConfigurationAttribute(string configuration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyConfigurationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(configuration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyConfigurationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00016220 File Offset: 0x00014420
		public AssemblyConfigurationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x0011D8F0 File Offset: 0x0011BAF0
		// (set) Token: 0x06003B76 RID: 15222 RVA: 0x00016229 File Offset: 0x00014429
		public unsafe string _Configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyConfigurationAttribute.NativeFieldInfoPtr__Configuration_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyConfigurationAttribute.NativeFieldInfoPtr__Configuration_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003011 RID: 12305
		private static readonly IntPtr NativeFieldInfoPtr__Configuration_k__BackingField;

		// Token: 0x04003012 RID: 12306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
