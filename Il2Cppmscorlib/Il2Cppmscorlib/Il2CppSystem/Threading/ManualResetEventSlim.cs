using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000195 RID: 405
	public class ManualResetEventSlim : Object
	{
		// Token: 0x06001A48 RID: 6728 RVA: 0x000A14C0 File Offset: 0x0009F6C0
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEventSlim()
		{
			Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEventSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr);
			ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_SP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "DEFAULT_SPIN_SP");
			ManualResetEventSlim.NativeFieldInfoPtr_m_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_lock");
			ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_eventObj");
			ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "m_combinedState");
			ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SignalledState_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_ShiftCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SignalledState_ShiftCount");
			ManualResetEventSlim.NativeFieldInfoPtr_Dispose_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "Dispose_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SpinCountState_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_ShiftCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SpinCountState_ShiftCount");
			ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "SpinCountState_MaxValue");
			ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "NumWaitersState_BitMask");
			ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_ShiftCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "NumWaitersState_ShiftCount");
			ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "NumWaitersState_MaxValue");
			ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, "s_cancellationTokenCallback");
			ManualResetEventSlim.NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667881);
			ManualResetEventSlim.NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667882);
			ManualResetEventSlim.NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667883);
			ManualResetEventSlim.NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667884);
			ManualResetEventSlim.NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667885);
			ManualResetEventSlim.NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667886);
			ManualResetEventSlim.NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667887);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667888);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667889);
			ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667890);
			ManualResetEventSlim.NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667891);
			ManualResetEventSlim.NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667892);
			ManualResetEventSlim.NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667893);
			ManualResetEventSlim.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667894);
			ManualResetEventSlim.NativeMethodInfoPtr_Set_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667895);
			ManualResetEventSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667896);
			ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667897);
			ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667898);
			ManualResetEventSlim.NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667899);
			ManualResetEventSlim.NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667900);
			ManualResetEventSlim.NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667901);
			ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667902);
			ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr, 100667903);
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x000A17D4 File Offset: 0x0009F9D4
		public unsafe WaitHandle WaitHandle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1351908, RefRangeEnd = 1351909, XrefRangeStart = 1351904, XrefRangeEnd = 1351908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x000A1814 File Offset: 0x0009FA14
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x000A1850 File Offset: 0x0009FA50
		public unsafe bool IsSet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1351913, RefRangeEnd = 1351915, XrefRangeStart = 1351909, XrefRangeEnd = 1351913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351915, XrefRangeEnd = 1351917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x000A1890 File Offset: 0x0009FA90
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x000A18CC File Offset: 0x0009FACC
		public unsafe int SpinCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351917, XrefRangeEnd = 1351921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351921, XrefRangeEnd = 1351923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000A190C File Offset: 0x0009FB0C
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x000A1948 File Offset: 0x0009FB48
		public unsafe int Waiters
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1351927, RefRangeEnd = 1351929, XrefRangeStart = 1351923, XrefRangeEnd = 1351927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1351939, RefRangeEnd = 1351941, XrefRangeStart = 1351929, XrefRangeEnd = 1351939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x000A1988 File Offset: 0x0009FB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351941, XrefRangeEnd = 1351953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000A19C4 File Offset: 0x0009FBC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351965, RefRangeEnd = 1351967, XrefRangeStart = 1351953, XrefRangeEnd = 1351965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000A1A0C File Offset: 0x0009FC0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351985, RefRangeEnd = 1351987, XrefRangeStart = 1351967, XrefRangeEnd = 1351985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEventSlim(bool initialState, int spinCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEventSlim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000A1A64 File Offset: 0x0009FC64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351994, RefRangeEnd = 1351995, XrefRangeStart = 1351987, XrefRangeEnd = 1351994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(bool initialState, int spinCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spinCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000A1AB0 File Offset: 0x0009FCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351995, XrefRangeEnd = 1352002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLockObjectCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000A1AE4 File Offset: 0x0009FCE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352035, RefRangeEnd = 1352036, XrefRangeStart = 1352002, XrefRangeEnd = 1352035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LazyInitializeEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000A1B20 File Offset: 0x0009FD20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1352037, RefRangeEnd = 1352044, XrefRangeStart = 1352036, XrefRangeEnd = 1352037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000A1B54 File Offset: 0x0009FD54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1352064, RefRangeEnd = 1352065, XrefRangeStart = 1352044, XrefRangeEnd = 1352064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool duringCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref duringCancellation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Set_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000A1B94 File Offset: 0x0009FD94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1352150, RefRangeEnd = 1352152, XrefRangeStart = 1352065, XrefRangeEnd = 1352150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1352156, RefRangeEnd = 1352159, XrefRangeStart = 1352152, XrefRangeEnd = 1352156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000A1C28 File Offset: 0x0009FE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352159, XrefRangeEnd = 1352170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualResetEventSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000A1C74 File Offset: 0x0009FE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352170, XrefRangeEnd = 1352171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000A1CA8 File Offset: 0x0009FEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352171, XrefRangeEnd = 1352181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancellationTokenCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000A1CE0 File Offset: 0x0009FEE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1352194, RefRangeEnd = 1352197, XrefRangeStart = 1352181, XrefRangeEnd = 1352194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateBitsMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000A1D2C File Offset: 0x0009FF2C
		[CallerCount(0)]
		public unsafe static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightBitShiftCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000A1D88 File Offset: 0x0009FF88
		[CallerCount(0)]
		public unsafe static int ExtractStatePortion(int state, int mask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEventSlim.NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00008600 File Offset: 0x00006800
		public ManualResetEventSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x000A1DD4 File Offset: 0x0009FFD4
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x00008609 File Offset: 0x00006809
		public unsafe static int DEFAULT_SPIN_SP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_SP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_DEFAULT_SPIN_SP, (void*)(&value));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000A1DF0 File Offset: 0x0009FFF0
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x00008617 File Offset: 0x00006817
		public unsafe Object m_lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x000A1E20 File Offset: 0x000A0020
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x00008636 File Offset: 0x00006836
		public unsafe ManualResetEvent m_eventObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_eventObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x000A1E50 File Offset: 0x000A0050
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x00008655 File Offset: 0x00006855
		public unsafe int m_combinedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualResetEventSlim.NativeFieldInfoPtr_m_combinedState)) = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000A1E78 File Offset: 0x000A0078
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x00008670 File Offset: 0x00006870
		public unsafe static int SignalledState_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_BitMask, (void*)(&value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x000A1E94 File Offset: 0x000A0094
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000867E File Offset: 0x0000687E
		public unsafe static int SignalledState_ShiftCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_ShiftCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SignalledState_ShiftCount, (void*)(&value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0000868C File Offset: 0x0000688C
		public unsafe static int Dispose_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_Dispose_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_Dispose_BitMask, (void*)(&value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x000A1ECC File Offset: 0x000A00CC
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0000869A File Offset: 0x0000689A
		public unsafe static int SpinCountState_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_BitMask, (void*)(&value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x000A1EE8 File Offset: 0x000A00E8
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x000086A8 File Offset: 0x000068A8
		public unsafe static int SpinCountState_ShiftCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_ShiftCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_ShiftCount, (void*)(&value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x000A1F04 File Offset: 0x000A0104
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x000086B6 File Offset: 0x000068B6
		public unsafe static int SpinCountState_MaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_SpinCountState_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x000A1F20 File Offset: 0x000A0120
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x000086C4 File Offset: 0x000068C4
		public unsafe static int NumWaitersState_BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_BitMask, (void*)(&value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x000A1F3C File Offset: 0x000A013C
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x000086D2 File Offset: 0x000068D2
		public unsafe static int NumWaitersState_ShiftCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_ShiftCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_ShiftCount, (void*)(&value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x000A1F58 File Offset: 0x000A0158
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x000086E0 File Offset: 0x000068E0
		public unsafe static int NumWaitersState_MaxValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_NumWaitersState_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000A1F74 File Offset: 0x000A0174
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x000086EE File Offset: 0x000068EE
		public unsafe static Action<Object> s_cancellationTokenCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManualResetEventSlim.NativeFieldInfoPtr_s_cancellationTokenCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SPIN_SP;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr_m_lock;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeFieldInfoPtr_m_eventObj;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeFieldInfoPtr_m_combinedState;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeFieldInfoPtr_SignalledState_BitMask;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr_SignalledState_ShiftCount;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeFieldInfoPtr_Dispose_BitMask;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountState_BitMask;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountState_ShiftCount;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountState_MaxValue;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr_NumWaitersState_BitMask;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr_NumWaitersState_ShiftCount;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_NumWaitersState_MaxValue;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_s_cancellationTokenCallback;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitHandle_Public_get_WaitHandle_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSet_Public_get_Boolean_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSet_Private_set_Void_Boolean_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_get_SpinCount_Public_get_Int32_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_set_SpinCount_Private_set_Void_Int32_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_get_Waiters_Private_get_Int32_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_set_Waiters_Private_set_Void_Int32_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Int32_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLockObjectCreated_Private_Void_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_LazyInitializeEvent_Private_Boolean_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Boolean_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfDisposed_Private_Void_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_CancellationTokenCallback_Private_Static_Void_Object_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStateAtomically_Private_Void_Int32_Int32_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStatePortionAndShiftRight_Private_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStatePortion_Private_Static_Int32_Int32_Int32_0;
	}
}
