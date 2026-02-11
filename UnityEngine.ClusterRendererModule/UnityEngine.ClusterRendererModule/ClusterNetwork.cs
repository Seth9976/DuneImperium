using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class ClusterNetwork
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000208E File Offset: 0x0000028E
		public static bool isMasterOfCluster
		{
			get
			{
				return ClusterNetwork.get_isMasterOfClusterDelegateField();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000209A File Offset: 0x0000029A
		public static bool isDisconnected
		{
			get
			{
				return ClusterNetwork.get_isDisconnectedDelegateField();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020A6 File Offset: 0x000002A6
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020B2 File Offset: 0x000002B2
		public static int nodeIndex
		{
			get
			{
				return ClusterNetwork.get_nodeIndexDelegateField();
			}
			set
			{
				ClusterNetwork.set_nodeIndexDelegateField(value);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly ClusterNetwork.get_isMasterOfClusterDelegate get_isMasterOfClusterDelegateField = IL2CPP.ResolveICall<ClusterNetwork.get_isMasterOfClusterDelegate>("UnityEngine.ClusterNetwork::get_isMasterOfCluster");

		// Token: 0x04000002 RID: 2
		private static readonly ClusterNetwork.get_isDisconnectedDelegate get_isDisconnectedDelegateField = IL2CPP.ResolveICall<ClusterNetwork.get_isDisconnectedDelegate>("UnityEngine.ClusterNetwork::get_isDisconnected");

		// Token: 0x04000003 RID: 3
		private static readonly ClusterNetwork.get_nodeIndexDelegate get_nodeIndexDelegateField = IL2CPP.ResolveICall<ClusterNetwork.get_nodeIndexDelegate>("UnityEngine.ClusterNetwork::get_nodeIndex");

		// Token: 0x04000004 RID: 4
		private static readonly ClusterNetwork.set_nodeIndexDelegate set_nodeIndexDelegateField = IL2CPP.ResolveICall<ClusterNetwork.set_nodeIndexDelegate>("UnityEngine.ClusterNetwork::set_nodeIndex");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000014 RID: 20
		private delegate bool get_isMasterOfClusterDelegate();

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000016 RID: 22
		private delegate bool get_isDisconnectedDelegate();

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000018 RID: 24
		private delegate int get_nodeIndexDelegate();

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate void set_nodeIndexDelegate(int value);
	}
}
