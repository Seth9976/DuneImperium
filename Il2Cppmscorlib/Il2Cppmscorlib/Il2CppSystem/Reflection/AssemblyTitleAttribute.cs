using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000401 RID: 1025
	public sealed class AssemblyTitleAttribute : Attribute
	{
		// Token: 0x06003BA8 RID: 15272 RVA: 0x0011E128 File Offset: 0x0011C328
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyTitleAttribute()
		{
			Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyTitleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr);
			AssemblyTitleAttribute.NativeFieldInfoPtr__Title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr, "<Title>k__BackingField");
			AssemblyTitleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr, 100672183);
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0011E180 File Offset: 0x0011C380
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyTitleAttribute(string title)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyTitleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyTitleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000163CB File Offset: 0x000145CB
		public AssemblyTitleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x0011E1CC File Offset: 0x0011C3CC
		// (set) Token: 0x06003BAC RID: 15276 RVA: 0x000163D4 File Offset: 0x000145D4
		public unsafe string _Title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTitleAttribute.NativeFieldInfoPtr__Title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTitleAttribute.NativeFieldInfoPtr__Title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003031 RID: 12337
		private static readonly IntPtr NativeFieldInfoPtr__Title_k__BackingField;

		// Token: 0x04003032 RID: 12338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
