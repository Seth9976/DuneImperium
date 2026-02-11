using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003FD RID: 1021
	public sealed class AssemblyKeyFileAttribute : Attribute
	{
		// Token: 0x06003B97 RID: 15255 RVA: 0x0011DE74 File Offset: 0x0011C074
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyKeyFileAttribute()
		{
			Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyKeyFileAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr);
			AssemblyKeyFileAttribute.NativeFieldInfoPtr__KeyFile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr, "<KeyFile>k__BackingField");
			AssemblyKeyFileAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr, 100672180);
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x0011DECC File Offset: 0x0011C0CC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyKeyFileAttribute(string keyFile)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyKeyFileAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyKeyFileAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00016334 File Offset: 0x00014534
		public AssemblyKeyFileAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x0011DF18 File Offset: 0x0011C118
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x0001633D File Offset: 0x0001453D
		public unsafe string _KeyFile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyKeyFileAttribute.NativeFieldInfoPtr__KeyFile_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyKeyFileAttribute.NativeFieldInfoPtr__KeyFile_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003024 RID: 12324
		private static readonly IntPtr NativeFieldInfoPtr__KeyFile_k__BackingField;

		// Token: 0x04003025 RID: 12325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
