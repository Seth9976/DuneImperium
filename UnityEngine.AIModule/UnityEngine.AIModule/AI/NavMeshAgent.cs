using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.AI
{
	// Token: 0x02000008 RID: 8
	public sealed class NavMeshAgent : Behaviour
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0000222D File Offset: 0x0000042D
		public bool SetDestination(Vector3 target)
		{
			return this.SetDestination_Injected(ref target);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000329C File Offset: 0x0000149C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002237 File Offset: 0x00000437
		public Vector3 destination
		{
			get
			{
				Vector3 vector;
				this.get_destination_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_destination_Injected(ref value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002241 File Offset: 0x00000441
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002253 File Offset: 0x00000453
		public float stoppingDistance
		{
			get
			{
				return NavMeshAgent.get_stoppingDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_stoppingDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000032B4 File Offset: 0x000014B4
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002266 File Offset: 0x00000466
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000032CC File Offset: 0x000014CC
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002270 File Offset: 0x00000470
		public Vector3 nextPosition
		{
			get
			{
				Vector3 vector;
				this.get_nextPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_nextPosition_Injected(ref value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000032E4 File Offset: 0x000014E4
		public Vector3 steeringTarget
		{
			get
			{
				Vector3 vector;
				this.get_steeringTarget_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000032FC File Offset: 0x000014FC
		public Vector3 desiredVelocity
		{
			get
			{
				Vector3 vector;
				this.get_desiredVelocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000227A File Offset: 0x0000047A
		public float remainingDistance
		{
			get
			{
				return NavMeshAgent.get_remainingDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000228C File Offset: 0x0000048C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000229E File Offset: 0x0000049E
		public float baseOffset
		{
			get
			{
				return NavMeshAgent.get_baseOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_baseOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022B1 File Offset: 0x000004B1
		public bool isOnOffMeshLink
		{
			get
			{
				return NavMeshAgent.get_isOnOffMeshLinkDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022C3 File Offset: 0x000004C3
		public void ActivateCurrentOffMeshLink(bool activated)
		{
			NavMeshAgent.ActivateCurrentOffMeshLinkDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), activated);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000022D6 File Offset: 0x000004D6
		public void CompleteOffMeshLink()
		{
			NavMeshAgent.CompleteOffMeshLinkDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000022E8 File Offset: 0x000004E8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000022FA File Offset: 0x000004FA
		public bool autoTraverseOffMeshLink
		{
			get
			{
				return NavMeshAgent.get_autoTraverseOffMeshLinkDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_autoTraverseOffMeshLinkDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000230D File Offset: 0x0000050D
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000231F File Offset: 0x0000051F
		public bool autoBraking
		{
			get
			{
				return NavMeshAgent.get_autoBrakingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_autoBrakingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002332 File Offset: 0x00000532
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002344 File Offset: 0x00000544
		public bool autoRepath
		{
			get
			{
				return NavMeshAgent.get_autoRepathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_autoRepathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002357 File Offset: 0x00000557
		public bool hasPath
		{
			get
			{
				return NavMeshAgent.get_hasPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002369 File Offset: 0x00000569
		public bool pathPending
		{
			get
			{
				return NavMeshAgent.get_pathPendingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000237B File Offset: 0x0000057B
		public bool isPathStale
		{
			get
			{
				return NavMeshAgent.get_isPathStaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000238D File Offset: 0x0000058D
		public NavMeshPathStatus pathStatus
		{
			get
			{
				return NavMeshAgent.get_pathStatusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003314 File Offset: 0x00001514
		public Vector3 pathEndPosition
		{
			get
			{
				Vector3 vector;
				this.get_pathEndPosition_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000239F File Offset: 0x0000059F
		public bool Warp(Vector3 newPosition)
		{
			return this.Warp_Injected(ref newPosition);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000023A9 File Offset: 0x000005A9
		public void Move(Vector3 offset)
		{
			this.Move_Injected(ref offset);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000023B3 File Offset: 0x000005B3
		public void Stop()
		{
			NavMeshAgent.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000023C5 File Offset: 0x000005C5
		public void Stop(bool stopUpdates)
		{
			this.Stop();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000023CF File Offset: 0x000005CF
		public void Resume()
		{
			NavMeshAgent.ResumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000023E1 File Offset: 0x000005E1
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000023F3 File Offset: 0x000005F3
		public bool isStopped
		{
			get
			{
				return NavMeshAgent.get_isStoppedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_isStoppedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002406 File Offset: 0x00000606
		public void ResetPath()
		{
			NavMeshAgent.ResetPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002418 File Offset: 0x00000618
		public bool SetPath(NavMeshPath path)
		{
			return NavMeshAgent.SetPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(path));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000332C File Offset: 0x0000152C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00003350 File Offset: 0x00001550
		public NavMeshPath path
		{
			get
			{
				NavMeshPath navMeshPath = new NavMeshPath();
				this.CopyPathTo(navMeshPath);
				return navMeshPath;
			}
			set
			{
				bool flag = value == null;
				if (flag)
				{
					throw new NullReferenceException();
				}
				this.SetPath(value);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002430 File Offset: 0x00000630
		public void CopyPathTo(NavMeshPath path)
		{
			NavMeshAgent.CopyPathToDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(path));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003374 File Offset: 0x00001574
		public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
		{
			path.ClearCorners();
			return this.CalculatePathInternal(targetPosition, path);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002448 File Offset: 0x00000648
		public bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path)
		{
			return this.CalculatePathInternal_Injected(ref targetPosition, path);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002453 File Offset: 0x00000653
		public void SetLayerCost(int layer, float cost)
		{
			NavMeshAgent.SetLayerCostDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layer, cost);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002467 File Offset: 0x00000667
		public float GetLayerCost(int layer)
		{
			return NavMeshAgent.GetLayerCostDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layer);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000247A File Offset: 0x0000067A
		public void SetAreaCost(int areaIndex, float areaCost)
		{
			NavMeshAgent.SetAreaCostDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), areaIndex, areaCost);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000248E File Offset: 0x0000068E
		public float GetAreaCost(int areaIndex)
		{
			return NavMeshAgent.GetAreaCostDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), areaIndex);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000024A1 File Offset: 0x000006A1
		public Object navMeshOwner
		{
			get
			{
				return this.GetOwnerInternal();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000024A9 File Offset: 0x000006A9
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000024BB File Offset: 0x000006BB
		public int agentTypeID
		{
			get
			{
				return NavMeshAgent.get_agentTypeIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_agentTypeIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003398 File Offset: 0x00001598
		public Object GetOwnerInternal()
		{
			IntPtr intPtr = NavMeshAgent.GetOwnerInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000024CE File Offset: 0x000006CE
		public int walkableMask
		{
			get
			{
				return this.areaMask;
			}
			set
			{
				this.areaMask = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000024D9 File Offset: 0x000006D9
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000024EB File Offset: 0x000006EB
		public int areaMask
		{
			get
			{
				return NavMeshAgent.get_areaMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_areaMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000024FE File Offset: 0x000006FE
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002510 File Offset: 0x00000710
		public float speed
		{
			get
			{
				return NavMeshAgent.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002523 File Offset: 0x00000723
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002535 File Offset: 0x00000735
		public float angularSpeed
		{
			get
			{
				return NavMeshAgent.get_angularSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_angularSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002548 File Offset: 0x00000748
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000255A File Offset: 0x0000075A
		public float acceleration
		{
			get
			{
				return NavMeshAgent.get_accelerationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_accelerationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000256D File Offset: 0x0000076D
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000257F File Offset: 0x0000077F
		public bool updatePosition
		{
			get
			{
				return NavMeshAgent.get_updatePositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_updatePositionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002592 File Offset: 0x00000792
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000025A4 File Offset: 0x000007A4
		public bool updateRotation
		{
			get
			{
				return NavMeshAgent.get_updateRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_updateRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000025B7 File Offset: 0x000007B7
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000025C9 File Offset: 0x000007C9
		public bool updateUpAxis
		{
			get
			{
				return NavMeshAgent.get_updateUpAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_updateUpAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000025DC File Offset: 0x000007DC
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000025EE File Offset: 0x000007EE
		public float radius
		{
			get
			{
				return NavMeshAgent.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002601 File Offset: 0x00000801
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002613 File Offset: 0x00000813
		public float height
		{
			get
			{
				return NavMeshAgent.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002626 File Offset: 0x00000826
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002638 File Offset: 0x00000838
		public ObstacleAvoidanceType obstacleAvoidanceType
		{
			get
			{
				return NavMeshAgent.get_obstacleAvoidanceTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_obstacleAvoidanceTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000264B File Offset: 0x0000084B
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000265D File Offset: 0x0000085D
		public int avoidancePriority
		{
			get
			{
				return NavMeshAgent.get_avoidancePriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshAgent.set_avoidancePriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002670 File Offset: 0x00000870
		public bool isOnNavMesh
		{
			get
			{
				return NavMeshAgent.get_isOnNavMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002682 File Offset: 0x00000882
		public bool SetDestination_Injected(ref Vector3 target)
		{
			return NavMeshAgent.SetDestination_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref target);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002695 File Offset: 0x00000895
		public void get_destination_Injected(out Vector3 ret)
		{
			NavMeshAgent.get_destination_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000026A8 File Offset: 0x000008A8
		public void set_destination_Injected(ref Vector3 value)
		{
			NavMeshAgent.set_destination_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000026BB File Offset: 0x000008BB
		public void get_velocity_Injected(out Vector3 ret)
		{
			NavMeshAgent.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000026CE File Offset: 0x000008CE
		public void set_velocity_Injected(ref Vector3 value)
		{
			NavMeshAgent.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000026E1 File Offset: 0x000008E1
		public void get_nextPosition_Injected(out Vector3 ret)
		{
			NavMeshAgent.get_nextPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000026F4 File Offset: 0x000008F4
		public void set_nextPosition_Injected(ref Vector3 value)
		{
			NavMeshAgent.set_nextPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002707 File Offset: 0x00000907
		public void get_steeringTarget_Injected(out Vector3 ret)
		{
			NavMeshAgent.get_steeringTarget_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000271A File Offset: 0x0000091A
		public void get_desiredVelocity_Injected(out Vector3 ret)
		{
			NavMeshAgent.get_desiredVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000272D File Offset: 0x0000092D
		public void get_pathEndPosition_Injected(out Vector3 ret)
		{
			NavMeshAgent.get_pathEndPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002740 File Offset: 0x00000940
		public bool Warp_Injected(ref Vector3 newPosition)
		{
			return NavMeshAgent.Warp_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref newPosition);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002753 File Offset: 0x00000953
		public void Move_Injected(ref Vector3 offset)
		{
			NavMeshAgent.Move_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref offset);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002766 File Offset: 0x00000966
		public bool CalculatePathInternal_Injected(ref Vector3 targetPosition, NavMeshPath path)
		{
			return NavMeshAgent.CalculatePathInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref targetPosition, IL2CPP.Il2CppObjectBaseToPtr(path));
		}

		// Token: 0x04000035 RID: 53
		private static readonly NavMeshAgent.get_stoppingDistanceDelegate get_stoppingDistanceDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_stoppingDistanceDelegate>("UnityEngine.AI.NavMeshAgent::get_stoppingDistance");

		// Token: 0x04000036 RID: 54
		private static readonly NavMeshAgent.set_stoppingDistanceDelegate set_stoppingDistanceDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_stoppingDistanceDelegate>("UnityEngine.AI.NavMeshAgent::set_stoppingDistance");

		// Token: 0x04000037 RID: 55
		private static readonly NavMeshAgent.get_remainingDistanceDelegate get_remainingDistanceDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_remainingDistanceDelegate>("UnityEngine.AI.NavMeshAgent::get_remainingDistance");

		// Token: 0x04000038 RID: 56
		private static readonly NavMeshAgent.get_baseOffsetDelegate get_baseOffsetDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_baseOffsetDelegate>("UnityEngine.AI.NavMeshAgent::get_baseOffset");

		// Token: 0x04000039 RID: 57
		private static readonly NavMeshAgent.set_baseOffsetDelegate set_baseOffsetDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_baseOffsetDelegate>("UnityEngine.AI.NavMeshAgent::set_baseOffset");

		// Token: 0x0400003A RID: 58
		private static readonly NavMeshAgent.get_isOnOffMeshLinkDelegate get_isOnOffMeshLinkDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_isOnOffMeshLinkDelegate>("UnityEngine.AI.NavMeshAgent::get_isOnOffMeshLink");

		// Token: 0x0400003B RID: 59
		private static readonly NavMeshAgent.ActivateCurrentOffMeshLinkDelegate ActivateCurrentOffMeshLinkDelegateField = IL2CPP.ResolveICall<NavMeshAgent.ActivateCurrentOffMeshLinkDelegate>("UnityEngine.AI.NavMeshAgent::ActivateCurrentOffMeshLink");

		// Token: 0x0400003C RID: 60
		private static readonly NavMeshAgent.CompleteOffMeshLinkDelegate CompleteOffMeshLinkDelegateField = IL2CPP.ResolveICall<NavMeshAgent.CompleteOffMeshLinkDelegate>("UnityEngine.AI.NavMeshAgent::CompleteOffMeshLink");

		// Token: 0x0400003D RID: 61
		private static readonly NavMeshAgent.get_autoTraverseOffMeshLinkDelegate get_autoTraverseOffMeshLinkDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_autoTraverseOffMeshLinkDelegate>("UnityEngine.AI.NavMeshAgent::get_autoTraverseOffMeshLink");

		// Token: 0x0400003E RID: 62
		private static readonly NavMeshAgent.set_autoTraverseOffMeshLinkDelegate set_autoTraverseOffMeshLinkDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_autoTraverseOffMeshLinkDelegate>("UnityEngine.AI.NavMeshAgent::set_autoTraverseOffMeshLink");

		// Token: 0x0400003F RID: 63
		private static readonly NavMeshAgent.get_autoBrakingDelegate get_autoBrakingDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_autoBrakingDelegate>("UnityEngine.AI.NavMeshAgent::get_autoBraking");

		// Token: 0x04000040 RID: 64
		private static readonly NavMeshAgent.set_autoBrakingDelegate set_autoBrakingDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_autoBrakingDelegate>("UnityEngine.AI.NavMeshAgent::set_autoBraking");

		// Token: 0x04000041 RID: 65
		private static readonly NavMeshAgent.get_autoRepathDelegate get_autoRepathDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_autoRepathDelegate>("UnityEngine.AI.NavMeshAgent::get_autoRepath");

		// Token: 0x04000042 RID: 66
		private static readonly NavMeshAgent.set_autoRepathDelegate set_autoRepathDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_autoRepathDelegate>("UnityEngine.AI.NavMeshAgent::set_autoRepath");

		// Token: 0x04000043 RID: 67
		private static readonly NavMeshAgent.get_hasPathDelegate get_hasPathDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_hasPathDelegate>("UnityEngine.AI.NavMeshAgent::get_hasPath");

		// Token: 0x04000044 RID: 68
		private static readonly NavMeshAgent.get_pathPendingDelegate get_pathPendingDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_pathPendingDelegate>("UnityEngine.AI.NavMeshAgent::get_pathPending");

		// Token: 0x04000045 RID: 69
		private static readonly NavMeshAgent.get_isPathStaleDelegate get_isPathStaleDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_isPathStaleDelegate>("UnityEngine.AI.NavMeshAgent::get_isPathStale");

		// Token: 0x04000046 RID: 70
		private static readonly NavMeshAgent.get_pathStatusDelegate get_pathStatusDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_pathStatusDelegate>("UnityEngine.AI.NavMeshAgent::get_pathStatus");

		// Token: 0x04000047 RID: 71
		private static readonly NavMeshAgent.StopDelegate StopDelegateField = IL2CPP.ResolveICall<NavMeshAgent.StopDelegate>("UnityEngine.AI.NavMeshAgent::Stop");

		// Token: 0x04000048 RID: 72
		private static readonly NavMeshAgent.ResumeDelegate ResumeDelegateField = IL2CPP.ResolveICall<NavMeshAgent.ResumeDelegate>("UnityEngine.AI.NavMeshAgent::Resume");

		// Token: 0x04000049 RID: 73
		private static readonly NavMeshAgent.get_isStoppedDelegate get_isStoppedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_isStoppedDelegate>("UnityEngine.AI.NavMeshAgent::get_isStopped");

		// Token: 0x0400004A RID: 74
		private static readonly NavMeshAgent.set_isStoppedDelegate set_isStoppedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_isStoppedDelegate>("UnityEngine.AI.NavMeshAgent::set_isStopped");

		// Token: 0x0400004B RID: 75
		private static readonly NavMeshAgent.ResetPathDelegate ResetPathDelegateField = IL2CPP.ResolveICall<NavMeshAgent.ResetPathDelegate>("UnityEngine.AI.NavMeshAgent::ResetPath");

		// Token: 0x0400004C RID: 76
		private static readonly NavMeshAgent.SetPathDelegate SetPathDelegateField = IL2CPP.ResolveICall<NavMeshAgent.SetPathDelegate>("UnityEngine.AI.NavMeshAgent::SetPath");

		// Token: 0x0400004D RID: 77
		private static readonly NavMeshAgent.CopyPathToDelegate CopyPathToDelegateField = IL2CPP.ResolveICall<NavMeshAgent.CopyPathToDelegate>("UnityEngine.AI.NavMeshAgent::CopyPathTo");

		// Token: 0x0400004E RID: 78
		private static readonly NavMeshAgent.SetLayerCostDelegate SetLayerCostDelegateField = IL2CPP.ResolveICall<NavMeshAgent.SetLayerCostDelegate>("UnityEngine.AI.NavMeshAgent::SetLayerCost");

		// Token: 0x0400004F RID: 79
		private static readonly NavMeshAgent.GetLayerCostDelegate GetLayerCostDelegateField = IL2CPP.ResolveICall<NavMeshAgent.GetLayerCostDelegate>("UnityEngine.AI.NavMeshAgent::GetLayerCost");

		// Token: 0x04000050 RID: 80
		private static readonly NavMeshAgent.SetAreaCostDelegate SetAreaCostDelegateField = IL2CPP.ResolveICall<NavMeshAgent.SetAreaCostDelegate>("UnityEngine.AI.NavMeshAgent::SetAreaCost");

		// Token: 0x04000051 RID: 81
		private static readonly NavMeshAgent.GetAreaCostDelegate GetAreaCostDelegateField = IL2CPP.ResolveICall<NavMeshAgent.GetAreaCostDelegate>("UnityEngine.AI.NavMeshAgent::GetAreaCost");

		// Token: 0x04000052 RID: 82
		private static readonly NavMeshAgent.get_agentTypeIDDelegate get_agentTypeIDDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_agentTypeIDDelegate>("UnityEngine.AI.NavMeshAgent::get_agentTypeID");

		// Token: 0x04000053 RID: 83
		private static readonly NavMeshAgent.set_agentTypeIDDelegate set_agentTypeIDDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_agentTypeIDDelegate>("UnityEngine.AI.NavMeshAgent::set_agentTypeID");

		// Token: 0x04000054 RID: 84
		private static readonly NavMeshAgent.GetOwnerInternalDelegate GetOwnerInternalDelegateField = IL2CPP.ResolveICall<NavMeshAgent.GetOwnerInternalDelegate>("UnityEngine.AI.NavMeshAgent::GetOwnerInternal");

		// Token: 0x04000055 RID: 85
		private static readonly NavMeshAgent.get_areaMaskDelegate get_areaMaskDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_areaMaskDelegate>("UnityEngine.AI.NavMeshAgent::get_areaMask");

		// Token: 0x04000056 RID: 86
		private static readonly NavMeshAgent.set_areaMaskDelegate set_areaMaskDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_areaMaskDelegate>("UnityEngine.AI.NavMeshAgent::set_areaMask");

		// Token: 0x04000057 RID: 87
		private static readonly NavMeshAgent.get_speedDelegate get_speedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_speedDelegate>("UnityEngine.AI.NavMeshAgent::get_speed");

		// Token: 0x04000058 RID: 88
		private static readonly NavMeshAgent.set_speedDelegate set_speedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_speedDelegate>("UnityEngine.AI.NavMeshAgent::set_speed");

		// Token: 0x04000059 RID: 89
		private static readonly NavMeshAgent.get_angularSpeedDelegate get_angularSpeedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_angularSpeedDelegate>("UnityEngine.AI.NavMeshAgent::get_angularSpeed");

		// Token: 0x0400005A RID: 90
		private static readonly NavMeshAgent.set_angularSpeedDelegate set_angularSpeedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_angularSpeedDelegate>("UnityEngine.AI.NavMeshAgent::set_angularSpeed");

		// Token: 0x0400005B RID: 91
		private static readonly NavMeshAgent.get_accelerationDelegate get_accelerationDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_accelerationDelegate>("UnityEngine.AI.NavMeshAgent::get_acceleration");

		// Token: 0x0400005C RID: 92
		private static readonly NavMeshAgent.set_accelerationDelegate set_accelerationDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_accelerationDelegate>("UnityEngine.AI.NavMeshAgent::set_acceleration");

		// Token: 0x0400005D RID: 93
		private static readonly NavMeshAgent.get_updatePositionDelegate get_updatePositionDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_updatePositionDelegate>("UnityEngine.AI.NavMeshAgent::get_updatePosition");

		// Token: 0x0400005E RID: 94
		private static readonly NavMeshAgent.set_updatePositionDelegate set_updatePositionDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_updatePositionDelegate>("UnityEngine.AI.NavMeshAgent::set_updatePosition");

		// Token: 0x0400005F RID: 95
		private static readonly NavMeshAgent.get_updateRotationDelegate get_updateRotationDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_updateRotationDelegate>("UnityEngine.AI.NavMeshAgent::get_updateRotation");

		// Token: 0x04000060 RID: 96
		private static readonly NavMeshAgent.set_updateRotationDelegate set_updateRotationDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_updateRotationDelegate>("UnityEngine.AI.NavMeshAgent::set_updateRotation");

		// Token: 0x04000061 RID: 97
		private static readonly NavMeshAgent.get_updateUpAxisDelegate get_updateUpAxisDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_updateUpAxisDelegate>("UnityEngine.AI.NavMeshAgent::get_updateUpAxis");

		// Token: 0x04000062 RID: 98
		private static readonly NavMeshAgent.set_updateUpAxisDelegate set_updateUpAxisDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_updateUpAxisDelegate>("UnityEngine.AI.NavMeshAgent::set_updateUpAxis");

		// Token: 0x04000063 RID: 99
		private static readonly NavMeshAgent.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_radiusDelegate>("UnityEngine.AI.NavMeshAgent::get_radius");

		// Token: 0x04000064 RID: 100
		private static readonly NavMeshAgent.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_radiusDelegate>("UnityEngine.AI.NavMeshAgent::set_radius");

		// Token: 0x04000065 RID: 101
		private static readonly NavMeshAgent.get_heightDelegate get_heightDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_heightDelegate>("UnityEngine.AI.NavMeshAgent::get_height");

		// Token: 0x04000066 RID: 102
		private static readonly NavMeshAgent.set_heightDelegate set_heightDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_heightDelegate>("UnityEngine.AI.NavMeshAgent::set_height");

		// Token: 0x04000067 RID: 103
		private static readonly NavMeshAgent.get_obstacleAvoidanceTypeDelegate get_obstacleAvoidanceTypeDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_obstacleAvoidanceTypeDelegate>("UnityEngine.AI.NavMeshAgent::get_obstacleAvoidanceType");

		// Token: 0x04000068 RID: 104
		private static readonly NavMeshAgent.set_obstacleAvoidanceTypeDelegate set_obstacleAvoidanceTypeDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_obstacleAvoidanceTypeDelegate>("UnityEngine.AI.NavMeshAgent::set_obstacleAvoidanceType");

		// Token: 0x04000069 RID: 105
		private static readonly NavMeshAgent.get_avoidancePriorityDelegate get_avoidancePriorityDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_avoidancePriorityDelegate>("UnityEngine.AI.NavMeshAgent::get_avoidancePriority");

		// Token: 0x0400006A RID: 106
		private static readonly NavMeshAgent.set_avoidancePriorityDelegate set_avoidancePriorityDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_avoidancePriorityDelegate>("UnityEngine.AI.NavMeshAgent::set_avoidancePriority");

		// Token: 0x0400006B RID: 107
		private static readonly NavMeshAgent.get_isOnNavMeshDelegate get_isOnNavMeshDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_isOnNavMeshDelegate>("UnityEngine.AI.NavMeshAgent::get_isOnNavMesh");

		// Token: 0x0400006C RID: 108
		private static readonly NavMeshAgent.SetDestination_InjectedDelegate SetDestination_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.SetDestination_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::SetDestination_Injected");

		// Token: 0x0400006D RID: 109
		private static readonly NavMeshAgent.get_destination_InjectedDelegate get_destination_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_destination_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_destination_Injected");

		// Token: 0x0400006E RID: 110
		private static readonly NavMeshAgent.set_destination_InjectedDelegate set_destination_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_destination_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_destination_Injected");

		// Token: 0x0400006F RID: 111
		private static readonly NavMeshAgent.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_velocity_Injected");

		// Token: 0x04000070 RID: 112
		private static readonly NavMeshAgent.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_velocity_Injected");

		// Token: 0x04000071 RID: 113
		private static readonly NavMeshAgent.get_nextPosition_InjectedDelegate get_nextPosition_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_nextPosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_nextPosition_Injected");

		// Token: 0x04000072 RID: 114
		private static readonly NavMeshAgent.set_nextPosition_InjectedDelegate set_nextPosition_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.set_nextPosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_nextPosition_Injected");

		// Token: 0x04000073 RID: 115
		private static readonly NavMeshAgent.get_steeringTarget_InjectedDelegate get_steeringTarget_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_steeringTarget_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_steeringTarget_Injected");

		// Token: 0x04000074 RID: 116
		private static readonly NavMeshAgent.get_desiredVelocity_InjectedDelegate get_desiredVelocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_desiredVelocity_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_desiredVelocity_Injected");

		// Token: 0x04000075 RID: 117
		private static readonly NavMeshAgent.get_pathEndPosition_InjectedDelegate get_pathEndPosition_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.get_pathEndPosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_pathEndPosition_Injected");

		// Token: 0x04000076 RID: 118
		private static readonly NavMeshAgent.Warp_InjectedDelegate Warp_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.Warp_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::Warp_Injected");

		// Token: 0x04000077 RID: 119
		private static readonly NavMeshAgent.Move_InjectedDelegate Move_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.Move_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::Move_Injected");

		// Token: 0x04000078 RID: 120
		private static readonly NavMeshAgent.CalculatePathInternal_InjectedDelegate CalculatePathInternal_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshAgent.CalculatePathInternal_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::CalculatePathInternal_Injected");

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000108 RID: 264
		private delegate float get_stoppingDistanceDelegate(IntPtr @this);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600010A RID: 266
		private delegate void set_stoppingDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600010C RID: 268
		private delegate float get_remainingDistanceDelegate(IntPtr @this);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600010E RID: 270
		private delegate float get_baseOffsetDelegate(IntPtr @this);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000110 RID: 272
		private delegate void set_baseOffsetDelegate(IntPtr @this, float value);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000112 RID: 274
		private delegate bool get_isOnOffMeshLinkDelegate(IntPtr @this);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000114 RID: 276
		private delegate void ActivateCurrentOffMeshLinkDelegate(IntPtr @this, bool activated);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000116 RID: 278
		private delegate void CompleteOffMeshLinkDelegate(IntPtr @this);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000118 RID: 280
		private delegate bool get_autoTraverseOffMeshLinkDelegate(IntPtr @this);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600011A RID: 282
		private delegate void set_autoTraverseOffMeshLinkDelegate(IntPtr @this, bool value);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600011C RID: 284
		private delegate bool get_autoBrakingDelegate(IntPtr @this);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600011E RID: 286
		private delegate void set_autoBrakingDelegate(IntPtr @this, bool value);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000120 RID: 288
		private delegate bool get_autoRepathDelegate(IntPtr @this);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000122 RID: 290
		private delegate void set_autoRepathDelegate(IntPtr @this, bool value);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000124 RID: 292
		private delegate bool get_hasPathDelegate(IntPtr @this);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000126 RID: 294
		private delegate bool get_pathPendingDelegate(IntPtr @this);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000128 RID: 296
		private delegate bool get_isPathStaleDelegate(IntPtr @this);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600012A RID: 298
		private delegate NavMeshPathStatus get_pathStatusDelegate(IntPtr @this);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600012C RID: 300
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600012E RID: 302
		private delegate void ResumeDelegate(IntPtr @this);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000130 RID: 304
		private delegate bool get_isStoppedDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000132 RID: 306
		private delegate void set_isStoppedDelegate(IntPtr @this, bool value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000134 RID: 308
		private delegate void ResetPathDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000136 RID: 310
		private delegate bool SetPathDelegate(IntPtr @this, IntPtr path);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x06000138 RID: 312
		private delegate void CopyPathToDelegate(IntPtr @this, IntPtr path);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600013A RID: 314
		private delegate void SetLayerCostDelegate(IntPtr @this, int layer, float cost);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600013C RID: 316
		private delegate float GetLayerCostDelegate(IntPtr @this, int layer);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x0600013E RID: 318
		private delegate void SetAreaCostDelegate(IntPtr @this, int areaIndex, float areaCost);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000140 RID: 320
		private delegate float GetAreaCostDelegate(IntPtr @this, int areaIndex);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000142 RID: 322
		private delegate int get_agentTypeIDDelegate(IntPtr @this);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000144 RID: 324
		private delegate void set_agentTypeIDDelegate(IntPtr @this, int value);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000146 RID: 326
		private delegate IntPtr GetOwnerInternalDelegate(IntPtr @this);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000148 RID: 328
		private delegate int get_areaMaskDelegate(IntPtr @this);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600014A RID: 330
		private delegate void set_areaMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600014C RID: 332
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600014E RID: 334
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000150 RID: 336
		private delegate float get_angularSpeedDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000152 RID: 338
		private delegate void set_angularSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate float get_accelerationDelegate(IntPtr @this);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000156 RID: 342
		private delegate void set_accelerationDelegate(IntPtr @this, float value);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000158 RID: 344
		private delegate bool get_updatePositionDelegate(IntPtr @this);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600015A RID: 346
		private delegate void set_updatePositionDelegate(IntPtr @this, bool value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x0600015C RID: 348
		private delegate bool get_updateRotationDelegate(IntPtr @this);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x0600015E RID: 350
		private delegate void set_updateRotationDelegate(IntPtr @this, bool value);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000160 RID: 352
		private delegate bool get_updateUpAxisDelegate(IntPtr @this);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000162 RID: 354
		private delegate void set_updateUpAxisDelegate(IntPtr @this, bool value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate ObstacleAvoidanceType get_obstacleAvoidanceTypeDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate void set_obstacleAvoidanceTypeDelegate(IntPtr @this, ObstacleAvoidanceType value);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate int get_avoidancePriorityDelegate(IntPtr @this);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate void set_avoidancePriorityDelegate(IntPtr @this, int value);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate bool get_isOnNavMeshDelegate(IntPtr @this);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate bool SetDestination_InjectedDelegate(IntPtr @this, IntPtr target);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void get_destination_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate void set_destination_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate void get_nextPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate void set_nextPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate void get_steeringTarget_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate void get_desiredVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate void get_pathEndPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate bool Warp_InjectedDelegate(IntPtr @this, IntPtr newPosition);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate void Move_InjectedDelegate(IntPtr @this, IntPtr offset);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate bool CalculatePathInternal_InjectedDelegate(IntPtr @this, IntPtr targetPosition, IntPtr path);
	}
}
