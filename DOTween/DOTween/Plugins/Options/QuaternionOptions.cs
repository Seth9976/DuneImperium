using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000031 RID: 49
	[StructLayout(2)]
	public struct QuaternionOptions
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00016A18 File Offset: 0x00014C18
		// Note: this type is marked as 'beforefieldinit'.
		static QuaternionOptions()
		{
			Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "QuaternionOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr);
			QuaternionOptions.NativeFieldInfoPtr_rotateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, "rotateMode");
			QuaternionOptions.NativeFieldInfoPtr_axisConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, "axisConstraint");
			QuaternionOptions.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, "up");
			QuaternionOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, 100664085);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00016A98 File Offset: 0x00014C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132487, XrefRangeEnd = 1132489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuaternionOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002EE8 File Offset: 0x000010E8
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QuaternionOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_rotateMode;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_axisConstraint;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002EB RID: 747
		[FieldOffset(0)]
		public RotateMode rotateMode;

		// Token: 0x040002EC RID: 748
		[FieldOffset(4)]
		public AxisConstraint axisConstraint;

		// Token: 0x040002ED RID: 749
		[FieldOffset(8)]
		public Vector3 up;
	}
}
