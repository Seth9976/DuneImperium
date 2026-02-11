using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		// Token: 0x060039EE RID: 14830 RVA: 0x00117BA4 File Offset: 0x00115DA4
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDependencyAttribute()
		{
			Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DefaultDependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr);
			DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, "loadHint");
			DefaultDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, 100671951);
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x00117BFC File Offset: 0x00115DFC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDependencyAttribute(LoadHint loadHintArgument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadHintArgument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x0001587D File Offset: 0x00013A7D
		public DefaultDependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x00117C44 File Offset: 0x00115E44
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x00015886 File Offset: 0x00013A86
		public unsafe LoadHint loadHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint)) = value;
			}
		}

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeFieldInfoPtr_loadHint;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0;
	}
}
