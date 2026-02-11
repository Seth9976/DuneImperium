using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	[StructLayout(2)]
	public struct AnimatorClipInfo
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x000078D8 File Offset: 0x00005AD8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorClipInfo()
		{
			Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorClipInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr);
			AnimatorClipInfo.NativeFieldInfoPtr_m_ClipInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_ClipInstanceID");
			AnimatorClipInfo.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, "m_Weight");
			AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegateField = IL2CPP.ResolveICall<AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegate>("UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr");
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000023E8 File Offset: 0x000005E8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorClipInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00007940 File Offset: 0x00005B40
		public AnimationClip clip
		{
			get
			{
				return (this.m_ClipInstanceID != 0) ? AnimatorClipInfo.InstanceIDToAnimationClipPPtr(this.m_ClipInstanceID) : null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00007968 File Offset: 0x00005B68
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007980 File Offset: 0x00005B80
		public static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID)
		{
			IntPtr intPtr = AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_m_ClipInstanceID;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x040000CE RID: 206
		[FieldOffset(0)]
		public int m_ClipInstanceID;

		// Token: 0x040000CF RID: 207
		[FieldOffset(4)]
		public float m_Weight;

		// Token: 0x040000D0 RID: 208
		private static readonly AnimatorClipInfo.InstanceIDToAnimationClipPPtrDelegate InstanceIDToAnimationClipPPtrDelegateField;

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060005CB RID: 1483
		private delegate IntPtr InstanceIDToAnimationClipPPtrDelegate(int instanceID);
	}
}
