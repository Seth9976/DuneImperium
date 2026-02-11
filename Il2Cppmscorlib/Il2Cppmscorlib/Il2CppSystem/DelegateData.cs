using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000149 RID: 329
	public sealed class DelegateData : Object
	{
		// Token: 0x060016F0 RID: 5872 RVA: 0x000938B4 File Offset: 0x00091AB4
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateData()
		{
			Il2CppClassPointerStore<DelegateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DelegateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateData>.NativeClassPtr);
			DelegateData.NativeFieldInfoPtr_target_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "target_type");
			DelegateData.NativeFieldInfoPtr_method_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "method_name");
			DelegateData.NativeFieldInfoPtr_curried_first_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, "curried_first_arg");
			DelegateData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateData>.NativeClassPtr, 100667324);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00093934 File Offset: 0x00091B34
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegateData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00007415 File Offset: 0x00005615
		public DelegateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00093970 File Offset: 0x00091B70
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x0000741E File Offset: 0x0000561E
		public unsafe Type target_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_target_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_target_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000939A0 File Offset: 0x00091BA0
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0000743D File Offset: 0x0000563D
		public unsafe string method_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_method_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_method_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x000939C8 File Offset: 0x00091BC8
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0000745C File Offset: 0x0000565C
		public unsafe bool curried_first_arg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_curried_first_arg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateData.NativeFieldInfoPtr_curried_first_arg)) = value;
			}
		}

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_target_type;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_method_name;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr_curried_first_arg;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
