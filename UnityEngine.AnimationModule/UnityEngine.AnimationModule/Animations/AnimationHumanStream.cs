using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000028 RID: 40
	[StructLayout(2)]
	public struct AnimationHumanStream
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationHumanStream()
		{
			Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationHumanStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr);
			AnimationHumanStream.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, "stream");
			AnimationHumanStream.GetHumanScale_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetHumanScale_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetHumanScale_Injected");
			AnimationHumanStream.GetFootHeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetFootHeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetFootHeight_Injected");
			AnimationHumanStream.InternalResetToStancePose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalResetToStancePose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalResetToStancePose_Injected");
			AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalPositionFromPose_Injected");
			AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalRotationFromPose_Injected");
			AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyLocalPosition_Injected");
			AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyLocalPosition_Injected");
			AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyLocalRotation_Injected");
			AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyLocalRotation_Injected");
			AnimationHumanStream.InternalGetBodyPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyPosition_Injected");
			AnimationHumanStream.InternalSetBodyPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyPosition_Injected");
			AnimationHumanStream.InternalGetBodyRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyRotation_Injected");
			AnimationHumanStream.InternalSetBodyRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyRotation_Injected");
			AnimationHumanStream.GetLeftFootVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetLeftFootVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetLeftFootVelocity_Injected");
			AnimationHumanStream.GetRightFootVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetRightFootVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetRightFootVelocity_Injected");
			AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalLocalPosition_Injected");
			AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalLocalPosition_Injected");
			AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalLocalRotation_Injected");
			AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalLocalRotation_Injected");
			AnimationHumanStream.InternalGetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalPosition_Injected");
			AnimationHumanStream.InternalSetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalPosition_Injected");
			AnimationHumanStream.InternalGetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalRotation_Injected");
			AnimationHumanStream.InternalSetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalRotation_Injected");
			AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalWeightPosition_Injected");
			AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalWeightRotation_Injected");
			AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalWeightPosition_Injected");
			AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalWeightRotation_Injected");
			AnimationHumanStream.InternalGetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetHintPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetHintPosition_Injected");
			AnimationHumanStream.InternalSetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetHintPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetHintPosition_Injected");
			AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetHintWeightPosition_Injected");
			AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetHintWeightPosition_Injected");
			AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtPosition_Injected");
			AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtClampWeight_Injected");
			AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtBodyWeight_Injected");
			AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtHeadWeight_Injected");
			AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtEyesWeight_Injected");
			AnimationHumanStream.InternalSolveIK_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSolveIK_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSolveIK_Injected");
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002A7B File Offset: 0x00000C7B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, ref this));
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00010268 File Offset: 0x0000E468
		public bool isValid
		{
			get
			{
				return this.stream != IntPtr.Zero;
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001028C File Offset: 0x0000E48C
		public void ThrowIfInvalid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new InvalidOperationException("The AnimationHumanStream is invalid.");
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000102B4 File Offset: 0x0000E4B4
		public float humanScale
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetHumanScale();
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000102D4 File Offset: 0x0000E4D4
		public float leftFootHeight
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetFootHeight(true);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000102F4 File Offset: 0x0000E4F4
		public float rightFootHeight
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetFootHeight(false);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00010314 File Offset: 0x0000E514
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002A8D File Offset: 0x00000C8D
		public Vector3 bodyLocalPosition
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyLocalPosition();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyLocalPosition(value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00010334 File Offset: 0x0000E534
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00002A9F File Offset: 0x00000C9F
		public Quaternion bodyLocalRotation
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyLocalRotation();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyLocalRotation(value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00010354 File Offset: 0x0000E554
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00002AB1 File Offset: 0x00000CB1
		public Vector3 bodyPosition
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyPosition();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyPosition(value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00010374 File Offset: 0x0000E574
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00002AC3 File Offset: 0x00000CC3
		public Quaternion bodyRotation
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyRotation();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyRotation(value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00010394 File Offset: 0x0000E594
		public Vector3 leftFootVelocity
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetLeftFootVelocity();
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x000103B4 File Offset: 0x0000E5B4
		public Vector3 rightFootVelocity
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetRightFootVelocity();
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002AD5 File Offset: 0x00000CD5
		public void ResetToStancePose()
		{
			this.ThrowIfInvalid();
			this.InternalResetToStancePose();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000103D4 File Offset: 0x0000E5D4
		public Vector3 GetGoalPositionFromPose(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalPositionFromPose(index);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000103F4 File Offset: 0x0000E5F4
		public Quaternion GetGoalRotationFromPose(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalRotationFromPose(index);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00010414 File Offset: 0x0000E614
		public Vector3 GetGoalLocalPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalLocalPosition(index);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public void SetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalLocalPosition(index, pos);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00010434 File Offset: 0x0000E634
		public Quaternion GetGoalLocalRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalLocalRotation(index);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public void SetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalLocalRotation(index, rot);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00010454 File Offset: 0x0000E654
		public Vector3 GetGoalPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalPosition(index);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002B0C File Offset: 0x00000D0C
		public void SetGoalPosition(AvatarIKGoal index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalPosition(index, pos);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00010474 File Offset: 0x0000E674
		public Quaternion GetGoalRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalRotation(index);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002B1F File Offset: 0x00000D1F
		public void SetGoalRotation(AvatarIKGoal index, Quaternion rot)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalRotation(index, rot);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002B32 File Offset: 0x00000D32
		public void SetGoalWeightPosition(AvatarIKGoal index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalWeightPosition(index, value);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002B45 File Offset: 0x00000D45
		public void SetGoalWeightRotation(AvatarIKGoal index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalWeightRotation(index, value);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00010494 File Offset: 0x0000E694
		public float GetGoalWeightPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalWeightPosition(index);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000104B4 File Offset: 0x0000E6B4
		public float GetGoalWeightRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalWeightRotation(index);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000104D4 File Offset: 0x0000E6D4
		public Vector3 GetHintPosition(AvatarIKHint index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetHintPosition(index);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002B58 File Offset: 0x00000D58
		public void SetHintPosition(AvatarIKHint index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetHintPosition(index, pos);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002B6B File Offset: 0x00000D6B
		public void SetHintWeightPosition(AvatarIKHint index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetHintWeightPosition(index, value);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000104F4 File Offset: 0x0000E6F4
		public float GetHintWeightPosition(AvatarIKHint index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetHintWeightPosition(index);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002B7E File Offset: 0x00000D7E
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtPosition(lookAtPosition);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002B90 File Offset: 0x00000D90
		public void SetLookAtClampWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtClampWeight(weight);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public void SetLookAtBodyWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtBodyWeight(weight);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public void SetLookAtHeadWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtHeadWeight(weight);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public void SetLookAtEyesWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtEyesWeight(weight);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public void SolveIK()
		{
			this.ThrowIfInvalid();
			this.InternalSolveIK();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002BE9 File Offset: 0x00000DE9
		public float GetHumanScale()
		{
			return AnimationHumanStream.GetHumanScale_Injected(ref this);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002BF1 File Offset: 0x00000DF1
		public float GetFootHeight(bool left)
		{
			return AnimationHumanStream.GetFootHeight_Injected(ref this, left);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002BFA File Offset: 0x00000DFA
		public void InternalResetToStancePose()
		{
			AnimationHumanStream.InternalResetToStancePose_Injected(ref this);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00010514 File Offset: 0x0000E714
		public Vector3 InternalGetGoalPositionFromPose(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalPositionFromPose_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001052C File Offset: 0x0000E72C
		public Quaternion InternalGetGoalRotationFromPose(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalRotationFromPose_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00010544 File Offset: 0x0000E744
		public Vector3 InternalGetBodyLocalPosition()
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetBodyLocalPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002C02 File Offset: 0x00000E02
		public void InternalSetBodyLocalPosition(Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyLocalPosition_Injected(ref this, ref value);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001055C File Offset: 0x0000E75C
		public Quaternion InternalGetBodyLocalRotation()
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetBodyLocalRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002C0C File Offset: 0x00000E0C
		public void InternalSetBodyLocalRotation(Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyLocalRotation_Injected(ref this, ref value);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00010574 File Offset: 0x0000E774
		public Vector3 InternalGetBodyPosition()
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetBodyPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002C16 File Offset: 0x00000E16
		public void InternalSetBodyPosition(Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyPosition_Injected(ref this, ref value);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001058C File Offset: 0x0000E78C
		public Quaternion InternalGetBodyRotation()
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetBodyRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002C20 File Offset: 0x00000E20
		public void InternalSetBodyRotation(Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyRotation_Injected(ref this, ref value);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000105A4 File Offset: 0x0000E7A4
		public Vector3 GetLeftFootVelocity()
		{
			Vector3 vector;
			AnimationHumanStream.GetLeftFootVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000105BC File Offset: 0x0000E7BC
		public Vector3 GetRightFootVelocity()
		{
			Vector3 vector;
			AnimationHumanStream.GetRightFootVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000105D4 File Offset: 0x0000E7D4
		public Vector3 InternalGetGoalLocalPosition(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalLocalPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002C2A File Offset: 0x00000E2A
		public void InternalSetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalLocalPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000105EC File Offset: 0x0000E7EC
		public Quaternion InternalGetGoalLocalRotation(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalLocalRotation_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002C35 File Offset: 0x00000E35
		public void InternalSetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalLocalRotation_Injected(ref this, index, ref rot);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00010604 File Offset: 0x0000E804
		public Vector3 InternalGetGoalPosition(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002C40 File Offset: 0x00000E40
		public void InternalSetGoalPosition(AvatarIKGoal index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001061C File Offset: 0x0000E81C
		public Quaternion InternalGetGoalRotation(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalRotation_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002C4B File Offset: 0x00000E4B
		public void InternalSetGoalRotation(AvatarIKGoal index, Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalRotation_Injected(ref this, index, ref rot);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002C56 File Offset: 0x00000E56
		public void InternalSetGoalWeightPosition(AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightPosition_Injected(ref this, index, value);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002C60 File Offset: 0x00000E60
		public void InternalSetGoalWeightRotation(AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightRotation_Injected(ref this, index, value);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002C6A File Offset: 0x00000E6A
		public float InternalGetGoalWeightPosition(AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightPosition_Injected(ref this, index);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002C73 File Offset: 0x00000E73
		public float InternalGetGoalWeightRotation(AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightRotation_Injected(ref this, index);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00010634 File Offset: 0x0000E834
		public Vector3 InternalGetHintPosition(AvatarIKHint index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetHintPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002C7C File Offset: 0x00000E7C
		public void InternalSetHintPosition(AvatarIKHint index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetHintPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002C87 File Offset: 0x00000E87
		public void InternalSetHintWeightPosition(AvatarIKHint index, float value)
		{
			AnimationHumanStream.InternalSetHintWeightPosition_Injected(ref this, index, value);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002C91 File Offset: 0x00000E91
		public float InternalGetHintWeightPosition(AvatarIKHint index)
		{
			return AnimationHumanStream.InternalGetHintWeightPosition_Injected(ref this, index);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002C9A File Offset: 0x00000E9A
		public void InternalSetLookAtPosition(Vector3 lookAtPosition)
		{
			AnimationHumanStream.InternalSetLookAtPosition_Injected(ref this, ref lookAtPosition);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public void InternalSetLookAtClampWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtClampWeight_Injected(ref this, weight);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002CAD File Offset: 0x00000EAD
		public void InternalSetLookAtBodyWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtBodyWeight_Injected(ref this, weight);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002CB6 File Offset: 0x00000EB6
		public void InternalSetLookAtHeadWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtHeadWeight_Injected(ref this, weight);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002CBF File Offset: 0x00000EBF
		public void InternalSetLookAtEyesWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtEyesWeight_Injected(ref this, weight);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public void InternalSolveIK()
		{
			AnimationHumanStream.InternalSolveIK_Injected(ref this);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public static float GetHumanScale_Injected(ref AnimationHumanStream _unity_self)
		{
			return AnimationHumanStream.GetHumanScale_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002CDD File Offset: 0x00000EDD
		public static float GetFootHeight_Injected(ref AnimationHumanStream _unity_self, bool left)
		{
			return AnimationHumanStream.GetFootHeight_InjectedDelegateField(ref _unity_self, left);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002CEB File Offset: 0x00000EEB
		public static void InternalResetToStancePose_Injected(ref AnimationHumanStream _unity_self)
		{
			AnimationHumanStream.InternalResetToStancePose_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public static void InternalGetGoalPositionFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002D07 File Offset: 0x00000F07
		public static void InternalGetGoalRotationFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002D16 File Offset: 0x00000F16
		public static void InternalGetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002D24 File Offset: 0x00000F24
		public static void InternalSetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002D32 File Offset: 0x00000F32
		public static void InternalGetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002D40 File Offset: 0x00000F40
		public static void InternalSetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, ref Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002D4E File Offset: 0x00000F4E
		public static void InternalGetBodyPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetBodyPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002D5C File Offset: 0x00000F5C
		public static void InternalSetBodyPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyPosition_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002D6A File Offset: 0x00000F6A
		public static void InternalGetBodyRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetBodyRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002D78 File Offset: 0x00000F78
		public static void InternalSetBodyRotation_Injected(ref AnimationHumanStream _unity_self, ref Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyRotation_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002D86 File Offset: 0x00000F86
		public static void GetLeftFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.GetLeftFootVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002D94 File Offset: 0x00000F94
		public static void GetRightFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.GetRightFootVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public static void InternalGetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002DB1 File Offset: 0x00000FB1
		public static void InternalSetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public static void InternalGetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002DCF File Offset: 0x00000FCF
		public static void InternalSetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegateField(ref _unity_self, index, ref rot);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002DDE File Offset: 0x00000FDE
		public static void InternalGetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002DED File Offset: 0x00000FED
		public static void InternalSetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002DFC File Offset: 0x00000FFC
		public static void InternalGetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalRotation_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002E0B File Offset: 0x0000100B
		public static void InternalSetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalRotation_InjectedDelegateField(ref _unity_self, index, ref rot);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002E1A File Offset: 0x0000101A
		public static void InternalSetGoalWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002E29 File Offset: 0x00001029
		public static void InternalSetGoalWeightRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002E38 File Offset: 0x00001038
		public static float InternalGetGoalWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002E46 File Offset: 0x00001046
		public static float InternalGetGoalWeightRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002E54 File Offset: 0x00001054
		public static void InternalGetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetHintPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002E63 File Offset: 0x00001063
		public static void InternalSetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetHintPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002E72 File Offset: 0x00001072
		public static void InternalSetHintWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, float value)
		{
			AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002E81 File Offset: 0x00001081
		public static float InternalGetHintWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index)
		{
			return AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002E8F File Offset: 0x0000108F
		public static void InternalSetLookAtPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 lookAtPosition)
		{
			AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegateField(ref _unity_self, ref lookAtPosition);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002E9D File Offset: 0x0000109D
		public static void InternalSetLookAtClampWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002EAB File Offset: 0x000010AB
		public static void InternalSetLookAtBodyWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002EB9 File Offset: 0x000010B9
		public static void InternalSetLookAtHeadWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002EC7 File Offset: 0x000010C7
		public static void InternalSetLookAtEyesWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002ED5 File Offset: 0x000010D5
		public static void InternalSolveIK_Injected(ref AnimationHumanStream _unity_self)
		{
			AnimationHumanStream.InternalSolveIK_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040002B7 RID: 695
		[FieldOffset(0)]
		public IntPtr stream;

		// Token: 0x040002B8 RID: 696
		private static readonly AnimationHumanStream.GetHumanScale_InjectedDelegate GetHumanScale_InjectedDelegateField;

		// Token: 0x040002B9 RID: 697
		private static readonly AnimationHumanStream.GetFootHeight_InjectedDelegate GetFootHeight_InjectedDelegateField;

		// Token: 0x040002BA RID: 698
		private static readonly AnimationHumanStream.InternalResetToStancePose_InjectedDelegate InternalResetToStancePose_InjectedDelegateField;

		// Token: 0x040002BB RID: 699
		private static readonly AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegate InternalGetGoalPositionFromPose_InjectedDelegateField;

		// Token: 0x040002BC RID: 700
		private static readonly AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegate InternalGetGoalRotationFromPose_InjectedDelegateField;

		// Token: 0x040002BD RID: 701
		private static readonly AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegate InternalGetBodyLocalPosition_InjectedDelegateField;

		// Token: 0x040002BE RID: 702
		private static readonly AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegate InternalSetBodyLocalPosition_InjectedDelegateField;

		// Token: 0x040002BF RID: 703
		private static readonly AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegate InternalGetBodyLocalRotation_InjectedDelegateField;

		// Token: 0x040002C0 RID: 704
		private static readonly AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegate InternalSetBodyLocalRotation_InjectedDelegateField;

		// Token: 0x040002C1 RID: 705
		private static readonly AnimationHumanStream.InternalGetBodyPosition_InjectedDelegate InternalGetBodyPosition_InjectedDelegateField;

		// Token: 0x040002C2 RID: 706
		private static readonly AnimationHumanStream.InternalSetBodyPosition_InjectedDelegate InternalSetBodyPosition_InjectedDelegateField;

		// Token: 0x040002C3 RID: 707
		private static readonly AnimationHumanStream.InternalGetBodyRotation_InjectedDelegate InternalGetBodyRotation_InjectedDelegateField;

		// Token: 0x040002C4 RID: 708
		private static readonly AnimationHumanStream.InternalSetBodyRotation_InjectedDelegate InternalSetBodyRotation_InjectedDelegateField;

		// Token: 0x040002C5 RID: 709
		private static readonly AnimationHumanStream.GetLeftFootVelocity_InjectedDelegate GetLeftFootVelocity_InjectedDelegateField;

		// Token: 0x040002C6 RID: 710
		private static readonly AnimationHumanStream.GetRightFootVelocity_InjectedDelegate GetRightFootVelocity_InjectedDelegateField;

		// Token: 0x040002C7 RID: 711
		private static readonly AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegate InternalGetGoalLocalPosition_InjectedDelegateField;

		// Token: 0x040002C8 RID: 712
		private static readonly AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegate InternalSetGoalLocalPosition_InjectedDelegateField;

		// Token: 0x040002C9 RID: 713
		private static readonly AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegate InternalGetGoalLocalRotation_InjectedDelegateField;

		// Token: 0x040002CA RID: 714
		private static readonly AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegate InternalSetGoalLocalRotation_InjectedDelegateField;

		// Token: 0x040002CB RID: 715
		private static readonly AnimationHumanStream.InternalGetGoalPosition_InjectedDelegate InternalGetGoalPosition_InjectedDelegateField;

		// Token: 0x040002CC RID: 716
		private static readonly AnimationHumanStream.InternalSetGoalPosition_InjectedDelegate InternalSetGoalPosition_InjectedDelegateField;

		// Token: 0x040002CD RID: 717
		private static readonly AnimationHumanStream.InternalGetGoalRotation_InjectedDelegate InternalGetGoalRotation_InjectedDelegateField;

		// Token: 0x040002CE RID: 718
		private static readonly AnimationHumanStream.InternalSetGoalRotation_InjectedDelegate InternalSetGoalRotation_InjectedDelegateField;

		// Token: 0x040002CF RID: 719
		private static readonly AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegate InternalSetGoalWeightPosition_InjectedDelegateField;

		// Token: 0x040002D0 RID: 720
		private static readonly AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegate InternalSetGoalWeightRotation_InjectedDelegateField;

		// Token: 0x040002D1 RID: 721
		private static readonly AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegate InternalGetGoalWeightPosition_InjectedDelegateField;

		// Token: 0x040002D2 RID: 722
		private static readonly AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegate InternalGetGoalWeightRotation_InjectedDelegateField;

		// Token: 0x040002D3 RID: 723
		private static readonly AnimationHumanStream.InternalGetHintPosition_InjectedDelegate InternalGetHintPosition_InjectedDelegateField;

		// Token: 0x040002D4 RID: 724
		private static readonly AnimationHumanStream.InternalSetHintPosition_InjectedDelegate InternalSetHintPosition_InjectedDelegateField;

		// Token: 0x040002D5 RID: 725
		private static readonly AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegate InternalSetHintWeightPosition_InjectedDelegateField;

		// Token: 0x040002D6 RID: 726
		private static readonly AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegate InternalGetHintWeightPosition_InjectedDelegateField;

		// Token: 0x040002D7 RID: 727
		private static readonly AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegate InternalSetLookAtPosition_InjectedDelegateField;

		// Token: 0x040002D8 RID: 728
		private static readonly AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegate InternalSetLookAtClampWeight_InjectedDelegateField;

		// Token: 0x040002D9 RID: 729
		private static readonly AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegate InternalSetLookAtBodyWeight_InjectedDelegateField;

		// Token: 0x040002DA RID: 730
		private static readonly AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegate InternalSetLookAtHeadWeight_InjectedDelegateField;

		// Token: 0x040002DB RID: 731
		private static readonly AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegate InternalSetLookAtEyesWeight_InjectedDelegateField;

		// Token: 0x040002DC RID: 732
		private static readonly AnimationHumanStream.InternalSolveIK_InjectedDelegate InternalSolveIK_InjectedDelegateField;

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x0600062B RID: 1579
		private delegate float GetHumanScale_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x0600062D RID: 1581
		private delegate float GetFootHeight_InjectedDelegate(IntPtr _unity_self, bool left);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x0600062F RID: 1583
		private delegate void InternalResetToStancePose_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x06000631 RID: 1585
		private delegate void InternalGetGoalPositionFromPose_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x06000633 RID: 1587
		private delegate void InternalGetGoalRotationFromPose_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x06000635 RID: 1589
		private delegate void InternalGetBodyLocalPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x06000637 RID: 1591
		private delegate void InternalSetBodyLocalPosition_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000639 RID: 1593
		private delegate void InternalGetBodyLocalRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x0600063B RID: 1595
		private delegate void InternalSetBodyLocalRotation_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x0600063D RID: 1597
		private delegate void InternalGetBodyPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x0600063F RID: 1599
		private delegate void InternalSetBodyPosition_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000641 RID: 1601
		private delegate void InternalGetBodyRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000643 RID: 1603
		private delegate void InternalSetBodyRotation_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x06000645 RID: 1605
		private delegate void GetLeftFootVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x06000647 RID: 1607
		private delegate void GetRightFootVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000649 RID: 1609
		private delegate void InternalGetGoalLocalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x0600064B RID: 1611
		private delegate void InternalSetGoalLocalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr pos);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x0600064D RID: 1613
		private delegate void InternalGetGoalLocalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x0600064F RID: 1615
		private delegate void InternalSetGoalLocalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr rot);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000651 RID: 1617
		private delegate void InternalGetGoalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000653 RID: 1619
		private delegate void InternalSetGoalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr pos);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x06000655 RID: 1621
		private delegate void InternalGetGoalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x06000657 RID: 1623
		private delegate void InternalSetGoalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr rot);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000659 RID: 1625
		private delegate void InternalSetGoalWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, float value);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x0600065B RID: 1627
		private delegate void InternalSetGoalWeightRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, float value);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x0600065D RID: 1629
		private delegate float InternalGetGoalWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x0600065F RID: 1631
		private delegate float InternalGetGoalWeightRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x06000661 RID: 1633
		private delegate void InternalGetHintPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, [Out] IntPtr ret);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000663 RID: 1635
		private delegate void InternalSetHintPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, IntPtr pos);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x06000665 RID: 1637
		private delegate void InternalSetHintWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, float value);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000667 RID: 1639
		private delegate float InternalGetHintWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000669 RID: 1641
		private delegate void InternalSetLookAtPosition_InjectedDelegate(IntPtr _unity_self, IntPtr lookAtPosition);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x0600066B RID: 1643
		private delegate void InternalSetLookAtClampWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x0600066D RID: 1645
		private delegate void InternalSetLookAtBodyWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x0600066F RID: 1647
		private delegate void InternalSetLookAtHeadWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x020000CA RID: 202
		// (Invoke) Token: 0x06000671 RID: 1649
		private delegate void InternalSetLookAtEyesWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x06000673 RID: 1651
		private delegate void InternalSolveIK_InjectedDelegate(IntPtr _unity_self);
	}
}
