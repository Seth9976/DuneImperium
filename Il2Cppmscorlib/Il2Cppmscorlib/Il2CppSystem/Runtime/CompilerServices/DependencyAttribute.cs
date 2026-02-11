using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D7 RID: 983
	[Serializable]
	public sealed class DependencyAttribute : Attribute
	{
		// Token: 0x060039F3 RID: 14835 RVA: 0x00117C6C File Offset: 0x00115E6C
		// Note: this type is marked as 'beforefieldinit'.
		static DependencyAttribute()
		{
			Il2CppClassPointerStore<DependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependencyAttribute>.NativeClassPtr);
			DependencyAttribute.NativeFieldInfoPtr_dependentAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyAttribute>.NativeClassPtr, "dependentAssembly");
			DependencyAttribute.NativeFieldInfoPtr_loadHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyAttribute>.NativeClassPtr, "loadHint");
			DependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_LoadHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyAttribute>.NativeClassPtr, 100671952);
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00117CD8 File Offset: 0x00115ED8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DependencyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dependentAssemblyArgument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadHintArgument;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_LoadHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x000158A1 File Offset: 0x00013AA1
		public DependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060039F6 RID: 14838 RVA: 0x00117D34 File Offset: 0x00115F34
		// (set) Token: 0x060039F7 RID: 14839 RVA: 0x000158AA File Offset: 0x00013AAA
		public unsafe string dependentAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependencyAttribute.NativeFieldInfoPtr_dependentAssembly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependencyAttribute.NativeFieldInfoPtr_dependentAssembly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060039F8 RID: 14840 RVA: 0x00117D5C File Offset: 0x00115F5C
		// (set) Token: 0x060039F9 RID: 14841 RVA: 0x000158C9 File Offset: 0x00013AC9
		public unsafe LoadHint loadHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependencyAttribute.NativeFieldInfoPtr_loadHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependencyAttribute.NativeFieldInfoPtr_loadHint)) = value;
			}
		}

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeFieldInfoPtr_dependentAssembly;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeFieldInfoPtr_loadHint;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_LoadHint_0;
	}
}
