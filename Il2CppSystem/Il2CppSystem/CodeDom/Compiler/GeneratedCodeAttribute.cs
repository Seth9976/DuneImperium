using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.CodeDom.Compiler
{
	// Token: 0x0200008D RID: 141
	public sealed class GeneratedCodeAttribute : Attribute
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00044BF4 File Offset: 0x00042DF4
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedCodeAttribute()
		{
			Il2CppClassPointerStore<GeneratedCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.CodeDom.Compiler", "GeneratedCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedCodeAttribute>.NativeClassPtr);
			GeneratedCodeAttribute.NativeFieldInfoPtr_tool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedCodeAttribute>.NativeClassPtr, "tool");
			GeneratedCodeAttribute.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedCodeAttribute>.NativeClassPtr, "version");
			GeneratedCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedCodeAttribute>.NativeClassPtr, 100664902);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00044C60 File Offset: 0x00042E60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442631, XrefRangeEnd = 442634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneratedCodeAttribute(string tool, string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneratedCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00005B56 File Offset: 0x00003D56
		public GeneratedCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00044CC0 File Offset: 0x00042EC0
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00005B5F File Offset: 0x00003D5F
		public unsafe string tool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratedCodeAttribute.NativeFieldInfoPtr_tool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratedCodeAttribute.NativeFieldInfoPtr_tool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00044CE8 File Offset: 0x00042EE8
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00005B7E File Offset: 0x00003D7E
		public unsafe string version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratedCodeAttribute.NativeFieldInfoPtr_version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratedCodeAttribute.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr_tool;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
