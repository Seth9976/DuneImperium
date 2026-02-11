using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C2 RID: 194
	public class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> where T : MouseCaptureEventBase<T>, new()
	{
		// Token: 0x060011A6 RID: 4518 RVA: 0x0005AA24 File Offset: 0x00058C24
		// Note: this type is marked as 'beforefieldinit'.
		static MouseCaptureEventBase()
		{
			Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseCaptureEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr);
			MouseCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr, 100665786);
			MouseCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr, 100665787);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0005AAB8 File Offset: 0x00058CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311911, XrefRangeEnd = 311913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0005AAF4 File Offset: 0x00058CF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 311914, RefRangeEnd = 311918, XrefRangeStart = 311913, XrefRangeEnd = 311914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseCaptureEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseCaptureEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public MouseCaptureEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00008DED File Offset: 0x00006FED
		public new IEventHandler relatedTarget
		{
			get
			{
				return base.relatedTarget;
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0005AB30 File Offset: 0x00058D30
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget)
		{
			return PointerCaptureEventBase<T>.GetPooled(target, relatedTarget, 0);
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
