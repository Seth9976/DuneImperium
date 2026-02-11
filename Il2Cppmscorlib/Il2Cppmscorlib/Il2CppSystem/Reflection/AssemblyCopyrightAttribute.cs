using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003F7 RID: 1015
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		// Token: 0x06003B77 RID: 15223 RVA: 0x0011D918 File Offset: 0x0011BB18
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyCopyrightAttribute()
		{
			Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyCopyrightAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr);
			AssemblyCopyrightAttribute.NativeFieldInfoPtr__Copyright_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr, "<Copyright>k__BackingField");
			AssemblyCopyrightAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr, 100672172);
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x0011D970 File Offset: 0x0011BB70
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyCopyrightAttribute(string copyright)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyCopyrightAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(copyright);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyCopyrightAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00016248 File Offset: 0x00014448
		public AssemblyCopyrightAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06003B7A RID: 15226 RVA: 0x0011D9BC File Offset: 0x0011BBBC
		// (set) Token: 0x06003B7B RID: 15227 RVA: 0x00016251 File Offset: 0x00014451
		public unsafe string _Copyright_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCopyrightAttribute.NativeFieldInfoPtr__Copyright_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyCopyrightAttribute.NativeFieldInfoPtr__Copyright_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003016 RID: 12310
		private static readonly IntPtr NativeFieldInfoPtr__Copyright_k__BackingField;

		// Token: 0x04003017 RID: 12311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
