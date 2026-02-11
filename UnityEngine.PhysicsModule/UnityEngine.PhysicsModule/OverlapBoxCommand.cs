using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x02000031 RID: 49
	public struct OverlapBoxCommand
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00004801 File Offset: 0x00002A01
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00004809 File Offset: 0x00002A09
		public Vector3 center
		{
			get
			{
				return this.<center>k__BackingField;
			}
			set
			{
				this.<center>k__BackingField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00004812 File Offset: 0x00002A12
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000481A File Offset: 0x00002A1A
		public Vector3 halfExtents
		{
			get
			{
				return this.<halfExtents>k__BackingField;
			}
			set
			{
				this.<halfExtents>k__BackingField = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00004823 File Offset: 0x00002A23
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0000482B File Offset: 0x00002A2B
		public Quaternion orientation
		{
			get
			{
				return this.<orientation>k__BackingField;
			}
			set
			{
				this.<orientation>k__BackingField = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00004834 File Offset: 0x00002A34
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000483C File Offset: 0x00002A3C
		public PhysicsScene physicsScene
		{
			get
			{
				return this.<physicsScene>k__BackingField;
			}
			set
			{
				this.<physicsScene>k__BackingField = value;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000C74C File Offset: 0x0000A94C
		public unsafe static JobHandle ScheduleOverlapBoxBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
		{
			JobHandle jobHandle;
			OverlapBoxCommand.ScheduleOverlapBoxBatch_Injected(ref parameters, commands, commandLen, result, resultLen, minCommandsPerJob, maxHits, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000C76C File Offset: 0x0000A96C
		public unsafe static void ScheduleOverlapBoxBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret)
		{
			OverlapBoxCommand.ScheduleOverlapBoxBatch_InjectedDelegateField(ref parameters, commands, commandLen, result, resultLen, minCommandsPerJob, maxHits, out ret);
		}

		// Token: 0x04000310 RID: 784
		public Vector3 <center>k__BackingField;

		// Token: 0x04000311 RID: 785
		public Vector3 <halfExtents>k__BackingField;

		// Token: 0x04000312 RID: 786
		public Quaternion <orientation>k__BackingField;

		// Token: 0x04000313 RID: 787
		public PhysicsScene <physicsScene>k__BackingField;

		// Token: 0x04000314 RID: 788
		private static readonly OverlapBoxCommand.ScheduleOverlapBoxBatch_InjectedDelegate ScheduleOverlapBoxBatch_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBoxCommand.ScheduleOverlapBoxBatch_InjectedDelegate>("UnityEngine.OverlapBoxCommand::ScheduleOverlapBoxBatch_Injected");

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x0600078C RID: 1932
		private delegate void ScheduleOverlapBoxBatch_InjectedDelegate(IntPtr parameters, IntPtr commands, int commandLen, IntPtr result, int resultLen, int minCommandsPerJob, int maxHits, [Out] IntPtr ret);
	}
}
