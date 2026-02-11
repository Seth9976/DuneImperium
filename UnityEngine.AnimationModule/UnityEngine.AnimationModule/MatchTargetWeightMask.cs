using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	[StructLayout(2)]
	public struct MatchTargetWeightMask
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00007DF4 File Offset: 0x00005FF4
		// Note: this type is marked as 'beforefieldinit'.
		static MatchTargetWeightMask()
		{
			Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "MatchTargetWeightMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr);
			MatchTargetWeightMask.NativeFieldInfoPtr_m_PositionXYZWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, "m_PositionXYZWeight");
			MatchTargetWeightMask.NativeFieldInfoPtr_m_RotationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, "m_RotationWeight");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000241E File Offset: 0x0000061E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MatchTargetWeightMask>.NativeClassPtr, ref this));
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00007E4C File Offset: 0x0000604C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002430 File Offset: 0x00000630
		public Vector3 positionXYZWeight
		{
			get
			{
				return this.m_PositionXYZWeight;
			}
			set
			{
				this.m_PositionXYZWeight = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00007E64 File Offset: 0x00006064
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000243A File Offset: 0x0000063A
		public float rotationWeight
		{
			get
			{
				return this.m_RotationWeight;
			}
			set
			{
				this.m_RotationWeight = value;
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionXYZWeight;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_m_RotationWeight;

		// Token: 0x040000F6 RID: 246
		[FieldOffset(0)]
		public Vector3 m_PositionXYZWeight;

		// Token: 0x040000F7 RID: 247
		[FieldOffset(12)]
		public float m_RotationWeight;
	}
}
