using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000031 RID: 49
	[StructLayout(2)]
	public struct AnimationStream
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationStream()
		{
			Il2CppClassPointerStore<AnimationStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr);
			AnimationStream.NativeFieldInfoPtr_m_AnimatorBindingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "m_AnimatorBindingsVersion");
			AnimationStream.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "constant");
			AnimationStream.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "input");
			AnimationStream.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "output");
			AnimationStream.NativeFieldInfoPtr_workspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "workspace");
			AnimationStream.NativeFieldInfoPtr_inputStreamAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "inputStreamAccessor");
			AnimationStream.NativeFieldInfoPtr_animationHandleBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "animationHandleBinder");
			AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationStream::CopyAnimationStreamMotionInternal_Injected");
			AnimationStream.GetDeltaTime_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetDeltaTime_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected");
			AnimationStream.GetIsHumanStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetIsHumanStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetIsHumanStream_Injected");
			AnimationStream.GetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetVelocity_Injected");
			AnimationStream.SetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.SetVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::SetVelocity_Injected");
			AnimationStream.GetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetAngularVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetAngularVelocity_Injected");
			AnimationStream.SetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.SetAngularVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::SetAngularVelocity_Injected");
			AnimationStream.GetRootMotionPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetRootMotionPosition_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetRootMotionPosition_Injected");
			AnimationStream.GetRootMotionRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetRootMotionRotation_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetRootMotionRotation_Injected");
			AnimationStream.GetInputStreamCount_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetInputStreamCount_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetInputStreamCount_Injected");
			AnimationStream.InternalGetInputStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalGetInputStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalGetInputStream_Injected");
			AnimationStream.InternalGetInputWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalGetInputWeight_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalGetInputWeight_Injected");
			AnimationStream.GetHumanStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetHumanStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetHumanStream_Injected");
			AnimationStream.InternalReadSceneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalReadSceneTransforms_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalReadSceneTransforms_Injected");
			AnimationStream.InternalWriteSceneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalWriteSceneTransforms_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalWriteSceneTransforms_Injected");
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000323B File Offset: 0x0000143B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00011C68 File Offset: 0x0000FE68
		public uint animatorBindingsVersion
		{
			get
			{
				return this.m_AnimatorBindingsVersion;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00011C80 File Offset: 0x0000FE80
		public bool isValid
		{
			get
			{
				return this.m_AnimatorBindingsVersion >= 2U && this.constant != IntPtr.Zero && this.input != IntPtr.Zero && this.output != IntPtr.Zero && this.workspace != IntPtr.Zero && this.animationHandleBinder != IntPtr.Zero;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		public void CheckIsValid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new InvalidOperationException("The AnimationStream is invalid.");
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00011D20 File Offset: 0x0000FF20
		public float deltaTime
		{
			get
			{
				this.CheckIsValid();
				return this.GetDeltaTime();
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00011D40 File Offset: 0x0000FF40
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000324D File Offset: 0x0000144D
		public Vector3 velocity
		{
			get
			{
				this.CheckIsValid();
				return this.GetVelocity();
			}
			set
			{
				this.CheckIsValid();
				this.SetVelocity(value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00011D60 File Offset: 0x0000FF60
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000325F File Offset: 0x0000145F
		public Vector3 angularVelocity
		{
			get
			{
				this.CheckIsValid();
				return this.GetAngularVelocity();
			}
			set
			{
				this.CheckIsValid();
				this.SetAngularVelocity(value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00011D80 File Offset: 0x0000FF80
		public Vector3 rootMotionPosition
		{
			get
			{
				this.CheckIsValid();
				return this.GetRootMotionPosition();
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		public Quaternion rootMotionRotation
		{
			get
			{
				this.CheckIsValid();
				return this.GetRootMotionRotation();
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		public bool isHumanStream
		{
			get
			{
				this.CheckIsValid();
				return this.GetIsHumanStream();
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		public AnimationHumanStream AsHuman()
		{
			this.CheckIsValid();
			bool flag = !this.GetIsHumanStream();
			if (flag)
			{
				throw new InvalidOperationException("Cannot create an AnimationHumanStream for a generic rig.");
			}
			return this.GetHumanStream();
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00011E18 File Offset: 0x00010018
		public int inputStreamCount
		{
			get
			{
				this.CheckIsValid();
				return this.GetInputStreamCount();
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00011E38 File Offset: 0x00010038
		public AnimationStream GetInputStream(int index)
		{
			this.CheckIsValid();
			return this.InternalGetInputStream(index);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00011E58 File Offset: 0x00010058
		public float GetInputWeight(int index)
		{
			this.CheckIsValid();
			return this.InternalGetInputWeight(index);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003271 File Offset: 0x00001471
		public void CopyAnimationStreamMotion(AnimationStream animationStream)
		{
			this.CheckIsValid();
			animationStream.CheckIsValid();
			this.CopyAnimationStreamMotionInternal(animationStream);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000328B File Offset: 0x0000148B
		public void ReadSceneTransforms()
		{
			this.CheckIsValid();
			this.InternalReadSceneTransforms();
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000329C File Offset: 0x0000149C
		public void WriteSceneTransforms()
		{
			this.CheckIsValid();
			this.InternalWriteSceneTransforms();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000032AD File Offset: 0x000014AD
		public void CopyAnimationStreamMotionInternal(AnimationStream animationStream)
		{
			AnimationStream.CopyAnimationStreamMotionInternal_Injected(ref this, ref animationStream);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000032B7 File Offset: 0x000014B7
		public float GetDeltaTime()
		{
			return AnimationStream.GetDeltaTime_Injected(ref this);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000032BF File Offset: 0x000014BF
		public bool GetIsHumanStream()
		{
			return AnimationStream.GetIsHumanStream_Injected(ref this);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00011E78 File Offset: 0x00010078
		public Vector3 GetVelocity()
		{
			Vector3 vector;
			AnimationStream.GetVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000032C7 File Offset: 0x000014C7
		public void SetVelocity(Vector3 velocity)
		{
			AnimationStream.SetVelocity_Injected(ref this, ref velocity);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00011E90 File Offset: 0x00010090
		public Vector3 GetAngularVelocity()
		{
			Vector3 vector;
			AnimationStream.GetAngularVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000032D1 File Offset: 0x000014D1
		public void SetAngularVelocity(Vector3 velocity)
		{
			AnimationStream.SetAngularVelocity_Injected(ref this, ref velocity);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00011EA8 File Offset: 0x000100A8
		public Vector3 GetRootMotionPosition()
		{
			Vector3 vector;
			AnimationStream.GetRootMotionPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00011EC0 File Offset: 0x000100C0
		public Quaternion GetRootMotionRotation()
		{
			Quaternion quaternion;
			AnimationStream.GetRootMotionRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000032DB File Offset: 0x000014DB
		public int GetInputStreamCount()
		{
			return AnimationStream.GetInputStreamCount_Injected(ref this);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00011ED8 File Offset: 0x000100D8
		public AnimationStream InternalGetInputStream(int index)
		{
			AnimationStream animationStream;
			AnimationStream.InternalGetInputStream_Injected(ref this, index, out animationStream);
			return animationStream;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000032E3 File Offset: 0x000014E3
		public float InternalGetInputWeight(int index)
		{
			return AnimationStream.InternalGetInputWeight_Injected(ref this, index);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00011EF0 File Offset: 0x000100F0
		public AnimationHumanStream GetHumanStream()
		{
			AnimationHumanStream animationHumanStream;
			AnimationStream.GetHumanStream_Injected(ref this, out animationHumanStream);
			return animationHumanStream;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000032EC File Offset: 0x000014EC
		public void InternalReadSceneTransforms()
		{
			AnimationStream.InternalReadSceneTransforms_Injected(ref this);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000032F4 File Offset: 0x000014F4
		public void InternalWriteSceneTransforms()
		{
			AnimationStream.InternalWriteSceneTransforms_Injected(ref this);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000032FC File Offset: 0x000014FC
		public static void CopyAnimationStreamMotionInternal_Injected(ref AnimationStream _unity_self, ref AnimationStream animationStream)
		{
			AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegateField(ref _unity_self, ref animationStream);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000330A File Offset: 0x0000150A
		public static float GetDeltaTime_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetDeltaTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003317 File Offset: 0x00001517
		public static bool GetIsHumanStream_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetIsHumanStream_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003324 File Offset: 0x00001524
		public static void GetVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00003332 File Offset: 0x00001532
		public static void SetVelocity_Injected(ref AnimationStream _unity_self, ref Vector3 velocity)
		{
			AnimationStream.SetVelocity_InjectedDelegateField(ref _unity_self, ref velocity);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003340 File Offset: 0x00001540
		public static void GetAngularVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetAngularVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000334E File Offset: 0x0000154E
		public static void SetAngularVelocity_Injected(ref AnimationStream _unity_self, ref Vector3 velocity)
		{
			AnimationStream.SetAngularVelocity_InjectedDelegateField(ref _unity_self, ref velocity);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000335C File Offset: 0x0000155C
		public static void GetRootMotionPosition_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetRootMotionPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000336A File Offset: 0x0000156A
		public static void GetRootMotionRotation_Injected(ref AnimationStream _unity_self, out Quaternion ret)
		{
			AnimationStream.GetRootMotionRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003378 File Offset: 0x00001578
		public static int GetInputStreamCount_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetInputStreamCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00003385 File Offset: 0x00001585
		public static void InternalGetInputStream_Injected(ref AnimationStream _unity_self, int index, out AnimationStream ret)
		{
			AnimationStream.InternalGetInputStream_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003394 File Offset: 0x00001594
		public static float InternalGetInputWeight_Injected(ref AnimationStream _unity_self, int index)
		{
			return AnimationStream.InternalGetInputWeight_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000033A2 File Offset: 0x000015A2
		public static void GetHumanStream_Injected(ref AnimationStream _unity_self, out AnimationHumanStream ret)
		{
			AnimationStream.GetHumanStream_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000033B0 File Offset: 0x000015B0
		public static void InternalReadSceneTransforms_Injected(ref AnimationStream _unity_self)
		{
			AnimationStream.InternalReadSceneTransforms_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000033BD File Offset: 0x000015BD
		public static void InternalWriteSceneTransforms_Injected(ref AnimationStream _unity_self)
		{
			AnimationStream.InternalWriteSceneTransforms_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorBindingsVersion;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_constant;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_workspace;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_inputStreamAccessor;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_animationHandleBinder;

		// Token: 0x0400032B RID: 811
		[FieldOffset(0)]
		public uint m_AnimatorBindingsVersion;

		// Token: 0x0400032C RID: 812
		[FieldOffset(8)]
		public IntPtr constant;

		// Token: 0x0400032D RID: 813
		[FieldOffset(16)]
		public IntPtr input;

		// Token: 0x0400032E RID: 814
		[FieldOffset(24)]
		public IntPtr output;

		// Token: 0x0400032F RID: 815
		[FieldOffset(32)]
		public IntPtr workspace;

		// Token: 0x04000330 RID: 816
		[FieldOffset(40)]
		public IntPtr inputStreamAccessor;

		// Token: 0x04000331 RID: 817
		[FieldOffset(48)]
		public IntPtr animationHandleBinder;

		// Token: 0x04000332 RID: 818
		public const int InvalidIndex = -1;

		// Token: 0x04000333 RID: 819
		private static readonly AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegate CopyAnimationStreamMotionInternal_InjectedDelegateField;

		// Token: 0x04000334 RID: 820
		private static readonly AnimationStream.GetDeltaTime_InjectedDelegate GetDeltaTime_InjectedDelegateField;

		// Token: 0x04000335 RID: 821
		private static readonly AnimationStream.GetIsHumanStream_InjectedDelegate GetIsHumanStream_InjectedDelegateField;

		// Token: 0x04000336 RID: 822
		private static readonly AnimationStream.GetVelocity_InjectedDelegate GetVelocity_InjectedDelegateField;

		// Token: 0x04000337 RID: 823
		private static readonly AnimationStream.SetVelocity_InjectedDelegate SetVelocity_InjectedDelegateField;

		// Token: 0x04000338 RID: 824
		private static readonly AnimationStream.GetAngularVelocity_InjectedDelegate GetAngularVelocity_InjectedDelegateField;

		// Token: 0x04000339 RID: 825
		private static readonly AnimationStream.SetAngularVelocity_InjectedDelegate SetAngularVelocity_InjectedDelegateField;

		// Token: 0x0400033A RID: 826
		private static readonly AnimationStream.GetRootMotionPosition_InjectedDelegate GetRootMotionPosition_InjectedDelegateField;

		// Token: 0x0400033B RID: 827
		private static readonly AnimationStream.GetRootMotionRotation_InjectedDelegate GetRootMotionRotation_InjectedDelegateField;

		// Token: 0x0400033C RID: 828
		private static readonly AnimationStream.GetInputStreamCount_InjectedDelegate GetInputStreamCount_InjectedDelegateField;

		// Token: 0x0400033D RID: 829
		private static readonly AnimationStream.InternalGetInputStream_InjectedDelegate InternalGetInputStream_InjectedDelegateField;

		// Token: 0x0400033E RID: 830
		private static readonly AnimationStream.InternalGetInputWeight_InjectedDelegate InternalGetInputWeight_InjectedDelegateField;

		// Token: 0x0400033F RID: 831
		private static readonly AnimationStream.GetHumanStream_InjectedDelegate GetHumanStream_InjectedDelegateField;

		// Token: 0x04000340 RID: 832
		private static readonly AnimationStream.InternalReadSceneTransforms_InjectedDelegate InternalReadSceneTransforms_InjectedDelegateField;

		// Token: 0x04000341 RID: 833
		private static readonly AnimationStream.InternalWriteSceneTransforms_InjectedDelegate InternalWriteSceneTransforms_InjectedDelegateField;

		// Token: 0x020000E6 RID: 230
		// (Invoke) Token: 0x060006A9 RID: 1705
		private delegate void CopyAnimationStreamMotionInternal_InjectedDelegate(IntPtr _unity_self, IntPtr animationStream);

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x060006AB RID: 1707
		private delegate float GetDeltaTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x060006AD RID: 1709
		private delegate bool GetIsHumanStream_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x060006AF RID: 1711
		private delegate void GetVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x060006B1 RID: 1713
		private delegate void SetVelocity_InjectedDelegate(IntPtr _unity_self, IntPtr velocity);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x060006B3 RID: 1715
		private delegate void GetAngularVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000EC RID: 236
		// (Invoke) Token: 0x060006B5 RID: 1717
		private delegate void SetAngularVelocity_InjectedDelegate(IntPtr _unity_self, IntPtr velocity);

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x060006B7 RID: 1719
		private delegate void GetRootMotionPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000EE RID: 238
		// (Invoke) Token: 0x060006B9 RID: 1721
		private delegate void GetRootMotionRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x060006BB RID: 1723
		private delegate int GetInputStreamCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020000F0 RID: 240
		// (Invoke) Token: 0x060006BD RID: 1725
		private delegate void InternalGetInputStream_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060006BF RID: 1727
		private delegate float InternalGetInputWeight_InjectedDelegate(IntPtr _unity_self, int index);

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x060006C1 RID: 1729
		private delegate void GetHumanStream_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x060006C3 RID: 1731
		private delegate void InternalReadSceneTransforms_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020000F4 RID: 244
		// (Invoke) Token: 0x060006C5 RID: 1733
		private delegate void InternalWriteSceneTransforms_InjectedDelegate(IntPtr _unity_self);
	}
}
