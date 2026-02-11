using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001AB RID: 427
	public class SynchronizationContext : Object
	{
		// Token: 0x06001BC7 RID: 7111 RVA: 0x000A6A74 File Offset: 0x000A4C74
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContext()
		{
			Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr);
			SynchronizationContext.NativeFieldInfoPtr__props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "_props");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType1");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType2");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType3");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType4");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType5");
			SynchronizationContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668093);
			SynchronizationContext.NativeMethodInfoPtr_IsWaitNotificationRequired_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668094);
			SynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668095);
			SynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668096);
			SynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668097);
			SynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668098);
			SynchronizationContext.NativeMethodInfoPtr_Wait_Public_Virtual_New_Int32_Il2CppStructArray_1_IntPtr_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668099);
			SynchronizationContext.NativeMethodInfoPtr_WaitHelper_Protected_Static_Int32_Il2CppStructArray_1_IntPtr_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668100);
			SynchronizationContext.NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668101);
			SynchronizationContext.NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668102);
			SynchronizationContext.NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668103);
			SynchronizationContext.NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668104);
			SynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668105);
			SynchronizationContext.NativeMethodInfoPtr_get_CurrentExplicit_Internal_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100668106);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000A6C34 File Offset: 0x000A4E34
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000A6C70 File Offset: 0x000A4E70
		[CallerCount(0)]
		public unsafe bool IsWaitNotificationRequired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_IsWaitNotificationRequired_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000A6CAC File Offset: 0x000A4EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355615, XrefRangeEnd = 1355616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(SendOrPostCallback d, Object state)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000A6D0C File Offset: 0x000A4F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355616, XrefRangeEnd = 1355623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Post(SendOrPostCallback d, Object state)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000A6D6C File Offset: 0x000A4F6C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OperationStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000A6DA8 File Offset: 0x000A4FA8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000A6DE4 File Offset: 0x000A4FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355623, XrefRangeEnd = 1355635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Wait(Il2CppStructArray<IntPtr> waitHandles, bool waitAll, int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitAll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Wait_Public_Virtual_New_Int32_Il2CppStructArray_1_IntPtr_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000A6E58 File Offset: 0x000A5058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355635, XrefRangeEnd = 1355642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitHelper(Il2CppStructArray<IntPtr> waitHandles, bool waitAll, int millisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitAll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_WaitHelper_Protected_Static_Int32_Il2CppStructArray_1_IntPtr_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x000A6EB8 File Offset: 0x000A50B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1355656, RefRangeEnd = 1355657, XrefRangeStart = 1355642, XrefRangeEnd = 1355656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syncContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x000A6EF0 File Offset: 0x000A50F0
		public unsafe static SynchronizationContext Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1355663, RefRangeEnd = 1355678, XrefRangeStart = 1355657, XrefRangeEnd = 1355663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000A6F24 File Offset: 0x000A5124
		public unsafe static SynchronizationContext CurrentNoFlow
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1355684, RefRangeEnd = 1355686, XrefRangeStart = 1355678, XrefRangeEnd = 1355684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000A6F58 File Offset: 0x000A5158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1355714, RefRangeEnd = 1355716, XrefRangeStart = 1355686, XrefRangeEnd = 1355714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SynchronizationContext GetThreadLocalContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000A6F8C File Offset: 0x000A518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355716, XrefRangeEnd = 1355720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x000A6FD8 File Offset: 0x000A51D8
		public unsafe static SynchronizationContext CurrentExplicit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1355720, XrefRangeEnd = 1355721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_CurrentExplicit_Internal_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00008EB2 File Offset: 0x000070B2
		public SynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x000A700C File Offset: 0x000A520C
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x00008EBB File Offset: 0x000070BB
		public unsafe SynchronizationContextProperties _props
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContext.NativeFieldInfoPtr__props);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContext.NativeFieldInfoPtr__props)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000A7034 File Offset: 0x000A5234
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x00008ED6 File Offset: 0x000070D6
		public unsafe static Type s_cachedPreparedType1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x000A705C File Offset: 0x000A525C
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x00008EE8 File Offset: 0x000070E8
		public unsafe static Type s_cachedPreparedType2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x000A7084 File Offset: 0x000A5284
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x00008EFA File Offset: 0x000070FA
		public unsafe static Type s_cachedPreparedType3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x000A70AC File Offset: 0x000A52AC
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00008F0C File Offset: 0x0000710C
		public unsafe static Type s_cachedPreparedType4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000A70D4 File Offset: 0x000A52D4
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x00008F1E File Offset: 0x0000711E
		public unsafe static Type s_cachedPreparedType5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr__props;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType1;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType2;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType3;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType4;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType5;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_IsWaitNotificationRequired_Public_Boolean_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Virtual_New_Int32_Il2CppStructArray_1_IntPtr_Boolean_Int32_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_WaitHelper_Protected_Static_Int32_Il2CppStructArray_1_IntPtr_Boolean_Int32_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentExplicit_Internal_Static_get_SynchronizationContext_0;
	}
}
