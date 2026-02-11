using System;
using DG.Tweening.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x0200003C RID: 60
	public class IPlugSetter<T1, T2, TPlugin, TPlugOptions> : Il2CppObjectBase
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0001728C File Offset: 0x0001548C
		// Note: this type is marked as 'beforefieldinit'.
		static IPlugSetter()
		{
			Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "IPlugSetter`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugin>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			})).TypeHandle.value);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Getter_Public_Abstract_Virtual_New_DOGetter_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664098);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Setter_Public_Abstract_Virtual_New_DOSetter_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664099);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_EndValue_Public_Abstract_Virtual_New_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664100);
			IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_GetOptions_Public_Abstract_Virtual_New_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlugSetter<T1, T2, TPlugin, TPlugOptions>>.NativeClassPtr, 100664101);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00017374 File Offset: 0x00015574
		[CallerCount(0)]
		public unsafe virtual DOGetter<T1> Getter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Getter_Public_Abstract_Virtual_New_DOGetter_1_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DOGetter<T1>>(intPtr3) : null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000173C0 File Offset: 0x000155C0
		[CallerCount(0)]
		public unsafe virtual DOSetter<T1> Setter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_Setter_Public_Abstract_Virtual_New_DOSetter_1_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DOSetter<T1>>(intPtr3) : null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001740C File Offset: 0x0001560C
		[CallerCount(0)]
		public unsafe virtual T2 EndValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_EndValue_Public_Abstract_Virtual_New_T2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00017450 File Offset: 0x00015650
		[CallerCount(0)]
		public unsafe virtual TPlugOptions GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlugSetter<T1, T2, TPlugin, TPlugOptions>.NativeMethodInfoPtr_GetOptions_Public_Abstract_Virtual_New_TPlugOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TPlugOptions>(intPtr, false, true);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000030C7 File Offset: 0x000012C7
		public IPlugSetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_Getter_Public_Abstract_Virtual_New_DOGetter_1_T1_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Setter_Public_Abstract_Virtual_New_DOSetter_1_T1_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_EndValue_Public_Abstract_Virtual_New_T2_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Public_Abstract_Virtual_New_TPlugOptions_0;
	}
}
