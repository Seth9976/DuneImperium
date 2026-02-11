using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	[StructLayout(2)]
	public struct ControlPoint
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x00017F90 File Offset: 0x00016190
		// Note: this type is marked as 'beforefieldinit'.
		static ControlPoint()
		{
			Il2CppClassPointerStore<ControlPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "ControlPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr);
			ControlPoint.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, "a");
			ControlPoint.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, "b");
			ControlPoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, 100664113);
			ControlPoint.NativeMethodInfoPtr_op_Addition_Public_Static_ControlPoint_ControlPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, 100664114);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00018010 File Offset: 0x00016210
		[CallerCount(0)]
		public unsafe ControlPoint(Vector3 a, Vector3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPoint.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00018050 File Offset: 0x00016250
		[CallerCount(0)]
		public unsafe static ControlPoint operator +(ControlPoint cp, Vector3 v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlPoint.NativeMethodInfoPtr_op_Addition_Public_Static_ControlPoint_ControlPoint_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003246 File Offset: 0x00001446
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ControlPoint_ControlPoint_Vector3_0;

		// Token: 0x04000333 RID: 819
		[FieldOffset(0)]
		public Vector3 a;

		// Token: 0x04000334 RID: 820
		[FieldOffset(12)]
		public Vector3 b;
	}
}
