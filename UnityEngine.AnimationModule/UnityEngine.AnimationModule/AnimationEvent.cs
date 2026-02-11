using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public sealed class AnimationEvent : Object
	{
		// Token: 0x0600006E RID: 110 RVA: 0x000068CC File Offset: 0x00004ACC
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationEvent()
		{
			Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr);
			AnimationEvent.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_Time");
			AnimationEvent.NativeFieldInfoPtr_m_FunctionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_FunctionName");
			AnimationEvent.NativeFieldInfoPtr_m_StringParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_StringParameter");
			AnimationEvent.NativeFieldInfoPtr_m_ObjectReferenceParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_ObjectReferenceParameter");
			AnimationEvent.NativeFieldInfoPtr_m_FloatParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_FloatParameter");
			AnimationEvent.NativeFieldInfoPtr_m_IntParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_IntParameter");
			AnimationEvent.NativeFieldInfoPtr_m_MessageOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_MessageOptions");
			AnimationEvent.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_Source");
			AnimationEvent.NativeFieldInfoPtr_m_StateSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_StateSender");
			AnimationEvent.NativeFieldInfoPtr_m_AnimatorStateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_AnimatorStateInfo");
			AnimationEvent.NativeFieldInfoPtr_m_AnimatorClipInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, "m_AnimatorClipInfo");
			AnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr, 100663378);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000069EC File Offset: 0x00004BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219641, XrefRangeEnd = 1219651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000224D File Offset: 0x0000044D
		public AnimationEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00006A28 File Offset: 0x00004C28
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002256 File Offset: 0x00000456
		public unsafe float m_Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Time)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002271 File Offset: 0x00000471
		public unsafe string m_FunctionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FunctionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FunctionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00006A78 File Offset: 0x00004C78
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002290 File Offset: 0x00000490
		public unsafe string m_StringParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StringParameter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StringParameter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00006AA0 File Offset: 0x00004CA0
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000022AF File Offset: 0x000004AF
		public unsafe Object m_ObjectReferenceParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_ObjectReferenceParameter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_ObjectReferenceParameter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00006AD0 File Offset: 0x00004CD0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000022CE File Offset: 0x000004CE
		public unsafe float m_FloatParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FloatParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_FloatParameter)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00006AF8 File Offset: 0x00004CF8
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000022E9 File Offset: 0x000004E9
		public unsafe int m_IntParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_IntParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_IntParameter)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00006B20 File Offset: 0x00004D20
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002304 File Offset: 0x00000504
		public unsafe int m_MessageOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_MessageOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_MessageOptions)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00006B48 File Offset: 0x00004D48
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000231F File Offset: 0x0000051F
		public unsafe AnimationEventSource m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_Source)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00006B70 File Offset: 0x00004D70
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000233A File Offset: 0x0000053A
		public unsafe AnimationState m_StateSender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StateSender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_StateSender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00006BA0 File Offset: 0x00004DA0
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe AnimatorStateInfo m_AnimatorStateInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorStateInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorStateInfo)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006BC8 File Offset: 0x00004DC8
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002374 File Offset: 0x00000574
		public unsafe AnimatorClipInfo m_AnimatorClipInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorClipInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationEvent.NativeFieldInfoPtr_m_AnimatorClipInfo)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00006BF0 File Offset: 0x00004DF0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000238F File Offset: 0x0000058F
		public string data
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006C08 File Offset: 0x00004E08
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002399 File Offset: 0x00000599
		public string stringParameter
		{
			get
			{
				return this.m_StringParameter;
			}
			set
			{
				this.m_StringParameter = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00006C20 File Offset: 0x00004E20
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000023A3 File Offset: 0x000005A3
		public float floatParameter
		{
			get
			{
				return this.m_FloatParameter;
			}
			set
			{
				this.m_FloatParameter = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006C38 File Offset: 0x00004E38
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000023AD File Offset: 0x000005AD
		public int intParameter
		{
			get
			{
				return this.m_IntParameter;
			}
			set
			{
				this.m_IntParameter = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00006C50 File Offset: 0x00004E50
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000023B7 File Offset: 0x000005B7
		public Object objectReferenceParameter
		{
			get
			{
				return this.m_ObjectReferenceParameter;
			}
			set
			{
				this.m_ObjectReferenceParameter = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00006C68 File Offset: 0x00004E68
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000023C1 File Offset: 0x000005C1
		public string functionName
		{
			get
			{
				return this.m_FunctionName;
			}
			set
			{
				this.m_FunctionName = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006C80 File Offset: 0x00004E80
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000023CB File Offset: 0x000005CB
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006C98 File Offset: 0x00004E98
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000023D5 File Offset: 0x000005D5
		public SendMessageOptions messageOptions
		{
			get
			{
				return (SendMessageOptions)this.m_MessageOptions;
			}
			set
			{
				this.m_MessageOptions = (int)value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006CB0 File Offset: 0x00004EB0
		public bool isFiredByLegacy
		{
			get
			{
				return this.m_Source == AnimationEventSource.Legacy;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006CCC File Offset: 0x00004ECC
		public bool isFiredByAnimator
		{
			get
			{
				return this.m_Source == AnimationEventSource.Animator;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006CE8 File Offset: 0x00004EE8
		public AnimationState animationState
		{
			get
			{
				bool flag = !this.isFiredByLegacy;
				if (flag)
				{
					Debug.LogError("AnimationEvent was not fired by Animation component, you shouldn't use AnimationEvent.animationState");
				}
				return this.m_StateSender;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00006D18 File Offset: 0x00004F18
		public AnimatorStateInfo animatorStateInfo
		{
			get
			{
				bool flag = !this.isFiredByAnimator;
				if (flag)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorStateInfo");
				}
				return this.m_AnimatorStateInfo;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006D48 File Offset: 0x00004F48
		public AnimatorClipInfo animatorClipInfo
		{
			get
			{
				bool flag = !this.isFiredByAnimator;
				if (flag)
				{
					Debug.LogError("AnimationEvent was not fired by Animator component, you shouldn't use AnimationEvent.animatorClipInfo");
				}
				return this.m_AnimatorClipInfo;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006D78 File Offset: 0x00004F78
		public int GetHash()
		{
			int hashCode = this.functionName.GetHashCode();
			return 33 * hashCode + this.time.GetHashCode();
		}

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_FunctionName;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_m_StringParameter;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectReferenceParameter;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatParameter;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_m_IntParameter;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_m_MessageOptions;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_m_StateSender;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorStateInfo;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorClipInfo;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
