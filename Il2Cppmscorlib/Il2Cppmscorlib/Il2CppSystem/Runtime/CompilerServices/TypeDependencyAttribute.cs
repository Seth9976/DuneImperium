using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003DC RID: 988
	public sealed class TypeDependencyAttribute : Attribute
	{
		// Token: 0x06003A0C RID: 14860 RVA: 0x00118090 File Offset: 0x00116290
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDependencyAttribute()
		{
			Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TypeDependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr);
			TypeDependencyAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr, "typeName");
			TypeDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr, 100671959);
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x001180E8 File Offset: 0x001162E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395794, XrefRangeEnd = 1395802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeDependencyAttribute(string typeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDependencyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x0001598D File Offset: 0x00013B8D
		public TypeDependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06003A0F RID: 14863 RVA: 0x00118134 File Offset: 0x00116334
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x00015996 File Offset: 0x00013B96
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDependencyAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDependencyAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
