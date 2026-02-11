using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.util
{
	// Token: 0x02000092 RID: 146
	public class RefCounted : Object
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x0003AC24 File Offset: 0x00038E24
		// Note: this type is marked as 'beforefieldinit'.
		static RefCounted()
		{
			Il2CppClassPointerStore<RefCounted>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "RefCounted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefCounted>.NativeClassPtr);
			RefCounted.NativeFieldInfoPtr__refCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, "<refCount>k__BackingField");
			RefCounted.NativeFieldInfoPtr_cleanupHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, "cleanupHandler");
			RefCounted.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, "id");
			RefCounted.NativeMethodInfoPtr_get_refCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664730);
			RefCounted.NativeMethodInfoPtr_set_refCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664731);
			RefCounted.NativeMethodInfoPtr__ctor_Protected_Void_CleanupHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664732);
			RefCounted.NativeMethodInfoPtr_IncrementRefCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664733);
			RefCounted.NativeMethodInfoPtr_DecrementRefCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664734);
			RefCounted.NativeMethodInfoPtr_DecrementAndCleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664735);
			RefCounted.NativeMethodInfoPtr_ValidateRefCounts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, 100664736);
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0003AD1C File Offset: 0x00038F1C
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0003AD58 File Offset: 0x00038F58
		public unsafe int refCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr_get_refCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr_set_refCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0003AD98 File Offset: 0x00038F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 862748, RefRangeEnd = 862749, XrefRangeStart = 862743, XrefRangeEnd = 862748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefCounted(RefCounted.CleanupHandler handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefCounted>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr__ctor_Protected_Void_CleanupHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0003ADE4 File Offset: 0x00038FE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334680, RefRangeEnd = 334682, XrefRangeStart = 334680, XrefRangeEnd = 334682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementRefCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr_IncrementRefCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0003AE18 File Offset: 0x00039018
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334682, RefRangeEnd = 334686, XrefRangeStart = 334682, XrefRangeEnd = 334686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementRefCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr_DecrementRefCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0003AE4C File Offset: 0x0003904C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 862749, RefRangeEnd = 862756, XrefRangeStart = 862749, XrefRangeEnd = 862749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementAndCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr_DecrementAndCleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0003AE80 File Offset: 0x00039080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862756, XrefRangeEnd = 862768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateRefCounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.NativeMethodInfoPtr_ValidateRefCounts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00005A83 File Offset: 0x00003C83
		public RefCounted(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0003AEB4 File Offset: 0x000390B4
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00005A8C File Offset: 0x00003C8C
		public unsafe int _refCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefCounted.NativeFieldInfoPtr__refCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefCounted.NativeFieldInfoPtr__refCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003AEDC File Offset: 0x000390DC
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00005AA7 File Offset: 0x00003CA7
		public unsafe RefCounted.CleanupHandler cleanupHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefCounted.NativeFieldInfoPtr_cleanupHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RefCounted.CleanupHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefCounted.NativeFieldInfoPtr_cleanupHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0003AF0C File Offset: 0x0003910C
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00005AC6 File Offset: 0x00003CC6
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefCounted.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefCounted.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr__refCount_k__BackingField;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_cleanupHandler;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_get_refCount_Public_get_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_set_refCount_Private_set_Void_Int32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_CleanupHandler_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_IncrementRefCount_Public_Void_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_DecrementRefCount_Public_Void_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_DecrementAndCleanup_Public_Void_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRefCounts_Public_Void_0;

		// Token: 0x0200028E RID: 654
		public sealed class CleanupHandler : MulticastDelegate
		{
			// Token: 0x06001F62 RID: 8034 RVA: 0x0008E7A8 File Offset: 0x0008C9A8
			// Note: this type is marked as 'beforefieldinit'.
			static CleanupHandler()
			{
				Il2CppClassPointerStore<RefCounted.CleanupHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RefCounted>.NativeClassPtr, "CleanupHandler");
				RefCounted.CleanupHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted.CleanupHandler>.NativeClassPtr, 100664737);
				RefCounted.CleanupHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RefCounted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted.CleanupHandler>.NativeClassPtr, 100664738);
				RefCounted.CleanupHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RefCounted_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted.CleanupHandler>.NativeClassPtr, 100664739);
				RefCounted.CleanupHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefCounted.CleanupHandler>.NativeClassPtr, 100664740);
			}

			// Token: 0x06001F63 RID: 8035 RVA: 0x0008E81C File Offset: 0x0008CA1C
			[CallerCount(333)]
			[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CleanupHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefCounted.CleanupHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.CleanupHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F64 RID: 8036 RVA: 0x0008E878 File Offset: 0x0008CA78
			[CallerCount(0)]
			public unsafe void Invoke(RefCounted refCounted)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(refCounted);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.CleanupHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RefCounted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F65 RID: 8037 RVA: 0x0008E8BC File Offset: 0x0008CABC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(RefCounted refCounted, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(refCounted);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.CleanupHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RefCounted_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F66 RID: 8038 RVA: 0x0008E930 File Offset: 0x0008CB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefCounted.CleanupHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F67 RID: 8039 RVA: 0x0000D60E File Offset: 0x0000B80E
			public CleanupHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F68 RID: 8040 RVA: 0x0000D617 File Offset: 0x0000B817
			public static implicit operator RefCounted.CleanupHandler(Action<RefCounted> A_0)
			{
				return DelegateSupport.ConvertDelegate<RefCounted.CleanupHandler>(A_0);
			}

			// Token: 0x06001F69 RID: 8041 RVA: 0x0000D61F File Offset: 0x0000B81F
			public static RefCounted.CleanupHandler operator +(RefCounted.CleanupHandler A_0, RefCounted.CleanupHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RefCounted.CleanupHandler>();
			}

			// Token: 0x06001F6A RID: 8042 RVA: 0x0000D62D File Offset: 0x0000B82D
			public static RefCounted.CleanupHandler operator -(RefCounted.CleanupHandler A_0, RefCounted.CleanupHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RefCounted.CleanupHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RefCounted_0;

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RefCounted_AsyncCallback_Object_0;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
