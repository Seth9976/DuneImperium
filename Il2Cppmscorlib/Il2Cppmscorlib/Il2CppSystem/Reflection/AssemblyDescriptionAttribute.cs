using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003FA RID: 1018
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		// Token: 0x06003B86 RID: 15238 RVA: 0x0011DB78 File Offset: 0x0011BD78
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDescriptionAttribute()
		{
			Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr);
			AssemblyDescriptionAttribute.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr, "<Description>k__BackingField");
			AssemblyDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr, 100672175);
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x0011DBD0 File Offset: 0x0011BDD0
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x000162BC File Offset: 0x000144BC
		public AssemblyDescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06003B89 RID: 15241 RVA: 0x0011DC1C File Offset: 0x0011BE1C
		// (set) Token: 0x06003B8A RID: 15242 RVA: 0x000162C5 File Offset: 0x000144C5
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDescriptionAttribute.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDescriptionAttribute.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400301C RID: 12316
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x0400301D RID: 12317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
