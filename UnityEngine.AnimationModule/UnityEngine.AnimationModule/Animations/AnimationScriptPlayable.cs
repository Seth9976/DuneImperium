using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000030 RID: 48
	[StructLayout(2)]
	public struct AnimationScriptPlayable
	{
		// Token: 0x060003C1 RID: 961 RVA: 0x000117E0 File Offset: 0x0000F9E0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationScriptPlayable()
		{
			Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationScriptPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr);
			AnimationScriptPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, "m_Handle");
			AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimationScriptPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663759);
			AnimationScriptPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663760);
			AnimationScriptPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, 100663761);
			AnimationScriptPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::CreateHandleInternal_Injected");
			AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::SetProcessInputsInternal_Injected");
			AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegate>("UnityEngine.Animations.AnimationScriptPlayable::GetProcessInputsInternal_Injected");
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000118A4 File Offset: 0x0000FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220964, XrefRangeEnd = 1220973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationScriptPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000118D8 File Offset: 0x0000FAD8
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00011908 File Offset: 0x0000FB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220973, XrefRangeEnd = 1220980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimationScriptPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationScriptPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000031B6 File Offset: 0x000013B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationScriptPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00011948 File Offset: 0x0000FB48
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000031C8 File Offset: 0x000013C8
		public unsafe static AnimationScriptPlayable m_NullPlayable
		{
			get
			{
				AnimationScriptPlayable animationScriptPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animationScriptPlayable));
				return animationScriptPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationScriptPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00011964 File Offset: 0x0000FB64
		public static AnimationScriptPlayable Null
		{
			get
			{
				return AnimationScriptPlayable.m_NullPlayable;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001197C File Offset: 0x0000FB7C
		public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, [Optional] int inputCount) where T : struct
		{
			PlayableHandle playableHandle = AnimationScriptPlayable.CreateHandle<T>(graph, inputCount);
			AnimationScriptPlayable animationScriptPlayable = new AnimationScriptPlayable(playableHandle);
			animationScriptPlayable.SetJobData<T>(jobData);
			return animationScriptPlayable;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000031D6 File Offset: 0x000013D6
		public static PlayableHandle CreateHandle<T>(PlayableGraph graph, int inputCount) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000119A8 File Offset: 0x0000FBA8
		public void CheckJobTypeValidity<T>()
		{
			Type jobType = this.GetHandle().GetJobType();
			bool flag = jobType != Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			if (flag)
			{
				throw new ArgumentException(String.Format("Wrong type: the given job type ({0}) is different from the creation job type ({1}).", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName, jobType.FullName));
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00011A00 File Offset: 0x0000FC00
		public unsafe T GetJobData<T>() where T : struct
		{
			this.CheckJobTypeValidity<T>();
			T t;
			UnsafeUtility.CopyPtrToStructure<T>((void*)this.GetHandle().GetJobData(), out t);
			return t;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00011A38 File Offset: 0x0000FC38
		public unsafe void SetJobData<T>(T jobData) where T : struct
		{
			this.CheckJobTypeValidity<T>();
			UnsafeUtility.CopyStructureToPtr<T>(ref jobData, (void*)this.GetHandle().GetJobData());
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00011A68 File Offset: 0x0000FC68
		public static implicit operator Playable(AnimationScriptPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00011A88 File Offset: 0x0000FC88
		public static explicit operator AnimationScriptPlayable(Playable playable)
		{
			return new AnimationScriptPlayable(playable.GetHandle());
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000031E3 File Offset: 0x000013E3
		public void SetProcessInputs(bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal(this.GetHandle(), value);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		public bool GetProcessInputs()
		{
			return AnimationScriptPlayable.GetProcessInputsInternal(this.GetHandle());
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000031F3 File Offset: 0x000013F3
		public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return AnimationScriptPlayable.CreateHandleInternal_Injected(ref graph, ref handle, jobReflectionData);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000031FE File Offset: 0x000013FE
		public static void SetProcessInputsInternal(PlayableHandle handle, bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal_Injected(ref handle, value);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00003208 File Offset: 0x00001408
		public static bool GetProcessInputsInternal(PlayableHandle handle)
		{
			return AnimationScriptPlayable.GetProcessInputsInternal_Injected(ref handle);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00003211 File Offset: 0x00001411
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle, IntPtr jobReflectionData)
		{
			return AnimationScriptPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, ref handle, jobReflectionData);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00003220 File Offset: 0x00001420
		public static void SetProcessInputsInternal_Injected(ref PlayableHandle handle, bool value)
		{
			AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegateField(ref handle, value);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000322E File Offset: 0x0000142E
		public static bool GetProcessInputsInternal_Injected(ref PlayableHandle handle)
		{
			return AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegateField(ref handle);
		}

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationScriptPlayable_0;

		// Token: 0x04000320 RID: 800
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000321 RID: 801
		private static readonly AnimationScriptPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x04000322 RID: 802
		private static readonly AnimationScriptPlayable.SetProcessInputsInternal_InjectedDelegate SetProcessInputsInternal_InjectedDelegateField;

		// Token: 0x04000323 RID: 803
		private static readonly AnimationScriptPlayable.GetProcessInputsInternal_InjectedDelegate GetProcessInputsInternal_InjectedDelegateField;

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060006A3 RID: 1699
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr handle, IntPtr jobReflectionData);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060006A5 RID: 1701
		private delegate void SetProcessInputsInternal_InjectedDelegate(IntPtr handle, bool value);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060006A7 RID: 1703
		private delegate bool GetProcessInputsInternal_InjectedDelegate(IntPtr handle);
	}
}
