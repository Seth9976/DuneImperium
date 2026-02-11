using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200025C RID: 604
	[StructLayout(2)]
	public struct FrameData
	{
		// Token: 0x0600296C RID: 10604 RVA: 0x000ABBC8 File Offset: 0x000A9DC8
		// Note: this type is marked as 'beforefieldinit'.
		static FrameData()
		{
			Il2CppClassPointerStore<FrameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameData>.NativeClassPtr);
			FrameData.NativeFieldInfoPtr_m_FrameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_FrameID");
			FrameData.NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_DeltaTime");
			FrameData.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Weight");
			FrameData.NativeFieldInfoPtr_m_EffectiveWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveWeight");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentDelay");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentSpeed");
			FrameData.NativeFieldInfoPtr_m_EffectiveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveSpeed");
			FrameData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Flags");
			FrameData.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Output");
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00010159 File Offset: 0x0000E359
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameData>.NativeClassPtr, ref this));
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000ABCAC File Offset: 0x000A9EAC
		public bool HasFlags(FrameData.Flags flag)
		{
			return (this.m_Flags & flag) == flag;
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x000ABCCC File Offset: 0x000A9ECC
		public ulong frameId
		{
			get
			{
				return this.m_FrameID;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000ABCE4 File Offset: 0x000A9EE4
		public float deltaTime
		{
			get
			{
				return (float)this.m_DeltaTime;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000ABD00 File Offset: 0x000A9F00
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000ABD18 File Offset: 0x000A9F18
		public float effectiveWeight
		{
			get
			{
				return this.m_EffectiveWeight;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x000ABD30 File Offset: 0x000A9F30
		public double effectiveParentDelay
		{
			get
			{
				return this.m_EffectiveParentDelay;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x000ABD48 File Offset: 0x000A9F48
		public float effectiveParentSpeed
		{
			get
			{
				return this.m_EffectiveParentSpeed;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000ABD60 File Offset: 0x000A9F60
		public float effectiveSpeed
		{
			get
			{
				return this.m_EffectiveSpeed;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x000ABD78 File Offset: 0x000A9F78
		public FrameData.EvaluationType evaluationType
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Evaluate) ? FrameData.EvaluationType.Evaluate : FrameData.EvaluationType.Playback;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000ABD98 File Offset: 0x000A9F98
		public bool seekOccurred
		{
			get
			{
				return this.HasFlags(FrameData.Flags.SeekOccured);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x000ABDB4 File Offset: 0x000A9FB4
		public bool timeLooped
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Loop);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x000ABDD0 File Offset: 0x000A9FD0
		public bool timeHeld
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Hold);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x000ABDEC File Offset: 0x000A9FEC
		public PlayableOutput output
		{
			get
			{
				return this.m_Output;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x000ABE04 File Offset: 0x000AA004
		public PlayState effectivePlayState
		{
			get
			{
				bool flag = this.HasFlags(FrameData.Flags.EffectivePlayStateDelayed);
				PlayState playState;
				if (flag)
				{
					playState = PlayState.Delayed;
				}
				else
				{
					bool flag2 = this.HasFlags(FrameData.Flags.EffectivePlayStatePlaying);
					if (flag2)
					{
						playState = PlayState.Playing;
					}
					else
					{
						playState = PlayState.Paused;
					}
				}
				return playState;
			}
		}

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameID;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeFieldInfoPtr_m_DeltaTime;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveWeight;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentDelay;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentSpeed;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveSpeed;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeFieldInfoPtr_m_Output;

		// Token: 0x040024BB RID: 9403
		[FieldOffset(0)]
		public ulong m_FrameID;

		// Token: 0x040024BC RID: 9404
		[FieldOffset(8)]
		public double m_DeltaTime;

		// Token: 0x040024BD RID: 9405
		[FieldOffset(16)]
		public float m_Weight;

		// Token: 0x040024BE RID: 9406
		[FieldOffset(20)]
		public float m_EffectiveWeight;

		// Token: 0x040024BF RID: 9407
		[FieldOffset(24)]
		public double m_EffectiveParentDelay;

		// Token: 0x040024C0 RID: 9408
		[FieldOffset(32)]
		public float m_EffectiveParentSpeed;

		// Token: 0x040024C1 RID: 9409
		[FieldOffset(36)]
		public float m_EffectiveSpeed;

		// Token: 0x040024C2 RID: 9410
		[FieldOffset(40)]
		public FrameData.Flags m_Flags;

		// Token: 0x040024C3 RID: 9411
		[FieldOffset(48)]
		public PlayableOutput m_Output;

		// Token: 0x02000A03 RID: 2563
		[Flags]
		public enum Flags
		{
			// Token: 0x04002D45 RID: 11589
			Evaluate = 1,
			// Token: 0x04002D46 RID: 11590
			SeekOccured = 2,
			// Token: 0x04002D47 RID: 11591
			Loop = 4,
			// Token: 0x04002D48 RID: 11592
			Hold = 8,
			// Token: 0x04002D49 RID: 11593
			EffectivePlayStateDelayed = 16,
			// Token: 0x04002D4A RID: 11594
			EffectivePlayStatePlaying = 32
		}

		// Token: 0x02000A04 RID: 2564
		public enum EvaluationType
		{
			// Token: 0x04002D4C RID: 11596
			Evaluate,
			// Token: 0x04002D4D RID: 11597
			Playback
		}
	}
}
