using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.match
{
	// Token: 0x02000027 RID: 39
	public static class MatchErrors : Object
	{
		// Token: 0x06000191 RID: 401 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		// Note: this type is marked as 'beforefieldinit'.
		static MatchErrors()
		{
			Il2CppClassPointerStore<MatchErrors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.match", "MatchErrors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchErrors>.NativeClassPtr);
			MatchErrors.NativeFieldInfoPtr_INFINITE_LOOP_DETECTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchErrors>.NativeClassPtr, "INFINITE_LOOP_DETECTED");
			MatchErrors.NativeFieldInfoPtr_SEQUENCE_COULD_NOT_BE_PARSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchErrors>.NativeClassPtr, "SEQUENCE_COULD_NOT_BE_PARSED");
			MatchErrors.NativeFieldInfoPtr_SERVER_CRASH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchErrors>.NativeClassPtr, "SERVER_CRASH");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002715 File Offset: 0x00000915
		public MatchErrors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000AA34 File Offset: 0x00008C34
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000271E File Offset: 0x0000091E
		public unsafe static int INFINITE_LOOP_DETECTED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MatchErrors.NativeFieldInfoPtr_INFINITE_LOOP_DETECTED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchErrors.NativeFieldInfoPtr_INFINITE_LOOP_DETECTED, (void*)(&value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000AA50 File Offset: 0x00008C50
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe static int SEQUENCE_COULD_NOT_BE_PARSED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MatchErrors.NativeFieldInfoPtr_SEQUENCE_COULD_NOT_BE_PARSED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchErrors.NativeFieldInfoPtr_SEQUENCE_COULD_NOT_BE_PARSED, (void*)(&value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000AA6C File Offset: 0x00008C6C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000273A File Offset: 0x0000093A
		public unsafe static int SERVER_CRASH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MatchErrors.NativeFieldInfoPtr_SERVER_CRASH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchErrors.NativeFieldInfoPtr_SERVER_CRASH, (void*)(&value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_INFINITE_LOOP_DETECTED;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_SEQUENCE_COULD_NOT_BE_PARSED;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_SERVER_CRASH;
	}
}
