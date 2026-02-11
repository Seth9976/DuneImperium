using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.errorInfo
{
	// Token: 0x02000028 RID: 40
	public class ErrorLogger : Object
	{
		// Token: 0x06000199 RID: 409 RVA: 0x0000AA88 File Offset: 0x00008C88
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorLogger()
		{
			Il2CppClassPointerStore<ErrorLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.errorInfo", "ErrorLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorLogger>.NativeClassPtr);
			ErrorLogger.NativeMethodInfoPtr_dwd_core_errorInfo_IHandleErrorInfo_Handle_Private_Virtual_Final_New_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogger>.NativeClassPtr, 100663541);
			ErrorLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogger>.NativeClassPtr, 100663542);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181247, XrefRangeEnd = 1181259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_errorInfo_IHandleErrorInfo_Handle(ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogger.NativeMethodInfoPtr_dwd_core_errorInfo_IHandleErrorInfo_Handle_Private_Virtual_Final_New_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000AB28 File Offset: 0x00008D28
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorLogger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorLogger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002748 File Offset: 0x00000948
		public ErrorLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_errorInfo_IHandleErrorInfo_Handle_Private_Virtual_Final_New_Void_ErrorInfo_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
