using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000120 RID: 288
	public class AsyncInstantiateOperation<T> : CustomYieldInstruction where T : Object
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x0006EE00 File Offset: 0x0006D000
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncInstantiateOperation()
		{
			Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperation`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr);
			AsyncInstantiateOperation<T>.NativeFieldInfoPtr_m_op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr, "m_op");
			AsyncInstantiateOperation<T>.NativeMethodInfoPtr__ctor_Internal_Void_AsyncInstantiateOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr, 100666491);
			AsyncInstantiateOperation<T>.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr, 100666492);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0006EEA8 File Offset: 0x0006D0A8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncInstantiateOperation(AsyncInstantiateOperation op)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncInstantiateOperation<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation<T>.NativeMethodInfoPtr__ctor_Internal_Void_AsyncInstantiateOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x0006EEF4 File Offset: 0x0006D0F4
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660477, XrefRangeEnd = 660478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncInstantiateOperation<T>.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000091E0 File Offset: 0x000073E0
		public AsyncInstantiateOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x0006EF3C File Offset: 0x0006D13C
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x000091E9 File Offset: 0x000073E9
		public unsafe AsyncInstantiateOperation m_op
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation<T>.NativeFieldInfoPtr_m_op);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation<T>.NativeFieldInfoPtr_m_op), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00009208 File Offset: 0x00007408
		public AsyncInstantiateOperation GetOperation()
		{
			return this.m_op;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00009210 File Offset: 0x00007410
		public static implicit operator AsyncInstantiateOperation(AsyncInstantiateOperation<T> generic)
		{
			return generic.m_op;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00009218 File Offset: 0x00007418
		public bool IsWaitingForSceneActivation()
		{
			return this.m_op.IsWaitingForSceneActivation();
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00009225 File Offset: 0x00007425
		public void add_completed(Action<AsyncOperation> value)
		{
			this.m_op.add_completed(value);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00009234 File Offset: 0x00007434
		public void remove_completed(Action<AsyncOperation> value)
		{
			this.m_op.remove_completed(value);
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00009243 File Offset: 0x00007443
		public bool isDone
		{
			get
			{
				return this.m_op.isDone;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00009250 File Offset: 0x00007450
		public float progress
		{
			get
			{
				return this.m_op.progress;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0000925D File Offset: 0x0000745D
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x0000926A File Offset: 0x0000746A
		public bool allowSceneActivation
		{
			get
			{
				return this.m_op.allowSceneActivation;
			}
			set
			{
				this.m_op.allowSceneActivation = value;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00009279 File Offset: 0x00007479
		public void WaitForCompletion()
		{
			this.m_op.WaitForCompletion();
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00009287 File Offset: 0x00007487
		public void Cancel()
		{
			this.m_op.Cancel();
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x0006EF6C File Offset: 0x0006D16C
		public unsafe Il2CppArrayBase<T> Result
		{
			get
			{
				Il2CppReferenceArray<Object> result = this.m_op.Result;
				return *Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<Il2CppReferenceArray<Object>, Il2CppArrayBase<T>>(ref result);
			}
		}

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeFieldInfoPtr_m_op;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AsyncInstantiateOperation_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;
	}
}
