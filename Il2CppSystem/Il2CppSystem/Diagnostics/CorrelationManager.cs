using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200008F RID: 143
	public class CorrelationManager : Object
	{
		// Token: 0x06000AB1 RID: 2737 RVA: 0x00044D70 File Offset: 0x00042F70
		// Note: this type is marked as 'beforefieldinit'.
		static CorrelationManager()
		{
			Il2CppClassPointerStore<CorrelationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "CorrelationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CorrelationManager>.NativeClassPtr);
			CorrelationManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrelationManager>.NativeClassPtr, 100664904);
			CorrelationManager.NativeMethodInfoPtr_get_LogicalOperationStack_Public_get_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrelationManager>.NativeClassPtr, 100664905);
			CorrelationManager.NativeMethodInfoPtr_GetLogicalOperationStack_Private_Stack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrelationManager>.NativeClassPtr, 100664906);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00044DDC File Offset: 0x00042FDC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CorrelationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CorrelationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorrelationManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00044E18 File Offset: 0x00043018
		public unsafe Stack LogicalOperationStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442645, XrefRangeEnd = 442655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorrelationManager.NativeMethodInfoPtr_get_LogicalOperationStack_Public_get_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr3) : null;
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00044E58 File Offset: 0x00043058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stack GetLogicalOperationStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorrelationManager.NativeMethodInfoPtr_GetLogicalOperationStack_Private_Stack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr3) : null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00005BDF File Offset: 0x00003DDF
		public CorrelationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalOperationStack_Public_get_Stack_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_GetLogicalOperationStack_Private_Stack_0;
	}
}
