using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000159 RID: 345
	public class MonoAsyncCall : Object
	{
		// Token: 0x06001774 RID: 6004 RVA: 0x00095BB4 File Offset: 0x00093DB4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoAsyncCall()
		{
			Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoAsyncCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr);
			MonoAsyncCall.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "msg");
			MonoAsyncCall.NativeFieldInfoPtr_cb_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "cb_method");
			MonoAsyncCall.NativeFieldInfoPtr_cb_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "cb_target");
			MonoAsyncCall.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "state");
			MonoAsyncCall.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "res");
			MonoAsyncCall.NativeFieldInfoPtr_out_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, "out_args");
			MonoAsyncCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr, 100667401);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00095C70 File Offset: 0x00093E70
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoAsyncCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoAsyncCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoAsyncCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000076A7 File Offset: 0x000058A7
		public MonoAsyncCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00095CAC File Offset: 0x00093EAC
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x000076B0 File Offset: 0x000058B0
		public unsafe Object msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_msg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_msg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00095CDC File Offset: 0x00093EDC
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x000076CF File Offset: 0x000058CF
		public unsafe IntPtr cb_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_method)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x00095D04 File Offset: 0x00093F04
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x000076EA File Offset: 0x000058EA
		public unsafe Object cb_target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_cb_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00095D34 File Offset: 0x00093F34
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x00007709 File Offset: 0x00005909
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x00095D64 File Offset: 0x00093F64
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x00007728 File Offset: 0x00005928
		public unsafe Object res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_res);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_res), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00095D94 File Offset: 0x00093F94
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x00007747 File Offset: 0x00005947
		public unsafe Object out_args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_out_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoAsyncCall.NativeFieldInfoPtr_out_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr_msg;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr_cb_method;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr_cb_target;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeFieldInfoPtr_out_args;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
