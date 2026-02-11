using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x020003A2 RID: 930
	public sealed class ExceptionDispatchInfo : Object
	{
		// Token: 0x0600389C RID: 14492 RVA: 0x001137FC File Offset: 0x001119FC
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionDispatchInfo()
		{
			Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "ExceptionDispatchInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr);
			ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_Exception");
			ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_stackTrace");
			ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671763);
			ExceptionDispatchInfo.NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671764);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671765);
			ExceptionDispatchInfo.NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671766);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671767);
			ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671768);
			ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671769);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x001138E0 File Offset: 0x00111AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392519, XrefRangeEnd = 1392538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo(Exception exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x0011392C File Offset: 0x00111B2C
		public unsafe Object BinaryStackTraceArray
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0011396C File Offset: 0x00111B6C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1392556, RefRangeEnd = 1392576, XrefRangeStart = 1392538, XrefRangeEnd = 1392556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExceptionDispatchInfo Capture(Exception source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x001139B0 File Offset: 0x00111BB0
		public unsafe Exception SourceException
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x001139F0 File Offset: 0x00111BF0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1392580, RefRangeEnd = 1392608, XrefRangeStart = 1392576, XrefRangeEnd = 1392580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00113A24 File Offset: 0x00111C24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1392611, RefRangeEnd = 1392622, XrefRangeStart = 1392608, XrefRangeEnd = 1392611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Throw(Exception source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr_Throw_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00113A5C File Offset: 0x00111C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392622, XrefRangeEnd = 1392625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionDispatchInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00014C2B File Offset: 0x00012E2B
		public ExceptionDispatchInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x00113A98 File Offset: 0x00111C98
		// (set) Token: 0x060038A6 RID: 14502 RVA: 0x00014C34 File Offset: 0x00012E34
		public unsafe Exception m_Exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_Exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x00113AC8 File Offset: 0x00111CC8
		// (set) Token: 0x060038A8 RID: 14504 RVA: 0x00014C53 File Offset: 0x00012E53
		public unsafe Object m_stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExceptionDispatchInfo.NativeFieldInfoPtr_m_stackTrace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeFieldInfoPtr_m_Exception;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeFieldInfoPtr_m_stackTrace;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Exception_0;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Void_0;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Static_Void_Exception_0;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
