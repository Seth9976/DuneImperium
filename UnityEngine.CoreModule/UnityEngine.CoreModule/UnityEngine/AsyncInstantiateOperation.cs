using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011F RID: 287
	public class AsyncInstantiateOperation : AsyncOperation
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x0006EC8C File Offset: 0x0006CE8C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncInstantiateOperation()
		{
			Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr);
			AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, "m_Result");
			AsyncInstantiateOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100666490);
			AsyncInstantiateOperation.IsWaitingForSceneActivationDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.IsWaitingForSceneActivationDelegate>("UnityEngine.AsyncInstantiateOperation::IsWaitingForSceneActivation");
			AsyncInstantiateOperation.WaitForCompletionDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.WaitForCompletionDelegate>("UnityEngine.AsyncInstantiateOperation::WaitForCompletion");
			AsyncInstantiateOperation.CancelDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.CancelDelegate>("UnityEngine.AsyncInstantiateOperation::Cancel");
			AsyncInstantiateOperation.get_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.get_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::get_IntegrationTimeMS");
			AsyncInstantiateOperation.set_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.set_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::set_IntegrationTimeMS");
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0006ED30 File Offset: 0x0006CF30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncInstantiateOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00009169 File Offset: 0x00007369
		public AsyncInstantiateOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x0006ED6C File Offset: 0x0006CF6C
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x00009172 File Offset: 0x00007372
		public unsafe Il2CppReferenceArray<Object> m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x0006ED9C File Offset: 0x0006CF9C
		public Il2CppReferenceArray<Object> Result
		{
			get
			{
				return this.m_Result;
			}
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00009191 File Offset: 0x00007391
		public bool IsWaitingForSceneActivation()
		{
			return AsyncInstantiateOperation.IsWaitingForSceneActivationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000091A3 File Offset: 0x000073A3
		public void WaitForCompletion()
		{
			AsyncInstantiateOperation.WaitForCompletionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000091B5 File Offset: 0x000073B5
		public void Cancel()
		{
			AsyncInstantiateOperation.CancelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000091C7 File Offset: 0x000073C7
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x000091D3 File Offset: 0x000073D3
		public static float IntegrationTimeMS
		{
			get
			{
				return AsyncInstantiateOperation.get_IntegrationTimeMSDelegateField();
			}
			set
			{
				AsyncInstantiateOperation.set_IntegrationTimeMSDelegateField(value);
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
		public static float GetIntegrationTimeMS()
		{
			return AsyncInstantiateOperation.IntegrationTimeMS;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0006EDCC File Offset: 0x0006CFCC
		public static void SetIntegrationTimeMS(float integrationTimeMS)
		{
			bool flag = integrationTimeMS <= 0f;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("integrationTimeMS", "integrationTimeMS was out of range. Must be greater than zero.");
			}
			AsyncInstantiateOperation.IntegrationTimeMS = integrationTimeMS;
		}

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001516 RID: 5398
		private static readonly AsyncInstantiateOperation.IsWaitingForSceneActivationDelegate IsWaitingForSceneActivationDelegateField;

		// Token: 0x04001517 RID: 5399
		private static readonly AsyncInstantiateOperation.WaitForCompletionDelegate WaitForCompletionDelegateField;

		// Token: 0x04001518 RID: 5400
		private static readonly AsyncInstantiateOperation.CancelDelegate CancelDelegateField;

		// Token: 0x04001519 RID: 5401
		private static readonly AsyncInstantiateOperation.get_IntegrationTimeMSDelegate get_IntegrationTimeMSDelegateField;

		// Token: 0x0400151A RID: 5402
		private static readonly AsyncInstantiateOperation.set_IntegrationTimeMSDelegate set_IntegrationTimeMSDelegateField;

		// Token: 0x0200071F RID: 1823
		// (Invoke) Token: 0x0600370B RID: 14091
		private delegate bool IsWaitingForSceneActivationDelegate(IntPtr @this);

		// Token: 0x02000720 RID: 1824
		// (Invoke) Token: 0x0600370D RID: 14093
		private delegate void WaitForCompletionDelegate(IntPtr @this);

		// Token: 0x02000721 RID: 1825
		// (Invoke) Token: 0x0600370F RID: 14095
		private delegate void CancelDelegate(IntPtr @this);

		// Token: 0x02000722 RID: 1826
		// (Invoke) Token: 0x06003711 RID: 14097
		private delegate float get_IntegrationTimeMSDelegate();

		// Token: 0x02000723 RID: 1827
		// (Invoke) Token: 0x06003713 RID: 14099
		private delegate void set_IntegrationTimeMSDelegate(float value);
	}
}
