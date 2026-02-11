using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C6 RID: 966
	public sealed class TypeForwardedFromAttribute : Attribute
	{
		// Token: 0x06003953 RID: 14675 RVA: 0x00115890 File Offset: 0x00113A90
		// Note: this type is marked as 'beforefieldinit'.
		static TypeForwardedFromAttribute()
		{
			Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TypeForwardedFromAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr);
			TypeForwardedFromAttribute.NativeFieldInfoPtr__AssemblyFullName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, "<AssemblyFullName>k__BackingField");
			TypeForwardedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, 100671845);
			TypeForwardedFromAttribute.NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr, 100671846);
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x001158FC File Offset: 0x00113AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392995, XrefRangeEnd = 1393004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeForwardedFromAttribute(string assemblyFullName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeForwardedFromAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyFullName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeForwardedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x00115948 File Offset: 0x00113B48
		public unsafe string AssemblyFullName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeForwardedFromAttribute.NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x000153B0 File Offset: 0x000135B0
		public TypeForwardedFromAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x00115980 File Offset: 0x00113B80
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x000153B9 File Offset: 0x000135B9
		public unsafe string _AssemblyFullName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeForwardedFromAttribute.NativeFieldInfoPtr__AssemblyFullName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeForwardedFromAttribute.NativeFieldInfoPtr__AssemblyFullName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeFieldInfoPtr__AssemblyFullName_k__BackingField;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyFullName_Public_get_String_0;
	}
}
