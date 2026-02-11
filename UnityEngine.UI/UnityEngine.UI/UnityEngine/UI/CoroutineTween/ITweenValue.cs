using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000047 RID: 71
	public class ITweenValue : Il2CppObjectBase
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x000282C4 File Offset: 0x000264C4
		// Note: this type is marked as 'beforefieldinit'.
		static ITweenValue()
		{
			Il2CppClassPointerStore<ITweenValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "ITweenValue");
			ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664666);
			ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664667);
			ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664668);
			ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664669);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0002833C File Offset: 0x0002653C
		[CallerCount(0)]
		public unsafe virtual void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00028388 File Offset: 0x00026588
		public unsafe virtual bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000283D0 File Offset: 0x000265D0
		public unsafe virtual float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00028418 File Offset: 0x00026618
		[CallerCount(0)]
		public unsafe virtual bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00004E1C File Offset: 0x0000301C
		public ITweenValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0;
	}
}
