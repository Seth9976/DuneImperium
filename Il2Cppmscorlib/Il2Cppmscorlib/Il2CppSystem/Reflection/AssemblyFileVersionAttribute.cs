using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003FB RID: 1019
	public sealed class AssemblyFileVersionAttribute : Attribute
	{
		// Token: 0x06003B8B RID: 15243 RVA: 0x0011DC44 File Offset: 0x0011BE44
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyFileVersionAttribute()
		{
			Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyFileVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr);
			AssemblyFileVersionAttribute.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, "<Version>k__BackingField");
			AssemblyFileVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, 100672176);
			AssemblyFileVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, 100672177);
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x0011DCB0 File Offset: 0x0011BEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398067, XrefRangeEnd = 1398075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyFileVersionAttribute(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFileVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06003B8D RID: 15245 RVA: 0x0011DCFC File Offset: 0x0011BEFC
		public unsafe string Version
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFileVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x000162E4 File Offset: 0x000144E4
		public AssemblyFileVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x0011DD34 File Offset: 0x0011BF34
		// (set) Token: 0x06003B90 RID: 15248 RVA: 0x000162ED File Offset: 0x000144ED
		public unsafe string _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFileVersionAttribute.NativeFieldInfoPtr__Version_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFileVersionAttribute.NativeFieldInfoPtr__Version_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400301E RID: 12318
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x0400301F RID: 12319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003020 RID: 12320
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;
	}
}
