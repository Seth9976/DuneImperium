using System;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.alerts
{
	// Token: 0x0200021B RID: 539
	public class AlertQueue : DataProvider
	{
		// Token: 0x06001D71 RID: 7537 RVA: 0x00088260 File Offset: 0x00086460
		// Note: this type is marked as 'beforefieldinit'.
		static AlertQueue()
		{
			Il2CppClassPointerStore<AlertQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.alerts", "AlertQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr);
			AlertQueue.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr, "queue");
			AlertQueue.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr, 100668038);
			AlertQueue.NativeMethodInfoPtr_Enqueue_Public_Void_Alert_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr, 100668039);
			AlertQueue.NativeMethodInfoPtr_Dequeue_Public_Alert_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr, 100668040);
			AlertQueue.NativeMethodInfoPtr_Peek_Public_Alert_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr, 100668041);
			AlertQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr, 100668042);
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00088308 File Offset: 0x00086508
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886405, XrefRangeEnd = 886406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlertQueue.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00088344 File Offset: 0x00086544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886406, XrefRangeEnd = 886411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(Alert alert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlertQueue.NativeMethodInfoPtr_Enqueue_Public_Void_Alert_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00088388 File Offset: 0x00086588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886411, XrefRangeEnd = 886415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alert Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlertQueue.NativeMethodInfoPtr_Dequeue_Public_Alert_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Alert>(intPtr3) : null;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x000883C8 File Offset: 0x000865C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886415, XrefRangeEnd = 886419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alert Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlertQueue.NativeMethodInfoPtr_Peek_Public_Alert_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Alert>(intPtr3) : null;
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00088408 File Offset: 0x00086608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886419, XrefRangeEnd = 886427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlertQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlertQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlertQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0000C8CC File Offset: 0x0000AACC
		public AlertQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00088444 File Offset: 0x00086644
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000C8D5 File Offset: 0x0000AAD5
		public unsafe Queue<Alert> queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlertQueue.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Alert>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlertQueue.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_Alert_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Alert_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Alert_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
