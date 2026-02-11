using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	[StructLayout(2)]
	public struct AnimatorStateInfo
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x000079A8 File Offset: 0x00005BA8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorStateInfo()
		{
			Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorStateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr);
			AnimatorStateInfo.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Name");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Path");
			AnimatorStateInfo.NativeFieldInfoPtr_m_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_FullPath");
			AnimatorStateInfo.NativeFieldInfoPtr_m_NormalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_NormalizedTime");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Length");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Speed");
			AnimatorStateInfo.NativeFieldInfoPtr_m_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_SpeedMultiplier");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Tag");
			AnimatorStateInfo.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, "m_Loop");
			AnimatorStateInfo.NativeMethodInfoPtr_IsName_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1219731, RefRangeEnd = 1219732, XrefRangeStart = 1219729, XrefRangeEnd = 1219731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorStateInfo.NativeMethodInfoPtr_IsName_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000023FA File Offset: 0x000005FA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorStateInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public int fullPathHash
		{
			get
			{
				return this.m_FullPath;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007AFC File Offset: 0x00005CFC
		public int nameHash
		{
			get
			{
				return this.m_Path;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00007B14 File Offset: 0x00005D14
		public int shortNameHash
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00007B2C File Offset: 0x00005D2C
		public float normalizedTime
		{
			get
			{
				return this.m_NormalizedTime;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00007B44 File Offset: 0x00005D44
		public float length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00007B5C File Offset: 0x00005D5C
		public float speed
		{
			get
			{
				return this.m_Speed;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00007B74 File Offset: 0x00005D74
		public float speedMultiplier
		{
			get
			{
				return this.m_SpeedMultiplier;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00007B8C File Offset: 0x00005D8C
		public int tagHash
		{
			get
			{
				return this.m_Tag;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public bool IsTag(string tag)
		{
			return Animator.StringToHash(tag) == this.m_Tag;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00007BC4 File Offset: 0x00005DC4
		public bool loop
		{
			get
			{
				return this.m_Loop != 0;
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_m_Path;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_m_FullPath;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalizedTime;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_m_Speed;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_m_SpeedMultiplier;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_m_Tag;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_IsName_Public_Boolean_String_0;

		// Token: 0x040000DB RID: 219
		[FieldOffset(0)]
		public int m_Name;

		// Token: 0x040000DC RID: 220
		[FieldOffset(4)]
		public int m_Path;

		// Token: 0x040000DD RID: 221
		[FieldOffset(8)]
		public int m_FullPath;

		// Token: 0x040000DE RID: 222
		[FieldOffset(12)]
		public float m_NormalizedTime;

		// Token: 0x040000DF RID: 223
		[FieldOffset(16)]
		public float m_Length;

		// Token: 0x040000E0 RID: 224
		[FieldOffset(20)]
		public float m_Speed;

		// Token: 0x040000E1 RID: 225
		[FieldOffset(24)]
		public float m_SpeedMultiplier;

		// Token: 0x040000E2 RID: 226
		[FieldOffset(28)]
		public int m_Tag;

		// Token: 0x040000E3 RID: 227
		[FieldOffset(32)]
		public int m_Loop;
	}
}
