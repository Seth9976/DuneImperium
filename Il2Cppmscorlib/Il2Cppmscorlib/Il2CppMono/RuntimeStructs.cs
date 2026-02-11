using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000011 RID: 17
	public static class RuntimeStructs : Object
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002214 File Offset: 0x00000414
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeStructs()
		{
			Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeStructs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002239 File Offset: 0x00000439
		public RuntimeStructs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000560 RID: 1376
		[StructLayout(2)]
		public struct RemoteClass
		{
			// Token: 0x0600558E RID: 21902 RVA: 0x0018BB04 File Offset: 0x00189D04
			// Note: this type is marked as 'beforefieldinit'.
			static RemoteClass()
			{
				Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "RemoteClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr);
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_default_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "default_vtable");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_xdomain_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "xdomain_vtable");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_proxy_class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "proxy_class");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_proxy_class_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "proxy_class_name");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_interface_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "interface_count");
			}

			// Token: 0x0600558F RID: 21903 RVA: 0x0001E5B5 File Offset: 0x0001C7B5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, ref this));
			}

			// Token: 0x040045AC RID: 17836
			private static readonly IntPtr NativeFieldInfoPtr_default_vtable;

			// Token: 0x040045AD RID: 17837
			private static readonly IntPtr NativeFieldInfoPtr_xdomain_vtable;

			// Token: 0x040045AE RID: 17838
			private static readonly IntPtr NativeFieldInfoPtr_proxy_class;

			// Token: 0x040045AF RID: 17839
			private static readonly IntPtr NativeFieldInfoPtr_proxy_class_name;

			// Token: 0x040045B0 RID: 17840
			private static readonly IntPtr NativeFieldInfoPtr_interface_count;

			// Token: 0x040045B1 RID: 17841
			[FieldOffset(0)]
			public IntPtr default_vtable;

			// Token: 0x040045B2 RID: 17842
			[FieldOffset(8)]
			public IntPtr xdomain_vtable;

			// Token: 0x040045B3 RID: 17843
			[FieldOffset(16)]
			public IntPtr proxy_class;

			// Token: 0x040045B4 RID: 17844
			[FieldOffset(24)]
			public IntPtr proxy_class_name;

			// Token: 0x040045B5 RID: 17845
			[FieldOffset(32)]
			public uint interface_count;
		}

		// Token: 0x02000561 RID: 1377
		[StructLayout(2)]
		public struct MonoClass
		{
			// Token: 0x06005590 RID: 21904 RVA: 0x0001E5C7 File Offset: 0x0001C7C7
			// Note: this type is marked as 'beforefieldinit'.
			static MonoClass()
			{
				Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "MonoClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr);
			}

			// Token: 0x06005591 RID: 21905 RVA: 0x0001E5E7 File Offset: 0x0001C7E7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000562 RID: 1378
		[StructLayout(2)]
		public struct GenericParamInfo
		{
			// Token: 0x06005592 RID: 21906 RVA: 0x0018BB94 File Offset: 0x00189D94
			// Note: this type is marked as 'beforefieldinit'.
			static GenericParamInfo()
			{
				Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GenericParamInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr);
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_pklass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "pklass");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "name");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "flags");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "token");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "constraints");
			}

			// Token: 0x06005593 RID: 21907 RVA: 0x0001E5F9 File Offset: 0x0001C7F9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040045B6 RID: 17846
			private static readonly IntPtr NativeFieldInfoPtr_pklass;

			// Token: 0x040045B7 RID: 17847
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040045B8 RID: 17848
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x040045B9 RID: 17849
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x040045BA RID: 17850
			private static readonly IntPtr NativeFieldInfoPtr_constraints;

			// Token: 0x040045BB RID: 17851
			[FieldOffset(0)]
			public IntPtr pklass;

			// Token: 0x040045BC RID: 17852
			[FieldOffset(8)]
			public IntPtr name;

			// Token: 0x040045BD RID: 17853
			[FieldOffset(16)]
			public ushort flags;

			// Token: 0x040045BE RID: 17854
			[FieldOffset(20)]
			public uint token;

			// Token: 0x040045BF RID: 17855
			[FieldOffset(24)]
			public IntPtr constraints;
		}

		// Token: 0x02000563 RID: 1379
		[StructLayout(2)]
		public struct GPtrArray
		{
			// Token: 0x06005594 RID: 21908 RVA: 0x0018BC24 File Offset: 0x00189E24
			// Note: this type is marked as 'beforefieldinit'.
			static GPtrArray()
			{
				Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GPtrArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr);
				RuntimeStructs.GPtrArray.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, "data");
				RuntimeStructs.GPtrArray.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, "len");
			}

			// Token: 0x06005595 RID: 21909 RVA: 0x0001E60B File Offset: 0x0001C80B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, ref this));
			}

			// Token: 0x040045C0 RID: 17856
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040045C1 RID: 17857
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x040045C2 RID: 17858
			[FieldOffset(0)]
			public IntPtr data;

			// Token: 0x040045C3 RID: 17859
			[FieldOffset(8)]
			public int len;
		}
	}
}
