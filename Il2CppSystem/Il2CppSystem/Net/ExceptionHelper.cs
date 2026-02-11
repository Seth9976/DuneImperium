using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B8 RID: 440
	public static class ExceptionHelper : Object
	{
		// Token: 0x06001B1B RID: 6939 RVA: 0x00086434 File Offset: 0x00084634
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHelper()
		{
			Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ExceptionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr);
			ExceptionHelper.NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100667494);
			ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100667495);
			ExceptionHelper.NativeMethodInfoPtr_get_TimeoutException_Internal_Static_get_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100667496);
			ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100667497);
			ExceptionHelper.NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100667498);
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x000864C8 File Offset: 0x000846C8
		public unsafe static NotImplementedException MethodNotImplementedException
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 474531, RefRangeEnd = 474540, XrefRangeStart = 474524, XrefRangeEnd = 474531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000864FC File Offset: 0x000846FC
		public unsafe static NotImplementedException PropertyNotImplementedException
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 474547, RefRangeEnd = 474565, XrefRangeStart = 474540, XrefRangeEnd = 474547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x00086530 File Offset: 0x00084730
		public unsafe static WebException TimeoutException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474565, XrefRangeEnd = 474571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_TimeoutException_Internal_Static_get_WebException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00086564 File Offset: 0x00084764
		public unsafe static NotSupportedException PropertyNotSupportedException
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 474578, RefRangeEnd = 474581, XrefRangeStart = 474571, XrefRangeEnd = 474578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr3) : null;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00086598 File Offset: 0x00084798
		public unsafe static WebException RequestAbortedException
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 474588, RefRangeEnd = 474592, XrefRangeStart = 474581, XrefRangeEnd = 474588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0000BA22 File Offset: 0x00009C22
		public ExceptionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeoutException_Internal_Static_get_WebException_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0;
	}
}
