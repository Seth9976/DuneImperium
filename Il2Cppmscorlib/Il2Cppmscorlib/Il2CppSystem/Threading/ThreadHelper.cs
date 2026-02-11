using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001AD RID: 429
	public class ThreadHelper : Object
	{
		// Token: 0x06001BF1 RID: 7153 RVA: 0x000A7494 File Offset: 0x000A5694
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadHelper()
		{
			Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr);
			ThreadHelper.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_start");
			ThreadHelper.NativeFieldInfoPtr__startArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_startArg");
			ThreadHelper.NativeFieldInfoPtr__executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_executionContext");
			ThreadHelper.NativeFieldInfoPtr__ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_ccb");
			ThreadHelper.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100668123);
			ThreadHelper.NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100668124);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100668125);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100668126);
			ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100668127);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000A7578 File Offset: 0x000A5778
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadHelper(Delegate start)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000A75C4 File Offset: 0x000A57C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExecutionContextHelper(ExecutionContext ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000A7608 File Offset: 0x000A5808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355815, XrefRangeEnd = 1355825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadStart_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000A7640 File Offset: 0x000A5840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355825, XrefRangeEnd = 1355838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThreadStart(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000A7684 File Offset: 0x000A5884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355838, XrefRangeEnd = 1355860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThreadStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadHelper.NativeMethodInfoPtr_ThreadStart_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00008F6A File Offset: 0x0000716A
		public ThreadHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000A76B8 File Offset: 0x000A58B8
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00008F73 File Offset: 0x00007173
		public unsafe Delegate _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x000A76E8 File Offset: 0x000A58E8
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x00008F92 File Offset: 0x00007192
		public unsafe Object _startArg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__startArg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__startArg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000A7718 File Offset: 0x000A5918
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x00008FB1 File Offset: 0x000071B1
		public unsafe ExecutionContext _executionContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__executionContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadHelper.NativeFieldInfoPtr__executionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000A7748 File Offset: 0x000A5948
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x00008FD0 File Offset: 0x000071D0
		public unsafe static ContextCallback _ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadHelper.NativeFieldInfoPtr__ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadHelper.NativeFieldInfoPtr__ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr__startArg;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeFieldInfoPtr__executionContext;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeFieldInfoPtr__ccb;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_0;
	}
}
