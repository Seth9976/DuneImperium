using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000194 RID: 404
	public sealed class CancellationToken : ValueType
	{
		// Token: 0x06001A31 RID: 6705 RVA: 0x000A0DD4 File Offset: 0x0009EFD4
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationToken()
		{
			Il2CppClassPointerStore<CancellationToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr);
			CancellationToken.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "_source");
			CancellationToken.NativeFieldInfoPtr_s_actionToActionObjShunt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "s_actionToActionObjShunt");
			CancellationToken.NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667861);
			CancellationToken.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667862);
			CancellationToken.NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667863);
			CancellationToken.NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667864);
			CancellationToken.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667865);
			CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667866);
			CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667867);
			CancellationToken.NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667868);
			CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667869);
			CancellationToken.NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667870);
			CancellationToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667871);
			CancellationToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667872);
			CancellationToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667873);
			CancellationToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667874);
			CancellationToken.NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667875);
			CancellationToken.NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, 100667876);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x000A0F6C File Offset: 0x0009F16C
		public unsafe static CancellationToken None
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x000A0F98 File Offset: 0x0009F198
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(121)]
			[CachedScanResults(RefRangeStart = 1351647, RefRangeEnd = 1351768, XrefRangeStart = 1351647, XrefRangeEnd = 1351647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000A0FDC File Offset: 0x0009F1DC
		public unsafe bool CanBeCanceled
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 608772, RefRangeEnd = 608784, XrefRangeStart = 608772, XrefRangeEnd = 608784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000A1020 File Offset: 0x0009F220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationToken(CancellationTokenSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000A1070 File Offset: 0x0009F270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351777, RefRangeEnd = 1351779, XrefRangeStart = 1351768, XrefRangeEnd = 1351777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationToken(bool canceled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000A10BC File Offset: 0x0009F2BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1351785, RefRangeEnd = 1351789, XrefRangeStart = 1351779, XrefRangeEnd = 1351785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationTokenRegistration(intPtr);
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000A110C File Offset: 0x0009F30C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1351793, RefRangeEnd = 1351801, XrefRangeStart = 1351789, XrefRangeEnd = 1351793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action<Object> callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_1_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000A116C File Offset: 0x0009F36C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1351805, RefRangeEnd = 1351811, XrefRangeStart = 1351801, XrefRangeEnd = 1351805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration InternalRegisterWithoutEC(Action<Object> callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x000A11CC File Offset: 0x0009F3CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1351819, RefRangeEnd = 1351827, XrefRangeStart = 1351811, XrefRangeEnd = 1351819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationTokenRegistration Register(Action<Object> callback, Object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSynchronizationContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CancellationTokenRegistration(intPtr);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000A1248 File Offset: 0x0009F448
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1309270, RefRangeEnd = 1309279, XrefRangeStart = 1309270, XrefRangeEnd = 1309279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CancellationToken other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000A12A0 File Offset: 0x0009F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351827, XrefRangeEnd = 1351832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000A12F4 File Offset: 0x0009F4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351832, XrefRangeEnd = 1351837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000A1338 File Offset: 0x0009F538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351840, RefRangeEnd = 1351842, XrefRangeStart = 1351837, XrefRangeEnd = 1351840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CancellationToken left, CancellationToken right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000A1398 File Offset: 0x0009F598
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1351845, RefRangeEnd = 1351848, XrefRangeStart = 1351842, XrefRangeEnd = 1351845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CancellationToken left, CancellationToken right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000A13F8 File Offset: 0x0009F5F8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1351852, RefRangeEnd = 1351884, XrefRangeStart = 1351848, XrefRangeEnd = 1351852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfCancellationRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000A1430 File Offset: 0x0009F630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351884, XrefRangeEnd = 1351904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOperationCanceledException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000085B4 File Offset: 0x000067B4
		public CancellationToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x000085BD File Offset: 0x000067BD
		public CancellationToken()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr))
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x000A1468 File Offset: 0x0009F668
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x000085CF File Offset: 0x000067CF
		public unsafe CancellationTokenSource _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationToken.NativeFieldInfoPtr__source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationToken.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x000A1498 File Offset: 0x0009F698
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x000085EE File Offset: 0x000067EE
		public unsafe static Action<Object> s_actionToActionObjShunt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CancellationToken.NativeFieldInfoPtr_s_actionToActionObjShunt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CancellationToken.NativeFieldInfoPtr_s_actionToActionObjShunt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_s_actionToActionObjShunt;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_CancellationToken_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Public_get_Boolean_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeCanceled_Public_get_Boolean_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationTokenSource_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_1_Object_Object_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterWithoutEC_Internal_CancellationTokenRegistration_Action_1_Object_Object_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_CancellationTokenRegistration_Action_1_Object_Object_Boolean_Boolean_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_CancellationToken_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CancellationToken_CancellationToken_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CancellationToken_CancellationToken_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfCancellationRequested_Public_Void_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOperationCanceledException_Private_Void_0;

		// Token: 0x02000604 RID: 1540
		[ObfuscatedName("System.Threading.CancellationToken+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600581C RID: 22556 RVA: 0x00195AF8 File Offset: 0x00193CF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CancellationToken.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationToken.__c>.NativeClassPtr);
				CancellationToken.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationToken.__c>.NativeClassPtr, "<>9");
				CancellationToken.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken.__c>.NativeClassPtr, 100667879);
				CancellationToken.__c.NativeMethodInfoPtr___cctor_b__26_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationToken.__c>.NativeClassPtr, 100667880);
			}

			// Token: 0x0600581D RID: 22557 RVA: 0x00195B60 File Offset: 0x00193D60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationToken.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600581E RID: 22558 RVA: 0x00195B9C File Offset: 0x00193D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351643, XrefRangeEnd = 1351647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__26_0(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationToken.__c.NativeMethodInfoPtr___cctor_b__26_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600581F RID: 22559 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001675 RID: 5749
			// (get) Token: 0x06005820 RID: 22560 RVA: 0x00195BE0 File Offset: 0x00193DE0
			// (set) Token: 0x06005821 RID: 22561 RVA: 0x0001F4AD File Offset: 0x0001D6AD
			public unsafe static CancellationToken.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CancellationToken.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationToken.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CancellationToken.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400488A RID: 18570
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400488B RID: 18571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400488C RID: 18572
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__26_0_Internal_Void_Object_0;
		}
	}
}
