using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001AC RID: 428
	public class OSSpecificSynchronizationContext : SynchronizationContext
	{
		// Token: 0x06001BE3 RID: 7139 RVA: 0x000A70FC File Offset: 0x000A52FC
		// Note: this type is marked as 'beforefieldinit'.
		static OSSpecificSynchronizationContext()
		{
			Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "OSSpecificSynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr);
			OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "m_OSSynchronizationContext");
			OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "s_ContextCache");
			OSSpecificSynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668107);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668108);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668109);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668110);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668111);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668112);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668113);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100668114);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000A71F4 File Offset: 0x000A53F4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OSSpecificSynchronizationContext(Object osContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(osContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000A7240 File Offset: 0x000A5440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355731, XrefRangeEnd = 1355756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OSSpecificSynchronizationContext Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000A7274 File Offset: 0x000A5474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355756, XrefRangeEnd = 1355761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000A72C0 File Offset: 0x000A54C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355761, XrefRangeEnd = 1355776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000A7320 File Offset: 0x000A5520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355776, XrefRangeEnd = 1355804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000A7380 File Offset: 0x000A5580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355804, XrefRangeEnd = 1355813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvocationEntry(IntPtr arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000A73B4 File Offset: 0x000A55B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355813, XrefRangeEnd = 1355814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetOSContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x000A73E8 File Offset: 0x000A55E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355814, XrefRangeEnd = 1355815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostInternal(Object osSynchronizationContext, IntPtr callback, IntPtr arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(osSynchronizationContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callback;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00008F30 File Offset: 0x00007130
		public OSSpecificSynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x000A743C File Offset: 0x000A563C
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x00008F39 File Offset: 0x00007139
		public unsafe Object m_OSSynchronizationContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x000A746C File Offset: 0x000A566C
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00008F58 File Offset: 0x00007158
		public unsafe static ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, OSSpecificSynchronizationContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr_m_OSSynchronizationContext;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_s_ContextCache;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0;

		// Token: 0x0200060F RID: 1551
		public sealed class InvocationEntryDelegate : MulticastDelegate
		{
			// Token: 0x06005870 RID: 22640 RVA: 0x0001F7FA File Offset: 0x0001D9FA
			// Note: this type is marked as 'beforefieldinit'.
			static InvocationEntryDelegate()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "InvocationEntryDelegate");
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100668116);
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100668117);
			}

			// Token: 0x06005871 RID: 22641 RVA: 0x001969F4 File Offset: 0x00194BF4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1355724, RefRangeEnd = 1355726, XrefRangeStart = 1355721, XrefRangeEnd = 1355724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvocationEntryDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005872 RID: 22642 RVA: 0x00196A50 File Offset: 0x00194C50
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref arg;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005873 RID: 22643 RVA: 0x0001F838 File Offset: 0x0001DA38
			public InvocationEntryDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005874 RID: 22644 RVA: 0x0001F841 File Offset: 0x0001DA41
			public static implicit operator OSSpecificSynchronizationContext.InvocationEntryDelegate(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>(A_0);
			}

			// Token: 0x06005875 RID: 22645 RVA: 0x0001F849 File Offset: 0x0001DA49
			public static OSSpecificSynchronizationContext.InvocationEntryDelegate operator +(OSSpecificSynchronizationContext.InvocationEntryDelegate A_0, OSSpecificSynchronizationContext.InvocationEntryDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OSSpecificSynchronizationContext.InvocationEntryDelegate>();
			}

			// Token: 0x06005876 RID: 22646 RVA: 0x0001F857 File Offset: 0x0001DA57
			public static OSSpecificSynchronizationContext.InvocationEntryDelegate operator -(OSSpecificSynchronizationContext.InvocationEntryDelegate A_0, OSSpecificSynchronizationContext.InvocationEntryDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OSSpecificSynchronizationContext.InvocationEntryDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040048BE RID: 18622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040048BF RID: 18623
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;
		}

		// Token: 0x02000610 RID: 1552
		public class InvocationContext : Object
		{
			// Token: 0x06005877 RID: 22647 RVA: 0x00196A90 File Offset: 0x00194C90
			// Note: this type is marked as 'beforefieldinit'.
			static InvocationContext()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "InvocationContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr);
				OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, "m_Delegate");
				OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, "m_State");
				OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, 100668118);
				OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, 100668119);
			}

			// Token: 0x06005878 RID: 22648 RVA: 0x00196B0C File Offset: 0x00194D0C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvocationContext(SendOrPostCallback d, Object state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005879 RID: 22649 RVA: 0x00196B6C File Offset: 0x00194D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600587A RID: 22650 RVA: 0x0001F868 File Offset: 0x0001DA68
			public InvocationContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700168E RID: 5774
			// (get) Token: 0x0600587B RID: 22651 RVA: 0x00196BA0 File Offset: 0x00194DA0
			// (set) Token: 0x0600587C RID: 22652 RVA: 0x0001F871 File Offset: 0x0001DA71
			public unsafe SendOrPostCallback m_Delegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700168F RID: 5775
			// (get) Token: 0x0600587D RID: 22653 RVA: 0x00196BD0 File Offset: 0x00194DD0
			// (set) Token: 0x0600587E RID: 22654 RVA: 0x0001F890 File Offset: 0x0001DA90
			public unsafe Object m_State
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048C0 RID: 18624
			private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

			// Token: 0x040048C1 RID: 18625
			private static readonly IntPtr NativeFieldInfoPtr_m_State;

			// Token: 0x040048C2 RID: 18626
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0;

			// Token: 0x040048C3 RID: 18627
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}

		// Token: 0x02000611 RID: 1553
		[ObfuscatedName("System.Threading.OSSpecificSynchronizationContext+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600587F RID: 22655 RVA: 0x00196C00 File Offset: 0x00194E00
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr);
				OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, "<>9");
				OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, "<>9__3_0");
				OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, 100668121);
				OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, 100668122);
			}

			// Token: 0x06005880 RID: 22656 RVA: 0x00196C7C File Offset: 0x00194E7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005881 RID: 22657 RVA: 0x00196CB8 File Offset: 0x00194EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355726, XrefRangeEnd = 1355731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OSSpecificSynchronizationContext _Get_b__3_0(Object _osContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_osContext);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x06005882 RID: 22658 RVA: 0x0001F8AF File Offset: 0x0001DAAF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001690 RID: 5776
			// (get) Token: 0x06005883 RID: 22659 RVA: 0x00196D08 File Offset: 0x00194F08
			// (set) Token: 0x06005884 RID: 22660 RVA: 0x0001F8B8 File Offset: 0x0001DAB8
			public unsafe static OSSpecificSynchronizationContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001691 RID: 5777
			// (get) Token: 0x06005885 RID: 22661 RVA: 0x00196D30 File Offset: 0x00194F30
			// (set) Token: 0x06005886 RID: 22662 RVA: 0x0001F8CA File Offset: 0x0001DACA
			public unsafe static ConditionalWeakTable<Object, OSSpecificSynchronizationContext>.CreateValueCallback __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, OSSpecificSynchronizationContext>.CreateValueCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048C4 RID: 18628
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040048C5 RID: 18629
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040048C6 RID: 18630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048C7 RID: 18631
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0;
		}
	}
}
