using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B5 RID: 437
	public static class ThreadPoolGlobals : Object
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x000A9240 File Offset: 0x000A7440
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolGlobals()
		{
			Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolGlobals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr);
			ThreadPoolGlobals.NativeFieldInfoPtr_processorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "processorCount");
			ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "vmTpInitialized");
			ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "enableWorkerTracking");
			ThreadPoolGlobals.NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolGlobals>.NativeClassPtr, "workQueue");
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000091D4 File Offset: 0x000073D4
		public ThreadPoolGlobals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x000A92C0 File Offset: 0x000A74C0
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x000091DD File Offset: 0x000073DD
		public unsafe static int processorCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_processorCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_processorCount, (void*)(&value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x000A92DC File Offset: 0x000A74DC
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x000091EB File Offset: 0x000073EB
		public unsafe static bool vmTpInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_vmTpInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x000A92F8 File Offset: 0x000A74F8
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x000091F9 File Offset: 0x000073F9
		public unsafe static bool enableWorkerTracking
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_enableWorkerTracking, (void*)(&value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x000A9314 File Offset: 0x000A7514
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x00009207 File Offset: 0x00007407
		public unsafe static ThreadPoolWorkQueue workQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolGlobals.NativeFieldInfoPtr_workQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolGlobals.NativeFieldInfoPtr_workQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_processorCount;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr_vmTpInitialized;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr_enableWorkerTracking;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr_workQueue;
	}
}
