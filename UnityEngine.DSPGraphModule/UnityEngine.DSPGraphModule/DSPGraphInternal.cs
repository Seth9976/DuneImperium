using System;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace Unity.Audio
{
	// Token: 0x02000005 RID: 5
	public struct DSPGraphInternal
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000208B File Offset: 0x0000028B
		public unsafe static void Internal_InitializeJob(void* jobStructData, void* jobReflectionData, void* resourceContext)
		{
			DSPGraphInternal.Internal_InitializeJobDelegateField(jobStructData, jobReflectionData, resourceContext);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209A File Offset: 0x0000029A
		public unsafe static void Internal_ExecuteJob(void* jobStructData, void* jobReflectionData, void* jobData, void* resourceContext)
		{
			DSPGraphInternal.Internal_ExecuteJobDelegateField(jobStructData, jobReflectionData, jobData, resourceContext);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020AA File Offset: 0x000002AA
		public unsafe static void Internal_DisposeJob(void* jobStructData, void* jobReflectionData, void* resourceContext)
		{
			DSPGraphInternal.Internal_DisposeJobDelegateField(jobStructData, jobReflectionData, resourceContext);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020B9 File Offset: 0x000002B9
		public unsafe static void Internal_ScheduleGraph(JobHandle inputDeps, void* nodes, int nodeCount, int* childTable, void* dependencies)
		{
			DSPGraphInternal.Internal_ScheduleGraph_Injected(ref inputDeps, nodes, nodeCount, childTable, dependencies);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020C7 File Offset: 0x000002C7
		public static void Internal_SyncFenceNoWorkSteal(JobHandle handle)
		{
			DSPGraphInternal.Internal_SyncFenceNoWorkSteal_Injected(ref handle);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020D0 File Offset: 0x000002D0
		public unsafe static void Internal_ScheduleGraph_Injected(ref JobHandle inputDeps, void* nodes, int nodeCount, int* childTable, void* dependencies)
		{
			DSPGraphInternal.Internal_ScheduleGraph_InjectedDelegateField(ref inputDeps, nodes, nodeCount, childTable, dependencies);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020E2 File Offset: 0x000002E2
		public static void Internal_SyncFenceNoWorkSteal_Injected(ref JobHandle handle)
		{
			DSPGraphInternal.Internal_SyncFenceNoWorkSteal_InjectedDelegateField(ref handle);
		}

		// Token: 0x04000003 RID: 3
		private static readonly DSPGraphInternal.Internal_InitializeJobDelegate Internal_InitializeJobDelegateField = IL2CPP.ResolveICall<DSPGraphInternal.Internal_InitializeJobDelegate>("Unity.Audio.DSPGraphInternal::Internal_InitializeJob");

		// Token: 0x04000004 RID: 4
		private static readonly DSPGraphInternal.Internal_ExecuteJobDelegate Internal_ExecuteJobDelegateField = IL2CPP.ResolveICall<DSPGraphInternal.Internal_ExecuteJobDelegate>("Unity.Audio.DSPGraphInternal::Internal_ExecuteJob");

		// Token: 0x04000005 RID: 5
		private static readonly DSPGraphInternal.Internal_DisposeJobDelegate Internal_DisposeJobDelegateField = IL2CPP.ResolveICall<DSPGraphInternal.Internal_DisposeJobDelegate>("Unity.Audio.DSPGraphInternal::Internal_DisposeJob");

		// Token: 0x04000006 RID: 6
		private static readonly DSPGraphInternal.Internal_ScheduleGraph_InjectedDelegate Internal_ScheduleGraph_InjectedDelegateField = IL2CPP.ResolveICall<DSPGraphInternal.Internal_ScheduleGraph_InjectedDelegate>("Unity.Audio.DSPGraphInternal::Internal_ScheduleGraph_Injected");

		// Token: 0x04000007 RID: 7
		private static readonly DSPGraphInternal.Internal_SyncFenceNoWorkSteal_InjectedDelegate Internal_SyncFenceNoWorkSteal_InjectedDelegateField = IL2CPP.ResolveICall<DSPGraphInternal.Internal_SyncFenceNoWorkSteal_InjectedDelegate>("Unity.Audio.DSPGraphInternal::Internal_SyncFenceNoWorkSteal_Injected");

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate void Internal_InitializeJobDelegate(IntPtr jobStructData, IntPtr jobReflectionData, IntPtr resourceContext);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate void Internal_ExecuteJobDelegate(IntPtr jobStructData, IntPtr jobReflectionData, IntPtr jobData, IntPtr resourceContext);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate void Internal_DisposeJobDelegate(IntPtr jobStructData, IntPtr jobReflectionData, IntPtr resourceContext);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate void Internal_ScheduleGraph_InjectedDelegate(IntPtr inputDeps, IntPtr nodes, int nodeCount, IntPtr childTable, IntPtr dependencies);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate void Internal_SyncFenceNoWorkSteal_InjectedDelegate(IntPtr handle);
	}
}
