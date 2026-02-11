using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BF RID: 191
	public class PointerCaptureEventBase<T> : EventBase<T> where T : PointerCaptureEventBase<T>, new()
	{
		// Token: 0x06001192 RID: 4498 RVA: 0x0005A668 File Offset: 0x00058868
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureEventBase()
		{
			Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr);
			PointerCaptureEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, "<relatedTarget>k__BackingField");
			PointerCaptureEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665769);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665770);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665771);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665772);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665773);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665774);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100665775);
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00008D6C File Offset: 0x00006F6C
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x0005A788 File Offset: 0x00058988
		public unsafe IEventHandler relatedTarget
		{
			get
			{
				return this._relatedTarget_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x0005A7CC File Offset: 0x000589CC
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x0005A808 File Offset: 0x00058A08
		public unsafe virtual int pointerId
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0005A848 File Offset: 0x00058A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311845, RefRangeEnd = 311846, XrefRangeStart = 311839, XrefRangeEnd = 311845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0005A884 File Offset: 0x00058A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311846, XrefRangeEnd = 311851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0005A8B8 File Offset: 0x00058AB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 311860, RefRangeEnd = 311864, XrefRangeStart = 311851, XrefRangeEnd = 311860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relatedTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0005A918 File Offset: 0x00058B18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 311872, RefRangeEnd = 311877, XrefRangeStart = 311864, XrefRangeEnd = 311872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00008D29 File Offset: 0x00006F29
		public PointerCaptureEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0005A954 File Offset: 0x00058B54
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x00008D32 File Offset: 0x00006F32
		public unsafe IEventHandler _relatedTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x0005A984 File Offset: 0x00058B84
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x00008D51 File Offset: 0x00006F51
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr__relatedTarget_k__BackingField;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_IEventHandler_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_IEventHandler_Int32_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
