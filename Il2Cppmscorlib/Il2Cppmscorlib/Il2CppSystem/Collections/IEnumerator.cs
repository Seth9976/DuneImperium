using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004BF RID: 1215
	public class IEnumerator : Il2CppObjectBase
	{
		// Token: 0x06004A71 RID: 19057 RVA: 0x0015818C File Offset: 0x0015638C
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerator()
		{
			Il2CppClassPointerStore<IEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IEnumerator");
			IEnumerator.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator>.NativeClassPtr, 100674118);
			IEnumerator.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator>.NativeClassPtr, 100674119);
			IEnumerator.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator>.NativeClassPtr, 100674120);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x001581F0 File Offset: 0x001563F0
		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x00158238 File Offset: 0x00156438
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00158284 File Offset: 0x00156484
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0001B4F2 File Offset: 0x000196F2
		public IEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003D00 RID: 15616
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;
	}
}
