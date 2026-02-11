using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		// Token: 0x06001122 RID: 4386 RVA: 0x00076E60 File Offset: 0x00075060
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionEventArgs()
		{
			Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnhandledExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr);
			UnhandledExceptionEventArgs.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, "_exception");
			UnhandledExceptionEventArgs.NativeFieldInfoPtr__isTerminating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, "_isTerminating");
			UnhandledExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666316);
			UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666317);
			UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr, 100666318);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00076EF4 File Offset: 0x000750F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1327856, XrefRangeEnd = 1327861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnhandledExceptionEventArgs(Object exception, bool isTerminating)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTerminating;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00076F50 File Offset: 0x00075150
		public unsafe Object ExceptionObject
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00076F90 File Offset: 0x00075190
		public unsafe bool IsTerminating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionEventArgs.NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00005E5E File Offset: 0x0000405E
		public UnhandledExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00076FCC File Offset: 0x000751CC
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x00005E67 File Offset: 0x00004067
		public unsafe Object _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x00076FFC File Offset: 0x000751FC
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00005E86 File Offset: 0x00004086
		public unsafe bool _isTerminating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__isTerminating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnhandledExceptionEventArgs.NativeFieldInfoPtr__isTerminating)) = value;
			}
		}

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr__isTerminating;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionObject_Public_get_Object_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTerminating_Public_get_Boolean_0;
	}
}
