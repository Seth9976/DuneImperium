using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000400 RID: 1024
	public sealed class AssemblyProductAttribute : Attribute
	{
		// Token: 0x06003BA3 RID: 15267 RVA: 0x0011E05C File Offset: 0x0011C25C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyProductAttribute()
		{
			Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyProductAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr);
			AssemblyProductAttribute.NativeFieldInfoPtr__Product_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, "<Product>k__BackingField");
			AssemblyProductAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, 100672182);
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x0011E0B4 File Offset: 0x0011C2B4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyProductAttribute(string product)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyProductAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000163A3 File Offset: 0x000145A3
		public AssemblyProductAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x0011E100 File Offset: 0x0011C300
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x000163AC File Offset: 0x000145AC
		public unsafe string _Product_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyProductAttribute.NativeFieldInfoPtr__Product_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyProductAttribute.NativeFieldInfoPtr__Product_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400302F RID: 12335
		private static readonly IntPtr NativeFieldInfoPtr__Product_k__BackingField;

		// Token: 0x04003030 RID: 12336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
