using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000212 RID: 530
	[StructLayout(2)]
	public struct GraphicsFence
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x0009547C File Offset: 0x0009367C
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFence()
		{
			Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsFence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr);
			GraphicsFence.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_Ptr");
			GraphicsFence.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_Version");
			GraphicsFence.NativeFieldInfoPtr_m_FenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_FenceType");
			GraphicsFence.NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667882);
			GraphicsFence.NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667883);
			GraphicsFence.NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667884);
			GraphicsFence.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667885);
			GraphicsFence.NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667886);
			GraphicsFence.NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667887);
			GraphicsFence.HasFencePassed_InternalDelegateField = IL2CPP.ResolveICall<GraphicsFence.HasFencePassed_InternalDelegate>("UnityEngine.Rendering.GraphicsFence::HasFencePassed_Internal");
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00095570 File Offset: 0x00093770
		[CallerCount(0)]
		public unsafe static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x000955B0 File Offset: 0x000937B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 681822, RefRangeEnd = 681824, XrefRangeStart = 681819, XrefRangeEnd = 681822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPostAllocation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x000955D8 File Offset: 0x000937D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681824, XrefRangeEnd = 681827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFencePending()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00095608 File Offset: 0x00093808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681829, RefRangeEnd = 681830, XrefRangeStart = 681827, XrefRangeEnd = 681829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_Validate_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00095630 File Offset: 0x00093830
		[CallerCount(0)]
		public unsafe int GetPlatformNotSupportedVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00095660 File Offset: 0x00093860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681830, XrefRangeEnd = 681832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetVersionNumber(IntPtr fencePtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fencePtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0000CF32 File Offset: 0x0000B132
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, ref this));
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x000956A0 File Offset: 0x000938A0
		public bool passed
		{
			get
			{
				this.Validate();
				bool flag = !SystemInfo.supportsGraphicsFence;
				if (flag)
				{
					throw new NotSupportedException("Cannot determine if this GraphicsFence has passed as this platform has not implemented GraphicsFences.");
				}
				bool flag2 = this.m_FenceType == GraphicsFenceType.AsyncQueueSynchronisation && !SystemInfo.supportsAsyncCompute;
				if (flag2)
				{
					throw new NotSupportedException("Cannot determine if this AsyncQueueSynchronisation GraphicsFence has passed as this platform does not support async compute.");
				}
				bool flag3 = !this.IsFencePending();
				return flag3 || GraphicsFence.HasFencePassed_Internal(this.m_Ptr);
			}
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0000CF44 File Offset: 0x0000B144
		public static bool HasFencePassed_Internal(IntPtr fencePtr)
		{
			return GraphicsFence.HasFencePassed_InternalDelegateField(fencePtr);
		}

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeFieldInfoPtr_m_FenceType;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001E8C RID: 7820
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04001E8D RID: 7821
		[FieldOffset(8)]
		public int m_Version;

		// Token: 0x04001E8E RID: 7822
		[FieldOffset(12)]
		public GraphicsFenceType m_FenceType;

		// Token: 0x04001E8F RID: 7823
		private static readonly GraphicsFence.HasFencePassed_InternalDelegate HasFencePassed_InternalDelegateField;

		// Token: 0x02000939 RID: 2361
		// (Invoke) Token: 0x06003B8F RID: 15247
		private delegate bool HasFencePassed_InternalDelegate(IntPtr fencePtr);
	}
}
