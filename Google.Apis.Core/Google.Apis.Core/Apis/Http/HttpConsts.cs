using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Http
{
	// Token: 0x0200002C RID: 44
	public static class HttpConsts : Object
	{
		// Token: 0x06000200 RID: 512 RVA: 0x0000B998 File Offset: 0x00009B98
		// Note: this type is marked as 'beforefieldinit'.
		static HttpConsts()
		{
			Il2CppClassPointerStore<HttpConsts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "HttpConsts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpConsts>.NativeClassPtr);
			HttpConsts.NativeFieldInfoPtr_Get = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConsts>.NativeClassPtr, "Get");
			HttpConsts.NativeFieldInfoPtr_Delete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConsts>.NativeClassPtr, "Delete");
			HttpConsts.NativeFieldInfoPtr_Put = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConsts>.NativeClassPtr, "Put");
			HttpConsts.NativeFieldInfoPtr_Post = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConsts>.NativeClassPtr, "Post");
			HttpConsts.NativeFieldInfoPtr_Patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpConsts>.NativeClassPtr, "Patch");
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002C41 File Offset: 0x00000E41
		public HttpConsts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000BA2C File Offset: 0x00009C2C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002C4A File Offset: 0x00000E4A
		public unsafe static string Get
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpConsts.NativeFieldInfoPtr_Get, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpConsts.NativeFieldInfoPtr_Get, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000BA4C File Offset: 0x00009C4C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002C5C File Offset: 0x00000E5C
		public unsafe static string Delete
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpConsts.NativeFieldInfoPtr_Delete, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpConsts.NativeFieldInfoPtr_Delete, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000BA6C File Offset: 0x00009C6C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002C6E File Offset: 0x00000E6E
		public unsafe static string Put
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpConsts.NativeFieldInfoPtr_Put, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpConsts.NativeFieldInfoPtr_Put, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000BA8C File Offset: 0x00009C8C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002C80 File Offset: 0x00000E80
		public unsafe static string Post
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpConsts.NativeFieldInfoPtr_Post, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpConsts.NativeFieldInfoPtr_Post, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000BAAC File Offset: 0x00009CAC
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002C92 File Offset: 0x00000E92
		public unsafe static string Patch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpConsts.NativeFieldInfoPtr_Patch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpConsts.NativeFieldInfoPtr_Patch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_Get;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_Delete;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_Put;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_Post;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_Patch;
	}
}
