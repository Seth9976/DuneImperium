using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002D RID: 45
	public class ConfigurableJoint : Joint
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000C66C File Offset: 0x0000A86C
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00004525 File Offset: 0x00002725
		public Vector3 secondaryAxis
		{
			get
			{
				Vector3 vector;
				this.get_secondaryAxis_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_secondaryAxis_Injected(ref value);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000452F File Offset: 0x0000272F
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00004541 File Offset: 0x00002741
		public ConfigurableJointMotion xMotion
		{
			get
			{
				return ConfigurableJoint.get_xMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_xMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00004554 File Offset: 0x00002754
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00004566 File Offset: 0x00002766
		public ConfigurableJointMotion yMotion
		{
			get
			{
				return ConfigurableJoint.get_yMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_yMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00004579 File Offset: 0x00002779
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x0000458B File Offset: 0x0000278B
		public ConfigurableJointMotion zMotion
		{
			get
			{
				return ConfigurableJoint.get_zMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_zMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000459E File Offset: 0x0000279E
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x000045B0 File Offset: 0x000027B0
		public ConfigurableJointMotion angularXMotion
		{
			get
			{
				return ConfigurableJoint.get_angularXMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularXMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000045C3 File Offset: 0x000027C3
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x000045D5 File Offset: 0x000027D5
		public ConfigurableJointMotion angularYMotion
		{
			get
			{
				return ConfigurableJoint.get_angularYMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularYMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000045E8 File Offset: 0x000027E8
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x000045FA File Offset: 0x000027FA
		public ConfigurableJointMotion angularZMotion
		{
			get
			{
				return ConfigurableJoint.get_angularZMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_angularZMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000C684 File Offset: 0x0000A884
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000460D File Offset: 0x0000280D
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.get_targetPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetPosition_Injected(ref value);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000C69C File Offset: 0x0000A89C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00004617 File Offset: 0x00002817
		public Vector3 targetVelocity
		{
			get
			{
				Vector3 vector;
				this.get_targetVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetVelocity_Injected(ref value);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00004621 File Offset: 0x00002821
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_targetRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_targetRotation_Injected(ref value);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000462B File Offset: 0x0000282B
		public Vector3 targetAngularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_targetAngularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_targetAngularVelocity_Injected(ref value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00004635 File Offset: 0x00002835
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00004647 File Offset: 0x00002847
		public RotationDriveMode rotationDriveMode
		{
			get
			{
				return ConfigurableJoint.get_rotationDriveModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_rotationDriveModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000465A File Offset: 0x0000285A
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0000466C File Offset: 0x0000286C
		public JointProjectionMode projectionMode
		{
			get
			{
				return ConfigurableJoint.get_projectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0000467F File Offset: 0x0000287F
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00004691 File Offset: 0x00002891
		public float projectionDistance
		{
			get
			{
				return ConfigurableJoint.get_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x000046A4 File Offset: 0x000028A4
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x000046B6 File Offset: 0x000028B6
		public float projectionAngle
		{
			get
			{
				return ConfigurableJoint.get_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_projectionAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000046C9 File Offset: 0x000028C9
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x000046DB File Offset: 0x000028DB
		public bool configuredInWorldSpace
		{
			get
			{
				return ConfigurableJoint.get_configuredInWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_configuredInWorldSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x000046EE File Offset: 0x000028EE
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00004700 File Offset: 0x00002900
		public bool swapBodies
		{
			get
			{
				return ConfigurableJoint.get_swapBodiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ConfigurableJoint.set_swapBodiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00004713 File Offset: 0x00002913
		public void get_secondaryAxis_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_secondaryAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00004726 File Offset: 0x00002926
		public void set_secondaryAxis_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_secondaryAxis_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00004739 File Offset: 0x00002939
		public void get_targetPosition_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000474C File Offset: 0x0000294C
		public void set_targetPosition_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000475F File Offset: 0x0000295F
		public void get_targetVelocity_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00004772 File Offset: 0x00002972
		public void set_targetVelocity_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004785 File Offset: 0x00002985
		public void get_targetRotation_Injected(out Quaternion ret)
		{
			ConfigurableJoint.get_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00004798 File Offset: 0x00002998
		public void set_targetRotation_Injected(ref Quaternion value)
		{
			ConfigurableJoint.set_targetRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000047AB File Offset: 0x000029AB
		public void get_targetAngularVelocity_Injected(out Vector3 ret)
		{
			ConfigurableJoint.get_targetAngularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000047BE File Offset: 0x000029BE
		public void set_targetAngularVelocity_Injected(ref Vector3 value)
		{
			ConfigurableJoint.set_targetAngularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040002E4 RID: 740
		private static readonly ConfigurableJoint.get_xMotionDelegate get_xMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_xMotionDelegate>("UnityEngine.ConfigurableJoint::get_xMotion");

		// Token: 0x040002E5 RID: 741
		private static readonly ConfigurableJoint.set_xMotionDelegate set_xMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_xMotionDelegate>("UnityEngine.ConfigurableJoint::set_xMotion");

		// Token: 0x040002E6 RID: 742
		private static readonly ConfigurableJoint.get_yMotionDelegate get_yMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_yMotionDelegate>("UnityEngine.ConfigurableJoint::get_yMotion");

		// Token: 0x040002E7 RID: 743
		private static readonly ConfigurableJoint.set_yMotionDelegate set_yMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_yMotionDelegate>("UnityEngine.ConfigurableJoint::set_yMotion");

		// Token: 0x040002E8 RID: 744
		private static readonly ConfigurableJoint.get_zMotionDelegate get_zMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_zMotionDelegate>("UnityEngine.ConfigurableJoint::get_zMotion");

		// Token: 0x040002E9 RID: 745
		private static readonly ConfigurableJoint.set_zMotionDelegate set_zMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_zMotionDelegate>("UnityEngine.ConfigurableJoint::set_zMotion");

		// Token: 0x040002EA RID: 746
		private static readonly ConfigurableJoint.get_angularXMotionDelegate get_angularXMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularXMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularXMotion");

		// Token: 0x040002EB RID: 747
		private static readonly ConfigurableJoint.set_angularXMotionDelegate set_angularXMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularXMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularXMotion");

		// Token: 0x040002EC RID: 748
		private static readonly ConfigurableJoint.get_angularYMotionDelegate get_angularYMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularYMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularYMotion");

		// Token: 0x040002ED RID: 749
		private static readonly ConfigurableJoint.set_angularYMotionDelegate set_angularYMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularYMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularYMotion");

		// Token: 0x040002EE RID: 750
		private static readonly ConfigurableJoint.get_angularZMotionDelegate get_angularZMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_angularZMotionDelegate>("UnityEngine.ConfigurableJoint::get_angularZMotion");

		// Token: 0x040002EF RID: 751
		private static readonly ConfigurableJoint.set_angularZMotionDelegate set_angularZMotionDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_angularZMotionDelegate>("UnityEngine.ConfigurableJoint::set_angularZMotion");

		// Token: 0x040002F0 RID: 752
		private static readonly ConfigurableJoint.get_rotationDriveModeDelegate get_rotationDriveModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_rotationDriveModeDelegate>("UnityEngine.ConfigurableJoint::get_rotationDriveMode");

		// Token: 0x040002F1 RID: 753
		private static readonly ConfigurableJoint.set_rotationDriveModeDelegate set_rotationDriveModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_rotationDriveModeDelegate>("UnityEngine.ConfigurableJoint::set_rotationDriveMode");

		// Token: 0x040002F2 RID: 754
		private static readonly ConfigurableJoint.get_projectionModeDelegate get_projectionModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionModeDelegate>("UnityEngine.ConfigurableJoint::get_projectionMode");

		// Token: 0x040002F3 RID: 755
		private static readonly ConfigurableJoint.set_projectionModeDelegate set_projectionModeDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionModeDelegate>("UnityEngine.ConfigurableJoint::set_projectionMode");

		// Token: 0x040002F4 RID: 756
		private static readonly ConfigurableJoint.get_projectionDistanceDelegate get_projectionDistanceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionDistanceDelegate>("UnityEngine.ConfigurableJoint::get_projectionDistance");

		// Token: 0x040002F5 RID: 757
		private static readonly ConfigurableJoint.set_projectionDistanceDelegate set_projectionDistanceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionDistanceDelegate>("UnityEngine.ConfigurableJoint::set_projectionDistance");

		// Token: 0x040002F6 RID: 758
		private static readonly ConfigurableJoint.get_projectionAngleDelegate get_projectionAngleDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_projectionAngleDelegate>("UnityEngine.ConfigurableJoint::get_projectionAngle");

		// Token: 0x040002F7 RID: 759
		private static readonly ConfigurableJoint.set_projectionAngleDelegate set_projectionAngleDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_projectionAngleDelegate>("UnityEngine.ConfigurableJoint::set_projectionAngle");

		// Token: 0x040002F8 RID: 760
		private static readonly ConfigurableJoint.get_configuredInWorldSpaceDelegate get_configuredInWorldSpaceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_configuredInWorldSpaceDelegate>("UnityEngine.ConfigurableJoint::get_configuredInWorldSpace");

		// Token: 0x040002F9 RID: 761
		private static readonly ConfigurableJoint.set_configuredInWorldSpaceDelegate set_configuredInWorldSpaceDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_configuredInWorldSpaceDelegate>("UnityEngine.ConfigurableJoint::set_configuredInWorldSpace");

		// Token: 0x040002FA RID: 762
		private static readonly ConfigurableJoint.get_swapBodiesDelegate get_swapBodiesDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_swapBodiesDelegate>("UnityEngine.ConfigurableJoint::get_swapBodies");

		// Token: 0x040002FB RID: 763
		private static readonly ConfigurableJoint.set_swapBodiesDelegate set_swapBodiesDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_swapBodiesDelegate>("UnityEngine.ConfigurableJoint::set_swapBodies");

		// Token: 0x040002FC RID: 764
		private static readonly ConfigurableJoint.get_secondaryAxis_InjectedDelegate get_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_secondaryAxis_Injected");

		// Token: 0x040002FD RID: 765
		private static readonly ConfigurableJoint.set_secondaryAxis_InjectedDelegate set_secondaryAxis_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_secondaryAxis_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_secondaryAxis_Injected");

		// Token: 0x040002FE RID: 766
		private static readonly ConfigurableJoint.get_targetPosition_InjectedDelegate get_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetPosition_Injected");

		// Token: 0x040002FF RID: 767
		private static readonly ConfigurableJoint.set_targetPosition_InjectedDelegate set_targetPosition_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetPosition_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetPosition_Injected");

		// Token: 0x04000300 RID: 768
		private static readonly ConfigurableJoint.get_targetVelocity_InjectedDelegate get_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetVelocity_Injected");

		// Token: 0x04000301 RID: 769
		private static readonly ConfigurableJoint.set_targetVelocity_InjectedDelegate set_targetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetVelocity_Injected");

		// Token: 0x04000302 RID: 770
		private static readonly ConfigurableJoint.get_targetRotation_InjectedDelegate get_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetRotation_Injected");

		// Token: 0x04000303 RID: 771
		private static readonly ConfigurableJoint.set_targetRotation_InjectedDelegate set_targetRotation_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetRotation_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetRotation_Injected");

		// Token: 0x04000304 RID: 772
		private static readonly ConfigurableJoint.get_targetAngularVelocity_InjectedDelegate get_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.get_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::get_targetAngularVelocity_Injected");

		// Token: 0x04000305 RID: 773
		private static readonly ConfigurableJoint.set_targetAngularVelocity_InjectedDelegate set_targetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ConfigurableJoint.set_targetAngularVelocity_InjectedDelegate>("UnityEngine.ConfigurableJoint::set_targetAngularVelocity_Injected");

		// Token: 0x020001B7 RID: 439
		// (Invoke) Token: 0x06000746 RID: 1862
		private delegate ConfigurableJointMotion get_xMotionDelegate(IntPtr @this);

		// Token: 0x020001B8 RID: 440
		// (Invoke) Token: 0x06000748 RID: 1864
		private delegate void set_xMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x020001B9 RID: 441
		// (Invoke) Token: 0x0600074A RID: 1866
		private delegate ConfigurableJointMotion get_yMotionDelegate(IntPtr @this);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x0600074C RID: 1868
		private delegate void set_yMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x0600074E RID: 1870
		private delegate ConfigurableJointMotion get_zMotionDelegate(IntPtr @this);

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x06000750 RID: 1872
		private delegate void set_zMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x06000752 RID: 1874
		private delegate ConfigurableJointMotion get_angularXMotionDelegate(IntPtr @this);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x06000754 RID: 1876
		private delegate void set_angularXMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x06000756 RID: 1878
		private delegate ConfigurableJointMotion get_angularYMotionDelegate(IntPtr @this);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x06000758 RID: 1880
		private delegate void set_angularYMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x020001C1 RID: 449
		// (Invoke) Token: 0x0600075A RID: 1882
		private delegate ConfigurableJointMotion get_angularZMotionDelegate(IntPtr @this);

		// Token: 0x020001C2 RID: 450
		// (Invoke) Token: 0x0600075C RID: 1884
		private delegate void set_angularZMotionDelegate(IntPtr @this, ConfigurableJointMotion value);

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x0600075E RID: 1886
		private delegate RotationDriveMode get_rotationDriveModeDelegate(IntPtr @this);

		// Token: 0x020001C4 RID: 452
		// (Invoke) Token: 0x06000760 RID: 1888
		private delegate void set_rotationDriveModeDelegate(IntPtr @this, RotationDriveMode value);

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x06000762 RID: 1890
		private delegate JointProjectionMode get_projectionModeDelegate(IntPtr @this);

		// Token: 0x020001C6 RID: 454
		// (Invoke) Token: 0x06000764 RID: 1892
		private delegate void set_projectionModeDelegate(IntPtr @this, JointProjectionMode value);

		// Token: 0x020001C7 RID: 455
		// (Invoke) Token: 0x06000766 RID: 1894
		private delegate float get_projectionDistanceDelegate(IntPtr @this);

		// Token: 0x020001C8 RID: 456
		// (Invoke) Token: 0x06000768 RID: 1896
		private delegate void set_projectionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x0600076A RID: 1898
		private delegate float get_projectionAngleDelegate(IntPtr @this);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x0600076C RID: 1900
		private delegate void set_projectionAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x0600076E RID: 1902
		private delegate bool get_configuredInWorldSpaceDelegate(IntPtr @this);

		// Token: 0x020001CC RID: 460
		// (Invoke) Token: 0x06000770 RID: 1904
		private delegate void set_configuredInWorldSpaceDelegate(IntPtr @this, bool value);

		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x06000772 RID: 1906
		private delegate bool get_swapBodiesDelegate(IntPtr @this);

		// Token: 0x020001CE RID: 462
		// (Invoke) Token: 0x06000774 RID: 1908
		private delegate void set_swapBodiesDelegate(IntPtr @this, bool value);

		// Token: 0x020001CF RID: 463
		// (Invoke) Token: 0x06000776 RID: 1910
		private delegate void get_secondaryAxis_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x06000778 RID: 1912
		private delegate void set_secondaryAxis_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x0600077A RID: 1914
		private delegate void get_targetPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x0600077C RID: 1916
		private delegate void set_targetPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001D3 RID: 467
		// (Invoke) Token: 0x0600077E RID: 1918
		private delegate void get_targetVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001D4 RID: 468
		// (Invoke) Token: 0x06000780 RID: 1920
		private delegate void set_targetVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x06000782 RID: 1922
		private delegate void get_targetRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001D6 RID: 470
		// (Invoke) Token: 0x06000784 RID: 1924
		private delegate void set_targetRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001D7 RID: 471
		// (Invoke) Token: 0x06000786 RID: 1926
		private delegate void get_targetAngularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x06000788 RID: 1928
		private delegate void set_targetAngularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
