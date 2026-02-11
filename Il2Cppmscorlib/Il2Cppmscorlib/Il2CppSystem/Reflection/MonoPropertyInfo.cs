using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200044C RID: 1100
	public sealed class MonoPropertyInfo : ValueType
	{
		// Token: 0x06004036 RID: 16438 RVA: 0x00133AAC File Offset: 0x00131CAC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoPropertyInfo()
		{
			Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoPropertyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr);
			MonoPropertyInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "parent");
			MonoPropertyInfo.NativeFieldInfoPtr_declaring_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "declaring_type");
			MonoPropertyInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "name");
			MonoPropertyInfo.NativeFieldInfoPtr_get_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "get_method");
			MonoPropertyInfo.NativeFieldInfoPtr_set_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "set_method");
			MonoPropertyInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, "attrs");
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00017593 File Offset: 0x00015793
		public MonoPropertyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x0001759C File Offset: 0x0001579C
		public MonoPropertyInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x00133B54 File Offset: 0x00131D54
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x000175AE File Offset: 0x000157AE
		public unsafe Type parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x0600403B RID: 16443 RVA: 0x00133B84 File Offset: 0x00131D84
		// (set) Token: 0x0600403C RID: 16444 RVA: 0x000175CD File Offset: 0x000157CD
		public unsafe Type declaring_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_declaring_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_declaring_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x00133BB4 File Offset: 0x00131DB4
		// (set) Token: 0x0600403E RID: 16446 RVA: 0x000175EC File Offset: 0x000157EC
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x00133BDC File Offset: 0x00131DDC
		// (set) Token: 0x06004040 RID: 16448 RVA: 0x0001760B File Offset: 0x0001580B
		public unsafe MethodInfo get_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_get_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_get_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x00133C0C File Offset: 0x00131E0C
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x0001762A File Offset: 0x0001582A
		public unsafe MethodInfo set_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_set_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_set_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06004043 RID: 16451 RVA: 0x00133C3C File Offset: 0x00131E3C
		// (set) Token: 0x06004044 RID: 16452 RVA: 0x00017649 File Offset: 0x00015849
		public unsafe PropertyAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoPropertyInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeFieldInfoPtr_declaring_type;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeFieldInfoPtr_get_method;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeFieldInfoPtr_set_method;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeFieldInfoPtr_attrs;
	}
}
