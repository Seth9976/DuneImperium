using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003FE RID: 1022
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x0011DF40 File Offset: 0x0011C140
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyMetadataAttribute()
		{
			Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyMetadataAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr);
			AssemblyMetadataAttribute.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr, "<Key>k__BackingField");
			AssemblyMetadataAttribute.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr, "<Value>k__BackingField");
			AssemblyMetadataAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr, 100672181);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x0011DFAC File Offset: 0x0011C1AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyMetadataAttribute(string key, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyMetadataAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyMetadataAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x0001635C File Offset: 0x0001455C
		public AssemblyMetadataAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06003B9F RID: 15263 RVA: 0x0011E00C File Offset: 0x0011C20C
		// (set) Token: 0x06003BA0 RID: 15264 RVA: 0x00016365 File Offset: 0x00014565
		public unsafe string _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr__Key_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x0011E034 File Offset: 0x0011C234
		// (set) Token: 0x06003BA2 RID: 15266 RVA: 0x00016384 File Offset: 0x00014584
		public unsafe string _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr__Value_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyMetadataAttribute.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003026 RID: 12326
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04003027 RID: 12327
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04003028 RID: 12328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
