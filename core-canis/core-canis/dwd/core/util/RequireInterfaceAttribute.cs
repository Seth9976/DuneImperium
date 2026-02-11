using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x02000093 RID: 147
	public class RequireInterfaceAttribute : PropertyAttribute
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x0003AF34 File Offset: 0x00039134
		// Note: this type is marked as 'beforefieldinit'.
		static RequireInterfaceAttribute()
		{
			Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "RequireInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr);
			RequireInterfaceAttribute.NativeFieldInfoPtr__Interface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr, "<Interface>k__BackingField");
			RequireInterfaceAttribute.NativeFieldInfoPtr__DefaultOptionName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr, "<DefaultOptionName>k__BackingField");
			RequireInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr, 100664741);
			RequireInterfaceAttribute.NativeMethodInfoPtr_get_Interface_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr, 100664742);
			RequireInterfaceAttribute.NativeMethodInfoPtr_get_DefaultOptionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr, 100664743);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0003AFC8 File Offset: 0x000391C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862768, XrefRangeEnd = 862771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireInterfaceAttribute(Type interfaceType, string defaultOptionName = "None")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireInterfaceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interfaceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultOptionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003B028 File Offset: 0x00039228
		public unsafe Type Interface
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireInterfaceAttribute.NativeMethodInfoPtr_get_Interface_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0003B068 File Offset: 0x00039268
		public unsafe string DefaultOptionName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireInterfaceAttribute.NativeMethodInfoPtr_get_DefaultOptionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00005AE5 File Offset: 0x00003CE5
		public RequireInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0003B0A0 File Offset: 0x000392A0
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00005AEE File Offset: 0x00003CEE
		public unsafe Type _Interface_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireInterfaceAttribute.NativeFieldInfoPtr__Interface_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireInterfaceAttribute.NativeFieldInfoPtr__Interface_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0003B0D0 File Offset: 0x000392D0
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00005B0D File Offset: 0x00003D0D
		public unsafe string _DefaultOptionName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireInterfaceAttribute.NativeFieldInfoPtr__DefaultOptionName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireInterfaceAttribute.NativeFieldInfoPtr__DefaultOptionName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr__Interface_k__BackingField;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr__DefaultOptionName_k__BackingField;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_Interface_Public_get_Type_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultOptionName_Public_get_String_0;
	}
}
