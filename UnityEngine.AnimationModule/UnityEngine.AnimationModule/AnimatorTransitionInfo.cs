using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	[StructLayout(2)]
	public struct AnimatorTransitionInfo
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00007BE0 File Offset: 0x00005DE0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorTransitionInfo()
		{
			Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorTransitionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr);
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_FullPath");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_UserName");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Name");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_HasFixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_HasFixedDuration");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_Duration");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_NormalizedTime");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_AnyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_AnyState");
			AnimatorTransitionInfo.NativeFieldInfoPtr_m_TransitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, "m_TransitionType");
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000240C File Offset: 0x0000060C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorTransitionInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007CB0 File Offset: 0x00005EB0
		public bool IsName(string name)
		{
			return Animator.StringToHash(name) == this.m_Name || Animator.StringToHash(name) == this.m_FullPath;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public bool IsUserName(string name)
		{
			return Animator.StringToHash(name) == this.m_UserName;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007D04 File Offset: 0x00005F04
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00007D1C File Offset: 0x00005F1C
		public int nameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00007D34 File Offset: 0x00005F34
		public int userNameHash
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007D4C File Offset: 0x00005F4C
		public DurationUnit durationUnit
		{
			get
			{
				return this.m_HasFixedDuration ? DurationUnit.Fixed : DurationUnit.Normalized;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00007D6C File Offset: 0x00005F6C
		public float duration
		{
			get
			{
				return this.m_Duration;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00007D84 File Offset: 0x00005F84
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00007D9C File Offset: 0x00005F9C
		public bool anyState
		{
			get
			{
				return this.m_AnyState;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00007DB4 File Offset: 0x00005FB4
		public bool entry
		{
			get
			{
				return (this.m_TransitionType & 2) != 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00007DD4 File Offset: 0x00005FD4
		public bool exit
		{
			get
			{
				return (this.m_TransitionType & 4) != 0;
			}
		}

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_m_FullPath;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_m_UserName;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFixedDuration;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalizedTime;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_m_AnyState;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_m_TransitionType;

		// Token: 0x040000EC RID: 236
		[FieldOffset(0)]
		public int m_FullPath;

		// Token: 0x040000ED RID: 237
		[FieldOffset(4)]
		public int m_UserName;

		// Token: 0x040000EE RID: 238
		[FieldOffset(8)]
		public int m_Name;

		// Token: 0x040000EF RID: 239
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_HasFixedDuration;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(16)]
		public float m_Duration;

		// Token: 0x040000F1 RID: 241
		[FieldOffset(20)]
		public float m_NormalizedTime;

		// Token: 0x040000F2 RID: 242
		[FieldOffset(24)]
		[MarshalAs(4)]
		public bool m_AnyState;

		// Token: 0x040000F3 RID: 243
		[FieldOffset(28)]
		public int m_TransitionType;
	}
}
