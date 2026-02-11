using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	public sealed class AppDomainSetup : Object
	{
		// Token: 0x06001682 RID: 5762 RVA: 0x0009259C File Offset: 0x0009079C
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainSetup()
		{
			Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomainSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr);
			AppDomainSetup.NativeFieldInfoPtr_application_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_base");
			AppDomainSetup.NativeFieldInfoPtr_application_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_name");
			AppDomainSetup.NativeFieldInfoPtr_cache_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "cache_path");
			AppDomainSetup.NativeFieldInfoPtr_configuration_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_file");
			AppDomainSetup.NativeFieldInfoPtr_dynamic_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "dynamic_base");
			AppDomainSetup.NativeFieldInfoPtr_license_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "license_file");
			AppDomainSetup.NativeFieldInfoPtr_private_bin_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path");
			AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path_probe");
			AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_directories");
			AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_files");
			AppDomainSetup.NativeFieldInfoPtr_publisher_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "publisher_policy");
			AppDomainSetup.NativeFieldInfoPtr_path_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "path_changed");
			AppDomainSetup.NativeFieldInfoPtr_loader_optimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "loader_optimization");
			AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_binding_redirects");
			AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_code_downloads");
			AppDomainSetup.NativeFieldInfoPtr__activationArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "_activationArguments");
			AppDomainSetup.NativeFieldInfoPtr_domain_initializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer");
			AppDomainSetup.NativeFieldInfoPtr_application_trust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_trust");
			AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer_args");
			AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_appbase_probe");
			AppDomainSetup.NativeFieldInfoPtr_configuration_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_bytes");
			AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "serialized_non_primitives");
			AppDomainSetup.NativeFieldInfoPtr_manager_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "manager_assembly");
			AppDomainSetup.NativeFieldInfoPtr_manager_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "manager_type");
			AppDomainSetup.NativeFieldInfoPtr_partial_visible_assemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "partial_visible_assemblies");
			AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "<TargetFrameworkName>k__BackingField");
			AppDomainSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, 100667284);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x000927E8 File Offset: 0x000909E8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00007032 File Offset: 0x00005232
		public AppDomainSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x00092824 File Offset: 0x00090A24
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x0000703B File Offset: 0x0000523B
		public unsafe string application_base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_base);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_base), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x0009284C File Offset: 0x00090A4C
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x0000705A File Offset: 0x0000525A
		public unsafe string application_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00092874 File Offset: 0x00090A74
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00007079 File Offset: 0x00005279
		public unsafe string cache_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_cache_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_cache_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x0009289C File Offset: 0x00090A9C
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x00007098 File Offset: 0x00005298
		public unsafe string configuration_file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x000928C4 File Offset: 0x00090AC4
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x000070B7 File Offset: 0x000052B7
		public unsafe string dynamic_base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_dynamic_base);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_dynamic_base), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x000928EC File Offset: 0x00090AEC
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x000070D6 File Offset: 0x000052D6
		public unsafe string license_file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_license_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_license_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00092914 File Offset: 0x00090B14
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x000070F5 File Offset: 0x000052F5
		public unsafe string private_bin_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x0009293C File Offset: 0x00090B3C
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00007114 File Offset: 0x00005314
		public unsafe string private_bin_path_probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00092964 File Offset: 0x00090B64
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x00007133 File Offset: 0x00005333
		public unsafe string shadow_copy_directories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x0009298C File Offset: 0x00090B8C
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x00007152 File Offset: 0x00005352
		public unsafe string shadow_copy_files
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x000929B4 File Offset: 0x00090BB4
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x00007171 File Offset: 0x00005371
		public unsafe bool publisher_policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_publisher_policy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_publisher_policy)) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x000929DC File Offset: 0x00090BDC
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x0000718C File Offset: 0x0000538C
		public unsafe bool path_changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_path_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_path_changed)) = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00092A04 File Offset: 0x00090C04
		// (set) Token: 0x0600169E RID: 5790 RVA: 0x000071A7 File Offset: 0x000053A7
		public unsafe int loader_optimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_loader_optimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_loader_optimization)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00092A2C File Offset: 0x00090C2C
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x000071C2 File Offset: 0x000053C2
		public unsafe bool disallow_binding_redirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00092A54 File Offset: 0x00090C54
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x000071DD File Offset: 0x000053DD
		public unsafe bool disallow_code_downloads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00092A7C File Offset: 0x00090C7C
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x000071F8 File Offset: 0x000053F8
		public unsafe Object _activationArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__activationArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__activationArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00092AAC File Offset: 0x00090CAC
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x00007217 File Offset: 0x00005417
		public unsafe Object domain_initializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00092ADC File Offset: 0x00090CDC
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x00007236 File Offset: 0x00005436
		public unsafe Object application_trust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_trust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_trust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00092B0C File Offset: 0x00090D0C
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x00007255 File Offset: 0x00005455
		public unsafe Il2CppStringArray domain_initializer_args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00092B3C File Offset: 0x00090D3C
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x00007274 File Offset: 0x00005474
		public unsafe bool disallow_appbase_probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00092B64 File Offset: 0x00090D64
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000728F File Offset: 0x0000548F
		public unsafe Il2CppStructArray<byte> configuration_bytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_bytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x00092B94 File Offset: 0x00090D94
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x000072AE File Offset: 0x000054AE
		public unsafe Il2CppStructArray<byte> serialized_non_primitives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00092BC4 File Offset: 0x00090DC4
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x000072CD File Offset: 0x000054CD
		public unsafe string manager_assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_manager_assembly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_manager_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x00092BEC File Offset: 0x00090DEC
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x000072EC File Offset: 0x000054EC
		public unsafe string manager_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_manager_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_manager_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00092C14 File Offset: 0x00090E14
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000730B File Offset: 0x0000550B
		public unsafe Il2CppStringArray partial_visible_assemblies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_partial_visible_assemblies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_partial_visible_assemblies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00092C44 File Offset: 0x00090E44
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x0000732A File Offset: 0x0000552A
		public unsafe string _TargetFrameworkName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr_application_base;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_application_name;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_cache_path;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_configuration_file;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr_dynamic_base;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr_license_file;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr_private_bin_path;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeFieldInfoPtr_private_bin_path_probe;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeFieldInfoPtr_shadow_copy_directories;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeFieldInfoPtr_shadow_copy_files;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeFieldInfoPtr_publisher_policy;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_path_changed;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_loader_optimization;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr_disallow_binding_redirects;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_disallow_code_downloads;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr__activationArguments;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_domain_initializer;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_application_trust;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_domain_initializer_args;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeFieldInfoPtr_disallow_appbase_probe;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeFieldInfoPtr_configuration_bytes;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeFieldInfoPtr_serialized_non_primitives;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeFieldInfoPtr_manager_assembly;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeFieldInfoPtr_manager_type;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeFieldInfoPtr_partial_visible_assemblies;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeFieldInfoPtr__TargetFrameworkName_k__BackingField;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
