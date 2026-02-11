using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.await
{
	// Token: 0x02000207 RID: 519
	public class SimpleUnitySafeAwaiter : Object
	{
		// Token: 0x06001CA5 RID: 7333 RVA: 0x0008527C File Offset: 0x0008347C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleUnitySafeAwaiter()
		{
			Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.await", "SimpleUnitySafeAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr);
			SimpleUnitySafeAwaiter.NativeFieldInfoPtr__IsCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, "<IsCompleted>k__BackingField");
			SimpleUnitySafeAwaiter.NativeFieldInfoPtr_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, "exception");
			SimpleUnitySafeAwaiter.NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, "_continuation");
			SimpleUnitySafeAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, 100667912);
			SimpleUnitySafeAwaiter.NativeMethodInfoPtr_set_IsCompleted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, 100667913);
			SimpleUnitySafeAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, 100667914);
			SimpleUnitySafeAwaiter.NativeMethodInfoPtr_Complete_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, 100667915);
			SimpleUnitySafeAwaiter.NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, 100667916);
			SimpleUnitySafeAwaiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr, 100667917);
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00085360 File Offset: 0x00083560
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0008539C File Offset: 0x0008359C
		public unsafe bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter.NativeMethodInfoPtr_set_IsCompleted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x000853DC File Offset: 0x000835DC
		[CallerCount(0)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00085410 File Offset: 0x00083610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885916, XrefRangeEnd = 885918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter.NativeMethodInfoPtr_Complete_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00085454 File Offset: 0x00083654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_CompilerServices_INotifyCompletion_OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter.NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00085498 File Offset: 0x00083698
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleUnitySafeAwaiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleUnitySafeAwaiter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleUnitySafeAwaiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0000C467 File Offset: 0x0000A667
		public SimpleUnitySafeAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x000854D4 File Offset: 0x000836D4
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0000C470 File Offset: 0x0000A670
		public unsafe bool _IsCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter.NativeFieldInfoPtr__IsCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter.NativeFieldInfoPtr__IsCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x000854FC File Offset: 0x000836FC
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x0000C48B File Offset: 0x0000A68B
		public unsafe Exception exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter.NativeFieldInfoPtr_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter.NativeFieldInfoPtr_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0008552C File Offset: 0x0008372C
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x0000C4AA File Offset: 0x0000A6AA
		public unsafe Action _continuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter.NativeFieldInfoPtr__continuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleUnitySafeAwaiter.NativeFieldInfoPtr__continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr__IsCompleted_k__BackingField;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_exception;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr__continuation;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompleted_Private_set_Void_Boolean_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_CompilerServices_INotifyCompletion_OnCompleted_Private_Virtual_Final_New_Void_Action_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
