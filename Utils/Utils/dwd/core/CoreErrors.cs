using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core
{
	// Token: 0x02000024 RID: 36
	public static class CoreErrors : Object
	{
		// Token: 0x0600016B RID: 363 RVA: 0x0000A238 File Offset: 0x00008438
		// Note: this type is marked as 'beforefieldinit'.
		static CoreErrors()
		{
			Il2CppClassPointerStore<CoreErrors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core", "CoreErrors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreErrors>.NativeClassPtr);
			CoreErrors.NativeFieldInfoPtr_NONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreErrors>.NativeClassPtr, "NONE");
			CoreErrors.NativeFieldInfoPtr_UNEXPECTED_EXCEPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreErrors>.NativeClassPtr, "UNEXPECTED_EXCEPTION");
			CoreErrors.NativeFieldInfoPtr_GENERIC_INTERRUPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreErrors>.NativeClassPtr, "GENERIC_INTERRUPTION");
			CoreErrors.NativeFieldInfoPtr_GENERIC_DISCONNECTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreErrors>.NativeClassPtr, "GENERIC_DISCONNECTED");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002632 File Offset: 0x00000832
		public CoreErrors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000A2B8 File Offset: 0x000084B8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000263B File Offset: 0x0000083B
		public unsafe static int NONE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreErrors.NativeFieldInfoPtr_NONE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreErrors.NativeFieldInfoPtr_NONE, (void*)(&value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000A2D4 File Offset: 0x000084D4
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002649 File Offset: 0x00000849
		public unsafe static int UNEXPECTED_EXCEPTION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreErrors.NativeFieldInfoPtr_UNEXPECTED_EXCEPTION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreErrors.NativeFieldInfoPtr_UNEXPECTED_EXCEPTION, (void*)(&value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002657 File Offset: 0x00000857
		public unsafe static int GENERIC_INTERRUPTION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreErrors.NativeFieldInfoPtr_GENERIC_INTERRUPTION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreErrors.NativeFieldInfoPtr_GENERIC_INTERRUPTION, (void*)(&value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000A30C File Offset: 0x0000850C
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002665 File Offset: 0x00000865
		public unsafe static int GENERIC_DISCONNECTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CoreErrors.NativeFieldInfoPtr_GENERIC_DISCONNECTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreErrors.NativeFieldInfoPtr_GENERIC_DISCONNECTED, (void*)(&value));
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_NONE;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_UNEXPECTED_EXCEPTION;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_GENERIC_INTERRUPTION;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_GENERIC_DISCONNECTED;
	}
}
