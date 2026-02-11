using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000007 RID: 7
	public static class AsyncHelper : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00016580 File Offset: 0x00014780
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncHelper()
		{
			Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "AsyncHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr);
			AsyncHelper.NativeFieldInfoPtr_DoneTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTask");
			AsyncHelper.NativeFieldInfoPtr_DoneTaskTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskTrue");
			AsyncHelper.NativeFieldInfoPtr_DoneTaskFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskFalse");
			AsyncHelper.NativeFieldInfoPtr_DoneTaskZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncHelper>.NativeClassPtr, "DoneTaskZero");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002161 File Offset: 0x00000361
		public AsyncHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00016600 File Offset: 0x00014800
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000216A File Offset: 0x0000036A
		public unsafe static Task DoneTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00016628 File Offset: 0x00014828
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000217C File Offset: 0x0000037C
		public unsafe static Task<bool> DoneTaskTrue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskTrue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskTrue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00016650 File Offset: 0x00014850
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000218E File Offset: 0x0000038E
		public unsafe static Task<bool> DoneTaskFalse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskFalse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskFalse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00016678 File Offset: 0x00014878
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000021A0 File Offset: 0x000003A0
		public unsafe static Task<int> DoneTaskZero
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskZero, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncHelper.NativeFieldInfoPtr_DoneTaskZero, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_DoneTask;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_DoneTaskTrue;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_DoneTaskFalse;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_DoneTaskZero;
	}
}
