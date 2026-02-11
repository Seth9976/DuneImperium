using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x02000011 RID: 17
	public class ServiceProviderOptions : Object
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x000058A4 File Offset: 0x00003AA4
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceProviderOptions()
		{
			Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection", "ServiceProviderOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr);
			ServiceProviderOptions.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr, "Default");
			ServiceProviderOptions.NativeFieldInfoPtr__ValidateScopes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr, "<ValidateScopes>k__BackingField");
			ServiceProviderOptions.NativeFieldInfoPtr__ValidateOnBuild_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr, "<ValidateOnBuild>k__BackingField");
			ServiceProviderOptions.NativeMethodInfoPtr_get_ValidateScopes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr, 100663407);
			ServiceProviderOptions.NativeMethodInfoPtr_get_ValidateOnBuild_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr, 100663408);
			ServiceProviderOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr, 100663409);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000594C File Offset: 0x00003B4C
		public unsafe bool ValidateScopes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderOptions.NativeMethodInfoPtr_get_ValidateScopes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005988 File Offset: 0x00003B88
		public unsafe bool ValidateOnBuild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderOptions.NativeMethodInfoPtr_get_ValidateOnBuild_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000059C4 File Offset: 0x00003BC4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProviderOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProviderOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002395 File Offset: 0x00000595
		public ServiceProviderOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005A00 File Offset: 0x00003C00
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000239E File Offset: 0x0000059E
		public unsafe static ServiceProviderOptions Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceProviderOptions.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProviderOptions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceProviderOptions.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00005A28 File Offset: 0x00003C28
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000023B0 File Offset: 0x000005B0
		public unsafe bool _ValidateScopes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderOptions.NativeFieldInfoPtr__ValidateScopes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderOptions.NativeFieldInfoPtr__ValidateScopes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005A50 File Offset: 0x00003C50
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000023CB File Offset: 0x000005CB
		public unsafe bool _ValidateOnBuild_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderOptions.NativeFieldInfoPtr__ValidateOnBuild_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderOptions.NativeFieldInfoPtr__ValidateOnBuild_k__BackingField)) = value;
			}
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr__ValidateScopes_k__BackingField;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr__ValidateOnBuild_k__BackingField;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidateScopes_Public_get_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidateOnBuild_Public_get_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
