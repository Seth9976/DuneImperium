using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E8 RID: 488
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x000B79C8 File Offset: 0x000B5BC8
		// Note: this type is marked as 'beforefieldinit'.
		static UnobservedTaskExceptionEventArgs()
		{
			Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "UnobservedTaskExceptionEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr);
			UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_exception");
			UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, "m_observed");
			UnobservedTaskExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr, 100668733);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000B7A34 File Offset: 0x000B5C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361957, XrefRangeEnd = 1361976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnobservedTaskExceptionEventArgs(AggregateException exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnobservedTaskExceptionEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnobservedTaskExceptionEventArgs.NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0000A67D File Offset: 0x0000887D
		public UnobservedTaskExceptionEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x000B7A80 File Offset: 0x000B5C80
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x0000A686 File Offset: 0x00008886
		public unsafe AggregateException m_exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0000A6A5 File Offset: 0x000088A5
		public unsafe bool m_observed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnobservedTaskExceptionEventArgs.NativeFieldInfoPtr_m_observed)) = value;
			}
		}

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_m_exception;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeFieldInfoPtr_m_observed;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AggregateException_0;
	}
}
