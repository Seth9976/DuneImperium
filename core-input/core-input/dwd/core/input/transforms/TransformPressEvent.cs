using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.transforms
{
	// Token: 0x02000063 RID: 99
	public class TransformPressEvent : PressEvent
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00012A40 File Offset: 0x00010C40
		// Note: this type is marked as 'beforefieldinit'.
		static TransformPressEvent()
		{
			Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.transforms", "TransformPressEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr);
			TransformPressEvent.NativeFieldInfoPtr__Transform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr, "<Transform>k__BackingField");
			TransformPressEvent.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr, 100663722);
			TransformPressEvent.NativeMethodInfoPtr_set_Transform_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr, 100663723);
			TransformPressEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr, 100663724);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00012AC0 File Offset: 0x00010CC0
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00012B00 File Offset: 0x00010D00
		public unsafe Transform Transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformPressEvent.NativeMethodInfoPtr_get_Transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformPressEvent.NativeMethodInfoPtr_set_Transform_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00012B44 File Offset: 0x00010D44
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1122097, RefRangeEnd = 1122111, XrefRangeStart = 1122082, XrefRangeEnd = 1122097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformPressEvent(Press press, Transform transform)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformPressEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformPressEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00004332 File Offset: 0x00002532
		public TransformPressEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00012BA4 File Offset: 0x00010DA4
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0000433B File Offset: 0x0000253B
		public unsafe Transform _Transform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformPressEvent.NativeFieldInfoPtr__Transform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformPressEvent.NativeFieldInfoPtr__Transform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr__Transform_k__BackingField;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_Transform_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_set_Transform_Private_set_Void_Transform_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_0;
	}
}
