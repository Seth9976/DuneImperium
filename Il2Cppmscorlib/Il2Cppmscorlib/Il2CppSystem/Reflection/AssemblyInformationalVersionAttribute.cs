using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003FC RID: 1020
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		// Token: 0x06003B91 RID: 15249 RVA: 0x0011DD5C File Offset: 0x0011BF5C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyInformationalVersionAttribute()
		{
			Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyInformationalVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr);
			AssemblyInformationalVersionAttribute.NativeFieldInfoPtr__InformationalVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, "<InformationalVersion>k__BackingField");
			AssemblyInformationalVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, 100672178);
			AssemblyInformationalVersionAttribute.NativeMethodInfoPtr_get_InformationalVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr, 100672179);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x0011DDC8 File Offset: 0x0011BFC8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyInformationalVersionAttribute(string informationalVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyInformationalVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(informationalVersion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyInformationalVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x0011DE14 File Offset: 0x0011C014
		public unsafe string InformationalVersion
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyInformationalVersionAttribute.NativeMethodInfoPtr_get_InformationalVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x0001630C File Offset: 0x0001450C
		public AssemblyInformationalVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x0011DE4C File Offset: 0x0011C04C
		// (set) Token: 0x06003B96 RID: 15254 RVA: 0x00016315 File Offset: 0x00014515
		public unsafe string _InformationalVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyInformationalVersionAttribute.NativeFieldInfoPtr__InformationalVersion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyInformationalVersionAttribute.NativeFieldInfoPtr__InformationalVersion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003021 RID: 12321
		private static readonly IntPtr NativeFieldInfoPtr__InformationalVersion_k__BackingField;

		// Token: 0x04003022 RID: 12322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003023 RID: 12323
		private static readonly IntPtr NativeMethodInfoPtr_get_InformationalVersion_Public_get_String_0;
	}
}
