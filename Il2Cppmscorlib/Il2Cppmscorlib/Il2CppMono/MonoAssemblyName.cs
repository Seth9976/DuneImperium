using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000012 RID: 18
	[StructLayout(2)]
	public struct MonoAssemblyName
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00026860 File Offset: 0x00024A60
		// Note: this type is marked as 'beforefieldinit'.
		static MonoAssemblyName()
		{
			Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "MonoAssemblyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr);
			MonoAssemblyName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "name");
			MonoAssemblyName.NativeFieldInfoPtr_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "culture");
			MonoAssemblyName.NativeFieldInfoPtr_hash_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_value");
			MonoAssemblyName.NativeFieldInfoPtr_public_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "public_key");
			MonoAssemblyName.NativeFieldInfoPtr_public_key_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "public_key_token");
			MonoAssemblyName.NativeFieldInfoPtr_hash_alg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_alg");
			MonoAssemblyName.NativeFieldInfoPtr_hash_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_len");
			MonoAssemblyName.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "flags");
			MonoAssemblyName.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "major");
			MonoAssemblyName.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "minor");
			MonoAssemblyName.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "build");
			MonoAssemblyName.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "revision");
			MonoAssemblyName.NativeFieldInfoPtr_arch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "arch");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002242 File Offset: 0x00000442
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, ref this));
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_culture;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_hash_value;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_public_key;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_public_key_token;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_hash_alg;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_hash_len;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_arch;

		// Token: 0x0400004F RID: 79
		[FieldOffset(0)]
		public IntPtr name;

		// Token: 0x04000050 RID: 80
		[FieldOffset(8)]
		public IntPtr culture;

		// Token: 0x04000051 RID: 81
		[FieldOffset(16)]
		public IntPtr hash_value;

		// Token: 0x04000052 RID: 82
		[FieldOffset(24)]
		public IntPtr public_key;

		// Token: 0x04000053 RID: 83
		[FieldOffset(32)]
		public MonoAssemblyName._public_key_token_e__FixedBuffer public_key_token;

		// Token: 0x04000054 RID: 84
		[FieldOffset(52)]
		public uint hash_alg;

		// Token: 0x04000055 RID: 85
		[FieldOffset(56)]
		public uint hash_len;

		// Token: 0x04000056 RID: 86
		[FieldOffset(60)]
		public uint flags;

		// Token: 0x04000057 RID: 87
		[FieldOffset(64)]
		public ushort major;

		// Token: 0x04000058 RID: 88
		[FieldOffset(66)]
		public ushort minor;

		// Token: 0x04000059 RID: 89
		[FieldOffset(68)]
		public ushort build;

		// Token: 0x0400005A RID: 90
		[FieldOffset(70)]
		public ushort revision;

		// Token: 0x0400005B RID: 91
		[FieldOffset(72)]
		public ushort arch;

		// Token: 0x02000564 RID: 1380
		[ObfuscatedName("Mono.MonoAssemblyName+<public_key_token>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _public_key_token_e__FixedBuffer
		{
			// Token: 0x06005596 RID: 21910 RVA: 0x0001E61D File Offset: 0x0001C81D
			// Note: this type is marked as 'beforefieldinit'.
			static _public_key_token_e__FixedBuffer()
			{
				Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "<public_key_token>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr);
				MonoAssemblyName._public_key_token_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06005597 RID: 21911 RVA: 0x0001E651 File Offset: 0x0001C851
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoAssemblyName._public_key_token_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040045C4 RID: 17860
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040045C5 RID: 17861
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
