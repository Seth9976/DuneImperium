using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003DE RID: 990
	public sealed class Ephemeron : ValueType
	{
		// Token: 0x06003A16 RID: 14870 RVA: 0x001182F8 File Offset: 0x001164F8
		// Note: this type is marked as 'beforefieldinit'.
		static Ephemeron()
		{
			Il2CppClassPointerStore<Ephemeron>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "Ephemeron");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr);
			Ephemeron.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr, "key");
			Ephemeron.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr, "value");
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x000159BE File Offset: 0x00013BBE
		public Ephemeron(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x000159C7 File Offset: 0x00013BC7
		public Ephemeron()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ephemeron>.NativeClassPtr))
		{
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x00118350 File Offset: 0x00116550
		// (set) Token: 0x06003A1A RID: 14874 RVA: 0x000159D9 File Offset: 0x00013BD9
		public unsafe Object key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x00118380 File Offset: 0x00116580
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x000159F8 File Offset: 0x00013BF8
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ephemeron.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeFieldInfoPtr_value;
	}
}
