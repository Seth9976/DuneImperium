using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000443 RID: 1091
	public sealed class MonoEventInfo : ValueType
	{
		// Token: 0x06003F24 RID: 16164 RVA: 0x0012E828 File Offset: 0x0012CA28
		// Note: this type is marked as 'beforefieldinit'.
		static MonoEventInfo()
		{
			Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoEventInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr);
			MonoEventInfo.NativeFieldInfoPtr_declaring_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "declaring_type");
			MonoEventInfo.NativeFieldInfoPtr_reflected_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "reflected_type");
			MonoEventInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "name");
			MonoEventInfo.NativeFieldInfoPtr_add_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "add_method");
			MonoEventInfo.NativeFieldInfoPtr_remove_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "remove_method");
			MonoEventInfo.NativeFieldInfoPtr_raise_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "raise_method");
			MonoEventInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "attrs");
			MonoEventInfo.NativeFieldInfoPtr_other_methods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "other_methods");
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0001712A File Offset: 0x0001532A
		public MonoEventInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00017133 File Offset: 0x00015333
		public MonoEventInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x0012E8F8 File Offset: 0x0012CAF8
		// (set) Token: 0x06003F28 RID: 16168 RVA: 0x00017145 File Offset: 0x00015345
		public unsafe Type declaring_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_declaring_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_declaring_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x0012E928 File Offset: 0x0012CB28
		// (set) Token: 0x06003F2A RID: 16170 RVA: 0x00017164 File Offset: 0x00015364
		public unsafe Type reflected_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_reflected_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_reflected_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06003F2B RID: 16171 RVA: 0x0012E958 File Offset: 0x0012CB58
		// (set) Token: 0x06003F2C RID: 16172 RVA: 0x00017183 File Offset: 0x00015383
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x0012E980 File Offset: 0x0012CB80
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x000171A2 File Offset: 0x000153A2
		public unsafe MethodInfo add_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_add_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_add_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x0012E9B0 File Offset: 0x0012CBB0
		// (set) Token: 0x06003F30 RID: 16176 RVA: 0x000171C1 File Offset: 0x000153C1
		public unsafe MethodInfo remove_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_remove_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_remove_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06003F31 RID: 16177 RVA: 0x0012E9E0 File Offset: 0x0012CBE0
		// (set) Token: 0x06003F32 RID: 16178 RVA: 0x000171E0 File Offset: 0x000153E0
		public unsafe MethodInfo raise_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_raise_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_raise_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06003F33 RID: 16179 RVA: 0x0012EA10 File Offset: 0x0012CC10
		// (set) Token: 0x06003F34 RID: 16180 RVA: 0x000171FF File Offset: 0x000153FF
		public unsafe EventAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06003F35 RID: 16181 RVA: 0x0012EA38 File Offset: 0x0012CC38
		// (set) Token: 0x06003F36 RID: 16182 RVA: 0x0001721A File Offset: 0x0001541A
		public unsafe Il2CppReferenceArray<MethodInfo> other_methods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_other_methods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_other_methods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeFieldInfoPtr_declaring_type;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeFieldInfoPtr_reflected_type;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeFieldInfoPtr_add_method;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeFieldInfoPtr_remove_method;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeFieldInfoPtr_raise_method;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeFieldInfoPtr_other_methods;
	}
}
