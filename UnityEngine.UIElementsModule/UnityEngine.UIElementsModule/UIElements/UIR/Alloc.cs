using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200024A RID: 586
	public sealed class Alloc : ValueType
	{
		// Token: 0x06002B8D RID: 11149 RVA: 0x000BC8D4 File Offset: 0x000BAAD4
		// Note: this type is marked as 'beforefieldinit'.
		static Alloc()
		{
			Il2CppClassPointerStore<Alloc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Alloc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Alloc>.NativeClassPtr);
			Alloc.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "start");
			Alloc.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "size");
			Alloc.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "handle");
			Alloc.NativeFieldInfoPtr_shortLived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "shortLived");
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0001196B File Offset: 0x0000FB6B
		public Alloc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00011974 File Offset: 0x0000FB74
		public Alloc()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Alloc>.NativeClassPtr))
		{
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000BC954 File Offset: 0x000BAB54
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x00011986 File Offset: 0x0000FB86
		public unsafe uint start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000BC97C File Offset: 0x000BAB7C
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x000119A1 File Offset: 0x0000FBA1
		public unsafe uint size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000BC9A4 File Offset: 0x000BABA4
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x000119BC File Offset: 0x0000FBBC
		public unsafe Object handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000BC9D4 File Offset: 0x000BABD4
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x000119DB File Offset: 0x0000FBDB
		public unsafe bool shortLived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_shortLived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_shortLived)) = value;
			}
		}

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeFieldInfoPtr_shortLived;
	}
}
