using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C2 RID: 450
	[StructLayout(2)]
	public struct Hashes
	{
		// Token: 0x0600235C RID: 9052 RVA: 0x0009FCD4 File Offset: 0x0009DED4
		// Note: this type is marked as 'beforefieldinit'.
		static Hashes()
		{
			Il2CppClassPointerStore<Hashes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Hashes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashes>.NativeClassPtr);
			Hashes.NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashes>.NativeClassPtr, "kSize");
			Hashes.NativeFieldInfoPtr_hashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashes>.NativeClassPtr, "hashes");
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0000E7A6 File Offset: 0x0000C9A6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hashes>.NativeClassPtr, ref this));
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0009FD2C File Offset: 0x0009DF2C
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		public unsafe static int kSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashes.NativeFieldInfoPtr_kSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashes.NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeFieldInfoPtr_kSize;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeFieldInfoPtr_hashes;

		// Token: 0x0400195A RID: 6490
		[FieldOffset(0)]
		public Hashes._hashes_e__FixedBuffer hashes;

		// Token: 0x020004DA RID: 1242
		[ObfuscatedName("UnityEngine.UIElements.Hashes+<hashes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _hashes_e__FixedBuffer
		{
			// Token: 0x06003EFB RID: 16123 RVA: 0x0001A5FC File Offset: 0x000187FC
			// Note: this type is marked as 'beforefieldinit'.
			static _hashes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<Hashes._hashes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashes>.NativeClassPtr, "<hashes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashes._hashes_e__FixedBuffer>.NativeClassPtr);
				Hashes._hashes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashes._hashes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003EFC RID: 16124 RVA: 0x0001A630 File Offset: 0x00018830
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hashes._hashes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002C8A RID: 11402
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002C8B RID: 11403
			[FieldOffset(0)]
			public int FixedElementField;
		}
	}
}
