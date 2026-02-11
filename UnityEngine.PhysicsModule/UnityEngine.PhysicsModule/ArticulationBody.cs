using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public class ArticulationBody : Behaviour
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000035C3 File Offset: 0x000017C3
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000035D5 File Offset: 0x000017D5
		public ArticulationJointType jointType
		{
			get
			{
				return ArticulationBody.get_jointTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_jointTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000BB24 File Offset: 0x00009D24
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000035E8 File Offset: 0x000017E8
		public Vector3 anchorPosition
		{
			get
			{
				Vector3 vector;
				this.get_anchorPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchorPosition_Injected(ref value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000BB3C File Offset: 0x00009D3C
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x000035F2 File Offset: 0x000017F2
		public Vector3 parentAnchorPosition
		{
			get
			{
				Vector3 vector;
				this.get_parentAnchorPosition_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_parentAnchorPosition_Injected(ref value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000BB54 File Offset: 0x00009D54
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x000035FC File Offset: 0x000017FC
		public Quaternion anchorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_anchorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_anchorRotation_Injected(ref value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000BB6C File Offset: 0x00009D6C
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00003606 File Offset: 0x00001806
		public Quaternion parentAnchorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_parentAnchorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_parentAnchorRotation_Injected(ref value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00003610 File Offset: 0x00001810
		public bool isRoot
		{
			get
			{
				return ArticulationBody.get_isRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00003622 File Offset: 0x00001822
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00003634 File Offset: 0x00001834
		public bool matchAnchors
		{
			get
			{
				return ArticulationBody.get_matchAnchorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_matchAnchorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00003647 File Offset: 0x00001847
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00003659 File Offset: 0x00001859
		public ArticulationDofLock linearLockX
		{
			get
			{
				return ArticulationBody.get_linearLockXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000366C File Offset: 0x0000186C
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000367E File Offset: 0x0000187E
		public ArticulationDofLock linearLockY
		{
			get
			{
				return ArticulationBody.get_linearLockYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00003691 File Offset: 0x00001891
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000036A3 File Offset: 0x000018A3
		public ArticulationDofLock linearLockZ
		{
			get
			{
				return ArticulationBody.get_linearLockZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearLockZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000304 RID: 772 RVA: 0x000036B6 File Offset: 0x000018B6
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000036C8 File Offset: 0x000018C8
		public ArticulationDofLock swingYLock
		{
			get
			{
				return ArticulationBody.get_swingYLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_swingYLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000036DB File Offset: 0x000018DB
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000036ED File Offset: 0x000018ED
		public ArticulationDofLock swingZLock
		{
			get
			{
				return ArticulationBody.get_swingZLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_swingZLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00003700 File Offset: 0x00001900
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003712 File Offset: 0x00001912
		public ArticulationDofLock twistLock
		{
			get
			{
				return ArticulationBody.get_twistLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_twistLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00003725 File Offset: 0x00001925
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003737 File Offset: 0x00001937
		public bool immovable
		{
			get
			{
				return ArticulationBody.get_immovableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_immovableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000374A File Offset: 0x0000194A
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0000375C File Offset: 0x0000195C
		public bool useGravity
		{
			get
			{
				return ArticulationBody.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000376F File Offset: 0x0000196F
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003781 File Offset: 0x00001981
		public float linearDamping
		{
			get
			{
				return ArticulationBody.get_linearDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_linearDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00003794 File Offset: 0x00001994
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000037A6 File Offset: 0x000019A6
		public float angularDamping
		{
			get
			{
				return ArticulationBody.get_angularDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_angularDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000037B9 File Offset: 0x000019B9
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000037CB File Offset: 0x000019CB
		public float jointFriction
		{
			get
			{
				return ArticulationBody.get_jointFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_jointFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000BB84 File Offset: 0x00009D84
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000037DE File Offset: 0x000019DE
		public LayerMask excludeLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_excludeLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_excludeLayers_Injected(ref value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000BB9C File Offset: 0x00009D9C
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000037E8 File Offset: 0x000019E8
		public LayerMask includeLayers
		{
			get
			{
				LayerMask layerMask;
				this.get_includeLayers_Injected(out layerMask);
				return layerMask;
			}
			set
			{
				this.set_includeLayers_Injected(ref value);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public Vector3 GetAccumulatedForce(float step)
		{
			Vector3 vector;
			this.GetAccumulatedForce_Injected(step, out vector);
			return vector;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public Vector3 GetAccumulatedForce()
		{
			return this.GetAccumulatedForce(Time.fixedDeltaTime);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000BBEC File Offset: 0x00009DEC
		public Vector3 GetAccumulatedTorque(float step)
		{
			Vector3 vector;
			this.GetAccumulatedTorque_Injected(step, out vector);
			return vector;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000BC04 File Offset: 0x00009E04
		public Vector3 GetAccumulatedTorque()
		{
			return this.GetAccumulatedTorque(Time.fixedDeltaTime);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000037F2 File Offset: 0x000019F2
		public void AddForce(Vector3 force, ForceMode mode)
		{
			this.AddForce_Injected(ref force, mode);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000037FD File Offset: 0x000019FD
		public void AddForce(Vector3 force)
		{
			this.AddForce(force, ForceMode.Force);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00003809 File Offset: 0x00001A09
		public void AddRelativeForce(Vector3 force, ForceMode mode)
		{
			this.AddRelativeForce_Injected(ref force, mode);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003814 File Offset: 0x00001A14
		public void AddRelativeForce(Vector3 force)
		{
			this.AddRelativeForce(force, ForceMode.Force);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003820 File Offset: 0x00001A20
		public void AddTorque(Vector3 torque, ForceMode mode)
		{
			this.AddTorque_Injected(ref torque, mode);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000382B File Offset: 0x00001A2B
		public void AddTorque(Vector3 torque)
		{
			this.AddTorque(torque, ForceMode.Force);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003837 File Offset: 0x00001A37
		public void AddRelativeTorque(Vector3 torque, ForceMode mode)
		{
			this.AddRelativeTorque_Injected(ref torque, mode);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003842 File Offset: 0x00001A42
		public void AddRelativeTorque(Vector3 torque)
		{
			this.AddRelativeTorque(torque, ForceMode.Force);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000384E File Offset: 0x00001A4E
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
		{
			this.AddForceAtPosition_Injected(ref force, ref position, mode);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000385B File Offset: 0x00001A5B
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			this.AddForceAtPosition(force, position, ForceMode.Force);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000BC24 File Offset: 0x00009E24
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003868 File Offset: 0x00001A68
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000BC3C File Offset: 0x00009E3C
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00003872 File Offset: 0x00001A72
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.get_angularVelocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_angularVelocity_Injected(ref value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000387C File Offset: 0x00001A7C
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000388E File Offset: 0x00001A8E
		public float mass
		{
			get
			{
				return ArticulationBody.get_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_massDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000038A1 File Offset: 0x00001AA1
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000038B3 File Offset: 0x00001AB3
		public bool automaticCenterOfMass
		{
			get
			{
				return ArticulationBody.get_automaticCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_automaticCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000BC54 File Offset: 0x00009E54
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000038C6 File Offset: 0x00001AC6
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.get_centerOfMass_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_centerOfMass_Injected(ref value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.get_worldCenterOfMass_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000331 RID: 817 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x06000332 RID: 818 RVA: 0x000038E2 File Offset: 0x00001AE2
		public bool automaticInertiaTensor
		{
			get
			{
				return ArticulationBody.get_automaticInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_automaticInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000BC84 File Offset: 0x00009E84
		// (set) Token: 0x06000334 RID: 820 RVA: 0x000038F5 File Offset: 0x00001AF5
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.get_inertiaTensor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_inertiaTensor_Injected(ref value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000BC9C File Offset: 0x00009E9C
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000038FF File Offset: 0x00001AFF
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.get_inertiaTensorRotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_inertiaTensorRotation_Injected(ref value);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003909 File Offset: 0x00001B09
		public void ResetCenterOfMass()
		{
			ArticulationBody.ResetCenterOfMassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000391B File Offset: 0x00001B1B
		public void ResetInertiaTensor()
		{
			ArticulationBody.ResetInertiaTensorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000392D File Offset: 0x00001B2D
		public void Sleep()
		{
			ArticulationBody.SleepDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000393F File Offset: 0x00001B3F
		public bool IsSleeping()
		{
			return ArticulationBody.IsSleepingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003951 File Offset: 0x00001B51
		public void WakeUp()
		{
			ArticulationBody.WakeUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00003963 File Offset: 0x00001B63
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003975 File Offset: 0x00001B75
		public float sleepThreshold
		{
			get
			{
				return ArticulationBody.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00003988 File Offset: 0x00001B88
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000399A File Offset: 0x00001B9A
		public int solverIterations
		{
			get
			{
				return ArticulationBody.get_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_solverIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000039AD File Offset: 0x00001BAD
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000039BF File Offset: 0x00001BBF
		public int solverVelocityIterations
		{
			get
			{
				return ArticulationBody.get_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_solverVelocityIterationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000039D2 File Offset: 0x00001BD2
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000039E4 File Offset: 0x00001BE4
		public float maxAngularVelocity
		{
			get
			{
				return ArticulationBody.get_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxAngularVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000039F7 File Offset: 0x00001BF7
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003A09 File Offset: 0x00001C09
		public float maxLinearVelocity
		{
			get
			{
				return ArticulationBody.get_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxLinearVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00003A1C File Offset: 0x00001C1C
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003A2E File Offset: 0x00001C2E
		public float maxJointVelocity
		{
			get
			{
				return ArticulationBody.get_maxJointVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxJointVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00003A41 File Offset: 0x00001C41
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003A53 File Offset: 0x00001C53
		public float maxDepenetrationVelocity
		{
			get
			{
				return ArticulationBody.get_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_maxDepenetrationVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00003A66 File Offset: 0x00001C66
		public int dofCount
		{
			get
			{
				return ArticulationBody.get_dofCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00003A78 File Offset: 0x00001C78
		public int index
		{
			get
			{
				return ArticulationBody.get_indexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003A8A File Offset: 0x00001C8A
		public void TeleportRoot(Vector3 position, Quaternion rotation)
		{
			this.TeleportRoot_Injected(ref position, ref rotation);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		public Vector3 GetClosestPoint(Vector3 point)
		{
			Vector3 vector;
			this.GetClosestPoint_Injected(ref point, out vector);
			return vector;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000BCCC File Offset: 0x00009ECC
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			Vector3 vector;
			this.GetRelativePointVelocity_Injected(ref relativePoint, out vector);
			return vector;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			Vector3 vector;
			this.GetPointVelocity_Injected(ref worldPoint, out vector);
			return vector;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003A96 File Offset: 0x00001C96
		public int GetJointPositions(List<float> positions)
		{
			return ArticulationBody.GetJointPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003AAE File Offset: 0x00001CAE
		public void SetJointPositions(List<float> positions)
		{
			ArticulationBody.SetJointPositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(positions));
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003AC6 File Offset: 0x00001CC6
		public int GetJointVelocities(List<float> velocities)
		{
			return ArticulationBody.GetJointVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(velocities));
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00003ADE File Offset: 0x00001CDE
		public void SetJointVelocities(List<float> velocities)
		{
			ArticulationBody.SetJointVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(velocities));
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003AF6 File Offset: 0x00001CF6
		public int GetJointAccelerations(List<float> accelerations)
		{
			return ArticulationBody.GetJointAccelerationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerations));
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003B0E File Offset: 0x00001D0E
		public int GetJointForces(List<float> forces)
		{
			return ArticulationBody.GetJointForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003B26 File Offset: 0x00001D26
		public void SetJointForces(List<float> forces)
		{
			ArticulationBody.SetJointForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003B3E File Offset: 0x00001D3E
		public int GetDriveForces(List<float> forces)
		{
			return ArticulationBody.GetDriveForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003B56 File Offset: 0x00001D56
		public int GetJointGravityForces(List<float> forces)
		{
			return ArticulationBody.GetJointGravityForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003B6E File Offset: 0x00001D6E
		public int GetJointCoriolisCentrifugalForces(List<float> forces)
		{
			return ArticulationBody.GetJointCoriolisCentrifugalForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces));
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003B86 File Offset: 0x00001D86
		public int GetJointExternalForces(List<float> forces, float step)
		{
			return ArticulationBody.GetJointExternalForcesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(forces), step);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003B9F File Offset: 0x00001D9F
		public int GetDriveTargets(List<float> targets)
		{
			return ArticulationBody.GetDriveTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targets));
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003BB7 File Offset: 0x00001DB7
		public void SetDriveTargets(List<float> targets)
		{
			ArticulationBody.SetDriveTargetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targets));
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003BCF File Offset: 0x00001DCF
		public int GetDriveTargetVelocities(List<float> targetVelocities)
		{
			return ArticulationBody.GetDriveTargetVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetVelocities));
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003BE7 File Offset: 0x00001DE7
		public void SetDriveTargetVelocities(List<float> targetVelocities)
		{
			ArticulationBody.SetDriveTargetVelocitiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetVelocities));
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003BFF File Offset: 0x00001DFF
		public int GetDofStartIndices(List<int> dofStartIndices)
		{
			return ArticulationBody.GetDofStartIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dofStartIndices));
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003C17 File Offset: 0x00001E17
		public void SetDriveTarget(ArticulationDriveAxis axis, float value)
		{
			ArticulationBody.SetDriveTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), axis, value);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003C2B File Offset: 0x00001E2B
		public void SetDriveTargetVelocity(ArticulationDriveAxis axis, float value)
		{
			ArticulationBody.SetDriveTargetVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), axis, value);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003C3F File Offset: 0x00001E3F
		public void SetDriveLimits(ArticulationDriveAxis axis, float lower, float upper)
		{
			ArticulationBody.SetDriveLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), axis, lower, upper);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00003C54 File Offset: 0x00001E54
		public void SetDriveStiffness(ArticulationDriveAxis axis, float value)
		{
			ArticulationBody.SetDriveStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), axis, value);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003C68 File Offset: 0x00001E68
		public void SetDriveDamping(ArticulationDriveAxis axis, float value)
		{
			ArticulationBody.SetDriveDampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), axis, value);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003C7C File Offset: 0x00001E7C
		public void SetDriveForceLimit(ArticulationDriveAxis axis, float value)
		{
			ArticulationBody.SetDriveForceLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), axis, value);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00003C90 File Offset: 0x00001E90
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003CA2 File Offset: 0x00001EA2
		public CollisionDetectionMode collisionDetectionMode
		{
			get
			{
				return ArticulationBody.get_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ArticulationBody.set_collisionDetectionModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000BCFC File Offset: 0x00009EFC
		public void SnapAnchorToClosestContact()
		{
			bool flag = !base.transform.parent;
			if (!flag)
			{
				ArticulationBody articulationBody = base.transform.parent.GetComponentInParent<ArticulationBody>();
				while (articulationBody && !articulationBody.enabled)
				{
					articulationBody = articulationBody.transform.parent.GetComponentInParent<ArticulationBody>();
				}
				bool flag2 = !articulationBody;
				if (!flag2)
				{
					Vector3 worldCenterOfMass = articulationBody.worldCenterOfMass;
					Vector3 closestPoint = this.GetClosestPoint(worldCenterOfMass);
					this.anchorPosition = base.transform.InverseTransformPoint(closestPoint);
					this.anchorRotation = Quaternion.FromToRotation(Vector3.right, base.transform.InverseTransformDirection(worldCenterOfMass - closestPoint).normalized);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00003CB5 File Offset: 0x00001EB5
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00003CBD File Offset: 0x00001EBD
		public bool computeParentAnchor
		{
			get
			{
				return this.matchAnchors;
			}
			set
			{
				this.matchAnchors = value;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003CC7 File Offset: 0x00001EC7
		public void SetJointAccelerations(List<float> accelerations)
		{
			ArticulationBody.SetJointAccelerationsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(accelerations));
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003CDF File Offset: 0x00001EDF
		public void get_anchorPosition_Injected(out Vector3 ret)
		{
			ArticulationBody.get_anchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003CF2 File Offset: 0x00001EF2
		public void set_anchorPosition_Injected(ref Vector3 value)
		{
			ArticulationBody.set_anchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003D05 File Offset: 0x00001F05
		public void get_parentAnchorPosition_Injected(out Vector3 ret)
		{
			ArticulationBody.get_parentAnchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003D18 File Offset: 0x00001F18
		public void set_parentAnchorPosition_Injected(ref Vector3 value)
		{
			ArticulationBody.set_parentAnchorPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003D2B File Offset: 0x00001F2B
		public void get_anchorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_anchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003D3E File Offset: 0x00001F3E
		public void set_anchorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_anchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003D51 File Offset: 0x00001F51
		public void get_parentAnchorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_parentAnchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003D64 File Offset: 0x00001F64
		public void set_parentAnchorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_parentAnchorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00003D77 File Offset: 0x00001F77
		public void get_excludeLayers_Injected(out LayerMask ret)
		{
			ArticulationBody.get_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00003D8A File Offset: 0x00001F8A
		public void set_excludeLayers_Injected(ref LayerMask value)
		{
			ArticulationBody.set_excludeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003D9D File Offset: 0x00001F9D
		public void get_includeLayers_Injected(out LayerMask ret)
		{
			ArticulationBody.get_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public void set_includeLayers_Injected(ref LayerMask value)
		{
			ArticulationBody.set_includeLayers_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003DC3 File Offset: 0x00001FC3
		public void GetAccumulatedForce_Injected(float step, out Vector3 ret)
		{
			ArticulationBody.GetAccumulatedForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), step, out ret);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003DD7 File Offset: 0x00001FD7
		public void GetAccumulatedTorque_Injected(float step, out Vector3 ret)
		{
			ArticulationBody.GetAccumulatedTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), step, out ret);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003DEB File Offset: 0x00001FEB
		public void AddForce_Injected(ref Vector3 force, ForceMode mode)
		{
			ArticulationBody.AddForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00003DFF File Offset: 0x00001FFF
		public void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode)
		{
			ArticulationBody.AddRelativeForce_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, mode);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003E13 File Offset: 0x00002013
		public void AddTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			ArticulationBody.AddTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003E27 File Offset: 0x00002027
		public void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode)
		{
			ArticulationBody.AddRelativeTorque_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref torque, mode);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003E3B File Offset: 0x0000203B
		public void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode)
		{
			ArticulationBody.AddForceAtPosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref force, ref position, mode);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00003E50 File Offset: 0x00002050
		public void get_velocity_Injected(out Vector3 ret)
		{
			ArticulationBody.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00003E63 File Offset: 0x00002063
		public void set_velocity_Injected(ref Vector3 value)
		{
			ArticulationBody.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003E76 File Offset: 0x00002076
		public void get_angularVelocity_Injected(out Vector3 ret)
		{
			ArticulationBody.get_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00003E89 File Offset: 0x00002089
		public void set_angularVelocity_Injected(ref Vector3 value)
		{
			ArticulationBody.set_angularVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003E9C File Offset: 0x0000209C
		public void get_centerOfMass_Injected(out Vector3 ret)
		{
			ArticulationBody.get_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00003EAF File Offset: 0x000020AF
		public void set_centerOfMass_Injected(ref Vector3 value)
		{
			ArticulationBody.set_centerOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00003EC2 File Offset: 0x000020C2
		public void get_worldCenterOfMass_Injected(out Vector3 ret)
		{
			ArticulationBody.get_worldCenterOfMass_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003ED5 File Offset: 0x000020D5
		public void get_inertiaTensor_Injected(out Vector3 ret)
		{
			ArticulationBody.get_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00003EE8 File Offset: 0x000020E8
		public void set_inertiaTensor_Injected(ref Vector3 value)
		{
			ArticulationBody.set_inertiaTensor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003EFB File Offset: 0x000020FB
		public void get_inertiaTensorRotation_Injected(out Quaternion ret)
		{
			ArticulationBody.get_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003F0E File Offset: 0x0000210E
		public void set_inertiaTensorRotation_Injected(ref Quaternion value)
		{
			ArticulationBody.set_inertiaTensorRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003F21 File Offset: 0x00002121
		public void TeleportRoot_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			ArticulationBody.TeleportRoot_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, ref rotation);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003F35 File Offset: 0x00002135
		public void GetClosestPoint_Injected(ref Vector3 point, out Vector3 ret)
		{
			ArticulationBody.GetClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, out ret);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003F49 File Offset: 0x00002149
		public void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret)
		{
			ArticulationBody.GetRelativePointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativePoint, out ret);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003F5D File Offset: 0x0000215D
		public void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
		{
			ArticulationBody.GetPointVelocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref worldPoint, out ret);
		}

		// Token: 0x04000223 RID: 547
		private static readonly ArticulationBody.get_jointTypeDelegate get_jointTypeDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_jointTypeDelegate>("UnityEngine.ArticulationBody::get_jointType");

		// Token: 0x04000224 RID: 548
		private static readonly ArticulationBody.set_jointTypeDelegate set_jointTypeDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_jointTypeDelegate>("UnityEngine.ArticulationBody::set_jointType");

		// Token: 0x04000225 RID: 549
		private static readonly ArticulationBody.get_isRootDelegate get_isRootDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_isRootDelegate>("UnityEngine.ArticulationBody::get_isRoot");

		// Token: 0x04000226 RID: 550
		private static readonly ArticulationBody.get_matchAnchorsDelegate get_matchAnchorsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_matchAnchorsDelegate>("UnityEngine.ArticulationBody::get_matchAnchors");

		// Token: 0x04000227 RID: 551
		private static readonly ArticulationBody.set_matchAnchorsDelegate set_matchAnchorsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_matchAnchorsDelegate>("UnityEngine.ArticulationBody::set_matchAnchors");

		// Token: 0x04000228 RID: 552
		private static readonly ArticulationBody.get_linearLockXDelegate get_linearLockXDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockXDelegate>("UnityEngine.ArticulationBody::get_linearLockX");

		// Token: 0x04000229 RID: 553
		private static readonly ArticulationBody.set_linearLockXDelegate set_linearLockXDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockXDelegate>("UnityEngine.ArticulationBody::set_linearLockX");

		// Token: 0x0400022A RID: 554
		private static readonly ArticulationBody.get_linearLockYDelegate get_linearLockYDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockYDelegate>("UnityEngine.ArticulationBody::get_linearLockY");

		// Token: 0x0400022B RID: 555
		private static readonly ArticulationBody.set_linearLockYDelegate set_linearLockYDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockYDelegate>("UnityEngine.ArticulationBody::set_linearLockY");

		// Token: 0x0400022C RID: 556
		private static readonly ArticulationBody.get_linearLockZDelegate get_linearLockZDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearLockZDelegate>("UnityEngine.ArticulationBody::get_linearLockZ");

		// Token: 0x0400022D RID: 557
		private static readonly ArticulationBody.set_linearLockZDelegate set_linearLockZDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearLockZDelegate>("UnityEngine.ArticulationBody::set_linearLockZ");

		// Token: 0x0400022E RID: 558
		private static readonly ArticulationBody.get_swingYLockDelegate get_swingYLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_swingYLockDelegate>("UnityEngine.ArticulationBody::get_swingYLock");

		// Token: 0x0400022F RID: 559
		private static readonly ArticulationBody.set_swingYLockDelegate set_swingYLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_swingYLockDelegate>("UnityEngine.ArticulationBody::set_swingYLock");

		// Token: 0x04000230 RID: 560
		private static readonly ArticulationBody.get_swingZLockDelegate get_swingZLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_swingZLockDelegate>("UnityEngine.ArticulationBody::get_swingZLock");

		// Token: 0x04000231 RID: 561
		private static readonly ArticulationBody.set_swingZLockDelegate set_swingZLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_swingZLockDelegate>("UnityEngine.ArticulationBody::set_swingZLock");

		// Token: 0x04000232 RID: 562
		private static readonly ArticulationBody.get_twistLockDelegate get_twistLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_twistLockDelegate>("UnityEngine.ArticulationBody::get_twistLock");

		// Token: 0x04000233 RID: 563
		private static readonly ArticulationBody.set_twistLockDelegate set_twistLockDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_twistLockDelegate>("UnityEngine.ArticulationBody::set_twistLock");

		// Token: 0x04000234 RID: 564
		private static readonly ArticulationBody.get_immovableDelegate get_immovableDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_immovableDelegate>("UnityEngine.ArticulationBody::get_immovable");

		// Token: 0x04000235 RID: 565
		private static readonly ArticulationBody.set_immovableDelegate set_immovableDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_immovableDelegate>("UnityEngine.ArticulationBody::set_immovable");

		// Token: 0x04000236 RID: 566
		private static readonly ArticulationBody.get_useGravityDelegate get_useGravityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_useGravityDelegate>("UnityEngine.ArticulationBody::get_useGravity");

		// Token: 0x04000237 RID: 567
		private static readonly ArticulationBody.set_useGravityDelegate set_useGravityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_useGravityDelegate>("UnityEngine.ArticulationBody::set_useGravity");

		// Token: 0x04000238 RID: 568
		private static readonly ArticulationBody.get_linearDampingDelegate get_linearDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_linearDampingDelegate>("UnityEngine.ArticulationBody::get_linearDamping");

		// Token: 0x04000239 RID: 569
		private static readonly ArticulationBody.set_linearDampingDelegate set_linearDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_linearDampingDelegate>("UnityEngine.ArticulationBody::set_linearDamping");

		// Token: 0x0400023A RID: 570
		private static readonly ArticulationBody.get_angularDampingDelegate get_angularDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_angularDampingDelegate>("UnityEngine.ArticulationBody::get_angularDamping");

		// Token: 0x0400023B RID: 571
		private static readonly ArticulationBody.set_angularDampingDelegate set_angularDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_angularDampingDelegate>("UnityEngine.ArticulationBody::set_angularDamping");

		// Token: 0x0400023C RID: 572
		private static readonly ArticulationBody.get_jointFrictionDelegate get_jointFrictionDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_jointFrictionDelegate>("UnityEngine.ArticulationBody::get_jointFriction");

		// Token: 0x0400023D RID: 573
		private static readonly ArticulationBody.set_jointFrictionDelegate set_jointFrictionDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_jointFrictionDelegate>("UnityEngine.ArticulationBody::set_jointFriction");

		// Token: 0x0400023E RID: 574
		private static readonly ArticulationBody.get_massDelegate get_massDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_massDelegate>("UnityEngine.ArticulationBody::get_mass");

		// Token: 0x0400023F RID: 575
		private static readonly ArticulationBody.set_massDelegate set_massDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_massDelegate>("UnityEngine.ArticulationBody::set_mass");

		// Token: 0x04000240 RID: 576
		private static readonly ArticulationBody.get_automaticCenterOfMassDelegate get_automaticCenterOfMassDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_automaticCenterOfMassDelegate>("UnityEngine.ArticulationBody::get_automaticCenterOfMass");

		// Token: 0x04000241 RID: 577
		private static readonly ArticulationBody.set_automaticCenterOfMassDelegate set_automaticCenterOfMassDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_automaticCenterOfMassDelegate>("UnityEngine.ArticulationBody::set_automaticCenterOfMass");

		// Token: 0x04000242 RID: 578
		private static readonly ArticulationBody.get_automaticInertiaTensorDelegate get_automaticInertiaTensorDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_automaticInertiaTensorDelegate>("UnityEngine.ArticulationBody::get_automaticInertiaTensor");

		// Token: 0x04000243 RID: 579
		private static readonly ArticulationBody.set_automaticInertiaTensorDelegate set_automaticInertiaTensorDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_automaticInertiaTensorDelegate>("UnityEngine.ArticulationBody::set_automaticInertiaTensor");

		// Token: 0x04000244 RID: 580
		private static readonly ArticulationBody.ResetCenterOfMassDelegate ResetCenterOfMassDelegateField = IL2CPP.ResolveICall<ArticulationBody.ResetCenterOfMassDelegate>("UnityEngine.ArticulationBody::ResetCenterOfMass");

		// Token: 0x04000245 RID: 581
		private static readonly ArticulationBody.ResetInertiaTensorDelegate ResetInertiaTensorDelegateField = IL2CPP.ResolveICall<ArticulationBody.ResetInertiaTensorDelegate>("UnityEngine.ArticulationBody::ResetInertiaTensor");

		// Token: 0x04000246 RID: 582
		private static readonly ArticulationBody.SleepDelegate SleepDelegateField = IL2CPP.ResolveICall<ArticulationBody.SleepDelegate>("UnityEngine.ArticulationBody::Sleep");

		// Token: 0x04000247 RID: 583
		private static readonly ArticulationBody.IsSleepingDelegate IsSleepingDelegateField = IL2CPP.ResolveICall<ArticulationBody.IsSleepingDelegate>("UnityEngine.ArticulationBody::IsSleeping");

		// Token: 0x04000248 RID: 584
		private static readonly ArticulationBody.WakeUpDelegate WakeUpDelegateField = IL2CPP.ResolveICall<ArticulationBody.WakeUpDelegate>("UnityEngine.ArticulationBody::WakeUp");

		// Token: 0x04000249 RID: 585
		private static readonly ArticulationBody.get_sleepThresholdDelegate get_sleepThresholdDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_sleepThresholdDelegate>("UnityEngine.ArticulationBody::get_sleepThreshold");

		// Token: 0x0400024A RID: 586
		private static readonly ArticulationBody.set_sleepThresholdDelegate set_sleepThresholdDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_sleepThresholdDelegate>("UnityEngine.ArticulationBody::set_sleepThreshold");

		// Token: 0x0400024B RID: 587
		private static readonly ArticulationBody.get_solverIterationsDelegate get_solverIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_solverIterationsDelegate>("UnityEngine.ArticulationBody::get_solverIterations");

		// Token: 0x0400024C RID: 588
		private static readonly ArticulationBody.set_solverIterationsDelegate set_solverIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_solverIterationsDelegate>("UnityEngine.ArticulationBody::set_solverIterations");

		// Token: 0x0400024D RID: 589
		private static readonly ArticulationBody.get_solverVelocityIterationsDelegate get_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_solverVelocityIterationsDelegate>("UnityEngine.ArticulationBody::get_solverVelocityIterations");

		// Token: 0x0400024E RID: 590
		private static readonly ArticulationBody.set_solverVelocityIterationsDelegate set_solverVelocityIterationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_solverVelocityIterationsDelegate>("UnityEngine.ArticulationBody::set_solverVelocityIterations");

		// Token: 0x0400024F RID: 591
		private static readonly ArticulationBody.get_maxAngularVelocityDelegate get_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxAngularVelocityDelegate>("UnityEngine.ArticulationBody::get_maxAngularVelocity");

		// Token: 0x04000250 RID: 592
		private static readonly ArticulationBody.set_maxAngularVelocityDelegate set_maxAngularVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxAngularVelocityDelegate>("UnityEngine.ArticulationBody::set_maxAngularVelocity");

		// Token: 0x04000251 RID: 593
		private static readonly ArticulationBody.get_maxLinearVelocityDelegate get_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxLinearVelocityDelegate>("UnityEngine.ArticulationBody::get_maxLinearVelocity");

		// Token: 0x04000252 RID: 594
		private static readonly ArticulationBody.set_maxLinearVelocityDelegate set_maxLinearVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxLinearVelocityDelegate>("UnityEngine.ArticulationBody::set_maxLinearVelocity");

		// Token: 0x04000253 RID: 595
		private static readonly ArticulationBody.get_maxJointVelocityDelegate get_maxJointVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxJointVelocityDelegate>("UnityEngine.ArticulationBody::get_maxJointVelocity");

		// Token: 0x04000254 RID: 596
		private static readonly ArticulationBody.set_maxJointVelocityDelegate set_maxJointVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxJointVelocityDelegate>("UnityEngine.ArticulationBody::set_maxJointVelocity");

		// Token: 0x04000255 RID: 597
		private static readonly ArticulationBody.get_maxDepenetrationVelocityDelegate get_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_maxDepenetrationVelocityDelegate>("UnityEngine.ArticulationBody::get_maxDepenetrationVelocity");

		// Token: 0x04000256 RID: 598
		private static readonly ArticulationBody.set_maxDepenetrationVelocityDelegate set_maxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_maxDepenetrationVelocityDelegate>("UnityEngine.ArticulationBody::set_maxDepenetrationVelocity");

		// Token: 0x04000257 RID: 599
		private static readonly ArticulationBody.get_dofCountDelegate get_dofCountDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_dofCountDelegate>("UnityEngine.ArticulationBody::get_dofCount");

		// Token: 0x04000258 RID: 600
		private static readonly ArticulationBody.get_indexDelegate get_indexDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_indexDelegate>("UnityEngine.ArticulationBody::get_index");

		// Token: 0x04000259 RID: 601
		private static readonly ArticulationBody.GetJointPositionsDelegate GetJointPositionsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointPositionsDelegate>("UnityEngine.ArticulationBody::GetJointPositions");

		// Token: 0x0400025A RID: 602
		private static readonly ArticulationBody.SetJointPositionsDelegate SetJointPositionsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointPositionsDelegate>("UnityEngine.ArticulationBody::SetJointPositions");

		// Token: 0x0400025B RID: 603
		private static readonly ArticulationBody.GetJointVelocitiesDelegate GetJointVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointVelocitiesDelegate>("UnityEngine.ArticulationBody::GetJointVelocities");

		// Token: 0x0400025C RID: 604
		private static readonly ArticulationBody.SetJointVelocitiesDelegate SetJointVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointVelocitiesDelegate>("UnityEngine.ArticulationBody::SetJointVelocities");

		// Token: 0x0400025D RID: 605
		private static readonly ArticulationBody.GetJointAccelerationsDelegate GetJointAccelerationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointAccelerationsDelegate>("UnityEngine.ArticulationBody::GetJointAccelerations");

		// Token: 0x0400025E RID: 606
		private static readonly ArticulationBody.GetJointForcesDelegate GetJointForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointForcesDelegate>("UnityEngine.ArticulationBody::GetJointForces");

		// Token: 0x0400025F RID: 607
		private static readonly ArticulationBody.SetJointForcesDelegate SetJointForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointForcesDelegate>("UnityEngine.ArticulationBody::SetJointForces");

		// Token: 0x04000260 RID: 608
		private static readonly ArticulationBody.GetDriveForcesDelegate GetDriveForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveForcesDelegate>("UnityEngine.ArticulationBody::GetDriveForces");

		// Token: 0x04000261 RID: 609
		private static readonly ArticulationBody.GetJointGravityForcesDelegate GetJointGravityForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointGravityForcesDelegate>("UnityEngine.ArticulationBody::GetJointGravityForces");

		// Token: 0x04000262 RID: 610
		private static readonly ArticulationBody.GetJointCoriolisCentrifugalForcesDelegate GetJointCoriolisCentrifugalForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointCoriolisCentrifugalForcesDelegate>("UnityEngine.ArticulationBody::GetJointCoriolisCentrifugalForces");

		// Token: 0x04000263 RID: 611
		private static readonly ArticulationBody.GetJointExternalForcesDelegate GetJointExternalForcesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetJointExternalForcesDelegate>("UnityEngine.ArticulationBody::GetJointExternalForces");

		// Token: 0x04000264 RID: 612
		private static readonly ArticulationBody.GetDriveTargetsDelegate GetDriveTargetsDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveTargetsDelegate>("UnityEngine.ArticulationBody::GetDriveTargets");

		// Token: 0x04000265 RID: 613
		private static readonly ArticulationBody.SetDriveTargetsDelegate SetDriveTargetsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetsDelegate>("UnityEngine.ArticulationBody::SetDriveTargets");

		// Token: 0x04000266 RID: 614
		private static readonly ArticulationBody.GetDriveTargetVelocitiesDelegate GetDriveTargetVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDriveTargetVelocitiesDelegate>("UnityEngine.ArticulationBody::GetDriveTargetVelocities");

		// Token: 0x04000267 RID: 615
		private static readonly ArticulationBody.SetDriveTargetVelocitiesDelegate SetDriveTargetVelocitiesDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetVelocitiesDelegate>("UnityEngine.ArticulationBody::SetDriveTargetVelocities");

		// Token: 0x04000268 RID: 616
		private static readonly ArticulationBody.GetDofStartIndicesDelegate GetDofStartIndicesDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetDofStartIndicesDelegate>("UnityEngine.ArticulationBody::GetDofStartIndices");

		// Token: 0x04000269 RID: 617
		private static readonly ArticulationBody.SetDriveTargetDelegate SetDriveTargetDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetDelegate>("UnityEngine.ArticulationBody::SetDriveTarget");

		// Token: 0x0400026A RID: 618
		private static readonly ArticulationBody.SetDriveTargetVelocityDelegate SetDriveTargetVelocityDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveTargetVelocityDelegate>("UnityEngine.ArticulationBody::SetDriveTargetVelocity");

		// Token: 0x0400026B RID: 619
		private static readonly ArticulationBody.SetDriveLimitsDelegate SetDriveLimitsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveLimitsDelegate>("UnityEngine.ArticulationBody::SetDriveLimits");

		// Token: 0x0400026C RID: 620
		private static readonly ArticulationBody.SetDriveStiffnessDelegate SetDriveStiffnessDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveStiffnessDelegate>("UnityEngine.ArticulationBody::SetDriveStiffness");

		// Token: 0x0400026D RID: 621
		private static readonly ArticulationBody.SetDriveDampingDelegate SetDriveDampingDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveDampingDelegate>("UnityEngine.ArticulationBody::SetDriveDamping");

		// Token: 0x0400026E RID: 622
		private static readonly ArticulationBody.SetDriveForceLimitDelegate SetDriveForceLimitDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetDriveForceLimitDelegate>("UnityEngine.ArticulationBody::SetDriveForceLimit");

		// Token: 0x0400026F RID: 623
		private static readonly ArticulationBody.get_collisionDetectionModeDelegate get_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_collisionDetectionModeDelegate>("UnityEngine.ArticulationBody::get_collisionDetectionMode");

		// Token: 0x04000270 RID: 624
		private static readonly ArticulationBody.set_collisionDetectionModeDelegate set_collisionDetectionModeDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_collisionDetectionModeDelegate>("UnityEngine.ArticulationBody::set_collisionDetectionMode");

		// Token: 0x04000271 RID: 625
		private static readonly ArticulationBody.SetJointAccelerationsDelegate SetJointAccelerationsDelegateField = IL2CPP.ResolveICall<ArticulationBody.SetJointAccelerationsDelegate>("UnityEngine.ArticulationBody::SetJointAccelerations");

		// Token: 0x04000272 RID: 626
		private static readonly ArticulationBody.get_anchorPosition_InjectedDelegate get_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorPosition_Injected");

		// Token: 0x04000273 RID: 627
		private static readonly ArticulationBody.set_anchorPosition_InjectedDelegate set_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorPosition_Injected");

		// Token: 0x04000274 RID: 628
		private static readonly ArticulationBody.get_parentAnchorPosition_InjectedDelegate get_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorPosition_Injected");

		// Token: 0x04000275 RID: 629
		private static readonly ArticulationBody.set_parentAnchorPosition_InjectedDelegate set_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorPosition_Injected");

		// Token: 0x04000276 RID: 630
		private static readonly ArticulationBody.get_anchorRotation_InjectedDelegate get_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorRotation_Injected");

		// Token: 0x04000277 RID: 631
		private static readonly ArticulationBody.set_anchorRotation_InjectedDelegate set_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorRotation_Injected");

		// Token: 0x04000278 RID: 632
		private static readonly ArticulationBody.get_parentAnchorRotation_InjectedDelegate get_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorRotation_Injected");

		// Token: 0x04000279 RID: 633
		private static readonly ArticulationBody.set_parentAnchorRotation_InjectedDelegate set_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorRotation_Injected");

		// Token: 0x0400027A RID: 634
		private static readonly ArticulationBody.get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_excludeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::get_excludeLayers_Injected");

		// Token: 0x0400027B RID: 635
		private static readonly ArticulationBody.set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_excludeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::set_excludeLayers_Injected");

		// Token: 0x0400027C RID: 636
		private static readonly ArticulationBody.get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_includeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::get_includeLayers_Injected");

		// Token: 0x0400027D RID: 637
		private static readonly ArticulationBody.set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_includeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::set_includeLayers_Injected");

		// Token: 0x0400027E RID: 638
		private static readonly ArticulationBody.GetAccumulatedForce_InjectedDelegate GetAccumulatedForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetAccumulatedForce_InjectedDelegate>("UnityEngine.ArticulationBody::GetAccumulatedForce_Injected");

		// Token: 0x0400027F RID: 639
		private static readonly ArticulationBody.GetAccumulatedTorque_InjectedDelegate GetAccumulatedTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetAccumulatedTorque_InjectedDelegate>("UnityEngine.ArticulationBody::GetAccumulatedTorque_Injected");

		// Token: 0x04000280 RID: 640
		private static readonly ArticulationBody.AddForce_InjectedDelegate AddForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddForce_Injected");

		// Token: 0x04000281 RID: 641
		private static readonly ArticulationBody.AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddRelativeForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeForce_Injected");

		// Token: 0x04000282 RID: 642
		private static readonly ArticulationBody.AddTorque_InjectedDelegate AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddTorque_Injected");

		// Token: 0x04000283 RID: 643
		private static readonly ArticulationBody.AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddRelativeTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeTorque_Injected");

		// Token: 0x04000284 RID: 644
		private static readonly ArticulationBody.AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.AddForceAtPosition_InjectedDelegate>("UnityEngine.ArticulationBody::AddForceAtPosition_Injected");

		// Token: 0x04000285 RID: 645
		private static readonly ArticulationBody.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_velocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_velocity_Injected");

		// Token: 0x04000286 RID: 646
		private static readonly ArticulationBody.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_velocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_velocity_Injected");

		// Token: 0x04000287 RID: 647
		private static readonly ArticulationBody.get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_angularVelocity_Injected");

		// Token: 0x04000288 RID: 648
		private static readonly ArticulationBody.set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_angularVelocity_Injected");

		// Token: 0x04000289 RID: 649
		private static readonly ArticulationBody.get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_centerOfMass_Injected");

		// Token: 0x0400028A RID: 650
		private static readonly ArticulationBody.set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::set_centerOfMass_Injected");

		// Token: 0x0400028B RID: 651
		private static readonly ArticulationBody.get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_worldCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_worldCenterOfMass_Injected");

		// Token: 0x0400028C RID: 652
		private static readonly ArticulationBody.get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensor_Injected");

		// Token: 0x0400028D RID: 653
		private static readonly ArticulationBody.set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensor_Injected");

		// Token: 0x0400028E RID: 654
		private static readonly ArticulationBody.get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensorRotation_Injected");

		// Token: 0x0400028F RID: 655
		private static readonly ArticulationBody.set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensorRotation_Injected");

		// Token: 0x04000290 RID: 656
		private static readonly ArticulationBody.TeleportRoot_InjectedDelegate TeleportRoot_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.TeleportRoot_InjectedDelegate>("UnityEngine.ArticulationBody::TeleportRoot_Injected");

		// Token: 0x04000291 RID: 657
		private static readonly ArticulationBody.GetClosestPoint_InjectedDelegate GetClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetClosestPoint_InjectedDelegate>("UnityEngine.ArticulationBody::GetClosestPoint_Injected");

		// Token: 0x04000292 RID: 658
		private static readonly ArticulationBody.GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetRelativePointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetRelativePointVelocity_Injected");

		// Token: 0x04000293 RID: 659
		private static readonly ArticulationBody.GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<ArticulationBody.GetPointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetPointVelocity_Injected");

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060005D0 RID: 1488
		private delegate ArticulationJointType get_jointTypeDelegate(IntPtr @this);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060005D2 RID: 1490
		private delegate void set_jointTypeDelegate(IntPtr @this, ArticulationJointType value);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x060005D4 RID: 1492
		private delegate bool get_isRootDelegate(IntPtr @this);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x060005D6 RID: 1494
		private delegate bool get_matchAnchorsDelegate(IntPtr @this);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060005D8 RID: 1496
		private delegate void set_matchAnchorsDelegate(IntPtr @this, bool value);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060005DA RID: 1498
		private delegate ArticulationDofLock get_linearLockXDelegate(IntPtr @this);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060005DC RID: 1500
		private delegate void set_linearLockXDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060005DE RID: 1502
		private delegate ArticulationDofLock get_linearLockYDelegate(IntPtr @this);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060005E0 RID: 1504
		private delegate void set_linearLockYDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060005E2 RID: 1506
		private delegate ArticulationDofLock get_linearLockZDelegate(IntPtr @this);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060005E4 RID: 1508
		private delegate void set_linearLockZDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060005E6 RID: 1510
		private delegate ArticulationDofLock get_swingYLockDelegate(IntPtr @this);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060005E8 RID: 1512
		private delegate void set_swingYLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060005EA RID: 1514
		private delegate ArticulationDofLock get_swingZLockDelegate(IntPtr @this);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060005EC RID: 1516
		private delegate void set_swingZLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060005EE RID: 1518
		private delegate ArticulationDofLock get_twistLockDelegate(IntPtr @this);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060005F0 RID: 1520
		private delegate void set_twistLockDelegate(IntPtr @this, ArticulationDofLock value);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060005F2 RID: 1522
		private delegate bool get_immovableDelegate(IntPtr @this);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060005F4 RID: 1524
		private delegate void set_immovableDelegate(IntPtr @this, bool value);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060005F6 RID: 1526
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060005F8 RID: 1528
		private delegate void set_useGravityDelegate(IntPtr @this, bool value);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060005FA RID: 1530
		private delegate float get_linearDampingDelegate(IntPtr @this);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x060005FC RID: 1532
		private delegate void set_linearDampingDelegate(IntPtr @this, float value);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x060005FE RID: 1534
		private delegate float get_angularDampingDelegate(IntPtr @this);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x06000600 RID: 1536
		private delegate void set_angularDampingDelegate(IntPtr @this, float value);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x06000602 RID: 1538
		private delegate float get_jointFrictionDelegate(IntPtr @this);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x06000604 RID: 1540
		private delegate void set_jointFrictionDelegate(IntPtr @this, float value);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x06000606 RID: 1542
		private delegate float get_massDelegate(IntPtr @this);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x06000608 RID: 1544
		private delegate void set_massDelegate(IntPtr @this, float value);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x0600060A RID: 1546
		private delegate bool get_automaticCenterOfMassDelegate(IntPtr @this);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x0600060C RID: 1548
		private delegate void set_automaticCenterOfMassDelegate(IntPtr @this, bool value);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x0600060E RID: 1550
		private delegate bool get_automaticInertiaTensorDelegate(IntPtr @this);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x06000610 RID: 1552
		private delegate void set_automaticInertiaTensorDelegate(IntPtr @this, bool value);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x06000612 RID: 1554
		private delegate void ResetCenterOfMassDelegate(IntPtr @this);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x06000614 RID: 1556
		private delegate void ResetInertiaTensorDelegate(IntPtr @this);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x06000616 RID: 1558
		private delegate void SleepDelegate(IntPtr @this);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x06000618 RID: 1560
		private delegate bool IsSleepingDelegate(IntPtr @this);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x0600061A RID: 1562
		private delegate void WakeUpDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x0600061C RID: 1564
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x0600061E RID: 1566
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x06000620 RID: 1568
		private delegate int get_solverIterationsDelegate(IntPtr @this);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000622 RID: 1570
		private delegate void set_solverIterationsDelegate(IntPtr @this, int value);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000624 RID: 1572
		private delegate int get_solverVelocityIterationsDelegate(IntPtr @this);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x06000626 RID: 1574
		private delegate void set_solverVelocityIterationsDelegate(IntPtr @this, int value);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate float get_maxAngularVelocityDelegate(IntPtr @this);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate void set_maxAngularVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate float get_maxLinearVelocityDelegate(IntPtr @this);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate void set_maxLinearVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate float get_maxJointVelocityDelegate(IntPtr @this);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate void set_maxJointVelocityDelegate(IntPtr @this, float value);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate float get_maxDepenetrationVelocityDelegate(IntPtr @this);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void set_maxDepenetrationVelocityDelegate(IntPtr @this, float value);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate int get_dofCountDelegate(IntPtr @this);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate int get_indexDelegate(IntPtr @this);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate int GetJointPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate void SetJointPositionsDelegate(IntPtr @this, IntPtr positions);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate int GetJointVelocitiesDelegate(IntPtr @this, IntPtr velocities);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate void SetJointVelocitiesDelegate(IntPtr @this, IntPtr velocities);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate int GetJointAccelerationsDelegate(IntPtr @this, IntPtr accelerations);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000646 RID: 1606
		private delegate int GetJointForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000648 RID: 1608
		private delegate void SetJointForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x0600064A RID: 1610
		private delegate int GetDriveForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x0600064C RID: 1612
		private delegate int GetJointGravityForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600064E RID: 1614
		private delegate int GetJointCoriolisCentrifugalForcesDelegate(IntPtr @this, IntPtr forces);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x06000650 RID: 1616
		private delegate int GetJointExternalForcesDelegate(IntPtr @this, IntPtr forces, float step);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000652 RID: 1618
		private delegate int GetDriveTargetsDelegate(IntPtr @this, IntPtr targets);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x06000654 RID: 1620
		private delegate void SetDriveTargetsDelegate(IntPtr @this, IntPtr targets);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x06000656 RID: 1622
		private delegate int GetDriveTargetVelocitiesDelegate(IntPtr @this, IntPtr targetVelocities);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x06000658 RID: 1624
		private delegate void SetDriveTargetVelocitiesDelegate(IntPtr @this, IntPtr targetVelocities);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x0600065A RID: 1626
		private delegate int GetDofStartIndicesDelegate(IntPtr @this, IntPtr dofStartIndices);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x0600065C RID: 1628
		private delegate void SetDriveTargetDelegate(IntPtr @this, ArticulationDriveAxis axis, float value);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x0600065E RID: 1630
		private delegate void SetDriveTargetVelocityDelegate(IntPtr @this, ArticulationDriveAxis axis, float value);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x06000660 RID: 1632
		private delegate void SetDriveLimitsDelegate(IntPtr @this, ArticulationDriveAxis axis, float lower, float upper);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000662 RID: 1634
		private delegate void SetDriveStiffnessDelegate(IntPtr @this, ArticulationDriveAxis axis, float value);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000664 RID: 1636
		private delegate void SetDriveDampingDelegate(IntPtr @this, ArticulationDriveAxis axis, float value);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x06000666 RID: 1638
		private delegate void SetDriveForceLimitDelegate(IntPtr @this, ArticulationDriveAxis axis, float value);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x06000668 RID: 1640
		private delegate CollisionDetectionMode get_collisionDetectionModeDelegate(IntPtr @this);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x0600066A RID: 1642
		private delegate void set_collisionDetectionModeDelegate(IntPtr @this, CollisionDetectionMode value);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x0600066C RID: 1644
		private delegate void SetJointAccelerationsDelegate(IntPtr @this, IntPtr accelerations);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x0600066E RID: 1646
		private delegate void get_anchorPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x06000670 RID: 1648
		private delegate void set_anchorPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000672 RID: 1650
		private delegate void get_parentAnchorPosition_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x06000674 RID: 1652
		private delegate void set_parentAnchorPosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x06000676 RID: 1654
		private delegate void get_anchorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x06000678 RID: 1656
		private delegate void set_anchorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x0600067A RID: 1658
		private delegate void get_parentAnchorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x0600067C RID: 1660
		private delegate void set_parentAnchorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x0600067E RID: 1662
		private delegate void get_excludeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x06000680 RID: 1664
		private delegate void set_excludeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x06000682 RID: 1666
		private delegate void get_includeLayers_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x06000684 RID: 1668
		private delegate void set_includeLayers_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x06000686 RID: 1670
		private delegate void GetAccumulatedForce_InjectedDelegate(IntPtr @this, float step, [Out] IntPtr ret);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x06000688 RID: 1672
		private delegate void GetAccumulatedTorque_InjectedDelegate(IntPtr @this, float step, [Out] IntPtr ret);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x0600068A RID: 1674
		private delegate void AddForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode mode);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x0600068C RID: 1676
		private delegate void AddRelativeForce_InjectedDelegate(IntPtr @this, IntPtr force, ForceMode mode);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x0600068E RID: 1678
		private delegate void AddTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x0200015C RID: 348
		// (Invoke) Token: 0x06000690 RID: 1680
		private delegate void AddRelativeTorque_InjectedDelegate(IntPtr @this, IntPtr torque, ForceMode mode);

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x06000692 RID: 1682
		private delegate void AddForceAtPosition_InjectedDelegate(IntPtr @this, IntPtr force, IntPtr position, ForceMode mode);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x06000694 RID: 1684
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x06000696 RID: 1686
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x06000698 RID: 1688
		private delegate void get_angularVelocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x0600069A RID: 1690
		private delegate void set_angularVelocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate void get_centerOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate void set_centerOfMass_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x060006A0 RID: 1696
		private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060006A2 RID: 1698
		private delegate void get_inertiaTensor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060006A4 RID: 1700
		private delegate void set_inertiaTensor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060006A6 RID: 1702
		private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060006A8 RID: 1704
		private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060006AA RID: 1706
		private delegate void TeleportRoot_InjectedDelegate(IntPtr @this, IntPtr position, IntPtr rotation);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060006AC RID: 1708
		private delegate void GetClosestPoint_InjectedDelegate(IntPtr @this, IntPtr point, [Out] IntPtr ret);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060006AE RID: 1710
		private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr @this, IntPtr relativePoint, [Out] IntPtr ret);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060006B0 RID: 1712
		private delegate void GetPointVelocity_InjectedDelegate(IntPtr @this, IntPtr worldPoint, [Out] IntPtr ret);
	}
}
